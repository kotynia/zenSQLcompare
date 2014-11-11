zenSQLcompare
=============
easy to use MSSQL database Schema comparision tool

Features
---------
- 1.2.1 no additional library need, no instalation just unzip and run
- 1.2.1 Generate T-SQL scripts to update one database to match the schema of another
- 1.2.1 Save/load configuration to file
- 1.2.1 Define Excluded object list
- 1.2.1 Show difference in schema in external tool (ex. <a href="http://winmerge.org/" >http://winmerge.org/</a>)
- 1.3 Support for index compare

History
-------
zenCompare was developed by me about 6 years ago (2008) but i found its still usefull so i dig this code from my old laptop and Im sharing with you :)


Scripts that zenComparer will generate for you:
           
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
