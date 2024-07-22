using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCCustomerPriceTypes : VNS.Windows.Controls.EditControlBase
    {
        public UCCustomerPriceTypes()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            CustomerPriceType customer = (dataSource as CustomerPriceType);
            if (this.DataSource != null)
            {
                this.lookUpSubject.EditValue = customer.SubjectCode;
                this.txtStartDate.DateTime = customer.StartDate;
                this.checkSpecialPrice.EditValue = customer.SpecialPrice;
                this.txtDescription.Text = customer.Description;
            }

            base.BindData();
        }
        protected override int ValidateData()
        {
            if (this.lookUpSubject.EditValue.ToString() == string.Empty)
            {
                this.lookUpSubject.Focus();
                return -1;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new CustomerPriceType();
            CustomerPriceType customer = (dataSource as CustomerPriceType);
            customer.SubjectCode = this.lookUpSubject.EditValue.ToString();
            customer.StartDate = this.txtStartDate.DateTime;
            customer.SpecialPrice = (bool) this.checkSpecialPrice.EditValue;
            customer.Description = this.txtDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                customer.UserCreated = Contexts.CurrentUser.LoginName;
                customer.DateCreated = DateTime.Now;
            }
            customer.UserUpdated = Contexts.CurrentUser.LoginName;
            customer.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                this.lookUpSubject.Properties.DataSource = new CustomerBLL().GetAll();
            }
            base.InitDataObject();
        }
        public override void RefreshControl()
        {
            bool view = (this.editMode == FormEditMode.VIEW);
            this.lookUpSubject.Properties.ReadOnly = view;
            this.txtStartDate.Properties.ReadOnly = view;
            this.checkSpecialPrice.Properties.ReadOnly = view;
            this.txtDescription.Properties.ReadOnly = view;

            base.RefreshControl();
        }
    }
}

