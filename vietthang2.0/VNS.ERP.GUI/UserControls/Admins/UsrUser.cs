using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Windows;
using VNS.ERP.Data;

using VNS.Security;
using VNS.Common;



namespace VNS.ERP.GUI.UserControl
{
    public partial class UsrUser :EditControlBase
    {
        public UsrUser()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            this.txtLoginName.Text = (this.dataSource as UserERP).LoginName;
            if ((this.dataSource as UserERP).Password!=null)
            this.txtPassword.EditValue= Crypto.DecryptString((this.dataSource as UserERP).Password);
            else 
                this.txtPassword.EditValue=(this.dataSource as UserERP).Password;

            this.CheckIsAdmin.EditValue = (this.dataSource as UserERP).IsAdmin;
            this.txtUserName.Text = (this.dataSource as UserERP).UserName;
            this.txtDescription.Text = (this.dataSource as UserERP).Description;
            LookupEmploy.EditValue = (this.dataSource as UserERP).EmployeeID;
            lookUpEditBranchCode.EditValue = (this.dataSource as UserERP).BranchCode;
            lookUpEditStockCode.EditValue = (this.dataSource as UserERP).StockCode;
            base.BindData();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                ListBase<Branch> lstBranch = new BranchBLL().GetAll();
                lstBranch.Insert(0, new Branch());
                lookUpEditBranchCode.Properties.DataSource = lstBranch;

                ListBase<Stock> lstStock = new StockBLL().GetAll();
                lstStock.Insert(0, new Stock());
                lookUpEditStockCode.Properties.DataSource = lstStock;
            }
            base.InitDataObject();
        }
        public void SetLookupEmploy(object Datasource)
        {
            this.LookupEmploy.Properties.DataSource = Datasource;
        }
        protected override void AssignData()
        {
            (this.dataSource as UserERP).BranchCode = lookUpEditBranchCode.EditValue.ToString();
            (this.dataSource as UserERP).StockCode = lookUpEditStockCode.EditValue.ToString();
            (this.dataSource as UserERP).LoginName= this.txtLoginName.Text ;
            if ( this.txtPassword.EditValue != null)
                (this.dataSource as UserERP).Password = Crypto.EncryptString( this.txtPassword.EditValue.ToString());
            else
                (this.dataSource as UserERP).Password = Crypto.EncryptString("");

            (this.dataSource as UserERP).IsAdmin=(Boolean) this.CheckIsAdmin.EditValue;
            (this.dataSource as UserERP).UserName=this.txtUserName.Text;
            if (this.LookupEmploy.EditValue != null)
                (this.dataSource as UserERP).EmployeeID =this.LookupEmploy.EditValue.ToString();
            else
                (this.dataSource as UserERP).EmployeeID =null;

            (this.dataSource as UserERP).Description=this.txtDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (this.dataSource as UserERP).UserCreated = Contexts.CurrentUser.LoginName;
                (this.dataSource as UserERP).DateCreated = DateTime.Now;
            }
            (this.dataSource as UserERP).UserUpdated = Contexts.CurrentUser.LoginName;
            (this.dataSource as UserERP).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            if (txtLoginName.Text == "") return -1;
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            txtLoginName.Properties.ReadOnly = this.editMode != FormEditMode.ADD;
            if (this.editMode != FormEditMode.ADD)
                txtLoginName.BackColor = lbDescription.BackColor;
            else
            {
                txtLoginName.Focus();
                txtLoginName.BackColor = Color.White;
            }
            if (editMode == FormEditMode.VIEW)

                RefreshUC(true, lbDescription.BackColor);
            else
                RefreshUC(false, Color.White);
            if (editMode == FormEditMode.EDIT) txtPassword.Focus();
            lookUpEditBranchCode.Properties.ReadOnly = lookUpEditStockCode.Properties.ReadOnly =
                this.EditMode == FormEditMode.VIEW;
            base.RefreshControl();
        }
        private void RefreshUC(bool value, Color color)
        {
            txtDescription.Properties.ReadOnly = value;
            txtPassword.Properties.ReadOnly = value;
            txtUserName.Properties.ReadOnly = value;
            LookupEmploy.Properties.ReadOnly = value;
            CheckIsAdmin.Properties.ReadOnly = value;

           
            txtDescription.BackColor = color;
            txtPassword.BackColor = color;
            txtUserName.BackColor = color;
            LookupEmploy.BackColor = color;


        }
      
    }
}
