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
    public partial class FormListAccountFixedAsset : FormEditBase
    {
        private string accountTransactionTypeCode;
        private string textForm;
        private ListBase<Period> lstPeriods = null;
        private DateTime startDate = Contexts.WorkingStartDate;
        private DateTime endDate = Contexts.WorkingEndDate;
        public FormListAccountFixedAsset()
        {
            InitializeComponent();
            this.Business = new AccountTransactionFixedAssetNewBLL();
        }

        public FormListAccountFixedAsset(string accTypeCode,string textform)
        {
            InitializeComponent();
            this.Business = new AccountTransactionFixedAssetNewBLL();
            accountTransactionTypeCode=accTypeCode;
            textForm=textform;
        }

        private void FormListAccountFixedAsset_Load(object sender, EventArgs e)
        {
            lstPeriods = new PeriodBLL().GetAll();
            this.cboPeriodCode.Properties.DataSource = lstPeriods;
            this.cboPeriodCode.EditValue = Contexts.WorkingPeriod.PeriodCode;

       
            this.Text = textForm;
        }
        public override void AddNewItem()
        {
            FormEditAccountFixedAssets f = new FormEditAccountFixedAssets(accountTransactionTypeCode,textForm);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<AccountTransactionFixedAssetNew>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl.RefreshDataSource();
        }

        public override void EditItem()
        {
            if (this.gridView.RowCount > 0)
            {
                FormEditAccountFixedAssets f = new FormEditAccountFixedAssets(accountTransactionTypeCode,textForm);
                SetFormPrivilege(f);
                f.DataSource = this.DataSource;
                f.CurrentItem = this.CurrentItem;
                f.EditItem();
                this.ShowChildForm(f);
                gridControl.RefreshDataSource();
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                FormEditAccountFixedAssets f = new FormEditAccountFixedAssets(accountTransactionTypeCode,textForm);
                SetFormPrivilege(f);
                f.DataSource = this.DataSource;
                f.CurrentItem = this.CurrentItem;
                this.ShowChildForm(f);
                gridControl.RefreshDataSource();
            }
        }

        private void cboPeriodCode_EditValueChanged(object sender, EventArgs e)
        {
            startDate = lstPeriods[this.cboPeriodCode.ItemIndex].StartDate;
            endDate = lstPeriods[this.cboPeriodCode.ItemIndex].EndDate;
            this.DataSource = (new AccountTransactionFixedAssetNewBLL()).GetObjectByTypeCodeTime(accountTransactionTypeCode, startDate, endDate);
        }
    }
}