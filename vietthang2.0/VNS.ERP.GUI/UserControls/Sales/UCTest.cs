using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows;
using VNS.ERP.Data.Sales;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.UserControls.Sales
{
    public partial class UCTest : VNS.Windows.Controls.EditControlBase
    {
        public UCTest()
        {
            InitializeComponent();
        }

        private void UCTest_Load(object sender, EventArgs e)
        {
            //lookUpEditDiscountTypeCode.Properties.DataSource = new CustomerDiscountTypeBLL().GetAll();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                CustomerDiscountList cdiscount = (DataSource as CustomerDiscountList);
                this.txtDiscountName.Text = cdiscount.DiscountName;
                //this.txtDiscountPercent.Text = cdiscount.DiscountPercent.ToString();
                this.chkInActive.Checked = cdiscount.InActive;
                lookUpEditDiscountTypeCode.EditValue = cdiscount.DiscountType;
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

            }
            base.BindData();
        }
        protected override void AssignData()
        {
            if (DataSource == null) DataSource = new CustomerDiscountList();
            CustomerDiscountList cdis = (DataSource as CustomerDiscountList);

            if (this.EditMode == FormEditMode.ADD)
            {
                cdis.UserCreated = Contexts.CurrentUser.LoginName;
                cdis.DateCreated = DateTime.Now;
            }
            cdis.UserUpdated = Contexts.CurrentUser.LoginName;
            cdis.DateUpdated = DateTime.Now;
            cdis.DiscountName = this.txtDiscountName.Text;
            cdis.InActive = this.chkInActive.Checked;

            cdis.DiscountType = lookUpEditDiscountTypeCode.EditValue.ToString();

            base.AssignData();
        }
        protected override int ValidateData()
        {
            if (lookUpEditDiscountTypeCode.EditValue == null)
            {
                lookUpEditDiscountTypeCode.Focus();
                return -1;
            }
            if (this.txtDiscountName.Text == string.Empty)
                return -2;
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            bool em = this.EditMode != FormEditMode.VIEW;
            lookUpEditDiscountTypeCode.Properties.ReadOnly = em;
            txtDiscountName.Properties.ReadOnly = em;
            chkInActive.Properties.ReadOnly = em;

            base.RefreshControl();
        }
    }
}
