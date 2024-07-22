using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpCustomerDeptOpening : ReportBase1
    {
        public RpCustomerDeptOpening()
        {
            InitializeComponent();
        }
        public RpCustomerDeptOpening(DataView dv)
        {
            InitializeComponent();
            dv.Sort = "InvoiceDate ASC";
            this.DataSource = dv.ToTable();
            BindDataDetail();
        }
        public void BindDataDetail()
        {
           
            this.cellInvoiceNo.DataBindings.Add("Text", DataSource, "InvoiceNo");
            this.cellInvoiceDate.DataBindings.Add("Text", DataSource, "InvoiceDate",AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellCustomerCode.DataBindings.Add("Text", DataSource, "CustomerCode");
            this.cellSubjectName.DataBindings.Add("Text", DataSource, "SubjectName");
            this.cellStockCode.DataBindings.Add("Text", DataSource, "StockCode");
            this.cellOrgAmount.DataBindings.Add("Text", DataSource, "OrgAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellPaidAmount.DataBindings.Add("Text", DataSource, "PaidAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellRemainAmount.DataBindings.Add("Text", DataSource, "RemainAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellDueDate.DataBindings.Add("Text", DataSource, "DueDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellTotalRemainAmount.DataBindings.Add("Text", DataSource, "RemainAmount");
            this.cellTotalPaidAmount.DataBindings.Add("Text", DataSource, "PaidAmount");
            this.cellTotalOrgAmount.DataBindings.Add("Text", DataSource, "OrgAmount");
    

           
        }
        public void BindDataMaster(string ngay)
        {
            this.cellNgay.Text =ngay;
        }
        private void cellDueDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (cellDueDate.Text != "")
            {
                //((DateTime) this.GetCurrentColumnValue("DueDate")<=(DateTime) this.GetCurrentColumnValue("DueDate"))
                if (DateTime.ParseExact(cellDueDate.Text, AppConfigs.CONFIG_DATEFORMAT,null) <= DateTime.ParseExact(this.cellNgay.Text, AppConfigs.CONFIG_DATEFORMAT,null))
                    this.cellDueDate.BackColor = Color.Red;
                else
                    this.cellDueDate.BackColor = Color.Empty;
            }
            else
                this.cellDueDate.BackColor = Color.Empty;
           
        }
    }
}
