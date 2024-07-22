using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class RpFixedAssetEnd : DevExpress.XtraReports.UI.XtraReport
    {
        public RpFixedAssetEnd(DataTable dt, DateTime endDate)
        {
            InitializeComponent();
            this.xrTableCell1.Text = this.xrTableCell1.Text + " " + endDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.DataSource = dt;
            SetDataCollumn();
        }
        private void SetDataCollumn()
        {
            this.xrAccountName.DataBindings.Add("Text", this.DataSource, "AccountName");
            this.xrAccumulatedDepreciationExtract.DataBindings.Add("Text", this.DataSource, "AccumulatedDepreciationExtract", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.xrSumAccumulatedDepreciationExtract.DataBindings.Add("Text", this.DataSource, "AccumulatedDepreciationExtract");
            this.xrSumAccumulatedDepreciationExtract.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((this.DataSource as DataTable).Rows.Count > 0)
                this.xrTableCell2.Text = "+";
        }
    }
}
