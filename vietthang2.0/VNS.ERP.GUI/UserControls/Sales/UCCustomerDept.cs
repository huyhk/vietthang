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

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCCustomerDept : EditControlBase
    {
        public string SubjectCode = "";
        public UCCustomerDept()
        {
            InitializeComponent();
            //chkNotCash
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                CustomerDept cdept = (DataSource as CustomerDept);
                this.dateEditStart.EditValue = cdept.StartDate;
                this.chkNotCash.Checked = !cdept.Cash;
                this.chkAmountLimit.Checked = cdept.AmountLimit;
                this.txtAmount.Text = cdept.Amount.ToString();
                this.chkDateLimit.Checked = cdept.DateLimit;
                this.txtDays.Text = cdept.Days.ToString();
                this.txtDescription.Text = cdept.Description;
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            if (DataSource == null) DataSource = new CustomerDept();
            CustomerDept cdept = (DataSource as CustomerDept);

            if (this.EditMode == FormEditMode.ADD)
            {
                cdept.UserCreated = Contexts.CurrentUser.LoginName;
                cdept.DateCreated = DateTime.Now;
            }
            cdept.UserUpdated = Contexts.CurrentUser.LoginName;
            cdept.DateUpdated = DateTime.Now;
            cdept.SubjectCode = SubjectCode;
            cdept.StartDate = dateEditStart.DateTime;
            cdept.Cash = !chkNotCash.Checked;
            cdept.AmountLimit = chkAmountLimit.Checked;
            cdept.Amount = Convert.ToDecimal(txtAmount.EditValue);
            cdept.DateLimit = chkDateLimit.Checked;
            cdept.Days = Convert.ToInt16(txtDays.EditValue);
            cdept.Description = txtDescription.Text;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            if (Convert.ToDecimal(this.txtAmount.EditValue) <= 0 && chkAmountLimit.Checked)
            {
                txtAmount.Focus();
                return -1;
            }
            if (Convert.ToInt16(this.txtDays.EditValue) <= 0 && chkDateLimit.Checked)
            {
                txtDays.Focus();
                return -2;
            }
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            dateEditStart.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            chkNotCash.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            chkCash.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            chkAmountLimit.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtAmount.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            chkDateLimit.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtDays.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtDescription.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            if (this.EditMode == FormEditMode.VIEW)
            {
                dateEditStart.BackColor = lbStartDate.BackColor;
                txtAmount.BackColor = lbStartDate.BackColor;
                txtDays.BackColor = lbStartDate.BackColor;
                txtDescription.BackColor = lbStartDate.BackColor;
            }
            if (this.EditMode == FormEditMode.ADD)
            {
                dateEditStart.Focus();
                dateEditStart.BackColor = txtBackGround.BackColor;
                txtAmount.BackColor = txtBackGround.BackColor;
                txtDays.BackColor = txtBackGround.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
            }
            if (this.EditMode == FormEditMode.EDIT)
            {
                if (chkAmountLimit.Checked)
                {
                    txtAmount.Focus();
                }
                else
                {
                    if (chkDateLimit.Checked)
                    {
                        txtDays.Focus();
                    }
                }
                dateEditStart.BackColor = lbStartDate.BackColor;
                txtAmount.BackColor = txtBackGround.BackColor;
                txtDays.BackColor = txtBackGround.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
            }
            if (this.DataSource == null)
            {
                chkNotCash.Checked = false;
                txtAmount.Text = "";
                txtDays.Text = "";
            }
            base.RefreshControl();
        }

        private void chkNotCash_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotCash.Checked)
            {
                chkAmountLimit.Enabled = true;
                chkDateLimit.Enabled = true;
                chkCash.Checked = false;
            }
            else
            {
                chkCash.Checked = true;
                chkAmountLimit.Enabled = false;
                chkAmountLimit.Checked = false;
                chkDateLimit.Enabled = false;
                chkDateLimit.Checked = false;
            }
        }

        private void chkAmountLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmountLimit.Checked)
            {
                txtAmount.Enabled = true;
                txtAmount.Focus();
            }
            else
            {
                txtAmount.Text = "";
                txtAmount.Enabled = false;
            }
        }

        private void chkDateLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateLimit.Checked)
            {
                txtDays.Enabled = true;
                txtDays.Focus();
            }
            else
            {
                txtDays.Text = "";
                txtDays.Enabled = false;
            }
        }

        private void chkTienMat_CheckedChanged(object sender, EventArgs e)
        {
            chkNotCash.Checked = !chkCash.Checked;
        }
    }
}
