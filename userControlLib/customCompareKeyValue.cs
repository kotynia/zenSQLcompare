using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Diagnostics;
namespace zenComparer
{
    public partial class customCompareKeyValue : UserControl
    {
        public customCompareKeyValue()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //   sourceSql.Text = frmMain.masterConnectionString;

            //string test = sourceSql.Text;
            //string test1 = targetSql.Text;

            //Pobranie danych z master
            //  logger("Get schema for tables from MODEL");
            try
            {
                dgResult.Rows.Clear();
            
            DataTable master = new DataTable();
            DataTable slave = new DataTable();


            master = Extensions.GetDataTable(sourceSql.Text, frmMain.masterConnectionString);

            slave = Extensions.GetDataTable(targetSql.Text, frmMain.slaveConnectionString);
            //pobranie slave
            Hashtable ht = zenComparer.Extensions._convertDataTableToHashTable(slave, 0, 1);


            string action = "", model = "", target = ""; //missing/missmatched
            foreach (DataRow r in master.Rows)
            {
                //sprawdzenie czy slave zawiera taki klucz jelsi tak trzeba porownac
                if (ht.ContainsKey(r[0].ToString().ToLower()))
                {

                    model = ht[r[0].ToString().ToLower()].ToString().Trim(); //pobranie ze slave
                    target = r[1].ToString().Trim(); //pobranie z master
                    //Wazne cleanstring porownuje bez whitespace
                    //unification zapewnia ze tpominiete zostana texty create ktore czesto maja male duze litery
                    if (string.CompareOrdinal(model, target) != 0)
                    {
                        action = "Missmatched";
                        dgResultInsertRow(r[0].ToString().ToLower(), action, model, target);
                    }
                }
                else //brak
                {
                    model = r[1].ToString().Trim();
                    target = string.Empty;
                    action = "missing";
                    dgResultInsertRow(r[0].ToString().ToLower(), action, model, target);

                }
            }
            ////compare(master, slave, out excludedNumber);
            dgResult.Refresh();
            master.Dispose();
            slave.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        void dgResultInsertRow(string key, string action, string model, string target)
        {
            DataGridViewRow dgrow = new DataGridViewRow();
            DataGridViewCell dgCell;


            dgCell = new DataGridViewTextBoxCell();
            dgCell.Value = key;
            dgrow.Cells.Add(dgCell);

            dgCell = new DataGridViewTextBoxCell();
            dgCell.Value = action;
            dgrow.Cells.Add(dgCell);

            dgCell = new DataGridViewTextBoxCell();
            dgCell.Value = model;
            dgrow.Cells.Add(dgCell);

            dgCell = new DataGridViewTextBoxCell();
            dgCell.Value = target;
            dgrow.Cells.Add(dgCell);

            dgResult.Rows.Add(dgrow);
    

        }

        private void btnShowChanges_Click(object sender, EventArgs e)
        {
            try
            {

                char separator = 'B';

                foreach (DataGridViewRow dgvr in dgResult.Rows)
                {
                    if (dgvr.Selected )
                    {
                        Process myProc;

                        // Generate File
                        string time = DateTime.Now.ToString("yyyymmddhhmmss");
                        string filenameModel = zenComparer.Extensions.MakeSafeFilename(string.Format("{0}_{1}model.txt", (string)dgvr.Cells[0].Value, time), separator);
                        FileStream f = new FileStream(filenameModel, FileMode.Create);
                        StreamWriter s = new StreamWriter(f);

                        s.WriteLine((string)dgvr.Cells["model"].Value);

                        s.Close();
                        f.Close();


                        string filenameTarget = zenComparer.Extensions.MakeSafeFilename(string.Format("{0}_{1}target.txt", (string)dgvr.Cells[0].Value, time), separator);
                        f = new FileStream(filenameTarget, FileMode.Create);
                        s = new StreamWriter(f);

                        s.WriteLine((string)dgvr.Cells["target"].Value);

                        s.Close();
                        f.Close();


                        string commandline = frmMain.commandLineArguments.Replace("%Model", Application.StartupPath + "\\" + filenameModel);
                        commandline = commandline.Replace("%Target", Application.StartupPath + "\\" + filenameTarget);

                        myProc = Process.Start(frmMain.commandLineTool, commandline);
                   }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
