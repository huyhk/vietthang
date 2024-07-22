using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.Windows;

namespace VNS.ERP.GUI.Transports
{
    public partial class UCTransportFeeType : VNS.Windows.Controls.EditControlBase
    {
        public UCTransportFeeType()
        {
            InitializeComponent();
            this.SetTextCode(this.txtCode);
            this.FirstControl = this.txtCode;
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtCode.Text = (dataSource as TransportFeeType).TypeCode;
                this.txtName.Text = (dataSource as TransportFeeType).TypeName;
                this.txtDescription.Text = (dataSource as TransportFeeType).Description;
            }

            base.BindData();
        }
        protected override int ValidateData()
        {
            if (this.txtCode.Text == string.Empty)
            {
                this.txtCode.Focus();
                return -1;
            }
            if (this.txtName.Text == string.Empty)
            {
                this.txtName.Focus();
                return -2;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new TransportFeeType();
            (dataSource as TransportFeeType).TypeCode = this.txtCode.Text;
            (dataSource as TransportFeeType).TypeName = this.txtName.Text;
            (dataSource as TransportFeeType).Description = this.txtDescription.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {

            this.txtCode.Properties.ReadOnly = this.editMode != FormEditMode.ADD;
            this.txtName.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            this.txtDescription.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            base.RefreshControl();
        }
    }
}

