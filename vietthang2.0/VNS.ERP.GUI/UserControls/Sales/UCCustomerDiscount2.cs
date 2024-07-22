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

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCCustomerDiscount2 : EditControlBase
    {
        private string customerCode = "";
        public string CustomerCode
        {
            get { return customerCode; }
            set { customerCode = value; }
        }
        public UCCustomerDiscount2()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                CustomerDiscount2 cdiscount = (DataSource as CustomerDiscount2);
                this.dateEditStart.EditValue = cdiscount.StartDate;
                //this.txtDiscountPercent.Text = cdiscount.DiscountPercent.ToString();
                this.txtDiscountPercent.EditValue = cdiscount.DiscountPercent;
                lookUpEditDiscountTypeCode.EditValue = cdiscount.DiscountTypeCode;
                if (this.EditMode == VNS.Windows.FormEditMode.ADD)
                {
                    try
                    {
                        lookUpEditDiscountTypeCode.ItemIndex = 0;
                    }
                    catch
                    {
                    }
                }
                this.txtDescription.Text = cdiscount.Description;
            }
            base.BindData();
        }
        public void SetDss()
        {
            lookUpEditDiscountTypeCode.Properties.DataSource = new CustomerDiscountTypeBLL().GetAll();
        }
        protected override void AssignData()
        {
            if (DataSource == null) DataSource = new CustomerDiscount2();
            CustomerDiscount2 cdis = (DataSource as CustomerDiscount2);

            if (this.EditMode == FormEditMode.ADD)
            {
                cdis.UserCreated = Contexts.CurrentUser.LoginName;
                cdis.DateCreated = DateTime.Now;
            }
            cdis.UserUpdated = Contexts.CurrentUser.LoginName;
            cdis.DateUpdated = DateTime.Now;
            cdis.CustomerCode = this.CustomerCode;
            cdis.StartDate = dateEditStart.DateTime;
            cdis.DiscountPercent = Convert.ToDecimal(txtDiscountPercent.EditValue);
            cdis.DiscountTypeCode = lookUpEditDiscountTypeCode.EditValue.ToString();
            cdis.Description = txtDescription.Text;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            if (lookUpEditDiscountTypeCode.EditValue == null)
            {
                lookUpEditDiscountTypeCode.Focus();
                return -1;
            }
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            dateEditStart.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            lookUpEditDiscountTypeCode.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT; 
            txtDiscountPercent.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtDescription.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
           
            if (this.DataSource == null)
            {
                txtDiscountPercent.Text = "";
                txtDescription.Text = "";
            }
            base.RefreshControl();
        }
    }
}
