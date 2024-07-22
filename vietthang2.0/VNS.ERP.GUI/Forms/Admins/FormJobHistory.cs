using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
namespace VNS.ERP.GUI
{
    public partial class FormJobHistory : VNS.Windows.Forms.FormBase
    {
        public FormJobHistory()
        {
            InitializeComponent();
        }

        void GetData()
        {
            this.gridControl1.DataSource = new AdminBLL().GetJobHistory().Tables[0];
        }
        private void FormJobHistory_Load(object sender, EventArgs e)
        {
            this.GetData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.GetData();
        }
    }
}

