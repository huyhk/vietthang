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
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class UCAccountFixedAssets:UCAccountTransaction
    {
        private DateTime startDate =Contexts.WorkingDate;
        private DataView dvSubject;
        private DataView dvClassification;
        private ListBase<Account> lstAccounts;
        private ListBase<Account> lstAllAccounts;
        private ListBase<FixedAsset> lstFixedAsset;
        private AccountBLL accountBLL;
        private SubjectBLL subjectBLL;
        public UCAccountFixedAssets()
        {
            InitializeComponent();
            this.cboStartDate.DateTime = Contexts.WorkingDate;
           
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                accountBLL = new AccountBLL();
                subjectBLL = new SubjectBLL();
                lstAccounts = accountBLL.GetObjectDynamic("left(AccountCode,3)='211'  and AccountCode not in (select AccountParent from Accounts where AccountParent is not null)", "");
                lstAllAccounts = accountBLL.GetAll();
                dvSubject =subjectBLL.GetAllToDataTable().DefaultView;
                dvClassification = (new AccountClassificationBLL()).GetAllToDataTable().DefaultView;
                foreach (Account acc in lstAccounts)
                {
                    if (acc.LstAccSubjectType == null)
                    {
                        acc.LstAccSubjectType = accountBLL.GetAccountSubjectType(acc.AccountCode);
                    }
                }
                foreach (Account acc1 in lstAllAccounts)
                {
                    if (acc1.LstAccSubjectType == null)
                    {
                        acc1.LstAccSubjectType = accountBLL.GetAccountSubjectType(acc1.AccountCode);
                    }
                }
                startDate = (new PeriodBLL()).GetMin().StartDate;
                this.cboAccountCode.Properties.DataSource = lstAccounts;
                lstFixedAsset = (new FixedAssetBLL()).GetAll();
                this.cboSubjectCode.Properties.DataSource = lstFixedAsset;
                this.cboDepAccountCode.Properties.DataSource = (new AccountBLL()).GetListAccountIsNotParentAccount();
                base.InitDataObject();
            }
        }
        protected override void BindData()
        {
            base.BindData();
            if ((this.DataSource as AccountTransactionFixedAssetNew).FixedAsset == null && this.EditMode == FormEditMode.ADD)
                (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset = new AccountFixedAssets();
            if ((((this.DataSource as AccountTransactionFixedAssetNew).FixedAsset == null) && this.EditMode != FormEditMode.ADD))
                (new AccountTransactionFixedAssetNewBLL()).GetDetailAccountTransactionFixedAssetNew(this.DataSource as AccountTransactionFixedAssetNew);
            this.txtFixedAssetCode.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.FixedAssetCode;
            this.txtFixedAssetName.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.FixedAssetName;
            this.cboStartDate.DateTime = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.StartDate;
            this.txtOriginalPrice.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.OriginalPrice;
            this.txtMonthUsing.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.MonthUsing / 12;
            this.txtDescription1.Text = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.Description;
            this.cboAccountCode.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.AccountCode;
            this.cboSubjectCode.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.SubjectCode;
            this.cboDepAccountCode.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.DepAccountCode;
            this.cboDepSubjectCode.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.DepSubjectCode;
            this.cboDepClassificationCode.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.DepClassificationCode;

            this.txtCountryName.EditValue = (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset.CountryName;

        }
        protected override int ValidateData()
        {
            int iError = 0;
            iError = base.ValidateData();
            if (iError == 0)
            {
                if (this.txtFixedAssetCode.Text == string.Empty)
                {
                    this.txtFixedAssetCode.Focus();
                    return -11;
                }
                if (this.cboAccountCode.EditValue.ToString() == string.Empty)
                {
                    this.cboAccountCode.Focus();
                    return -12;
                }
                if (this.cboSubjectCode.EditValue.ToString() == string.Empty)
                {
                    this.cboSubjectCode.Focus();
                    return -13;
                }
                if (this.cboStartDate.DateTime < startDate)
                {
                    this.cboStartDate.Focus();
                    return -14;
                }
                if (decimal.Parse(this.txtMonthUsing.EditValue.ToString()) <= 0)
                {
                    this.txtMonthUsing.Focus();
                    return -17;
                }
                if (this.cboDepAccountCode.EditValue.ToString() == string.Empty)
                {
                    this.cboDepAccountCode.Focus();
                    return -18;
                }
               
               //iError = CheckValidateOriginalPriceByDebitAccountCode(this.cboAccountCode.EditValue.ToString());
            }
            else
                return iError;
            return iError;
        }
        protected override void AssignData()
        {
            base.AssignData();
            AccountFixedAssets dataFixedAsset= new AccountFixedAssets();
            (this.DataSource as AccountTransactionFixedAssetNew).FixedAsset=dataFixedAsset;

            dataFixedAsset.FixedAssetCode = this.txtFixedAssetCode.EditValue.ToString();
            dataFixedAsset.FixedAssetName = this.txtFixedAssetName.EditValue.ToString();
            dataFixedAsset.StartDate = this.cboStartDate.DateTime;
            dataFixedAsset.OriginalPrice = decimal.Parse(this.txtOriginalPrice.EditValue.ToString());
            dataFixedAsset.MonthUsing = int.Parse(this.txtMonthUsing.EditValue.ToString()) * 12;
            dataFixedAsset.AccountCode = this.cboAccountCode.EditValue.ToString();
            dataFixedAsset.SubjectCode = this.cboSubjectCode.EditValue.ToString();
            dataFixedAsset.Description = this.txtDescription1.Text;
            dataFixedAsset.DepAccountCode = this.cboDepAccountCode.EditValue.ToString();
            dataFixedAsset.DepSubjectCode = this.cboDepSubjectCode.EditValue.ToString();
            dataFixedAsset.DepClassificationCode = this.cboDepClassificationCode.EditValue.ToString();
            dataFixedAsset.NgayCT = (this.DataSource as AccountTransactionFixedAssetNew).AccountTransactionDate;

            dataFixedAsset.CountryName = this.txtCountryName.EditValue.ToString();
        }

        private void cboAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            Account acc = null;
            if (lstAccounts.Count>0)
                acc = lstAccounts.Search("AccountCode", this.cboAccountCode.EditValue.ToString());
                if (acc != null)
                    this.txtAccountCode.Text = acc.AccountName;
                else
                    this.txtAccountCode.Text = ""; 

        }
        private void cboSubjectCode_EditValueChanged(object sender, EventArgs e)
        {
            FixedAsset accSet=null;
            if (lstFixedAsset.Count>0)
            {
                accSet=lstFixedAsset.Search("SubjectCode",this.cboSubjectCode.EditValue);
                if (accSet != null)
                    this.txtSubjectCode.Text = accSet.SubjectName;
                else
                    this.txtSubjectCode.Text = "";
            }
        }
        public override void RefreshControl()
        {
           
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtFixedAssetCode.Properties.ReadOnly = false;
                this.txtFixedAssetName.Properties.ReadOnly = false;
                this.cboStartDate.Properties.ReadOnly = false;
                this.txtOriginalPrice.Properties.ReadOnly = false;
                this.txtMonthUsing.Properties.ReadOnly = false;
                this.cboAccountCode.Properties.ReadOnly = false;
                this.cboSubjectCode.Properties.ReadOnly = false;
                this.txtDescription1.Properties.ReadOnly = false;
                this.cboDepAccountCode.Properties.ReadOnly = false;
                this.cboDepSubjectCode.Properties.ReadOnly = false;
                this.cboDepClassificationCode.Properties.ReadOnly = false;
                this.txtCountryName.Properties.ReadOnly = false;
                ClearTexBox();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtFixedAssetCode.Properties.ReadOnly = true;
                this.txtFixedAssetName.Properties.ReadOnly = false;
                this.cboStartDate.Properties.ReadOnly = false;
                this.txtOriginalPrice.Properties.ReadOnly = false;
                this.txtMonthUsing.Properties.ReadOnly = false;
                this.cboAccountCode.Properties.ReadOnly = false;
                this.cboSubjectCode.Properties.ReadOnly = false;
                this.txtDescription1.Properties.ReadOnly = false;
                this.cboDepAccountCode.Properties.ReadOnly = false;
                this.cboDepSubjectCode.Properties.ReadOnly = false;
                this.cboDepClassificationCode.Properties.ReadOnly = false;
                this.txtCountryName.Properties.ReadOnly = false;
            }
            else
            {
                this.txtFixedAssetCode.Properties.ReadOnly = true;
                this.txtFixedAssetName.Properties.ReadOnly = true;
                this.cboStartDate.Properties.ReadOnly = true;
                this.txtOriginalPrice.Properties.ReadOnly = true;
                this.txtMonthUsing.Properties.ReadOnly = true;
                this.cboAccountCode.Properties.ReadOnly = true;
                this.cboSubjectCode.Properties.ReadOnly = true;
                this.txtDescription1.Properties.ReadOnly = true;
                this.cboDepAccountCode.Properties.ReadOnly = true;
                this.cboDepSubjectCode.Properties.ReadOnly = true;
                this.cboDepClassificationCode.Properties.ReadOnly = true;
                this.txtCountryName.Properties.ReadOnly = true;
            }
            base.RefreshControl();
            if (this.editMode == FormEditMode.ADD)
                tapAccountFixedAsset.SelectedTabPage = xtraTabPage2;
        }

        private int CheckValidateOriginalPriceByDebitAccountCode(string debitAccountCode)
        {
            int ret = 0;
            decimal totalDebitAmount=0;
            foreach(AccountTransactionDetail1 accDetail1 in (this.DataSource as AccountTransactionFixedAssetNew).Detail1)
            {
                if (debitAccountCode == accDetail1.AccountCode)
                {
                    totalDebitAmount += accDetail1.DebitAmount;
                }
            }
            if (totalDebitAmount == 0)
                ret = -15;
            else
            {
                if (totalDebitAmount == decimal.Parse(this.txtOriginalPrice.EditValue.ToString()))
                    ret = 0;
                else
                    ret = -16;
            }
            return ret;
        }

        private void cboDepAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            string strFilter1 = "";
            string strFilter2 = "";
            Account acc=null;
            if(lstAllAccounts.Count>0)
                acc = lstAllAccounts.Search("AccountCode", this.cboDepAccountCode.EditValue.ToString());
            if(acc!=null)
            {
                this.txtDepAccountCode.Text = acc.AccountName;
                this.dvSubject.RowFilter = "";
                this.dvClassification.RowFilter = "";
                if (acc.LstAccSubjectType.Count > 0)
                {
                    foreach (AccountSubjectType accObj in acc.LstAccSubjectType)
                    {
                        strFilter1 += "'" + accObj.SubjectTypeCode + "',";

                    }
                    strFilter1 = "SubjectTypeCode in (" + strFilter1 + ")";
                    dvSubject.RowFilter = strFilter1;
                    this.cboDepSubjectCode.Properties.DataSource = dvSubject;
                    this.cboDepSubjectCode.ItemIndex = 0;
                }
                else
                {
                    this.cboDepSubjectCode.Properties.DataSource = null;
                    this.cboDepSubjectCode.EditValue = "";
                    this.txtDepSubjectCode.Text = "";
                }
                if (acc.ClassificationTypeCode != string.Empty)
                {
                    strFilter2 = "ClassificationTypeCode = ('" + acc.ClassificationTypeCode + "')";
                    this.dvClassification.RowFilter = strFilter2;
                    this.cboDepClassificationCode.Properties.DataSource = dvClassification;
                    this.cboDepClassificationCode.ItemIndex = 0;
                }
                else
                {
                    this.cboDepClassificationCode.Properties.DataSource = null;
                    this.txtDepClassificationCode.Text = "";
                    this.cboDepClassificationCode.EditValue = "";
                }

               
            }
            else
                this.txtDepAccountCode.Text = "";
 
        }

        private void cboDepSubjectCode_EditValueChanged(object sender, EventArgs e)
        {
            LoadTextSubjectName(this.cboDepSubjectCode.EditValue.ToString());
        }
        private void LoadTextSubjectName(string subjectCode)
        {
            if (this.cboDepSubjectCode.Properties.DataSource != null)
            {
                dvSubject.Sort = "SubjectCode ASC";
                int indext = dvSubject.Find(subjectCode);
                if (indext >= 0)
                    this.txtDepSubjectCode.Text = (dvSubject[indext]["SubjectName"]).ToString();
                else
                    this.txtDepSubjectCode.Text = "";
            }
        }

        private void cboDepClassificationCode_EditValueChanged(object sender, EventArgs e)
        {
            LoadTextClassificationName(this.cboDepClassificationCode.EditValue.ToString());
        }
        private void LoadTextClassificationName(string classificationName)
        {
            if (this.cboDepClassificationCode.Properties.DataSource != null)
            {
                dvClassification.Sort = "ClassificationCode ASC";
                int indext = dvClassification.Find(classificationName);
                if (indext >= 0)
                    this.txtDepClassificationCode.Text = (dvClassification[indext]["ClassificationName"]).ToString();
                else
                    this.txtDepClassificationCode.Text = "";
            }
        }
        private void ClearTexBox()
        {
            this.txtSubjectCode.Text = "";
            this.txtAccountCode.Text = "";
            this.txtDepAccountCode.Text = "";
            this.txtDepSubjectCode.Text = "";
            this.txtDepClassificationCode.Text = "";
        }

       
    }
}
