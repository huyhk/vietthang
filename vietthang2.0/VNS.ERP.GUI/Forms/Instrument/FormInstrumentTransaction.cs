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

namespace VNS.ERP.GUI
{
    public partial class FormInstrumentTransaction : FormEditBase
    {
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
                this.ucInstrumentTransactionAccount1.AccountTransactionTypeCode = value;
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
                this.ucInstrumentTransactionAccount1.TransactionType = value;
            }
        }
        InstrumentTransactionAccountBLL bll = new InstrumentTransactionAccountBLL();
        public FormInstrumentTransaction()
        {
            InitializeComponent();
            this.Business = bll;
        }
        public FormInstrumentTransaction(string accTransTypeCode, string transType, string text)
        {
            InitializeComponent();
            this.Business = bll;
            //this.ucInstrumentTransactionAccount1.Business = bll;
            this.TransactionType = transType;
            this.AccountTransactionTypeCode = accTransTypeCode;
            this.MessagePrefix = "FormEditAccountTransaction-";
            this.LayoutFile = "FormEditAccountTransaction.xml";
            this.Text = text;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Maximized;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.EditMode != VNS.Windows.FormEditMode.VIEW) this.CancelItem();
            base.OnClosing(e);
        }
        public override void CancelItem()
        {
            base.CancelItem();
        }
    }
}