using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class RpSubWeightItem1 : DevExpress.XtraReports.UI.XtraReport
    {
        bool isStartRow = true;
        public struct Params
        {
            public string nVCan;
            public decimal soBao;
            public decimal biBao;
            public decimal tongBiBao;
            public ListBase<WeightItemResult> lstwir;
        }
        public Params RpParams;
        public RpSubWeightItem1()
        {
            InitializeComponent();
            //cellTotalCan.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTotalKLuong.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING + " kg";
        }
        public void BindData()
        {
            RpSubWeightItem2.Params pr = new RpSubWeightItem2.Params();
            pr.soBao = this.RpParams.soBao;
            pr.biBao = this.RpParams.biBao;
            pr.tongBiBao = this.RpParams.tongBiBao;
           // pr.lstwir = this.RpParams.lstwir;

            (this.subreport1.ReportSource as RpSubWeightItem2).RpParams = pr;
            (this.subreport1.ReportSource as RpSubWeightItem2).DataSource = this.RpParams.lstwir;
            (this.subreport1.ReportSource as RpSubWeightItem2).BindData();

            cellNVCan.Text = this.RpParams.nVCan;
            cellXe.DataBindings.Add("Text", this.DataSource, "StockTransportCode");
            cellSLan.DataBindings.Add("Text", this.DataSource, "Count", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            //cellTotalCan.DataBindings.Add("Text", this.DataSource, "Count");
            cellBiXe.DataBindings.Add("Text", this.DataSource, "SkinTransport", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            cellKLuong.DataBindings.Add("Text", this.DataSource, "TotalWeight", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            cellTotalKLuong.DataBindings.Add("Text", this.DataSource, "TotalWeight");
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.isStartRow)
            {
                lbNVCan.Visible = true;
                lbNguoiGiao.Visible = true;
                this.isStartRow = false;
            }
            else
            {
                lbNVCan.Visible = false;
                lbNguoiGiao.Visible = false;
            }
        }
    }
}
