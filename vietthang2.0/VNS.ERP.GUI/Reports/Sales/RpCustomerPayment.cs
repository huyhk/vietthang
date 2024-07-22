using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpCustomerPayment : ReportBase1
    {
        public RpCustomerPayment()
        {
            InitializeComponent();
        }
        public RpCustomerPayment(DataView dv)
        {
            InitializeComponent();
            this.DataSource = dv.ToTable();
            BindDataDetail();
        }

        public void BindDataDetail()
        {
            this.cellPaymentNo.DataBindings.Add("Text", DataSource, "PaymentNo");
            this.cellDescription.DataBindings.Add("Text", DataSource, "Description");
            this.cellPaymentDate.DataBindings.Add("Text", DataSource, "PaymentDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellCustomerCode.DataBindings.Add("Text", DataSource, "CustomerCode");
            this.cellSubjectName.DataBindings.Add("Text", DataSource, "SubjectName");
            this.cellAmount.DataBindings.Add("Text", DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.celTotalAmount.DataBindings.Add("Text", DataSource, "Amount");
             this.celTotalAmount.Summary.FormatString= AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }
        public void BindDataMaster(ArrayList array)
        {
            this.cellTungay.Text = array[0].ToString();
            this.cellDenngay.Text = array[1].ToString();
        }

    }
}
