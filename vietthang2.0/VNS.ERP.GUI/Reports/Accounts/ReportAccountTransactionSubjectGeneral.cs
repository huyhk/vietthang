using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportAccountTransactionSubjectGeneral : ReportBase1
    {
        public ReportAccountTransactionSubjectGeneral()
        {
            InitializeComponent();
        }
        public struct Params
        {

            public string PeriodText;
           
        }
        public Params RpParams;
        public void BindDataDetail()
        {
            //Header.
            this.lblHeader.Text = RpParams.PeriodText;
            //Details.
            this.cellAccountCode.DataBindings.Add("Text", DataSource, "AccountCode");
            this.cellSubjectCode.DataBindings.Add("Text", DataSource, "SubjectCode");
            this.cellSubjectName.DataBindings.Add("Text", DataSource, "SubjectName");
            this.cellDebitOpenAmount.DataBindings.Add("Text", DataSource, "DebitOpenAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellCreditOpenAmount.DataBindings.Add("Text", DataSource, "CreditOpenAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellInAMount.DataBindings.Add("Text", DataSource, "InAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellOutAmount.DataBindings.Add("Text", DataSource, "OutAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellDebitCloseAmount.DataBindings.Add("Text", DataSource, "DebitCloseAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellCreditCloseAmount.DataBindings.Add("Text", DataSource, "CreditCloseAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellTotalDebitOpenAmount.DataBindings.Add("Text", DataSource, "DebitOpenAmount");
            this.cellTotalCreditOpenAmount.DataBindings.Add("Text", DataSource, "CreditOpenAmount");
            this.cellTotalInAmount.DataBindings.Add("Text", DataSource, "InAmount");
            this.cellTotalOutAmount.DataBindings.Add("Text", DataSource, "OutAmount");
            this.cellTotalDebitCloseAmount.DataBindings.Add("Text", DataSource, "DebitCloseAmount");
            this.cellTotalCreditCloseAmount.DataBindings.Add("Text", DataSource, "CreditCloseAmount");
            //Total.
            this.cellTotalDebitOpenAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalCreditOpenAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalInAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalOutAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalDebitCloseAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalCreditCloseAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }
    }
}
