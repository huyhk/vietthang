using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;

namespace VNS.ERP.GUI
{
    public partial class FormListPurchaseInvoice : VNS.Windows.Forms.FormEditBase
    {
        public FormListPurchaseInvoice()
        {
            InitializeComponent();
            this.Business = new PurchaseInvoiceBLL();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetDataSource();
        }
        void GetDataSource()
        {
            this.DataSource = new PurchaseInvoiceBLL().GetByDateAndSubject(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, "");
        }

        private void FormListPurchaseInvoice_Load(object sender, EventArgs e)
        {
            this.ucDatePeriodSelection1.SetCurrentMonth();
            this.repSubjectName.DataSource = new VendorBLL().GetAll();
            GetDataSource();
        }
        public override void AddNewItem()
        {
            FormEditPurchaseInvoice frm = new FormEditPurchaseInvoice();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.AddNewItem();
            frm.ShowDialog();
        }
        public override void EditItem()
        {
            FormEditPurchaseInvoice frm = new FormEditPurchaseInvoice();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            frm.EditItem();
            frm.ShowDialog();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormEditPurchaseInvoice frm = new FormEditPurchaseInvoice();
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            //frm.EditItem();
            frm.ShowDialog();
        }
    }
}

