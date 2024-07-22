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
    public partial class RpSaleOutNB : XtraReport
    {
        public struct Params
        {
            public StockTransaction Header;
            public string Khoxuat;
            public string Khonhap;
            
            public bool SmallSize;
        }
        public Params RpParams;

        public RpSaleOutNB()
        {
            InitializeComponent();
        }
       
        public void BindData()
        {
            if (!this.RpParams.SmallSize)
            {
                this.xrTableRow2.Font = new Font(this.xrTableRow2.Font.Name, 12);
            }
            //lbNgay.Text = this.RpParams.Header.TransactionDate.Day.ToString();
            //lbThang.Text = this.RpParams.Header.TransactionDate.Month.ToString();
            //lbNam.Text = this.RpParams.Header.TransactionDate.Year.ToString();
            DateTime d = this.RpParams.Header.SaleRequestObj.InvoiceDate;
            lbNgay.Text = d.Day.ToString();
            lbThang.Text = d.Month.ToString();
            lbNam.Text = d.ToString("yyyy");
            if (this.RpParams.Header.SaleRequestObj == null) this.RpParams.Header.SaleRequestObj = new SaleRequests();
            lblNguoiVC.Text = this.RpParams.Header.SaleRequestObj.NguoiGiaoNhan;
            lblPTVC.Text = this.RpParams.Header.SaleRequestObj.PTVC;
            lblKhoxuat.Text = this.RpParams.Khoxuat;
            this.lblTotalQuantity.Text = this.RpParams.Header.SaleRequestObj.Quantity.ToString("#,###");

            lbTotalAmount.Text = this.RpParams.Header.SaleRequestObj.BeforeTaxAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            

            cellSTT.DataBindings.Add("Text", this.DataSource, "STT");
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            cellDVT.DataBindings.Add("Text", this.DataSource, "Unit");
            cellQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellPrice.DataBindings.Add("Text", this.DataSource, "Price", AppConfigs.CONFIG_PRICEVNFORMAT_STRING);
            cellAmount.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);

            ListBase<Subject> lst = new SubjectBLL().GetAll();
            Subject stock = lst.Search("SubjectCode", this.RpParams.Header.OutStock);
            Subject branch = lst.Search("SubjectCode", stock.BranchCode);

            //this.lblDVBH.Text = branch.Description;
            //this.lblVTAddress.Text = branch.Address;
            //this.lblVTPhone.Text = branch.Phone;
            //this.lblVTTax.Text = branch.TaxCode;
            //this.lblSubjectCode.Text = this.RpParams.Header.SaleRequestObj.CustomerCode;


        }
    }
}
