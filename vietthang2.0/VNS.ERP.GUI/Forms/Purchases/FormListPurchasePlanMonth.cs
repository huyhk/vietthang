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
    public partial class FormListPurchasePlanMonth : FormEditBase
    {
        private PurchasePlanMonthsBLL bll = new PurchasePlanMonthsBLL();
        private ListBase<PurchasePlanMonths> lstPurchasePlanMonth = new ListBase<PurchasePlanMonths>();
        public FormListPurchasePlanMonth()
        {
            InitializeComponent();
            this.Business = bll;
        }
        private void LoadDSGridCrl()
        {
            if (this.gridView1.RowCount > 0)
            {
                FormEditPurchasePlanMonth frm = new FormEditPurchasePlanMonth();
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.CurrentItem = this.CurrentItem;
                frm.ShowDialog();
                if ((this.DataSource as ListBase<PurchasePlanMonths>).Count > 0)
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
            FormEditPurchasePlanMonth frm = new FormEditPurchasePlanMonth();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            frm.EditItem();
            frm.ShowDialog();
            if ((this.DataSource as ListBase<PurchasePlanMonths>).Count > 0)
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
            FormEditPurchasePlanMonth frm = new FormEditPurchasePlanMonth();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.AddNewItem();
            frm.ShowDialog();
            if ((this.DataSource as ListBase<PurchasePlanMonths>).Count > 0)
            {
                this.CurrentItem = frm.CurrentItem;
                this.gridView1.FocusedRowHandle = lstPurchasePlanMonth.IndexOf(this.CurrentItem as PurchasePlanMonths);
            }
            else
            {
                this.CurrentItem = null;
            }
            this.gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void FormListPurchasePlanMonth_Load(object sender, EventArgs e)
        {
            this.repLookUpItem.DataSource = new ItemBLL().GetAll();
            this.repLookUpStock.DataSource = new StockBLL().GetAll();
            this.repLookUpSubject.DataSource = new SubjectBLL().GetAll();

            this.DataSource = bll.GetAllPlanMonths();
            this.gridView1.ExpandAllGroups();
        }


    }
}

