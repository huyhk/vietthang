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
    public partial class ReportAccountTransactionClassificationDetail1 : ReportBase1
    {

        public ReportAccountTransactionClassificationDetail1()
        {
            InitializeComponent();
        }
        public struct Params
        {
            public string PeriodText;
            public string AccountCode;
            public string ClassificationCode;
            public string ClassificationName;
        }
        public Params RpParams;
     
        public void BindDataDetail()
        {
            //Header.
            this.lblHeader.Text = RpParams.PeriodText;
            this.cellAccountCode.Text=RpParams.AccountCode;
            this.cellClassificationCode.Text = RpParams.ClassificationCode;
            this.cellClassificationName.Text = RpParams.ClassificationName;
         
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
