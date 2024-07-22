using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Windows;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using System.Collections;
using VNS.Windows.Forms;
using System.Collections.Specialized;
using VNS.Utils;

namespace VNS.ERP.GUI
{
    public partial class UCSaleRequestDetails : EditControlBase
    {
        public string stockCode, productType;
        private CustomerOrderBLL customerOrderBLL ;//= new CustomerOrderBLL();
        private ListBase<CustomerOrders> lstCustomerOrders = new ListBase<CustomerOrders>();
        private ListBase<Item> lstItems = new ListBase<Item>();
        private ListBase<SaleRequestDetails> lstSaleRequestDetails;
        private CustomerDept cusTom = new CustomerDept();
        // edit by Tri 07/06/11
        //private CustomerDiscount cusDis = new CustomerDiscount();
        private CustomerDiscount2 cusDis = new CustomerDiscount2();
        //end edit
        private AutoCompleteStringCollection strPTVC = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection strNN = new AutoCompleteStringCollection();
        //private bool checkaddNewObject;
        private bool checkNochangeObject;
        public UCSaleRequestDetails()
        {
            InitializeComponent();
            this.cboSaleRequestDate.DateTime = Contexts.WorkingDate;
        }
      
        protected override void BindData()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.lookUpStockCode.EditValue = stockCode;
                this.gridControl.DataSource = null;
            }
            else
            {
                this.lookUpStockCode.EditValue = (this.DataSource as SaleRequests).StockCode;
            }

            this.lookUpStockInCode.EditValue = (this.DataSource as SaleRequests).StockInCode;

             this.cboSaleRequestDate.DateTime = (this.DataSource as SaleRequests).SaleRequestDate;
            this.txtNguoiNhan.Text = (this.DataSource as SaleRequests).NguoiGiaoNhan;
            this.txtPTVC.Text = (this.DataSource as SaleRequests).PTVC;
            this.cboCustomerOrderNo.Text = (this.DataSource as SaleRequests).CustomerOrderNo;
            this.cboTransportCode.EditValue = (this.DataSource as SaleRequests).TransportCode;
            this.cboCustomerCode.EditValue = (this.DataSource as SaleRequests).CustomerCode;
            this.txtSaleRequestNo.Text = (this.DataSource as SaleRequests).SaleRequestNo;
            this.txtInvoiceAmount.EditValue = (this.DataSource as SaleRequests).InvoiceAmount;
            this.txtInvoiceDiscount.EditValue = (this.DataSource as SaleRequests).InvoiceDiscount;
            //this.txtQuarterDiscount.EditValue = (this.DataSource as SaleRequests).QuarterDiscount;
            //this.txtYearDiscount.EditValue = (this.DataSource as SaleRequests).YearDiscount;
            this.txtDiscountAmount.EditValue = (this.DataSource as SaleRequests).DiscountAmount;
            this.txtDiscountDescription.Text = (this.DataSource as SaleRequests).DiscountDescription;
            this.txtBeforeAmount.EditValue = (this.DataSource as SaleRequests).BeforeTaxAmount;
            this.txtTaxAmount.EditValue = (this.DataSource as SaleRequests).TaxAmount;
            this.txtInvoiceNo.Text = (this.DataSource as SaleRequests).InvoiceNo;
            this.cboDueDate.Text = (this.DataSource as SaleRequests).DueDateFormat;// (this.DataSource as SaleRequests).DueDate;
            this.checkIsFinished.Checked = (this.DataSource as SaleRequests).IsFinished;
            this.checkDateLimit.Checked = (this.DataSource as SaleRequests).DateLimit;
            this.checkGiamgia.Checked = (this.DataSource as SaleRequests).Giamgia;
            if (this.EditMode == FormEditMode.ADD)
            {
                //if (DateTime.Today.Year >= 2015)
                    this.txtTaxRate.EditValue = 0;
                //else
                //    this.txtTaxRate.EditValue = 0.05;
            }
            else
                this.txtTaxRate.EditValue = (this.DataSource as SaleRequests).TaxRate;
            if (this.EditMode != FormEditMode.ADD)
            {
                if ((this.DataSource as SaleRequests).Details == null)
                {
                    (this.DataSource as SaleRequests).Details = (new SaleRequestBLL()).GetSaleRequestDetailByID((this.DataSource as SaleRequests).SaleRequestID);
                }
            }
            else
                (this.DataSource as SaleRequests).Details = new ListBase<SaleRequestDetails>();
            this.gridControl.DataSource = (this.DataSource as SaleRequests).Details;
            lkDiscountID.EditValue = (this.DataSource as SaleRequests).DiscountID;

            this.lookUpStockInCode.EditValue = (this.DataSource as SaleRequests).StockInCode;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new SaleRequests();
            (this.DataSource as SaleRequests).StockCode = this.lookUpStockCode.EditValue.ToString();

            (this.DataSource as SaleRequests).StockInCode = this.lookUpStockInCode.EditValue.ToString();


            (this.DataSource as SaleRequests).SaleRequestDate = this.cboSaleRequestDate.DateTime;
            (this.DataSource as SaleRequests).PTVC = this.txtPTVC.Text;
            if (this.cboTransportCode.EditValue != null)
            {
                (this.DataSource as SaleRequests).TransportCode = this.cboTransportCode.EditValue.ToString();
            }
            else
            {
                (this.DataSource as SaleRequests).TransportCode = "";
            }
            (this.DataSource as SaleRequests).NguoiGiaoNhan = txtNguoiNhan.Text;
            //(this.DataSource as SaleRequests).TransportCode = this.cboTransportCode.EditValue.ToString();
            (this.DataSource as SaleRequests).CustomerOrderNo = cboCustomerOrderNo.EditValue.ToString();
            (this.DataSource as SaleRequests).CustomerCode = this.cboCustomerCode.EditValue.ToString();
            (this.DataSource as SaleRequests).DueDate = this.cboDueDate.DateTime;
            (this.DataSource as SaleRequests).TaxRate = Convert.ToDecimal(this.txtTaxRate.EditValue);
            (this.DataSource as SaleRequests).SaleRequestNo = this.txtSaleRequestNo.Text;
            (this.DataSource as SaleRequests).InvoiceAmount =((decimal)(this.txtInvoiceAmount.EditValue));
            (this.DataSource as SaleRequests).InvoiceDiscount =Convert.ToDecimal(this.txtInvoiceDiscount.EditValue);
            (this.DataSource as SaleRequests).BeforeTaxAmount =((decimal)(this.txtBeforeAmount.EditValue));
            (this.DataSource as SaleRequests).TaxAmount = ((decimal)(this.txtTaxAmount.EditValue));
            (this.DataSource as SaleRequests).InvoiceNo = this.txtInvoiceNo.EditValue.ToString();
            (this.DataSource as SaleRequests).DiscountDescription = this.txtDiscountDescription.Text;
            (this.DataSource as SaleRequests).DiscountAmount = ((decimal)(this.txtDiscountAmount.EditValue));
            (this.DataSource as SaleRequests).IsFinished = this.checkIsFinished.Checked;
            (this.DataSource as SaleRequests).DateLimit = this.checkDateLimit.Checked;
            (this.DataSource as SaleRequests).Giamgia = this.checkGiamgia.Checked;
            (DataSource as SaleRequests).Details = (this.gridControl.DataSource as ListBase<SaleRequestDetails>);
            AddAutoCompleteForTextBox();

            (this.DataSource as SaleRequests).StockInCode = this.lookUpStockInCode.EditValue.ToString();
        }
        protected override int ValidateData()
        {
            if (this.EditMode == FormEditMode.EDIT)
            {
                SaleRequests sr = new SaleRequestBLL().GetBySaleRequestNo((this.DataSource as SaleRequests).SaleRequestNo);
                if (sr.IsFinished)
                {
                    MessageBox.Show("Phiếu yêu cầu xuất bán này đã thực hiện, không cho phép sửa!!!", "Thông báo", MessageBoxButtons.OK);
                    return -1234;
                }
            }
            txtNguoiNhan.Text = txtNguoiNhan.Text.Trim();
            if (this.txtSaleRequestNo.Text == String.Empty)
            {
                this.txtSaleRequestNo.Focus();
                return -1;

            }
            if (this.productType != string.Empty)
            {
                if (this.cboCustomerOrderNo.Text == String.Empty)
                {
                    this.cboCustomerOrderNo.Focus();
                    return -2;

                }

                if (this.cboCustomerCode.Text == String.Empty)
                {
                    this.cboCustomerCode.Focus();
                    return -3;

                }
            }
            if (this.txtPTVC.Text == string.Empty)
            {
                this.txtPTVC.Focus();
                return -7;
            }
            if (this.txtNguoiNhan.Text == string.Empty)
            {
                this.txtNguoiNhan.Focus();
                return -8;
            }
            if (((decimal)(this.txtDiscountAmount.EditValue)) != 0 && this.txtDiscountDescription.Text == string.Empty)
            {
                this.txtDiscountDescription.Focus();
                return -4;
            }
            if (((decimal)(this.txtDiscountAmount.EditValue)) == 0)
            {
                this.txtDiscountDescription.Text = string.Empty;
                (this.dataSource as SaleRequests).DiscountID = Guid.Empty;
            }
            if (((decimal)(this.txtDiscountAmount.EditValue)) == 0 && this.txtDiscountDescription.Text != string.Empty)
            {

                this.txtDiscountAmount.Focus();
                return -5;
            }
            if (((decimal)(this.txtDiscountAmount.EditValue)) == 0 && this.checkGiamgia.Checked == true)
            {
                this.txtDiscountAmount.Focus();
                return -5;
            }
            foreach (SaleRequestDetails saleRequestDetail in (this.DataSource as SaleRequests).Details)
            {
                if (saleRequestDetail.ItemCode == "")
                    return -6;
            }
            int i=(this.DataSource as SaleRequests).Details.Count;
            for (int j = i-1; j >=0; j--)
            {
                if ((this.DataSource as SaleRequests).Details[j].QuantityReq == 0)
                    (this.DataSource as SaleRequests).Details.RemoveAt(j);
                //SaleRequestDetails item = (this.DataSource as SaleRequests).Details.Search("QuantityReq", 0);
                //(this.DataSource as SaleRequests).Details.Remove(item);
            }
            foreach (SaleRequestDetails srd in (this.DataSource as SaleRequests).Details)
            {
                if (srd.SalePrice == 0)
                    return -100;
            }
            return 0;
        }

        public override void RefreshControl()
        {
            SetStatus();
            base.RefreshControl();
        }

        private void SetStatus()
        {
            if (this.EditMode == FormEditMode.VIEW)
            {
                this.txtNguoiNhan.ReadOnly = true;
                this.cboTransportCode.Properties.ReadOnly = true;
                this.txtSaleRequestNo.Properties.ReadOnly = true;
                this.cboSaleRequestDate.Properties.ReadOnly = true;
                this.txtPTVC.ReadOnly = true;
                this.txtTaxRate.Properties.ReadOnly = true;
                this.gridView.OptionsBehavior.Editable = false;

                this.gridControl.RefreshDataSource();
                this.btnCustomerOrderNo.Enabled = false;
                this.txtInvoiceDiscount.Properties.ReadOnly = true;
                this.txtDiscountDescription.Properties.ReadOnly = true;
                this.txtDiscountAmount.Properties.ReadOnly = true;
                this.btnReports.Enabled=true;
                this.checkGiamgia.Properties.ReadOnly = true;
                this.btnReportMau.Enabled = true;
                this.btnReportMau2.Enabled = true;

                this.lookUpStockInCode.Properties.ReadOnly = true;
            }
            if (this.EditMode == FormEditMode.ADD)
            {
                this.txtNguoiNhan.ReadOnly = false;
                this.cboTransportCode.Properties.ReadOnly = false;
                this.txtSaleRequestNo.Properties.ReadOnly = false;
                this.cboSaleRequestDate.Properties.ReadOnly = false;
                this.txtPTVC.ReadOnly = false;
                this.txtTaxRate.Properties.ReadOnly = false;
                this.gridView.OptionsBehavior.Editable = true;
                this.btnCustomerOrderNo.Enabled = true;
                this.txtInvoiceDiscount.Properties.ReadOnly = false;
                this.txtDiscountDescription.Properties.ReadOnly = true;
                this.txtDiscountAmount.Properties.ReadOnly = false;
                this.checkGiamgia.Properties.ReadOnly = false;
                this.txtSaleRequestNo.Focus();
                this.btnReportMau.Enabled = false;
                 this.btnReports.Enabled=false;
                 this.btnReportMau2.Enabled = false;

                 this.lookUpStockInCode.Properties.ReadOnly = false;
            }
            if (this.EditMode == FormEditMode.EDIT)
            {
                if (checkIsFinished.Checked == false)
                {
                    this.txtNguoiNhan.ReadOnly = false;
                    this.cboTransportCode.Properties.ReadOnly = false;
                    this.txtSaleRequestNo.Properties.ReadOnly = false;
                    this.cboSaleRequestDate.Properties.ReadOnly = false;
                    this.txtPTVC.ReadOnly = false;
                    this.txtTaxRate.Properties.ReadOnly = false;
                    this.gridView.OptionsBehavior.Editable = true;
                    this.btnCustomerOrderNo.Enabled = true;
                    this.txtInvoiceDiscount.Properties.ReadOnly = false;
                    this.txtDiscountDescription.Properties.ReadOnly = true;
                    this.txtDiscountAmount.Properties.ReadOnly = false;
                    this.txtSaleRequestNo.Focus();
                    this.btnReports.Enabled = false;
                    this.btnReportMau.Enabled = false;
                    this.btnReportMau2.Enabled = false;
                    this.checkGiamgia.Properties.ReadOnly = false;

                    this.lookUpStockInCode.Properties.ReadOnly = false;
                }
            }
            if (productType==string.Empty)
                this.btnCustomerOrderNo.Enabled = false;
        }
       

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView.RowCount > 0 && this.gridView.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    this.gridView.DeleteRow(this.gridView.FocusedRowHandle);
                    RefreshAmount();
                }
            }
        }

        void ItemLookUpItemCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                string itemCode = (string)(sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("ItemCode");
                SelectDataRowInsertGridControll(itemCode);
            }
        }


        private void btnCustomerOrderNo_Click(object sender, EventArgs e)
        {
            DataTable dtSearch = customerOrderBLL.GetSearchCustomerOrderByStockCode(stockCode, productType);
            string[] fields ={ "CustomerOrderNo", "CustomerOrderDate", "SubjectName" };
            string[] header ={ "Số phiếu", "Ngày", "Tên khách hàng" };
            DataRowView drv = (FormSearch.ShowSearch(dtSearch, fields, header) as DataRowView);
            if (this.editMode == FormEditMode.ADD || this.editMode == FormEditMode.EDIT)
            {
                if (drv != null)
                {
                    checkNochangeObject = false;
                    SetDataCboCustomer(drv["CustomerCode"].ToString(), drv["CustomerOrderNo"].ToString());
                    SetInvoiceData(drv["CustomerCode"].ToString(), drv["CustomerOrderNo"].ToString());
                }
            }
        }
        /// <summary>
        /// Set EditValue of  this.cboCustomerOrderNo.Text and  this.cboCustomerCode
        /// </summary>
        /// <param name="customerCode"></param>
        /// <param name="customerOrderNo"></param>
        public void SetDataCboCustomer(string customerCode, string customerOrderNo)
        {
            checkNochangeObject = false;
            this.cboCustomerOrderNo.Text = customerOrderNo;
            this.cboCustomerCode.EditValue = customerCode;

             (this.DataSource as SaleRequests).CustomerOrderNo=customerOrderNo;
             (this.DataSource as SaleRequests).CustomerCode = customerCode;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerCode"></param>
        /// <param name="customerOrderNo"></param>
        public void SetInvoiceData(string customerCode, string customerOrderNo)
        {
            lstSaleRequestDetails = new ListBase<SaleRequestDetails>();
           
            cusTom = (new CustomerDeptBLL()).GetBySubjectCodeAndDate(customerCode, this.cboSaleRequestDate.DateTime);
            //edit by Tri 07/06/11
            //cusDis = (new CustomerDiscountBLL()).GetBySubjectCodeAndDate(customerCode, this.cboSaleRequestDate.DateTime);
            Boolean error = false;
            cusDis = (new CustomerDiscount2BLL()).GetInvoiceDiscount(customerCode, this.cboSaleRequestDate.DateTime, out error);
            if (error == true)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu, không lấy chiết khấu được");
                return;
            }
            //end edit
            lstItems = (new CustomerOrderBLL()).GetCustomerOrderDetailByCustomerOrderNo(customerOrderNo);
            if (cusTom != null)
            {
                if (cusTom.DateLimit == true)
                {
                    checkDateLimit.Checked = cusTom.DateLimit;
                    (this.DataSource as SaleRequests).DateLimit = cusTom.DateLimit;
                    this.cboDueDate.DateTime = this.cboSaleRequestDate.DateTime.AddDays(double.Parse(cusTom.Days.ToString()));
                    (this.DataSource as SaleRequests).DueDate = this.cboSaleRequestDate.DateTime.AddDays(double.Parse(cusTom.Days.ToString()));
                }
                else
                {
                    this.cboDueDate.Text = "";
                    checkDateLimit.Checked = false;
                }
            }
            else
            {
                this.cboDueDate.Text = "";
                checkDateLimit.Checked = false;
            }
            if (cusDis != null)
            {
                //edit by Tri 07/06/11
                //this.txtInvoiceDiscount.EditValue = cusDis.InvoiceDiscount;
                //(this.DataSource as SaleRequests).InvoiceDiscount = cusDis.InvoiceDiscount;
                this.txtInvoiceDiscount.EditValue = cusDis.DiscountPercent;
                (this.DataSource as SaleRequests).InvoiceDiscount = cusDis.DiscountPercent;
                //end edit
            }
            else
            {
                this.txtInvoiceDiscount.EditValue = 0.00;
              //  (this.DataSource as SaleRequests).InvoiceDiscount = 0.00;
            }
            if (checkNochangeObject == false)
            {
                if (lstItems.Count > 0)
                {

                    foreach (Item item in lstItems)
                    {
                        SaleRequestDetails slDetail = new SaleRequestDetails();
                        slDetail.ItemCode = item.ItemCode;
                        slDetail.SalePrice = GetSalePrice(item.ItemCode);
                        lstSaleRequestDetails.Add(slDetail);
                    }
                   this.gridControl.DataSource = lstSaleRequestDetails;
                    (this.DataSource as SaleRequests).Details = lstSaleRequestDetails;
                }
            }
        }
        private decimal GetSalePrice(string itemCode)
        {
            decimal salePrice = 0, reducePrice = 0, reducePriceNoTax = 0;
            //ItemSalePrice ItemSale = new ItemSalePrice();
            //ItemSale = (new ItemSalePriceBLL()).GetByItemCodeAndDate(itemCode, this.cboSaleRequestDate.DateTime);
            //if (ItemSale != null)
            //{
            //     salePrice = decimal.Round(decimal.Round((ItemSale.SalePrice / (1 + Convert.ToDecimal(txtTaxRate.EditValue))), 2) * (1 - Convert.ToDecimal(txtInvoiceDiscount.EditValue)), 2);
            //}
            new SaleReportBLL().GetSalePrice(stockCode, this.cboCustomerCode.EditValue.ToString(), itemCode, this.cboSaleRequestDate.DateTime, out salePrice, out reducePrice, out reducePriceNoTax);
            salePrice -= reducePrice;
            salePrice = decimal.Round(decimal.Round((salePrice / (1 + Convert.ToDecimal(txtTaxRate.EditValue))), 2) * (1 - Convert.ToDecimal(txtInvoiceDiscount.EditValue)), 2,MidpointRounding.AwayFromZero);
            salePrice -= reducePriceNoTax;

            return salePrice;
        }
        private void SelectDataRowInsertGridControll(string itemCode)
        {
            //ItemSalePrice ItemSale = new ItemSalePrice();
            //ItemSale = (new ItemSalePriceBLL()).GetByItemCodeAndDate(itemCode, this.cboSaleRequestDate.DateTime);
            //if (ItemSale != null)
            //{
            //    decimal salePrice = decimal.Round(decimal.Round((ItemSale.SalePrice / (1 + Convert.ToDecimal(txtTaxRate.EditValue))), 2) * (1 - Convert.ToDecimal(txtInvoiceDiscount.EditValue)), 2);
            //    this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, this.colSalePrice, salePrice);
            //}
            //else
            //{
            //    this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, this.colSalePrice, 0);
            //}
            decimal salePrice = this.GetSalePrice(itemCode);
            this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, this.colSalePrice, salePrice);
       }

        private void txtInvoiceDiscount_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
                RefreshGrildDataSourcedGridControll();
        }

        private void txtTaxRate_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
                RefreshGrildDataSourcedGridControll();
        }
        private void RefreshGrildDataSourcedGridControll()
        {
            if (this.gridControl.DataSource != null)
            {
                foreach (SaleRequestDetails sale in (this.gridControl.DataSource as ListBase<SaleRequestDetails>))
                {
                    sale.SalePrice = GetSalePrice(sale.ItemCode);
                }
                this.gridControl.RefreshDataSource();
            }
        }
        private void LoadAutoCompleteForTextBox()
        {
            AutoCompleteUtils.LoadAutoComplete(txtPTVC);
            AutoCompleteUtils.LoadAutoComplete(txtNguoiNhan);
        }
        private void AddAutoCompleteForTextBox()
        {
            AutoCompleteUtils.AddAutoCompleteSource(txtPTVC);
            AutoCompleteUtils.AddAutoCompleteSource(txtNguoiNhan);
        }
        public void SaveAutoCompleteForTextBox()
        {
            AutoCompleteUtils.SaveAutoComplete(txtPTVC);
            AutoCompleteUtils.SaveAutoComplete(txtNguoiNhan);
        }

        private void UCSaleRequestDetails_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
              
                if (!Contexts.CurrentUser.IsAdmin)
                {
                    this.txtTaxRate.Enabled = false;
                    this.txtInvoiceDiscount.Enabled = false;
                    if (Contexts.MemberFunctions.Search("FunctionName", FunctionNames.SALES_FUNCTION_UPDATEPRICE) == null)
                    {
                        //this.txtTaxRate.Properties.ReadOnly = false;
                        //this.txtInvoiceDiscount.Properties.ReadOnly = false;
                        this.colSalePrice.OptionsColumn.AllowEdit = false;
                        this.colSalePrice.OptionsColumn.AllowFocus = false;
                       
                    }
                }
             
                customerOrderBLL = new CustomerOrderBLL(); 
                this.lookUpStockCode.Properties.DataSource =
                    this.lookUpStockInCode.Properties.DataSource = (new StockBLL()).GetAll();
                
                    this.cboCustomerCode.Properties.DataSource = (new CustomerBLL()).GetAll();
                
                this.lkDiscountID.Properties.DataSource = (new CustomerDiscountListBLL()).GetAll();
                //this.ItemLookUpItemCode.DataSource = (new ItemBLL()).GetbyItemtype((int)enumItemType.Product);
                this.ItemLookUpItemCode.DataSource = (new ItemBLL()).GetProduct(productType);
                ListBase<Vendor> lstTrans = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
                lstTrans.Add(new Vendor());
                this.cboTransportCode.Properties.DataSource = lstTrans;
                this.cboDueDate.Properties.Buttons.Clear();
                this.ItemLookUpItemCode.EditValueChanged += new EventHandler(ItemLookUpItemCode_EditValueChanged);
                this.cboCustomerCode.Properties.Buttons.Clear();
                LoadAutoCompleteForTextBox();
            }
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList();
            array.Add(cboCustomerCode.Text);
            array.Add(lookUpStockCode.Text);
            array.Add(cboTransportCode.Text);
            array.Add("Xuất bán");
            RpSaleRequestForItemMaster rpt = new RpSaleRequestForItemMaster((this.dataSource as SaleRequests), array, this.chk2Page.Checked);
            rpt.BindDataDetail();
            rpt.ShowPreviewDialog();
        }

        private void txtSaleRequestNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                string SoHieu = "";
                string year = "";
                string code = "Y21";
                if (productType==string.Empty)
                    code = "Y23";
                string suffix = "";
                if (lookUpStockCode.Text != string.Empty)
                {
                    if (lookUpStockCode.ItemIndex >= 0)
                    {
                        SoHieu = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[lookUpStockCode.ItemIndex].SoHieu;
                    }
                }
                year = cboSaleRequestDate.DateTime.Year.ToString().Substring(4 - 2);
                suffix = "/" + year + "-" + SoHieu + code;
                SaleRequests st = new SaleRequestBLL().GetTopBySuffixSaleRequestNo(suffix);
                if (st == null)
                {
                    txtSaleRequestNo.Text = "0001" + suffix;
                }
                else
                {
                    if (this.EditMode == FormEditMode.EDIT)
                    {
                        if ((DataSource as SaleRequests).SaleRequestNo != st.SaleRequestNo)
                        {
                            Int16 iprefix = Convert.ToInt16(st.SaleRequestNo.Substring(0, 4));
                            iprefix += 1;
                            string sprefix = iprefix.ToString();
                            while (sprefix.Length < 4) sprefix = "0" + sprefix;
                            txtSaleRequestNo.Text = sprefix + suffix;
                        }
                        else
                        {
                            if ((DataSource as SaleRequests).SaleRequestNo != txtSaleRequestNo.Text.Trim())
                            {
                                txtSaleRequestNo.Text = (DataSource as SaleRequests).SaleRequestNo;
                            }
                        }
                    }
                    else
                    {
                        Int16 iprefix = Convert.ToInt16(st.SaleRequestNo.Substring(0, 4));
                        iprefix += 1;
                        string sprefix = iprefix.ToString();
                        while (sprefix.Length < 4) sprefix = "0" + sprefix;
                        txtSaleRequestNo.Text = sprefix + suffix;
                    }
                }
            }
        }

        private void txtPTVC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtNguoiNhan.Focus();
        }

        private void txtNguoiNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtInvoiceDiscount.Focus();
        }

        private void cboSaleRequestDate_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                checkNochangeObject = true;
                if (this.cboCustomerCode.Text != string.Empty && this.cboCustomerOrderNo.Text != string.Empty)
                    SetInvoiceData(this.cboCustomerCode.EditValue.ToString(), this.cboCustomerOrderNo.EditValue.ToString());
                RefreshGrildDataSourcedGridControll();
            }
        }

        private void btnReportMau_Click(object sender, EventArgs e)
        {
            ListBase<SaleRequestDetails> lstDetail = new ListBase<SaleRequestDetails>();
            SaleRequests sale = (this.DataSource as SaleRequests).Clone() as SaleRequests;
            lstDetail = sale.Details;
            for (int i = 0; i < 6; i++)
            {
                if (lstDetail.Count < 6)
                {
                    lstDetail.AddNew();
                }
                else
                    break;
            }
            RpSaleRequestForItem rpt = new RpSaleRequestForItem();
            RpSaleRequestForItem.Params pr;
            pr.Lydo = "Xuất bán";
            pr.Nguoivanchuyen = cboTransportCode.Text;
            pr.Xuattaikho = lookUpStockCode.Text;
            pr.Donvimua = cboCustomerCode.Text;
            pr.NguoiGiaoNhan = this.txtNguoiNhan.Text;
            pr.So = this.txtSaleRequestNo.Text;
            pr.SoPTVC = this.txtPTVC.Text;
            pr.Ngay = this.cboSaleRequestDate.DateTime;
            rpt.RpParams = pr;
            rpt.DataSource = lstDetail;
            rpt.BindDataDetail();
            rpt.ShowPreviewDialog();
        }

        private void btnReportMau2_Click(object sender, EventArgs e)
        {
            ListBase<SaleRequestDetails> lstDetail = new ListBase<SaleRequestDetails>();
            SaleRequests sale = (this.DataSource as SaleRequests).Clone() as SaleRequests;
            lstDetail = sale.Details;
            for (int i = 0; i < 6; i++)
            {
                if (lstDetail.Count < 6)
                {
                    lstDetail.AddNew();
                }
                else
                    break;
            }
            RpSaleRequestForItem2 rpt = new RpSaleRequestForItem2();
            RpSaleRequestForItem2.Params pr;
            pr.Lydo = "Xuất bán";
            pr.Nguoivanchuyen = cboTransportCode.Text;
            pr.Xuattaikho = lookUpStockCode.Text;
            pr.Donvimua = cboCustomerCode.Text;
            pr.NguoiGiaoNhan = this.txtNguoiNhan.Text;
            pr.So = this.txtSaleRequestNo.Text;
            pr.SoPTVC = this.txtPTVC.Text;
            pr.Ngay = this.cboSaleRequestDate.DateTime;
            rpt.RpParams = pr;
            rpt.DataSource = lstDetail;
            rpt.BindDataDetail();
            rpt.ShowPreviewDialog();
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.EditMode == FormEditMode.VIEW)
                return;
            RefreshAmount();
            
        }
        void RefreshAmount()
        {
            SaleRequests s = this.dataSource as SaleRequests;
            s.TaxRate = Convert.ToDecimal(this.txtTaxRate.EditValue);
            s.UpdateRequestAmount();

            this.txtBeforeAmount.EditValue = s.BeforeTaxAmount;
            this.txtTaxAmount.EditValue = s.TaxAmount;
            this.txtInvoiceAmount.EditValue = s.InvoiceAmount;
        }

        private void txtDiscountDescription_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode == FormEditMode.VIEW)
                return;
            string[] fields = { "DiscountName", "DiscountType" };
            string[] header = { "Tên chiết khấu", "Loại" };

            ListBase<CustomerDiscountList> ooo = (new CustomerDiscountListBLL()).GetAll();
            ooo.Insert(0, new CustomerDiscountList());

            FormSearch frm = new FormSearch(ooo, fields, header);
            frm.ShowDialog();

            if (frm.SearchResult != null)
            {
                this.txtDiscountDescription.Text = (frm.SearchResult as CustomerDiscountList).DiscountName;
                (this.dataSource as SaleRequests).DiscountID = (frm.SearchResult as CustomerDiscountList).DiscountID;
            }
        }

        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            Guid saleRequestID = (this.dataSource as SaleRequests).SaleRequestID;
            Guid discountID = (Guid)lkDiscountID.EditValue;

            int i = (new SaleRequestBLL()).UpdateDiscountID(saleRequestID, discountID);
            MessageBox.Show("Xong");
            (this.dataSource as SaleRequests).DiscountID = discountID;
        }

        private void txtDiscountDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.M)
            {
                lkDiscountID.Visible = btnUpdateDiscount.Visible = true;
            }
        }
    }
}
