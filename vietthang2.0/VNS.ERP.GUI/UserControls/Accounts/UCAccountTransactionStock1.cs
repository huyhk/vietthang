using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.ERP.Data.Sales;
using VNS.Windows.Forms;
using VNS.Common;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCAccountTransactionStock1 : UCAccountTransaction
    {
        public delegate void SelectSTFail();
        public event SelectSTFail OnSelectSTFail;
        bool cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged=true;
        private string stockTransactionTypeCode;
        public string StockTransactionTypeCode
        {
            get { return stockTransactionTypeCode; }
            set 
            { 
                stockTransactionTypeCode = value;
                this.ucAccTransStock.StockTransactionTypeCode = value;
            }
        }
        protected override string GetStrBrandCode()
        {
            string s = base.GetStrBrandCode();
            if (this.IsInStockForBuy)
            {
                s = "NM.1SD";
            }
            return s;
        }
        private bool IsInStockForBuy
        {
            get 
            {
                return this.stockTransactionTypeCode == enumStockTransactionType.N11.ToString() || this.stockTransactionTypeCode == enumStockTransactionType.N31.ToString();
            }
        }
        public override string StrObject
        {
            get
            {
                return base.StrObject;
            }
            set
            {
                base.StrObject = value;
                this.ucAccTransStock.StrObject = value;
            }
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                if (this.StockTransactionTypeCode == enumStockTransactionType.N11.ToString())//nhập nguyên liệu mua
                {
                    this.cboSubjectcode2.Properties.DataSource = new VendorBLL().GetAll();
                }
                else
                {
                    //Xuất nguyên liệu bán và xuất thành phẩm bán
                    if (this.StockTransactionTypeCode == enumStockTransactionType.X14.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        this.cboSubjectcode2.Properties.DataSource = new CustomerBLL().GetAll();
                    }
                    else
                    {
                        ListBase<Subject> lst = new SubjectBLL().GetListBaseSubjectOutSide();
                        lst.Add(new Subject());
                        this.cboSubjectcode2.Properties.DataSource = lst;
                    }
                }
            }
        }
        public override string AccountTransactionTypeCode
        {
            get
            {
                return base.AccountTransactionTypeCode;
            }
            set
            {
                base.AccountTransactionTypeCode = value;
                this.ucAccTransStock.AccountTransactionTypeCode = value;
            }
        }
      
        public UCAccountTransactionStock1()
        {
            InitializeComponent();
           
            ucAccTransStock.OnbtnGetFromStockTransaction_Click += new UCAccountTransactionStock.btnGetFromStockTransaction_Click(ucAccTransStock_OnbtnGetFromStockTransaction_Click);
            ucAccTransStock.OnchkGetFromStockTransaction_CheckedChanged += new UCAccountTransactionStock.chkGetFromStockTransaction_CheckedChanged(ucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged);
            ucAccTransStock.OnAccounted += new UCAccountTransactionStock.Accounted(ucAccTransStock_OnAccounted);
            this.ucAccTransStock.OnPrintInvoice += new UCAccountTransactionStock.PrintInvoice(ucAccTransStock_OnPrintInvoice);
            this.panelControl1.Parent = this.tabPage1;
           
            this.ucAccTransStock.txtStockTransactionNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(txtStockTransactionNo_ButtonClick);
            //if (this.DesignMode)
            //{
            //    tCtrl.SelectedIndex = 0;
            //    tCtrl.SelectedIndex = 1;
            //}
        }

        void ucAccTransStock_OnPrintInvoice()
        {
            AccountTransactionStockNew t = this.DataSource as AccountTransactionStockNew;
            
            DataTable dt = new StockTransactionBLL().GetDetailForReportSaleInvoce(Guid.Empty);
            int stt = 1;
            foreach (AccountTransactionStockDetail accTransStockDetail in t.AccTransactionStock.Detail)
            {
                DataRow dr = dt.NewRow();
                Item item = this.ucAccTransStock.GetItem(accTransStockDetail.ItemCode);
                dr["STT"] = stt;
                stt++;
                dr["ItemCode"] = accTransStockDetail.ItemCode;
                dr["ItemName"] = item.ItemName;
                dr["Unit"] = item.Unit;
                dr["Quantity"] = accTransStockDetail.Quantity;
                dr["Price"] = accTransStockDetail.Price;
                dr["Amount"] = accTransStockDetail.Amount;
                dt.Rows.Add(dr);
            }
           
            while (dt.Rows.Count < 13)
            {
                DataRow dr = dt.NewRow();
                dr["STT"] = DBNull.Value;
                dr["ItemCode"] = DBNull.Value;
                dr["ItemName"] = DBNull.Value;
                dr["Unit"] = DBNull.Value;
                dr["Quantity"] = DBNull.Value;
                dr["Price"] = DBNull.Value;
                dr["Amount"] = DBNull.Value;
                if (dt.Rows.Count == 11)
                {
                    dr["ItemName"] = t.AccTransactionStock.DiscountDescription;
                    dr["Amount"] = t.AccTransactionStock.DiscountAmount;
                }
                dt.Rows.Add(dr);
            }
            StockTransaction header = new StockTransaction();
            header.TransactionDate = t.AccTransactionStock.InvoiceNgay;
            header.SaleRequestObj = new SaleRequests();
            header.SaleRequestObj.InvoiceCustomerName = t.AccTransactionStock.Donvi;
            header.SaleRequestObj.CustomerCode = t.AccTransactionStock.DonviCode;
            header.SaleRequestObj.PaymentType = t.AccTransactionStock.PaymentType;
            header.SaleRequestObj.TaxRate = t.AccTransactionStock.InvoiceThuexuat;
            header.SaleRequestObj.BeforeTaxAmount = t.AccTransactionStock.BeforeTaxAmount;
            header.SaleRequestObj.TaxAmount = t.AccTransactionStock.TaxAmount;
            header.SaleRequestObj.InvoiceAmount = t.AccTransactionStock.InvoiceAmount;
            RpSaleInvoice rp = new RpSaleInvoice();
            RpSaleInvoice.Params pr;
            pr.Header = header;
            rp.RpParams = pr;
            rp.DataSource = dt;
            rp.BindData();
            rp.ShowPreviewDialog();
        }

        void txtStockTransactionNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                this.txtAccountTransactionNo.Text = this.BuildAccountTransactionNo(this.StockTransactionTypeCode);
                this.ucAccTransStock.txtStockTransactionNo.Text = this.txtAccountTransactionNo.Text;
            }
            //throw new Exception("The method or operation is not implemented.");
        }
        private bool CheckAccounted()
        {
            AccountTransactionStockNew t = this.DataSource as AccountTransactionStockNew;
            if (t.SubjectCode1 != this.StrObject)
            {
                return false;
            }
            if (t.SubjectCode2 != this.ucAccTransStock.DonviCode)
            {
                return false;
            }
            if (t.AccTransactionStock.TaxAmount != this.ucAccTransStock.TaxAmount)
            {
                return false;
            }
            if (t.AccTransactionStock.BeforeTaxAmount != this.ucAccTransStock.BeforeTaxAmount)
            {
                return false;
            }
            if (t.AccTransactionStock.InvoiceAmount != this.ucAccTransStock.InvoiceAmount)
            {
                return false;
            }
            if (t.AccTransactionStock.InvoiceVAT != this.ucAccTransStock.InvoiceVAT)
            {
                return false;
            }
            if (t.AccTransactionStock.InvoiceVAT)
            {
                if (t.Invoice.Count == 0)
                {
                    return false;
                }
                else
                {
                    Invoice invoiceObj = t.Invoice[0];
                    if (invoiceObj.SoHoadon != this.ucAccTransStock.InvoiceNo)
                    {
                        return false;
                    }
                    if (invoiceObj.NgayHoadon != this.ucAccTransStock.InvoiceDate)
                    {
                        return false;
                    }
                    if (invoiceObj.SoSeri != this.ucAccTransStock.InvoiceSeri)
                    {
                        return false;
                    }
                    if (invoiceObj.MauHoadon != this.ucAccTransStock.InvoiceTemplate)
                    {
                        return false;
                    }
                    if (invoiceObj.Thuexuat != this.ucAccTransStock.ThueXuat)
                    {
                        return false;
                    }
                    if (invoiceObj.Doanhso != this.ucAccTransStock.BeforeTaxAmount)
                    {
                        return false;
                    }
                    if (invoiceObj.Tienthue != this.ucAccTransStock.TaxAmount)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void Accounted()
        {
            AccountTransactionStockNew t = this.DataSource as AccountTransactionStockNew;
            t.AccTransactionStock.StockTransactionTypeCode = this.StockTransactionTypeCode;
            t.AccTransactionStock.Description = this.ucAccTransStock.Description;

            t.SubjectCode1 = this.StrObject;
            t.SubjectCode2 = this.ucAccTransStock.DonviCode;
            t.AccTransactionStock.TaxAmount = this.ucAccTransStock.TaxAmount;
            t.AccTransactionStock.BeforeTaxAmount = this.ucAccTransStock.BeforeTaxAmount;
            t.AccTransactionStock.InvoiceAmount = this.ucAccTransStock.InvoiceAmount;
            t.AccTransactionStock.InvoiceVAT = this.ucAccTransStock.InvoiceVAT;
            Subject subjectObj = new SubjectBLL().GetBySubjectCode(t.SubjectCode2);
            if (this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.X14.ToString())
            {
                // invoiceObj.TenMathang = "Thức ăn cá";
                if (t.Description == string.Empty)
                {
                    if (t.Invoice == null) t.Invoice = new VNS.Common.ListBase<Invoice>();
                    if (subjectObj != null)
                    {
                        t.Description = "Bán hàng cho " + subjectObj.SubjectName;
                        this.Description = t.Description;
                    }
                }
            }
            new AccountTransactionStockNewBLL().AccountedFromAccTransStock(ref t, this.ucAccTransStock.DonviCode, this.ucAccTransStock.ThueXuat);
            //tạo ra hoá đơn tương ứng
            if (t.AccTransactionStock.InvoiceVAT)
            {
                if (this.StockTransactionTypeCode == enumStockTransactionType.N11.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.N31.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.X14.ToString())
                {
                    if (t.Invoice == null) t.Invoice = new VNS.Common.ListBase<Invoice>();
                    // t.Invoice.Clear();
                    Invoice invoiceObj = null;
                    if (t.Invoice.Count > 0)
                    {
                        invoiceObj = t.Invoice[0];
                    }
                    else
                    {
                        invoiceObj = new Invoice();
                    }
                    invoiceObj.Dauvao = this.StockTransactionTypeCode == enumStockTransactionType.N11.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.N31.ToString();

                    //Subject subjectObj = new SubjectBLL().GetBySubjectCode(this.ucAccTransStock.DonviCode);
                    Subject subjectObj1 = new SubjectBLL().GetBySubjectCode(this.StrObject);
                    Customer customerObj1 = new CustomerBLL().GetBySubjectCode(subjectObj == null ? "" : subjectObj.SubjectCode);
                    // Invoice invoiceObj = new Invoice();
                    invoiceObj.SoHoadon = this.ucAccTransStock.InvoiceNo;
                    invoiceObj.NgayHoadon = this.ucAccTransStock.InvoiceDate;
                    invoiceObj.SoSeri = this.ucAccTransStock.InvoiceSeri;
                    invoiceObj.MauHoadon = this.ucAccTransStock.InvoiceTemplate;
                    if (subjectObj != null)
                    {
                        invoiceObj.TenDonvi = subjectObj.SubjectName;
                        invoiceObj.Masothue = subjectObj.TaxCode;
                        //invoiceObj.BranchCode = subjectObj.BranchCode;
                    }
                    //if (subjectObj1 != null)
                    //{
                    //    invoiceObj.BranchCode = subjectObj1.BranchCode;
                    //}
                    invoiceObj.BranchCode = this.GetStrBrandCode();
                    invoiceObj.MauHoadon = this.ucAccTransStock.InvoiceTemplate;
                    invoiceObj.SoSeri = this.ucAccTransStock.InvoiceSeri;
                    invoiceObj.Thuexuat = this.ucAccTransStock.ThueXuat;
                    //invoiceObj.

                    invoiceObj.Doanhso = this.ucAccTransStock.BeforeTaxAmount;
                    //invoiceObj.BranchCode = this.;
                    invoiceObj.Tienthue = this.ucAccTransStock.TaxAmount;
                    if (invoiceObj.TenMathang == string.Empty)
                    {
                        if (this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                        {
                            if (customerObj1.ProductType.StartsWith("02."))
                                invoiceObj.TenMathang = "Thức ăn gia súc";
                            else
                                invoiceObj.TenMathang = "Thức ăn cá";
                        }
                        if (this.StockTransactionTypeCode == enumStockTransactionType.N11.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.N31.ToString())
                        {
                            invoiceObj.TenMathang = this.ucAccTransStock.StartItemName;
                        }
                    }
                    if (this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.X14.ToString())
                    {
                        if (subjectObj != null)
                        {
                            t.Description = "Bán hàng cho " + subjectObj.SubjectName;
                        }
                    }

                    if (t.Invoice.Count == 0)
                    {
                        t.Invoice.Add(invoiceObj);
                    }

                }
            }
            this.RefeshDataDetail();
            if (!this.DesignMode)
            {
                tCtrl.SelectedIndex = 0;
            }
        }
        public int TabSelectedIndex
        {
            set 
            {
                if (!this.DesignMode)
                {
                    tCtrl.SelectedIndex = value;
                }
            }
        }
        void ucAccTransStock_OnAccounted(object sender, EventArgs e)
        {
            this.Accounted();
        }

        public override void BindData2()
        {
            base.BindData2();
            //this.ucAccTransStock.BindData2();
            AccountTransactionStock accTransStock = (this.DataSource as AccountTransactionStockNew).AccTransactionStock;
            this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = true;
            this.ucAccTransStock.BindData2(accTransStock);
            this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = false;
        }

        void ucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if(ucAccTransStock.chkGetFromStockTransactionCheckedValue && !this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged)
            {
                ucAccTransStock_OnbtnGetFromStockTransaction_Click(sender, e);
            }
        }

        void ucAccTransStock_OnbtnGetFromStockTransaction_Click(object sender, EventArgs e)
        {
            object lstStockTransactionChecked = null;
            VNS.Common.ListBase<StockTransaction> lstStockTransaction = null;
            if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKIN.ToString())
            {
                string[] fields = { "InStock", "TransactionNo", "TransactionDate", "Description", "Shift", "DVGiao", "SoHD", "DonviVC", "PTVC", "CTKemtheo", "Nguoigiaonhan" };
                string[] headers ={ "Mã kho", "Số", "Ngày", "Diễn giải", "Ca", "Đơn vị giao", "Số HĐ", "ĐV vận chuyển", "PT vận chuyển", "CT kèm theo", "Người giao" };
                if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
                {
                    lstStockTransaction = new StockTransactionBLL().GetForAccountTransactionStockCheck(this.StockTransactionTypeCode, (this.DataSource as AccountTransactionStockNew).AccountTransactionID, "", "", true);
                    //lstStockTransactionChecked = FormCheck.Show(lstStockTransaction, fields, headers, -1, "", (this.DataSource as AccountTransactionStockNew).AccTransactionStock.LstAccountStock, "StockTransactionID");
                    lstStockTransactionChecked = FormCheck.Show(lstStockTransaction, fields, headers, -1, "TransactionID", (this.DataSource as AccountTransactionStockNew).AccTransactionStock.LstAccountStock, "StockTransactionID");
                }
                else if(this.ucAccTransStock.chkGetFromStockTransactionCheckedValue)
                {
                    lstStockTransaction = new StockTransactionBLL().GetListStockTransForAccountTrans((this.DataSource as AccountTransactionStockNew).AccountTransactionID);
                    //FormCheck.Show(lstStockTransaction, fields, headers, -1, "", (this.DataSource as AccountTransactionStockNew).AccTransactionStock.LstAccountStock, "StockTransactionID");
                    FormCheck.Show(lstStockTransaction, fields, headers, -1, "TransactionID", (this.DataSource as AccountTransactionStockNew).AccTransactionStock.LstAccountStock, "StockTransactionID");
                }
                if (lstStockTransactionChecked != null)
                {
                    AccountTransactionStockNew accTrans = this.DataSource as AccountTransactionStockNew;
                    System.Collections.ArrayList lstStockTransaction1 = lstStockTransactionChecked as System.Collections.ArrayList;
                    accTrans.SubjectCode1 = this.StrObject;
                    new AccountTransactionStockNewBLL().GetDataFromStockTransaction(lstStockTransaction1, ref accTrans, this.AccountTransactionTypeCode, this.StockTransactionTypeCode);
                    if (lstStockTransaction1.Count > 0)
                    {
                        this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = true;
                        ucAccTransStock.chkGetFromStockTransactionCheckedValue = true;
                        this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = false;
                        this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = true;
                       // this.ucAccTransStock.BindData2(accTrans.AccTransactionStock);
                        this.BindData2();
                        this.RefeshDataDetail();
                        this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = false;
                    }
                    else
                    {
                        ucAccTransStock.chkGetFromStockTransactionCheckedValue =false;
                    }
                }
            }
            if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKOUT.ToString())
            {
                string[] fields = { "OutStock", "TransactionNo", "TransactionDate", "Description", "Shift", "DVNhan", "SoDH", "DonviVC", "PTVC", "CTKemtheo", "Nguoigiaonhan" };
                string[] headers ={ "Mã kho", "Số", "Ngày", "Diễn giải", "Ca", "Đơn vị nhận", "Số ĐH", "ĐV vận chuyển", "PT vận chuyển", "CT kèm theo", "Người nhận" };
                if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
                {
                    lstStockTransaction = new StockTransactionBLL().GetForAccountTransactionStockCheck(this.StockTransactionTypeCode, (this.DataSource as AccountTransactionStockNew).AccountTransactionID, this.ucAccTransStock.DonviCode, this.ucAccTransStock.StrObject, false);
                    //lstStockTransactionChecked = FormCheck.Show(lstStockTransaction, fields, headers, -1, "", (this.DataSource as AccountTransactionStockNew).AccTransactionStock.LstAccountStock, "StockTransactionID");
                    lstStockTransactionChecked = FormCheck.Show(lstStockTransaction, fields, headers, -1, "TransactionID", (this.DataSource as AccountTransactionStockNew).AccTransactionStock.LstAccountStock, "StockTransactionID");
                }
                else if(this.ucAccTransStock.chkGetFromStockTransactionCheckedValue)
                {
                    lstStockTransaction = new StockTransactionBLL().GetListStockTransForAccountTrans((this.DataSource as AccountTransactionStockNew).AccountTransactionID);
                    //FormCheck.Show(lstStockTransaction, fields, headers, -1, "", (this.DataSource as AccountTransactionStockNew).AccTransactionStock.LstAccountStock, "StockTransactionID");
                   
                    FormCheck.Show(lstStockTransaction, fields, headers, -1, "TransactionID", (this.DataSource as AccountTransactionStockNew).AccTransactionStock.LstAccountStock, "StockTransactionID");
                }

                if (lstStockTransactionChecked != null)
                {
                    //if(lstStockTransactionChecked
                    AccountTransactionStockNew accTrans = this.DataSource as AccountTransactionStockNew;
                    System.Collections.ArrayList lstStockTransaction1 = lstStockTransactionChecked as System.Collections.ArrayList;
                    bool selectSTFail = false;
                    if (lstStockTransaction1.Count > 1)
                    {
                        StockTransaction stFirst = lstStockTransaction1[0] as StockTransaction;
                        int month = stFirst.TransactionDate.Month;
                       
                        if (stFirst.SaleRequestObj == null) stFirst.SaleRequestObj = new SaleRequestBLL().GetBySaleRequestNo(stFirst.SoDH);
                        if (stFirst.Details == null)
                        {
                            stFirst.Details = new StockTransactionBLL().GetDetailsByTransactionID(stFirst.TransactionID);
                        }
                        string invoiceNo = stFirst.SaleRequestObj.InvoiceNo;
                        DateTime invoiceDate = stFirst.SaleRequestObj.InvoiceDate;
                        string invoiceSeri = stFirst.SaleRequestObj.InvoiceSeri;
                        string invoiceTemplate = stFirst.SaleRequestObj.InvoiceMau;
                        decimal taxRate = stFirst.SaleRequestObj.TaxRate;

                        //ListBase<StockTransactionSumDetail> lstSumDetail = new ListBase<StockTransactionSumDetail>();

                        //foreach (StockTransactionSumDetail stsdetail in stFirst.Details)
                        //{
                        //    if (!selectSTFail)
                        //    {
                        //        StockTransactionSumDetail stsdDetail2 = lstSumDetail.Search("ItemCode", stsdetail.ItemCode);
                        //        if (stsdDetail2 == null)
                        //        {
                        //            lstSumDetail.Add(stsdetail.Clone() as StockTransactionSumDetail);
                        //        }
                        //        else
                        //        {
                        //            if (stsdetail.PriceOut != stsdDetail2.PriceOut)
                        //            {
                        //                selectSTFail = true;
                        //                break;
                        //            }
                        //        }
                        //    }
                        //}
                        if (!selectSTFail)
                        {
                            int countST = lstStockTransaction1.Count;
                            for(int i = 1; i < countST; i++)
                            {
                                if (!selectSTFail)
                                {
                                    StockTransaction sti = lstStockTransaction1[i] as StockTransaction;
                                    if (sti.SaleRequestObj == null) sti.SaleRequestObj = new SaleRequestBLL().GetBySaleRequestNo(sti.SoDH);
                                    if (sti.Details == null)
                                    {
                                        sti.Details = new StockTransactionBLL().GetDetailsByTransactionID(sti.TransactionID);
                                    }
                                    if (sti.SaleRequestObj.InvoiceNo != invoiceNo || sti.SaleRequestObj.InvoiceDate != invoiceDate || sti.SaleRequestObj.InvoiceMau != invoiceTemplate || sti.TransactionDate.Month != month || sti.SaleRequestObj.TaxRate != taxRate)
                                    {
                                        selectSTFail = true;
                                        break;
                                    }
                                    //if (!selectSTFail)
                                    //{
                                    //    foreach (StockTransactionSumDetail stsdetailNext in sti.Details)
                                    //    {
                                    //        if (!selectSTFail)
                                    //        {
                                    //            StockTransactionSumDetail stsdDetail2Next = lstSumDetail.Search("ItemCode", stsdetailNext.ItemCode);
                                    //            if (stsdDetail2Next == null)
                                    //            {
                                    //                lstSumDetail.Add(stsdetailNext.Clone() as StockTransactionSumDetail);
                                    //            }
                                    //            else
                                    //            {
                                    //                if (stsdetailNext.PriceOut != stsdDetail2Next.PriceOut)
                                    //                {
                                    //                    selectSTFail = true;
                                    //                    break;
                                    //                }
                                    //            }
                                    //        }
                                    //    }
                                    //}
                                }
                            }
                           
                        }
                    }
                    if (!selectSTFail)
                    {
                        accTrans.SubjectCode1 = this.StrObject;
                        new AccountTransactionStockNewBLL().GetDataFromStockTransaction(lstStockTransaction1, ref accTrans, this.AccountTransactionTypeCode, this.StockTransactionTypeCode);
                        if (lstStockTransaction1.Count > 0)
                        {
                            this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = true;
                            ucAccTransStock.chkGetFromStockTransactionCheckedValue = true;
                            this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = false;
                            this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = true;
                            // this.ucAccTransStock.BindData2(accTrans.AccTransactionStock);
                            accTrans.AccTransactionStock.BeforeTaxAmount = this.ucAccTransStock.TotalAmount - accTrans.AccTransactionStock.DiscountAmount;
                            accTrans.AccTransactionStock.TaxAmount = Math.Round(accTrans.AccTransactionStock.InvoiceThuexuat * accTrans.AccTransactionStock.BeforeTaxAmount, 0);
                            accTrans.AccTransactionStock.InvoiceAmount = accTrans.AccTransactionStock.BeforeTaxAmount + accTrans.AccTransactionStock.TaxAmount;

                            this.BindData2();
                            this.RefeshDataDetail();
                            this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = false;
                            //this.BindData2();
                        }
                        else
                        {
                            ucAccTransStock.chkGetFromStockTransactionCheckedValue = false;
                        }
                    }
                    else
                    {
                        if (this.OnSelectSTFail != null) this.OnSelectSTFail();
                    }
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tCtrl.Dock = DockStyle.Fill;
            ucAccTransStock.Dock = DockStyle.Fill;
          // tCtrl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            try
            {
                tCtrl.Width = this.Width;
                tCtrl.Height = this.Height;
                ucAccTransStock.Dock = DockStyle.Fill;
            }
            catch
            {
            }
        }
        protected override void BindData()
        {
            base.BindData();
            if (this.DataSource != null)
            {
                if ((this.DataSource as AccountTransactionStockNew).AccTransactionStock == null)
                {
                    (this.DataSource as AccountTransactionStockNew).AccTransactionStock = new AccountTransactionStock();
                }
                AccountTransactionStock accTransStock = (this.DataSource as AccountTransactionStockNew).AccTransactionStock;
                this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = true;
                ucAccTransStock.BindData(ref accTransStock);
                this.cancelucAccTransStock_OnchkGetFromStockTransaction_CheckedChanged = false;
            }
        }
        protected override void AssignData()
        {
            base.AssignData();
            AccountTransactionStock accTransStock = (this.DataSource as AccountTransactionStockNew).AccTransactionStock;
            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                (this.DataSource as AccountTransactionStockNew).UserCreated = Contexts.CurrentUser.LoginName;
                (this.DataSource as AccountTransactionStockNew).DateCreated = DateTime.Now;
            }
            (this.DataSource as AccountTransactionStockNew).UserUpdated = Contexts.CurrentUser.LoginName;
            (this.DataSource as AccountTransactionStockNew).DateUpdated = DateTime.Now;
            ucAccTransStock.AssignData(ref accTransStock);
        }
        public override void RefreshControl()
        {
            if (this.EditMode == VNS.Windows.FormEditMode.ADD && !this.DesignMode)
            {
                tCtrl.SelectedIndex = 1;
            }
            ucAccTransStock.RefreshControl(this.DataSource);
            base.RefreshControl();

        }
        protected override int ValidateData()
        {
            int ret = base.ValidateData();
            if (this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.X14.ToString())
            {
                if (this.ucAccTransStock.InvoiceVAT)
                    if (!this.CheckAccounted())
                    {
                        return -113;
                    }
            }
            if (tCtrl.SelectedIndex == 0)
            {
                this.ucAccTransStock.txtStockTransactionNo.Text = this.txtAccountTransactionNo.Text;
                this.ucAccTransStock.lookUpEditDonVi.EditValue = this.cboSubjectcode2.EditValue;
            }
            if (tCtrl.SelectedIndex == 1)
            {
                this.txtAccountTransactionNo.Text = this.ucAccTransStock.txtStockTransactionNo.Text;
                this.cboSubjectcode2.EditValue = this.ucAccTransStock.lookUpEditDonVi.EditValue;
                
            }
            if (ret != 0) return ret;
            ret = ucAccTransStock.ValidateData((this.DataSource as AccountTransactionStockNew).AccTransactionStock);
            if (ret != 0) return ret;
            AccountTransactionStockNew accTrans = this.DataSource as AccountTransactionStockNew;
            string materialInventoryAccount = Account.GetMaterialAccount(accTrans.AccountTransactionDate);
            string productInventoryAccount = Account.GetProductAccount(accTrans.AccountTransactionDate);

            if (this.AccountTransactionDate.Month != this.ucAccTransStock.StockTransactionDate.Month || this.AccountTransactionDate.Year != this.ucAccTransStock.StockTransactionDate.Year)
            {
                return -111;
            }

            //if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKIN.ToString())
            //{
            //    foreach (AccountTransactionDetail1 accTransDetail1 in accTrans.Detail1)
            //    {
            //        AccountTransactionStockDetail accTransStockDetail = accTrans.AccTransactionStock.Detail.Search("DebitAccountCode", accTransDetail1.AccountCode);
            //        if (accTransStockDetail == null && (accTransDetail1.AccountCode == Account.MaterialAccount || accTransDetail1.AccountCode == Account.ProductAccount))
            //            return -100;
            //    }

            //    foreach (AccountTransactionDetail2 accTransDetail2 in accTrans.Detail2)
            //    {
            //        AccountTransactionStockDetail accTransStockDetail = accTrans.AccTransactionStock.Detail.Search("DebitAccountCode", accTransDetail2.DebitAccountCode);
            //        if (accTransStockDetail == null && !(new AccountTransactionBLL().CompareDetail1(accTrans)) && (accTransDetail2.DebitAccountCode == Account.MaterialAccount || accTransDetail2.DebitAccountCode == Account.ProductAccount))
            //            return -101;
            //    }

            //    foreach (AccountTransactionStockDetail accTransStockDetail in accTrans.AccTransactionStock.Detail)
            //    {
            //        AccountTransactionDetail1 accTransDetail1 = accTrans.Detail1.Search("AccountCode", accTransStockDetail.DebitAccountCode);
            //        if (accTransDetail1 == null && this.StockTransactionTypeCode != enumStockTransactionType.N13.ToString() && this.StockTransactionTypeCode != enumStockTransactionType.N23.ToString())
            //            return -102;
            //        else if (accTransDetail1 != null)
            //        {
            //            foreach (AccountTransactionDetail1 accTransDetail11 in accTrans.Detail1)
            //            {
            //                if (accTransDetail11.AccountCode == accTransStockDetail.DebitAccountCode && accTransDetail11 != accTransDetail1)
            //                {
            //                    return -103;
            //                }
            //            }
            //        }
            //    }

            //    foreach (AccountTransactionStockDetail accTransStockDetail in accTrans.AccTransactionStock.Detail)
            //    {
            //        decimal d1 = 0;
            //        decimal d2 = 0;
            //        foreach (AccountTransactionStockDetail accTransStockDetail1 in accTrans.AccTransactionStock.Detail)
            //        {
            //            if (accTransStockDetail1.DebitAccountCode == accTransStockDetail.DebitAccountCode)
            //            {
            //                d1 += accTransStockDetail1.CostAmount;
            //            }
            //        }
            //        foreach (AccountTransactionDetail1 accTransDetail1 in accTrans.Detail1)
            //        {
            //            if (accTransDetail1.AccountCode == accTransStockDetail.DebitAccountCode)
            //            {
            //                d2 += accTransDetail1.DebitAmount;
            //            }
            //        }
            //        if (d1 != d2) return -104;
            //    }
            //}

            if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKOUT.ToString())
            {
                foreach (AccountTransactionDetail1 accTransDetail1 in accTrans.Detail1)
                {
                    AccountTransactionStockDetail accTransStockDetail = accTrans.AccTransactionStock.Detail.Search("CreditAccountCode", accTransDetail1.AccountCode);
                    if (accTransStockDetail == null && (accTransDetail1.AccountCode == materialInventoryAccount))// || accTransDetail1.AccountCode == Account.ProductAccount))
                        return -105;
                }

                foreach (AccountTransactionDetail2 accTransDetail2 in accTrans.Detail2)
                {
                    AccountTransactionStockDetail accTransStockDetail = accTrans.AccTransactionStock.Detail.Search("CreditAccountCode", accTransDetail2.CreditAccountCode);
                    if (accTransStockDetail == null && !(new AccountTransactionBLL().CompareDetail1(accTrans)) && (accTransDetail2.CreditAccountCode == materialInventoryAccount))// || accTransDetail2.CreditAccountCode == Account.ProductAccount))
                        return -106;
                }

                foreach (AccountTransactionStockDetail accTransStockDetail in accTrans.AccTransactionStock.Detail)
                {
                    AccountTransactionDetail1 accTransDetail1 = accTrans.Detail1.Search("AccountCode", accTransStockDetail.CreditAccountCode);
                    if (accTransDetail1 == null && this.StockTransactionTypeCode != enumStockTransactionType.X13.ToString() && this.StockTransactionTypeCode != enumStockTransactionType.X23.ToString())
                    {
                        if (!accTransStockDetail.CreditAccountCode.StartsWith(productInventoryAccount) && accTransStockDetail.CreditAccountCode != materialInventoryAccount) return -107;
                    }
                    else if (accTransDetail1 != null)
                    {
                        foreach (AccountTransactionDetail1 accTransDetail11 in accTrans.Detail1)
                        {
                            if (accTransDetail11.AccountCode == accTransStockDetail.CreditAccountCode && accTransDetail11 != accTransDetail1)
                            {
                                return -108;
                            }
                        }
                    }

                    AccountTransactionDetail2 accTransDetail2 = accTrans.Detail2.Search("CreditAccountCode", accTransStockDetail.CreditAccountCode);
                    if (accTransDetail2 == null && this.stockTransactionTypeCode != enumStockTransactionType.X13.ToString() && this.stockTransactionTypeCode != enumStockTransactionType.X23.ToString())
                    {
                        if (!accTransStockDetail.CreditAccountCode.StartsWith(productInventoryAccount) && accTransStockDetail.CreditAccountCode != materialInventoryAccount) return -109;
                    }
                    else if (accTransDetail2 != null)
                    {
                        foreach (AccountTransactionDetail2 accTransDetail21 in accTrans.Detail2)
                        {
                            if (accTransDetail21.CreditAccountCode == accTransStockDetail.CreditAccountCode && accTransDetail21 != accTransDetail2)
                            {
                                //return -110;
                            }
                        }
                    }
                }

                foreach (AccountTransactionStockDetail accTransStockDetail in accTrans.AccTransactionStock.Detail)
                {
                    decimal d1 = 0;
                    decimal d2 = 0;
                    foreach (AccountTransactionStockDetail accTransStockDetail1 in accTrans.AccTransactionStock.Detail)
                    {
                        if (accTransStockDetail1.CreditAccountCode == accTransStockDetail.CreditAccountCode)
                        {
                            d1 += accTransStockDetail1.CostAmount;
                        }
                    }
                    foreach (AccountTransactionDetail1 accTransDetail1 in accTrans.Detail1)
                    {
                        if (accTransDetail1.AccountCode == accTransStockDetail.CreditAccountCode)
                        {
                            d2 += accTransDetail1.CreditAmount;
                        }
                    }
                    if (d1 != d2 && this.StockTransactionTypeCode != enumStockTransactionType.X21.ToString() && this.StockTransactionTypeCode != enumStockTransactionType.X14.ToString()) return -112;
                }
            }

            return 0;
        }

        private void UCAccountTransactionStock1_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                tCtrl.SelectedIndex = 0;
                tCtrl.SelectedIndex = 1;
            }
        }

        private void tCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tCtrl.SelectedIndex == 0)
            {
                this.txtAccountTransactionNo.Text = this.ucAccTransStock.txtStockTransactionNo.Text;
                this.cboSubjectcode2.EditValue = this.ucAccTransStock.lookUpEditDonVi.EditValue;
                if (this.Description == string.Empty)
                {
                    this.Description = this.ucAccTransStock.Description;
                }
            }
            if (tCtrl.SelectedIndex == 1)
            {
                this.ucAccTransStock.txtStockTransactionNo.Text = this.txtAccountTransactionNo.Text;
                this.ucAccTransStock.lookUpEditDonVi.EditValue=this.cboSubjectcode2.EditValue;
            }
        }
    }
}
