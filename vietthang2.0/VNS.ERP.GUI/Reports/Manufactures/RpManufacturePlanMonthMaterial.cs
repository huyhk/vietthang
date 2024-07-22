using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Utils;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpManufacturePlanMonthMaterial : ReportBase1
    {
        public RpManufacturePlanMonthMaterial()
        {
            InitializeComponent();
        }
        public RpManufacturePlanMonthMaterial(object dataSourceHeader, object dataSourceDetail, string stockName)
        {
            InitializeComponent();
            this.DataSource = dataSourceDetail;
            cellStockName.Text = stockName;
            cellMonthNo.Text = (dataSourceHeader as ManufacturePlanMonth).MonthNo.ToString();
            cellYearNo.Text = (dataSourceHeader as ManufacturePlanMonth).YearNo.ToString();
            Week w = Week.FromWeekNumber((dataSourceHeader as ManufacturePlanMonth).MonthNo, (dataSourceHeader as ManufacturePlanMonth).YearNo);
            this.LoadData();
        }
        private void LoadData()
        {
            cellQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellItemCode.DataBindings.Add("Text", this.DataSource, "MaterialCode");
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            cellDescription.DataBindings.Add("Text", this.DataSource, "Description");
            cellTotalQuantity.DataBindings.Add("Text", this.DataSource, "Quantity");
        }
    }
}
