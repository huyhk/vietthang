using System;
using System.Windows.Forms;

using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public class MainProg
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //if (Contexts.CurrentUser == null)
            //{
            //    FormLogin frmLogin = new FormLogin();
            //    if (frmLogin.ShowDialog() == DialogResult.OK)
            //    {
            //        Application.Run(new MainForm());
            //    }
            //    else
            //    {
            //        Application.Exit();
            //    }
            //}

            

        }
    }
}