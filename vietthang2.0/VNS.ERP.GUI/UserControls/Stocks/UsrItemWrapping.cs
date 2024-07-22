using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.Windows.Controls;
using VNS.Windows;

namespace VNS.ERP.GUI.UserControl
{
    public partial class UsrItemWrapping : EditControlBase 
    {
        public UsrItemWrapping()
        {
            InitializeComponent();
           
        }
        protected override void BindData()
        {
            this.txtItemCode.Text = (dataSource as ItemWrapping).ItemCode;
            this.txtItemName.Text = (dataSource as ItemWrapping).ItemName;
            this.txtDescription.Text = (dataSource as ItemWrapping).Description;
            this.lookUpProduct.EditValue = (dataSource as ItemWrapping).ProductCode;
            this.lookUpWeightCode.EditValue = (dataSource as ItemWrapping).WeightCode;
            this.CheckOutByFormula.EditValue=(dataSource as ItemWrapping).OutByFormula;
            this.checkOutToStock.EditValue=    (dataSource as ItemWrapping).OutToStock ;
            this.txtUnit.EditValue = (dataSource as ItemWrapping).Unit;

            this.txtMasapxep.EditValue = (dataSource as ItemWrapping).Masapxep;
            this.chkInActive.Checked = (dataSource as ItemWrapping).InActive;
            base.BindData();
        }
        public void SetLookup()
        {
            this.lookUpProduct.Properties.DataSource = new ProductBLL().GetAll();
            this.lookUpWeightCode.Properties.DataSource = new ProductWeightBLL().GetAll();
          
        }
        protected override void AssignData()
        {
            (dataSource as ItemWrapping).ItemCode=this.txtItemCode.Text;
            (dataSource as ItemWrapping).ItemName= this.txtItemName.Text;
            (dataSource as ItemWrapping).Description=   this.txtDescription.Text ;
            (dataSource as ItemWrapping).ProductCode= (string ) this.lookUpProduct.EditValue ;
            (dataSource as ItemWrapping).WeightCode=(string)this.lookUpWeightCode.EditValue ;
            (dataSource as ItemWrapping).OutByFormula = (bool)CheckOutByFormula.EditValue;
            (dataSource as ItemWrapping).OutToStock = (bool)checkOutToStock.EditValue;
            (dataSource as ItemWrapping).Unit = this.txtUnit.Text;
            if (lookUpWeightCode.EditValue != null)
                (dataSource as ItemWrapping).UnitWeight =Convert.ToDecimal( lookUpWeightCode.GetColumnValue("Weight").ToString());

            (dataSource as ItemWrapping).Masapxep = this.txtMasapxep.Text;
            (dataSource as ItemWrapping).InActive = this.chkInActive.Checked;
            base.AssignData();
        }
        protected override int  ValidateData()
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
             if (this.lookUpWeightCode.Text == String.Empty)
             {
                 lookUpWeightCode.Focus();
                 return -4;
             }
 	        return 0;
        }
       
        public override void RefreshControl()
        {

            if (this.editMode == FormEditMode.ADD)
            {
                this.txtItemCode.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtItemName.Properties.ReadOnly = false;
                this.lookUpProduct.Properties.ReadOnly = false;
                this.lookUpWeightCode.Properties.ReadOnly = false;
                this.CheckOutByFormula.Properties.ReadOnly = false;
                this.checkOutToStock.Properties.ReadOnly = false;
                this.txtUnit.Properties.ReadOnly = false;
                txtMasapxep.Properties.ReadOnly = false;
                this.chkInActive.Properties.ReadOnly = false;
                this.txtItemCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtItemCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtItemName.Properties.ReadOnly = false;
                this.lookUpProduct.Properties.ReadOnly = false;
                this.lookUpWeightCode.Properties.ReadOnly = false;
                this.CheckOutByFormula.Properties.ReadOnly = false;
                this.checkOutToStock.Properties.ReadOnly = false;
                this.txtUnit.Properties.ReadOnly = false;
                txtMasapxep.Properties.ReadOnly = false;
                this.chkInActive.Properties.ReadOnly = false;
                this.txtItemName.Focus();

            }
            else
            {
                this.txtItemCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.txtItemName.Properties.ReadOnly = true;
                this.lookUpProduct.Properties.ReadOnly = true;
                this.lookUpWeightCode.Properties.ReadOnly = true;
                this.CheckOutByFormula.Properties.ReadOnly = true;
                this.checkOutToStock.Properties.ReadOnly = true;
                this.txtUnit.Properties.ReadOnly = true;
                txtMasapxep.Properties.ReadOnly = true;
                this.chkInActive.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }
     
        private void AddProducCode_Click(object sender, EventArgs e)
        {
            FormProducts frmProduct = new FormProducts();
            frmProduct.ShowDialog();
        }

        private void AddWeightCode_Click(object sender, EventArgs e)
        {
            FormProductWeights frmProductWeight = new FormProductWeights();
            frmProductWeight.ShowDialog();
        }
      
    }
}
