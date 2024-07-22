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

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormAccountTransactionTypeDetail : FormEditBase
    {
        public FormAccountTransactionTypeDetail()
        {
            InitializeComponent();
            this.Business = new AccountTransactionTypeDetailBLL();
        }

        private void FormAccountTransactionTypeDetail_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.LookupSubject.DataSource = EnumDisplays.GetListenumAccountTransactionTypeForBank();
                this.DataSource = new AccountTransactionTypeDetailBLL().GetAll();
            }
        }

    }
}