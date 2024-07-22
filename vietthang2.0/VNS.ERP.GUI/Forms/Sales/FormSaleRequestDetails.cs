using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Windows;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using System.Collections;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormSaleRequestDetails : FormEditBase
    {
        private SaleRequestBLL _SaleRequestBLL = new SaleRequestBLL();
        //private ListBase<SaleRequestDetails> lst;
        private string StockCode = "", productType = "";
        public FormSaleRequestDetails()
        {
            InitializeComponent();
            this.Business = _SaleRequestBLL;
        }

        public FormSaleRequestDetails(string _pStockCode, string pProductType)
        {
            InitializeComponent();
            this.Business = _SaleRequestBLL;
            StockCode = _pStockCode;
            productType = pProductType;

            this.ucSaleRequestDetails1.stockCode = StockCode;
            this.ucSaleRequestDetails1.productType = pProductType;
            if (productType == string.Empty)
                this.Text = "Phiếu yêu cầu xuất nội bộ";
        }
        public void AddNewObject(string customerOrderNo, string customerCode)
        {
            this.ucSaleRequestDetails1.SetDataCboCustomer(customerCode, customerOrderNo);
            this.ucSaleRequestDetails1.SetInvoiceData(customerCode,customerOrderNo);

        }

        public override void EditItem()
        {
            if ((this.currentItem as SaleRequests).IsFinished == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show("Phiếu yêu cầu xuất bán này đã thực hiện, không cho phép sửa!!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                base.EditItem();
            }
         
        }
        public override void Delete()
        {
            if ((this.currentItem as SaleRequests).IsFinished == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show("Phiếu yêu cầu xuất bán này đã thực hiện, không cho phép xóa!!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                base.Delete();
            }
        }
        private void FormRequestDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ucSaleRequestDetails1.SaveAutoCompleteForTextBox();
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
        }
       
    }
}