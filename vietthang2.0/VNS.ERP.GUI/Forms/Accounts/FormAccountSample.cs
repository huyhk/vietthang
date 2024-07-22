using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows.Forms;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormAccountSample : FormEditBase
    {
        AccountSampleBLL obj = new AccountSampleBLL();
        public FormAccountSample()
        {
            InitializeComponent();
            this.Business = obj;
            this.ucAccountSample1.InitDss();
        }

        private void FormAccountSample_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                this.CancelItem();
            }
        }
    }
}