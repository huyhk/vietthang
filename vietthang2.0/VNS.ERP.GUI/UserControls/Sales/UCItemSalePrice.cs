using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Windows;

namespace VNS.ERP.GUI.UserControls.Sales
{
    public partial class UCItemSalePrice : EditControlBase
    {
        public string ItemCode = "";
        public UCItemSalePrice()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                ItemSalePrice isp = (DataSource as ItemSalePrice);
                dateEditStart.EditValue = isp.StartDate;
                txtSalePrice.Text = isp.SalePrice.ToString();
                txtDescription.Text = isp.Description;
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            if (DataSource == null) DataSource = new ItemSalePrice();
            ItemSalePrice isp = (DataSource as ItemSalePrice);
            if (this.EditMode == FormEditMode.ADD)
            {
                isp.UserCreated = Contexts.CurrentUser.LoginName;
                isp.DateCreated = DateTime.Now;
            }
            isp.UserUpdated = Contexts.CurrentUser.LoginName;
            isp.DateUpdated = DateTime.Now;
            isp.ItemCode = ItemCode;
            isp.StartDate = dateEditStart.DateTime;
            isp.SalePrice = Convert.ToDecimal(txtSalePrice.EditValue);
            isp.Description = txtDescription.Text;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            if (Convert.ToDecimal(txtSalePrice.EditValue) <= 0)
            {
                txtSalePrice.Focus();
                return -1;
            }
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            dateEditStart.Properties.ReadOnly = !(this.EditMode == FormEditMode.ADD);
            txtSalePrice.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtDescription.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            if (this.EditMode == FormEditMode.VIEW)
            {
                dateEditStart.BackColor = lbStartDate.BackColor;
                txtSalePrice.BackColor = lbStartDate.BackColor;
                txtDescription.BackColor = lbStartDate.BackColor;
            }
            if (this.EditMode == FormEditMode.EDIT)
            {
                txtSalePrice.Focus();
                dateEditStart.BackColor = lbStartDate.BackColor;
                txtSalePrice.BackColor = txtBackGround.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
            }
            if (this.EditMode == FormEditMode.ADD)
            {
                dateEditStart.Focus();
                dateEditStart.BackColor = txtBackGround.BackColor;
                txtSalePrice.BackColor = txtBackGround.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
            }
            if (this.DataSource == null)
            {
                txtSalePrice.Text = "";
                txtDescription.Text = "";
            }
            base.RefreshControl();
        }
    }
}
