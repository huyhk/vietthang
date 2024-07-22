using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Accounting;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormKheUocVay : VNS.Windows.Forms.FormEditBase
    {
        KheUocVayBLL bll = new KheUocVayBLL();
        public FormKheUocVay()
        {
            InitializeComponent();

            this.Business = bll;

            this.DataSource = bll.GetAll();

            this.repSubjectCode.Properties.DataSource = new BankBLL().GetAll();
        }
    }
}

