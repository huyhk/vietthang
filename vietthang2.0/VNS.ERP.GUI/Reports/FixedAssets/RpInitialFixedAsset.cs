/*
 * Tai san co dinh luy ke dau thang
*/
using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class RpInitialFixedAsset : DevExpress.XtraReports.UI.XtraReport
    {
        public RpInitialFixedAsset(DataTable dt, DateTime startDate)
        {
            InitializeComponent();

            this.xrTableCell1.Text = this.xrTableCell1.Text + " " + startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.DataSource = dt;
            SetDataCollumn();
        }

        private void SetDataCollumn()
        {
            this.xrAccountName.DataBindings.Add("Text", this.DataSource, "AccountName");
            this.xrAccumulatedDepreciation.DataBindings.Add("Text", this.DataSource, "AccumulatedDepreciation", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.xrSumAccumulatedDepreciation.DataBindings.Add("Text", this.DataSource, "AccumulatedDepreciation");
            this.xrSumAccumulatedDepreciation.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((this.DataSource as DataTable).Rows.Count > 0)
                this.xrTableCell2.Text = "+";
        }
    }
}
