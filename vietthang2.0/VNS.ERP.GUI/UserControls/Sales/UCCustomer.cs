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
using VNS.Common;


namespace VNS.ERP.GUI.UserControls
{
    public partial class UCCustomer : EditControlBase
    {
       
        public UCCustomer()
        {
            InitializeComponent();
          
        }
        protected override void BindData()
        {

            if (this.DataSource != null)
            {
                Customer obj = dataSource as Customer;
                this.txtSubjectCode.Text = obj.SubjectCode;
                this.txtSubjectName.Text = obj.SubjectName;
                this.txtAddress.Text = obj.Address;
                this.txtPhone.Text = obj.Phone;
                this.txtFax.Text = obj.Fax;
                this.txtTaxCode.Text = obj.TaxCode;
                this.txtBankName.Text = obj.BankName;
                this.txtBankAccountNo.Text = obj.BankAccountNo;
                this.txtDescription.Text = obj.Description;
                this.cboProductType.Text = obj.ProductType;
                if (this.editMode != FormEditMode.ADD)
                {
                    this.cboProvinces.EditValue = obj.Province;
                   
                }
                this.txtDistrict.Text = obj.District;
                this.txtContactName.Text = obj.ContactName;
                this.txtBAPNo.Text = obj.BAPNo;
                this.txtSohieu.Text = obj.SoHieu;
            }

            base.BindData();
        }
        protected override int ValidateData()
        {
            if (this.txtSubjectCode.Text == string.Empty) 
            {
                this.txtSubjectCode.Focus();
                return -1;
            }
            if (this.txtSubjectName.Text == string.Empty) 
            {
                this.txtSubjectName.Focus();
                return -2;
            }
            if (this.cboProvinces.Text == string.Empty)
            {
                this.cboProvinces.Focus();
                return -3;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Customer();
            (dataSource as Customer).SubjectCode = this.txtSubjectCode.Text;
            (dataSource as Customer).SubjectName = this.txtSubjectName.Text;
            (dataSource as Customer).Address = this.txtAddress.Text;
            (dataSource as Customer).Phone = this.txtPhone.Text;
            (dataSource as Customer).Fax = this.txtFax.Text;
            (dataSource as Customer).TaxCode = this.txtTaxCode.Text;
            (dataSource as Customer).BankName = this.txtBankName.Text;
            (dataSource as Customer).BankAccountNo = this.txtBankAccountNo.Text;
            (dataSource as Customer).Description = this.txtDescription.Text;
            (dataSource as Customer).Province = this.cboProvinces.EditValue.ToString();
            (dataSource as Customer).District= this.txtDistrict.Text ;
            (dataSource as Customer).ContactName= this.txtContactName.Text ;
            (dataSource as Customer).ProductType = this.cboProductType.Text;
            (dataSource as Customer).BAPNo = this.txtBAPNo.Text;
            (dataSource as Customer).SoHieu = this.txtSohieu.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtSubjectCode.Properties.ReadOnly = false;
                this.txtSubjectName.Properties.ReadOnly = false;
                this.txtAddress.Properties.ReadOnly = false;
                this.txtPhone.Properties.ReadOnly = false;
                this.txtFax.Properties.ReadOnly = false;
                this.txtTaxCode.Properties.ReadOnly = false;
                this.txtBankName.Properties.ReadOnly = false;
                this.txtBankAccountNo.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.cboProvinces.Properties.ReadOnly = false;
                this.txtContactName.Properties.ReadOnly = false;
                this.txtDistrict.Properties.ReadOnly = false;
                this.cboProductType.Enabled = true;
                this.txtBAPNo.Properties.ReadOnly = false;
                this.txtSohieu.Properties.ReadOnly = false;
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                this.txtSubjectCode.Properties.ReadOnly = true;
                this.txtSubjectName.Focus();
                this.txtSubjectName.Properties.ReadOnly = false;
                this.txtAddress.Properties.ReadOnly = false;
                this.txtPhone.Properties.ReadOnly = false;
                this.txtFax.Properties.ReadOnly = false;
                this.txtTaxCode.Properties.ReadOnly = false;
                this.txtBankName.Properties.ReadOnly = false;
                this.txtBankAccountNo.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.cboProvinces.Properties.ReadOnly = false;
                this.txtContactName.Properties.ReadOnly = false;
                this.txtDistrict.Properties.ReadOnly = false;
                this.cboProductType.Enabled = true;
                this.txtBAPNo.Properties.ReadOnly = false;
                this.txtSohieu.Properties.ReadOnly = false;
            }
            if (this.editMode == FormEditMode.VIEW)
            {
                this.txtSubjectCode.Properties.ReadOnly = true;
                this.txtSubjectName.Properties.ReadOnly = true;
                this.txtAddress.Properties.ReadOnly = true;
                this.txtPhone.Properties.ReadOnly = true;
                this.txtFax.Properties.ReadOnly = true;
                this.txtTaxCode.Properties.ReadOnly = true;
                this.txtBankName.Properties.ReadOnly = true;
                this.txtBankAccountNo.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.cboProvinces.Properties.ReadOnly = true;
                this.txtContactName.Properties.ReadOnly = true;
                this.txtDistrict.Properties.ReadOnly = true;
                this.cboProductType.Enabled = false;
                this.txtBAPNo.Properties.ReadOnly = true;
                this.txtSohieu.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }

        private void UCCustomer_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.cboProvinces.Properties.DataSource = (new ProvinceBLL()).GetAll();
                this.cboProvinces.ItemIndex = 0;
            }
           
        }
    }
}
