using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace zenComparer
{
    class sql_lite
    {
        public static string dbPath = "";
        public static string dbConnStr = "Data Source={0};UTF8Encoding=True;Version=3";



       // select 

        //public static string datatableToSqlLiteTable(DataTable dtSqlObjects, DataTable dtSqlTables, string server, string database)
        //{
        //    dbPath = string.Format("{0}_{1}_{2}.db", DateTime.Now.ToString("yyyyMMdd_hhmm_ss") , server , database) ; 
        //    dbConnStr = string.Format(  dbConnStr,dbPath);

        //    bool dbExists = System.IO.File.Exists(dbPath);
        //    if (!dbExists)
        //    {
        //        datatableToSqlLiteTable(dtSqlObjects, "sqlObjects");
        //        datatableToSqlLiteTable(dtSqlTables, "sqlTables");

        //    }

        //    return dbPath;
        //}


        //public static void datatableToSqlLiteTable(DataTable dt, string tableName)
        //{

          //  System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection();
        //    conn.ConnectionString = dbConnStr;
        //    conn.Open();
        //    //przyspieszenie
        //    System.Data.SQLite.SQLiteCommand cmd = conn.CreateCommand();


        //    string sql, sqlinsert, sqlcolumns = "", sqlinsertcolumns = "", sqlvalues = "";
        //    sql = "CREATE TABLE {0} ({1})";
        //    sqlinsert = "insert into {0} ({1}) values ({2})";

        //    for (int colIndx = 0; colIndx < dt.Columns.Count; colIndx++)
        //    {
        //        sqlcolumns += dt.Columns[colIndx].ColumnName.ToLower() + " Text,";
        //        sqlinsertcolumns += "[" + dt.Columns[colIndx].ColumnName.ToLower() + "],";

        //        int temp = colIndx + 1;
        //        sqlvalues += "@" + temp + " ,";
        //    }


        //    cmd.CommandText = string.Format(sql, tableName, _RemoveLast(sqlcolumns, ","));
        //    cmd.ExecuteNonQuery();


        //    cmd.CommandText = "PRAGMA synchronous = OFF";
        //    cmd.ExecuteNonQuery();
        //    cmd.CommandText = "BEGIN TRANSACTION";
        //    cmd.ExecuteNonQuery();

        //    sqlinsert = string.Format(sqlinsert, tableName, _RemoveLast(sqlinsertcolumns, ","), _RemoveLast(sqlvalues, ","));

        //    string[] arrValues;
        //    arrValues = new string[dt.Columns.Count];


        //    for (int rowIndx = 0; rowIndx < dt.Rows.Count; rowIndx++)
        //    {

        //        cmd.CommandText = sqlinsert;
        //        List<SQLiteParameter> paramss = new List<SQLiteParameter>();
        //        //Dodanie do array, formatowanie, zamienianie nazw na odpowiednie numery
        //        for (int colIndx = 0; colIndx < dt.Columns.Count; colIndx++)
        //        {
        //            //arrValues[colIndx] = dt.Rows[rowIndx][colIndx].ToString();
        //            int temp = colIndx + 1;
        //            cmd.Parameters.Add(new SQLiteParameter("@" + temp, dt.Rows[rowIndx][colIndx].ToString()));
        //        }

        //        cmd.ExecuteNonQuery();

        //    }
        //    cmd.CommandText = "COMMIT TRANSACTION";
        //    cmd.ExecuteNonQuery();


        //    conn.Close();
        //}


        public static string _RemoveLast(string input, string lastStringToRemove)
        {
            input = input.TrimEnd();
            int i = input.LastIndexOf(lastStringToRemove);
            int length = input.Length;

            if (i > 0 && length > 0 && length - lastStringToRemove.Length == i)
            {
                return input.Remove(i, lastStringToRemove.Length);
            }

            return input;

        }



    }
}
