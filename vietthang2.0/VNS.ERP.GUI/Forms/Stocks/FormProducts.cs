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
    public partial class FormProducts : VNS.Windows.Forms.FormEditBase
    {
        //private ListBase<Product> lstProduct;
        private ProductBLL _ProductBLL = new ProductBLL();
        public FormProducts()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            this.DataSource = _ProductBLL.GetAll();
            Business = _ProductBLL;
        }
  
      
    }
}