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
    public partial class RpManufacturePlanWeek : ReportBase1
    {
        /// <summary>
        /// Use to sum quantity of detail from Monday to Sunday
        /// </summary>
        private decimal total=0;
        private decimal totalAll = 0;
        /// <summary>
        /// Not use
        /// </summary>
        public RpManufacturePlanWeek()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Use to call
        /// </summary>
        /// <param name="dataSource"></param>
        public RpManufacturePlanWeek(object dataSource, string stockName)
        {
            InitializeComponent();
            this.DataSource = (dataSource as ManufacturePlanWeek).Detail;
            cellWeekNo.Text = (dataSource as ManufacturePlanWeek).WeekNo.ToString();
            cellYearNo.Text = (dataSource as ManufacturePlanWeek).YearNo.ToString();
            cellStockName.Text = stockName;
            Week w = Week.FromWeekNumber((dataSource as ManufacturePlanWeek).WeekNo, (dataSource as ManufacturePlanWeek).YearNo);
            txtStartDate.Text = w.StartDate.Day.ToString() + "/" + w.StartDate.Month.ToString();
            txtEndDate.Text = w.EndDate.Day.ToString() + "/" + w.EndDate.Month.ToString();
            this.LoadData();
        }
        private void LoadData()
        {
            cellDay1.DataBindings.Add("Text", this.DataSource, "Day1", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellDay2.DataBindings.Add("Text", this.DataSource, "Day2", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellDay3.DataBindings.Add("Text", this.DataSource, "Day3", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellDay4.DataBindings.Add("Text", this.DataSource, "Day4", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellDay5.DataBindings.Add("Text", this.DataSource, "Day5", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellDay6.DataBindings.Add("Text", this.DataSource, "Day6", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellDay7.DataBindings.Add("Text", this.DataSource, "Day7", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellItemCode.DataBindings.Add("Text", this.DataSource, "ItemCode");
            cellDescription.DataBindings.Add("Text", this.DataSource, "Description");

            cellToTalDay1.DataBindings.Add("Text", this.DataSource, "Day1");
            cellToTalDay2.DataBindings.Add("Text", this.DataSource, "Day2");
            cellToTalDay3.DataBindings.Add("Text", this.DataSource, "Day3");
            cellToTalDay4.DataBindings.Add("Text", this.DataSource, "Day4");
            cellToTalDay5.DataBindings.Add("Text", this.DataSource, "Day5");
            cellToTalDay6.DataBindings.Add("Text", this.DataSource, "Day6");
            cellToTalDay7.DataBindings.Add("Text", this.DataSource, "Day7");
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            total = 0;
            cellTotal.Text = "0";
        }

        private void cellDay_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                total += Convert.ToDecimal((sender as XRTableCell).Text);
                totalAll += Convert.ToDecimal((sender as XRTableCell).Text);
                cellTotalAll.Text = totalAll.ToString("N0");
                cellTotal.Text = total.ToString("N0");
            }
            catch 
            {
            }
           
        }
    }
    
}
