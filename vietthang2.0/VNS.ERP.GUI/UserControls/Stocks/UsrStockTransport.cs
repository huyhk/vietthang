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
    public partial class UsrStockTransport :EditControlBase 
    {
        public UsrStockTransport()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (dataSource != null)
            {
                this.txtStockTransportCode.Text = (dataSource as StockTransport).StockTransportCode;
                this.txtStockTransportName.Text = (dataSource as StockTransport).StockTransportName;
                this.txtWeight.EditValue = (dataSource as StockTransport).Weight;
                this.txtDescription.Text = (dataSource as StockTransport).Description;
            }
            base.BindData();
        }
        protected override void AssignData()
        {
            (dataSource as StockTransport).StockCode = FormStockTransport.StockCode;
            (dataSource as StockTransport).StockTransportCode= this.txtStockTransportCode.Text ;
            (dataSource as StockTransport).StockTransportName=this.txtStockTransportName.Text ;
            (dataSource as StockTransport).Weight= Convert.ToDecimal (this.txtWeight.EditValue.ToString());
            (dataSource as StockTransport).Description=  this.txtDescription.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            txtStockTransportCode.Properties.ReadOnly = this.editMode != FormEditMode.ADD ;
            if (this.editMode != FormEditMode.ADD)
                txtStockTransportCode.BackColor = lbDescription.BackColor;
            else
            {
                txtStockTransportCode.BackColor = Color.White;
                txtStockTransportCode.Focus();
            }
         
            if (editMode == FormEditMode.VIEW)

                RefreshUC(true, lbDescription.BackColor);
            else
                RefreshUC(false, Color.White);
            if (editMode == FormEditMode.EDIT) txtStockTransportName.Focus();
            base.RefreshControl();
        }
        private void RefreshUC(bool value, Color color)
        {
            txtDescription.Properties.ReadOnly = value;
            txtStockTransportName.Properties.ReadOnly = value;
            txtWeight.Properties.ReadOnly = value;
            txtDescription.BackColor = color;
            txtStockTransportName.BackColor = color;
            txtWeight.BackColor = color;

        }
        protected override int ValidateData()
        {
            if (txtStockTransportCode.Text == "") return -1;
            if (txtWeight.Text == "0") return -2;
            return base.ValidateData();
        }
    }
}
