using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.Windows.Forms;

namespace VNS.ERP.GUI
{
    public partial class FormBank : FormEditBase
    {
        public FormBank()
        {
            InitializeComponent();
            this.Business = new BankBLL();
        }

        private void FormBank_Load(object sender, EventArgs e)
        {
            this.DataSource = (new BankBLL()).GetAll();
            this.cboBranchCode.DataSource = new BranchBLL().GetAll();
        }
    }
}