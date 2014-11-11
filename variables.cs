
namespace zenComparer
{
    class variables
    {
        #region Sqls


        public static string sqlObjects = @"
select distinct  SCHEMA_NAME(so.schema_id) + '.'+ so.name + '|' + so.type collate polish_ci_as + '|' + type_desc + '|'
+isnull(CCU.TABLE_NAME,'') + '|' + isnull(CCU.COLUMN_NAME,'')    'key', 
so.type ,
isnull( OBJECT_DEFINITION(so.object_id),
so.type  collate polish_ci_as + '|' + so.name + '|' + type_desc + '|'
+isnull(CCU.TABLE_NAME,'') + '|' + isnull(CCU.COLUMN_NAME,'') ) text 
from sys.objects so left join 
(select * from sys.syscomments where colid=1 )  sc on  so.object_id =sc.id
left join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE CCU on 
so.name = CCU.CONSTRAINT_NAME
where 
 type not in ('D') 
and so.is_ms_shipped =0
";

        /// <summary>
        /// Query for compare views,procedures,triggers...
        /// </summary>
       public static string sqlIndex = @"

sELECT distinct --'['+Sch.name+'].['+ Tab.[name]+']' AS TableName,
Ind.[name]  +'|['+Sch.name+'].['+ Tab.[name]+']' AS [KEY],
'IX' type,
script.[CreateIndexScript] text

FROM sys.[indexes] Ind
INNER JOIN sys.[tables] AS Tab
ON Tab.[object_id] = Ind.[object_id]
INNER JOIN sys.[schemas] AS Sch
ON Sch.[schema_id] = Tab.[schema_id]
inner join 
(SELECT ' CREATE ' + 
    CASE WHEN I.is_unique = 1 THEN ' UNIQUE ' ELSE '' END  +  
    I.type_desc COLLATE DATABASE_DEFAULT +' INDEX [' +   
    I.name  + '] ON ['  +  
    Schema_name(T.Schema_id)+'].['+T.name + '] ( ' + 
    KeyColumns + ' )  ' + 
    ISNULL(' INCLUDE ('+IncludedColumns+' ) ','') + 
    ISNULL(' WHERE  '+I.Filter_definition,'') + ' WITH ( ' + 
    CASE WHEN I.is_padded = 1 THEN ' PAD_INDEX = ON ' ELSE ' PAD_INDEX = OFF ' END + ','  + 
    'FILLFACTOR = '+CONVERT(CHAR(5),CASE WHEN I.Fill_factor = 0 THEN 100 ELSE I.Fill_factor END) + ','  + 
    -- default value 
    'SORT_IN_TEMPDB = OFF '  + ','  + 
    CASE WHEN I.ignore_dup_key = 1 THEN ' IGNORE_DUP_KEY = ON ' ELSE ' IGNORE_DUP_KEY = OFF ' END + ','  + 
    CASE WHEN ST.no_recompute = 0 THEN ' STATISTICS_NORECOMPUTE = OFF ' ELSE ' STATISTICS_NORECOMPUTE = ON ' END + ','  + 
    -- default value  
    ' DROP_EXISTING = ON '  + ','  + 
    -- default value  
    ' ONLINE = OFF '  + ','  + 
   CASE WHEN I.allow_row_locks = 1 THEN ' ALLOW_ROW_LOCKS = ON ' ELSE ' ALLOW_ROW_LOCKS = OFF ' END + ','  + 
   CASE WHEN I.allow_page_locks = 1 THEN ' ALLOW_PAGE_LOCKS = ON ' ELSE ' ALLOW_PAGE_LOCKS = OFF ' END  + ' ) ON [' + 
   DS.name + ' ] '  [CreateIndexScript] , I.name
FROM sys.indexes I   
 JOIN sys.tables T ON T.Object_id = I.Object_id    
 JOIN sys.sysindexes SI ON I.Object_id = SI.id AND I.index_id = SI.indid   
 JOIN (SELECT * FROM (  
    SELECT IC2.object_id , IC2.index_id ,  
        STUFF((SELECT ' , [' + C.name +']' + CASE WHEN MAX(CONVERT(INT,IC1.is_descending_key)) = 1 THEN ' DESC ' ELSE ' ASC ' END 
    FROM sys.index_columns IC1  
    JOIN Sys.columns C   
       ON C.object_id = IC1.object_id   
       AND C.column_id = IC1.column_id   
       AND IC1.is_included_column = 0  
    WHERE IC1.object_id = IC2.object_id   
       AND IC1.index_id = IC2.index_id   
    GROUP BY IC1.object_id,C.name,index_id  
    ORDER BY MAX(IC1.key_ordinal)  
       FOR XML PATH('')), 1, 2, '') KeyColumns   
    FROM sys.index_columns IC2   
    --WHERE IC2.Object_id = object_id('Person.Address') --Comment for all tables  
    GROUP BY IC2.object_id ,IC2.index_id) tmp3 )tmp4   
  ON I.object_id = tmp4.object_id AND I.Index_id = tmp4.index_id  
 JOIN sys.stats ST ON ST.object_id = I.object_id AND ST.stats_id = I.index_id   
 JOIN sys.data_spaces DS ON I.data_space_id=DS.data_space_id   
 JOIN sys.filegroups FG ON I.data_space_id=FG.data_space_id   
 LEFT JOIN (SELECT * FROM (   
    SELECT IC2.object_id , IC2.index_id ,   
        STUFF((SELECT ' , ' + C.name  
    FROM sys.index_columns IC1   
    JOIN Sys.columns C    
       ON C.object_id = IC1.object_id    
       AND C.column_id = IC1.column_id    
       AND IC1.is_included_column = 1   
    WHERE IC1.object_id = IC2.object_id    
       AND IC1.index_id = IC2.index_id    
    GROUP BY IC1.object_id,C.name,index_id   
       FOR XML PATH('')), 1, 2, '') IncludedColumns    
   FROM sys.index_columns IC2    
   --WHERE IC2.Object_id = object_id('Person.Address') --Comment for all tables   
   GROUP BY IC2.object_id ,IC2.index_id) tmp1   
   WHERE IncludedColumns IS NOT NULL ) tmp2    
ON tmp2.object_id = I.object_id AND tmp2.index_id = I.index_id   
WHERE I.is_primary_key = 0 AND I.is_unique_constraint = 0 
--AND I.Object_id = object_id('Person.Address') --Comment for all tables 
) script on  script.name = Ind.[name] --comment for all indexes 


where Ind.[name] is not null




";
        /// <summary>
        /// Query for compare table schema
        /// </summary>
       public static string sqlTables = @"
SELECT   [text], [key], type
FROM     
          (
          SELECT  distinct    table_schema + '.[' + table_name + ']|' + column_name [key],
                    --
                    table_name,
                    'CO' type, -- zmiana U na CO czyli kolumny
                    ordinal_position,
                    table_name + '|' + column_name + '|'
                    + isnull(cast(data_type as varchar), '') + '|'
                    + isnull(cast(character_maximum_length as varchar), '')+ '|'
                    + isnull(column_default, '') +'|'
                    + cast(isnull(numeric_precision, '') as varchar(50)) + '|'
                    + cast(isnull(numeric_scale, '') as varchar(50))+ '|'
                    + IS_NULLABLE + '|' 
		    + isnull(DefaultConstraint.name, '') 
			 + isnull(cast(columnproperty(object_id(table_name), INFORMATION_SCHEMA.columns.column_name,'IsIdentity') as varchar(1)),'0') 
            + '|' + table_schema [text]
	 --columnproperty(object_id(table_name), INFORMATION_SCHEMA.columns.column_name,'IsIdentity') isIdentity
	 -- cast(ident_seed(table_name) as varchar) ident_seed, -- moze kiedys
	 -- cast(ident_incr(table_name) as varchar) ident_incr  -- moze kiedys
          FROM      INFORMATION_SCHEMA.columns inner join sysobjects
                    ON INFORMATION_SCHEMA.columns.table_name = sysobjects.name
                    left join
                    (
			SELECT OBJECT_NAME(PARENT_OBJECT_ID) TABLENAME,
			COL_NAME (PARENT_OBJECT_ID, PARENT_COLUMN_ID)COLUMNNAME ,
			NAME name
			FROM SYS.DEFAULT_CONSTRAINTS
                    ) DefaultConstraint
                    ON DefaultConstraint.ColumnName = INFORMATION_SCHEMA.columns.column_name
                    AND
                    DefaultConstraint.tablename = INFORMATION_SCHEMA.columns.table_name
          WHERE     sysobjects.xtype = 'u'
                    ) a
ORDER BY  table_name,
          ordinal_position
 ";


        /// <summary>
        /// Create table query
        /// </summary>
        public static string sqlCreateTable = @"     
select  'create table [' + so.name + '] (' + o.list + ')' + CASE WHEN tc.Constraint_Name IS NULL THEN '' ELSE 'ALTER TABLE ' + so.Name + ' ADD CONSTRAINT ' + tc.Constraint_Name  + ' PRIMARY KEY ' + ' (' + LEFT(j.List, Len(j.List)-1) + ')' END
from    sysobjects so
cross apply
    (SELECT 
        '  ['+column_name+'] ' + 
        data_type + case data_type
                when 'sql_variant' then ''
                when 'text' then ''
                when 'decimal' then '(' + cast(numeric_precision as varchar) + ', ' + cast(numeric_scale as varchar) + ')'
		when 'numeric' then '(' + cast(numeric_precision as varchar) + ', ' + cast(numeric_scale as varchar) + ')'
                else coalesce('('+case when character_maximum_length = -1 then 'MAX' else cast(character_maximum_length as varchar) end +')','') end + ' ' +
        case when exists ( 
        select id from syscolumns
        where object_name(id)=so.name
        and name=column_name
        and columnproperty(id,name,'IsIdentity') = 1 
        ) then
        'IDENTITY(' + 
        cast(ident_seed(so.name) as varchar) + ',' + 
        cast(ident_incr(so.name) as varchar) + ')'
        else ''
        end + ' ' +
         (case when IS_NULLABLE = 'No' then 'NOT ' else '' end ) + 'NULL ' + 
          case when information_schema.columns.COLUMN_DEFAULT IS NOT NULL THEN 'DEFAULT '+ information_schema.columns.COLUMN_DEFAULT ELSE '' END + ', ' 

     from information_schema.columns where table_name = so.name
     order by ordinal_position
    FOR XML PATH('')) o (list)
left join
    information_schema.table_constraints tc
on  tc.Table_name               = so.Name
AND tc.Constraint_Type  = 'PRIMARY KEY'
cross apply
    (select '[' + Column_Name + '], '
     FROM       information_schema.key_column_usage kcu
     WHERE      kcu.Constraint_Name     = tc.Constraint_Name
     ORDER BY
        ORDINAL_POSITION
     FOR XML PATH('')) j (list)
where   xtype = 'U'
AND name='{0}'";


        #endregion



        public static string scriptSeparator = "\nGO\n/*----------------------------------------NEXT ITEM---------------------------------------*/\nGO\n\n"; 
    }
}
