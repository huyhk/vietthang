using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportAccountTransactionClassificationGeneral : ReportBase1
    {
        public ReportAccountTransactionClassificationGeneral()
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
            this.cellClassificationCode.DataBindings.Add("Text", DataSource, "ClassificationCode");
            this.cellClassificationName.DataBindings.Add("Text", DataSource, "ClassificationName");
            this.cellInAMount.DataBindings.Add("Text", DataSource, "InAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellOutAmount.DataBindings.Add("Text", DataSource, "OutAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            this.cellTotalInAmount.DataBindings.Add("Text", DataSource, "InAmount");
            this.cellTotalOutAmount.DataBindings.Add("Text", DataSource, "OutAmount");
          
            //Total.
          
            this.cellTotalInAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.cellTotalOutAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
          
        }
    }
}
