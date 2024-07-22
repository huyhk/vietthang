using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Windows;
using VNS.ERP.Data;
using VNS.ERP.Data.Equipments;

namespace VNS.ERP.GUI.Equipments
{
    public partial class FormEditVattuTransaction : FormEditBase
    {
        VattuTransactionBLL bll = new VattuTransactionBLL();
        private string stockCode = string.Empty;
        private string StockCode
        {
            get { return stockCode; }
            set
            {
                stockCode = value;
                this.ucVattuTransaction1.StockCode = value;
            }
        }
        private string stockCodeIn = string.Empty;
        private string StockCodeIn
        {
            get { return stockCodeIn; }
            set
            {
                stockCodeIn = value;
                this.ucVattuTransaction1.StockCodeIn = value;
            }
        }
        private string transactionType = string.Empty;
       
        private string inOutType = string.Empty;
        

        public FormEditVattuTransaction()
        {
            InitializeComponent();
            this.Business = bll;
        }
        public FormEditVattuTransaction(string fStockCode, string fStockCodeIn, string fTransactionType, string fTextForm, string fInOutType)
        {
            InitializeComponent();
            this.Text = fTextForm;
            this.StockCode = fStockCode;
            //this.ucVattuTransaction1.stockCode = stockCode;
            this.StockCodeIn = fStockCodeIn;
            //this.ucVattuTransaction1.stockCodeIn = stockCodeIn;
            transactionType = fTransactionType;
            this.ucVattuTransaction1.transactionType = transactionType;
            inOutType = fInOutType;
            this.ucVattuTransaction1.inOutType = inOutType;
            this.Business = bll;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                this.CancelItem();
            }
            base.OnClosing(e);
        }
    }
}

