using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class ReportAccountTransactionSubjectDetail2 : ReportBase1
    {
        private decimal amount = 0;
        private decimal totalSoduNo = 0;
        private decimal totalSoduCo = 0;
        public ReportAccountTransactionSubjectDetail2()
        {
            InitializeComponent();
        }
        public struct Params
        {

            public string PeriodText;
            public string AccountCode;
            public string SubjectCode;
            public decimal DebitOpenAmount;
            public decimal CreditOpenAmount;
            public decimal DebitCloseAmount;
            public decimal CreditCloseAmount;
            public string SubjectName;
            public string Ngaymoso;

        }
        public Params RpParams;
        public void BindDataDetail()
        {
            //Header.
            amount = RpParams.DebitOpenAmount - RpParams.CreditOpenAmount;
            this.cellNgaymoso.Text = RpParams.Ngaymoso;
            this.lblHeader.Text = RpParams.PeriodText;
            this.cellAccountCode.Text=RpParams.AccountCode;
            this.cellSubjectCode.Text = RpParams.SubjectCode;
            this.cellSubjectName.Text = RpParams.SubjectName;
            this.cellDebitOpenAmount.Text = RpParams.DebitOpenAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.cellCreditOpenAmount.Text = RpParams.CreditOpenAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.cellDebitCloseAmount.Text = RpParams.DebitCloseAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.cellCreditCloseAmount.Text = RpParams.CreditCloseAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            //Details
            this.cellAccountTransactionDate.DataBindings.Add("Text", DataSource, "AccountTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellAccountTransactionNo.DataBindings.Add("Text", DataSource, "AccountTransactionNo");
            this.cellNgayCT.DataBindings.Add("Text", DataSource, "NgayCT", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellDescription.DataBindings.Add("Text", DataSource, "Description");
            this.cellCreditAmount.DataBindings.Add("Text", DataSource, "CreditAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellDebitAmount.DataBindings.Add("Text", DataSource, "DebitAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellDUAccountCode.DataBindings.Add("Text", DataSource, "DUAccountCode");
            //Total.
            this.cellTotalDebitAmount.DataBindings.Add("Text", DataSource, "DebitAmount");
            this.cellTotalCreditAmount.DataBindings.Add("Text", DataSource, "CreditAmount");
            this.cellTotalDebitAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalCreditAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            object obj = this.GetCurrentRow();
            amount = amount + (decimal)((obj as DataRowView)["DebitAmount"]) - (decimal)((obj as DataRowView)["CreditAmount"]);
            if (amount >= 0)
            {
                this.cellSoduNo.Text = amount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
                this.cellSOduCo.Text = "0";
                totalSoduNo += amount;
            }
            else
            {
                this.cellSOduCo.Text = ((decimal)(0 - amount)).ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
                this.cellSoduNo.Text = "0";
                totalSoduCo = totalSoduCo - amount;
            }
            //this.cellTotalSoduNo.Text = totalSoduNo.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            //this.cellTotalSoduCo.Text = totalSoduCo.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
        }
    }
}
