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
    public partial class FormCustomerSpecialPrices : VNS.Windows.Forms.FormEditBase
    {
        CustomerSpecialPriceBLL bll = new CustomerSpecialPriceBLL();
        public FormCustomerSpecialPrices()
        {
            InitializeComponent();
            this.Business = bll;
            this.DataSource = bll.GetAll();
            this.repLookUpSubjectName.DataSource = new CustomerBLL().GetAll();
        }

        private void ucCustomerSpecialPrices1_Load(object sender, EventArgs e)
        {
            AddUserColumn();
        }
    }
}

