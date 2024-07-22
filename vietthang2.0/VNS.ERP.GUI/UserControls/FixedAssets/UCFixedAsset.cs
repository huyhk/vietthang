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
    public partial class UCFixedAsset : EditControlBase
    {

        public UCFixedAsset()
        {
            InitializeComponent();
           
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtSubjectCode.Text = (dataSource as FixedAsset).SubjectCode;
                this.txtSubjectName.Text = (dataSource as FixedAsset).SubjectName;
                this.txtAddress.Text = (dataSource as FixedAsset).Address;
                this.txtPhone.Text = (dataSource as FixedAsset).Phone;
                this.txtFax.Text = (dataSource as FixedAsset).Fax;
                this.txtTaxCode.Text = (dataSource as FixedAsset).TaxCode;
                this.txtBankName.Text = (dataSource as FixedAsset).BankName;
                this.txtBankAccountNo.Text = (dataSource as FixedAsset).BankAccountNo;
                this.txtDescription.Text = (dataSource as FixedAsset).Description;
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
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new FixedAsset();
            (dataSource as FixedAsset).SubjectCode = this.txtSubjectCode.Text;
            (dataSource as FixedAsset).SubjectName = this.txtSubjectName.Text;
            (dataSource as FixedAsset).Address = this.txtAddress.Text;
            (dataSource as FixedAsset).Phone = this.txtPhone.Text;
            (dataSource as FixedAsset).Fax = this.txtFax.Text;
            (dataSource as FixedAsset).TaxCode = this.txtTaxCode.Text;
            (dataSource as FixedAsset).BankName = this.txtBankName.Text;
            (dataSource as FixedAsset).BankAccountNo = this.txtBankAccountNo.Text;
            (dataSource as FixedAsset).Description = this.txtDescription.Text;

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
                this.txtDescription.ReadOnly = false;

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
            }
            base.RefreshControl();
        }

    }
}
