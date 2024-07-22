using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormInfoImportTechnicalTestReturnDetail : VNS.Windows.Forms.FormBase
    {
        public FormInfoImportTechnicalTestReturnDetail()
        {
            InitializeComponent();
        }
        public FormInfoImportTechnicalTestReturnDetail(DataTable dataSource)
        {
            InitializeComponent();
            this.gridControl1.DataSource = dataSource;
        }
    }
}

