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
    public partial class FormListPurchasePlan : VNS.Windows.Forms.FormEditBase
    {
        private PurchasePlanBLL bll = new PurchasePlanBLL();
        private ListBase<PurchasePlan> lstPurchasePlan = new ListBase<PurchasePlan>();

        public FormListPurchasePlan()
        {
            InitializeComponent();
            this.Business = bll;
        }
        private void LoadDSGridCrl()
        {
            if (this.gridView1.RowCount > 0)
            {
                FormEditPurchasePlan frm = new FormEditPurchasePlan();
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.CurrentItem = this.CurrentItem;
                frm.ShowDialog();
                if ((this.DataSource as ListBase<PurchasePlan>).Count > 0)
                    this.CurrentItem = frm.CurrentItem;
                else
                    this.CurrentItem = null;
                gridControl1.RefreshDataSource();
                this.RefreshButtons();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            LoadDSGridCrl();
        }
        public override void EditItem()
        {
            FormEditPurchasePlan frm = new FormEditPurchasePlan();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            frm.EditItem();
            frm.ShowDialog();
            if ((this.DataSource as ListBase<PurchasePlan>).Count > 0)
            {
                this.CurrentItem = frm.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }

            this.gridControl1.RefreshDataSource();
        }
        public override void AddNewItem()
        {
            FormEditPurchasePlan frm = new FormEditPurchasePlan();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.AddNewItem();
            frm.ShowDialog();
            if ((this.DataSource as ListBase<PurchasePlan>).Count > 0)
            {
                this.CurrentItem = frm.CurrentItem;
                this.gridView1.FocusedRowHandle = lstPurchasePlan.IndexOf(this.CurrentItem as PurchasePlan);
            }
            else
            {
                this.CurrentItem = null;
            }
            this.gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void FormListPurchasePlan_Load(object sender, EventArgs e)
        {
            this.repLookUpItem.DataSource = new ItemBLL().GetAll();
            this.repLookUpStock.DataSource = new StockBLL().GetAll();
            this.repLookUpSubject.DataSource = new SubjectBLL().GetAll();

            this.DataSource = bll.GetAllPlanMonths();
            this.gridView1.ExpandAllGroups();
        }
    }
}

