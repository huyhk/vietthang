using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data ;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI.UserControl
{
    public partial class UsrItem : EditControlBase 
    {
        public UsrItem()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            base.BindData();
            this.CheckOutByFormula.EditValue = (dataSource as Item).OutByFormula;
            this.checkOutToStock.EditValue = (dataSource as Item).OutToStock;
            this.txtItemCode .Text = (dataSource as Item ).ItemCode ;
            this.txtItemName.Text = (dataSource as Item).ItemName;
            this.txtUnit.Text = (dataSource as Item).Unit;
            this.txtUnitWeight.EditValue = (dataSource as Item).UnitWeight;
            this.txtDescription.Text = (dataSource as Item).Description;
            this.lookUpItemGroup.EditValue = (dataSource as Item).ItemGroup;
            this.txtMasapxep.EditValue = (dataSource as Item).Masapxep;
            this.chkInActive.Checked = (dataSource as Item).InActive;

            this.txtCode2.Text = (dataSource as Item).Code2;
        }
        protected override void AssignData()
        {
            (dataSource as Item).OutByFormula  = (bool ) CheckOutByFormula.EditValue;
            (dataSource as Item).OutToStock = (bool)checkOutToStock.EditValue;
            (dataSource as Item).ItemType = FormItems.Enumtype;
            (dataSource as Item).ItemCode=  this.txtItemCode.Text;
            (dataSource as Item).ItemName=this.txtItemName.Text;
            (dataSource as Item).Unit = this.txtUnit.Text;
            (dataSource as Item).UnitWeight = Convert.ToDecimal( this.txtUnitWeight.EditValue.ToString());
            (dataSource as Item).Description=this.txtDescription.Text ;
            (dataSource as Item).ItemGroup = this.lookUpItemGroup.EditValue.ToString();
            (dataSource as Item).Masapxep = this.txtMasapxep.Text;
            (dataSource as Item).InActive = this.chkInActive.Checked;
            (dataSource as Item).Code2 = this.txtCode2.Text;
            base.AssignData();
        }
        protected override int ValidateData()
        {
            if (this.txtItemCode.Text == String.Empty)
            {
                this.txtItemCode.Focus();
                return -1;
            }
            return 0;
        }

        public override void RefreshControl()
        {
            txtItemCode.Properties.ReadOnly = editMode != FormEditMode.ADD;
            if (editMode != FormEditMode.ADD)
            {
                txtItemCode.BackColor = lbDescription.BackColor;
                txtUnit.Focus();
            }
            else
            {
                txtItemCode.BackColor = Color.White;
                txtItemCode.Focus();
            }
            if (editMode == FormEditMode.VIEW)
            
                RefreshUC(true,lbDescription.BackColor);
            else
                RefreshUC(false, Color.White);
            if (this.editMode == FormEditMode.EDIT) txtUnit.Focus();
            base.RefreshControl();
        }
        private void RefreshUC(bool value, Color color)
        {
            txtDescription.Properties.ReadOnly = value;
            txtItemName.Properties.ReadOnly = value;
            txtUnit.Properties.ReadOnly = value;
            txtUnitWeight.Properties.ReadOnly = value;
            CheckOutByFormula.Properties.ReadOnly = value;
            checkOutToStock.Properties.ReadOnly = value;
            lookUpItemGroup.Properties.ReadOnly = value;
            txtMasapxep.Properties.ReadOnly = value;
            this.chkInActive.Properties.ReadOnly = value;
            this.txtCode2.Properties.ReadOnly = value;
            
            txtDescription.BackColor = color;
            txtItemName.BackColor = color;
            txtUnit.BackColor = color;
            txtUnitWeight.BackColor = color;
            lookUpItemGroup.BackColor = color;
            
        }
        public void SetOutByFormular(bool value)
        {
            this.CheckOutByFormula.Visible = value;
        }

        public void SetOutToStock(bool value)
        {
            this.checkOutToStock.Visible = value;
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();
            ListBase<ItemGroup> lst = new ItemGroupBLL().GetAll();
            ItemGroup group = new ItemGroup();
            group.GroupCode = "";
            group.GroupName = "";
            lst.Insert(0, group);
            this.lookUpItemGroup.Properties.DataSource = lst;
            this.lookUpItemGroup.ItemIndex = 0;
        }
        
    }
}
