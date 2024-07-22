using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCEmployee : EditControlBase
    {
        public UCEmployee()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                this.txtEmployeeID.Text = (DataSource as Employee).EmployeeID;
                this.txtEmployeeName.Text = (DataSource as Employee).EmployeeName;
                lookUpStockCode.EditValue = (dataSource as Employee).StockCode;
                if (lookUpStockCode.EditValue == null)
                {
                    lookUpStockCode.ItemIndex = 0;
                }
            }
            base.BindData();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                ListBase<Stock> lstStock = new ListBase<Stock>();
                lstStock = new StockBLL().GetAll();
                Stock stock = new Stock();
                stock.StockCode = string.Empty;
                stock.StockName = string.Empty;
                lstStock.Insert(0, stock);
                lookUpStockCode.Properties.DataSource = lstStock;
            }
            base.InitDataObject();
        }
        protected override void AssignData()
        {
            if (DataSource == null) DataSource = new Employee();
            (DataSource as Employee).EmployeeID = this.txtEmployeeID.Text;
            (DataSource as Employee).EmployeeName = this.txtEmployeeName.Text;
            (dataSource as Employee).StockCode = lookUpStockCode.EditValue.ToString();
            if (this.EditMode == FormEditMode.ADD)
            {
                (dataSource as Employee).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as Employee).DateCreated = DateTime.Now;

            }
            (dataSource as Employee).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as Employee).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            this.txtEmployeeID.Text = this.txtEmployeeID.Text.Trim();
            this.txtEmployeeName.Text = this.txtEmployeeName.Text.Trim();
            if(this.txtEmployeeID.Text =="") 
            {
                txtEmployeeID.Focus();
                return -1;
            }
            if (this.txtEmployeeName.Text == "")
            {
                txtEmployeeName.Focus();
                return -2;
            }
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            this.txtEmployeeID.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW) || (this.editMode == FormEditMode.EDIT);
            this.txtEmployeeName.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            lookUpStockCode.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            if (this.editMode == FormEditMode.ADD)
            {
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = txtBackGround.BackColor;
                txtEmployeeName.BackColor = txtBackGround.BackColor;
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                txtEmployeeName.Focus();
                txtEmployeeID.BackColor = lbEmployeeID.BackColor;
                txtEmployeeName.BackColor = txtBackGround.BackColor;
            } 
            if (this.editMode == FormEditMode.VIEW)
            {
                txtEmployeeName.Focus();
                txtEmployeeID.BackColor = lbEmployeeID.BackColor;
                txtEmployeeName.BackColor = lbEmployeeID.BackColor;
            }
            if (this.DataSource == null)
            {
                txtEmployeeID.Text = "";
                txtEmployeeName.Text = "";
            }
            base.RefreshControl();
        }
    }
}
