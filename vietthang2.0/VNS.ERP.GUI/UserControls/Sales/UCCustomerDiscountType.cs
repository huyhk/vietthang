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

namespace VNS.ERP.GUI
{
    public partial class UCCustomerDiscountType : EditControlBase
    {
        public UCCustomerDiscountType()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtDiscountTypeCode.Text = (dataSource as CustomerDiscountType).DiscountTypeCode;
                this.txtDiscountTypeName.Text = (dataSource as CustomerDiscountType).DiscountTypeName;
                this.txtDescription.Text = (dataSource as CustomerDiscountType).Description;
            }
        }
        protected override int ValidateData()
        {
            if (this.txtDiscountTypeCode.Text == string.Empty)
            {
                this.txtDiscountTypeCode.Focus();
                return -1;
            }
            if (this.txtDiscountTypeName.Text == string.Empty)
            {
                this.txtDiscountTypeName.Focus();
                return -2;
            }

            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new CustomerDiscountType();
            (dataSource as CustomerDiscountType).DiscountTypeCode = this.txtDiscountTypeCode.Text;
            (dataSource as CustomerDiscountType).DiscountTypeName = this.txtDiscountTypeName.Text;
            (dataSource as CustomerDiscountType).Description = this.txtDescription.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtDiscountTypeCode.Properties.ReadOnly = false;
                this.txtDiscountTypeName.Properties.ReadOnly = false;
                this.txtDescription.ReadOnly = false;
                this.txtDiscountTypeCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtDiscountTypeCode.Properties.ReadOnly = true;
                this.txtDiscountTypeName.Properties.ReadOnly = false;
                this.txtDescription.ReadOnly = false;
                this.txtDiscountTypeName.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
            {

                this.txtDiscountTypeCode.Properties.ReadOnly = true;
                this.txtDiscountTypeName.Properties.ReadOnly = true;
                this.txtDescription.ReadOnly = true;
            }
            base.RefreshControl();
        }


    }
}
