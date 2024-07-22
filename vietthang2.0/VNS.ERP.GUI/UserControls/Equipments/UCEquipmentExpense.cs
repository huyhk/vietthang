using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data.Equipments;
using VNS.Windows;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Equipments
{
    public partial class UCEquipmentExpense : EditControlBase
    {
        public UCEquipmentExpense()
        {
            InitializeComponent();

            this.txtExpenseDate.EditValue = Contexts.WorkingPeriod.PeriodCode;
        }
        private string _StockCode;

        public string StockCode
        {
           get { return _StockCode; }
            set { this._StockCode  = value; 
                _StockCode=value;}
        }
         
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtExpenseNo.Text = (dataSource as EquipmentExpense).ExpenseNo;
                this.txtExpenseDate.DateTime = (dataSource as EquipmentExpense).ExpenseDate;
                this.txtDescription.Text = (dataSource as EquipmentExpense).Description;
                this.txtAmount.EditValue = (dataSource as EquipmentExpense).Amount;
                this.lkStockCode.EditValue = this.StockCode;
                

            }

        }
        protected override int ValidateData()
        {
            if (this.txtExpenseNo.Text == string.Empty)
            {
                this.txtExpenseNo.Focus();
                return -1;
            }
            if (Convert.ToDecimal(this.txtAmount.EditValue.ToString())==0)
            {
                this.txtAmount.Focus();
                return -2;
            }
          
            return 0;
        }
        protected override void AssignData()
        {

            if (dataSource == null)
                dataSource = new EquipmentExpense();
            (dataSource as EquipmentExpense).ExpenseNo = this.txtExpenseNo.Text;
            (dataSource as EquipmentExpense).ExpenseDate  = this.txtExpenseDate.DateTime;
            (dataSource as EquipmentExpense).Amount =Convert.ToDecimal(this.txtAmount.EditValue.ToString());
            (dataSource as EquipmentExpense).Description = this.txtDescription.Text;
            (dataSource as EquipmentExpense).StockCode = StockCode;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                (dataSource as EquipmentExpense).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as EquipmentExpense).DateCreated = DateTime.Now;
            }
            (dataSource as EquipmentExpense).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as EquipmentExpense).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool viewmode = this.editMode == FormEditMode.VIEW;
           
            this.txtExpenseNo.Properties.ReadOnly = viewmode;
            this.txtExpenseDate.Properties.ReadOnly = viewmode;
            this.txtAmount.Properties.ReadOnly = viewmode;
            this.lkStockCode.Properties.ReadOnly =true;
            this.txtDescription.Properties.ReadOnly = viewmode;
                       
            base.RefreshControl();
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!DesignMode)
            {
                this.lkStockCode.Properties.DataSource = new StockBLL().GetAll();
            }
        }
    }
}
