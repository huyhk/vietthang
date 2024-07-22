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


namespace VNS.ERP.GUI
{
    public partial class UCBranch : EditControlBase
    {

        public UCBranch()
        {
            InitializeComponent();
           
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtSubjectCode.Text = (dataSource as Branch).SubjectCode;
                this.txtSubjectName.Text = (dataSource as Branch).SubjectName;
                this.txtAddress.Text = (dataSource as Branch).Address;
                this.txtPhone.Text = (dataSource as Branch).Phone;
                this.txtFax.Text = (dataSource as Branch).Fax;
                this.txtTaxCode.Text = (dataSource as Branch).TaxCode;
                this.txtBankName.Text = (dataSource as Branch).BankName;
                this.txtBankAccountNo.Text = (dataSource as Branch).BankAccountNo;
                this.txtDescription.Text = (dataSource as Branch).Description;
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
            if (dataSource == null) dataSource = new Branch();
            (dataSource as Branch).SubjectCode = this.txtSubjectCode.Text;
            (dataSource as Branch).SubjectName = this.txtSubjectName.Text;
            (dataSource as Branch).Address = this.txtAddress.Text;
            (dataSource as Branch).Phone = this.txtPhone.Text;
            (dataSource as Branch).Fax = this.txtFax.Text;
            (dataSource as Branch).TaxCode = this.txtTaxCode.Text;
            (dataSource as Branch).BankName = this.txtBankName.Text;
            (dataSource as Branch).BankAccountNo = this.txtBankAccountNo.Text;
            (dataSource as Branch).Description = this.txtDescription.Text;

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
                this.txtSubjectCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
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
                this.txtSubjectName.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
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
            }
            base.RefreshControl();
        }

    }
}
