using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Windows.Controls;
using VNS.Common;

namespace VNS.ERP.GUI.Stocks
{
    public partial class FormWeightItem : FormEditBase
    {
        public bool isReceive;
        private string stockCode = string.Empty;
        WeightItemBLL weightItemBLLObj = new WeightItemBLL();
        object lstDataSource;
        object lstDataSourceItem, lstDataSourceEmployee;

        public FormWeightItem()
        {
            InitializeComponent();
            this.Business = weightItemBLLObj;
            this.gridControlBase = this.gridControl1;
            lookUpStockCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
            try
            {
                lookUpStockCode.EditValue = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[0].StockCode;
            }
            catch 
            {
            }
            
            lstDataSourceEmployee = new EmployeeBLL().GetAll();
            lstDataSourceItem = new ItemBLL().GetAll();
            //this.editControl = new EditControlBase();
            //lstDataSourceStock = new StockBLL().GetAll();
            //lookUpEditStockCode.Properties.DataSource = lstDataSourceStock;
            
            
            this.repositoryItemLookUpEdit1.DataSource = lstDataSourceItem;
            this.repositoryItemLookUpEdit2.DataSource = lstDataSourceEmployee;

           
            //this.gridControl1.DataSource = lstDataSource;
        }
        public FormWeightItem(bool _IsReceive)
        {
            InitializeComponent();
            this.helpProvider1.HelpNamespace = Application.StartupPath + "//Helps//Kho.chm";
            this.helpProvider1.SetHelpKeyword(this, this.GetTextMessage("DefaultHelpKeyWord", "Phieu can xe phao nhap xuat kho"));
            this.helpProvider1.SetHelpString(this, this.GetTextMessage("DefaultHelpKeyWord", "Phieu can xe phao nhap xuat kho"));
            lookUpEditDVGiao.DataSource = new VendorBLL().GetAll();
            lookupEditDVNhan.DataSource = new CustomerBLL().GetAll();
            lookUpEditDVVanChuyen.DataSource = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            lookUpEditKhoGiao.DataSource = new StockBLL().GetAll();
            lookUpEditKhoNhan.DataSource = new StockBLL().GetAll();
            isReceive = _IsReceive;
            if (isReceive)
            {
                colDVNhan.Visible = false;
                colKhoNhan.Visible = false;
            }
            else
            {
                colDVGiao.Visible = false;
                colKhoGiao.Visible = false;
            }
            this.Business = weightItemBLLObj;
            this.gridControlBase = this.gridControl1;
            //lstDataSource = weightItemBLLObj.GetByIsReceive(isReceive);
            lstDataSourceEmployee = new EmployeeBLL().GetAll();
            lstDataSourceItem = new ItemBLL().GetAll();
            lookUpStockCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
            //this.editControl = new EditControlBase();
            //lstDataSourceStock = new StockBLL().GetAll();
            //lookUpEditStockCode.Properties.DataSource = lstDataSourceStock;
            try
            {
                lookUpStockCode.EditValue = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[0].StockCode;
            }
            catch
            {
            }


            this.repositoryItemLookUpEdit1.DataSource = lstDataSourceItem;
            this.repositoryItemLookUpEdit2.DataSource = lstDataSourceEmployee;

            this.DataSource = lstDataSource;
            if (_IsReceive)
            {
                this.Text = "Phiếu cân nhập kho";
            }
            else
            {
                this.Text = "Phiếu cân xuất kho";
            }
            colItemWeight.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            colQuantity.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            //this.gridControl1.DataSource = lstDataSource;
        }
        //protected override void AssignData()
        //{
        //    //this.editControl.data
        //    base.AssignData();
        //}

        //private void FormWeightItem_Load(object sender, EventArgs e)
        //{
        //    //lookUpEditStockCode.ItemIndex = 0;
        //    try
        //    {
        //        lookUpEditStockCode.ItemIndex = 0;
        //    }
        //    catch (Exception excp)
        //    {
        //        lookUpEditStockCode.ItemIndex = -1;
        //    }
 
        //}

        private void lookUpEditStockCode_EditValueChanged(object sender, EventArgs e)
        {
            //DevExpress.XtraGrid.Views.Base.ViewFilter vfilter = new DevExpress.XtraGrid.Views.Base.ViewFilter();
            //DevExpress.XtraGrid.Columns.ColumnFilterInfo cfinfo=new DevExpress.XtraGrid.Columns.ColumnFilterInfo("0002");
            //DevExpress.XtraGrid.Views.Base.ViewColumnFilterInfo vcfinfo = new DevExpress.XtraGrid.Views.Base.ViewColumnFilterInfo(colItemCode,cfinfo);
            //vfilter.Add(vcfinfo);
            //this.gridView1.MRUFilters.Add(vfilter);
            //this.gridView1.MRUFilters[0].
            //this.gridView1.MRUFilters.
        }
        public override void EditItem()
        {
            if (this.CurrentItem != null)
            {
                // base.EditItem();
                CurrencyManager cr = this.BindingContext[this.gridControlBase.DataSource] as CurrencyManager;
                FormWeightItemDetail f = new FormWeightItemDetail(isReceive, this.stockCode);
                SetFormPrivilege(f);
                f.SetStockCode(lookUpStockCode.EditValue.ToString());
                f.SetDataSource(this.DataSource);
                f.CurrentItem = cr.Current;
                f.Text = this.Text;
                f.EditItem();
                f.isReceive = this.isReceive;
                this.ShowChildForm(f);
                if (cr.Count > 0)
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
            //f.DataSource=this.   
        }
        public override void AddNewItem()
        {
            //base.AddNewItem();
            CurrencyManager cr = this.BindingContext[this.gridControlBase.DataSource] as CurrencyManager;
            FormWeightItemDetail f = new FormWeightItemDetail(isReceive, this.stockCode);
            SetFormPrivilege(f);
            f.SetStockCode(lookUpStockCode.EditValue.ToString());
            f.SetDataSource(this.DataSource);
            f.AddNewItem();
            //f.SetDataSource(this.dataSource);
            f.isReceive = this.isReceive;
            f.Text = this.Text;
            this.ShowChildForm(f);
            if (cr.Count > 0)
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

        private void lookUpStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStockCode.EditValue != null) this.stockCode = lookUpStockCode.EditValue.ToString();
            this.RefeshListDataSource();
        }
        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            
            if (lookUpStockCode.EditValue != null && lookUpStockCode.Properties.DataSource != null)
            {
                lstDataSource = weightItemBLLObj.GetByIsReceiveForPeriod(isReceive, this.stockCode, p.StartDate, p.EndDate);
                this.DataSource = lstDataSource;
            }
            else
            {
                this.DataSource = null;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControlBase.DataSource] as CurrencyManager;
            FormWeightItemDetail f = new FormWeightItemDetail(isReceive, this.stockCode);
            SetFormPrivilege(f);
            f.SetStockCode(lookUpStockCode.EditValue.ToString());
            f.SetDataSource(this.DataSource);
            //f.AddNewItem();
            //f.SetDataSource(this.dataSource);
            f.isReceive = this.isReceive;
            f.CurrentItem = cr.Current;
            f.Text = this.Text;
            this.ShowChildForm(f);
            if (cr.Count > 0)
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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            string fileName="";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel file|*.xls";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                gridControl1.MainView.ExportToXls(fileName);
            }
           
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            this.RefeshListDataSource();
        }
    }
}