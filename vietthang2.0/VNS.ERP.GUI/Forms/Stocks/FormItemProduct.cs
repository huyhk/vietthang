using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data; 

using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormItemProduct :FormEditBase 
    {
        public FormItemProduct()
        {
            InitializeComponent();
            this.Business = new ItemProductBLL();
            this.DataSource = new ItemProductBLL().GetAllAll();
            usrItemProduct1.setLooKup();
            repLookUpWrappingCode.DataSource = new ItemWrappingBLL().GetAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string fileName = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel file|*.xls";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                gridControl1.MainView.ExportToXls(fileName);
            }
        }
    }
}