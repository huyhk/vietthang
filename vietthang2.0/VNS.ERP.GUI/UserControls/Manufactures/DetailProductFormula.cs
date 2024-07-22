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

namespace VNS.ERP.GUI.UserControl
{
    public partial class DetailProductFormula : EditControlBase
    {
        public DetailProductFormula()
        {
            InitializeComponent();
        }
        #region Method
        
        public override void RefreshControl()
        {
            txtFormulaCode.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW) || (this.editMode == FormEditMode.EDIT);
            txtDescription.Properties.ReadOnly = (this.editMode == FormEditMode.VIEW);
            if (this.editMode == FormEditMode.ADD)
            {
               txtFormulaCode.Focus();
               txtFormulaCode.BackColor = txtBackGround.BackColor;
               txtDescription.BackColor = txtBackGround.BackColor;
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                txtDescription.Focus();
                txtFormulaCode.BackColor = lbFormulaCode.BackColor;
                txtDescription.BackColor = txtBackGround.BackColor;
            }
            if (this.editMode == FormEditMode.VIEW)
            {
                txtFormulaCode.BackColor = lbFormulaCode.BackColor;
                txtDescription.BackColor = lbFormulaCode.BackColor;
            }
            if (DataSource == null)
            {
                this.txtFormulaCode.Text = "";
                this.txtDescription.Text = "";
            }
            base.RefreshControl();
        }
        protected override void BindData()
        {
            if (dataSource != null)
            {
                this.txtFormulaCode.Text = (dataSource as ProductFormula).FormulaCode;
                this.txtDescription.Text = (dataSource as ProductFormula).Description;
            }
            base.BindData();
        }
      
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new ProductFormula();
            (dataSource as ProductFormula).FormulaCode = this.txtFormulaCode.Text;
            (dataSource as ProductFormula).Description = this.txtDescription.Text;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (dataSource as ProductFormula).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as ProductFormula).DateCreated = DateTime.Now;
            }
            (dataSource as ProductFormula).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as ProductFormula).DateUpdated = DateTime.Now;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            this.txtFormulaCode.Text = this.txtFormulaCode.Text.Trim();
            this.txtDescription.Text = this.txtDescription.Text.Trim();
            if (this.txtFormulaCode.Text == "")
            {
                this.txtFormulaCode.Focus();
                return -1;
            }
            return base.ValidateData();
        }
        #endregion
    }
}
