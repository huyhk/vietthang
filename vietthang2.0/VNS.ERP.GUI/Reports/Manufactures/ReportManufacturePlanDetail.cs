using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportManufacturePlanDetail : ReportBase1
    {
        public ReportManufacturePlanDetail()
        {
            InitializeComponent();
        }
        public struct Params
        {
            public DateTime Date;
            public string StockName;
            public DataTable dt1;
            public DataTable dt2;
            public string Description;
            public string PlanNo;
        }
        public Params RpParams;
        public void BindDataDetail()
        {
            this.PrintingSystem.ShowMarginsWarning = false;
            this.cellPlanNo.Text = RpParams.PlanNo;
            this.cellDate.Text = RpParams.Date.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.cellStockName.Text = RpParams.StockName;
            this.subreportSizeCode.ReportSource.DataSource = RpParams.dt1;
            this.rpManufacturePlanDetailForSizeCodeSub1.BindDataDetail();
            this.subreportItemCode.ReportSource.DataSource = RpParams.dt2;
            this.rpManufacturePlanDetailForItemCodeSub1.BindDataDetail(RpParams.StockName);
            this.cellDescription.Text = RpParams.Description;

        }

    }
}
