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
    public partial class DetailTransactionType : VNS.Windows.Controls.EditControlBase
    {
        public DetailTransactionType()
        {
            InitializeComponent();
            //this.CboStockTransaction.Properties.Styl;
        }
        public void SetDataSourceCboStockTransaction(object obj)
        {
            CboStockTransaction.Properties.DataSource = obj;
        }
        protected override void BindData()
        {
            if (dataSource != null)
            {
                //string st = (dataSource as TransactionType).StockTransaction.ToString();
                this.txtTransactionTypeCode.Text = (dataSource as TransactionType).TransactionTypeCode;
          
                this.txtDescription.Text = (dataSource as TransactionType).Description;
                this.CboStockTransaction.EditValue = (byte)(dataSource as TransactionType).StockTransaction;
                if (this.CboStockTransaction.ItemIndex == -1)
                {
                    try
                    {
                        this.CboStockTransaction.EditValue = (byte)(CboStockTransaction.Properties.DataSource as ListBase<enums>)[0].EnumID;
                    }
                    catch 
                    {
                    }
                }
            }
            base.BindData();
        }

        protected override int ValidateData()
        {
            txtTransactionTypeCode.Text = txtTransactionTypeCode.Text.Trim();
            if (txtTransactionTypeCode.Text == "")
            {
                txtTransactionTypeCode.Focus();
                return -1;
            }
            //if (txtdescription.Text == "") return -3;
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if(dataSource == null) dataSource =new TransactionType();
            (dataSource as TransactionType).TransactionTypeCode = this.txtTransactionTypeCode.Text;
            (dataSource as TransactionType).Description = this.txtDescription.Text;
            if (this.EditMode == FormEditMode.ADD)
            {
                (dataSource as TransactionType).UserCreated = Contexts.CurrentUser.LoginName;
                (dataSource as TransactionType).DateCreated = DateTime.Now;
            }
            (dataSource as TransactionType).UserUpdated = Contexts.CurrentUser.LoginName;
            (dataSource as TransactionType).DateUpdated = DateTime.Now;
            (dataSource as TransactionType).StockTransaction = (byte)CboStockTransaction.EditValue;
            //if (CboStockTransaction.SelectedIndex == 0 )
            //{
            //    (dataSource as TransactionType).StockTransaction = 0;
            //}
            //else if (CboStockTransaction.SelectedIndex == 1)
            //{
            //    (dataSource as TransactionType).StockTransaction = 1;
            //}
            //else
            //{
            //    (dataSource as TransactionType).StockTransaction = 2;
            //}

            base.AssignData();
        }
        //public override bool Save()
        //{
        //    return base.Save();
        //}
        public override void RefreshControl()
        {
            this.txtTransactionTypeCode.Properties.ReadOnly = this.editMode != FormEditMode.ADD;
            this.CboStockTransaction.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            this.txtDescription.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtTransactionTypeCode.BackColor = txtBackGround.BackColor;
                this.txtDescription.BackColor = txtBackGround.BackColor;
                this.CboStockTransaction.BackColor = txtBackGround.BackColor;
                this.txtTransactionTypeCode.Focus();
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                this.txtTransactionTypeCode.BackColor = lbStockTransaction.BackColor;
                this.txtDescription.BackColor = txtBackGround.BackColor;
                this.CboStockTransaction.BackColor = txtBackGround.BackColor;
                this.CboStockTransaction.Focus();
            }
             if (this.editMode == FormEditMode.VIEW)
            {
                this.txtTransactionTypeCode.BackColor = lbStockTransaction.BackColor;
                this.txtDescription.BackColor = lbStockTransaction.BackColor;
                this.CboStockTransaction.BackColor = lbStockTransaction.BackColor;
                
            }
            if (this.DataSource == null)
            {
                this.txtTransactionTypeCode.Text = "";
                this.txtDescription.Text = "";
                this.CboStockTransaction.ItemIndex = -1;
            }
            base.RefreshControl();
        }

       
    }
}
