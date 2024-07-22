using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormProductWeights : FormEditBase
    {
        //private ListBase<ProductWeight> lstProductWeight;
        private ProductWeightBLL _ProductWeightBLL = new ProductWeightBLL();
        public FormProductWeights()
        {
            InitializeComponent();
        }

        private void ProductWeights_Load(object sender, EventArgs e)
        {
            this.DataSource = _ProductWeightBLL.GetAll();
            Business = _ProductWeightBLL;
        }

    }
}