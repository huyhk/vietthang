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
using VNS.Windows;
using DevExpress.XtraGrid.Views.Grid;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormPrePaidReDepreciation : FormEditBase
    {
        private PrePaidReDepreciationBLL preBLL;
        private ListBase<Period> lstPeriod;
        private PrePaidExpenseOpeningBLL prePaidOpenBLL;
        private DataTable dtOpen;
        private ListBase<PrePaidReDepreciation> lstPreRe;
        public FormPrePaidReDepreciation()
        {
            InitializeComponent();
        }
        public override void RefreshButtons()
        {
            this.cboPeriodCode.Properties.ReadOnly = this.EditMode != FormEditMode.VIEW;
            this.gridView1.OptionsBehavior.Editable = this.EditMode != FormEditMode.VIEW;
            this.btnEdit.Enabled = this.EditMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.EditMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.EditMode == FormEditMode.EDIT;
            this.navigatorFrmEditBase.Visible = false;
          
         }

         protected override bool SaveData()
         {

             ErrorMessageType messageType = ErrorMessageType.VALIDATE;
             int ret = ValidateData();
             if (ret != 0)
             {
                 OnError(ret, messageType);
                 return false;
             }
             messageType = ErrorMessageType.INSERT;
             int Error = preBLL.InsertListPrePaidReDepreciation((this.gridControl1.DataSource as ListBase<PrePaidReDepreciation>), this.cboPeriodCode.EditValue.ToString());
             if (Error != 0)
             {
                 OnError(Error, messageType);
                 return false;
             }
             return base.SaveData();
         }
         public override void CancelItem()
         {
             if (this.cboPeriodCode.ItemIndex != -1)
             {
                 lstPreRe = preBLL.GetListPrePaidReDepreciationByPeriodCode(this.cboPeriodCode.EditValue.ToString());
                SetDataSource();
                 this.gridControl1.RefreshDataSource();
               
             }
             base.CancelItem();

         }
        private void ItemLookUpPrePaid_EditValueChanged(object sender, EventArgs e)
        {
            if (this.EditMode == FormEditMode.EDIT)
            {
                string prePaidName = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("PrePaidName").ToString();
                string description = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("Description").ToString();
                this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, this.colPrePaidName, prePaidName);
                this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, this.colDescription, description);
            }
        }

        private void FormPrePaidReDepreciation_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                prePaidOpenBLL=new PrePaidExpenseOpeningBLL();
                preBLL = new PrePaidReDepreciationBLL();
                lstPeriod=new PeriodBLL().GetAll();
                this.cboPeriodCode.Properties.DataSource = lstPeriod;
                this.cboPeriodCode.EditValue = Contexts.WorkingPeriod.PeriodCode;
                RefreshButtons();
                ListBase<PrePaidExpense> lstPreEx = (new PrePaidExpenseBLL()).GetAll();
                this.ItemLookUpPrePaidName.DataSource = lstPreEx;
                this.ItemLookUpDescription.DataSource = lstPreEx;
            }
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView1.RowCount > 0 && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }
        }

        private void cboPeriodCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cboPeriodCode.ItemIndex != -1)
            {
              lstPreRe = preBLL.GetListPrePaidReDepreciationByPeriodCode(this.cboPeriodCode.EditValue.ToString());
              dtOpen = prePaidOpenBLL.GetListPrePaidOpeningByStartDate(lstPeriod[this.cboPeriodCode.ItemIndex].StartDate, this.cboPeriodCode.EditValue.ToString());
              SetDataSource();
            
            }
        }
        private void SetDataSource()
        {
            foreach (DataRow dr in dtOpen.Rows)
            {
                PrePaidReDepreciation preRe = new PrePaidReDepreciation();
                preRe.PrePaidCode = dr["PrePaidCode"].ToString();
                preRe.PeriodCode = this.cboPeriodCode.EditValue.ToString();
                PrePaidReDepreciation preReS = lstPreRe.Search("PrePaidCode", preRe.PrePaidCode);
                if (preReS == null)
                {
                    preRe.CheckEdit = false;
                    lstPreRe.Add(preRe);
                }
            }
            this.gridControl1.DataSource = lstPreRe;
        }
    }
}