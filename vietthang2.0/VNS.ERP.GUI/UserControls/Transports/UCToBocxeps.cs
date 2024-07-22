using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;
using VNS.Common;
using System.Collections;

namespace VNS.ERP.GUI.Transports
{
    public partial class UCToBocxeps : EditControlBase
    {
        private string subjectCode;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        public UCToBocxeps()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                ToBocxep t = (DataSource as ToBocxep);
                this.txtToBocxepCode.Text = t.ToBocxepCode;
                this.txtToBocxepName.Text = t.ToBocxepName;
                //this.lookUpSubjectCode.EditValue = t.SubjectCode;
                this.memoDescription.Text = t.Description;
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new ToBocxep();
            ToBocxep t = this.DataSource as ToBocxep;
            t.ToBocxepCode = txtToBocxepCode.Text;
            t.ToBocxepName = txtToBocxepName.Text;
            t.SubjectCode = this.SubjectCode;
            //t.SubjectCode = lookUpSubjectCode.EditValue.ToString();
            t.Description = memoDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                t.UserCreated = Contexts.CurrentUser.LoginName;
            }
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            txtToBocxepCode.Text = txtToBocxepCode.Text.Trim();
            txtToBocxepName.Text = txtToBocxepName.Text.Trim();
            memoDescription.Text = memoDescription.Text.Trim();
            if (txtToBocxepCode.Text == string.Empty)
            {
                txtToBocxepCode.Focus();
                return -1;
            }
            if (txtToBocxepName.Text == string.Empty)
            {
                txtToBocxepName.Focus();
                return -2;
            }
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            txtToBocxepCode.Properties.ReadOnly = viewMode;
            txtToBocxepName.Properties.ReadOnly = viewMode;
            memoDescription.Properties.ReadOnly = viewMode;

            if (editMode == VNS.Windows.FormEditMode.EDIT)
            {
                txtToBocxepCode.Properties.ReadOnly = true;
            }
            if (this.DataSource == null)
            {
                txtToBocxepCode.Text = string.Empty;
                txtToBocxepName.Text = string.Empty;
                memoDescription.Text = string.Empty;
            }
            if (editMode == VNS.Windows.FormEditMode.ADD)
            {
                txtToBocxepCode.Focus();
            }

            base.RefreshControl();
        }
    }
}

