using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.ERP.Data.Accounting;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormEditFixedAssetLiquidate : VNS.Windows.Forms.FormEditBase
    {
        AccountTransactionFixedAssetLiquidateBLL bll = new AccountTransactionFixedAssetLiquidateBLL();
        public FormEditFixedAssetLiquidate(string accTypeCode, string textform)
        {
            InitializeComponent();
            this.Business = bll;
            this.ucFixedAssetLiquidate1.AccountTransactionTypeCode = accTypeCode;
            this.Text = textform;
            this.MessagePrefix = "FormEditAccountTransaction-";
            this.LayoutFile = "FormEditAccountTransaction.xml";
        }
    }
}

