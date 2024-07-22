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
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormPrePaidExpenseOpening : FormEditBase
    {
        private PeriodBLL periodBLL = null;
        public FormPrePaidExpenseOpening()
        {
            InitializeComponent();
            this.Business = new PrePaidExpenseOpeningBLL();
        }

        private void FormPrePaidExpenseOpening_Load(object sender, EventArgs e)
        {
            periodBLL = new PeriodBLL();
            Period period = periodBLL.GetMin();
            this.DataSource = (new PrePaidExpenseOpeningBLL()).GetListPrePaidExpenseOpeningByPeriodCode(period.PeriodCode);
            this.ItemLookUpAccount.DataSource = (new AccountBLL()).GetObjectDynamic("left(AccountCode,3)='142' or left(AccountCode,3)='242'  and AccountCode not in (select AccountParent from Accounts where AccountParent is not null)", "");
            this.ItemLookUpSubject.DataSource = (new BranchBLL()).GetAll();
            this.Text = this.Text + " " + period.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.gridOpenning.RefreshDataSource();
            //if (periodBLL.SelectIsClosedTrue(enumModuleID.Accounting.ToString()).Count > 0)
            //{
            //    this.btnAdd.Enabled = false;
            //    this.btnEdit.Enabled = false;
            //    this.btnRemove.Enabled = false;
            //}

        }
    }
}