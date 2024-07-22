using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;

namespace VNS.ERP.GUI
{
    public partial class FormEditCustomerDiscountList : VNS.Windows.Forms.FormEditBase
    {
        CustomerDiscountListBLL bll = new CustomerDiscountListBLL();
        public FormEditCustomerDiscountList()
        {
            InitializeComponent();
        }

        private void FormEditCustomerDiscountList_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.Business = bll;
                this.DataSource = bll.GetAll();
            }
        }
    }
}
