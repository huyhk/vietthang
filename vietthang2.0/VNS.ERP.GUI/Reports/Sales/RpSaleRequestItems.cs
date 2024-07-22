using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpSaleRequestItems : ReportBase1
    {
        public RpSaleRequestItems()
        {
            InitializeComponent();
        }
        public RpSaleRequestItems(DataView dv)
        {
            InitializeComponent();
            this.DataSource = dv.ToTable();
            BindDataDetail();
        }
        public void BindDataDetail()
        {
            this.cellInvoiceNo.DataBindings.Add("Text", DataSource, "InvoiceNo");
            this.cellQuantity.DataBindings.Add("Text", DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);
            this.cellSaleRequestDate.DataBindings.Add("Text", DataSource, "SaleRequestDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellCustomerCode.DataBindings.Add("Text", DataSource, "CustomerCode");
            this.celItemCode.DataBindings.Add("Text", DataSource, "ItemCode");
            this.cellSubjectName.DataBindings.Add("Text", DataSource, "SubjectName");
            this.cellInvoiceAmount.DataBindings.Add("Text", DataSource, "InvoiceAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellTotalInvoiceAmout.DataBindings.Add("Text", DataSource, "InvoiceAmount");
            this.cellTotalInvoiceAmout.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalQuantity.DataBindings.Add("Text", DataSource, "Quantity");
            this.cellTotalQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING;
        }
        public void BindDataMaster(ArrayList array)
        {
            this.cellTungay.Text = array[0].ToString();
            this.cellDenngay.Text = array[1].ToString();
        }
    }
}
