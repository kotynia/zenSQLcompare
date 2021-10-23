#zenSQLcompare Compare SQL Server schemas and create scripts "for most" differences

Getting started 
---------------
1.  Take latest release  https://github.com/marcinKotynia/zenSQLcompare/releases
2. download and install http://winmerge.org/  , adjust proper folder path 
3.  provide or paste connection strings
4.  go to tab compare database schema select "Start Compare"
5.  copy paste generated script to your favourite sql editor


Version
---------
- 1.4.0 Bug Fixes, helper Scripts (2015-08)
- 1.2.1 no additional library need, no instalation just unzip and run
- 1.2.1 Generate T-SQL scripts to update one database to match the schema of another
- 1.2.1 Save/load configuration to file
- 1.2.1 Define Excluded object list
- 1.2.1 Show difference in schema in external tool (ex. <a href="http://winmerge.org/" >http://winmerge.org/</a>)
- 1.3 Support for index compare

History
-------
This is old, ugly code and tool but it works :) first version was  created aboout 2003 in VB6 converted to .net as IS in 2008 its still useful and updated.  


zenComparer will solve most basic schema differencies including:
           
<table>
  <thead>
    <tr>
      <th>Object Type</th>
      <th>Description</th>
      <th>Repair script</th>
      <th>Display information</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Tables (U)</td>
      <td>Missing table</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missing column</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missmatched column Data type</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missmatched column character_maximum_length</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missmatched column default</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td>Scalar Funtions (FN)</td>
      <td>Missmatched Scalar Funtion</td>
      <td>YES</td>
      <td>
        <p>YES</p>
      </td>
    </tr>
    <tr>
      <td></td>
      <td>Missing Scalar Funtion</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td>Scalar Funtions (IF)</td>
      <td>Missmatched Scalar Funtion</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missing Scalar Funtion</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td>Table-valued Function (TF)</td>
      <td>Missmatched Table-valued Function</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missing Table-valued Function</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td>Procedures (P)</td>
      <td>Missmatched Procedure</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missing Procedure</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td>Triggers (TR)</td>
      <td>Missmatched Trigger</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missing Trigger</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td>Views (V)</td>
      <td>Missmatched View</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missing View</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td>Index (IX)</td>
      <td>Missmatched Index</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
    <tr>
      <td></td>
      <td>Missing Index</td>
      <td>YES</td>
      <td>YES</td>
    </tr>
  </tbody>
</table>

What zenSQLCompare will not do for you

- Solve multiple dependant problems (it will provide some helper scripts for manual adjustments)
- Create completly new table (you can always script in Managment Studio)

## Bugs

### Scenario  Comparing  
- database 1 and "Uniqued index" 
- database 2 and "Unique Key" (constraint)

will build partial script, you need to drop constraint first
```
ALTER TABLE [table name] DROP CONSTRAINT [index name] 
```


