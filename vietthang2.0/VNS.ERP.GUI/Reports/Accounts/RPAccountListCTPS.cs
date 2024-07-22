using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using VNS.ERP.Data.Accounting;

namespace VNS.ERP.GUI.Reports.Accounts
{
    public partial class RPAccountListCTPS : DevExpress.XtraReports.UI.XtraReport
    {
        public RPAccountListCTPS()
        {
            InitializeComponent();
        }
        public void BindData(ListBase<AccountTransaction> lst)
        {
            this.DataSource = lst;
            //this.subreport1.
        }

    }
}
