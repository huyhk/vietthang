using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using VNS.Windows;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormCustomerDeptOpening : FormEditBase
    {
        string periodCode;
        string datePeriod;
        private ListBase<Customer> lstCus;
        private ListBase<CustomerDeptOpening> lst;
        private ListBase<CustomerDeptSumOpening> lst2; 
        public FormCustomerDeptOpening()
        {
            InitializeComponent();
        }
  
        private void FormCustomerDeptOpening_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.cboStockCode.DataSource = (new StockBLL()).GetAll();
                lstCus=new CustomerBLL().GetAll();
                Period obj = new PeriodBLL().GetMin();
                this.datePeriod = obj.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
                this.periodCode = obj.PeriodCode;
                this.Text = this.Text + " " + this.datePeriod;
                this.gridControl1.DataSource = new CustomerDeptOpeningBLL().GetByPeriodCode(periodCode);
                this.gridControl2.DataSource = new CustomerDeptSumOpeningBLL().GetByPeriodCode(periodCode);
                this.cboCustomerCode.DataSource = lstCus;
                this.cboCustomerName.DataSource = lstCus;
                this.lookUpEditCustomerCode.DataSource = lstCus;
                this.lookUpEditCustomerName.DataSource = lstCus;
                RefreshButtons ();

                PeriodBLL periodBLL = new PeriodBLL();
                if (periodBLL.SelectIsClosedTrue(enumModuleID.Sale.ToString()).Count > 0)
                    this.btnEdit.Enabled = false;
                this.navigatorFrmEditBase.Visible = false;
            }
        }

       
        protected override bool SaveData()
        {
            lst = (gridView1.DataSource as ListBase<CustomerDeptOpening>);
            foreach (CustomerDeptOpening obj in lst)
            {
                 obj.PeriodCode = this.periodCode;
            }
            lst2 = (gridView2.DataSource as ListBase<CustomerDeptSumOpening>);
            foreach (CustomerDeptSumOpening obj in lst2)
            {
                obj.PeriodCode = this.periodCode;
            }
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int iError = ValidateData2();
            if (iError != 0)
            {
                OnError(iError, messageType);
                return false;
            }
            messageType = ErrorMessageType.INSERT;
            iError = new CustomerDeptOpeningBLL().Insert(lst,lst2,periodCode);
            if (iError != 0)
            {
                OnError(iError, messageType);
                return false;
            }
            return base.SaveData();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
                if (e.KeyCode == Keys.Delete) gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }
        private int ValidateData2()
        {
           
            foreach (CustomerDeptOpening obj in lst)
            {
                if (obj.CustomerCode == null) return -2;
                if (obj.StockCode == null) return -1;
                
            }
            foreach (CustomerDeptSumOpening obj in lst2)
            {
                if (obj.CustomerCode == null) return -2;

                if (lst.Search("CustomerCode", obj.CustomerCode) != null)
                    return -3;
            }
            return 0;
        }
        public override void RefreshButtons()
        {
            this.btnEdit.Enabled = this.editMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.editMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.editMode == FormEditMode.EDIT;
            gridView1.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
            gridView2.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
            if (this.EditMode == FormEditMode.EDIT)
            {
                gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
            else
            {
                gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        private void cboCustomerCode_EditValueChanged(object sender, EventArgs e)
        {
            string customerCode = (sender as LookUpEdit).GetColumnValue("SubjectCode").ToString();
            gridView2.SetRowCellValue(gridView2.FocusedRowHandle, this.colCustomerName2, customerCode);
        }

        private void lookUpEditCustomerCode_EditValueChanged(object sender, EventArgs e)
        {
            string customerCode = (sender as LookUpEdit).GetColumnValue("SubjectCode").ToString();
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, this.colCustomerName, customerCode);
        }
    }
}