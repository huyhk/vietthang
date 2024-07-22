using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpSaleProductQuatity : ReportBase1
    {
        public RpSaleProductQuatity()
        {
            InitializeComponent();
        }
        public RpSaleProductQuatity(object dataSource, DateTime startDate, DateTime endDate)
        {
            
            InitializeComponent();
          
            txtStartDate.Text = startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtEndDate.Text = endDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.DataSource = dataSource;
            this.LoadData();
            this.PrintingSystem.ShowMarginsWarning = false;
            this.PrintingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
        }
        private void LoadData()
        {
            lbStockName.DataBindings.Add("Text", this.DataSource, "SubjectName");
            cellItemCode.DataBindings.Add("Text", this.DataSource, "ItemCode");
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            cellQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellAmount.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalAmount.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalGroupQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalGroupAmount.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
        }
    }
}
