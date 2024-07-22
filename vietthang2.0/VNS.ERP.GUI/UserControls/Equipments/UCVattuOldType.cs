using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data.Equipments;
using VNS.Windows;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Equipments
{
    public partial class UCVattuOldType : EditControlBase
    {
        public UCVattuOldType()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtTypeCode.Text = (dataSource as VattuOldType).TypeCode;
                this.txtTypeName.Text = (dataSource as VattuOldType).TypeName ;
                this.txtDienGiai.Text = (dataSource as VattuOldType).Description;

            }

        }
        protected override int ValidateData()
        {
            if (this.txtTypeCode.Text == string.Empty)
            {
                this.txtTypeCode.Focus();
                return -1;
            }
            if (this.txtTypeName.Text == string.Empty)
            {
                this.txtTypeName.Focus();
                return -2;
            }
            return 0;
        }
        protected override void AssignData()
        {

            if (dataSource == null)
                dataSource = new VattuOldType();
            (dataSource as VattuOldType).TypeName = this.txtTypeName.Text;
            (dataSource as VattuOldType).TypeCode  = this.txtTypeCode.Text;


            (dataSource as VattuOldType).Description = this.txtDienGiai.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {

                (dataSource as VattuOldType).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as VattuOldType).DateCreated = DateTime.Now;
            }
            (dataSource as VattuOldType).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as VattuOldType).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.editMode == FormEditMode.VIEW;
            this.txtTypeCode.Properties.ReadOnly = viewMode;
            this.txtTypeName.Properties.ReadOnly = viewMode;                 
            this.txtDienGiai.Properties.ReadOnly = viewMode;
            if(this.editMode==FormEditMode.EDIT)
                this.txtTypeCode.Properties.ReadOnly = !viewMode;
            base.RefreshControl();
        }

    }
}
