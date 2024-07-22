using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpAccountTransactionQuantityDetail : ReportBase1
    {
        public struct Params
        {
            //public DateTime StartDate;
            //public DateTime EndDate;
            public string StockName;
            public string ItemCode;
            public string ItemName;
            public decimal OpenQuantity;
            public decimal CloseQuantity;
            public string PeriodText;
        }
        public Params RpParams = new Params();
        public RpAccountTransactionQuantityDetail()
        {
            InitializeComponent();
            cellTotalInQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTotalOutQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
        }
       
        public void BindData()
        {
            //this.lbStartDate.Text = RpParams.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            //this.lbEndDate.Text = RpParams.EndDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.lbPeriodText.Text = RpParams.PeriodText;
            this.lbStockName.Text = RpParams.StockName;
            this.lbItemCode.Text = RpParams.ItemCode;
            this.lbItemName.Text = RpParams.ItemName;
            this.lbOpenQuantity.Text = RpParams.OpenQuantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            this.lbCloseQuantity.Text = RpParams.CloseQuantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);

            cellStockTransactionNo.DataBindings.Add("Text", this.DataSource, "StockTransactionNo");
            cellStockTransactionDate.DataBindings.Add("Text", this.DataSource, "StockTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            cellDescription.DataBindings.Add("Text", this.DataSource, "Description");
            cellInQuantity.DataBindings.Add("Text", this.DataSource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellOutQuantity.DataBindings.Add("Text", this.DataSource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalInQuantity.DataBindings.Add("Text", this.DataSource, "InQuantity");
            cellTotalOutQuantity.DataBindings.Add("Text", this.DataSource, "OutQuantity");
        }

    }
}
