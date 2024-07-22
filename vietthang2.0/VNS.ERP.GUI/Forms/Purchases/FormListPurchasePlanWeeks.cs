using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.Windows.Forms;
using VNS.Common;


namespace VNS.ERP.GUI
{
    public partial class FormListPurchasePlanWeeks : FormEditBase
    {
        private PurchasePlanWeekBLL bll = new PurchasePlanWeekBLL();
        private ListBase<PurchasePlanWeek> lstPurchasePlanWeek = new ListBase<PurchasePlanWeek>();
        public FormListPurchasePlanWeeks()
        {
            InitializeComponent();
            this.Business = bll;
        }
        private void LoadDSGridCrl()
        {
            if (this.gridView1.RowCount > 0)
            {
                FormEditPurchasePlanWeeks frm = new FormEditPurchasePlanWeeks();
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.CurrentItem = this.CurrentItem;
                frm.ShowDialog();
                if ((this.DataSource as ListBase<PurchasePlanWeek>).Count > 0)
                    this.CurrentItem = frm.CurrentItem;
                else
                    this.CurrentItem = null;
                gridControl1.RefreshDataSource();
                this.RefreshButtons();
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            LoadDSGridCrl();
        }
        public override void EditItem()
        {
            FormEditPurchasePlanWeeks frm = new FormEditPurchasePlanWeeks();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            frm.EditItem();
            frm.ShowDialog();
            if ((this.DataSource as ListBase<PurchasePlanWeek>).Count > 0)
            {
                this.CurrentItem = frm.CurrentItem;
                //this.gridView1.FocusedRowHandle = lstPurchasePlanMonth.IndexOf(this.CurrentItem as PurchasePlanMonths);
            }
            else
            {
                this.CurrentItem = null;
            }

            this.gridControl1.RefreshDataSource();
        }
        public override void AddNewItem()
        {
            FormEditPurchasePlanWeeks frm = new FormEditPurchasePlanWeeks();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.AddNewItem();
            frm.ShowDialog();
            if ((this.DataSource as ListBase<PurchasePlanWeek>).Count > 0)
            {
                this.CurrentItem = frm.CurrentItem;
                this.gridView1.FocusedRowHandle = lstPurchasePlanWeek.IndexOf(this.CurrentItem as PurchasePlanWeek);
            }
            else
            {
                this.CurrentItem = null;
            }
            this.gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void FormListPurchasePlanWeeks_Load(object sender, EventArgs e)
        {
            this.spinYear.Value = DateTime.Now.Year;

            this.repLookUpStartDate.DataSource = new PurchasePlanWeekBLL().GetAll();
            this.repLookUpEndDate.DataSource = new PurchasePlanWeekBLL().GetAll();
            this.repLookUpItem.DataSource = new ItemBLL().GetAll();
            this.repLookUpStock.DataSource = new StockBLL().GetAll();
            this.repLookUpSubject.DataSource = new VendorBLL().GetForPurchase();
            this.RefreshGridControl();
            this.gridView1.ExpandAllGroups();
        }
        private void RefreshGridControl()
        {
            this.DataSource = bll.GetAllPlanWeeks(Convert.ToInt32(this.spinYear.Value));
        }

        private void spinYear_EditValueChanged(object sender, EventArgs e)
        {
            this.RefreshGridControl();
        }
    }
}

