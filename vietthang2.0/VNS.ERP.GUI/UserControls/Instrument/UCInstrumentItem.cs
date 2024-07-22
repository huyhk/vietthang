using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;

namespace VNS.ERP.GUI.UserControl
{
    public partial class UCInstrumentItem : EditControlBase
    {
        public UCInstrumentItem()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                InstrumentItem ii = this.DataSource as InstrumentItem;
                txtItemCode.Text = ii.ItemCode;
                txtItemName.Text = ii.ItemName;
                txtUnit.Text = ii.Unit;
                txtDescription.Text = ii.Description;
            }
            base.BindData();
        }
        protected override int ValidateData()
        {
            txtItemCode.Text = txtItemCode.Text.Trim();
            txtItemName.Text = txtItemName.Text.Trim();
            txtUnit.Text = txtUnit.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();
            if (txtItemCode.Text == "")
            {
                txtItemCode.Focus();
                return -1;
            }
            if (txtItemName.Text == "")
            {
                txtItemName.Focus();
                return -2;
            }
            if (txtUnit.Text == "")
            {
                txtUnit.Focus();
                return -3;
            }
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new InstrumentItem();
            InstrumentItem ii = this.DataSource as InstrumentItem;
            ii.ItemCode = txtItemCode.Text;
            ii.ItemName = txtItemName.Text;
            ii.Unit = txtUnit.Text;
            ii.Description = txtDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                ii.UserCreated = Contexts.CurrentUser.LoginName;
                ii.DateCreated = DateTime.Now;
            }
            ii.UserUpdated = Contexts.CurrentUser.LoginName;
            ii.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            bool editMod = this.EditMode == VNS.Windows.FormEditMode.EDIT;
            txtItemCode.Properties.ReadOnly = viewMode || editMod;
            txtItemName.Properties.ReadOnly = viewMode;
            txtUnit.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            if (this.DataSource == null)
            {
                txtItemCode.Text = "";
                txtItemName.Text = "";
                txtUnit.Text = "";
                txtDescription.Text = "";
            }
            base.RefreshControl();
        }
    }
}
