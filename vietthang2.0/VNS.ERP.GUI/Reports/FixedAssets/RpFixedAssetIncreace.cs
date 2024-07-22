/*
 * Tong so KHCB tscd luy ke cuoi thang
 */
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
    public partial class RpFixedAssetIncreace : DevExpress.XtraReports.UI.XtraReport
    {
        public RpFixedAssetIncreace( DataTable dt, DateTime date)
        {
            InitializeComponent();
            this.xrTableCell1.Text = "Tổng số KHCB TSCD trích tháng " + date.Month.ToString() + " năm " + date.Year.ToString();
            this.DataSource = dt;
            SetDataCollumn();
        }

        private void SetDataCollumn()
        {
            this.xrAccountName.DataBindings.Add("Text", this.DataSource, "AccountName");
            this.xrDepreciationInput.DataBindings.Add("Text", this.DataSource, "DepreciationInput", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.xrSumDepreciationInput.DataBindings.Add("Text", this.DataSource, "DepreciationInput");
            this.xrSumDepreciationInput.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((this.DataSource as DataTable).Rows.Count > 0)
                this.xrTableCell2.Text = "+";
        }
    }
}
