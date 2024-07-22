using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Accounting;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormListFixedAssetLiquidate : VNS.Windows.Forms.FormEditBase
    {
        AccountTransactionFixedAssetLiquidateBLL bll = new AccountTransactionFixedAssetLiquidateBLL();
        private string accountTransactionTypeCode;
        public FormListFixedAssetLiquidate(string accTypeCode, string textform)
        {
            InitializeComponent();
            this.Business = bll;
            accountTransactionTypeCode = accTypeCode;
            this.LayoutFile = "FormListAccountTransaction.xml";
        }
        void GetData()
        {
            this.DataSource = bll.GetObjectByTypeCodeTime(accountTransactionTypeCode, this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.GetData();
        }

        private void FormListFixedAssetLiquidate_Load(object sender, EventArgs e)
        {
            this.ucDatePeriodSelection1.SetCurrentYear();
            this.GetData();
        }
        public override void AddNewItem()
        {
            FormEditFixedAssetLiquidate f = new FormEditFixedAssetLiquidate(accountTransactionTypeCode, this.Text);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            //if ((this.DataSource as ListBase<AccountTransactionFixedAssetUpgrade>).Count > 0)
            //{
            //    this.CurrentItem = f.CurrentItem;
            //}
            //else
            //{
            //    this.CurrentItem = null;
            //}
            //gridControl.RefreshDataSource();
        }
        public override void EditItem()
        {
            if (this.gridView.RowCount > 0)
            {
                FormEditFixedAssetLiquidate f = new FormEditFixedAssetLiquidate(accountTransactionTypeCode, this.Text);
                SetFormPrivilege(f);
                f.DataSource = this.DataSource;
                f.CurrentItem = this.CurrentItem;
                f.EditItem();
                this.ShowChildForm(f);
                //gridControl.RefreshDataSource();
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                FormEditFixedAssetLiquidate f = new FormEditFixedAssetLiquidate(accountTransactionTypeCode, this.Text);
                SetFormPrivilege(f);
                f.DataSource = this.DataSource;
                f.CurrentItem = this.CurrentItem;
                //f.EditItem();
                this.ShowChildForm(f);
                //gridControl.RefreshDataSource();
            }
        }
    }
}

