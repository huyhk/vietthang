using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;
//using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;


namespace VNS.ERP.GUI.UserControls
{
    public partial class UCAccount : EditControlBase
    {
        ListBase<SubjectType> lstSubType = null;
        public UCAccount()
        {
            InitializeComponent();
            btn.BackColor = this.BackColor;
        }
        private void LoadAccountSubjectType()
        {
            Account acc = this.DataSource as Account;
            AccountSubjectType accst=null;

            lst.Items.Clear();
            int countSubjectType = this.lstSubType.Count;
            for (int i = 0; i < countSubjectType; i++)
            {
                try
                {
                    accst = acc.LstAccSubjectType.Search("SubjectTypeCode", lstSubType[i].SubjectTypeCode);
                }
                catch
                {
                }
                if (accst != null)
                {
                    lst.Items.Add(lstSubType[i].SubjectTypeName);
                    lstCheckeDetailSubject.SetItemChecked(i, true);
                }
                else
                {
                    lstCheckeDetailSubject.SetItemChecked(i, false);
                }
            }
           
        }
        protected override void BindData()
        {

            if (DataSource != null)
            {
                Account acc = this.DataSource as Account;
                TxtAcountCode.Text = acc.AccountCode;
                txtAccountName.Text = acc.AccountName;
                TxtDescription.Text = acc.Description;
                lookUpEditAccountType.EditValue = acc.AccountType;
                numUpDownAccountLevel.Value = Convert.ToDecimal(acc.AccountLevel);
                lookUpEditParentAccount.EditValue = acc.AccountParent;
                chkDetailSubject.Checked = acc.DetailSubject;
                chkDetailClassification.Checked = acc.DetailClassification;
                lookupEditClassificationTypeCode.EditValue = acc.ClassificationTypeCode;

                if (acc.LstAccSubjectType == null)
                {
                    if (this.EditMode == VNS.Windows.FormEditMode.ADD)
                    {
                        acc.LstAccSubjectType = new ListBase<AccountSubjectType>();
                    }
                    else
                    {
                        acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                    }
                }
                //lst.ValueMember = "SubjectTypeName";
                //lst.DataSource = acc.LstAccSubjectType;
                //lst.DisplayMember = "SubjectTypeCode";
                //lst.Refresh();

                this.LoadAccountSubjectType();

                if (this.EditMode == VNS.Windows.FormEditMode.ADD)
                {
                    try
                    {
                        lookUpEditAccountType.ItemIndex = 0;
                    }
                    catch
                    {
                    }

                    lookUpEditParentAccount.ItemIndex = 0;

                }
            }
            base.BindData();
        }
        protected override int ValidateData()
        {
            string parentAcc = lookUpEditParentAccount.EditValue.ToString();
            TxtAcountCode.Text = TxtAcountCode.Text.Trim();
            txtAccountName.Text = txtAccountName.Text.Trim();
            TxtDescription.Text = TxtDescription.Text.Trim();
            //txtParentAccount.Text = txtParentAccount.Text.Trim();
            if (TxtAcountCode.Text == "")
            {
                TxtAcountCode.Focus();
                return -1;
            }
            if (parentAcc.Length >= TxtAcountCode.Text.Length)
            {
                TxtAcountCode.Focus();
                return -6;
            }
            if (TxtAcountCode.Text.Substring(0, parentAcc.Length) != parentAcc)
            {
                TxtAcountCode.Focus();
                return -6;
            }
            if (txtAccountName.Text == "")
            {
                txtAccountName.Focus();
                return -2;
            }
            if (lookUpEditAccountType.EditValue == null)
            {
                lookUpEditAccountType.Focus();
                return -3;
            }
            if (lookUpEditParentAccount.EditValue == null)
            {
                lookUpEditParentAccount.Focus();
                return -4;
            }
            if (chkDetailClassification.Checked && lookupEditClassificationTypeCode.EditValue == null)
            {
                lookupEditClassificationTypeCode.Focus();
                return -5;
            }
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            int countSubjectTypeChecked = lstCheckeDetailSubject.CheckedItems.Count;
            if (this.DataSource == null) this.DataSource = new Account();
            Account acc = this.DataSource as Account;
            acc.AccountCode = TxtAcountCode.Text;
            acc.AccountName = txtAccountName.Text;
            acc.Description = TxtDescription.Text;
            acc.AccountType = Convert.ToByte(lookUpEditAccountType.EditValue);
            acc.AccountLevel = Convert.ToByte(numUpDownAccountLevel.Value);
            acc.AccountParent = lookUpEditParentAccount.EditValue.ToString();
            acc.DetailSubject = chkDetailSubject.Checked;
            acc.DetailClassification = chkDetailClassification.Checked;
            if (lookupEditClassificationTypeCode.EditValue != null)
            {
                acc.ClassificationTypeCode = lookupEditClassificationTypeCode.EditValue.ToString();
            }
            else
            {
                acc.ClassificationTypeCode = null;
            }
            acc.LstAccSubjectType.Clear();
            for (int i = 0; i < countSubjectTypeChecked; i++)
            { 
                AccountSubjectType accst = new AccountSubjectType();
                accst.AccountCode = acc.AccountCode;
                accst.SubjectTypeCode = lstCheckeDetailSubject.CheckedItems[i].ToString();
                acc.LstAccSubjectType.Add(accst);
            }
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                acc.UserCreated = Contexts.CurrentUser.LoginName;
                acc.DateCreated = DateTime.Now;
            }
            acc.UserUpdated = Contexts.CurrentUser.LoginName;
            acc.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void Cancel()
        {
            this.LoadAccountSubjectType();
            base.Cancel();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            TxtAcountCode.Properties.ReadOnly = viewMode || this.EditMode == VNS.Windows.FormEditMode.EDIT;
            lstCheckeDetailSubject.Visible = false;
            txtAccountName.Properties.ReadOnly = viewMode;
            TxtDescription.Properties.ReadOnly = viewMode;
            lookUpEditAccountType.Properties.ReadOnly = viewMode;
           // numUpDownAccountLevel.ReadOnly = viewMode;
            lookUpEditParentAccount.Properties.ReadOnly = viewMode;
            chkDetailSubject.Properties.ReadOnly = viewMode;
            chkDetailClassification.Properties.ReadOnly = viewMode;
            lookupEditClassificationTypeCode.Properties.ReadOnly = viewMode;
            if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                lookupEditClassificationTypeCode.BackColor = Color.White;
            }
            if (this.DataSource == null)
            {
                TxtAcountCode.Text = "";
                txtAccountName.Text = "";
                TxtDescription.Text = "";
                lookUpEditParentAccount.ItemIndex = 0;
                //FtxtParentAccount.Text = "";
                chkDetailClassification.Checked = false;
                chkDetailSubject.Checked = false;

            }
            base.RefreshControl();
        }
        public void SetDss()
        {
            ListBase<Account> lstAcc = null;
            lookupEditClassificationTypeCode.Properties.DataSource = new AccountClassificationTypeBLL().GetAll();
            lookUpEditAccountType.Properties.DataSource = EnumDisplays.GetListenumAccountType();
            lstCheckeDetailSubject.ValueMember = "SubjectTypeCode";
            lstCheckeDetailSubject.DisplayMember = "SubjectTypeName";
            this.lstSubType = new SubjectTypeBLL().GetAll();
            lstAcc = new AccountBLL().GetAll();
            Account acc = new Account();
            acc.AccountCode = "";
            acc.AccountLevel = 0;
            lstAcc.Add(acc);
            lookUpEditParentAccount.Properties.DataSource = lstAcc;
            lstCheckeDetailSubject.DataSource = this.lstSubType;
            lstCheckeDetailSubject.Refresh();
        }

        private void chkDetailClassification_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDetailClassification.Checked)
            {
                if (this.EditMode != VNS.Windows.FormEditMode.VIEW) lookupEditClassificationTypeCode.BackColor = Color.White;
                try
                {
                    lookupEditClassificationTypeCode.ItemIndex = 0;
                }
                catch
                {
                }
            }
            else
	        {
                lookupEditClassificationTypeCode.EditValue=null;
	        }
            lookupEditClassificationTypeCode.Enabled = chkDetailClassification.Checked;
            
        }

        private void btn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                lstCheckeDetailSubject.Visible = !lstCheckeDetailSubject.Visible;
                lstCheckeDetailSubject.BringToFront();

                lstCheckeDetailSubject.Focus();
                //lstCheckeDetailSubject.Enabled = true;
            }
            else if(chkDetailSubject.Checked)
            {
                lst.Visible = !lst.Visible;
                lst.BringToFront();
                lst.Focus();
            }
        }

        private void lstCheckeDetailSubject_Validated(object sender, EventArgs e)
        {
            lstCheckeDetailSubject.Visible = false;
        }

        private void lstCheckeDetailSubject_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            //lstCheckeDetailSubject.SetItemChecked(e.Index,e.State)
            if (lstCheckeDetailSubject.CheckedItems.Count > 0)
            {
                chkDetailSubject.Checked = true;
            }
            else
            {
                chkDetailSubject.Checked = false;
            }
        }

        private void lst_Validated(object sender, EventArgs e)
        {
            lst.Visible = false;
        }

        private void lookUpEditParentAccount_EditValueChanged(object sender, EventArgs e)
        {
            //CurrencyManager cr = this.BindingContext[lookUpEditParentAccount.Properties.DataSource] as CurrencyManager;
            numUpDownAccountLevel.Value = Convert.ToDecimal( lookUpEditParentAccount.GetColumnValue("AccountLevel"))+1;
        }
        public void UpdateNewAcc(Account acc)
        {
            (lookUpEditParentAccount.Properties.DataSource as ListBase<Account>).Add(acc.Clone() as Account);
        }
        public void UpdateRemoveAcc(Account acc)
        {
            Account acc1 = (lookUpEditParentAccount.Properties.DataSource as ListBase<Account>).Search("AccountCode", acc.AccountCode);
            if (acc1 != null)
            {
                (lookUpEditParentAccount.Properties.DataSource as ListBase<Account>).Remove(acc1);
            }
        }

        private void chkDetailSubject_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
