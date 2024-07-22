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
    public partial class FormProductSizes  :FormEditBase
    {
        //private ListBase<ProductSize> listProductSize;
        private ProductSizeBLL _ProductSizeBLL = new ProductSizeBLL();
        public FormProductSizes()
        {
            InitializeComponent();
        }

        private void ProductSizes_Load(object sender, EventArgs e)
        {
            this.EditControl = productSizesControl1;
            this.DataSource = _ProductSizeBLL.GetAll();
            Business = _ProductSizeBLL;
        }

       
    }
}