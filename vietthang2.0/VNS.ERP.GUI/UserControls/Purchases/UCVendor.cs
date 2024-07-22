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
    public partial class UCVendor : EditControlBase
    {
      
        public UCVendor()
        {
            InitializeComponent();
           
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtSubjectCode.Text = (dataSource as Vendor).SubjectCode;
                this.txtSubjectName.Text = (dataSource as Vendor).SubjectName;
                this.txtAddress.Text = (dataSource as Vendor).Address;
                this.txtPhone.Text = (dataSource as Vendor).Phone;
                this.txtFax.Text = (dataSource as Vendor).Fax;
                this.txtTaxCode.Text = (dataSource as Vendor).TaxCode;
                this.txtBankName.Text = (dataSource as Vendor).BankName;
                this.txtBankAccountNo.Text = (dataSource as Vendor).BankAccountNo;
                this.txtDescription.Text = (dataSource as Vendor).Description;
                this.txtRepName.Text = (dataSource as Vendor).RepName;
                this.txtRepJob.Text = (dataSource as Vendor).RepJob;
                this.checkPurchaseDept.Checked = (dataSource as Vendor).PurchaseDept;
                this.checkBocxepDept.Checked = (dataSource as Vendor).BocxepDept;
                this.checkVanchuyenDept.Checked = (dataSource as Vendor).VanchuyenDept;
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
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Vendor();
            (dataSource as Vendor).SubjectCode = this.txtSubjectCode.Text;
            (dataSource as Vendor).SubjectName = this.txtSubjectName.Text;
            (dataSource as Vendor).Address = this.txtAddress.Text;
            (dataSource as Vendor).Phone = this.txtPhone.Text;
            (dataSource as Vendor).Fax = this.txtFax.Text;
            (dataSource as Vendor).TaxCode = this.txtTaxCode.Text;
            (dataSource as Vendor).BankName = this.txtBankName.Text;
            (dataSource as Vendor).BankAccountNo = this.txtBankAccountNo.Text;
            (dataSource as Vendor).Description = this.txtDescription.Text;
            (dataSource as Vendor).RepName = this.txtRepName.Text;
            (dataSource as Vendor).RepJob = this.txtRepJob.Text;
            (dataSource as Vendor).PurchaseDept = this.checkPurchaseDept.Checked;
            (dataSource as Vendor).BocxepDept = this.checkBocxepDept.Checked;
            (dataSource as Vendor).VanchuyenDept = this.checkVanchuyenDept.Checked;
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
                this.txtDescription.ReadOnly = false;
                this.txtRepName.Properties.ReadOnly = false;
                this.txtRepJob.Properties.ReadOnly = false;
                this.checkPurchaseDept.Properties.ReadOnly = false;
                this.checkBocxepDept.Properties.ReadOnly = false;
                this.checkVanchuyenDept.Properties.ReadOnly = false;
                this.txtSubjectCode.Focus();
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                this.txtSubjectCode.Properties.ReadOnly = true;
                this.txtSubjectName.Properties.ReadOnly = false;
                this.txtAddress.Properties.ReadOnly = false;
                this.txtPhone.Properties.ReadOnly = false;
                this.txtFax.Properties.ReadOnly = false;
                this.txtTaxCode.Properties.ReadOnly = false;
                this.txtBankName.Properties.ReadOnly = false;
                this.txtBankAccountNo.Properties.ReadOnly = false;
                this.txtDescription.ReadOnly = false;
                this.txtRepName.Properties.ReadOnly = false;
                this.txtRepJob.Properties.ReadOnly = false;
                this.checkPurchaseDept.Properties.ReadOnly = false;
                this.checkBocxepDept.Properties.ReadOnly = false;
                this.checkVanchuyenDept.Properties.ReadOnly = false;
                this.txtSubjectName.Focus();

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
                this.txtDescription.ReadOnly = true;
                this.txtRepName.Properties.ReadOnly = true;
                this.txtRepJob.Properties.ReadOnly = true;
                this.checkPurchaseDept.Properties.ReadOnly = true;
                this.checkBocxepDept.Properties.ReadOnly = true;
                this.checkVanchuyenDept.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }



    }
}
