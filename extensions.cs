using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace zenComparer
{
    public static class Extensions
    {
        public static Regex regex = new Regex("[\\s]",  // \\s  [\n\r]
    RegexOptions.IgnoreCase
    | RegexOptions.CultureInvariant
    | RegexOptions.Compiled
    );

        /// <summary>
        /// convert to hashtable
        /// </summary>
        public static Hashtable _convertDataTableToHashTable(DataTable dtIn, string keyField, string valueField)
        {

            Hashtable htOut = new Hashtable();
            foreach (DataRow drIn in dtIn.Rows)
            {
                if (!htOut.ContainsKey(drIn[keyField].ToString().ToLower()))
                    htOut.Add(drIn[keyField].ToString().ToLower(), drIn[valueField].ToString());
            }
            return htOut;
        }


        /// <summary>
        /// convert to hashtable
        /// </summary>
        public static Hashtable _convertDataTableToHashTable(DataTable dtIn, int columnIndexKey, int columnIndexValue)
        {

            Hashtable htOut = new Hashtable();
            foreach (DataRow drIn in dtIn.Rows)
            {
                if (!htOut.ContainsKey(drIn[columnIndexKey].ToString().ToLower()))
                    htOut.Add(drIn[columnIndexKey].ToString().ToLower(), drIn[columnIndexValue].ToString());
            }
            return htOut;
        }

        /// <summary>
        /// eliminuje whitespace bardzo wazne chodzi o entery etc
        /// </summary>
        /// <param name="IN"></param>
        /// <returns></returns>
        public static string _cleanstring(string input)
        {
            return regex.Replace(input, "");
        }


        //dirty check
        public static string _cleanstringWithoutComments(string input)
        {

            input = input.Replace("WITH EXEC AS CALLER", "");
            input = input.Replace("[", "");
            input = input.Replace("]", "");


            var blockComments = @"/\*(.*?)\*/";
            var lineComments = @"--(.*?)\r?\n";
            var strings = @"'((\\[^\n]|[^""\n])*)'";
            // var verbatimStrings = @"@(""[^""]*"")+";


            string retvalue = Regex.Replace(input,
            blockComments + "|" + lineComments + "|" + strings,"",
            RegexOptions.Singleline);

            return zenComparer.Extensions._cleanstring(retvalue);
        }


        public static string _getSeparatedString(string IN, int position)
        {
            char[] delim = { '|' };
            string[] splitted = IN.Split(delim);

            string temp = "";

            try
            {
                temp = splitted[position];
            }
            catch (System.Exception)
            {

                temp = "";
            }

            return temp;
        }


        public static System.Data.DataTable GetDataTable(string sql, string dsn)
        {
            DataTable dt = new DataTable();

            SqlConnection cnn = new SqlConnection(dsn);
            cnn.Open();
            SqlCommand mycommand = new SqlCommand(sql, cnn);
            mycommand.CommandText = sql;
            mycommand.CommandTimeout = 90;
            SqlDataReader reader = mycommand.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            cnn.Close();

            return dt;
        }

        public static string MakeSafeFilename(string filename, char replaceChar)
        {
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                filename = filename.Replace(c, replaceChar);
            }
            return filename;
        }

        public static string GetValue(string sql, string dsn)
        {
            string temp;
            try
            {


                //DataTable dt = new DataTable();

                SqlConnection cnn = new SqlConnection(dsn);
                cnn.Open();
                SqlCommand mycommand = new SqlCommand(sql, cnn);
                mycommand.CommandText = sql;


                temp = mycommand.ExecuteScalar().ToString();
                cnn.Close();
            }
            catch (System.Exception ex)
            {

                temp = "ERROR " + ex.Message.ToString();
            }
            return temp;
        }
    }
}
