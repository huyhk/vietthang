using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Accounting;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class UCFixedAssetLiquidate : UCAccountTransaction //VNS.Windows.Controls.EditControlBase 
    {
        public UCFixedAssetLiquidate()
        {
            InitializeComponent();
            //this.panelControl1.Parent = this.xtraTabPage1;
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                //startDate = (new PeriodBLL()).GetMin().StartDate;
                //lstAccFixedAssets = (new AccountFixedAssetBLL().GetAll());
                this.cboFixedAssetCode.Properties.DataSource = (new AccountFixedAssetBLL().GetAll());
                base.InitDataObject();

                this.panelControl1.Parent = this.xtraTabPage1;
            }
        }
        protected override void BindData()
        {
            AccountTransactionFixedAssetLiquidate t = this.DataSource as AccountTransactionFixedAssetLiquidate;
            base.BindData();
            if (t.FixedAsset == null && this.EditMode == FormEditMode.ADD)
                t.FixedAsset = new FixedAssetLiquidate();
            //(this.DataSource as AccountTransactionFixedAssetUpgrade).Detail1.Count == 0 || 
            if (((t.FixedAsset == null) && this.EditMode != FormEditMode.ADD))
                (new AccountTransactionFixedAssetLiquidateBLL()).GetDetailAccountTransactionFixedAssetLiquidate(t);
            this.cboFixedAssetCode.EditValue = t.FixedAsset.FixedAssetCode;
            this.cboStartDate.DateTime = t.FixedAsset.StartDate;
            this.txtAmount.EditValue = t.FixedAsset.Amount;
            this.txtDescription1.Text = t.FixedAsset.Description;
        }

        protected override int ValidateData()
        {
            int iError = base.ValidateData();
            if (iError != 0)
                return iError;

            if (this.cboFixedAssetCode.EditValue.ToString() == string.Empty)
            {
                this.cboFixedAssetCode.Focus();
                return -21;
            }

            return iError;
        }
        protected override void AssignData()
        {
            base.AssignData();
            FixedAssetLiquidate dataFixedAsset = (this.DataSource as AccountTransactionFixedAssetLiquidate).FixedAsset;

            dataFixedAsset.FixedAssetCode = this.cboFixedAssetCode.EditValue.ToString();
            dataFixedAsset.StartDate = this.cboStartDate.DateTime;
            dataFixedAsset.Amount = (decimal)this.txtAmount.EditValue;
            dataFixedAsset.Description = this.txtDescription1.Text;
        }
        public override void RefreshControl()
        {

            this.cboFixedAssetCode.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            this.txtAmount.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            this.cboStartDate.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            this.txtDescription1.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            this.cboFixedAssetCode.Focus();
            base.RefreshControl();
            if (this.editMode == FormEditMode.ADD)
                TabFixedAsset.SelectedTabPage = xtraTabPage2;
        }
        private void UCFixedAssetLiquidate_Load(object sender, EventArgs e)
        {
            //this.panelControl1.Parent = this.xtraTabPage1;
        }
    }
}

