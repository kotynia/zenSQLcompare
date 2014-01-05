
namespace zenComparer
{
    class variables
    {
        #region Sqls

        /// <summary>
        /// Do porownywania widokow ,procedur funkcji,tabel, iw szystkiego co sie znajdzie
        /// Bez default constraint to jest w zapytaniu tabel
        /// </summary>
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
        /// Do porownywania tabel
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
                    lower(table_name) + '|' + lower(column_name) + '|'
                    + isnull(cast(data_type as varchar), '') + '|'
                    + isnull(cast(character_maximum_length as varchar), '')+ '|'
                    + isnull(column_default, '') +'|'
                    + cast(isnull(numeric_precision, '') as varchar(50)) + '|'
                    + cast(isnull(numeric_scale, '') as varchar(50))+ '|'
                    + IS_NULLABLE + '|' 
		    + isnull(DefaultConstraint.name, '') + '|' 
		    + cast(columnproperty(object_id(table_name), INFORMATION_SCHEMA.columns.column_name,'IsIdentity') as varchar(1)) [text]
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
        /// Create table
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
