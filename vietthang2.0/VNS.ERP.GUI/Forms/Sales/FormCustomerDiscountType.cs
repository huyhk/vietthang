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
    public partial class FormCustomerDiscountType : FormEditBase
    {
        private CustomerDiscountTypeBLL customerDiscountTypeBLL = new CustomerDiscountTypeBLL();
        public FormCustomerDiscountType()
        {
            InitializeComponent();
            this.Business = customerDiscountTypeBLL;
        }

        private void FormCustomerDiscountType_Load(object sender, EventArgs e)
        {
            this.DataSource = customerDiscountTypeBLL.GetAll();
        }
        public override void Delete()
        {
            if(DiscountType.CheckDiscountSystemType((this.CurrentItem as CustomerDiscountType).DiscountTypeCode)==false)
                base.Delete();
            else
                MessageBox.Show("Không cho phép xóa!!!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}