using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpSubWeightItem2 : DevExpress.XtraReports.UI.XtraReport
    {
        public struct Params
        {
            public decimal soBao;
            public decimal biBao;
            public decimal tongBiBao;
        }
        public Params RpParams;
        public RpSubWeightItem2()
        {
            InitializeComponent();
            cellTotal.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING+" kg";
        }
        public void BindData()
        {
            cellSoBao.Text = this.RpParams.soBao.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            cellBiBao.Text = this.RpParams.biBao.ToString(AppConfigs.CONFIG_QUANTITYFORMAT+" kg");
            cellTongBiBao.Text = this.RpParams.tongBiBao.ToString(AppConfigs.CONFIG_QUANTITYFORMAT+" kg");

            cellCayHang.DataBindings.Add("Text", this.DataSource, "StockLocationCode");
            cellTL.DataBindings.Add("Text", this.DataSource, "Weight", AppConfigs.CONFIG_QUANTITYFORMAT_STRING+"kg");
            cellTotal.DataBindings.Add("Text", this.DataSource, "Weight");
        }
        private int detailCount = 1;
        private void xrTableRow2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (detailCount > 1)
                this.xrTableRow2.Visible = false;
            detailCount++;
        }
    }
}
