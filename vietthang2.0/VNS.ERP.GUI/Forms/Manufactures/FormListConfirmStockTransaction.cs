using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormListConfirmStockTransaction : FormEditBase
    {
        StockTransactionBLL obj = new StockTransactionBLL();
        /// <summary>
        /// 
        /// </summary>
        byte forDepartment = 0;
        /// <summary>
        /// Not use
        /// </summary>
        public FormListConfirmStockTransaction()
        {
            InitializeComponent();
            this.Business = obj;
        }
        /// <summary>
        /// Use to call
        /// </summary>
        /// <param name="_ForDepartment">Get value from enum</param>
        //public FormListConfirmStockTransaction(byte _ForDepartment, string text)
        //{
        //    InitializeComponent();
        //    this.Text = text;
        //    lookUpEditDVGiao.DataSource = new VendorBLL().GetAll();
        //    lookUpEditDVNhan.DataSource = new CustomerBLL().GetAll();
        //    lookUpEditKhoGiaoNhan.DataSource = new StockBLL().GetAll();
        //    lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
        //    lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
        //    this.forDepartment = _ForDepartment;
        //    if (forDepartment != (byte)enumStockTransactionForDepartment.ForSale)
        //    {
        //        gridView1.Columns.Remove(colIsAccounted);
        //        colSoDH.Visible = false;
        //    }
        //    this.Business = obj;
        //    this.lookUpStockCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
        //    this.lookUpStockCode.EditValueChanged += new EventHandler(lookUpStockCode_EditValueChanged);
        //}
        public FormListConfirmStockTransaction(byte _ForDepartment)
        {
            InitializeComponent();
            lookUpEditDVGiao.DataSource = new VendorBLL().GetAll();
            lookUpEditDVNhan.DataSource = new CustomerBLL().GetAll();
            lookUpEditKhoGiaoNhan.DataSource = new StockBLL().GetAll();
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            this.forDepartment = _ForDepartment;
            if (forDepartment != (byte)enumStockTransactionForDepartment.ForSale)
            {
                gridView1.Columns.Remove(colIsAccounted);
                colSoDH.Visible = false;
            }
            this.Business = obj;
            this.lookUpStockCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
            this.lookUpStockCode.EditValueChanged += new EventHandler(lookUpStockCode_EditValueChanged);
        }
        string productType = string.Empty;
        public FormListConfirmStockTransaction(byte _ForDepartment, string pProductType)
            : this(_ForDepartment)
        {
            productType = pProductType;
        }
        void lookUpStockCode_EditValueChanged(object sender, EventArgs e)
        {
            this.RefeshListDataSource();
        }
        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            if (forDepartment == (byte)enumStockTransactionForDepartment.ForSale)
                this.DataSource = obj.GetForDepartmentConfirmSales(lookUpStockCode.EditValue.ToString(), p.StartDate, p.EndDate, productType);
            else
                this.DataSource = obj.GetForDepartmentConfirmForPeriod(lookUpStockCode.EditValue.ToString(), forDepartment, p.StartDate, p.EndDate);
            gridControl1.RefreshDataSource();
            gridControl1.Refresh();
            gridView1.RefreshData();
        }

        private void FormListConfirmStockTransaction_Load(object sender, EventArgs e)
        {
            this.AllowEditOther = true;
            try
            {
                this.lookUpStockCode.ItemIndex = 0;
            }
            catch
            {
                
            }
            LookUpEditForDepartment.DataSource = EnumDisplays.GetListenumStockTransactionForDepartment();
            LookUpEditTTCode.DataSource = new TransactiontypeBLL().GetAll();
            LookUpEditStatus.DataSource = EnumDisplays.GetListenumStockTransactionDepartmentStatus();
            //colDepartmentStatus.Group();
            //colDepartmentStatus.SortIndex = 0;
            //colDepartmentStatus.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            //colDepartmentStatus.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

            gridControl1.RefreshDataSource();
            gridControl1.Refresh();
            gridView1.RefreshData();
        }
        public override void EditItem()
        {
            FormEditConfirmStockTransaction f = new FormEditConfirmStockTransaction(this.Text);
            f.ForDepartment = this.forDepartment;
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();

            this.ShowChildForm(f);
            //ShowDialog();
            if ((this.DataSource as ListBase<StockTransaction>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
           // base.EditItem();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditConfirmStockTransaction f = new FormEditConfirmStockTransaction(this.Text);
            f.ForDepartment = this.forDepartment;
            SetFormPrivilege(f);
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
           // f.EditItem();

            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<StockTransaction>).Count > 0)
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

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStockCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lookUpStockCode.EditValue != null && lookUpPeriod.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }
    }
}