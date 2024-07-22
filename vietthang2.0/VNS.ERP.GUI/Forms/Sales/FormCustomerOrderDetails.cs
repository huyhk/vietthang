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
using VNS.Common;
using VNS.Windows;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormCustomerOrderDetails : FormEditBase
    {
        private CustomerOrderBLL _CustomerOrderBLL = new CustomerOrderBLL();
        private string StockCode = "";
        string productType;
        //public FormCustomerOrderDetails()
        //{
        //    InitializeComponent();
        //    this.Business = _CustomerOrderBLL;
        //}

        public FormCustomerOrderDetails(string _pStockCode, string pProductType)
        {
            InitializeComponent();
            this.Business = _CustomerOrderBLL;
            StockCode = _pStockCode;
            productType = pProductType;
            this.ucCustomerOrderDetail1.StockCode = StockCode;
            this.ucCustomerOrderDetail1.productType = productType;
        }

        private void FormCustomerOderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
        }

    }
}