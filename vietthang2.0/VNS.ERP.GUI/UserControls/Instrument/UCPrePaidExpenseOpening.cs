using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class UCPrePaidExpenseOpening : EditControlBase
    {
        private string periodCode = "";
        private DateTime startDate = Contexts.WorkingDate;
        private DataView dvSubject;
        private DataView dvClassification;
        private ListBase<Account> lstAllAccounts;
        private AccountBLL accountBLL;
        private SubjectBLL subjectBLL;
        public UCPrePaidExpenseOpening()
        {
            InitializeComponent();
        }

        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                accountBLL = new AccountBLL();
                subjectBLL = new SubjectBLL();
                this.cboAccountCode.Properties.DataSource = accountBLL.GetObjectDynamic("(left(AccountCode,3)='142' or  left(AccountCode,3)='242') and AccountCode not in (select AccountParent from Accounts where AccountParent is not null)", "");
                this.cboSubjectCode.Properties.DataSource = (new BranchBLL()).GetAll();
                Period period = (new PeriodBLL()).GetMin();
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
                this.DataSource = new PrePaidExpenseOpening();
            PrePaidExpenseOpening prePaidOpen = (this.DataSource as PrePaidExpenseOpening);
            this.txtPrePaidCode.Text = prePaidOpen.PrePaidCode;
            this.txtPrePaidName.Text = prePaidOpen.PrePaidName;
            this.txtUnit.Text = prePaidOpen.Unit;
            this.txtQuantity.EditValue = prePaidOpen.Quantity;
            this.txtDepRate.EditValue = prePaidOpen.DepRate;
            this.txtDepMonth.EditValue = prePaidOpen.DepMonth;
            this.txtPrePaidNo.Text = prePaidOpen.PrePaidNo;
            this.cboPrePaidDate.EditValue = prePaidOpen.PrePaidDate;
            this.cboDepStartDate.EditValue = prePaidOpen.DepStartDate;
            this.cboSubjectCode.EditValue = prePaidOpen.SubjectCode;
            this.cboAccountCode.EditValue = prePaidOpen.AccountCode;
            this.txtPrice.EditValue = prePaidOpen.Price;
            this.txtAmount.EditValue = prePaidOpen.Amount;
            this.txtDescription.Text = prePaidOpen.Description;
            this.txtRemainCost.EditValue = prePaidOpen.RemainCost;
            this.txtAccumulateDepreciation.EditValue = prePaidOpen.AccumulatedDepreciation;
            this.cboDepAccountCode.EditValue = prePaidOpen.DepAccountCode;
            this.cboDepSubjectCode.EditValue = prePaidOpen.DepSubjectCode;
            this.cboDepClassificationCode.EditValue = prePaidOpen.DepClassificationCode;
            if (this.EditMode == FormEditMode.ADD)
            {
                this.cboDepStartDate.DateTime = startDate.AddDays(-1);
                this.cboAccountCode.ItemIndex = 0;
                this.cboSubjectCode.ItemIndex = 0;
            }
            base.BindData();
        }
        
        protected override void AssignData()
        {
            PrePaidExpenseOpening prePaidOpen = (this.DataSource as PrePaidExpenseOpening);
            prePaidOpen.PrePaidCode= this.txtPrePaidCode.Text;
            prePaidOpen.PeriodCode = periodCode;
            prePaidOpen.PrePaidName=this.txtPrePaidName.Text ;
            prePaidOpen.Unit=this.txtUnit.Text;
            prePaidOpen.Quantity=(decimal)(this.txtQuantity.EditValue) ;
            prePaidOpen.DepRate=(decimal)(this.txtDepRate.EditValue);
            prePaidOpen.DepMonth=(int)(this.txtDepMonth.EditValue);
            prePaidOpen.PrePaidNo=this.txtPrePaidNo.Text;
            prePaidOpen.PrePaidDate= this.cboPrePaidDate.DateTime ;
            prePaidOpen.DepStartDate = this.cboDepStartDate.DateTime;
            prePaidOpen.SubjectCode= this.cboSubjectCode.EditValue.ToString();
            prePaidOpen.AccountCode= this.cboAccountCode.EditValue.ToString();
            prePaidOpen.Price= (decimal)(this.txtPrice.EditValue);
            //prePaidOpen.Amount= decimal.Parse(this.txtAmount.Text);
            prePaidOpen.Description= this.txtDescription.Text;
            prePaidOpen.AccumulatedDepreciation = (decimal)(this.txtAccumulateDepreciation.EditValue);
            prePaidOpen.RemainCost = (decimal)(this.txtRemainCost.EditValue);

            prePaidOpen.DepAccountCode=this.cboDepAccountCode.EditValue.ToString();
            prePaidOpen.DepSubjectCode=this.cboDepSubjectCode.EditValue.ToString();
            prePaidOpen.DepClassificationCode= this.cboDepClassificationCode.EditValue.ToString();
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtPrePaidCode.Properties.ReadOnly = false;
                this.txtPrePaidName.Properties.ReadOnly = false;
                this.txtUnit.Properties.ReadOnly = false;
                this.txtQuantity.Properties.ReadOnly = false;
                this.txtDepRate.Properties.ReadOnly = false;
                this.txtDepMonth.Properties.ReadOnly = false;
                this.txtPrePaidNo.Properties.ReadOnly = false;
                this.cboPrePaidDate.Properties.ReadOnly = false;
                this.cboSubjectCode.Properties.ReadOnly = false;
                this.cboDepStartDate.Properties.ReadOnly = false;
                this.txtRemainCost.Properties.ReadOnly = false;
                this.txtAccumulateDepreciation.Properties.ReadOnly = false;
                this.cboAccountCode.Properties.ReadOnly = false;
                this.txtPrice.Properties.ReadOnly = false;
                this.txtAmount.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.cboDepAccountCode.Properties.ReadOnly = false;
                this.cboDepClassificationCode.Properties.ReadOnly = false;
                this.cboDepSubjectCode.Properties.ReadOnly = false;
                ClearTexBox();
                this.txtPrePaidCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtPrePaidCode.Properties.ReadOnly = true;
                this.txtPrePaidName.Properties.ReadOnly = false;
                this.txtUnit.Properties.ReadOnly = false;
                this.txtQuantity.Properties.ReadOnly = false;
                this.txtDepRate.Properties.ReadOnly = false;
                this.txtDepMonth.Properties.ReadOnly = false;
                this.txtPrePaidNo.Properties.ReadOnly = false;
                this.cboPrePaidDate.Properties.ReadOnly = false;
                this.cboDepStartDate.Properties.ReadOnly = false;
                this.txtRemainCost.Properties.ReadOnly = false;
                this.txtAccumulateDepreciation.Properties.ReadOnly = false;
                this.cboSubjectCode.Properties.ReadOnly = false;
                this.cboAccountCode.Properties.ReadOnly = false;
                this.txtPrice.Properties.ReadOnly = false;
                this.txtAmount.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.cboDepAccountCode.Properties.ReadOnly = false;
                this.cboDepClassificationCode.Properties.ReadOnly = false;
                this.cboDepSubjectCode.Properties.ReadOnly = false;
                this.txtPrePaidName.Focus();
            }
            else
            {
                this.txtPrePaidCode.Properties.ReadOnly = true;
                this.txtPrePaidName.Properties.ReadOnly = true;
                this.txtUnit.Properties.ReadOnly = true;
                this.txtQuantity.Properties.ReadOnly = true;
                this.txtDepRate.Properties.ReadOnly = true;
                this.txtDepMonth.Properties.ReadOnly = true;
                this.txtPrePaidNo.Properties.ReadOnly = true;
                this.cboPrePaidDate.Properties.ReadOnly = true;
                this.cboDepStartDate.Properties.ReadOnly = true;
                this.txtRemainCost.Properties.ReadOnly = true;
                this.txtAccumulateDepreciation.Properties.ReadOnly = true;
                this.cboSubjectCode.Properties.ReadOnly = true;
                this.cboAccountCode.Properties.ReadOnly = true;
                this.txtPrice.Properties.ReadOnly = true;
                this.txtAmount.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.cboDepAccountCode.Properties.ReadOnly = true;
                this.cboDepClassificationCode.Properties.ReadOnly = true;
                this.cboDepSubjectCode.Properties.ReadOnly = true;
                this.txtPrePaidCode.Focus();
            }
            base.RefreshControl();
        }
        protected override int ValidateData()
        {
            base.ValidateData();
            if (this.txtPrePaidCode.Text == string.Empty)
            {
                this.txtPrePaidCode.Focus();
                return -1;
            }
            if ((int)(this.txtDepMonth.EditValue) <= 0)
            {
                this.txtDepMonth.Focus();
                return -2;
            }
            //if (this.cboDepStartDate.DateTime >= startDate)
            //{
            //    this.cboDepStartDate.Focus();
            //    return -3;
            //}
            if (this.cboAccountCode.ItemIndex == -1)
            {
                this.cboAccountCode.Focus();
                return -4;
            }
            if (this.cboSubjectCode.ItemIndex == -1)
            {
                this.cboSubjectCode.Focus();
                return -5;
            }
            if ((decimal)(this.txtQuantity.EditValue) <= 0)
            {
                this.txtQuantity.Focus();
                return -6;
            }

            if (this.cboDepAccountCode.ItemIndex == -1)
            {
                this.cboDepAccountCode.Focus();
                return -7;
            }

            return 0;
        }
        private void txtAccumulateDepreciation_Validated(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                decimal amount = (decimal)(this.txtAmount.EditValue);
                decimal accumulateDepreciation = (decimal)(this.txtAccumulateDepreciation.EditValue);
                if (amount != 0 && accumulateDepreciation != 0)
                {
                    this.txtRemainCost.EditValue = amount - accumulateDepreciation;
                }
            }
        }

        private void txtAmount_Validated(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                decimal amount = (decimal)(this.txtAmount.EditValue);
                decimal accumulateDepreciation = (decimal)(this.txtAccumulateDepreciation.EditValue);
                if (amount != 0 && accumulateDepreciation != 0)
                {
                    this.txtRemainCost.EditValue = amount - accumulateDepreciation;

                }
                else if (accumulateDepreciation == 0)
                {
                    this.txtRemainCost.EditValue = amount;
                }
                if (amount != 0)
                    this.txtPrice.EditValue = (amount / (decimal)(this.txtQuantity.EditValue));
                else
                    this.txtPrice.EditValue = 0;
            }
        }

        private void txtRemainCost_Validated(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                decimal amount = (decimal)(this.txtAmount.EditValue);
                decimal remaiCost = (decimal)(this.txtRemainCost.EditValue);
                this.txtAccumulateDepreciation.EditValue = amount - remaiCost;
            }
        }
        private void txtQuantity_Validated(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                int quantity = Convert.ToInt32(this.txtQuantity.EditValue);
                decimal price = (decimal)(this.txtPrice.EditValue);
                this.txtAmount.EditValue = quantity * price;
            }
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                int quantity = Convert.ToInt32(this.txtQuantity.EditValue);
                decimal price = (decimal)(this.txtPrice.EditValue);
                this.txtAmount.EditValue = quantity * price;
            }
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
