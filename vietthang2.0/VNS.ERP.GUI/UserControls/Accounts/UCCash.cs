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
    public partial class UCCash : EditControlBase
    {
        private ListBase<Branch> lstBranchs=null;
        public UCCash()
        {
            InitializeComponent();
           
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                lstBranchs = new BranchBLL().GetAll();
                lstBranchs.Add(new Branch());
                this.cboBranchCode.Properties.DataSource = lstBranchs;
            }
            base.InitDataObject();
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtSubjectCode.Text = (dataSource as Cash).SubjectCode;
                this.txtSubjectName.Text = (dataSource as Cash).SubjectName;
                this.txtAddress.Text = (dataSource as Cash).Address;
                this.txtPhone.Text = (dataSource as Cash).Phone;
                this.txtFax.Text = (dataSource as Cash).Fax;
                this.txtTaxCode.Text = (dataSource as Cash).TaxCode;
                this.txtBankName.Text = (dataSource as Cash).BankName;
                this.txtBankAccountNo.Text = (dataSource as Cash).BankAccountNo;
                this.txtDescription.Text = (dataSource as Cash).Description;
                this.txtSoHieu.Text = (dataSource as Cash).SoHieu;
                this.cboBranchCode.EditValue = (dataSource as Cash).BranchCode;
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
            if (dataSource == null) dataSource = new Cash();
            (dataSource as Cash).SubjectCode = this.txtSubjectCode.Text;
            (dataSource as Cash).SubjectName = this.txtSubjectName.Text;
            (dataSource as Cash).Address = this.txtAddress.Text;
            (dataSource as Cash).Phone = this.txtPhone.Text;
            (dataSource as Cash).Fax = this.txtFax.Text;
            (dataSource as Cash).TaxCode = this.txtTaxCode.Text;
            (dataSource as Cash).BankName = this.txtBankName.Text;
            (dataSource as Cash).BankAccountNo = this.txtBankAccountNo.Text;
            (dataSource as Cash).Description = this.txtDescription.Text;
            (dataSource as Cash).SoHieu = this.txtSoHieu.Text;
            (dataSource as Cash).BranchCode = this.cboBranchCode.EditValue.ToString();

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
                this.txtSoHieu.Properties.ReadOnly = false;
                this.cboBranchCode.Properties.ReadOnly = false;
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
                this.txtSoHieu.Properties.ReadOnly = false;
                this.cboBranchCode.Properties.ReadOnly = false;
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
                this.txtDescription.Properties.ReadOnly = true;
                this.txtSoHieu.Properties.ReadOnly = true;
                this.cboBranchCode.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }

    }
}
