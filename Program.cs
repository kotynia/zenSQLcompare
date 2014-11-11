using System;
using System.Windows.Forms;

namespace zenComparer
{
    

    public static class Program
    {
       public static  frmMain currentForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            currentForm = new frmMain();
            Application.Run(currentForm);
        }
    }
}
