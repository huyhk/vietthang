using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormCustomerDept : FormEditBase
    {
        CustomerDeptBLL obj = new CustomerDeptBLL();
        
        public FormCustomerDept()
        {
            InitializeComponent();
            this.Business = obj;
        }

        private void FormCustomerDept_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = new CustomerBLL().GetAll();
        }

        private void gridControl1_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
            this.ucCustomerDept1.SubjectCode = (cr.Current as Customer).SubjectCode;
            this.DataSource = obj.GetBySubjectCode((cr.Current as Customer).SubjectCode);
        }

        private void gridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
            this.ucCustomerDept1.SubjectCode = (cr.Current as Customer).SubjectCode;
            this.DataSource = obj.GetBySubjectCode((cr.Current as Customer).SubjectCode);
        }
        public override void RefreshButtons()
        {
            gridControl2.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }
    }
}