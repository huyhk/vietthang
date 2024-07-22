using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpManufacturePlanMonth : ReportBase1
    {
        public ListBase<Item> lstItem;
        public RpManufacturePlanMonth()
        {
            InitializeComponent();
        }
        public RpManufacturePlanMonth(object dataSource, string stockName, object lstItem)
        {
            InitializeComponent();
            this.lstItem = lstItem as ListBase<Item>;
            this.DataSource = (dataSource as ManufacturePlanMonth).Detail;
            cellMonthNo.Text = (dataSource as ManufacturePlanMonth).MonthNo.ToString();
            cellYearNo.Text = (dataSource as ManufacturePlanMonth).YearNo.ToString();
            cellStockName.Text = stockName;
            this.LoadData();
        }
        private void LoadData()
        {
            cellQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellItemCode.DataBindings.Add("Text", this.DataSource, "ItemCode");
            cellDescription.DataBindings.Add("Text", this.DataSource, "Description");
            cellTotalQuantity.DataBindings.Add("Text", this.DataSource, "Quantity");
        }

        private void cellItemCode_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                cellItemName.Text = lstItem.Search("ItemCode", cellItemCode.Text).ItemName;
            }
            catch 
            {
            }
            
        }

        private void cellItemCode_AfterPrint(object sender, EventArgs e)
        {
            //cellItemName.Text = lstItem.Search("ItemCode", cellItemCode.Text).ItemName;
        }
    }
}
