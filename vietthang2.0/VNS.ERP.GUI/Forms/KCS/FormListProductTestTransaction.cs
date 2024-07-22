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
    public partial class FormListProductTestTransaction : VNS.Windows.Forms.FormEditBase
    {
        private enumKCSDepartment department = enumKCSDepartment.KCS;
        public enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
            }
        }
        ProductTestTransactionBLL bll = new ProductTestTransactionBLL();
        private string stockCode;
        public FormListProductTestTransaction()
        {
            InitializeComponent();
            this.Business = bll;
            lookUpStock.Properties.DataSource = new StockBLL().GetAll();
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            this.repositoryItemDateEdit1.Mask.EditMask = AppConfigs.CONFIG_DATEFORMAT;
        }
        public FormListProductTestTransaction(enumKCSDepartment department, string textForm)
        {
            InitializeComponent();
            this.Business = bll;
            this.Department = department;
            this.Text = textForm;
            lookUpStock.Properties.DataSource = new StockBLL().GetAll();
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            this.repositoryItemDateEdit1.Mask.EditMask = AppConfigs.CONFIG_DATEFORMAT;
        }
        public override void AddNewItem()
        {
            FormEditProductTestTransaction f = new FormEditProductTestTransaction(this.stockCode, this.Text, this.department);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.AddNewItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ProductTestTransaction>).Count > 0)
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
            FormEditProductTestTransaction f = new FormEditProductTestTransaction(this.stockCode, this.Text, this.department);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ProductTestTransaction>).Count > 0)
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
            FormEditProductTestTransaction f = new FormEditProductTestTransaction(this.stockCode, this.Text, this.department);
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<ProductTestTransaction>).Count > 0)
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
            lookUpStock.ItemIndex = 0;
            this.colTransactionDate.DisplayFormat.FormatString = AppConfigs.CONFIG_DATEFORMAT;
            if (this.Department == enumKCSDepartment.PTN)
            {
                this.btnAdd.Visible = false;
                this.btnEdit.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnSaveClose.Visible = false;
                this.btnSaveNew.Visible = false;
            }
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            if (this.Department == enumKCSDepartment.PTN)
            {
                this.btnAdd.Visible = false;
                this.btnEdit.Visible = false;
                this.btnRemove.Visible = false;
                this.btnSave.Visible = false;
                this.btnSaveClose.Visible = false;
                this.btnSaveNew.Visible = false;
            }
        }
        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            this.stockCode = this.lookUpStock.EditValue.ToString();
            this.DataSource = this.bll.GetByDateAndStockCode(this.stockCode, p.StartDate, p.EndDate);
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpStock.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
        private void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpStock.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null && lookUpStock.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
    }
}

