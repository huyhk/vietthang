using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormEditPurchaseInvoice : VNS.Windows.Forms.FormEditBase
    {
        public FormEditPurchaseInvoice()
        {
            InitializeComponent();
            this.Business = new PurchaseInvoiceBLL();
        }
    }
}

