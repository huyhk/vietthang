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
    public partial class UCCustomerPriceReduces : VNS.Windows.Controls.EditControlBase
    {
        public UCCustomerPriceReduces()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            CustomerPriceReduce customer = (dataSource as CustomerPriceReduce);
            if (this.DataSource != null)
            {
                this.lookUpSubject.EditValue = customer.SubjectCode;
                this.txtStartDate.DateTime = customer.StartDate;
                this.lookUpStock.EditValue = customer.StockCode;
                this.txtReduceAmount.EditValue = customer.ReduceAmount;
                this.txtReduceAmountNoTax.EditValue = customer.ReduceAmountNoTax;
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
            if (this.lookUpStock.EditValue.ToString() == string.Empty)
            {
                this.lookUpStock.Focus();
                return -2;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new CustomerPriceReduce();
            CustomerPriceReduce customer = (dataSource as CustomerPriceReduce);
            customer.SubjectCode = this.lookUpSubject.EditValue.ToString();
            customer.StartDate = this.txtStartDate.DateTime;
            customer.StockCode = this.lookUpStock.EditValue.ToString();
            customer.ReduceAmount = Convert.ToDecimal(this.txtReduceAmount.EditValue);
            customer.ReduceAmountNoTax = Convert.ToDecimal(this.txtReduceAmountNoTax.EditValue);
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
                this.lookUpStock.Properties.DataSource = new StockBLL().GetAll();
            }
            base.InitDataObject();
        }
        public override void RefreshControl()
        {
            bool view = (this.editMode == FormEditMode.VIEW);
            this.lookUpSubject.Properties.ReadOnly = view;
            this.txtStartDate.Properties.ReadOnly = view;
            this.lookUpStock.Properties.ReadOnly = view;
            this.txtReduceAmount.Properties.ReadOnly = view;
            this.txtReduceAmountNoTax.Properties.ReadOnly = view;
            this.txtDescription.Properties.ReadOnly = view;

            base.RefreshControl();
        }

        private void txtReduceAmount_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode == FormEditMode.VIEW)
                return;
            if (Convert.ToDecimal(this.txtReduceAmount.EditValue) != 0)
                this.txtReduceAmountNoTax.EditValue = 0;
        }

        private void txtReduceAmountNoTax_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode == FormEditMode.VIEW)
                return;
            if (Convert.ToDecimal(this.txtReduceAmountNoTax.EditValue) != 0)
                this.txtReduceAmount.EditValue = 0;
        }


    }
}

