using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpAccountTransactionAmounDetailNgang : ReportBase2
    {
        public struct Params
        {
            //public DateTime StartDate;
            //public DateTime EndDate;
            public string Ngaymoso;
            public string ItemCode;
            public string ItemName;
            public string AccountCode;
            public decimal OpenQuantity;
            public decimal OpenAmount;
            public decimal CloseQuantity;
            public decimal CloseAmount;
            public string PeriodText;
            
        }
        decimal SoduQuantity, SoduAmount;
        public Params RpParams = new Params();
        public RpAccountTransactionAmounDetailNgang()
        {
            InitializeComponent();
            cellTotalInAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalOutAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalInQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTotalOutQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
        }
        public void BindData()
        {
            SoduQuantity = RpParams.OpenQuantity;
            SoduAmount = RpParams.OpenAmount;
            this.cellNgaymoso.Text = RpParams.Ngaymoso;
            //this.lbStartDate.Text = RpParams.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            //this.lbEndDate.Text = RpParams.EndDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.lbPeriodText.Text = RpParams.PeriodText;
            this.lbItemCode.Text = RpParams.ItemCode;
            this.lbItemName.Text = RpParams.ItemName;
            this.lblTaikhoan.Text = RpParams.AccountCode;
            this.lbOpenQuantity.Text = RpParams.OpenQuantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            this.lbOpenAmount.Text = RpParams.OpenAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.lbCloseQuantity.Text = RpParams.CloseQuantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            this.lbCloseAmount.Text = RpParams.CloseAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);

            
            cellStockTransactionNo.DataBindings.Add("Text", this.DataSource, "StockTransactionNo");
            cellStockTransactionDate.DataBindings.Add("Text", this.DataSource, "StockTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            //cellStockName.DataBindings.Add("Text", this.DataSource, "StockName");
            cellDescription.DataBindings.Add("Text", this.DataSource, "Description");
            cellInQuantity.DataBindings.Add("Text", this.DataSource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            cellTotalInQuantity.DataBindings.Add("Text", this.DataSource, "InQuantity");
            cellInAmount.DataBindings.Add("Text", this.DataSource, "InCostAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            cellTotalInAmount.DataBindings.Add("Text", this.DataSource, "InCostAmount");
            cellOutQuantity.DataBindings.Add("Text", this.DataSource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            cellTotalOutQuantity.DataBindings.Add("Text", this.DataSource, "OutQuantity");
            cellOutAmount.DataBindings.Add("Text", this.DataSource, "OutCostAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            cellTotalOutAmount.DataBindings.Add("Text", this.DataSource, "OutCostAmount");

            cellCostPrice.DataBindings.Add("Text", this.DataSource, "CostPrice", AppConfigs.CONFIG_PRICEVNFORMAT_STRING);
            cellTKDU.DataBindings.Add("Text", this.DataSource, "TKDU");

            this.txtInMonthQuantity.DataBindings.Add("Text", DataSource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtInMonthQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtOutMonthQuantity.DataBindings.Add("Text", DataSource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtOutMonthQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            this.txtInMonthAmount.DataBindings.Add("Text", DataSource, "InCostAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.txtInMonthAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.txtOutMonthAmount.DataBindings.Add("Text", DataSource, "OutCostAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.txtOutMonthAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;

        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.txtCloseMonthQuantity.Text = SoduQuantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            this.txtCloseMonthAmount.Text = SoduAmount.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.GetCurrentColumnValue("InQuantity") != null)
            {
                SoduQuantity += (decimal)this.GetCurrentColumnValue("InQuantity") - (decimal)this.GetCurrentColumnValue("OutQuantity");
                SoduAmount += (decimal)this.GetCurrentColumnValue("InCostAmount") - (decimal)this.GetCurrentColumnValue("OutCostAmount");
            }
        }

    }
}
