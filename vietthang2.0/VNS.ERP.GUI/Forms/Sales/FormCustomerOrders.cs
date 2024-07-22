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
using VNS.Common;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormCustomerOrders : FormEditBase
    {
        private CustomerOrderBLL customerOrderBLL = new CustomerOrderBLL();
        private ListBase<CustomerOrders> lstCustomerOrders = new ListBase<CustomerOrders>();
        private ListBase<Period> lstPeriods = null;
        private DateTime startDate = Contexts.WorkingStartDate;
        private DateTime endDate = Contexts.WorkingEndDate;

        string productType;
        public FormCustomerOrders(string pProductType)
        {
            InitializeComponent();
            this.Business = customerOrderBLL;
            productType = pProductType;
        }

        public override void AddNewItem()
        {
            if (this.lookUpStockCode.ItemIndex >= 0)
            {

                FormCustomerOrderDetails frm = new FormCustomerOrderDetails(this.lookUpStockCode.EditValue.ToString(), this.productType);
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.AddNewItem();
                frm.ShowDialog();
                if ((this.DataSource as ListBase<CustomerOrders>).Count> 0)
                {
                    this.CurrentItem = frm.CurrentItem;

                    this.gridView.FocusedRowHandle = lstCustomerOrders.IndexOf(this.CurrentItem as CustomerOrders);
                }
                else
                {
                    this.CurrentItem = null;
                }

                gridControl.RefreshDataSource();
                this.RefreshButtons();
            }
        }
        public override void EditItem()
        {
            FormCustomerOrderDetails frm = new FormCustomerOrderDetails(this.lookUpStockCode.EditValue.ToString(), this.productType);
            SetFormPrivilege(frm);
            frm.DataSource = this.DataSource;
            frm.CurrentItem = this.CurrentItem;
            frm.EditItem();
            frm.ShowDialog();
            if ((this.DataSource as ListBase<CustomerOrders>).Count > 0)
            {
                this.CurrentItem = frm.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl.RefreshDataSource();
        }

        private void FormCustomerOrders_Load(object sender, EventArgs e)
        {
            ListBase<Customer> lstCustomers = (new CustomerBLL()).GetAll();
            this.lookUpStockCode.Properties.DataSource = (new StockBLL()).GetAllForMember(Contexts.CurrentUser.MemberID);
            this.lookUpStockCode.ItemIndex = 0;
            this.ItemLookCustomerCode.DataSource = lstCustomers;
            this.ItemLookUpCustomerCodes.DataSource = lstCustomers;
            this.cboNgay.DateTime = Contexts.WorkingDate;
            this.ItemLookUpItemCode.DataSource = (new ItemBLL()).GetbyItemtype((int)enumItemType.Product);

            GetData();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
           LoadDataSourcedgridControl2();
        }

        private void cboNgay_EditValueChanged(object sender, EventArgs e)
        {
          LoadDataSourceGrilControll();
        }
       
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            LoadDataSourcedgridControl1();
        }
        private void LoadDataSourcedgridControl1()
        {
            if (this.gridView.RowCount > 0 && this.gridView1.FocusedRowHandle>=0)
            {
                DataRow dr = this.gridView1.GetDataRow(this.gridView1.FocusedRowHandle);
                FormCustomerOrderDetails frm = new FormCustomerOrderDetails(this.lookUpStockCode.EditValue.ToString(), this.productType);
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.CurrentItem = (this.DataSource as ListBase<CustomerOrders>).Search("CustomerOrderID", dr["CustomerOrderID"]);
                frm.ShowDialog();
                if ((this.DataSource as ListBase<CustomerOrders>).Count > 0)
                    this.CurrentItem = frm.CurrentItem;
                else
                    this.CurrentItem = null;
                gridControl.RefreshDataSource();
                gridControl1.RefreshDataSource();
            }
        }
        private void LoadDataSourcedgridControl2()
        {
            if (this.gridView.RowCount > 0)
            {
                FormCustomerOrderDetails frm = new FormCustomerOrderDetails(this.lookUpStockCode.EditValue.ToString(), this.productType);
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.CurrentItem = this.CurrentItem;
                frm.ShowDialog();
                if ((this.DataSource as ListBase<CustomerOrders>).Count > 0)
                    this.CurrentItem = frm.CurrentItem;
                else
                    this.CurrentItem = null;
                gridControl.RefreshDataSource();
            }
            
        }
        private void LoadDataSourceGrilControll()
        {
            if (lookUpStockCode.ItemIndex >= 0)
            {
                this.gridControl1.DataSource = customerOrderBLL.GetCustomerOrderDetailByDeliver_StockCode(this.cboNgay.DateTime, this.lookUpStockCode.EditValue.ToString());
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        void GetData()
        {
            lstCustomerOrders = customerOrderBLL.GetObjectByTimeStockCode(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, this.lookUpStockCode.EditValue.ToString(), this.productType);
            this.DataSource = lstCustomerOrders;
        }
    }
}