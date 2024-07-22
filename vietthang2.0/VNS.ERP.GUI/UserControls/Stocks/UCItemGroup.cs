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

namespace VNS.ERP.GUI
{
    public partial class UCItemGroup : VNS.Windows.Controls.EditControlBase
    {
        public UCItemGroup()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            ItemGroup obj = (DataSource as ItemGroup);
            if (DataSource != null)
            {
                this.txtGroupCode.Text = obj.GroupCode.ToString();
                this.txtGroupName.Text = obj.GroupName.ToString();
                this.txtDescription.Text = obj.Description.ToString();
                this.txtMasapxep.EditValue = obj.Masapxep;
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new ItemGroup();
            ItemGroup obj = (DataSource as ItemGroup);
            obj.GroupCode = this.txtGroupCode.Text.ToString();
            obj.GroupName = this.txtGroupName.Text.ToString();
            obj.Description = this.txtDescription.Text.ToString();
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                obj.UserCreated = Contexts.CurrentUser.LoginName;
            }
            obj.UserUpdated = Contexts.CurrentUser.LoginName;
            obj.Masapxep = this.txtMasapxep.Text;
            base.AssignData();
        }
        protected override int ValidateData()
        {

            if (this.txtGroupCode.Text.ToString() == "")
            {
                txtGroupCode.Focus();
                return -1;
            }
            if (this.txtGroupName.Text.ToString() == "")
            {
                txtGroupName.Focus();
                return -2;
            }
            return base.ValidateData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            txtGroupCode.Properties.ReadOnly = viewMode;
            txtGroupName.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            txtMasapxep.Properties.ReadOnly = viewMode;
            if (this.EditMode == VNS.Windows.FormEditMode.EDIT)
                txtGroupCode.Properties.ReadOnly = true;
            base.RefreshControl();
        }
    }
}

