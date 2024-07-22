using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using DevExpress;

namespace VNS.ERP.GUI
{
   
    public partial class FormStock : FormEditBase
    {
        #region Properties
        object LstDataSourceStock;
        object LstDataSourceController;
        StockBLL Obj = new StockBLL();
        #endregion
        public FormStock()
        {
            
            InitializeComponent();
            this.Business = Obj;
           //this.UserDetailStock.frmParentMe = this;
           
            LstDataSourceStock = new StockBLL().GetAllAll();
            LstDataSourceController = new EmployeeBLL().GetListObjectByEmployeeGroupCode(enumEmployeeGroup.EmployeeThukho.ToString());
            UserDetailStock.SetLookupController(LstDataSourceController);
            this.DataSource = LstDataSourceStock;
            this.repositoryItemLookUpEdit2.DataSource = LstDataSourceController;
            //this.editControl = this.UserDetailStock;
            
        }
        
        protected override void InitDataObjects()
        {
            base.InitDataObjects();
            //this.Business = Obj;

            //LstDataSourceStock = new StockBLL().GetAll();
            //LstDataSourceController = new EmployeeBLL().GetAll();
            //UserDetailStock.SetLookupController(LstDataSourceController);
            //this.DataSource = LstDataSourceStock;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void FormStock_Load(object sender, EventArgs e)
        {
            //gridView1.ActiveFilter.Clear();
            //gridView1.ActiveFilter.Add(gridView1.Columns["StockCode"], new DevExpress.XtraGrid.Columns.ColumnFilterInfo("LV"));
            //gridView1.ActiveFilter.Add(gridView1.Columns["StockName"], new DevExpress.XtraGrid.Columns.ColumnFilterInfo("ABC"));
            //gridView1.RefreshData();
            //colStockCode.FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(;
            //gridView1.OptionsFilter.a
            //gridControl1.RefreshDataSource();
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            //CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            //this.CurrentItem = cr.Current;
            //MessageBox.Show("Filter; Total row: " + gridView1.RowCount.ToString());
        }

        private void UserDetailStock_OnBtnClick(object sender, EventArgs e, string sCode, string sName)
        {
            FormStockLocation f = new FormStockLocation(sCode);
            f.Text = "Phân lô cho kho " + sName;
            SetFormPrivilege(f);
            this.ShowChildForm(f);
        }
       
                     
    }
}