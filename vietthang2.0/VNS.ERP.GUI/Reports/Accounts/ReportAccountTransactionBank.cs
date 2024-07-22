using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Reports.Accounts
{
    public partial class ReportAccountTransactionBank : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportAccountTransactionBank()
        {
            InitializeComponent();
        }
        public ReportAccountTransactionBank(DataTable dtSources, string bankName, string bankAccountNo, decimal opening, DateTime startDate)
        {
            InitializeComponent();

            ModuleAccounting md = new ModuleBLL().GetModuleAccounting();

            xrTableCell2.Text = md.TenDonvi;
            xrTableCell4.Text = md.Diachi;

            this.txtBankName.Text = bankName;
            this.txtBankAccount.Text = bankAccountNo;
            decimal sumDebitAmount = 0;
            decimal sumCreditAmount = 0;
            decimal remainAmount = 0;
            remainAmount = opening;

            DataColumn col = new DataColumn("RemainAmount", typeof(decimal));
            dtSources.Columns.Add(col);
            foreach (DataRow row in dtSources.Rows)
            {
                remainAmount = remainAmount + (decimal)row["DebitAmount"] - (decimal)row["CreditAmount"];
                row["RemainAmount"] = remainAmount;
                sumDebitAmount = sumDebitAmount + (decimal)row["DebitAmount"];
                sumCreditAmount = sumCreditAmount + (decimal)row["CreditAmount"];
            }
            this.cellOpenAmount.Text = opening.ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
            this.cellTotalDebit.Text = this.cellTotalDebit2.Text = sumDebitAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
            this.cellTotalCredit.Text = this.cellTotalCredit2.Text = sumCreditAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
            this.cellCloseAmount.Text = remainAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

            this.cellNgaymoso.Text = startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.DataSource = dtSources;
            SetDatacollumn();
        }
        private void SetDatacollumn()
        {
            this.cellAccountTransactionDate.DataBindings.Add("Text", DataSource, "AccountTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellDebitAccountNo.DataBindings.Add("Text", DataSource, "AccountTransactionNo");
            this.cellCreditAccountNo.DataBindings.Add("Text", DataSource, "NgayCT", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellDescription.DataBindings.Add("Text", DataSource, "Description");
            this.cellAccountCodeDU.DataBindings.Add("Text", DataSource, "DUAccountCode");
            this.cellDebitAmount.DataBindings.Add("Text", DataSource, "DebitAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.cellCreditAmount.DataBindings.Add("Text", DataSource, "CreditAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.cellOpenning.DataBindings.Add("Text", DataSource, "RemainAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            //this.cellGhichu.DataBindings.Add("Text", DataSource, "AccountTransactionDate");
        }
    }
}
