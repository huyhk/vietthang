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
    public partial class UCFixedAssetUpgrade :UCAccountTransaction
    {
        private DateTime startDate = Contexts.WorkingDate;
        //private DataView dvSubject;
        private ListBase<AccountFixedAssets> lstAccFixedAssets;
        public UCFixedAssetUpgrade()
        {
            InitializeComponent();
            this.cboStartDate.DateTime = Contexts.WorkingDate;
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                startDate = (new PeriodBLL()).GetMin().StartDate;
                lstAccFixedAssets=(new AccountFixedAssetBLL().GetAll());
                this.cboFixedAssetCode.Properties.DataSource = lstAccFixedAssets;
                base.InitDataObject();
            }
        }
        protected override void BindData()
        {
            base.BindData();
            if ((this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset == null && this.EditMode == FormEditMode.ADD)
                (this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset = new FixedAssetUpgrade();
            if ((((this.DataSource as AccountTransactionFixedAssetUpgrade).Detail1.Count == 0 || (this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset == null) && this.EditMode != FormEditMode.ADD))
                (new AccountTransactionFixedAssetUpgradeBLL()).GetDetailAccountTransactionFixedAssetUpgrade(this.DataSource as AccountTransactionFixedAssetUpgrade);
            this.cboFixedAssetCode.EditValue = (this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset.FixedAssetCode;
            this.cboStartDate.DateTime = (this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset.StartDate;
            this.txtAmount.EditValue=(this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset.Amount;
            this.txtMonthUsing.EditValue = (this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset.MonthUsing/12;
            this.txtDescription1.Text = (this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset.Description;
        }
        protected override int ValidateData()
        {
            int iError = 0;
            iError = base.ValidateData();
            if (iError == 0)
            {
                if (this.cboFixedAssetCode.EditValue.ToString() ==string.Empty)
                {
                    this.cboFixedAssetCode.Focus();
                    return -21;
                }

                if (this.cboStartDate.DateTime < lstAccFixedAssets[this.cboFixedAssetCode.ItemIndex].StartDate)
                {
                    this.cboStartDate.Focus();
                    return -22;
                }
                if (decimal.Parse(this.txtAmount.EditValue.ToString()) == 0)
                {
                    this.txtAmount.Focus();
                    return -23;
                }
                if (decimal.Parse(this.txtMonthUsing.EditValue.ToString()) <= 0)
                {
                    this.txtMonthUsing.Focus();
                    return -24;
                }
                //iError = CheckDebitAmountByAccountCode(lstAccFixedAssets[this.cboFixedAssetCode.ItemIndex].AccountCode);
            }
            else
                return iError;
            return iError;
        }
        protected override void AssignData()
        {
            base.AssignData();
            FixedAssetUpgrade dataFixedAsset = new FixedAssetUpgrade();
            (this.DataSource as AccountTransactionFixedAssetUpgrade).FixedAsset=dataFixedAsset;
            dataFixedAsset.FixedAssetCode = this.cboFixedAssetCode.EditValue.ToString();
            dataFixedAsset.StartDate = this.cboStartDate.DateTime;
            dataFixedAsset.Amount = decimal.Parse(this.txtAmount.EditValue.ToString());
            dataFixedAsset.MonthUsing = int.Parse(this.txtMonthUsing.EditValue.ToString())*12;
            dataFixedAsset.Description = this.txtDescription1.Text;
        }

        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.cboFixedAssetCode.Properties.ReadOnly = false;
                this.txtAmount.Properties.ReadOnly = false;
                this.txtMonthUsing.Properties.ReadOnly = false;
                this.cboStartDate.Properties.ReadOnly = false;
                this.txtDescription1.Properties.ReadOnly = false;
                this.cboFixedAssetCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtAmount.Properties.ReadOnly = false;
                this.cboStartDate.Properties.ReadOnly = false;
                this.txtMonthUsing.Properties.ReadOnly = false;
                this.txtDescription1.Properties.ReadOnly = false;
                 this.cboFixedAssetCode.Properties.ReadOnly = false;
                this.cboStartDate.Focus();
            }
            else
            {
                this.cboFixedAssetCode.Properties.ReadOnly = true;
                this.txtAmount.Properties.ReadOnly = true;
                this.cboStartDate.Properties.ReadOnly = true;
                this.txtMonthUsing.Properties.ReadOnly = true;
                this.txtDescription1.Properties.ReadOnly = true;
            }
            base.RefreshControl();
            if (this.editMode == FormEditMode.ADD)
                tapFixedAssetUpgrade.SelectedTabPage = xtraTabPage2;
        }
        private int CheckDebitAmountByAccountCode(string debitAccountCode)
        {
            int ret = 0;
            decimal totalDebitAmount = 0;
            foreach (AccountTransactionDetail1 accDetail1 in (this.DataSource as AccountTransactionFixedAssetUpgrade).Detail1)
            {
                if (debitAccountCode == accDetail1.AccountCode)
                {
                    totalDebitAmount += (accDetail1.DebitAmount-accDetail1.CreditAmount);
                }
            }
            if (totalDebitAmount == 0)
                ret = -25;
            else
            {
                if (totalDebitAmount == decimal.Parse(this.txtAmount.EditValue.ToString()))
                    ret = 0;
                else
                    ret = -26;
            }
            return ret;
        }

    }
}
