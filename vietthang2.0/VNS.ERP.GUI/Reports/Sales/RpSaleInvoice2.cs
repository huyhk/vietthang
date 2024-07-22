using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using VNS.Utils;

namespace VNS.ERP.GUI
{
    public partial class RpSaleInvoice2 : XtraReport
    {
        public struct Params
        {
            public StockTransaction Header;
            public string CKDescription;
            public decimal CKAmount;
        }
        public Params RpParams;

        public RpSaleInvoice2()
        {
            InitializeComponent();
        }
       
        public void BindData()
        {
            //lbNgay.Text = this.RpParams.Header.TransactionDate.Day.ToString();
            //lbThang.Text = this.RpParams.Header.TransactionDate.Month.ToString();
            //lbNam.Text = this.RpParams.Header.TransactionDate.Year.ToString();
            DateTime d = this.RpParams.Header.SaleRequestObj.InvoiceDate;
            lbNgay.Text = d.Day.ToString();
            lbThang.Text = d.Month.ToString();
            lbNam.Text = d.Year.ToString();
            if (this.RpParams.Header.SaleRequestObj == null) this.RpParams.Header.SaleRequestObj = new SaleRequests();
            lbCustomer.Text = this.RpParams.Header.SaleRequestObj.InvoiceCustomerName;
            Customer c = new CustomerBLL().GetBySubjectCode(this.RpParams.Header.SaleRequestObj.CustomerCode);
            if (c != null)
            {
                //lbCustomer.Text = c.SubjectName;
                lbAddress.Text = c.Address;
                lbTaxCode.Text = c.TaxCode;
                lbAccountNo.Text = c.BankAccountNo;
            }
            lbPaymentType.Text = this.RpParams.Header.SaleRequestObj.PaymentType;
            lbTaxRate.Text = Convert.ToInt32(this.RpParams.Header.SaleRequestObj.TaxRate * 100).ToString();

            lbTotalAmount.Text = this.RpParams.Header.SaleRequestObj.BeforeTaxAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT) + " VND";
            cellThueGTGT.Text = this.RpParams.Header.SaleRequestObj.TaxAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT) + " VND";
            cellTotalAmount1.Text = this.RpParams.Header.SaleRequestObj.InvoiceAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT) + " VND";

            lbReadAmount.Text = NumberConvert.NumberToSentence(this.RpParams.Header.SaleRequestObj.InvoiceAmount) + "đồng.";

            cellSTT.DataBindings.Add("Text", this.DataSource, "STT");
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            cellDVT.DataBindings.Add("Text", this.DataSource, "Unit");
            cellQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellPrice.DataBindings.Add("Text", this.DataSource, "Price", AppConfigs.CONFIG_PRICEVNFORMAT_STRING);
            cellAmount.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);

            ListBase<Subject> lst = new SubjectBLL().GetAll();
            Subject stock = lst.Search("SubjectCode", this.RpParams.Header.OutStock);
            Subject branch = lst.Search("SubjectCode", stock.BranchCode);

            this.lblDVBH.Text = branch.Description;
            this.lblVTAddress.Text = branch.Address;
            this.lblVTPhone.Text = branch.Phone;
            this.lblVTTax.Text = branch.TaxCode;
            this.lblSubjectCode.Text = this.RpParams.Header.SaleRequestObj.CustomerCode;

            this.lblCK.Text = this.RpParams.CKDescription;
            this.lblCKAmount.Text = this.RpParams.CKAmount.ToString("#,###");
        }
    }
}
