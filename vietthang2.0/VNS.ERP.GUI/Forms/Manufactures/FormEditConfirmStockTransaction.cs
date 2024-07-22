using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.ERP.Data.Sales;
using VNS.Common;
using VNS.Windows;
using VNS.ERP.GUI.Accounting;

namespace VNS.ERP.GUI
{
    public partial class FormEditConfirmStockTransaction : FormEditBase
    {
        DepartmentConfirmSTBLL obj = new DepartmentConfirmSTBLL();
        private byte forDepartment;
        public byte ForDepartment
        {
            get { return forDepartment; }
            set 
            { 
                forDepartment = value;
                this.ucConfirmStockTransaction1.ForDepartment = value;
               // button1.Visible = false;//open next comment to use this button
                button1.Visible = value == (byte)enumStockTransactionForDepartment.ForSale;
                tableLayoutPanel1.Visible = value == (byte)enumStockTransactionForDepartment.ForSale;
                if (value != (byte)enumStockTransactionForDepartment.ForSale)
                {
                    this.ucConfirmStockTransaction1.Height += tableLayoutPanel1.Height;
                    //this.ucConfirmStockTransaction1.BringToFront();
                    //this.Height = this.Height - tableLayoutPanel1.Height;
                }
            }
        }
        public FormEditConfirmStockTransaction()
        {
            InitializeComponent();
            this.ucConfirmStockTransaction1.SetLookupEditInStockDataSource(new StockBLL().GetAll());
            this.ucConfirmStockTransaction1.SetLookupEditOutStockDataSource(new StockBLL().GetAll());
            this.ucConfirmStockTransaction1.SetItemDataSource(new ItemBLL().GetAll());
            ucConfirmStockTransaction1.SetLookupEditForDepartmentDataSource(EnumDisplays.GetListenumStockTransactionForDepartment());
            ListBase<Stock> LookupEditKhoGiaoDSr = new StockBLL().GetAll();
            LookupEditKhoGiaoDSr.Add(new Stock());
            ListBase<Stock> LookupEditKhoNhanDSr = new StockBLL().GetAll();
            LookupEditKhoNhanDSr.Add(new Stock());
            this.ucConfirmStockTransaction1.SetLookupEditKhoGiaoDSr(LookupEditKhoGiaoDSr);
            this.ucConfirmStockTransaction1.SetLookupEditKhoNhanDSr(LookupEditKhoNhanDSr);
            this.ucConfirmStockTransaction1.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetAll());
            ListBase<Vendor> lstVendor1 = new VendorBLL().GetAll();
            lstVendor1.Add(new Vendor());
            ListBase<Customer> lstVendor2 = new CustomerBLL().GetAll();
            lstVendor2.Add(new Customer());
            ListBase<Vendor> lstTransport = new VendorBLL().GetForVanchuyen(); //new TransportBLL().GetAll();
            lstTransport.Add(new Vendor());
            this.ucConfirmStockTransaction1.SetLookupEditDVGiaoDSr(lstVendor1);
            this.ucConfirmStockTransaction1.SetLookupEditDVNhanDSr(lstVendor2);
            this.ucConfirmStockTransaction1.SetLookupEditDVVanChuyenDSr(lstTransport);
            this.Business = obj;
        }
        public FormEditConfirmStockTransaction(string text)
        {
            InitializeComponent();
            this.Text = text;
            this.ucConfirmStockTransaction1.SetLookupEditInStockDataSource(new StockBLL().GetAll());
            this.ucConfirmStockTransaction1.SetLookupEditOutStockDataSource(new StockBLL().GetAll());
            this.ucConfirmStockTransaction1.SetItemDataSource(new ItemBLL().GetAll());
            ucConfirmStockTransaction1.SetLookupEditForDepartmentDataSource(EnumDisplays.GetListenumStockTransactionForDepartment());
            ListBase<Stock> LookupEditKhoGiaoDSr = new StockBLL().GetAll();
            LookupEditKhoGiaoDSr.Add(new Stock());
            ListBase<Stock> LookupEditKhoNhanDSr = new StockBLL().GetAll();
            LookupEditKhoNhanDSr.Add(new Stock());
            this.ucConfirmStockTransaction1.SetLookupEditKhoGiaoDSr(LookupEditKhoGiaoDSr);
            this.ucConfirmStockTransaction1.SetLookupEditKhoNhanDSr(LookupEditKhoNhanDSr);
            this.ucConfirmStockTransaction1.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetAll());
            ListBase<Vendor> lstVendor1 = new VendorBLL().GetAll();
            lstVendor1.Add(new Vendor());
            ListBase<Customer> lstVendor2 = new CustomerBLL().GetAll();
            lstVendor2.Add(new Customer());
            ListBase<Vendor> lstTransport = new VendorBLL().GetForVanchuyen(); //new TransportBLL().GetAll();
            lstTransport.Add(new Vendor());
            this.ucConfirmStockTransaction1.SetLookupEditDVGiaoDSr(lstVendor1);
            this.ucConfirmStockTransaction1.SetLookupEditDVNhanDSr(lstVendor2);
            this.ucConfirmStockTransaction1.SetLookupEditDVVanChuyenDSr(lstTransport);
            this.Business = obj;
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            base.RefreshButtons();
            //btnPrint.Enabled = this.EditMode == FormEditMode.VIEW && this.CurrentItem != null;
            button1.Enabled = this.EditMode == FormEditMode.VIEW && this.CurrentItem != null && (this.CurrentItem as StockTransaction).TransactionTypeCode == "X21";
            btnPrintInvoice.Enabled = btnPrintInvoice2.Enabled = this.EditMode == FormEditMode.VIEW && this.CurrentItem != null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.CurrentItem == null)
            {
                MessageBox.Show(this.GetTextMessage("ErrorButton1Click-2", "Chưa có phiếu"));
                return;
            }
            if (this.ucConfirmStockTransaction1.TransactionTypeCode == null)
            {
                MessageBox.Show(this.GetTextMessage("ErrorButton1Click-1", "Chưa xác định mã N/X"));
            }
            else
            {
                bool createNew = false;
                StockTransaction t1 = new StockTransactionBLL().GetByTransactionID((this.CurrentItem as StockTransaction).TransactionID);
                (this.CurrentItem as StockTransaction).AccountTransactionID = t1.AccountTransactionID;
                if ((this.CurrentItem as StockTransaction).IsAccounted)
                {
                    FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction(false);
                    enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("", "Phiếu đã được định khoản!"), "Thông báo");
                    FormEditAccountTransactionStock f = null;
                    if (answer == enumFormMsgExistAccTransDialogResult.OpenView || answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                        //f.StrSpecialType = enumAccountSpecialType.KETCHUYENXUATTHANHPHAMBAN.ToString();
                        f.StockTransactionTypeCode = this.ucConfirmStockTransaction1.TransactionTypeCode.ToString();
                        SetFormPrivilege(f);
                        ListBase<AccountTransactionStockNew> lst = new ListBase<AccountTransactionStockNew>();

                        AccountTransactionStockNew t = new AccountTransactionStockNewBLL().GetByStockTransactionID((this.CurrentItem as StockTransaction).TransactionID);
                        t.Description = "";
                        if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                        {
                            StockTransaction st = this.CurrentItem as StockTransaction;
                            SaleRequests sr = st.SaleRequestObj;
                            t.AccTransactionStock.InvoiceMau = sr.InvoiceMau;
                            t.AccTransactionStock.DiscountAmount = sr.DiscountAmount;
                            t.AccTransactionStock.InvoiceSeri = sr.InvoiceSeri;
                            t.AccTransactionStock.DiscountDescription = sr.DiscountDescription;
                            t.AccTransactionStock.InvoiceSo = sr.InvoiceNo;
                            t.AccTransactionStock.InvoiceNgay = sr.InvoiceDate;
                            t.AccTransactionStock.PaymentType = sr.PaymentType;
                            t.AccTransactionStock.Giamgia = sr.Giamgia;
                            t.AccTransactionStock.InvoiceThuexuat = sr.TaxRate;
                            t.AccTransactionStock.TaxAmount = sr.TaxAmount;
                        }
                        lst.Add(t);
                        f.DataSource = lst;
                        f.StrObject = (this.CurrentItem as StockTransaction).OutStock;
                        if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                        {
                            f.EditItem();
                        }
                        f.ShowDialog();
                        if (t.AccTransactionStock.LstAccountStock.Count == 0)
                        {
                            StockTransaction st = this.CurrentItem as StockTransaction;
                            st.AccountTransactionID = Guid.Empty;
                        }
                    }
                    if (answer == enumFormMsgExistAccTransDialogResult.DeleteAndCreat)
                    {
                        if (MessageBox.Show(this.GetTextMessage("", "Bạn có đồng ý xoá phiếu định khoản cũ để tạo lại (Y/N?)"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            AccountTransactionStockNew t = new AccountTransactionStockNewBLL().GetByStockTransactionID((this.CurrentItem as StockTransaction).TransactionID);
                            if((new AccountTransactionStockNewBLL().Delete(t))!=0)
                            {
                                MessageBox.Show(this.GetTextMessage("", "Xoá phiếu định khoản không thành công!"));
                            }
                            else
                            {
                                (this.CurrentItem as StockTransaction).AccountTransactionID = Guid.Empty;
                                createNew = true;
                            }
                        }
                    }
                }
                if (!(this.CurrentItem as StockTransaction).IsAccounted || createNew)
                {
                    if ((this.CurrentItem as StockTransaction).DepartmentStatus == (byte)enumStockTransactionDepartmentStatus.Confirm)
                    {
                        FormEditAccountTransactionStock f = null;
                        f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString(), true);
                        f.StockTransactionTypeCode = this.ucConfirmStockTransaction1.TransactionTypeCode.ToString();
                        //f.StrSpecialType = enumAccountSpecialType.KETCHUYENXUATTHANHPHAMBAN.ToString();
                        SetFormPrivilege(f);
                        f.DataSource = new ListBase<AccountTransactionStockNew>();
                        f.AddNewItem();
                        System.Collections.ArrayList lst = new System.Collections.ArrayList();
                        lst.Add((this.CurrentItem as StockTransaction).Clone());
                        AccountTransactionStockNew t = f.CurrentItem as AccountTransactionStockNew;
                        f.StrObject = (this.CurrentItem as StockTransaction).OutStock;
                       // t.SpecsialType = enumAccountSpecialType.KETCHUYENXUATTHANHPHAMBAN.ToString();
                        t.SubjectCode1 = f.StrObject;
                        new AccountTransactionStockNewBLL().GetDataFromStockTransaction(lst, ref t, enumAccountTransactionType.STOCKOUT.ToString(), f.StockTransactionTypeCode);
                        t.Description = "";
                        t.AccTransactionStock.Donvi = (this.CurrentItem as StockTransaction).SaleRequestObj.InvoiceCustomerName;
                       // f.Accounted();
                        f.ShowDialog();
                        if (f.CurrentItem != null && t.AccTransactionStock.LstAccountStock.Count > 0)
                        {
                            StockTransaction st = this.CurrentItem as StockTransaction;
                            st.AccountTransactionID = Guid.NewGuid();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this.GetTextMessage("ErrorButton1Click-3", "Bạn phải xác nhận phiếu trước khi định khoản!"));
                    }
                }
               
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            #region old
            //StockTransaction st = this.CurrentItem as StockTransaction;
            //if (st.DepartmentStatus != (byte)enumStockTransactionDepartmentStatus.Confirm)
            //{
            //    MessageBox.Show(this.GetTextMessage("CanNotPrintInvoice", "Phiếu chưa được xác nhận, không thể in hóa đơn!"));
            //    return;
            //}
            //DataTable dt = new StockTransactionBLL().GetDetailForReportSaleInvoce((this.CurrentItem as StockTransaction).TransactionID);
            //SaleRequests sr = st.SaleRequestObj;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    SaleRequestDetails srd = sr.Details.Search("ItemCode", dr["ItemCode"].ToString());
            //    if (srd != null)
            //    {
            //        dr["Price"] = srd.SalePrice;
            //        dr["Amount"] = Math.Round(srd.SalePrice * Convert.ToDecimal(dr["Quantity"]),0);
            //    }
            //}
            //while (dt.Rows.Count < 13)
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["STT"] = DBNull.Value;
            //    dr["ItemCode"] = DBNull.Value;
            //    dr["ItemName"] = DBNull.Value;
            //    dr["Unit"] = DBNull.Value;
            //    dr["Quantity"] = DBNull.Value;
            //    dr["Price"] = DBNull.Value;
            //    dr["Amount"] = DBNull.Value;
            //    if (dt.Rows.Count == 11)
            //    {
            //        dr["ItemName"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
            //        dr["Amount"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
            //    }
            //    dt.Rows.Add(dr);
                
            //}
            //RpSaleInvoice rp = new RpSaleInvoice();
            //RpSaleInvoice.Params pr;
            //pr.Header = this.CurrentItem as StockTransaction;
            //rp.RpParams = pr;
            //rp.DataSource = dt;
            //rp.BindData();
            //rp.ShowPreviewDialog();
            #endregion
            StockTransaction st = this.CurrentItem as StockTransaction;
            if (st.DepartmentStatus != (byte)enumStockTransactionDepartmentStatus.Confirm)
            {
                MessageBox.Show(this.GetTextMessage("CanNotPrintInvoice", "Phiếu chưa được xác nhận, không thể in hóa đơn!"));
                return;
            }
            if (!st.IsAccounted)
            {
                MessageBox.Show(this.GetTextMessage("CanNotPrintInvoice", "Phiếu chưa được định khoản, không thể in hóa đơn!"));
                return;
            }
            DataTable dt = new StockTransactionBLL().GetDetailForReportSaleInvoce((this.CurrentItem as StockTransaction).TransactionID);
            SaleRequests sr = st.SaleRequestObj;
            foreach (DataRow dr in dt.Rows)
            {
                SaleRequestDetails srd = sr.Details.Search("ItemCode", dr["ItemCode"].ToString());
                if (srd != null)
                {
                    dr["Price"] = srd.SalePrice;
                    dr["Amount"] = Math.Round(srd.SalePrice * Convert.ToDecimal(dr["Quantity"]), 0, MidpointRounding.AwayFromZero);
                }
            }
            while (dt.Rows.Count < 8)
            {
                DataRow dr = dt.NewRow();
                dr["STT"] = DBNull.Value;
                dr["ItemCode"] = DBNull.Value;
                dr["ItemName"] = DBNull.Value;
                dr["Unit"] = DBNull.Value;
                dr["Quantity"] = DBNull.Value;
                dr["Price"] = DBNull.Value;
                dr["Amount"] = DBNull.Value;
                //if (dt.Rows.Count == 8)
                //{
                //    dr["ItemName"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
                //    dr["Amount"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
                //}
                dt.Rows.Add(dr);

            }
            RpSaleInvoice5 rp = new RpSaleInvoice5();
            RpSaleInvoice5.Params pr;
            pr.Header = this.CurrentItem as StockTransaction;
            pr.CKDescription = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
            pr.CKAmount = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
            pr.SmallSize = true;
            pr.hddt = this.chkHddt.Checked;
            pr.branch = this.lookUpHddtStock.EditValue.ToString();
            rp.RpParams = pr;
            rp.DataSource = dt;
            rp.BindData();
            rp.ShowPreviewDialog();
        }

        private void FormEditConfirmStockTransaction_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.lookUpHddtStock.Properties.DataSource = new BranchBLL().GetAll();
            this.lookUpHddtStock.ItemIndex = 0;
        }

        private void FormEditConfirmStockTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ucConfirmStockTransaction1.SaveAutoCompleteForTextBox();

        }

        private void btnPrintInvoice2_Click(object sender, EventArgs e)
        {
            #region old
            //StockTransaction st = this.CurrentItem as StockTransaction;
            //if (st.DepartmentStatus != (byte)enumStockTransactionDepartmentStatus.Confirm)
            //{
            //    MessageBox.Show(this.GetTextMessage("CanNotPrintInvoice", "Phiếu chưa được xác nhận, không thể in hóa đơn!"));
            //    return;
            //}
            //DataTable dt = new StockTransactionBLL().GetDetailForReportSaleInvoce((this.CurrentItem as StockTransaction).TransactionID);
            //SaleRequests sr = st.SaleRequestObj;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    SaleRequestDetails srd = sr.Details.Search("ItemCode", dr["ItemCode"].ToString());
            //    if (srd != null)
            //    {
            //        dr["Price"] = srd.SalePrice;
            //        dr["Amount"] = Math.Round(srd.SalePrice * Convert.ToDecimal(dr["Quantity"]), 0);
            //    }
            //}
            //while (dt.Rows.Count < 8)
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["STT"] = DBNull.Value;
            //    dr["ItemCode"] = DBNull.Value;
            //    dr["ItemName"] = DBNull.Value;
            //    dr["Unit"] = DBNull.Value;
            //    dr["Quantity"] = DBNull.Value;
            //    dr["Price"] = DBNull.Value;
            //    dr["Amount"] = DBNull.Value;
            //    //if (dt.Rows.Count == 8)
            //    //{
            //    //    dr["ItemName"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
            //    //    dr["Amount"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
            //    //}
            //    dt.Rows.Add(dr);

            //}
            //RpSaleInvoice2 rp = new RpSaleInvoice2();
            //RpSaleInvoice2.Params pr;
            //pr.Header = this.CurrentItem as StockTransaction;
            //pr.CKDescription = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
            //pr.CKAmount = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
            //rp.RpParams = pr;
            //rp.DataSource = dt;
            //rp.BindData();
            //rp.ShowPreviewDialog();
            #endregion
            StockTransaction st = this.CurrentItem as StockTransaction;
            if (st.DepartmentStatus != (byte)enumStockTransactionDepartmentStatus.Confirm)
            {
                MessageBox.Show(this.GetTextMessage("CanNotPrintInvoice", "Phiếu chưa được xác nhận, không thể in hóa đơn!"));
                return;
            }
            if (!st.IsAccounted)
            {
                MessageBox.Show(this.GetTextMessage("CanNotPrintInvoice", "Phiếu chưa được định khoản, không thể in hóa đơn!"));
                return;
            }
            DataTable dt = new StockTransactionBLL().GetDetailForReportSaleInvoce((this.CurrentItem as StockTransaction).TransactionID);
            SaleRequests sr = st.SaleRequestObj;
            foreach (DataRow dr in dt.Rows)
            {
                SaleRequestDetails srd = sr.Details.Search("ItemCode", dr["ItemCode"].ToString());
                if (srd != null)
                {
                    dr["Price"] = srd.SalePrice;
                    dr["Amount"] = Math.Round(srd.SalePrice * Convert.ToDecimal(dr["Quantity"]), 0, MidpointRounding.AwayFromZero);
                }

            }
            while (dt.Rows.Count < 8)
            {
                DataRow dr = dt.NewRow();
                dr["STT"] = DBNull.Value;
                dr["ItemCode"] = DBNull.Value;
                dr["ItemName"] = DBNull.Value;
                dr["Unit"] = DBNull.Value;
                dr["Quantity"] = DBNull.Value;
                dr["Price"] = DBNull.Value;
                dr["Amount"] = DBNull.Value;
                //if (dt.Rows.Count == 8)
                //{
                //    dr["ItemName"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
                //    dr["Amount"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
                //}
                dt.Rows.Add(dr);

            }
            RpSaleInvoice5 rp = new RpSaleInvoice5();
            RpSaleInvoice5.Params pr;
            pr.Header = this.CurrentItem as StockTransaction;
            pr.CKDescription = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
            pr.CKAmount = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
            pr.SmallSize = false;
            pr.hddt = this.chkHddt.Checked;
            pr.branch = this.lookUpHddtStock.EditValue.ToString();
            rp.RpParams = pr;
            rp.DataSource = dt;
            rp.BindData();
            rp.ShowPreviewDialog();
        }

        private void btnPrintInvoice3_Click(object sender, EventArgs e)
        {
            StockTransaction st = this.CurrentItem as StockTransaction;
            //if (st.DepartmentStatus != (byte)enumStockTransactionDepartmentStatus.Confirm)
            //{
            //    MessageBox.Show(this.GetTextMessage("CanNotPrintInvoice", "Phiếu chưa được xác nhận, không thể in hóa đơn!"));
            //    return;
            //}
            DataTable dt = new StockTransactionBLL().GetDetailForReportSaleInvoce((this.CurrentItem as StockTransaction).TransactionID);
            SaleRequests sr = st.SaleRequestObj;
            foreach (DataRow dr in dt.Rows)
            {
                SaleRequestDetails srd = sr.Details.Search("ItemCode", dr["ItemCode"].ToString());
                if (srd != null)
                {
                    dr["Price"] = srd.SalePrice;
                    dr["Amount"] = Math.Round(srd.SalePrice * Convert.ToDecimal(dr["Quantity"]), 0);
                }
            }
            while (dt.Rows.Count < 8)
            {
                DataRow dr = dt.NewRow();
                dr["STT"] = DBNull.Value;
                dr["ItemCode"] = DBNull.Value;
                dr["ItemName"] = DBNull.Value;
                dr["Unit"] = DBNull.Value;
                dr["Quantity"] = DBNull.Value;
                dr["Price"] = DBNull.Value;
                dr["Amount"] = DBNull.Value;
                //if (dt.Rows.Count == 8)
                //{
                //    dr["ItemName"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
                //    dr["Amount"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
                //}
                dt.Rows.Add(dr);

            }
            RpSaleOutNB rp = new RpSaleOutNB();
            RpSaleOutNB.Params pr = new RpSaleOutNB.Params();
            pr.Header = this.CurrentItem as StockTransaction;
            //pr.CKDescription = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
            //pr.CKAmount = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
            ListBase<Stock> lstStock = new StockBLL().GetAll();
            Stock st1 = lstStock.Search("StockCode", pr.Header.OutStock);
            if (st1 != null)
                pr.Khoxuat = st1.StockName;
            pr.SmallSize = false;
            rp.RpParams = pr;
            rp.DataSource = dt;
            rp.BindData();
            rp.ShowPreviewDialog();
        }

        private void btnPrintInvoice4_Click(object sender, EventArgs e)
        {
            StockTransaction st = this.CurrentItem as StockTransaction;
            if (st.DepartmentStatus != (byte)enumStockTransactionDepartmentStatus.Confirm)
            {
                MessageBox.Show(this.GetTextMessage("CanNotPrintInvoice", "Phiếu chưa được xác nhận, không thể in hóa đơn!"));
                return;
            }
            DataTable dt = new StockTransactionBLL().GetDetailForReportSaleInvoce((this.CurrentItem as StockTransaction).TransactionID);
            SaleRequests sr = st.SaleRequestObj;
            foreach (DataRow dr in dt.Rows)
            {
                SaleRequestDetails srd = sr.Details.Search("ItemCode", dr["ItemCode"].ToString());
                if (srd != null)
                {
                    dr["Price"] = srd.SalePrice;
                    dr["Amount"] = Math.Round(srd.SalePrice * Convert.ToDecimal(dr["Quantity"]), 0);
                }
            }
            while (dt.Rows.Count < 8)
            {
                DataRow dr = dt.NewRow();
                dr["STT"] = DBNull.Value;
                dr["ItemCode"] = DBNull.Value;
                dr["ItemName"] = DBNull.Value;
                dr["Unit"] = DBNull.Value;
                dr["Quantity"] = DBNull.Value;
                dr["Price"] = DBNull.Value;
                dr["Amount"] = DBNull.Value;
                //if (dt.Rows.Count == 8)
                //{
                //    dr["ItemName"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
                //    dr["Amount"] = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;
                //}
                dt.Rows.Add(dr);

            }
            RpSaleInvoice3 rp = new RpSaleInvoice3();
            RpSaleInvoice3.Params pr;
            pr.Header = this.CurrentItem as StockTransaction;
            pr.CKDescription = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountDescription;
            pr.CKAmount = (this.CurrentItem as StockTransaction).SaleRequestObj.DiscountAmount;

            pr.SmallSize = true;
            rp.RpParams = pr;
            rp.DataSource = dt;
            rp.BindData();
            rp.ShowPreviewDialog();
        }
    }
}