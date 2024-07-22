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
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class UCFixedAssetOpening : EditControlBase
    {
        private string periodCode = "";
        private DateTime startDate = Contexts.WorkingDate;
        private DataView dvSubject;
        private DataView dvClassification;
        private ListBase<Account> lstAllAccounts;
        private AccountBLL accountBLL;
        private SubjectBLL subjectBLL;
        public UCFixedAssetOpening()
        {
            InitializeComponent();
        }

        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                accountBLL = new AccountBLL();
                subjectBLL = new SubjectBLL();
                this.cboAccountCode.Properties.DataSource = accountBLL.GetObjectDynamic("left(AccountCode,3) in ('211','213')  and AccountCode not in (select AccountParent from Accounts where AccountParent is not null)", "");
                this.cboSubjectCode.Properties.DataSource = (new FixedAssetBLL()).GetAll();
                Period period=(new PeriodBLL()).GetMin();
                lstAllAccounts = accountBLL.GetListAccountIsNotParentAccount();
                foreach (Account acc1 in lstAllAccounts)
                {
                    if (acc1.LstAccSubjectType == null)
                    {
                        acc1.LstAccSubjectType = accountBLL.GetAccountSubjectType(acc1.AccountCode);
                    }
                }
                dvSubject = subjectBLL.GetAllToDataTable().DefaultView;
                dvClassification = (new AccountClassificationBLL()).GetAllToDataTable().DefaultView;
                periodCode = period.PeriodCode;
                startDate = period.StartDate;
                this.cboDepAccountCode.Properties.DataSource = lstAllAccounts;
                base.InitDataObject();
            }
        }
        protected override void BindData()
        {
            if (this.DataSource == null)
                this.DataSource = new FixedAssetOpening();
            this.txtFixedAssetCode.EditValue = (this.DataSource as FixedAssetOpening).FixedAssetCode;
            this.txtFixedAssetName.EditValue = (this.DataSource as FixedAssetOpening).FixedAssetName;
            this.cboStartDate.DateTime = (this.DataSource as FixedAssetOpening).StartDate;
            this.txtOriginalPrice.EditValue = (this.DataSource as FixedAssetOpening).OriginalPrice;
            this.txtMonthUsing.EditValue = (this.DataSource as FixedAssetOpening).MonthUsing/12;
            this.cboSubjectCode.EditValue = (this.DataSource as FixedAssetOpening).SubjectCode;
            this.cboAccountCode.EditValue = (this.DataSource as FixedAssetOpening).AccountCode;
            this.txtAccumulateDepreciation.EditValue = (this.DataSource as FixedAssetOpening).AccumulatedDepreciation;
            this.txtRemainCost.EditValue = (this.DataSource as FixedAssetOpening).RemainCost;
            this.txtDescription.Text = (this.DataSource as FixedAssetOpening).Description;
            this.cboDepAccountCode.EditValue = (this.DataSource as FixedAssetOpening).DepAccountCode;
            this.cboDepSubjectCode.EditValue = (this.DataSource as FixedAssetOpening).DepSubjectCode;
            this.cboDepClassificationCode.EditValue = (this.DataSource as FixedAssetOpening).DepClassificationCode;
            this.txtSoCT.Text = (this.DataSource as FixedAssetOpening).SoCT;
            this.txtContryName.Text = (this.DataSource as FixedAssetOpening).CountryName;
            this.txtNgayCT.DateTime = (this.DataSource as FixedAssetOpening).NgayCT;
            if (this.EditMode == FormEditMode.ADD)
            {
                this.cboStartDate.DateTime = startDate.AddDays(-1);
                this.cboAccountCode.ItemIndex = 0;
                this.cboSubjectCode.ItemIndex = 0;
            }
            base.BindData();
        }
        protected override int ValidateData()
        {
            base.ValidateData();
            if (this.txtFixedAssetCode.Text == String.Empty)
            {
                this.txtFixedAssetCode.Focus();
                return -1;
            }
            //if (this.cboStartDate.DateTime >= startDate)
            //{
            //    this.cboStartDate.Focus();
            //    return -2;
            //}
            if (this.cboSubjectCode.ItemIndex == -1)
            {
                this.cboSubjectCode.Focus();
                return -3;
            }
            if (this.cboAccountCode.ItemIndex == -1)
            {
                this.cboAccountCode.Focus();
                return -4;
            }
            if (decimal.Parse(this.txtMonthUsing.EditValue.ToString()) <= 0)
            {
                this.txtMonthUsing.Focus();
                return -5;
            }
            if (this.cboDepAccountCode.ItemIndex == -1)
            {
                this.cboDepAccountCode.Focus();
                return -6;
            }
            return 0;
        }
        protected override void AssignData()
        {

            (this.DataSource as FixedAssetOpening).FixedAssetCode=this.txtFixedAssetCode.EditValue.ToString() ;
            (this.DataSource as FixedAssetOpening).FixedAssetName= this.txtFixedAssetName.EditValue.ToString() ;
            (this.DataSource as FixedAssetOpening).StartDate= this.cboStartDate.DateTime ;
            (this.DataSource as FixedAssetOpening).OriginalPrice=(decimal)(this.txtOriginalPrice.EditValue) ;
            (this.DataSource as FixedAssetOpening).MonthUsing=int.Parse(this.txtMonthUsing.EditValue.ToString())*12;
            (this.DataSource as FixedAssetOpening).SubjectCode=this.cboSubjectCode.EditValue.ToString() ;
            (this.DataSource as FixedAssetOpening).AccountCode=this.cboAccountCode.EditValue.ToString() ;
            (this.DataSource as FixedAssetOpening).AccumulatedDepreciation=(decimal)(this.txtAccumulateDepreciation.EditValue) ;
            (this.DataSource as FixedAssetOpening).RemainCost=(decimal)(this.txtRemainCost.EditValue) ;
            (this.DataSource as FixedAssetOpening).Description=this.txtDescription.Text ;
            (this.DataSource as FixedAssetOpening).PeriodCode = periodCode;
            (this.DataSource as FixedAssetOpening).PriceDepreciation = (this.DataSource as FixedAssetOpening).OriginalPrice;
            (this.DataSource as FixedAssetOpening).DepAccountCode = this.cboDepAccountCode.EditValue.ToString();
            (this.DataSource as FixedAssetOpening).DepSubjectCode = this.cboDepSubjectCode.EditValue.ToString();
            (this.DataSource as FixedAssetOpening).DepClassificationCode = this.cboDepClassificationCode.EditValue.ToString();
            (this.DataSource as FixedAssetOpening).NgayCT = this.txtNgayCT.DateTime;
            (this.DataSource as FixedAssetOpening).SoCT = this.txtSoCT.Text;
            (this.DataSource as FixedAssetOpening).CountryName = this.txtContryName.Text;

            base.AssignData();
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
                this.txtRemainCost.Properties.ReadOnly = false;
                this.txtAccumulateDepreciation.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.cboDepAccountCode.Properties.ReadOnly = false;
                this.cboDepClassificationCode.Properties.ReadOnly = false;
                this.cboDepSubjectCode.Properties.ReadOnly = false;
                this.txtNgayCT.Properties.ReadOnly = false;
                ClearTexBox();
                this.txtFixedAssetCode.Focus();
                this.txtContryName.Properties.ReadOnly = false;
                this.txtSoCT.Properties.ReadOnly = false;
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
                this.txtRemainCost.Properties.ReadOnly = false;
                this.txtAccumulateDepreciation.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.cboDepAccountCode.Properties.ReadOnly = false;
                this.cboDepClassificationCode.Properties.ReadOnly = false;
                this.cboDepSubjectCode.Properties.ReadOnly = false;
                this.txtNgayCT.Properties.ReadOnly = false;
                this.txtFixedAssetName.Focus();
                this.txtContryName.Properties.ReadOnly = false;
                this.txtSoCT.Properties.ReadOnly = false;
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
                this.txtRemainCost.Properties.ReadOnly = true;
                this.txtAccumulateDepreciation.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.cboDepAccountCode.Properties.ReadOnly = true;
                this.cboDepClassificationCode.Properties.ReadOnly = true;
                this.cboDepSubjectCode.Properties.ReadOnly = true;
                this.txtNgayCT.Properties.ReadOnly = true;
                this.txtFixedAssetCode.Focus();
                this.txtContryName.Properties.ReadOnly = true;
                this.txtSoCT.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }

        private void txtAccumulateDepreciation_Validated(object sender, EventArgs e)
        {
            decimal originalPrice=decimal.Parse(this.txtOriginalPrice.EditValue.ToString());
            decimal accumulateDepreciation=decimal.Parse(this.txtAccumulateDepreciation.EditValue.ToString());
            if(originalPrice!=0 && accumulateDepreciation != 0)
            {
                this.txtRemainCost.EditValue=originalPrice-accumulateDepreciation;
            }
        }

        private void txtOriginalPrice_Validated(object sender, EventArgs e)
        {
            decimal originalPrice=decimal.Parse(this.txtOriginalPrice.EditValue.ToString());
            decimal accumulateDepreciation=decimal.Parse(this.txtAccumulateDepreciation.EditValue.ToString());
            if(originalPrice!=0 && accumulateDepreciation != 0)
            {
                this.txtRemainCost.EditValue=originalPrice-accumulateDepreciation;
            }
            else if (accumulateDepreciation == 0)
            {
                 this.txtRemainCost.EditValue=originalPrice;
            }
        }

        private void txtRemainCost_Validated(object sender, EventArgs e)
        {
            decimal originalPrice = decimal.Parse(this.txtOriginalPrice.EditValue.ToString());
            decimal remaiCost = decimal.Parse(this.txtRemainCost.EditValue.ToString());
            this.txtAccumulateDepreciation.EditValue = originalPrice - remaiCost;
        }
        private void cboDepAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            string strFilter1 = "";
            string strFilter2 = "";
            Account acc = null;
            if (lstAllAccounts.Count > 0)
                acc = lstAllAccounts.Search("AccountCode", this.cboDepAccountCode.EditValue.ToString());
            if (acc != null)
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
                    this.cboDepClassificationCode.EditValue = "";
                    this.txtDepClassificationCode.Text = "";
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
            LoadTextClassificationName(cboDepClassificationCode.EditValue.ToString());
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
            this.txtDepAccountCode.Text = "";
            this.txtDepSubjectCode.Text = "";
            this.txtDepClassificationCode.Text = "";
        }

       
    }
}
