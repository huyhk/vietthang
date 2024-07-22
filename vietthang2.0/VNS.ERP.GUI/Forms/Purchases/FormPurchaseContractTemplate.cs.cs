using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;
using Microsoft.Office.Interop.Excel;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class FormPurchaseContractTemplate : VNS.Windows.Forms.FormEditBase
    {
        PurchaseContractTemplateBLL bll = new PurchaseContractTemplateBLL();
        public FormPurchaseContractTemplate()
        {
            InitializeComponent();
            this.Business = bll;
        }

        private void FormPurchaseContractTemplate_Load(object sender, EventArgs e)
        {
            this.DataSource = (new PurchaseContractTemplateBLL()).GetAll();
            this.repLookUpItemCode.DataSource = new ItemBLL().GetAll();
        }
    }
}

