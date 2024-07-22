using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormCash : FormEditBase
    {
        public FormCash()
        {
            InitializeComponent();
            this.Business = new CashBLL();
        }

        private void FormCash_Load(object sender, EventArgs e)
        {
            this.DataSource = (new CashBLL()).GetAll();
            this.cboBranchCode.DataSource=new BranchBLL().GetAll();
        }
    }
}