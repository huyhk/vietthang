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
    public partial class UCObjectInserts : EditControlBase
    {

        public UCObjectInserts()
        {
            InitializeComponent();
        }

        private string subjectType = string.Empty;
        public string SubjectType
        {
            get { return subjectType; }
            set { subjectType = value; }
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtSubjectCode.Text = (dataSource as Subject).SubjectCode;
                this.txtSubjectName.Text = (dataSource as Subject).SubjectName;
                this.txtAddress.Text = (dataSource as Subject).Address;
                this.txtPhone.Text = (dataSource as Subject).Phone;
                this.txtFax.Text = (dataSource as Subject).Fax;
                this.txtTaxCode.Text = (dataSource as Subject).TaxCode;
                this.txtBankName.Text = (dataSource as Subject).BankName;
                this.txtBankAccountNo.Text = (dataSource as Subject).BankAccountNo;
                this.txtDescription.Text = (dataSource as Subject).Description;
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
            if (dataSource == null) dataSource = new Subject();
            (dataSource as Subject).SubjectCode = this.txtSubjectCode.Text;
            (dataSource as Subject).SubjectName = this.txtSubjectName.Text;
            (dataSource as Subject).Address = this.txtAddress.Text;
            (dataSource as Subject).Phone = this.txtPhone.Text;
            (dataSource as Subject).Fax = this.txtFax.Text;
            (dataSource as Subject).TaxCode = this.txtTaxCode.Text;
            (dataSource as Subject).BankName = this.txtBankName.Text;
            (dataSource as Subject).BankAccountNo = this.txtBankAccountNo.Text;
            (dataSource as Subject).Description = this.txtDescription.Text;
            (dataSource as Subject).SubjectTypeCode = SubjectType;

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
                this.txtDescription.Properties.ReadOnly = false;
                this.txtSubjectName.Focus();

            }
            else
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
            }
            base.RefreshControl();
            if (this.DataSource == null)
                ClearTextBox();
        }
        private void ClearTextBox()
        {
            this.txtSubjectCode.Text ="";
            this.txtSubjectName.Text ="";
            this.txtAddress.Text ="";
            this.txtPhone.Text = "";
            this.txtFax.Text ="";
            this.txtTaxCode.Text = "";
            this.txtBankName.Text ="";
            this.txtBankAccountNo.Text ="";
            this.txtDescription.Text = "";
        }
    }
}
