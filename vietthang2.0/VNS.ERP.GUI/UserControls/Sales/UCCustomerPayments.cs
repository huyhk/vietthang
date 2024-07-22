using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class UCCustomerPayments : EditControlBase
    {
        private ListBase<Cash> lstCashs;
        private ListBase<Bank> lstBanks;
        public string branchCode;
        public string soHieu;
        public UCCustomerPayments()
        {
            InitializeComponent();
            //cboPaymentTpye.EditValueChanged += new EventHandler(cboPaymentTpye_EditValueChanged);
        }

        void cboPaymentTpye_EditValueChanged(object sender, EventArgs e)
        {
            
            //throw new Exception("The method or operation is not implemented.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void SetlookUpStockCodeDSr(ListBase<Bank> lstBank, ListBase<Cash> lstCash)
        {
           lstCashs=lstCash;
           lstBanks = lstBank;
        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="obj"></param>
        public void SetLookupCustomerCodeDSr(object obj)
        {
            cboCustomerCode.Properties.DataSource = obj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void SetLookupPaymentTypeDSr(object obj)
        {
            cboPaymentTpye.Properties.DataSource = obj;
        }
        protected override void BindData()
        {
            this.cboPaymentTpye.EditValue = (dataSource as CustomerPayments).PaymentType;
            this.txtPaymentNo.Text = (dataSource as CustomerPayments).PaymentNo;
            this.cboNgayPaymentDate.DateTime = (dataSource as CustomerPayments).PaymentDate;
            this.cboCustomerCode.EditValue = (dataSource as CustomerPayments).CustomerCode;
            this.lookUpStockCode.EditValue = (dataSource as CustomerPayments).StockCode;
            this.txtAmount.EditValue = (dataSource as CustomerPayments).Amount;
            this.txtDescription.Text = (dataSource as CustomerPayments).Description;
         }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new CustomerPayments();
            (dataSource as CustomerPayments).PaymentNo = this.txtPaymentNo.Text;
            (dataSource as CustomerPayments).PaymentDate= this.cboNgayPaymentDate.DateTime ;
            (dataSource as CustomerPayments).StockCode = this.lookUpStockCode.EditValue.ToString();
            if (cboCustomerCode.EditValue != null)
            {
                (dataSource as CustomerPayments).CustomerCode = this.cboCustomerCode.EditValue.ToString();
            }
            (dataSource as CustomerPayments).PaymentType= Convert.ToByte(cboPaymentTpye.EditValue) ;
            (dataSource as CustomerPayments).Amount = Convert.ToDecimal(this.txtAmount.EditValue);
            (dataSource as CustomerPayments).Description=  this.txtDescription.Text ;
            (dataSource as CustomerPayments).BranchCode = branchCode;

        }
        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            this.txtPaymentNo.Text = this.txtPaymentNo.Text.Trim();
            if (this.txtPaymentNo.Text == String.Empty)
            {
                this.txtPaymentNo.Focus();
                return -1;
            }
            if (cboCustomerCode.ItemIndex == -1)
            {
                this.cboCustomerCode.Focus();
                return -2;
            }
            if (cboPaymentTpye.ItemIndex == -1)
            {
                this.cboPaymentTpye.Focus();
                return -3;
            }
            if (lookUpStockCode.ItemIndex == -1)
            {
                this.lookUpStockCode.Focus();
                return -4;
            }
            if (Convert.ToDecimal(txtAmount.EditValue) == 0)
            {
                this.txtAmount.Focus();
                return -5;
            }
            return 0;
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtPaymentNo.Properties.ReadOnly = false;
                this.cboNgayPaymentDate.Properties.ReadOnly = false;
                this.cboCustomerCode.Properties.ReadOnly = false;
                this.lookUpStockCode.Properties.ReadOnly = false;
                this.cboPaymentTpye.Properties.ReadOnly = false;
                this.txtAmount.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtPaymentNo.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtPaymentNo.Properties.ReadOnly = false;
                this.cboNgayPaymentDate.Properties.ReadOnly = false;
                this.cboCustomerCode.Properties.ReadOnly = false;
                this.lookUpStockCode.Properties.ReadOnly = false;
                this.cboPaymentTpye.Properties.ReadOnly = false;
                this.txtAmount.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtPaymentNo.Focus();
            }
            else
            {
                this.txtPaymentNo.Properties.ReadOnly = true;
                this.cboNgayPaymentDate.Properties.ReadOnly = true;
                this.cboCustomerCode.Properties.ReadOnly = true;
                this.lookUpStockCode.Properties.ReadOnly = true;
                this.cboPaymentTpye.Properties.ReadOnly = true;
                this.txtAmount.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
               // this.txtPaymentNo.Focus();
            }
            base.RefreshControl();
        }

        private void cboPaymentTpye_EditValueChanged_1(object sender, EventArgs e)
        {
            if (Convert.ToByte(cboPaymentTpye.EditValue) == (byte)enumCustomerPayments.Amount)
            {
                lookUpStockCode.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
                lookUpStockCode.Properties.DataSource =lstCashs;
                lookUpStockCode.ItemIndex = 0;
            }
            else
            {
                lookUpStockCode.Properties.DataSource = lstBanks;
                lookUpStockCode.ItemIndex = 0;
            }
        }

        private void txtPaymentNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                string code = "TT";
                string year = "";
                string suffix = "";
                year = this.cboNgayPaymentDate.DateTime.Year.ToString().Substring(4 - 2);
                suffix = "/" + year + "-" + soHieu + code;
                CustomerPayments st = new CustomerPaymentBLL().GetTopBySuffixCustomerPaymentNo(suffix);
                if (st == null)
                {
                    this.txtPaymentNo.Text = "0001" + suffix;
                }
                else
                {
                    
                    if (this.EditMode == FormEditMode.EDIT)
                    {
                        if ((DataSource as CustomerPayments).PaymentNo != st.PaymentNo)
                        {
                            Int16 iprefix = Convert.ToInt16(st.PaymentNo.Substring(0, 4));
                            iprefix += 1;
                            string sprefix = iprefix.ToString();
                            while (sprefix.Length < 4) sprefix = "0" + sprefix;
                            this.txtPaymentNo.Text = sprefix + suffix;
                        }
                        else
                        {
                            if ((DataSource as CustomerPayments).PaymentNo != this.txtPaymentNo.Text.Trim())
                            {
                                this.txtPaymentNo.Text = (DataSource as CustomerPayments).PaymentNo;
                            }
                        }
                    }
                    else
                    {
                        if (st.PaymentNo.StartsWith("9999"))
                        {
                            st = new CustomerPaymentBLL().GetTopBySuffixCustomerPaymentNo5(suffix);

                            if (st == null)
                            {
                                this.txtPaymentNo.Text = "10000" + suffix;
                            }
                            else
                            {
                                Int16 iprefix = Convert.ToInt16(st.PaymentNo.Substring(0, 5));
                                iprefix += 1;
                                string sprefix = iprefix.ToString();
                                while (sprefix.Length < 5) sprefix = "0" + sprefix;
                                this.txtPaymentNo.Text = sprefix + suffix;
                            }
                        }
                        else
                        {
                            Int16 iprefix = Convert.ToInt16(st.PaymentNo.Substring(0, 4));
                            iprefix += 1;
                            string sprefix = iprefix.ToString();
                            while (sprefix.Length < 4) sprefix = "0" + sprefix;
                            this.txtPaymentNo.Text = sprefix + suffix;
                        }
                    }
                }
            }
        }
    }
}
