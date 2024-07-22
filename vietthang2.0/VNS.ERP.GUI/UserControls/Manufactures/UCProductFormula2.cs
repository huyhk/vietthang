using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCProductFormula2 : EditControlBase
    {
        private ListBase<ProductFormula2> lstProductFormula = null;
        private ListBase<ProductFormula2> lstProductFormulaFilter = null;
        private string productCode = string.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set 
            { 
                productCode = value;
                if (!this.DesignMode)
                {
                    lstProductFormulaFilter = new ProductFormulaBLL2().GetFormulaByProductCode(productCode);
                }
            }
        }
        public UCProductFormula2()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            base.BindData();
            if (this.DataSource != null)
            { 
                ProductFormula2 pf2 = this.DataSource as ProductFormula2;
                txtFormulaCode.Text = pf2.FormulaCode;
                txtDescription.Text = pf2.Description;
                chkIsActive.Checked = pf2.IsActive;
                gridControl2.DataSource = pf2.FormulaDetails;
            }
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                txtFormulaCode.AutoCompleteCustomSource.Clear();
                lstProductFormula = new ProductFormulaBLL2().GetAll();
                foreach (ProductFormula2 pf2 in lstProductFormula)
                {
                    txtFormulaCode.AutoCompleteCustomSource.Add(pf2.FormulaCode);
                }
                //ListBase<Item> lstDataSourceItem = new ItemBLL().GetByGroup2ItemType((Int16)enumItemType.Material, (Int16)enumItemType.Premix);
                ListBase<Item> lstDataSourceItem = new ItemBLL().GetAll();

                this.repositoryItemLookUpEdit4.DataSource = lstDataSourceItem;
                this.repositoryItemLookUpEdit5.DataSource = lstDataSourceItem;
            }
            base.InitDataObject();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            bool editMod = this.EditMode == VNS.Windows.FormEditMode.EDIT;
            bool addMod = this.EditMode == VNS.Windows.FormEditMode.ADD;
            if (addMod)
            {
                txtFormulaCode.Focus();
            }
            if (editMod)
            {
                txtDescription.Focus();
            }
            if (addMod || editMod)
            {
                gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            }
            else
            {
                gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }

            txtFormulaCode.ReadOnly = viewMode || editMod;
            txtDescription.Properties.ReadOnly = viewMode;
            chkIsActive.Enabled = !viewMode;
            gridView2.OptionsBehavior.Editable = !viewMode;
            if (this.DataSource == null)
            {
                txtFormulaCode.Text = "";
                txtDescription.Text = "";
                chkIsActive.Checked = false;
                gridControl2.DataSource = null;

            }
            base.RefreshControl();
        }
        protected override int ValidateData()
        {
            ProductFormula2 pf2 = this.DataSource as ProductFormula2;
            int count = pf2.FormulaDetails.Count;
            txtFormulaCode.Text = txtFormulaCode.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();
            if (txtFormulaCode.Text == string.Empty)
            {
                return -1;
            }
            if (count == 0) return -6;
            int countRowZeroWeight = 0;
            for (int i = 0; i <= count - 1; i++)
            {
                if (pf2.FormulaDetails[i].Weight == 0) countRowZeroWeight++;
                if (pf2.FormulaDetails[i].Weight < 0) return -2;
                if ((pf2.FormulaDetails[i].MaterialCode == null)) return -3;
            }
            if (countRowZeroWeight == count)
            {
                return -4;
            }
            foreach (FormulaDetail fd in pf2.FormulaDetails)
            {
                FormulaDetail fd1 = pf2.FormulaDetails.Search("MaterialCode", fd.MaterialCode);
                if (fd1 != null && fd1 != fd)
                {
                    if (fd1.Weight != 0 && fd.Weight != 0)
                    {
                        return -5;
                    }
                }
            }
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                ProductFormula2 pf2a = lstProductFormulaFilter.Search("FormulaCode", txtFormulaCode.Text);
                if (pf2a != null)
                {
                    return -7;
                }
            }
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new ProductFormula2();
            ProductFormula2 pf2 = this.DataSource as ProductFormula2;
            pf2.FormulaCode = txtFormulaCode.Text;
            pf2.ProductCode = this.ProductCode;
            foreach (FormulaDetail fd in pf2.FormulaDetails)
            {
                fd.FormulaCode = pf2.FormulaCode;
                fd.ProductCode = this.ProductCode;
            }
            pf2.Description = txtDescription.Text;
            pf2.IsActive = chkIsActive.Checked;
            
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                pf2.UserCreated = Contexts.CurrentUser.LoginName;
                pf2.DateCreated = DateTime.Now;

                ProductFormula2 pf2a = lstProductFormula.Search("FormulaCode", pf2.FormulaCode);
                pf2.IsNewFormulaCode = pf2a == null;
            }
            pf2.UserUpdated = Contexts.CurrentUser.LoginName;
            pf2.DateUpdated = DateTime.Now;
            base.AssignData();
        }

        private void txtFormulaCode_Validated(object sender, EventArgs e)
        {
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                ProductFormula2 pf2a = lstProductFormula.Search("FormulaCode", txtFormulaCode.Text);
                if (pf2a != null)
                {
                    txtDescription.Text = pf2a.Description;
                }
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView2.RowCount > 0 && this.gridView2.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView2.DeleteRow(this.gridView2.FocusedRowHandle);
            }
        }
    }
}
