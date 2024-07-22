/*
 * Tong KHCB tscd tang moi
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
    public partial class RpNewFixedAsset : DevExpress.XtraReports.UI.XtraReport
    {
        public RpNewFixedAsset(DataTable dt, string caption)
        {
            InitializeComponent();
            xrTableCell1.Text = caption;
            this.DataSource = dt;
            SetDataCollumn();
        }
        private void SetDataCollumn()
        {
            this.xrFixedAssetName.DataBindings.Add("Text", this.DataSource, "FixedAssetName");
            this.xrTangtrongky.DataBindings.Add("Text", this.DataSource, "Tangtrongky", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.xrSumTangtrongky.DataBindings.Add("Text", this.DataSource, "Tangtrongky");
            this.xrSumTangtrongky.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if((this.DataSource as DataTable).Rows.Count > 0)
                this.xrTableCell2.Text = "+";
        }
    }
}
