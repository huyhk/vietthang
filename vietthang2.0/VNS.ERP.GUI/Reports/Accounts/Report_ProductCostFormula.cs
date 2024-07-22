using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using VNS.ERP.Data.Accounting;

namespace VNS.ERP.GUI.Reports.Accounts
{
    public partial class Report_ProductCostFormula : ReportBase2
    {
        public System.Data.DataTable Table;
        public string Kyketoan;
        public Report_ProductCostFormula()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            this.DataSource = Table;
            this.lblKyketoan.Text += Kyketoan;
            this.txtProductCode.DataBindings.Add("Text", DataSource, "ProductCode");
            this.txtTotalCostAmount.DataBindings.Add("Text", DataSource, "TotalCostAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.txtMaterialCode.DataBindings.Add("Text", DataSource, "MaterialCode");
            this.txtMaterialName.DataBindings.Add("Text", DataSource, "MaterialName");
            this.txtQuantity.DataBindings.Add("Text", DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtCostPrice.DataBindings.Add("Text", DataSource, "CostPrice", AppConfigs.CONFIG_PRICEVNFORMAT_STRING);
            this.txtCostAmount.DataBindings.Add("Text", DataSource, "CostAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
        }

        int i = 0;
        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (i > 0)
                GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
            i++;
        }

      

 


    }
}
