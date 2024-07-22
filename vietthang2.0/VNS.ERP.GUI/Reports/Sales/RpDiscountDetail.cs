using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Windows.Forms;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpDiscountDetail : ReportBase1
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
                if(value)
                {
                    captionDiscount.Text = "Chiết khấu năm";
                }
                else
                {
                    captionDiscount.Text = "Chiết khấu quý";
                }
                
            }
        }
        public RpDiscountDetail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// use
        /// </summary>
        /// <param name="isYearDiscountValue"></param>
        /// <param name="header"></param>
        /// <param name="Source"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public RpDiscountDetail(bool isYearDiscountValue, System.Data.DataRowView header, object Source, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            try
            {
                txtCustomerCode.Text = header["CustomerCode"].ToString();
                txtCustomerName.Text = header["SubjectName"].ToString();
            }
            catch
            {
            }
            
            txtStartDate.Text = startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtEndDate.Text = endDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.IsYearDiscount = isYearDiscountValue;
            this.DataSource = Source;
            this.LoadData();
        }
        private void LoadData()
        {
            cellInvoiceNo.DataBindings.Add("Text", this.DataSource, "InvoiceNo");
            cellSaleRequestDate.DataBindings.Add("Text", this.DataSource, "SaleRequestDate", "{0:" + AppConfigs.CONFIG_DATEFORMAT+"}");
            cellInvoiceAmount.DataBindings.Add("Text", this.DataSource, "InvoiceAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            if (this.IsYearDiscount)
            {
                cellDiscount.DataBindings.Add("Text", this.DataSource, "YearDiscount", AppConfigs.CONFIG_PERCENTFORMAT_STRING);
                cellDiscountAmount.DataBindings.Add("Text", this.DataSource, "YearDiscountAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
                cellTotalDiscountAmount.DataBindings.Add("Text", this.DataSource, "YearDiscountAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            }
            else
            {
                cellDiscount.DataBindings.Add("Text", this.DataSource, "QuarterDiscount", AppConfigs.CONFIG_PERCENTFORMAT_STRING);
                cellDiscountAmount.DataBindings.Add("Text", this.DataSource, "QuarterDiscountAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
                cellTotalDiscountAmount.DataBindings.Add("Text", this.DataSource, "QuarterDiscountAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            }
            cellTotalInvoiceAmount.DataBindings.Add("Text", this.DataSource, "InvoiceAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
        }
    }
}
