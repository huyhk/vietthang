using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using VNS.Windows;
using VNS.Windows.Forms;
using VNS.Utils;
using DevExpress.XtraGrid.Views.Grid;

namespace VNS.ERP.GUI.UserControls.Manufactures
{
    public partial class UCConfirmStockTransaction : EditControlBase
    {
        bool loadedAutoComplete = false;
        public string TransactionTypeCode
        {
            get 
            {
                string s = null;
                if (lookupTransactionTypeCode.EditValue != null)
                {
                    s = lookupTransactionTypeCode.EditValue.ToString(); 
                }
                return s; 
            }
        }
        /// <summary>
        ///
        /// </summary>
        bool IsAutoInitForDepartmentValue = true;
        /// <summary>
        /// 
        /// </summary>
        private byte forDepartment;
        /// <summary>
        /// 
        /// </summary>
        public byte ForDepartment
        {
            get { return forDepartment; }
            set 
            { 
                forDepartment = value;
                if (forDepartment == (byte)enumStockTransactionForDepartment.ForSale)
                {
                    //txtHTTT.Visible = true;
                    //lbHTTT.Visible = true;
                    //txtSoHoaDon.Visible = true;
                    //lbSoHoaDon.Visible = true;
                    //lbDiscount.Visible = true;
                    //txtDiscount.Visible = true;
                    //txtDiscountDescription.Visible = true;
                    //lbDiscountDescription.Visible = true;
                    grBoxInvoice.Visible = true;
                    this.IsAutoInitForDepartmentValue = false;
                    //chkSaleDiscount.Visible = true;
                }
                else
                {
                    //txtHTTT.Visible = false;
                    //lbHTTT.Visible = false;
                    //txtSoHoaDon.Visible = false;
                    //lbSoHoaDon.Visible = false;
                    //lbDiscount.Visible = false;
                    //txtDiscount.Visible = false;
                    //txtDiscountDescription.Visible = false;
                    //lbDiscountDescription.Visible = false;
                    //chkSaleDiscount.Visible = false;
                    grBoxInvoice.Visible = false;
                    if (!this.IsAutoInitForDepartmentValue)
                    {
                        //int deltaTopInputControl = btnEditSoDH.Top - txtDiscount.Top;
                        //int deltaTopLabelControl = lbSoDH.Top - lbSoHoaDon.Top;
                        //foreach (Control o in this.Controls)
                        //{
                        //    if (o is Label)
                        //    {
                        //        if (o.Top > lbSoHoaDon.Top)
                        //        {
                        //            o.Top -= deltaTopLabelControl;
                        //        }
                        //    }
                        //    else
                        //    {
                        //        if (o.Top > txtDiscount.Top)
                        //        {
                        //            o.Top -= deltaTopInputControl;
                        //        }
                        //    }
                        //}

                        gridControl1.Height += grBoxInvoice.Height;
                    }
                    if (this.ForDepartment != (byte)enumStockTransactionForDepartment.ForPurchase)
                    {
                        this.gridView1.OptionsDetail.EnableMasterViewMode = false;
                    }
                    else
                    { this.gridView1.OptionsDetail.EnableMasterViewMode = true; }
                    this.IsAutoInitForDepartmentValue = false;
                }
            }
        }
        public UCConfirmStockTransaction()
        {
            //chkDepartmentConfirm.Visible
            InitializeComponent();
            btnEdit.Buttons[0].Visible = false;
            this.txtInvoiceThueXuat.Properties.EditFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.txtInvoiceThueXuat.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.txtInvoiceThueXuat.Properties.Mask.EditMask = AppConfigs.CONFIG_PERCENTFORMAT;
            //if (!this.DesignMode)
            //{
            //    AutoCompleteUtils.LoadAutoComplete(txtInvoiceSeri);
            //}

            
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                ListBase<Vessel> lstVessel = new VesselBLL().GetAll();
                lstVessel.Insert(0, new Vessel());
                lookUpEditVesselCode.Properties.DataSource = lstVessel;

                ListBase<TransportRoute> lstRoute = new TransportRouteBLL().GetVCRoute();
                lstRoute.Insert(0, new TransportRoute());
                txtTransportRoute.Properties.DataSource = lstRoute;

                AutoCompleteUtils.LoadAutoComplete(txtInvoiceSeri);
                loadedAutoComplete = true;
            }
        }
        public void SetLookupEditDVGiaoDSr(object obj)
        {
            lookUpEditDVGiao.Properties.DataSource = obj;
        }
        public void SetLookupEditDVNhanDSr(object obj)
        {
            lookUpEditDVNhan.Properties.DataSource = obj;
        }
        public void SetLookupEditDVVanChuyenDSr(object obj)
        {
            lookUpEditDVVanChuyen.Properties.DataSource = obj;
        }
        public void SetLookupTransactionTypeCodeDataSource(Object obj)
        {
            this.lookupTransactionTypeCode.Properties.DataSource = obj;
        }
        public void SetLookupEditInStockDataSource(Object obj)
        {
            lookUpInStock.Properties.DataSource = obj;
        }
        public void SetLookupEditOutStockDataSource(Object obj)
        {
            lookUpOutStock.Properties.DataSource = obj;
        }
        public void SetLookupEditForDepartmentDataSource(Object obj)
        {
            lookUpEditForDepartment.Properties.DataSource = obj;
        }
        public void SetLookupEditKhoGiaoDSr(object obj)
        {
            lookUpEditKhoGiao.Properties.DataSource = obj;
            //colQuantityReg.Visible
        }
        public void SetLookupEditKhoNhanDSr(object obj)
        {
            lookUpEditKhoNhan.Properties.DataSource = obj;
        }
        //public void SetLookupEditDVGiaoDSr(object obj)
        //{
        //    lookUpEditDVGiao.Properties.DataSource = obj;
        //}
        //public void SetLookupEditDVNhanDSr(object obj)
        //{
        //    lookUpEditDVNhan.Properties.DataSource = obj;
        //}
        protected override bool ConfirmBeforeSave()
        {
            if (this.DataSource!= null)
            {
                if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForSale)
                {
                    StockTransaction t = this.DataSource as StockTransaction;
                    StockTransaction t1 = new StockTransactionBLL().GetByTransactionID(t.TransactionID);
                    t.AccountTransactionID = t1.AccountTransactionID;
                    if (t.IsAccounted)
                    {
                        if (MessageBox.Show((this.Parent as FormEditBase).GetTextMessage("ConfirmDeleteIsAccounted", "Phiếu này đã được định khoản kế toán, chương trình sẽ xóa phiếu định khoản đi trước khi lưu, bạn muốn tiếp tục lưu không?"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            
            return base.ConfirmBeforeSave();
        }
        protected override void AssignData()
        {
            if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForSale)
            {
                if ((this.DataSource as StockTransaction).SaleRequestObj == null) (this.DataSource as StockTransaction).SaleRequestObj = new SaleRequests();
                (this.DataSource as StockTransaction).SaleRequestObj.DiscountAmount = Convert.ToDecimal(txtDiscount.EditValue);
                (this.DataSource as StockTransaction).SaleRequestObj.DiscountDescription = txtDiscountDescription.Text;
                (this.DataSource as StockTransaction).SaleRequestObj.PaymentType = txtHTTT.Text;
                (this.DataSource as StockTransaction).SaleRequestObj.Giamgia = chkSaleDiscount.Checked;
                (this.DataSource as StockTransaction).SaleRequestObj.InvoiceMau = txtInvoiceMau.Text;
                (this.DataSource as StockTransaction).SaleRequestObj.InvoiceSeri = txtInvoiceSeri.Text;
                (this.DataSource as StockTransaction).SaleRequestObj.InvoiceDate = dateEditInvoice.DateTime;
                (this.DataSource as StockTransaction).SaleRequestObj.TaxRate = Convert.ToDecimal(txtInvoiceThueXuat.EditValue);
                (this.DataSource as StockTransaction).SaleRequestObj.BeforeTaxAmount = Convert.ToDecimal(txtBeforeTaxAmount.EditValue);
                (this.DataSource as StockTransaction).SaleRequestObj.TaxAmount = Convert.ToDecimal(txtTaxAmount.EditValue);
                (this.DataSource as StockTransaction).SaleRequestObj.InvoiceAmount = Convert.ToDecimal(txtInvoiceAmount.EditValue);
                (this.DataSource as StockTransaction).SaleRequestObj.InvoiceNo = txtSoHoaDon.Text;
                (this.DataSource as StockTransaction).SaleRequestObj.InvoiceCustomerName = txtInvoiceCustomerName.Text;
                (this.DataSource as StockTransaction).SaleRequestObj.InvoicePersonName = txtInvoicePersonName.Text;

                (this.DataSource as StockTransaction).SoHoaDon = txtSoHoaDon.Text;
            }
            if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForPurchase)
            {
                (this.DataSource as StockTransaction).SoHD = this.btnEditSoHD.EditValue.ToString();
                //tri
                (this.DataSource as StockTransaction).Dotnhap = (int) this.txtDotnhap.Value;
                //
            }
            //(this.DataSource as StockTransaction).SaleRequestObj.
            if (chkDepartmentConfirm.Checked)
            {
                (this.DataSource as StockTransaction).DepartmentStatus = (byte)enumStockTransactionDepartmentStatus.Confirm;
            }
            else
            {
                (this.DataSource as StockTransaction).DepartmentStatus = (byte)enumStockTransactionDepartmentStatus.WaittingConfirm;
            }
            (this.DataSource as StockTransaction).DepartmentDescription = txtDepartmentDes.Text;
            //(this.DataSource as StockTransaction).DepartmentStatus=(byte)(chk)
            base.AssignData();
        }
        protected override int ValidateData()
        {
            StockTransaction st = this.DataSource as StockTransaction;
            ListBase<StockTransactionSumDetail> listD = new StockTransactionBLL().GetDetailsByTransactionID(st.TransactionID);
            if (st.Details.Count != listD.Count)
                return -123;
            for (int i = 0; i < listD.Count; i++)
                if (st.Details[i].ItemCode != listD[i].ItemCode || st.Details[i].Quantity != listD[i].Quantity)
                    return -123;
            if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForSale)
            {
                this.RefreshSaleRequest1();

                //txtDiscount.Text = txtDiscount.Text.Trim();
                txtDiscountDescription.Text = txtDiscountDescription.Text.Trim();
                txtInvoiceCustomerName.Text = txtInvoiceCustomerName.Text.Trim();
                txtSoHoaDon.Text = txtSoHoaDon.Text.Trim();
                txtHTTT.Text = txtHTTT.Text.Trim();
                txtInvoiceMau.Text = txtInvoiceMau.Text.Trim();
                txtInvoiceSeri.Text = txtInvoiceSeri.Text.Trim();

                AutoCompleteUtils.AddAutoCompleteSource(txtInvoiceSeri);

                decimal beforeTaxAmount = 0;
                //StockTransaction st = this.DataSource as StockTransaction;
                foreach (StockTransactionSumDetail stsd in st.Details)
                {
                    beforeTaxAmount += stsd.AmountOut;
                }
                beforeTaxAmount -= Convert.ToDecimal(txtDiscount.EditValue);
                txtBeforeTaxAmount.EditValue = beforeTaxAmount;
                txtTaxAmount.EditValue = Math.Round(beforeTaxAmount * Convert.ToDecimal(txtInvoiceThueXuat.EditValue), 0, MidpointRounding.AwayFromZero);
                txtInvoiceAmount.EditValue = beforeTaxAmount + Convert.ToDecimal(txtTaxAmount.EditValue);
                if (this.TransactionTypeCode == "X21")
                {
                    if (chkDepartmentConfirm.Checked && txtSoHoaDon.Text == "" && this.forDepartment == (byte)enumStockTransactionForDepartment.ForSale)
                    {
                        txtSoHoaDon.Focus();
                        return -1;
                    }
                    if (Convert.ToDecimal(this.txtDiscount.EditValue) != 0 && this.txtDiscountDescription.Text == string.Empty)
                    {
                        this.txtDiscountDescription.Focus();
                        return -2;
                    }
                    if (Convert.ToDecimal(this.txtDiscount.EditValue) == 0 && this.txtDiscountDescription.Text != string.Empty)
                    {
                        this.txtDiscountDescription.Focus();
                        return -3;
                    }
                }
            }
            if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForPurchase)
            {
                if (this.btnEditSoHD.Text == "" && this.chkDepartmentConfirm.Checked)
                {
                    bool flag = false;
                    foreach (StockTransactionSumDetail sd in st.Details)
                    {
                        decimal sumQuantity=0;
                        foreach (StockTransactionPurchaseDetail spd in sd.ListPurchaseDetail)
                        {
                            sumQuantity += spd.Quantity;
                        }
                        if (sumQuantity != sd.Quantity)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        return -11;
                }
            }

            if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForPurchase)
            {
                if (this.btnEditSoHD.Text == "" && this.chkDepartmentConfirm.Checked)
                {
                    bool flag = false;
                    foreach (StockTransactionSumDetail sd in st.Details)
                    {
                        decimal sumWrappingCounter = 0;
                        foreach (StockTransactionPurchaseDetail spd in sd.ListPurchaseDetail)
                        {
                            sumWrappingCounter += spd.WrappingCounter;
                        }
                        if (sumWrappingCounter != sd.WrappingCounter)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        return -12;
                }
            }


            return base.ValidateData();
        }
        private void RefreshSaleRequest1()
        {
            Guid discountID = (this.DataSource as StockTransaction).SaleRequestObj.DiscountID;
            (this.DataSource as StockTransaction).SaleRequestObj = new SaleRequestBLL().GetBySaleRequestNo(btnEditSoDH.Text);
            if ((this.DataSource as StockTransaction).SaleRequestObj != null)
            {
                (this.DataSource as StockTransaction).SaleRequestObj.DiscountID = discountID;
                foreach (StockTransactionSumDetail stsd in (this.DataSource as StockTransaction).Details)
                {
                    SaleRequestDetails srd = (this.DataSource as StockTransaction).SaleRequestObj.Details.Search("ItemCode", stsd.ItemCode);
                    if (srd != null)
                    {
                        stsd.PriceOut = srd.SalePrice;
                    }
                }
                //if ((this.DataSource as StockTransaction).SaleRequestObj.InvoiceDate != DateTime.MinValue)
                //{
                //    dateEditInvoice.DateTime = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceDate;
                //}
                //txtDiscount.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.DiscountAmount;
                //txtDiscountDescription.Text = (this.DataSource as StockTransaction).SaleRequestObj.DiscountDescription;
                //txtHTTT.Text = (this.DataSource as StockTransaction).SaleRequestObj.PaymentType;
                //chkSaleDiscount.Checked = (this.DataSource as StockTransaction).SaleRequestObj.Giamgia;
                //txtInvoiceMau.Text = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceMau;
                //txtInvoiceCustomerName.Text = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceCustomerName;



                //if (txtInvoiceMau.Text == string.Empty)
                //{
                //    txtInvoiceMau.Text = "01 GTKT - 3LL";
                //}

                //txtInvoiceSeri.Text = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceSeri;

                //txtInvoiceThueXuat.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.TaxRate;
                //txtBeforeTaxAmount.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.BeforeTaxAmount;
                txtTaxAmount.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.TaxAmount;
                txtInvoiceAmount.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceAmount;
                gridView1.RefreshData();
                gridView2.RefreshData();
            }
            //else
            //{
            //    txtInvoiceMau.Text = "";
            //    txtInvoiceSeri.Text = "";
            //    txtInvoiceThueXuat.EditValue = 0;
            //    txtBeforeTaxAmount.EditValue = 0;
            //    txtTaxAmount.EditValue = 0;
            //    txtDiscount.EditValue = 0;
            //    txtInvoiceAmount.EditValue = 0;
            //    txtDiscountDescription.Text = "";
            //    txtHTTT.Text = "";
            //    chkSaleDiscount.Checked = false;
            //}
        }
        private void RefreshSaleRequest()
        {
            (this.DataSource as StockTransaction).SaleRequestObj = new SaleRequestBLL().GetBySaleRequestNo(btnEditSoDH.Text);
            if ((this.DataSource as StockTransaction).SaleRequestObj != null)
            {
                foreach (StockTransactionSumDetail stsd in (this.DataSource as StockTransaction).Details)
                {
                    SaleRequestDetails srd = (this.DataSource as StockTransaction).SaleRequestObj.Details.Search("ItemCode", stsd.ItemCode);
                    if (srd != null)
                    {
                        stsd.PriceOut = srd.SalePrice;
                    }
                }
                if ((this.DataSource as StockTransaction).SaleRequestObj.InvoiceDate != DateTime.MinValue)
                {
                    dateEditInvoice.DateTime = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceDate;
                }
                txtDiscount.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.DiscountAmount;
                txtDiscountDescription.Text = (this.DataSource as StockTransaction).SaleRequestObj.DiscountDescription;
                txtHTTT.Text = (this.DataSource as StockTransaction).SaleRequestObj.PaymentType;
                chkSaleDiscount.Checked = (this.DataSource as StockTransaction).SaleRequestObj.Giamgia;
                txtInvoiceMau.Text = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceMau;
                txtInvoiceCustomerName.Text = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceCustomerName;
                txtInvoicePersonName.Text = (this.DataSource as StockTransaction).SaleRequestObj.InvoicePersonName;



                //if (txtInvoiceMau.Text == string.Empty)
                //{
                //    txtInvoiceMau.Text = "01 GTKT - 3LL";
                //}

                txtInvoiceSeri.Text = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceSeri;

                txtInvoiceThueXuat.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.TaxRate;
                txtBeforeTaxAmount.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.BeforeTaxAmount;
                txtTaxAmount.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.TaxAmount;
                txtInvoiceAmount.EditValue = (this.DataSource as StockTransaction).SaleRequestObj.InvoiceAmount;
                gridView1.RefreshData();
                gridView2.RefreshData();
            }
            else
            {
                txtInvoiceMau.Text = "";
                txtInvoiceSeri.Text = "";
                txtInvoiceThueXuat.EditValue = 0;
                txtBeforeTaxAmount.EditValue = 0;
                txtTaxAmount.EditValue = 0;
                txtDiscount.EditValue = 0;
                txtInvoiceAmount.EditValue = 0;
                txtDiscountDescription.Text = "";
                txtHTTT.Text = "";
                chkSaleDiscount.Checked = false;
            }
        }
        protected override void BindData()
        {
            string InStock = string.Empty;
            string OutStock = string.Empty;
            if (this.DataSource != null)
            {
                InStock = (this.DataSource as StockTransaction).InStock;
                OutStock = (this.DataSource as StockTransaction).OutStock;
            }
            lookUpOutStock.EditValue = OutStock;
            lookUpInStock.EditValue = InStock;
            if (InStock == string.Empty || InStock == "" || InStock == null)
            {
                this.SetOutStockStatus();
            }
            else
            {
                this.SetInStockStatus();
            }
            if (this.DataSource != null)
            {
                StockTransaction st = (DataSource as StockTransaction);
                //tri
                txtDotnhap.EditValue = st.Dotnhap;

                lookUpEditVesselCode.EditValue = st.VesselCode;
                txtTransportRoute.EditValue = st.TransportRouteCode;
                txtDepartmentDes.EditValue = st.DepartmentDescription;
                //
                txtSoHoaDon.Text = st.SoHoaDon;
                chkDepartmentConfirm.Checked = (st.DepartmentStatus == (byte)enumStockTransactionDepartmentStatus.Confirm);
                lookUpEditForDepartment.EditValue = st.ForDepartment;
                txtShift.Text = st.Shift.ToString();
                if (InStock == string.Empty || InStock == "" || InStock == null)
                {
                    lookUpEditKhoNhan.EditValue = (this.DataSource as StockTransaction).KhoGiaoNhan;
                    txtNguoiNhan.Text = (this.DataSource as StockTransaction).NguoiGiaoNhan;
                }
                else
                {
                    lookUpEditKhoGiao.EditValue = (this.DataSource as StockTransaction).KhoGiaoNhan;
                    txtNguoiGiao.Text = (this.DataSource as StockTransaction).NguoiGiaoNhan;
                }
                lookUpEditDVGiao.EditValue = (this.DataSource as StockTransaction).DVGiao;
                lookUpEditDVNhan.EditValue = (this.DataSource as StockTransaction).DVNhan;
                btnEditSoDH.Text = (this.DataSource as StockTransaction).SoDH;//Sale RequestNo
                dateEditInvoice.DateTime = (this.DataSource as StockTransaction).TransactionDate;
                if (st.Details == null)
                {
                    if (this.EditMode == FormEditMode.ADD) st.Details = new ListBase<StockTransactionSumDetail>();
                    if (this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT) st.Details = new StockTransactionBLL().GetDetailsByTransactionID(st.TransactionID);
                }
                if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForSale)
                {
                    this.RefreshSaleRequest();
                }
                btnEditSoHD.Text = (this.DataSource as StockTransaction).SoHD;
                lookUpEditDVVanChuyen.EditValue = (this.DataSource as StockTransaction).DonviVC;
                txtPTVanChuyen.Text = (this.DataSource as StockTransaction).PTVC;
                txtCTKemTheo.Text = (this.DataSource as StockTransaction).CTKemTheo;
                lookupTransactionTypeCode.EditValue = st.TransactionTypeCode;
                if (lookupTransactionTypeCode.EditValue == null)
                {
                    try
                    {
                        lookupTransactionTypeCode.EditValue = (lookupTransactionTypeCode.Properties.DataSource as ListBase<TransactionType>)[0].TransactionTypeCode;
                    }
                    catch { }
                }
                txtTransactionNo.Text = st.TransactionNo;
                dateEditTransaction.DateTime = st.TransactionDate;
                ChkGetByWeightItem.Checked = st.GetByWeightItems;
                ChkGetByWeightItem.Visible = st.GenID == Guid.Empty;

                chkDepartmentConfirm.Visible = st.GenID == Guid.Empty;
                txtDescription.Text = st.Description;
               
                //if (st.Details == null)
                //{
                //    if (this.EditMode == FormEditMode.ADD) st.Details = new ListBase<StockTransactionSumDetail>();
                //    if (this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT) st.Details = new StockTransactionBLL().GetDetailsByTransactionID(st.TransactionID);
                //}
                if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForSale)
                {
                    if (this.EditMode != FormEditMode.VIEW)
                    {
                        if (txtInvoiceSeri.Text == string.Empty)
                        {
                            if (txtInvoiceSeri.AutoCompleteCustomSource.Count > 0)
                            {
                                txtInvoiceSeri.Text = txtInvoiceSeri.AutoCompleteCustomSource[txtInvoiceSeri.AutoCompleteCustomSource.Count - 1];
                            }
                            //SaleRequests sr = new SaleRequestBLL().GetByCurrentInvoiceSeri();
                            //if (sr != null)
                            //{
                            //   // txtInvoiceSeri.Text = sr.InvoiceSeri;
                            //    txtInvoiceSeri.Text = txtInvoiceSeri.AutoCompleteCustomSource[0];
                            //}
                        }
                        if (txtInvoiceCustomerName.Text == string.Empty)
                        {
                            ListBase<Customer> lstCustomer = lookUpEditDVNhan.Properties.DataSource as ListBase<Customer>;
                            if (lstCustomer != null)
                            {
                                Subject s = lstCustomer.Search("SubjectCode", (this.DataSource as StockTransaction).DVNhan);
                                if (s != null)
                                {
                                    txtInvoiceCustomerName.Text = s.SubjectName;
                                }
                            }
                        }
                    }
                }
                gridControl1.DataSource = st.Details;
            }
            base.BindData();
        }
        public void SetInStockStatus()
        {
            lbOutStock.Visible = false;
            lookUpOutStock.Visible = false;
            txtOutStockName.Visible = false;

            lookUpInStock.Properties.ReadOnly = true;
            lbInStock.Visible = true;
            lookUpInStock.Visible = true;
            txtInStockName.Visible = true;

            lbKhoNhan.Visible = false;
            lookUpEditKhoNhan.Visible = false;
            lbKhoGiao.Visible = true;
            lookUpEditKhoGiao.Visible = true;

            lbDVNhan.Visible = false;
            lookUpEditDVNhan.Visible = false;
            lbDVGiao.Visible = true;
            lookUpEditDVGiao.Visible = true;

            lbDVGiao.Visible = true;
            lookUpEditDVGiao.Visible = true;

            lbSoDH.Visible = false;
            btnEditSoDH.Visible = false;
            lbSoHD.Visible = true;
            btnEditSoHD.Visible = true;

            lbSoHD.Left = lbSoDH.Left;
            btnEditSoHD.Left = btnEditSoDH.Left;

            lbInStock.Left = lbOutStock.Left;
            lookUpInStock.Left = lookUpOutStock.Left;
            txtInStockName.Left = txtOutStockName.Left;
            colQuantityReg.Visible = true;
            colPriceIn.Visible = false;
            colAmountIn.Visible = false;
            colPriceOut.Visible = false;
            colAmountOut.Visible = false;
         
            if (!lookUpOutStock.Visible)
            {
                colOutLocation.Visible = false;
            }
            if (!lookUpInStock.Visible)
            {
                colInLocation.Visible = false;
            }

            lbNguoiGiao.Visible = true;
            txtNguoiGiao.Visible = true;
            lbNguoiNhan.Visible = false;
            txtNguoiNhan.Visible = false;
            lbNguoiGiao.Left = lbNguoiNhan.Left;
            txtNguoiGiao.Left = txtNguoiNhan.Left;

            if (forDepartment == (byte)enumStockTransactionForDepartment.ForPurchase)
            {
                colPriceIn.Visible = true;
                colPriceIn.VisibleIndex = 7;
                colAmountIn.Visible = true;
                colAmountIn.VisibleIndex = 8;
                colQuantityReg.Caption = "Số lượng giao";
            }
        }
        public void SetOutStockStatus()
        {
            lbInStock.Visible = false;
            lookUpInStock.Visible = false;
            txtInStockName.Visible = false;

            lookUpOutStock.Properties.ReadOnly = true;
            lbOutStock.Visible = true;
            lookUpOutStock.Visible = true;
            txtOutStockName.Visible = true;

            lbKhoNhan.Visible = true;
            lookUpEditKhoNhan.Visible = true;
            lbKhoGiao.Visible = false;
            lookUpEditKhoGiao.Visible = false;
            lbKhoNhan.Left = lbKhoGiao.Left;
            lookUpEditKhoNhan.Left = lookUpEditKhoGiao.Left;

            lbDVNhan.Visible = true;
            lookUpEditDVNhan.Visible = true;
            lbDVGiao.Visible = false;
            lookUpEditDVGiao.Visible = false;
            lbDVNhan.Left = lbDVGiao.Left;
            lookUpEditDVNhan.Left = lookUpEditDVGiao.Left;

            lbSoDH.Visible = true;
            btnEditSoDH.Visible = true;
            lbSoHD.Visible = false;
            btnEditSoHD.Visible = false;

            lbNguoiGiao.Visible = false;
            txtNguoiGiao.Visible = false;
            lbNguoiNhan.Visible = true;
            txtNguoiNhan.Visible = true;
            //lbSoDH.Left = lbSoHD.Left;
            //btnEditSoDH.Left = btnEditSoHD.Left;
            //colQuantityReg.Visible = false;
            colPriceIn.Visible = false;
            colAmountIn.Visible = false;
            if (forDepartment == (byte)enumStockTransactionForDepartment.ForSale)
            {
                colPriceOut.Visible = true;
                colPriceOut.VisibleIndex = 7;
                colAmountOut.Visible = true;
                colAmountOut.VisibleIndex = 8;
            }
            else
            {
                colPriceOut.Visible = false;
                colAmountOut.Visible = false;
            }
            //if (forDepartment == (byte)enumStockTransactionForDepartment.ForPurchase)
            //{
            //    colPriceIn.Visible = true;
            //    colAmountIn.Visible = true;
            //}
            
            if (!lookUpOutStock.Visible)
            {
                colOutLocation.Visible = false;
            }
            if (!lookUpInStock.Visible)
            {
                colInLocation.Visible = false;
            }
            btnEdit.Buttons[0].Visible = false;
        }
        public void SetInLocationDataSource(object obj)
        {
            this.LookupInLocation.DataSource = obj;
        }
        public void SetOutLocationDataSource(object obj)
        {
            this.LookupOutLocation.DataSource = obj;
        }
        public void SetItemDataSource(object obj)
        {
            this.LookupItem.DataSource = obj;
            this.LookUpItemName.DataSource = obj;
        }
        public override void RefreshControl()
        {
            if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForPurchase)
            {
                this.colPriceIn.OptionsColumn.ReadOnly = this.EditMode == FormEditMode.VIEW;
                this.colAmountIn.OptionsColumn.ReadOnly = this.EditMode == FormEditMode.VIEW;
                this.btnEditSoHD.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
                //tri
                this.txtDotnhap.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
                this.gridView3.OptionsBehavior.Editable = this.EditMode != FormEditMode.VIEW;
            }
            else
            {
                this.txtDotnhap.Visible = false;
            }

            chkDepartmentConfirm.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtSoHoaDon.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtDepartmentDes.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtDiscount.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            //txtDiscountDescription.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtHTTT.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtInvoiceMau.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtInvoiceSeri.ReadOnly = this.EditMode == FormEditMode.VIEW;
            dateEditInvoice.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtInvoiceThueXuat.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtInvoiceCustomerName.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtInvoicePersonName.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            //txtTaxAmount.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            chkSaleDiscount.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            //if (!this.loadedAutoComplete)
            //{
            //    AutoCompleteUtils.LoadAutoComplete(txtInvoiceSeri);
            //    loadedAutoComplete = true;
            //}
            if (this.EditMode != FormEditMode.VIEW)
            {
                if (txtInvoiceSeri.Text == string.Empty)
                {
                    if (txtInvoiceSeri.AutoCompleteCustomSource.Count > 0)
                    {
                        txtInvoiceSeri.Text = txtInvoiceSeri.AutoCompleteCustomSource[txtInvoiceSeri.AutoCompleteCustomSource.Count - 1];
                    }
                    //SaleRequests sr = new SaleRequestBLL().GetByCurrentInvoiceSeri();
                    //if (sr != null)
                    //{
                    //   // txtInvoiceSeri.Text = sr.InvoiceSeri;
                    //    txtInvoiceSeri.Text = txtInvoiceSeri.AutoCompleteCustomSource[0];
                    //}
                }
                if (txtInvoiceCustomerName.Text == string.Empty)
                {
                    ListBase<Customer> lstCustomer = lookUpEditDVNhan.Properties.DataSource as ListBase<Customer>;
                    if (lstCustomer != null)
                    {
                        Subject s = lstCustomer.Search("SubjectCode", (this.DataSource as StockTransaction).DVNhan);
                        if (s != null)
                        {
                            txtInvoiceCustomerName.Text = s.SubjectName;
                        }
                    }
                }
            }
            if (txtInvoiceMau.Text == string.Empty && this.EditMode != FormEditMode.VIEW)
            {
                txtInvoiceMau.Text = "01GTKT3/001"; //"01 GTKT - 3LL";
            }
            //if(this.EditMode == FormEditMode.

            txtSoHoaDon.BackColor = lbInStock.BackColor;
            lookUpInStock.BackColor = lbInStock.BackColor;
            lookupTransactionTypeCode.BackColor = lbInStock.BackColor;
            lookUpOutStock.BackColor = lbInStock.BackColor;
            txtTransactionNo.BackColor = lbInStock.BackColor;
            dateEditTransaction.BackColor = lbInStock.BackColor;
            txtDescription.BackColor = lbInStock.BackColor;
            lookUpEditForDepartment.BackColor = lbInStock.BackColor;

            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            txtShift.BackColor = lbShift.BackColor;
            lookUpEditKhoGiao.BackColor = lbShift.BackColor;
            lookUpEditKhoNhan.BackColor = lbShift.BackColor;
            lookUpEditDVGiao.BackColor = lbShift.BackColor;
            lookUpEditDVNhan.BackColor = lbShift.BackColor;
            btnEditSoDH.BackColor = lbShift.BackColor;
            btnEditSoHD.BackColor = lbShift.BackColor;
            lookUpEditDVVanChuyen.BackColor = lbShift.BackColor;
            txtPTVanChuyen.BackColor = lbShift.BackColor;
            txtCTKemTheo.BackColor = lbShift.BackColor;
            lookUpInStock.BackColor = lbInStock.BackColor;
            lookUpOutStock.BackColor = lbInStock.BackColor;
                    
            if (this.DataSource == null)
            {
                StockTransaction st = (dataSource as StockTransaction);
                lookUpEditForDepartment.ItemIndex = -1;
                txtShift.Text = "";
                txtStatus.Text = "";

                txtTransactionNo.Text = "";
                ChkGetByWeightItem.Checked = false;
                txtDescription.Text = "";

                gridControl1.DataSource = null;
                lookUpEditKhoGiao.ItemIndex = -1;
                lookUpEditKhoNhan.ItemIndex = -1;
                lookUpEditDVGiao.ItemIndex = -1;
                lookUpEditDVNhan.ItemIndex = -1;
                btnEditSoDH.Text = "";
                btnEditSoHD.Text = "";
                lookUpEditDVVanChuyen.ItemIndex = -1;
                txtPTVanChuyen.Text = "";
                txtCTKemTheo.Text = "";
            }
            base.RefreshControl();
        }

        private void lookupTransactionTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            if (lookupTransactionTypeCode.EditValue != null && lookupTransactionTypeCode.Properties.DataSource != null)
            {
                try
                {
                    TransactionType tt = (lookupTransactionTypeCode.Properties.DataSource as ListBase<TransactionType>).Search("TransactionTypeCode", lookupTransactionTypeCode.EditValue.ToString());
                    txtTransactionTypeCode.Text = tt.Description;
                }
                catch
                {
                    txtTransactionTypeCode.Text = "";
                }

            }
            else
            {
                txtTransactionTypeCode.Text = "";
            }
        }
        public void SaveAutoCompleteForTextBox()
        {
            AutoCompleteUtils.SaveAutoComplete(txtInvoiceSeri);
        }

        private void txtSoHoaDon_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                txtInvoiceMau.Text = txtInvoiceMau.Text.Trim();
                SaleRequests obj = new SaleRequestBLL().GetItemMaxInvoiceNo(txtInvoiceSeri.Text);
                if (obj != null)
                {
                    string invoiceNo = obj.InvoiceNo;
                    if (invoiceNo != txtSoHoaDon.Text)
                    {
                        try
                        {
                            decimal d = Convert.ToDecimal(invoiceNo);
                            d += 1;
                            invoiceNo = d.ToString();
                            while (invoiceNo.Length < 8)
                            {
                                invoiceNo = "0" + invoiceNo;
                            }
                            txtSoHoaDon.Text = invoiceNo;
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    txtSoHoaDon.Text = "00000001";
                }
            }
        }

        private void btnEditSoHD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode == FormEditMode.VIEW)
                return;
            ListBase<PurchaseContract> list = new PurchaseContractBLL().GetDynamic("VendorCode='" + this.lookUpEditDVGiao.EditValue.ToString() + "' and IsFinished=0", "ContractDate,ContractNo");
            string[] fields = { "ContractNo", "ContractDate", "Description"};
            string[] headers = { "Số hợp đồng", "Ngày", "Ghi chú" };
            PurchaseContract pc = (FormSearch.ShowSearch(list, fields, headers) as PurchaseContract);
            if (pc != null)
            {
                string vesselCode = this.lookUpEditVesselCode.EditValue.ToString();
                this.btnEditSoHD.EditValue = pc.ContractNo;
                ListBase<PurchaseContractDetail> lstContractDetail = new PurchaseContractBLL().GetDetailByContractNo(pc.ContractNo);
                foreach (StockTransactionSumDetail stsd in (this.DataSource as StockTransaction).Details)
                {
                    stsd.PriceIn = 0;
                    foreach (PurchaseContractDetail pcd in lstContractDetail)
                    {
                        if (pcd.ItemCode == stsd.ItemCode && pcd.VesselCode == vesselCode)
                        {
                            stsd.PriceIn = pcd.Price;
                            break;
                        }
                    }

                    //PurchaseContractDetail pcd = lstContractDetail.Search("ItemCode", stsd.ItemCode);
                    //if (pcd != null)
                    //    stsd.PriceIn = pcd.Price;
                }
                this.gridView1.RefreshData();

            }
        }

        private void gridView3_KeyDown(object sender, KeyEventArgs e)
        {

            if (this.gridView3.RowCount > 0 && this.gridView3.OptionsBehavior.Editable == true)
            {
                DevExpress.XtraGrid.Views.Grid.GridView v = this.gridView1.GetDetailView(this.gridView1.FocusedRowHandle, 1) as DevExpress.XtraGrid.Views.Grid.GridView;
                if (e.KeyCode == Keys.Delete)
                    v.DeleteRow(v.FocusedRowHandle);
            }
        }

        private void txtPurchaseNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.EditMode == FormEditMode.VIEW)
                    return;
                ListBase<PurchaseContract> list = new PurchaseContractBLL().GetDynamic("VendorCode='" + this.lookUpEditDVGiao.EditValue.ToString() + "' and IsFinished=0", "ContractDate,ContractNo");
                string[] fields = { "ContractNo", "ContractDate", "Description" };
                string[] headers = { "Số hợp đồng", "Ngày", "Ghi chú" };
                PurchaseContract pc = (FormSearch.ShowSearch(list, fields, headers) as PurchaseContract);
                if (pc != null)
                {
                    //int iRel = this.gridView1.GetRelationIndex(this.gridView1.FocusedRowHandle, "ListPurchaseDetail");
                    //GridView v = this.gridView1.GetDetailView(this.gridView1.FocusedRowHandle, iRel) as GridView;
                    GridView v = this.gridControl1.FocusedView as GridView;
                    StockTransactionPurchaseDetail d = v.GetRow(v.FocusedRowHandle) as StockTransactionPurchaseDetail;
                    //StockTransactionPurchaseDetail d = this.gridView3.GetRow(this.gridView3.FocusedRowHandle) as StockTransactionPurchaseDetail;
                    if (d == null)
                    {
                        if (v.IsNewItemRow(v.FocusedRowHandle))
                            v.AddNewRow();
                        d = v.GetRow(v.FocusedRowHandle) as StockTransactionPurchaseDetail;
                    }

                    if (d != null)
                    {
                        d.PONo = pc.ContractNo;
                        ListBase<PurchaseContractDetail> lstContractDetail = new PurchaseContractBLL().GetDetailByContractNo(pc.ContractNo);
                        if (d.ItemCode == "")
                            foreach (StockTransactionSumDetail stsd in (this.DataSource as StockTransaction).Details)
                                foreach (StockTransactionPurchaseDetail stpd in stsd.ListPurchaseDetail)
                                    stpd.ItemCode = stsd.ItemCode;

                        string vesselCode = this.lookUpEditVesselCode.EditValue.ToString();
                        d.Price = 0;
                        foreach (PurchaseContractDetail pcd in lstContractDetail)
                        {
                            if (d.ItemCode == pcd.ItemCode && pcd.VesselCode == vesselCode)
                            {
                                d.Price = pcd.Price;
                                break;
                            }
                        }
                        //PurchaseContractDetail pcd = lstContractDetail.Search("ItemCode", d.ItemCode);
                        //if (pcd != null)
                        //    d.Price = pcd.Price;
                        v.RefreshRow(v.FocusedRowHandle);
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs(this.Name, "txtPurchaseNo_ButtonClick", excp.Message);
            }
        }

        private void btnEditSoHD_EditValueChanged(object sender, EventArgs e)
        {
            if (this.ForDepartment == (byte)enumStockTransactionForDepartment.ForPurchase)
                this.gridView1.OptionsDetail.EnableMasterViewMode = (this.btnEditSoHD.Text == "");
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

                (this.DataSource as StockTransaction).SaleRequestObj.DiscountID = (frm.SearchResult as CustomerDiscountList).DiscountID;
            }
        }
    }
}
