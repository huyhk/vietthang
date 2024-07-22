using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Windows;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using System.Collections;


namespace VNS.ERP.GUI.Sales
{
    public partial class UCCustomerOrderDetail : EditControlBase
    {
        private ListBase<Item> lstItems;
        private ItemProductBLL _ItemProductBLL;
        public string productType;
        public UCCustomerOrderDetail()
        {
            InitializeComponent();
          
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
               _ItemProductBLL = new ItemProductBLL();
               this.lookUpStockCode.Properties.DataSource = (new StockBLL()).GetAll();
               lookUpStockCode.ItemIndex = 0;
               this.lookUpStockCode.Enabled = false;
               this.cboCustomerCode.Properties.DataSource = (new CustomerBLL()).GetCustomer(productType);
               this.cboCustomerCode.ItemIndex = 0;

               //lstItems = (new ItemBLL()).GetbyItemtype((int)enumItemType.Product);
               lstItems = (new ItemBLL()).GetProduct(productType);
               this.ItemLookUpItemCode.DataSource = lstItems;
               this.ItemLookItem.DataSource = lstItems;
            }
            
            base.InitDataObject();
        }
        protected string stockCode;
        ///<summary>
        ///Gets or sets the object being displayed when is AddNew or Edit.
        ///</summary>
        [Browsable(false)]
        public string StockCode
        {
            get { return stockCode; }
            set
            {
                this.stockCode = value;
            }
        }
        protected override void BindData()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.lookUpStockCode.EditValue = StockCode;
            }
            else
            {
                this.lookUpStockCode.EditValue = (this.DataSource as CustomerOrders).StockCode;
            }
            //lstItems = (new ItemBLL()).GetbyItemtype((int)enumItemType.Product);
            //this.ItemLookUpItemCode.DataSource = lstItems;
            //this.ItemLookItem.DataSource = lstItems;

            if ((this.DataSource as CustomerOrders).CustomerOrderDate == DateTime.MinValue)
            {
                this.dateCustomerOrderDate.DateTime = DateTime.Today;
            }
            else
            {
                this.dateCustomerOrderDate.DateTime = (this.DataSource as CustomerOrders).CustomerOrderDate;
            }
            this.txtDescription.Text = (this.DataSource as CustomerOrders).Description;
            this.txtCustomerOrderNo.Text = (this.DataSource as CustomerOrders).CustomerOrderNo;
            this.checkIsFinished.Checked = (this.DataSource as CustomerOrders).IsFinished;
            this.cboCustomerCode.EditValue = (this.DataSource as CustomerOrders).CustomerCode;
            if (this.EditMode != FormEditMode.ADD)
            {
                if ((this.DataSource as CustomerOrders).Details.Count == 0)
                {
                    (this.DataSource as CustomerOrders).Details = (new CustomerOrderBLL()).GetCustomerOrderDetailByID((this.DataSource as CustomerOrders).CustomerOrderID);
                }
                if ((this.DataSource as CustomerOrders).DetailIsFinished == null)
                {
                    (this.DataSource as CustomerOrders).DetailIsFinished = (new SaleRequestBLL()).GetSaleRequestDetailByIsFinished_ID((this.DataSource as CustomerOrders).CustomerOrderNo);
                }
            }
            if ((this.DataSource as CustomerOrders).DetailIsFinished != null)
            {
                DataViewManager dvManager = new DataViewManager((this.DataSource as CustomerOrders).DetailIsFinished);
                DataView dv = dvManager.CreateDataView((this.DataSource as CustomerOrders).DetailIsFinished.Tables[0]);
                this.gridControl1.DataSource = dv;
            }
            else
                this.gridControl1.DataSource = null;
            this.gridControl.DataSource = (this.DataSource as CustomerOrders).Details;
           
        }

        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new CustomerOrders();
            (DataSource as CustomerOrders).StockCode = this.lookUpStockCode.EditValue.ToString();
            (DataSource as CustomerOrders).CustomerCode = this.cboCustomerCode.EditValue.ToString();
            (DataSource as CustomerOrders).CustomerOrderDate = this.dateCustomerOrderDate.DateTime;
            (DataSource as CustomerOrders).CustomerOrderNo = this.txtCustomerOrderNo.Text;
            (DataSource as CustomerOrders).Description = this.txtDescription.Text;
            (DataSource as CustomerOrders).IsFinished = this.checkIsFinished.Checked;
            (DataSource as CustomerOrders).Details = (this.gridControl.DataSource as ListBase<CustomerOrderDetails>);
        }
        protected override int ValidateData()
        {
            if (this.txtCustomerOrderNo.Text == String.Empty)
            {
                this.txtCustomerOrderNo.Focus();
                return -1;

            }
            if (this.cboCustomerCode.Text == String.Empty)
            {
                this.cboCustomerCode.Focus();
                return -2;

            }
            foreach (CustomerOrderDetails customerOrder in (this.gridControl.DataSource as ListBase<CustomerOrderDetails>))
            {
           
                if (customerOrder.ItemCode == string.Empty)
                {
                    return -3;
                }
            
                
            }
            return 0;
        }

       
        public override void RefreshControl()
        {
            SetStatus();
            base.RefreshControl();
  
        }
        //private void RefreshGridControl()
        //{
        //    try
        //    {
        //        foreach (CustomerOrderDetails customerOrder in (this.gridControl.DataSource as ListBase<CustomerOrderDetails>))
        //        {
        //            if (customerOrder.Quantity == 0)
        //                (this.gridControl.DataSource as ListBase<CustomerOrderDetails>).Remove(customerOrder);
        //        }
        //    }
        //    catch 
        //    {
        //    }
          
        //}
        
        private void SetStatus()
        {
            if (this.EditMode == FormEditMode.VIEW)
            {
                this.lookUpStockCode.Enabled = false;
                this.txtDescription.Properties.ReadOnly = true;
                this.txtCustomerOrderNo.Properties.ReadOnly = true;
                this.dateCustomerOrderDate.Properties.ReadOnly = true;
                this.gridView.OptionsBehavior.Editable = false;
                this.checkIsFinished.Properties.ReadOnly = true;
                this.cboCustomerCode.Properties.ReadOnly = true;
              //  RefreshGridControl();
                this.btnPhieuyeucau.Enabled = true;
                this.gridControl.RefreshDataSource();
            }
            else if (this.EditMode == FormEditMode.ADD)
            {
                this.txtDescription.Properties.ReadOnly = false;
                this.txtCustomerOrderNo.Properties.ReadOnly = false;
                this.dateCustomerOrderDate.Properties.ReadOnly = false;
                this.gridView.OptionsBehavior.Editable = true;
                ListBase<CustomerOrderDetails> list = new ListBase<CustomerOrderDetails>();
                CustomerOrderDetails mt = new CustomerOrderDetails();
                mt.DeliverDate = dateCustomerOrderDate.DateTime;
                list.Add(mt);
                this.gridControl.DataSource = list;
                this.txtCustomerOrderNo.Focus();
                this.checkIsFinished.Properties.ReadOnly = false;
                this.cboCustomerCode.Properties.ReadOnly = false;
                this.btnPhieuyeucau.Enabled = false;
            }
           else// (this.EditMode == FormEditMode.EDIT)
            {

                this.txtDescription.Properties.ReadOnly = false;
                this.txtCustomerOrderNo.Properties.ReadOnly = false;
                this.dateCustomerOrderDate.Properties.ReadOnly = false;
                this.gridView.OptionsBehavior.Editable = true;
                this.checkIsFinished.Properties.ReadOnly = false;
                this.cboCustomerCode.Properties.ReadOnly = false;
                this.txtCustomerOrderNo.Focus();
                this.btnPhieuyeucau.Enabled = false;
            }
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView.RowCount > 0 && this.gridView.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView.DeleteRow(this.gridView.FocusedRowHandle);
            }
        }

        private void btnPhieuyeucau_Click(object sender, EventArgs e)
        {
            if (this.lookUpStockCode.ItemIndex >= 0)
            {
                FormSaleRequestDetails frm = new FormSaleRequestDetails(this.lookUpStockCode.EditValue.ToString(), this.productType);
                frm.DataSource = (new SaleRequestBLL()).GetAllSaleRequestByStockCode(this.lookUpStockCode.EditValue.ToString());
                frm.AddNewItem();
                frm.AddNewObject(this.txtCustomerOrderNo.EditValue.ToString(),this.cboCustomerCode.EditValue.ToString());
               
                frm.ShowDialog();
            }
        } 

        private void UCCustomerOrderDetail_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (!Contexts.CurrentUser.IsAdmin)
                {
                    if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.SALES_FORM_SALEREQUEST) == null)
                        this.btnPhieuyeucau.Visible = false;
                }
            }
        }

        private void txtCustomerOrderNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                string SoHieu = "";
                string year = "";
                string code = "D21";
                string suffix = "";
                if (lookUpStockCode.Text!=string.Empty)
                {
                    if (lookUpStockCode.ItemIndex >= 0)
                    {
                        SoHieu = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[lookUpStockCode.ItemIndex].SoHieu;
                    }
                }
                year = dateCustomerOrderDate.DateTime.Year.ToString().Substring(4 - 2);
                suffix = "/" + year + "-" + SoHieu + code;
                CustomerOrders st = new CustomerOrderBLL().GetTopBySuffixCustomerOrderNo(suffix);
                if (st == null)
                {
                    txtCustomerOrderNo.Text = "0001" + suffix;
                }
                else
                {
                    if (this.EditMode == FormEditMode.EDIT)
                    {
                        if ((DataSource as CustomerOrders).CustomerOrderNo != st.CustomerOrderNo)
                        {
                            Int16 iprefix = Convert.ToInt16(st.CustomerOrderNo.Substring(0, 4));
                            iprefix += 1;
                            string sprefix = iprefix.ToString();
                            while (sprefix.Length < 4) sprefix = "0" + sprefix;
                            txtCustomerOrderNo.Text = sprefix + suffix;
                        }
                        else
                        {
                            if ((DataSource as CustomerOrders).CustomerOrderNo != txtCustomerOrderNo.Text.Trim())
                            {
                                txtCustomerOrderNo.Text = (DataSource as CustomerOrders).CustomerOrderNo;
                            }
                        }
                    }
                    else
                    {
                        Int16 iprefix = Convert.ToInt16(st.CustomerOrderNo.Substring(0, 4));
                        iprefix += 1;
                        string sprefix = iprefix.ToString();
                        while (sprefix.Length < 4) sprefix = "0" + sprefix;
                        txtCustomerOrderNo.Text = sprefix + suffix;
                    }
                }
                //if(this.EditMode== FormEditMode.EDIT)
            }
        }
    }
}
