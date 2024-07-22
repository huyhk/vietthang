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

namespace VNS.ERP.GUI.Equipments
{
    public partial class UCVattu : EditControlBase
    {
        public UCVattu()
        {
            InitializeComponent();
            this.SetTextCode(this.txtVattuCode);
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtVattuCode.Text = (dataSource as Vattu).VattuCode;
                this.txtVattuName.Text = (dataSource as Vattu).VattuName ;
                this.txtUnit.Text = (dataSource as Vattu).Unit;
                this.txtDienGiai.Text = (dataSource as Vattu).Description;

            }

        }
        protected override int ValidateData()
        {
            if (this.txtVattuCode.Text == string.Empty)
            {
                this.txtVattuCode.Focus();
                return -1;
            }
            if (this.txtVattuName.Text == string.Empty)
            {
                this.txtVattuName.Focus();
                return -2;
            }
            if (this.txtUnit.Text == string.Empty)
            {
                this.txtUnit.Focus();
                return -3;
            }
            return 0;
        }
        protected override void AssignData()
        {

            if (dataSource == null)
                dataSource = new Vattu();
            (dataSource as Vattu).VattuCode = this.txtVattuCode.Text;
            (dataSource as Vattu).VattuName = this.txtVattuName.Text;
            (dataSource as Vattu).Unit = this.txtUnit.Text;

            (dataSource as Vattu).Description = this.txtDienGiai.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                (dataSource as Vattu).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as Vattu).DateCreated = DateTime.Now;
            }
            (dataSource as Vattu).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as Vattu).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.editMode == FormEditMode.VIEW;
            this.txtVattuCode.Properties.ReadOnly = viewMode;
            this.txtVattuName.Properties.ReadOnly = viewMode;

            this.txtUnit.Properties.ReadOnly = viewMode;
            this.txtDienGiai.Properties.ReadOnly = viewMode;
            if (this.editMode == FormEditMode.EDIT)
            {
                this.txtVattuCode.Properties.ReadOnly = true;
            }
      
            base.RefreshControl();
        }

    }
}
