using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormCustomerPriceReduces : VNS.Windows.Forms.FormEditBase
    {
        CustomerPriceReduceBLL bll = new CustomerPriceReduceBLL();
        public FormCustomerPriceReduces()
        {
            InitializeComponent();
            this.Business = bll;
            this.DataSource = bll.GetAll();
            this.repLookUpSubjectName.DataSource = new CustomerBLL().GetAll();
            this.repLookUpStockName.DataSource = new StockBLL().GetAll();
        }
    }
}

