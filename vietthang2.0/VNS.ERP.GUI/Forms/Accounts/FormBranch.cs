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
    public partial class FormBranch : FormEditBase
    {
        public FormBranch()
        {
            InitializeComponent();
            this.Business = new BranchBLL();
        }

        private void FormBranch_Load(object sender, EventArgs e)
        {
            this.DataSource = (new BranchBLL()).GetAll();
        }
    }
}