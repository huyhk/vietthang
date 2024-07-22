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

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormFixedAssetOpening : FormEditBase
    {
        private PeriodBLL periodBLL = null;
        public FormFixedAssetOpening()
        {
            InitializeComponent();
            this.Business = new FixedAssetOpeningBLL();
        }

        private void FormFixedAssetOpening_Load(object sender, EventArgs e)
        {
            periodBLL = new PeriodBLL();
            Period period = periodBLL.GetMin();
            this.DataSource = (new FixedAssetOpeningBLL()).GetListFixedAssetOpeningByPeriodCode(period.PeriodCode);
            this.ItemLookAccountCode.DataSource = (new AccountBLL()).GetObjectDynamic("left(AccountCode,3) in ('211','213')  and AccountCode not in (select AccountParent from Accounts where AccountParent is not null)", "");
            this.ItemLookSubjectCode.DataSource = (new FixedAssetBLL()).GetAll();
            this.Text = this.Text + " " + period.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.gridControl.RefreshDataSource();
            //if (periodBLL.SelectIsClosedTrue(enumModuleID.Accounting.ToString()).Count > 0)
            //{
            //    this.btnAdd.Enabled = false;
            //    this.btnEdit.Enabled = false;
            //    this.btnRemove.Enabled = false;
            //}

        }
    }
}