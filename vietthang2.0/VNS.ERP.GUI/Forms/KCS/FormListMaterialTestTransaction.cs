using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormListMaterialTestTransaction : VNS.Windows.Forms.FormEditBase
    {
        MaterialTestTransactionBLL bll = new MaterialTestTransactionBLL();
        private string stockCode = string.Empty;
        public FormListMaterialTestTransaction()
        {
            InitializeComponent();
            this.Business = bll;
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            //repItemLookUpStock.DataSource = new StockBLL().GetAll();
            //lookUpBranchCode.Properties.DataSource = new BranchBLL().GetAllByMemberID(enumSubjectType.Branch.ToString(), Contexts.CurrentUser.MemberID);
            lookUpBranchCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.LoginName);

            repLookUpItem.DataSource = new ItemBLL().GetAll();
            repLookUpVendor.DataSource = new VendorBLL().GetForPurchase();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
        }
        public override void AddNewItem()
        {
            FormEditMaterialTestTransaction f = new FormEditMaterialTestTransaction(this.stockCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            f.Text = this.Text;
            //this.shoe
            this.ShowChildForm(f);
            //f.ShowDialog();
            if ((this.DataSource as ListBase<MaterialTestTransaction>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();

        }
        public override void EditItem()
        {
            FormEditMaterialTestTransaction f = new FormEditMaterialTestTransaction(this.stockCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            f.Text = this.Text;
            this.ShowChildForm(f);
            //f.ShowDialog();
            if ((this.DataSource as ListBase<MaterialTestTransaction>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditMaterialTestTransaction f = new FormEditMaterialTestTransaction(this.stockCode);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<MaterialTestTransaction>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lookUpBranchCode.ItemIndex = 0;
        }
        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            this.stockCode = this.lookUpBranchCode.EditValue.ToString();
            this.DataSource = this.bll.GetByDateAndStockCode(p.StartDate, p.EndDate, this.stockCode);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpBranchCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpBranchCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void lookUpBranchCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpBranchCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
    }
}

