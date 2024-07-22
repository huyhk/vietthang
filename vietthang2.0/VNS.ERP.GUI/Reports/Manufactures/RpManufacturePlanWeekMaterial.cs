using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpManufacturePlanWeekMaterial : ReportBase1
    {
        public RpManufacturePlanWeekMaterial()
        {
            InitializeComponent();
        }
        public RpManufacturePlanWeekMaterial(object dataSourceHeader, object dataSourceDetail, string stockName)
        {
            InitializeComponent();
            this.DataSource = dataSourceDetail;
            cellStockName.Text = stockName;
            cellWeekNo.Text = (dataSourceHeader as ManufacturePlanWeek).WeekNo.ToString();
            cellYearNo.Text = (dataSourceHeader as ManufacturePlanWeek).YearNo.ToString();
            Week w = Week.FromWeekNumber((dataSourceHeader as ManufacturePlanWeek).WeekNo, (dataSourceHeader as ManufacturePlanWeek).YearNo);
            txtStartDate.Text = w.StartDate.Day.ToString() + "/" + w.StartDate.Month.ToString();
            txtEndDate.Text = w.EndDate.Day.ToString() + "/" + w.EndDate.Month.ToString();
            this.LoadData();
        }
        private void LoadData()
        {
            cellDay1.DataBindings.Add("Text", this.DataSource, "Day1", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDay2.DataBindings.Add("Text", this.DataSource, "Day2", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDay3.DataBindings.Add("Text", this.DataSource, "Day3", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDay4.DataBindings.Add("Text", this.DataSource, "Day4", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDay5.DataBindings.Add("Text", this.DataSource, "Day5", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDay6.DataBindings.Add("Text", this.DataSource, "Day6", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDay7.DataBindings.Add("Text", this.DataSource, "Day7", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotal.DataBindings.Add("Text", this.DataSource, "Total", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            cellDescription.DataBindings.Add("Text", this.DataSource, "Description");

            cellToTalDay1.DataBindings.Add("Text", this.DataSource, "Day1");
            cellToTalDay2.DataBindings.Add("Text", this.DataSource, "Day2");
            cellToTalDay3.DataBindings.Add("Text", this.DataSource, "Day3");
            cellToTalDay4.DataBindings.Add("Text", this.DataSource, "Day4");
            cellToTalDay5.DataBindings.Add("Text", this.DataSource, "Day5");
            cellToTalDay6.DataBindings.Add("Text", this.DataSource, "Day6");
            cellToTalDay7.DataBindings.Add("Text", this.DataSource, "Day7");
            cellTotalAll.DataBindings.Add("Text", this.DataSource, "Total");
        }
    }
}
