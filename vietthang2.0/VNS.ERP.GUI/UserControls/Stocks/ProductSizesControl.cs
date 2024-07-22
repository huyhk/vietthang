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
    public partial class ProductSizesControl : EditControlBase
    {
        public ProductSizesControl()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (dataSource != null)
            {
                this.txtsizecode.Text = (dataSource as ProductSize).SizeCode;
                this.txtdescription.Text = (dataSource as ProductSize).Description;
            }
            base.BindData();
        }
        protected override int ValidateData()
        {
            if (txtsizecode.Text == String.Empty) 
            {
                txtsizecode.Focus();
                return -1;
            }
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new ProductSize();
            (dataSource as ProductSize).SizeCode = txtsizecode.Text;
            (dataSource as ProductSize).Description = txtdescription.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            this.txtsizecode.Properties.ReadOnly = this.editMode != FormEditMode.ADD;
            if (this.editMode != FormEditMode.ADD)
                this.txtsizecode.BackColor = lblDescription.BackColor;
            else
            {
                this.txtsizecode.Focus();
                this.txtsizecode.BackColor = Color.White;
            }
            if (editMode == FormEditMode.VIEW)
            {
                txtdescription.Properties.ReadOnly = true;
                txtdescription.BackColor = lblDescription.BackColor;
            }
  
            else
            {
                txtdescription.Properties.ReadOnly = false;
                txtdescription.BackColor = Color.White;
            }
            if (editMode == FormEditMode.EDIT) txtdescription.Focus();
            base.RefreshControl();
        }
    }
}
