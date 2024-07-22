using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using System.Threading;
using System.Globalization;

namespace VNS.ERP.GUI
{
    public partial class RpSale : ReportBase1
    {
        private DateTime d = DateTime.Today;
        private bool reportSaleForYear;
        public bool ReportSaleForYear
        {
            get { return reportSaleForYear; }
            set 
            { 
                reportSaleForYear = value;
                if (value)
                {
                    txtHeader.Text = "BÁO CÁO BÁN HÀNG TRONG NĂM";
                    txt1.Text = "Luỹ kế bán hàng trong năm";
                    txt2.Text = "Luỹ kế bán hàng năm trước";
                    this.d = this.d.AddDays(-(this.d.Day - 1));
                    this.txtStartDate.Text = this.d.AddMonths(-(this.d.Month - 1)).ToString(AppConfigs.CONFIG_DATEFORMAT);
                }
                else
                {
                    this.txtStartDate.Text = d.AddDays(-(d.Day - 1)).ToString(AppConfigs.CONFIG_DATEFORMAT);
                }
            }
        }
        decimal d1, d2, d3=0, d4=0;
        public RpSale()
        {
            InitializeComponent();
        }
        public RpSale(DateTime d, object dsDetail, bool reportSaleForYear)
        {
            InitializeComponent();
            this.d = d;
            this.ReportSaleForYear = reportSaleForYear;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
           
            this.txtEndDate.Text = d.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.DataSource = dsDetail;
            this.LoadData();
        }
        private void LoadData()
        {
            txtProvince.DataBindings.Add("Text", this.DataSource, "ProvinceName");
            cellCustomerCode.DataBindings.Add("Text", this.DataSource, "CustomerCode");
            cellCustomerName.DataBindings.Add("Text", this.DataSource, "SubjectName");
            cellPreviousSaleAmount.DataBindings.Add("Text", this.DataSource, "PreviousSaleAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellPreviousSaleQuantity.DataBindings.Add("Text", this.DataSource, "PreviousSaleQuantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);
            cellRate.DataBindings.Add("Text", this.DataSource, "Rate", "{0:0.00%}");
            cellSaleAmount.DataBindings.Add("Text", this.DataSource, "SaleAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellSaleQuantity.DataBindings.Add("Text", this.DataSource, "SaleQuantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);

            cellTotalPreviousSaleAmount.DataBindings.Add("Text", this.DataSource, "PreviousSaleAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalPreviousSaleQuantity.DataBindings.Add("Text", this.DataSource, "PreviousSaleQuantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);
            cellTotalSaleAmount.DataBindings.Add("Text", this.DataSource, "SaleAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalSaleQuantity.DataBindings.Add("Text", this.DataSource, "SaleQuantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);

            cellTotalGroupPreviousSaleAmount.DataBindings.Add("Text", this.DataSource, "PreviousSaleAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalGroupPreviousSaleQuantity.DataBindings.Add("Text", this.DataSource, "PreviousSaleQuantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);
            cellTotalGroupSaleAmount.DataBindings.Add("Text", this.DataSource, "SaleAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalGroupSaleQuantity.DataBindings.Add("Text", this.DataSource, "SaleQuantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            d1 = 0; d2 = 0;
            cellTotalGroupRate.Text = "0.00%";
            cellTotalRate.Text = "0.00%";
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            d1 += Convert.ToDecimal(GroupHeader1.Report.GetCurrentColumnValue("SaleQuantity"));
            d2 += Convert.ToDecimal(GroupHeader1.Report.GetCurrentColumnValue("PreviousSaleQuantity"));
            d3 += Convert.ToDecimal(GroupHeader1.Report.GetCurrentColumnValue("SaleQuantity"));
            d4 += Convert.ToDecimal(GroupHeader1.Report.GetCurrentColumnValue("PreviousSaleQuantity"));
            if (d2 != 0)
            {
                cellTotalGroupRate.Text = Convert.ToDecimal(d1*100/d2).ToString("N")+"%";
            }
            else
            {
                cellTotalGroupRate.Text = "0.00%";
            }
            if (d4 != 0)
            {
                cellTotalRate.Text = Convert.ToDecimal(d3*100/d4).ToString("N")+"%";
            }
            else
            {
                cellTotalRate.Text = "0.00%";
            }
        }
    }
}
