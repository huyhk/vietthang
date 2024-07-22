using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormEditMaterialTestTransaction : VNS.Windows.Forms.FormEditBase
    {
        MaterialTestTransactionBLL bll = new MaterialTestTransactionBLL();
        private string stockCode = string.Empty;
        private string StockCode
        {
            get { return stockCode; }
            set 
            {
                stockCode = value;
                this.ucMaterialTestTransaction1.StockCode = value;
            }
        }
        /// <summary>
        /// not use
        /// </summary>
        public FormEditMaterialTestTransaction()
        {
            InitializeComponent();
            this.Business = bll;
        }
        /// <summary>
        /// use to call
        /// </summary>
        /// <param name="branchCode"></param>
        public FormEditMaterialTestTransaction(string stockCode)
        {
            InitializeComponent();
            this.StockCode = stockCode;
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

