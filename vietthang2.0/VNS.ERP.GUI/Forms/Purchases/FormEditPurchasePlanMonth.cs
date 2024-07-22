using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormEditPurchasePlanMonth : FormEditBase
    {
        PurchasePlanMonthsBLL bll = new PurchasePlanMonthsBLL();
        public FormEditPurchasePlanMonth()
        {
            InitializeComponent();
            this.Business = bll;
        }
    }
}

