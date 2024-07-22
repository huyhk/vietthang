using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows.Controls;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class UCAccountTransactionTypeDetail : EditControlBase
    {
       
        public UCAccountTransactionTypeDetail()
        {
            InitializeComponent();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                this.cboTransactionTypeCode.Properties.DataSource = EnumDisplays.GetListenumAccountTransactionTypeForBank();
            }
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.cboTransactionTypeCode.EditValue = (this.DataSource as AccountTransactionTypeDetail).TransactionTypeCode;
                this.txtDetailTransactionCode.Text = (this.DataSource as AccountTransactionTypeDetail).DetailTransactionCode;
                this.txtDetailTransactionName.Text = (this.DataSource as AccountTransactionTypeDetail).DetailTransactionName;
                this.txtDescription.Text = (this.DataSource as AccountTransactionTypeDetail).Description;
            }
        }
        protected override int ValidateData()
        {
            if (this.cboTransactionTypeCode.ItemIndex == -1)
            {
                this.cboTransactionTypeCode.Focus();
                return -1;
            }
            if (this.txtDetailTransactionCode.Text == string.Empty)
            {
                this.txtDetailTransactionCode.Focus();
                return -2;
            }
            if (this.txtDetailTransactionName.Text == string.Empty)
            {
                this.txtDetailTransactionName.Focus();
                return -3;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (this.DataSource == null)
                this.DataSource = new AccountTransactionTypeDetail();
            (this.DataSource as AccountTransactionTypeDetail).TransactionTypeCode = this.cboTransactionTypeCode.EditValue.ToString();
            (this.DataSource as AccountTransactionTypeDetail).DetailTransactionCode = this.txtDetailTransactionCode.Text;
            (this.DataSource as AccountTransactionTypeDetail).DetailTransactionName = this.txtDetailTransactionName.Text;
            (this.DataSource as AccountTransactionTypeDetail).Description = this.txtDescription.Text;
            if (this.EditMode ==FormEditMode.ADD)
            {
                (this.DataSource as AccountTransactionTypeDetail).UserCreated = Contexts.CurrentUser.LoginName;
                (this.DataSource as AccountTransactionTypeDetail).DateCreated = DateTime.Now;
            }
            (this.DataSource as AccountTransactionTypeDetail).UserUpdated = Contexts.CurrentUser.LoginName;
            (this.DataSource as AccountTransactionTypeDetail).DateUpdated = DateTime.Now;
        }

        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.cboTransactionTypeCode.Properties.ReadOnly = false;
                this.txtDetailTransactionCode.Properties.ReadOnly = false;
                this.txtDetailTransactionName.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.cboTransactionTypeCode.ItemIndex = 0;
                this.cboTransactionTypeCode.Focus();
               
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.cboTransactionTypeCode.Properties.ReadOnly = true;
                this.txtDetailTransactionCode.Properties.ReadOnly = true;
                this.txtDetailTransactionName.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtDetailTransactionName.Focus();
            }
            else
            {
                this.cboTransactionTypeCode.Properties.ReadOnly = true;
                this.txtDetailTransactionCode.Properties.ReadOnly = true;
                this.txtDetailTransactionName.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
            }

            base.RefreshControl();
        }
    }
}
