using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpDiscount : ReportBase1
    {
        private bool isYearDiscount;
        /// <summary>
        /// true: Use case YearDiscount, else: QuarterDiscount
        /// </summary>
        public bool IsYearDiscount
        {
            get { return isYearDiscount; }
            set
            {
                isYearDiscount = value;
                if (value)
                {
                    txtTotalDiscount.Text += " năm";
                }
                else
                {
                    txtTotalDiscount.Text += " quý";
                }
            }
        }
        public RpDiscount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// use
        /// </summary>
        /// <param name="isYearDiscountValue"></param>
        /// <param name="Source"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public RpDiscount(bool isYearDiscountValue, object Source, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            txtStartDate.Text = startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtEndDate.Text = endDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.IsYearDiscount = isYearDiscountValue;
            this.DataSource = Source;
            this.LoadData();
        }
        private void LoadData()
        {
            txtProvince.DataBindings.Add("Text", this.DataSource, "ProvinceName");
            cellCustomerCode.DataBindings.Add("Text", this.DataSource, "CustomerCode");
            cellCustomerName.DataBindings.Add("Text", this.DataSource, "SubjectName");
            cellInvoiceAmount.DataBindings.Add("Text", this.DataSource, "InvoiceAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            if (this.IsYearDiscount)
            {
                cellDiscountAmount.DataBindings.Add("Text", this.DataSource, "YearDiscountAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
                cellTotalDiscountAmount.DataBindings.Add("Text", this.DataSource, "YearDiscountAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            }
            else
            {
                cellDiscountAmount.DataBindings.Add("Text", this.DataSource, "QuarterDiscountAmount", "{0:n2}");
                cellTotalDiscountAmount.DataBindings.Add("Text", this.DataSource, "QuarterDiscountAmount", "{0:n2}");
            }
            cellTotalInvoiceAmount.DataBindings.Add("Text", this.DataSource, "InvoiceAmount", "{0:n2}");
        }
    }
}
