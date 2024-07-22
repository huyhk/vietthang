using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpCustomerDept : ReportBase1
    {
        public RpCustomerDept()
        {
            InitializeComponent();
        }
        public RpCustomerDept(DateTime startDate, DateTime endDate, object dsDetail)
        {
            InitializeComponent();
            txtStartDate.Text = startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtEndDate.Text = endDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.DataSource = dsDetail;
            this.LoadData();
            cellTotalOpening.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalPeriodSaleQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING;
            cellTotalPeriodSaleAmount.Summary.FormatString=AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalPeriodPaymentAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalClose.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }
        private void LoadData()
        {

            txtProvince.DataBindings.Add("Text", this.DataSource, "ProvinceName");
            cellCustomerCode.DataBindings.Add("Text", this.DataSource, "CustomerCode");
            cellCustomerName.DataBindings.Add("Text", this.DataSource, "SubjectName");
            cellClose.DataBindings.Add("Text", this.DataSource, "CloseAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellOpening.DataBindings.Add("Text", this.DataSource, "OpenAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellPeriodPaymentAmount.DataBindings.Add("Text", this.DataSource, "PeriodPaymentAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellPeriodSaleAmount.DataBindings.Add("Text", this.DataSource, "PeriodSaleAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellPeriodSaleQuantity.DataBindings.Add("Text", this.DataSource, "PeriodSaleQuantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);

            cellTotalClose.DataBindings.Add("Text", this.DataSource, "CloseAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalOpening.DataBindings.Add("Text", this.DataSource, "OpenAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalPeriodPaymentAmount.DataBindings.Add("Text", this.DataSource, "PeriodPaymentAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalPeriodSaleAmount.DataBindings.Add("Text", this.DataSource, "PeriodSaleAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellTotalPeriodSaleQuantity.DataBindings.Add("Text", this.DataSource, "PeriodSaleQuantity", AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING);
        }
    }
}
