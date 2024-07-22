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
    public partial class FormAccountClassificationType : FormEditBase
    {
        public FormAccountClassificationType()
        {
            InitializeComponent();
            this.Business = (new AccountClassificationTypeBLL());
           
        }

        private void FormAccountClassificationType_Load(object sender, EventArgs e)
        {
            this.DataSource = (new AccountClassificationTypeBLL()).GetAll();
        }
    }
}