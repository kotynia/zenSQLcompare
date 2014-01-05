using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace zenComparer
{
    class compareDATA
    {
        string[] _DATACOMPARE_KEYS;
        string[] _DATACOMPARE_EXCLUDECOLUMNS;
        string _modelTable;
        string _targetTable;
        public System.Text.StringBuilder Script = new System.Text.StringBuilder(); //generated script

        public compareDATA(
             string modelConnection, string targetConnection,
             string modelTable, string targetTable,
             string DATACOMPARE_KEYS, string DATACOMPARE_EXCLUDECOLUMNS)
        {

            //   try
            //  {



            _DATACOMPARE_KEYS = _trimStringArray(DATACOMPARE_KEYS.Split(','));
            _DATACOMPARE_EXCLUDECOLUMNS = _trimStringArray(DATACOMPARE_EXCLUDECOLUMNS.Split(','));
            _modelTable = modelTable;
            _targetTable = targetTable;


            DataTable master = new DataTable();
            DataTable slave = new DataTable();

            master = Extensions.GetDataTable("select * from " + _modelTable, modelConnection);
            slave = Extensions.GetDataTable("select * from " + _targetTable, targetConnection);

            DatatableRemoveColumns(ref master, _DATACOMPARE_EXCLUDECOLUMNS);
            DatatableRemoveColumns(ref slave, _DATACOMPARE_EXCLUDECOLUMNS);


            Hashtable htmaster = _convertDatatabletoHash(master, _DATACOMPARE_KEYS);
            Hashtable htslave = _convertDatatabletoHash(slave, _DATACOMPARE_KEYS);




            //usuniecie nadliczbowych
            foreach (DataRow r in slave.Rows)
            {
                string key = "";

                foreach (DataColumn c in slave.Columns) //przygotowanie klucza
                {
                    if (_compareToString(_DATACOMPARE_KEYS, c.ColumnName)) //klucze
                        key += r[c];
                }

                if (!htmaster.ContainsKey(key)) //porownac czy slave ma taki wirsz
                {
                    string script = createDeleteFromDatarow(_DATACOMPARE_KEYS, r);
                    Script.Append("\n\n/*DELETE*/\n/*" + script + " */");
                }

            }


            foreach (DataRow r in master.Rows)
            {
                string key = "";

                foreach (DataColumn c in master.Columns) //przygotowanie klucza
                {
                    if (_compareToString(_DATACOMPARE_KEYS, c.ColumnName)) //klucze
                        key += r[c];
                }

                //update istnijacych
                if (htslave.ContainsKey(key)) //porownac czy slave ma taki wirsz
                {
                    string keymaster = htmaster[key].ToString();
                    string keyslave = htslave[key].ToString();

                    if (keymaster != keyslave)//czy wiersz jest taki sam
                    {
                        string script = createUpdateFromDatarow(_DATACOMPARE_KEYS, r);

                        Script.Append("\n\n/*UPDATE*/\n" + script);
                    }
                }
                else //insert brakujacych
                {
                    string script = createInsertFromDatarow(_DATACOMPARE_KEYS, r);

                    Script.Append("\n\n/*INSERT*/\n" + script);
                }
            }
            master.Dispose();
            slave.Dispose();
            //   }
            //   catch (Exception ex)
            //   {
            //       Script.Append(ex.Message);
            //   }
        }





        string createDeleteFromDatarow(string[] keys, DataRow drIn)
        {

            string updatecommand = "delete from " + _targetTable + "  ";
            string where = "";
            foreach (DataColumn c in drIn.Table.Columns)
            {
                string temp;
                if (drIn.IsNull(c))
                    temp = "NULL";
                else
                    temp = "N'" + drIn[c].ToString().Replace("'", "''") + "'";


                if (_compareToString(keys, c.ColumnName)) //klucze
                    where += string.Format(" [{0}] = {1} and", c.ColumnName, temp);


            }
            where = where.Remove(where.Length - 3, 3);

            updatecommand += string.Format(" where {0}", where);
            return updatecommand;
        }



        string createUpdateFromDatarow(string[] keys, DataRow drIn)
        {

            string updatecommand = "update " + _targetTable + " set ";
            string where = "";
            foreach (DataColumn c in drIn.Table.Columns)
            {
                string temp;
                if (drIn.IsNull(c))
                    temp = "NULL";
                else
                    temp = "N'" + drIn[c].ToString().Replace("'", "''") + "'";


                if (_compareToString(keys, c.ColumnName)) //klucze
                    where += string.Format(" [{0}] = {1} and", c.ColumnName, temp);
                else //wartosc
                    updatecommand += string.Format(" [{0}] = {1},", c.ColumnName, temp);

            }
            updatecommand = updatecommand.Remove(updatecommand.Length - 1, 1);
            where = where.Remove(where.Length - 3, 3);

            updatecommand += string.Format(" where {0}", where);
            return updatecommand;
        }


        string createInsertFromDatarow(string[] keys, DataRow drIn)
        {

            ///items,values

            string items = "", values = "";

            // string updatecommand = "insert into " + targettable.Text +  ";
            foreach (DataColumn c in drIn.Table.Columns)
            {
                if (drIn.IsNull(c))
                    values += "NULL,";
                else
                    values += "N'" + drIn[c].ToString().Replace("'", "''") + "',";

                items += string.Format("[{0}],", c.ColumnName);

            }

            values = values.Remove(values.Length - 1, 1);
            items = items.Remove(items.Length - 1, 1);


            string insertCommand = string.Format("insert into  [{0}] ({1}) values ({2})", _targetTable, items, values);

            return insertCommand;
        }




        void DatatableRemoveColumns(ref DataTable dt, string[] removecolumns)
        {
            if (removecolumns.Length == 0)
                return;

            //modyfikacja datatable do kolumn takich jak soie zycza
            for (int colIndx = 0; colIndx < dt.Columns.Count; colIndx++)
            {
                if (_compareToString(removecolumns, dt.Columns[colIndx].ColumnName))
                {
                    dt.Columns.RemoveAt(colIndx);
                    colIndx = -1;
                }
            }

        }


        /// <summary>
        /// łączy wszystki dane i tworzy klucz i wartosci
        /// </summary>
        /// <param name="dtIn"></param>
        /// <param name="keyField">comma sparated keys</param>
        /// <returns></returns>
        Hashtable _convertDatatabletoHash(DataTable dtIn, string[] keys)
        {
            Hashtable htOut = new Hashtable();
            foreach (DataRow drIn in dtIn.Rows)
            {
                string value = "";
                string key = "";
                foreach (DataColumn c in dtIn.Columns)
                {

                    string temp;
                    if (drIn.IsNull(c))
                        temp = "NULL";
                    else
                        temp = drIn[c].ToString();

                    if (_compareToString(keys, c.ColumnName)) //klucze
                        key += temp;
                    else  //wartosc
                        value += temp;

                }
                htOut.Add(key, value);
            }
            return htOut;
        }



        static bool _compareToString(string[] input, string findElement)
        {
            foreach (string s in input)
                if (s.ToLowerInvariant().Trim().CompareTo(findElement.ToLowerInvariant().Trim()) == 0)
                    return true;

            return false;

        }



        string[] _trimStringArray(string[] input)
        {


            for (int i = 0; i < input.Length; i++)
                input[i] = input[i].Trim();
            return input;
        }

    }
}
