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
    public partial class ReportAccountTransactionSubjectDetail1 : ReportBase1
    {

        public ReportAccountTransactionSubjectDetail1()
        {
            InitializeComponent();
        }
        public struct Params
        {
            public string PeriodText;
            public string AccountCode;
            public decimal DebitOpenAmount;
            public decimal CreditOpenAmount;
            public decimal DebitCloseAmount;
            public decimal CreditCloseAmount;
            public string SubjectCode;
            public string SubjectName;
        }
        public Params RpParams;
     
        public void BindDataDetail()
        {
            //Header.
            this.lblHeader.Text = RpParams.PeriodText;
            this.cellAccountCode.Text=RpParams.AccountCode;
            this.cellSubjectCode.Text = RpParams.SubjectCode;
            this.cellSubjectName.Text = RpParams.SubjectName;
            this.cellDebitOpenAmount.Text = RpParams.DebitOpenAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.cellCreditOpenAmount.Text = RpParams.CreditOpenAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.cellDebitCloseAmount.Text = RpParams.DebitCloseAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            this.cellCreditCloseAmount.Text = RpParams.CreditCloseAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            //Details
            this.cellAccountTransactionNo.DataBindings.Add("Text", DataSource, "AccountTransactionNo");
            this.cellAccountTransactionDate.DataBindings.Add("Text", DataSource, "AccountTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellDescription.DataBindings.Add("Text", DataSource, "Description");
            this.cellCreditAmount.DataBindings.Add("Text", DataSource, "CreditAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellDebitAmount.DataBindings.Add("Text", DataSource, "DebitAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
       
            //Total.
            this.cellTotalDebitAmount.DataBindings.Add("Text", DataSource, "DebitAmount");
            this.cellTotalCreditAmount.DataBindings.Add("Text", DataSource, "CreditAmount");
            this.cellTotalDebitAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalCreditAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            
        }
      
    }
}
