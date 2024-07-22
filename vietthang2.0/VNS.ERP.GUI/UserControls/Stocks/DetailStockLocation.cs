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

namespace VNS.ERP.GUI.UserControl
{
    public partial class DetailStockLocation : EditControlBase
    {
        public static string sCode;
        public DetailStockLocation()
        {
            InitializeComponent();
        }
        #region Method
      
        protected override void BindData()
        {
            if (dataSource != null)
            {
                (dataSource as StockLocation).StockCode = sCode;
                this.txtStockLocationCode.Text = (dataSource as StockLocation).StockLocationCode;
                this.txtDescription.Text = (dataSource as StockLocation).Description;    
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new StockLocation();
            (dataSource as StockLocation).StockCode = sCode;
            (dataSource as StockLocation).StockLocationCode = this.txtStockLocationCode.Text;
            (dataSource as StockLocation).Description = this.txtDescription.Text;
            if (this.EditMode == FormEditMode.ADD)
            {
                (dataSource as StockLocation).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as StockLocation).DateCreated = DateTime.Now;
            }
            (dataSource as StockLocation).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as StockLocation).DateUpdated = DateTime.Now;
            base.AssignData();
            //base.AssignData();
        }
        public override void RefreshControl()
        {
            txtStockLocationCode.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW) || (this.editMode == FormEditMode.EDIT);
            txtDescription.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            if (this.editMode == FormEditMode.ADD)
            {
                txtStockLocationCode.Focus();
                txtStockLocationCode.BackColor = txtBackGround.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                txtDescription.Focus();
                txtStockLocationCode.BackColor = lbStockLocationCode.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
            }
            if (this.editMode == FormEditMode.VIEW)
            {
                txtStockLocationCode.BackColor = lbStockLocationCode.BackColor;
                txtDescription.BackColor = lbStockLocationCode.BackColor;
            }
            if (this.DataSource == null)
            {
                this.txtStockLocationCode.Text = "";
                this.txtDescription.Text = "";    
            }
            base.RefreshControl();
        }
        protected override int ValidateData()
        {
            this.txtStockLocationCode.Text = this.txtStockLocationCode.Text.Trim();
            this.txtDescription.Text = this.txtDescription.Text.Trim();
            if (this.txtStockLocationCode.Text == "")
            {
                txtStockLocationCode.Focus();
                return -1;
            }
            return base.ValidateData();
        }
        #endregion
    }
}
