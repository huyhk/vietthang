using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormFixedAsset : FormEditBase
    {
        public FormFixedAsset()
        {
            InitializeComponent();
            this.Business = new FixedAssetBLL();
        }

        private void FormFixedAsset_Load(object sender, EventArgs e)
        {
            this.DataSource = new FixedAssetBLL().GetAll();
        }
    }
}