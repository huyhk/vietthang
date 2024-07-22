using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows;

namespace VNS.ERP.GUI.UserControl
{
    public partial class ProductsControl : VNS.Windows.Controls.EditControlBase
    {
        public ProductsControl()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (dataSource != null)
            {
                this.txtProcode.Text = (dataSource as Product).ProductCode;
                this.txtProName.Text = (dataSource as Product).ProductName;
                this.txtDescription.Text = (dataSource as Product).Description;
                this.cboProductType.Text = (dataSource as Product).ProductType;
            }
            base.BindData();
        }
        protected override int ValidateData()
        {
            if (txtProcode.Text == String.Empty)
            {
                txtProcode.Focus();
                return -1;
            }
            if (txtProName.Text == String.Empty)
            {
                txtProName.Focus();
                return -2;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Product();
            (dataSource as Product).ProductCode = txtProcode.Text;
            (dataSource as Product).ProductName = txtProName.Text;
            (dataSource as Product).Description = txtDescription.Text;
            (dataSource as Product).ProductType = this.cboProductType.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            this.txtProcode.Properties.ReadOnly = this.editMode != FormEditMode.ADD;
            if (this.editMode != FormEditMode.ADD)
                this.txtProcode.BackColor =lblDescription.BackColor;
            else
            {
                this.txtProcode.Focus();
                this.txtProcode.BackColor = Color.White;
            }
            if (editMode == FormEditMode.EDIT)txtProName.Focus();
            if (editMode == FormEditMode.VIEW)
                RefreshUC(true, lblDescription.BackColor);
           
            else
                RefreshUC(false, Color.White);
            base.RefreshControl();
        }
        private void RefreshUC(bool value, Color color)
        {
            txtDescription.Properties.ReadOnly = value;
            txtProName.Properties.ReadOnly = value;
            txtDescription.BackColor = color;
            txtProName.BackColor = color;

            this.cboProductType.Enabled = !value;
        }
    }
}
