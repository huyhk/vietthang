using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpAccountTransactionAmount : ReportBase1
    {
        public struct Params
        {
            //public DateTime StartDate;
            //public DateTime EndDate;
            public string PeriodText;
            public string Taikhoan;
        }
        public Params RpParams = new Params();
        public RpAccountTransactionAmount()
        {
            InitializeComponent();
        }
       
        public void BindData()
        {
            this.lblTaikhoan.Text = this.lblTaikhoan.Text + " " + RpParams.Taikhoan;
            this.lbPeriodText.Text = RpParams.PeriodText;
            cellTotalCloseAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalInAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalOpenAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalOutAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;

            cellItemCode.DataBindings.Add("Text", this.DataSource, "ItemCode");
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            cellOpenQuantity.DataBindings.Add("Text", this.DataSource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellOpenAmount.DataBindings.Add("Text", this.DataSource, "OpenAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalOpenAmount.DataBindings.Add("Text", this.DataSource, "OpenAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellInQuantity.DataBindings.Add("Text", this.DataSource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellInAmount.DataBindings.Add("Text", this.DataSource, "InAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalInAmount.DataBindings.Add("Text", this.DataSource, "InAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellOutQuantity.DataBindings.Add("Text", this.DataSource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellOutAmount.DataBindings.Add("Text", this.DataSource, "OutAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalOutAmount.DataBindings.Add("Text", this.DataSource, "OutAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellCloseQuantity.DataBindings.Add("Text", this.DataSource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellCloseAmount.DataBindings.Add("Text", this.DataSource, "CloseAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalCloseAmount.DataBindings.Add("Text", this.DataSource, "CloseAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
        }

    }
}
