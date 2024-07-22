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
    public partial class UCPremixWrappings :EditControlBase
    {
        public UCPremixWrappings()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            this.txtItemCode.Text = (this.dataSource as PremixWrapping).ItemCode;
            this.txtItemName.Text = (this.dataSource as PremixWrapping).ItemName;
            this.lookUpPremixCode.EditValue = (this.dataSource as PremixWrapping).PremixCode;
            this.txtDescription.Text = (this.dataSource as PremixWrapping).Description;
            this.CheckOutByFormula.EditValue = (this.dataSource as PremixWrapping).OutByFormula;
            this.checkOutToStock.EditValue = (this.dataSource as PremixWrapping).OutToStock;
            this.txtUnit.EditValue = (this.dataSource as PremixWrapping).Unit;
            this.txtMasapxep.EditValue = (dataSource as PremixWrapping).Masapxep;
            SetLookupPremix();
            base.BindData();
        }
        protected override void AssignData()
        {
            (this.dataSource as PremixWrapping).ItemCode = this.txtItemCode.Text;
            (this.dataSource as PremixWrapping).ItemName = this.txtItemName.Text;
            (this.dataSource as PremixWrapping).PremixCode = this.lookUpPremixCode.EditValue.ToString();
            (this.dataSource as PremixWrapping).Description = this.txtDescription.Text;
            (this.dataSource as PremixWrapping).OutByFormula = (bool)this.CheckOutByFormula.EditValue;
            (this.dataSource as PremixWrapping).OutToStock = (bool)this.checkOutToStock.EditValue;
            (this.dataSource as PremixWrapping).Unit = this.txtUnit.Text;
            (dataSource as PremixWrapping).Masapxep = this.txtMasapxep.Text;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            if (txtItemCode.Text == String.Empty)
            {

                this.txtItemCode.Focus();
                return -1;
            }
            if (this.lookUpPremixCode.EditValue == null) return -2;
            return 0;
        }
        public void SetLookupPremix()
        {
            if (this.editMode == FormEditMode.EDIT || this.editMode == FormEditMode.VIEW)
            {
                if (lookUpPremixCode.EditValue!=null)
                this.lookUpPremixCode.Properties.DataSource = new ItemBLL().GetPremixCodeExcept2(lookUpPremixCode.EditValue.ToString());
            }
            else
                this.lookUpPremixCode.Properties.DataSource = new ItemBLL().GetPremixCodeExcept2();
        }
        public override void RefreshControl()
        {

            if (this.editMode == FormEditMode.ADD)
            {
                this.txtItemCode.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtItemName.Properties.ReadOnly = false;
                this.lookUpPremixCode.Properties.ReadOnly = false;
                this.CheckOutByFormula.Properties.ReadOnly = false;
                this.checkOutToStock.Properties.ReadOnly = false;
                this.txtUnit.Properties.ReadOnly = false;
                txtMasapxep.Properties.ReadOnly = false;
                this.txtItemCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtItemCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtItemName.Properties.ReadOnly = false;
                this.lookUpPremixCode.Properties.ReadOnly = false;
                this.CheckOutByFormula.Properties.ReadOnly = false;
                this.checkOutToStock.Properties.ReadOnly = false;
                this.txtUnit.Properties.ReadOnly = false;
                txtMasapxep.Properties.ReadOnly = false;
                this.txtItemName.Focus();
            }
            else
            {
                this.txtItemCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.txtItemName.Properties.ReadOnly = true;
                this.lookUpPremixCode.Properties.ReadOnly = true;
                this.CheckOutByFormula.Properties.ReadOnly = true;
                this.checkOutToStock.Properties.ReadOnly = true;
                this.txtUnit.Properties.ReadOnly = true;
                txtMasapxep.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }
     
    }
}
