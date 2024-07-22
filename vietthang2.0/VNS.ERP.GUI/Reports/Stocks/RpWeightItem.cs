using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;
using System.Data;

namespace VNS.ERP.GUI
{
    public partial class RpWeightItem : ReportBase1
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
            public DataTable data;
        }
        public Params RpParams;
        
        public RpWeightItem()
        {
            InitializeComponent();
            
        }
        public void BindData()
        {

            RpSubWeightItem1.Params pr = new RpSubWeightItem1.Params();
            pr.nVCan = this.RpParams.nVCan;
            pr.soBao = this.RpParams.soBao;
            pr.biBao = this.RpParams.biBao;
            pr.lstwir = this.RpParams.lstwir;
            pr.tongBiBao = this.RpParams.tongBiBao;
            
            (this.subreport1.ReportSource as RpSubWeightItem1).RpParams = pr;
            (this.subreport1.ReportSource as RpSubWeightItem1).DataSource = this.RpParams.lstgwidftc;
            (this.subreport1.ReportSource as RpSubWeightItem1).BindData();

            lbStock.Text = this.RpParams.stockName;
            lbNo.Text = this.RpParams.weightItemObj.WeightCode;
            lbDate.Text = this.RpParams.weightItemObj.WeightDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            lbItem.Text = this.RpParams.itemName;
            lbLyDo.Text = this.RpParams.description;
            lbDonVi.Text = this.RpParams.customer;
            lbPTVC.Text = this.RpParams.weightItemObj.PTVanChuyen;
            //lbPTTC.Text = this.RpParams.weightItemObj.PTTayBoa;
            //lbDVVC.Text = this.RpParams.donviVanChuyen;

            DataTable dt1 = this.RpParams.data.Clone();
            DataTable dt2 = this.RpParams.data.Clone();
            DataTable dt3 = this.RpParams.data.Clone();

            for (int i = 0; i < this.RpParams.data.Rows.Count; i++)
            {
                if (i < 5)
                    dt1.ImportRow(this.RpParams.data.Rows[i]);
                else if (i<10)
                    dt2.ImportRow(this.RpParams.data.Rows[i]);
                else
                    dt3.ImportRow(this.RpParams.data.Rows[i]);
            }
            if (dt1.Rows.Count < 5)
                for (int i = dt1.Rows.Count; i < 5; i++)
                    dt1.Rows.Add(dt1.NewRow());
            if (dt2.Rows.Count < 5)
                for (int i = dt2.Rows.Count; i < 5; i++)
                    dt2.Rows.Add(dt2.NewRow());
            if (dt3.Rows.Count < 5)
                for (int i = dt3.Rows.Count; i < 5; i++)
                    dt3.Rows.Add(dt3.NewRow());
            RpWeightItemDetail.Params pr1 = new RpWeightItemDetail.Params();
            RpWeightItemDetail.Params pr2 = new RpWeightItemDetail.Params();
            RpWeightItemDetail.Params pr3 = new RpWeightItemDetail.Params();

            pr1.transportCaption = this.RpParams.transportCaption;
            rpWeightItemDetail1.RpParams = pr1;
            rpWeightItemDetail1.DataSource = dt1;
            rpWeightItemDetail1.BindData();

            pr2.transportCaption = this.RpParams.transportCaption;
            rpWeightItemDetail2.RpParams = pr2;
            rpWeightItemDetail2.DataSource = dt2;
            rpWeightItemDetail2.BindData();

            pr3.transportCaption = this.RpParams.transportCaption;
            rpWeightItemDetail3.RpParams = pr3;
            rpWeightItemDetail3.DataSource = dt3;
            rpWeightItemDetail3.BindData();

            lbWeight1.Text = this.RpParams.weight1.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "kg";
        }
    }
}
