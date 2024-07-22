using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormEditAccountFixedAssets : FormEditBase
    {
        private string accountTransactionTypeCode;
        private string textForm;
        public FormEditAccountFixedAssets()
        {
            InitializeComponent();
           this.Business = new AccountTransactionFixedAssetNewBLL();
            
        }
        public FormEditAccountFixedAssets(string accTypeCode,string textform)
        {
            InitializeComponent();
            this.Business = new AccountTransactionFixedAssetNewBLL();
            accountTransactionTypeCode = accTypeCode;
            this.ucAccountFixedAssets1.AccountTransactionTypeCode = accTypeCode;
            textForm = textform;
            this.MessagePrefix = "FormEditAccountTransaction-";
            this.LayoutFile = "FormEditAccountTransaction.xml";
        }
     
        public override void AddNewItem()
        {
        
            base.AddNewItem();
            this.ucAccountFixedAssets1.SetAccountSample("");
        }

        public override void EditItem()
        {
          
            base.EditItem();
        }

        private void FormEditAccountFixedAssets_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.Text = textForm;
                if (accountTransactionTypeCode == string.Empty)
                {
                    this.btnSave.Enabled = false;
                    this.btnSaveNew.Enabled = false;
                    this.btnCancel.Enabled = false;
                }
                else
               
            this.MessagePrefix = "FormEditAccountTransaction-";
            this.LayoutFile = "FormEditAccountTransaction.xml";
            }
        }

        private void FormEditAccountFixedAssets_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
        }
    }
}