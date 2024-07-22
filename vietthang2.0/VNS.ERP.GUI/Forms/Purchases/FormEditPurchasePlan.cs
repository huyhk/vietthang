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
    public partial class FormEditPurchasePlan : VNS.Windows.Forms.FormEditBase
    {
        PurchasePlanBLL bll = new PurchasePlanBLL();
        public FormEditPurchasePlan()
        {
            InitializeComponent();
            this.Business = bll;
        }
    }
}

