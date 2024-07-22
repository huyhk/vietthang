using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormListInstrumentTransaction : FormEditBase
    {
        InstrumentTransactionAccountBLL bll = new InstrumentTransactionAccountBLL();
        private string accountTransactionTypeCode;
        /// <summary>
        /// Get or set AccountTransactionTypeCode property
        /// </summary>
        public string AccountTransactionTypeCode
        {
            get { return accountTransactionTypeCode; }
            set
            {
                accountTransactionTypeCode = value;
            }
        }
        private string transactionType;
        public string TransactionType
        {
            get
            {
                return transactionType;
            }
            set
            {
                transactionType = value;
            }
        }
        public FormListInstrumentTransaction()
        {
            InitializeComponent();
        }
        public FormListInstrumentTransaction(string accountTransactionTypeCodeValue, string transType, string text)
        {
            InitializeComponent();
            this.Business = bll;
            
            this.AccountTransactionTypeCode = accountTransactionTypeCodeValue;
            this.TransactionType = transType;
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
//            this.DataSource = bll.GetByTransactionTypeForPeriod(this.TransactionType, Contexts.WorkingStartDate, Contexts.WorkingEndDate);
            this.Text = text;
        }
        public override void AddNewItem()
        {
            FormInstrumentTransaction f = new FormInstrumentTransaction(this.AccountTransactionTypeCode, this.TransactionType, this.Text);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<InstrumentTransactionAccount>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl.RefreshDataSource();
            this.RefreshButtons();
        }
        public override void EditItem()
        {
            FormInstrumentTransaction f = new FormInstrumentTransaction(this.AccountTransactionTypeCode, this.TransactionType, this.Text);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            // f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<InstrumentTransactionAccount>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl.RefreshDataSource();
            this.RefreshButtons();
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            FormInstrumentTransaction f = new FormInstrumentTransaction(this.AccountTransactionTypeCode, this.TransactionType, this.Text);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<InstrumentTransactionAccount>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl.RefreshDataSource();
            this.RefreshButtons();
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            this.DataSource = bll.GetWithDetailByTransactionTypeForPeriod(this.TransactionType, p.StartDate, p.EndDate);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (btnLoadData.Text == "+")
            {
                for (int i = 0; i < gridView.RowCount; i++)
                    gridView.SetMasterRowExpanded(i, true);
                btnLoadData.Text = "-";
            }
            else
            {
                gridView.CollapseAllDetails();
                //gridView.setmw
                btnLoadData.Text = "+";
            }
        }
    }
}