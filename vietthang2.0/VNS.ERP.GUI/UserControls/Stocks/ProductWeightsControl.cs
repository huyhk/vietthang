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
    public partial class ProductWeightsControl : VNS.Windows.Controls.EditControlBase
    {
        public ProductWeightsControl()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (dataSource != null)
            {
                this.txtweightcode.Text = (dataSource as ProductWeight).WeightCode;
                this.txtweight.Text = (dataSource as ProductWeight).Weight.ToString();
                this.txtdescription.Text = (dataSource as ProductWeight).Description;
            }
            base.BindData();
        }
        protected override int ValidateData()
        {
            if (txtweightcode.Text == String.Empty)
            {
                txtweightcode.Focus();
                return -1;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new ProductWeight();
            (dataSource as ProductWeight).WeightCode = txtweightcode.Text;
            (dataSource as ProductWeight).Weight = decimal.Parse(txtweight.Text);
            (dataSource as ProductWeight).Description = txtdescription.Text;
            base.AssignData();
        }
        public override bool Save()
        {
            return base.Save();
        }
        public override void RefreshControl()
        {
            this.txtweightcode.Properties.ReadOnly = this.editMode != FormEditMode.ADD;
            if (this.editMode != FormEditMode.ADD)
                this.txtweightcode.BackColor = lbldescription.BackColor;
            else
            {
                this.txtweightcode.Focus();
                this.txtweightcode.BackColor = Color.White;
            }
            if (editMode == FormEditMode.VIEW)

                RefreshUC(true, lbldescription.BackColor);
            else
                RefreshUC(false, Color.White);
            if (editMode == FormEditMode.EDIT) txtweight.Focus();
            base.RefreshControl();
        }
        private void RefreshUC(bool value, Color color)
        {
            txtdescription.Properties.ReadOnly = value;
            txtweight.Properties.ReadOnly = value;
            txtdescription.BackColor = color;
            txtweight.BackColor = color;
        }

   
    }
}
