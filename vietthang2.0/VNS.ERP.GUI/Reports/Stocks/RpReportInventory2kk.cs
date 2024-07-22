using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpReportInventory2kk : ReportBase1
    {
        public struct Params
        {
            public DateTime FromDate;
            public DateTime ToDate;
            public string NameReport;
            public string StockName;
        }
        //private Params rpParams;
        public Params RpParams;
        //{
        //    get { return rpParams; }
        //    set { rpParams = value; }
        //}

        public RpReportInventory2kk()
        {
            InitializeComponent();
        }
        public void BindingData()
        {
            txtFromDate.Text = RpParams.FromDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtToDate.Text = RpParams.ToDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            lbStockName.Text = lbStockName.Text + " " + RpParams.StockName;
            lbNameReport.Text = RpParams.NameReport;

            this.txtItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            this.txtUnit.DataBindings.Add("Text", this.DataSource, "Unit");
            this.txtOpening.DataBindings.Add("Text", this.DataSource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtIn.DataBindings.Add("Text", this.DataSource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtOut.DataBindings.Add("Text", this.DataSource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellKKQuantity.DataBindings.Add("Text", this.DataSource, "KKQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtClosing.DataBindings.Add("Text", this.DataSource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);

            this.txtTotalOpening.DataBindings.Add("Text", this.DataSource, "OpenQuantity");
            this.txtTotalIn.DataBindings.Add("Text", this.DataSource, "InQuantity");
            this.txtTotalOut.DataBindings.Add("Text", this.DataSource, "OutQuantity");
            this.cellTotalKKQuantity.DataBindings.Add("Text", this.DataSource, "KKQuantity");
            this.txtTotalClosing.DataBindings.Add("Text", this.DataSource, "CloseQuantity");

            this.txtTotalOpening.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtTotalIn.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtTotalOut.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.cellTotalKKQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtTotalClosing.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
