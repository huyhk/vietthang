using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
namespace VNS.ERP.GUI
{
    public partial class ReportChitietBocxep : ReportBase1
    {
        public ReportChitietBocxep(string dateTime, string stockName,string bocxepSubjectName,DataTable dt)
        {
            InitializeComponent();
            this.xrlbBocxepSubjectName.Text = "Đơn vị bốc xếp: " + bocxepSubjectName;
            this.xrlbStockName.Text = "Tại kho: " + stockName;
            this.xrlbDateTime.Text = dateTime;

            this.DataSource = dt;
            BindData();
        }
        public void BindData()
        {
            this.xrStockTransactionDate.DataBindings.Add("Text", this.DataSource, "StockTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.xrStockTransactionNo.DataBindings.Add("Text", this.DataSource, "StockTransactionNo");
            this.xrPTVC.DataBindings.Add("Text", this.DataSource, "PTVC");
            this.xrPTTC.DataBindings.Add("Text", this.DataSource, "PTTC");
            this.xrServiceName.DataBindings.Add("Text", this.DataSource, "ServiceName");
            this.xrItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            this.xrQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.xrPriceTronggio.DataBindings.Add("Text", this.DataSource, "PriceTronggio", AppConfigs.CONFIG_PRICEVNFORMATZ_STRING);
            this.xrPriceNgoaigio.DataBindings.Add("Text", this.DataSource, "PriceNgoaigio", AppConfigs.CONFIG_PRICEVNFORMATZ_STRING);
            this.xrAmountTronggio.DataBindings.Add("Text", this.DataSource, "AmountTronggio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrAmountNgoaigio.DataBindings.Add("Text", this.DataSource, "AmountNgoaigio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrTotalAmount.DataBindings.Add("Text", this.DataSource, "TotalAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);

            this.xrTotalAmountNgoaigio.DataBindings.Add("Text", this.DataSource, "AmountNgoaigio");
            this.xrTotalAmountTronggio.DataBindings.Add("Text", this.DataSource, "AmountTronggio");
            this.xrSumTotalAmount.DataBindings.Add("Text", this.DataSource, "TotalAmount");
            this.xrTotalQuantity.DataBindings.Add("Text", this.DataSource, "Quantity");
            this.xrTotalAmountNgoaigio.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.xrTotalAmountTronggio.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.xrSumTotalAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.xrTotalQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;


        }


    }
}
