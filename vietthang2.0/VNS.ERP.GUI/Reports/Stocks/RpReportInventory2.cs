using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpReportInventory2 : ReportBase1
    {
        DateTime FromDate, ToDate;
        string NameReport;
        string StockName;
        object lstDatasource;
        public RpReportInventory2()
        {
            InitializeComponent();
        }
        public RpReportInventory2(DateTime _FromDate, DateTime _ToDate, string _StockName, object _Datasource, string _NameReport)
        {
            InitializeComponent();
            FromDate = _FromDate;
            ToDate = _ToDate;
            NameReport = _NameReport;
            StockName = _StockName;
            lstDatasource = _Datasource;
            this.DataSource = lstDatasource;
            BindingData();
        }
        private void BindingData()
        {
            txtFromDate.Text = FromDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtToDate.Text = ToDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            lbStockName.Text = lbStockName.Text + " " + StockName;
            lbNameReport.Text = NameReport;
         
            this.txtItemName.DataBindings.Add("Text", lstDatasource, "ItemName");

            this.txtUnit.DataBindings.Add("Text", lstDatasource, "Unit");

            this.txtOpening.DataBindings.Add("Text", lstDatasource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtIn.DataBindings.Add("Text", lstDatasource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtOut.DataBindings.Add("Text", lstDatasource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtClosing.DataBindings.Add("Text", lstDatasource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellTotalOpen.DataBindings.Add("Text", lstDatasource, "OpenQuantity");
            this.cellTotalIn.DataBindings.Add("Text", lstDatasource, "InQuantity");
            this.cellTotalOut.DataBindings.Add("Text", lstDatasource, "OutQuantity");
            this.cellTotalClosing.DataBindings.Add("Text", lstDatasource, "CloseQuantity");

            this.cellTotalOpen.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.cellTotalIn.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.cellTotalOut.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.cellTotalClosing.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
           

        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //decimal totalClose = 0;
            //decimal Openning = (decimal)this.GetCurrentColumnValue("OpenQuantity");
            //decimal In = (decimal)this.GetCurrentColumnValue("InQuantity");
            //decimal Out = (decimal)this.GetCurrentColumnValue("OutQuantity");
            //decimal Result = Openning + In - Out;
            //totalClose += Result;
            //txtClosing.Text = Result.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            //cellTotalClosing.Text = totalClose.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            //if (totalClose == 0)
            //    cellTotalClosing.Text = "0";
        }

    }
}
