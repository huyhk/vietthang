using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows.Forms;

namespace VNS.ERP.GUI.UserControl
{
    public partial class UCInstrumentTransactionAccount : UCAccountTransaction
    {
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
                this.ucInstrumentTransaction1.TransactionType = value;
            }
        }
        public UCInstrumentTransactionAccount()
        {
            InitializeComponent();
            tabControl1.TabPages[0].Controls.Add(this.panelControl1);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tabControl1.SelectedIndex = 1;
            //tabPage2.Select();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
        }
        protected override void AssignData()
        {
            base.AssignData();
        }
        public override bool Save()
        {
            this.AssignData();
            this.ucInstrumentTransaction1.Business = this.Business;

            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int iError = this.ValidateData();

            if (iError != 0)
            {
                OnError(iError, messageType);
                return false;
            }

            bool ret = this.ucInstrumentTransaction1.Save();
            //if (ret) ret = base.Save();
            return ret;
        }
        protected override int ValidateData()
        {
            if (this.AccountTransactionDate.Month != this.ucInstrumentTransaction1.TransactionDate.Month || this.AccountTransactionDate.Year != this.ucInstrumentTransaction1.TransactionDate.Year)
            {
                return -157;
            }
            return base.ValidateData();
        }
        protected override void BindData()
        {
            base.BindData();
            InstrumentTransactionAccount t = this.DataSource as InstrumentTransactionAccount;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                t.InstrTrans = new InstrumentTransaction();
            }
            this.ucInstrumentTransaction1.DataSource = t;
        }
        public override void Cancel()
        {
            base.Cancel();
        }
        public override void RefreshControl()
        {
            base.RefreshControl();
            this.ucInstrumentTransaction1.EditMode = this.EditMode;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                tabControl1.SelectedIndex = 1;
            }
            //if (this.DataSource == null) this.ucInstrumentTransaction1.DataSource = null;
            this.ucInstrumentTransaction1.RefreshControl();
        }
    }
}
