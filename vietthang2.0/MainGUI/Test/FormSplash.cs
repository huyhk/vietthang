using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VNS.ERP.GUI
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }
        private static FormSplash instance = null;
        public static void ShowSplash()
        {
            if (instance == null)
                instance = new FormSplash();
            instance.StartPosition = FormStartPosition.CenterScreen;
            instance.TopMost = true;
            instance.Show();
        }
        public static void CloseSplash()
        {
            if (instance != null)
            {
                instance.Close();
                instance = null;
            }
        }

        public static void SetStatus(string text)
        {
            if (instance !=null)
                instance.lblStatus.Text = text;
        }
                
    }
}