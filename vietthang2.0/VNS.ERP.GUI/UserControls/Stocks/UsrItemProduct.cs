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
using VNS.Common;

namespace VNS.ERP.GUI.UserControl
{
    public partial class UsrItemProduct : EditControlBase
    {
        public UsrItemProduct()
        {
            InitializeComponent();

        }
        protected override void BindData()
        {
            this.txtItemCode.Text = (this.dataSource as ItemProduct).ItemCode;
            this.txtItemName.Text = (this.dataSource as ItemProduct).ItemName;
            this.txtDescription.Text = (this.dataSource as ItemProduct).Description;
            this.lookUpProduct.EditValue = (this.dataSource as ItemProduct).ProductCode;
            this.LookupSizeCode.EditValue = (this.dataSource as ItemProduct).SizeCode;
            this.lookUpWeightCode.EditValue = (this.dataSource as ItemProduct).WeightCode;
            CheckOutByFormula.EditValue = (dataSource as ItemProduct).OutByFormula;
            checkOutToStock.EditValue = (dataSource as ItemProduct).OutToStock;
            this.txtUnit.EditValue = (dataSource as ItemProduct).Unit;
            this.lookUpItemWrapping.EditValue = (dataSource as ItemProduct).WrappingCode;

            this.txtMasapxep.EditValue = (dataSource as ItemProduct).Masapxep;
            this.chkInActive.Checked = (dataSource as ItemProduct).InActive;
            this.txtCode2.Text = (dataSource as ItemProduct).Code2;

            base.BindData();
        }
        protected override void AssignData()
        {
            (this.dataSource as ItemProduct).ItemCode = this.txtItemCode.Text;
            (this.dataSource as ItemProduct).ItemName = this.txtItemName.Text;
            (this.dataSource as ItemProduct).Description = this.txtDescription.Text;
            (this.dataSource as ItemProduct).ProductCode = this.lookUpProduct.Text;
            (this.dataSource as ItemProduct).SizeCode = this.LookupSizeCode.Text;
            (this.dataSource as ItemProduct).WeightCode = this.lookUpWeightCode.Text;
            (dataSource as ItemProduct).OutByFormula = (bool)CheckOutByFormula.EditValue;
            (dataSource as ItemProduct).OutToStock = (bool)checkOutToStock.EditValue;
            (dataSource as ItemProduct).Unit = this.txtUnit.Text;
            (dataSource as ItemProduct).WrappingCode = this.lookUpItemWrapping.EditValue.ToString();
            if (lookUpWeightCode.EditValue != null)
                (this.dataSource as ItemProduct).UnitWeight = Convert.ToDecimal(lookUpWeightCode.GetColumnValue("Weight").ToString());

            (dataSource as ItemProduct).Masapxep = this.txtMasapxep.Text;
            (dataSource as ItemProduct).InActive = this.chkInActive.Checked;
            (dataSource as ItemProduct).Code2 = this.txtCode2.Text;

            base.AssignData();
        }
        protected override int ValidateData()
        {
            if (this.txtItemCode.Text == String.Empty)
            {
                txtItemCode.Focus();
                return -1;
            }
            if (this.txtItemName.Text == String.Empty)
            {
                txtItemName.Focus();
                return -2;
            }
            if (this.lookUpProduct.Text == String.Empty)
            {
                lookUpProduct.Focus();
                return -3;
            }
            if (this.LookupSizeCode.Text == String.Empty)
            {
                LookupSizeCode.Focus();
                return -4;
            }
            if (this.lookUpWeightCode.Text == String.Empty)
            {
                lookUpWeightCode.Focus();
                return -5;
            }
            if (this.lookUpItemWrapping.Text == String.Empty)
            {
                lookUpItemWrapping.Focus();
                return -6;
            }
            return 0;
        }
        public override void RefreshControl()
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                this.txtItemCode.Properties.ReadOnly = false;
                this.txtItemCode.Focus();
                this.txtDescription.Properties.ReadOnly = false;
                this.txtItemName.Properties.ReadOnly = false;
                this.lookUpProduct.Properties.ReadOnly = false;
                this.LookupSizeCode.Properties.ReadOnly = false;
                this.lookUpWeightCode.Properties.ReadOnly = false;
                this.CheckOutByFormula.Properties.ReadOnly = false;
                this.checkOutToStock.Properties.ReadOnly = false;
                this.txtUnit.Properties.ReadOnly = false;
                this.lookUpItemWrapping.Properties.ReadOnly = false;
                txtMasapxep.Properties.ReadOnly = false;
                this.chkInActive.Properties.ReadOnly = false;
                this.txtCode2.Properties.ReadOnly = false;
            }
            else if (this.EditMode == FormEditMode.EDIT)
            {

                this.txtItemCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtItemName.Properties.ReadOnly = false;
                this.lookUpProduct.Properties.ReadOnly = false;
                this.LookupSizeCode.Properties.ReadOnly = false;
                this.lookUpWeightCode.Properties.ReadOnly = false;
                this.CheckOutByFormula.Properties.ReadOnly = false;
                this.checkOutToStock.Properties.ReadOnly = false;
                this.txtUnit.Properties.ReadOnly = false;
                this.lookUpItemWrapping.Properties.ReadOnly = false;
                txtMasapxep.Properties.ReadOnly = false;
                this.chkInActive.Properties.ReadOnly = false;
                this.txtCode2.Properties.ReadOnly = false;
                this.txtItemName.Focus();
            }
            else
            {
                this.txtItemCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.txtItemName.Properties.ReadOnly = true;
                this.lookUpProduct.Properties.ReadOnly = true;
                this.LookupSizeCode.Properties.ReadOnly = true;
                this.lookUpWeightCode.Properties.ReadOnly = true;
                this.CheckOutByFormula.Properties.ReadOnly = true;
                this.checkOutToStock.Properties.ReadOnly = true;
                this.txtUnit.Properties.ReadOnly = true;
                this.lookUpItemWrapping.Properties.ReadOnly = true;
                txtMasapxep.Properties.ReadOnly = true;
                this.chkInActive.Properties.ReadOnly = true;
                this.txtCode2.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }
        public void setLooKup()
        {
            lookUpProduct.Properties.DataSource = new ProductBLL().GetAll();
            LookupSizeCode.Properties.DataSource = new ProductSizeBLL().GetAll();
            lookUpWeightCode.Properties.DataSource = new ProductWeightBLL().GetAll();
            lookUpItemWrapping.Properties.DataSource = new ItemWrappingBLL().GetAll();
        }

        private void AddProducCode_Click(object sender, EventArgs e)
        {
            FormProducts frmProduct = new FormProducts();
            frmProduct.ShowDialog();
        }

        private void AddSizeCode_Click(object sender, EventArgs e)
        {
            FormProductSizes frmProductSize = new FormProductSizes();
            frmProductSize.ShowDialog();
        }

        private void AddWeightCode_Click(object sender, EventArgs e)
        {
            FormProductWeights frmProductWeight = new FormProductWeights();
            frmProductWeight.ShowDialog();
        }

        
    }
}
