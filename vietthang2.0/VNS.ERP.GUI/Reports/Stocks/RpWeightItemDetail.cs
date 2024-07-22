using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpWeightItemDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public struct Params
        {
            public string nVCan;
            public decimal soBao;
            public decimal biBao;
            public decimal tongBiBao;

            public string stockName;
            public WeightItem weightItemObj;
            public decimal weight1;
            public string[] transportCaption;
            public string donviVanChuyen;
            public string itemName;
            public string description;
            public string customer;
            public ListBase<GroupWeightItemDetailForTransportCode> lstgwidftc;
            public ListBase<WeightItemResult> lstwir;
        }
        public Params RpParams;

        public RpWeightItemDetail()
        {
            InitializeComponent();
            cellTotalTL1.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalTL2.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalTL3.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalTL4.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalTL5.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalTL6.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalSB1.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalSB2.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalSB3.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalSB4.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalSB5.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
            cellTotalSB6.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMATZ_STRING;
        }
        public void BindData()
        {
           
            
            lbXe1.Text = this.RpParams.transportCaption[0];
            lbXe2.Text = this.RpParams.transportCaption[1];
            lbXe3.Text = this.RpParams.transportCaption[2];
            lbXe4.Text = this.RpParams.transportCaption[3];
            lbXe5.Text = this.RpParams.transportCaption[4];
            lbXe6.Text = this.RpParams.transportCaption[5];
            //lbWeight1.Text = this.RpParams.weight1.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "kg";

            cellSoLo1.DataBindings.Add("Text", this.DataSource, "SL1");
            cellSoLo2.DataBindings.Add("Text", this.DataSource, "SL2");
            cellSoLo3.DataBindings.Add("Text", this.DataSource, "SL3");
            cellSoLo4.DataBindings.Add("Text", this.DataSource, "SL4");
            cellSoLo5.DataBindings.Add("Text", this.DataSource, "SL5");
            cellSoLo6.DataBindings.Add("Text", this.DataSource, "SL6");

            cellTLuong1.DataBindings.Add("Text", this.DataSource, "TL1", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTLuong2.DataBindings.Add("Text", this.DataSource, "TL2", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTLuong3.DataBindings.Add("Text", this.DataSource, "TL3", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTLuong4.DataBindings.Add("Text", this.DataSource, "TL4", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTLuong5.DataBindings.Add("Text", this.DataSource, "TL5", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTLuong6.DataBindings.Add("Text", this.DataSource, "TL6", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);

            cellTotalTL1.DataBindings.Add("Text", this.DataSource, "TL1", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalTL2.DataBindings.Add("Text", this.DataSource, "TL2", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalTL3.DataBindings.Add("Text", this.DataSource, "TL3", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalTL4.DataBindings.Add("Text", this.DataSource, "TL4", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalTL5.DataBindings.Add("Text", this.DataSource, "TL5", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalTL6.DataBindings.Add("Text", this.DataSource, "TL6", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);

            cellSBao1.DataBindings.Add("Text", this.DataSource, "SB1", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSBao2.DataBindings.Add("Text", this.DataSource, "SB2", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSBao3.DataBindings.Add("Text", this.DataSource, "SB3", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSBao4.DataBindings.Add("Text", this.DataSource, "SB4", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSBao5.DataBindings.Add("Text", this.DataSource, "SB5", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSBao6.DataBindings.Add("Text", this.DataSource, "SB6", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);

            cellTotalSB1.DataBindings.Add("Text", this.DataSource, "SB1", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalSB2.DataBindings.Add("Text", this.DataSource, "SB2", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalSB3.DataBindings.Add("Text", this.DataSource, "SB3", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalSB4.DataBindings.Add("Text", this.DataSource, "SB4", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalSB5.DataBindings.Add("Text", this.DataSource, "SB5", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalSB6.DataBindings.Add("Text", this.DataSource, "SB6", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
        }

        private void celTongTrongluong_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal tongTrongluong = Convert.ToDecimal(cellTotalTL1.Summary.GetResult()) + Convert.ToDecimal(cellTotalTL2.Summary.GetResult())
                + Convert.ToDecimal(cellTotalTL3.Summary.GetResult()) + Convert.ToDecimal(cellTotalTL4.Summary.GetResult())
                + Convert.ToDecimal(cellTotalTL5.Summary.GetResult()) + Convert.ToDecimal(cellTotalTL6.Summary.GetResult());
            celTongTrongluong.Text = tongTrongluong.ToString("#,###.##");
        }

        private void celTongSobao_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal tongSobao = Convert.ToDecimal(cellTotalSB1.Summary.GetResult()) + Convert.ToDecimal(cellTotalSB2.Summary.GetResult())
            + Convert.ToDecimal(cellTotalSB3.Summary.GetResult()) + Convert.ToDecimal(cellTotalSB4.Summary.GetResult())
            + Convert.ToDecimal(cellTotalSB5.Summary.GetResult()) + Convert.ToDecimal(cellTotalSB6.Summary.GetResult());
            celTongSobao.Text = tongSobao.ToString("#,###");
        }
    }
}
