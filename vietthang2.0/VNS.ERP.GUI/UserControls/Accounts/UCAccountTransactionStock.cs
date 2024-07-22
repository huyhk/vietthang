using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;
using VNS.Windows.Controls;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCAccountTransactionStock : System.Windows.Forms.UserControl
    {
        public delegate void Accounted(object sender, EventArgs e);
        public event Accounted OnAccounted;
        public delegate void PrintInvoice();
        public event PrintInvoice OnPrintInvoice;
        public delegate void chkGetFromStockTransaction_CheckedChanged(object sender, EventArgs e);
        public event chkGetFromStockTransaction_CheckedChanged OnchkGetFromStockTransaction_CheckedChanged;
        public delegate void btnGetFromStockTransaction_Click(object sender, EventArgs e);
        public event btnGetFromStockTransaction_Click OnbtnGetFromStockTransaction_Click;
        /// <summary>
        /// Khi Description của header thay đổi, nếu có chi tiết có Description là "" hoặc null hoặc saveDesction thì
        /// phải cập nhật lại Description chi tiết này thành Description của header.
        /// </summary>
        private string saveDescription = "";
        public DateTime StockTransactionDate
        {
            get { return dateEditStockTransaction.DateTime; }
        }
        public Item GetItem(string itemCode)
        {
            ListBase<Item> lstItem = repLookUpEditItemCode.DataSource as ListBase<Item>;
            Item i = lstItem.Search("ItemCode", itemCode);
            return i;
        }
        //Return start item name in detail
        public string StartItemName
        {
            get 
            {
                string result = string.Empty;
                ListBase<AccountTransactionStockDetail> lst = gridControl1.DataSource as ListBase<AccountTransactionStockDetail>;
                if (lst.Count > 0)
                {
                    ListBase<Item> lstItem = repLookUpEditItemCode.DataSource as ListBase<Item>;
                    Item i = lstItem.Search("ItemCode", lst[0].ItemCode);
                    if (i != null) result = i.ItemName;
                }
                return result;
            }
        }
        public bool chkGetFromStockTransactionCheckedValue
        {
            get { return chkGetFromStockTransaction.Checked; }
            set { chkGetFromStockTransaction.Checked = value; }
        }
        public bool InvoiceVAT
        {
            get { return chkVAT.Checked; }
        }
        public string DonviCode
        {
            get 
            {
                if (lookUpEditDonVi.ItemIndex == -1) return "";
                return lookUpEditDonVi.EditValue.ToString();
            }
        }
        public string InvoiceTemplate
        {
            get { return txtInvoiceMau.Text.Trim(); }
        }
        public string InvoiceSeri
        {
            get { return txtInvoiceSeri.Text.Trim(); }
        }
        public decimal BeforeTaxAmount
        {
            get 
            {
                decimal d = 0;
                d = Convert.ToDecimal(txtBeforeTaxAmount.EditValue);
                //ListBase<AccountTransactionStockDetail> lst = gridControl1.DataSource as ListBase<AccountTransactionStockDetail>;
                //if (lst == null) return 0;
                //foreach (AccountTransactionStockDetail obj in lst)
                //{
                //    d += obj.Amount;
                //}
                //gridControl1
                return d;
            }
        }
        public decimal TotalAmount
        {
            get
            {
                decimal d = 0;
                ListBase<AccountTransactionStockDetail> lst = gridControl1.DataSource as ListBase<AccountTransactionStockDetail>;
                if (lst == null) return 0;
                foreach (AccountTransactionStockDetail obj in lst)
                {
                    d += obj.Amount;
                }
                return d;
            }
        }
        public string InvoiceNo
        {
            get { return txtInvoiceSo.Text.Trim(); }
        }
        public DateTime InvoiceDate
        {
            get { return dateEditInvoice.DateTime; }
        }
        private Subject subjectObj = null;
        public decimal ThueXuat
        {
            get { return Convert.ToDecimal(txtInvoiceThueXuat.EditValue); }
        }
        public decimal TaxAmount
        {
            get { return Convert.ToDecimal(txtTaxAmount.EditValue); }
        }
        public decimal InvoiceAmount
        {
            get 
            { 
                return Convert.ToDecimal(txtInvoiceAmount.EditValue); 
            }
        }
        private string stockTransactionTypeCode;
        public string StockTransactionTypeCode
        {
            get { return stockTransactionTypeCode; }
            set 
            { 
                stockTransactionTypeCode = value;
                if (stockTransactionTypeCode == "X31")
                {
                    gridView1.Columns["DebitAccountCode"].Visible = true;
                    gridView1.Columns["DebitAccountCode"].ColumnEdit = null;
                }
            }
        }
        public string Description
        {
            get { return txtDescription.Text.Trim(); }
            set
            {
                txtDescription.Text = value;
            }
        }
        private string strObject = string.Empty;
        public string StrObject
        {
            get { return strObject; }
            set 
            { 
                strObject = value;
                this.subjectObj = new SubjectBLL().GetBySubjectCode(strObject);
            }
        }
        private string accountTransactionTypeCode;
        public string AccountTransactionTypeCode
        {
            get { return accountTransactionTypeCode; }
            set
            {
                accountTransactionTypeCode = value;
                if (value == enumAccountTransactionType.STOCKIN.ToString())
                {
                    lbNguoiNhan.Visible = false;
                    gridView1.Columns.Remove(colCreditAccountCode1);
                    gridView1.Columns.Remove(colStockOutCode);
                    gridView1.Columns.Remove(colPrice);
                    gridView1.Columns.Remove(colAmount1);
                    lookUpEditStockTransactionTypeCode.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.In);
                }
                if (value == enumAccountTransactionType.STOCKOUT.ToString())
                {
                    lbNguoiGiao.Visible = false;
                    lbNguoiNhan.Visible = true;
                    lbNguoiNhan.Top = lbNguoiGiao.Top;
                    lbNguoiNhan.Left = lbNguoiGiao.Left;
                    //if (stockTransactionTypeCode != "X31")
                        //gridView1.Columns.Remove(colDebitAccountCode1);
                    gridView1.Columns["DebitAccountCode"].Visible = false;
                    gridView1.Columns.Remove(colStockInCode);
                    gridView1.Columns.Remove(colPrice1);
                    gridView1.Columns.Remove(colAmount11);
                    lookUpEditStockTransactionTypeCode.Properties.DataSource = new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.Out);
                }
            }
        }
        public UCAccountTransactionStock()
        {
            InitializeComponent();
            //this.txtInvoiceThueXuat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //this.txtInvoiceThueXuat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;

            this.txtInvoiceThueXuat.Properties.EditFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.txtInvoiceThueXuat.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.txtInvoiceThueXuat.Properties.Mask.EditMask = AppConfigs.CONFIG_PERCENTFORMAT;
            colQuantity.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            colAmount1.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colAmount11.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colCostAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            repLookUpEditItemCode.EditValueChanged += new EventHandler(repLookUpEditItemCode_EditValueChanged);

            repLookUpEditDebitAccountCode.Enter += new EventHandler(ItemLook_Enter);
            repLookUpEditStockIn.Enter += new EventHandler(ItemLook_Enter);
            repLookUpEditCreditAccountCode.Enter += new EventHandler(ItemLook_Enter);
            repLookUpEditStockOut.Enter += new EventHandler(ItemLook_Enter);
            repLookUpEditItemCode.Enter += new EventHandler(ItemLook_Enter);
            repLookUpEditItemName.Enter += new EventHandler(ItemLook_Enter);
        }

        void repLookUpEditItemCode_EditValueChanged(object sender, EventArgs e)
        {
            string itemCode = gridView1.ActiveEditor.Text;
            this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, this.colItemName, itemCode);
            //this.gridView1.RefreshRow(this.gridView1.FocusedRowHandle);
        }

        public void BindData2(AccountTransactionStock dataSource)
        {
            //lst.sele
            txtStockTransactionNo.Text = dataSource.StockTransactionNo;
            dateEditStockTransaction.DateTime = dataSource.StockTransactionDate;
            txtNguoigiaonhan.Text = dataSource.Nguoigiaonhan;
            txtPTVC.Text = dataSource.PTVC;
            txtNguoiVC.Text = dataSource.NguoiVC;
            txtCTKT.Text = dataSource.Chungtukemtheo;
            txtDescription.Text = dataSource.Description;
            chkGetFromStockTransaction.Checked = true;
            txtBeforeTaxAmount.EditValue = dataSource.BeforeTaxAmount;
            txtTaxAmount.EditValue = dataSource.TaxAmount;
            txtInvoiceAmount.EditValue = dataSource.InvoiceAmount;
            txtInvoiceThueXuat.EditValue = dataSource.InvoiceThuexuat;
            txtDiscount.EditValue = dataSource.DiscountAmount;
            txtInvoiceSo.Text = dataSource.InvoiceSo;
            dateEditInvoice.DateTime = dataSource.InvoiceNgay;
            lookUpEditStockTransactionTypeCode.EditValue = this.StockTransactionTypeCode;
            TransactionType transType = (lookUpEditStockTransactionTypeCode.Properties.DataSource as VNS.Common.ListBase<TransactionType>).Search("TransactionTypeCode", lookUpEditStockTransactionTypeCode.EditValue.ToString());
            if (transType != null)
            {
                txtLydoNX.Text = transType.Description;
            }
            txtPaidDays.EditValue = dataSource.PaidDays;
        }

        void ItemLook_Enter(object sender, EventArgs e)
        {
            if ((this.Parent.Parent.Parent as VNS.Windows.Controls.EditControlBase).EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                DevExpress.XtraEditors.LookUpEdit repLookup = sender as DevExpress.XtraEditors.LookUpEdit;
                if (repLookup != null)
                {
                    repLookup.ShowPopup();
                }
            }
        }

        public void BindData(ref AccountTransactionStock dataSource)
        {
            if (dataSource != null)
            {
                AccountTransactionStock ats = dataSource as AccountTransactionStock;
                lookUpEditStockTransactionTypeCode.EditValue = this.StockTransactionTypeCode;
                txtStockTransactionNo.Text = ats.StockTransactionNo;
                dateEditStockTransaction.EditValue = ats.StockTransactionDate;
                txtTenkho.Text = ats.Tenkho;
                txtLydoNX.Text = ats.LydoNX;
                if ((this.Parent.Parent.Parent as VNS.Windows.Controls.EditControlBase).EditMode == VNS.Windows.FormEditMode.ADD)
                {
                    if (this.subjectObj != null)
                    {
                        txtTenkho.Text = this.subjectObj.SubjectName;
                        txtLydoNX.Text = lookUpEditStockTransactionTypeCode.GetColumnValue("Description").ToString();
                    }
                }
                txtNguoigiaonhan.Text = ats.Nguoigiaonhan;
                lookUpEditDonVi.EditValue = ats.DonviCode;
                btnEditDonvi.Text = ats.Donvi;
                txtPTVC.Text = ats.PTVC;
                txtNguoiVC.Text = ats.NguoiVC;
                txtCTKT.Text = ats.Chungtukemtheo;
                txtHTTT.Text = ats.PaymentType;
               
                txtDescription.Text = ats.Description;
              
                txtInvoiceMau.Text = ats.InvoiceMau;
                txtInvoiceSeri.Text = ats.InvoiceSeri;
                txtInvoiceSo.Text = ats.InvoiceSo;
                dateEditInvoice.DateTime = ats.InvoiceNgay;
                txtInvoiceThueXuat.EditValue = ats.InvoiceThuexuat;
                txtDiscount.EditValue = ats.DiscountAmount;
                txtDiscountDescription.Text = ats.DiscountDescription;
                chkGiamgia.Checked = ats.Giamgia;
                chkVAT.Checked = ats.InvoiceVAT;
                
                this.saveDescription = ats.Description;

                if (ats.Detail == null)
                {
                    if ((this.Parent.Parent.Parent as VNS.Windows.Controls.EditControlBase).EditMode == VNS.Windows.FormEditMode.ADD)
                    {
                        ats.Detail = new VNS.Common.ListBase<AccountTransactionStockDetail>();
                    }
                    else
                    {
                        ats.Detail = new AccountTransactionStockNewBLL().GetAccTransStockDetailByAccTransID(ats.AccountTransationID);
                    }
                }
                if (ats.LstAccountStock == null)
                {
                    if ((this.Parent.Parent.Parent as VNS.Windows.Controls.EditControlBase).EditMode == VNS.Windows.FormEditMode.ADD)
                    {
                        ats.LstAccountStock = new VNS.Common.ListBase<AccountStock>();
                    }
                    else
                    {
                        ats.LstAccountStock = new AccountTransactionStockNewBLL().GetAccStockByAccTransID(ats.AccountTransationID);
                    }
                }
                chkGetFromStockTransaction.Checked = ats.LstAccountStock.Count != 0;
             
                gridControl1.DataSource = ats.Detail;
                txtBeforeTaxAmount.EditValue = ats.BeforeTaxAmount;
                txtTaxAmount.EditValue = ats.TaxAmount;
                txtInvoiceAmount.EditValue = ats.InvoiceAmount;
                txtPaidDays.EditValue = ats.PaidDays;
          //      this.gridView1.BestFitColumns();
            }
        }

        public void AssignData(ref AccountTransactionStock dataSource)
        {
            if (dataSource == null) dataSource = new AccountTransactionStock();
            AccountTransactionStock ats = dataSource as AccountTransactionStock;
            ats.StockTransactionTypeCode = lookUpEditStockTransactionTypeCode.EditValue.ToString();
            ats.StockTransactionNo = txtStockTransactionNo.Text;
            ats.StockTransactionDate = dateEditStockTransaction.DateTime;
            ats.GetFromStockTransaction = chkGetFromStockTransaction.Checked;
            ats.Tenkho = txtTenkho.Text;
            ats.Nguoigiaonhan = txtNguoigiaonhan.Text;
            ats.Donvi = btnEditDonvi.Text;
            ats.PTVC = txtPTVC.Text;
            ats.NguoiVC = txtNguoiVC.Text;
            ats.Chungtukemtheo = txtCTKT.Text;
            ats.LydoNX = txtLydoNX.Text;
            ats.Description = txtDescription.Text;
            ats.DonviCode=lookUpEditDonVi.EditValue.ToString();
            ats.InvoiceMau=txtInvoiceMau.Text;
            ats.InvoiceSeri=txtInvoiceSeri.Text;
            ats.InvoiceSo=txtInvoiceSo.Text;
            ats.InvoiceNgay=dateEditInvoice.DateTime;
            ats.InvoiceThuexuat= Convert.ToDecimal(txtInvoiceThueXuat.EditValue);
            ats.InvoiceVAT = chkVAT.Checked;

            ats.DiscountAmount= Convert.ToDecimal(txtDiscount.EditValue);
            ats.DiscountDescription=txtDiscountDescription.Text;
            ats.Giamgia=chkGiamgia.Checked;
            ats.BeforeTaxAmount=Convert.ToDecimal(txtBeforeTaxAmount.EditValue);
            ats.TaxAmount=Convert.ToDecimal(txtTaxAmount.EditValue);
            ats.InvoiceAmount = Convert.ToDecimal(txtInvoiceAmount.EditValue);
            ats.PaymentType = txtHTTT.Text;
            if (!chkGetFromStockTransaction.Checked)
            {
                ats.LstAccountStock.Clear();
            }
            ats.PaidDays = Convert.ToInt32(txtPaidDays.EditValue);
        }

        public int ValidateData(object dataSource)
        {
            txtHTTT.Text = txtHTTT.Text.Trim();
            txtStockTransactionNo.Text = txtStockTransactionNo.Text.Trim();
            txtTenkho.Text = txtTenkho.Text.Trim();
            txtNguoigiaonhan.Text = txtNguoigiaonhan.Text.Trim();
            btnEditDonvi.Text = btnEditDonvi.Text.Trim();
            txtPTVC.Text = txtPTVC.Text.Trim();
            txtNguoiVC.Text = txtNguoiVC.Text.Trim();
            txtCTKT.Text = txtCTKT.Text.Trim();
            txtLydoNX.Text = txtLydoNX.Text.Trim();
            txtDescription.Text = txtDescription.Text.Trim();

            txtInvoiceMau.Text = txtInvoiceMau.Text.Trim();
            txtInvoiceSeri.Text = txtInvoiceSeri.Text.Trim(); 
            txtInvoiceSo.Text = txtInvoiceSo.Text.Trim();
            txtDiscountDescription.Text = txtDiscountDescription.Text.Trim();
            //txtInvoiceThueXuat.Text = "";

            if (lookUpEditStockTransactionTypeCode.EditValue == null)
            {
                lookUpEditStockTransactionTypeCode.Focus();
                return -50;
            }
            if (txtStockTransactionNo.Text == "")
            {
                txtStockTransactionNo.Focus();
                return -51;
            }

            AccountTransactionStock accTransStock = (dataSource as AccountTransactionStock);
            foreach (AccountTransactionStockDetail accTransStockDetail in accTransStock.Detail)
            {
                if ((accTransStockDetail.CreditAccountCode == null || accTransStockDetail.CreditAccountCode == string.Empty || accTransStockDetail.CreditAccountCode == "") && this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKOUT.ToString())
                {
                    return -52;
                }
                if ((accTransStockDetail.DebitAccountCode == null || accTransStockDetail.DebitAccountCode == string.Empty || accTransStockDetail.DebitAccountCode == "") && this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKIN.ToString())
                {
                    return -52;
                }
                if (accTransStockDetail.ItemCode == null)
                {
                    return -53;
                }
                if ((accTransStockDetail.StockOutCode == null || accTransStockDetail.StockOutCode == string.Empty || accTransStockDetail.StockOutCode == "") && this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKOUT.ToString())
                {
                    return -54;
                }
                if ((accTransStockDetail.StockInCode == null || accTransStockDetail.StockInCode == string.Empty || accTransStockDetail.StockInCode == "") && this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKIN.ToString())
                {
                    return -54;
                }
            }
            if (Convert.ToDecimal(txtDiscount.EditValue) != 0 && txtDiscountDescription.Text=="")
            {
                txtDiscountDescription.Focus();
                return -55;
            }
            if (Convert.ToDecimal(txtDiscount.EditValue) == 0 && txtDiscountDescription.Text != "")
            {
                txtDiscount.Focus();
                return -56;
            }
            return 0;
        }
     
        public void RefreshControl(object dataSource)
        {
            bool viewMode = (this.Parent.Parent.Parent as VNS.Windows.Controls.EditControlBase).EditMode == VNS.Windows.FormEditMode.VIEW;
           // this.lookUpEditStockTransactionTypeCode.Properties.ReadOnly = viewMode;
            txtStockTransactionNo.Properties.ReadOnly = viewMode;
            dateEditStockTransaction.Properties.ReadOnly = viewMode;
            txtTenkho.Properties.ReadOnly = viewMode;
            txtNguoigiaonhan.Properties.ReadOnly = viewMode;
            btnEditDonvi.Properties.ReadOnly = viewMode;
            txtPTVC.Properties.ReadOnly = viewMode;
            txtNguoiVC.Properties.ReadOnly = viewMode;
            txtCTKT.Properties.ReadOnly = viewMode;
            txtLydoNX.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
           
            chkGetFromStockTransaction.Properties.ReadOnly = viewMode;
            txtHTTT.Properties.ReadOnly = viewMode;

            lookUpEditDonVi.Properties.ReadOnly = viewMode;
            txtInvoiceMau.Properties.ReadOnly = viewMode;
            txtInvoiceSeri.Properties.ReadOnly = viewMode; 
            txtInvoiceSo.Properties.ReadOnly = viewMode;
            dateEditInvoice.Properties.ReadOnly = viewMode;
            txtInvoiceThueXuat.Properties.ReadOnly = viewMode;
            txtTaxAmount.Properties.ReadOnly = viewMode;
            chkGiamgia.Properties.ReadOnly = viewMode;
            txtDiscount.Properties.ReadOnly = viewMode;
            txtDiscountDescription.Properties.ReadOnly = viewMode;
            button1.Enabled = !viewMode;
            btnPrintReport.Enabled = viewMode;
            btnPrintInvoice.Enabled = viewMode;
            btnPrintReportA4.Enabled = viewMode;
            chkVAT.Properties.ReadOnly = viewMode;
            btnCopyDescription.Enabled = !viewMode;
            txtPaidDays.Properties.ReadOnly = viewMode;
           // btnEditDonvi.Enabled = !viewMode;
            if (!viewMode)
            {
                if (!chkGetFromStockTransaction.Checked)
                {
                    gridView1.OptionsBehavior.Editable = true;
                    gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                }
                else
                {
                    gridView1.OptionsBehavior.Editable = false;
                }
            }
            else
            {
                gridView1.OptionsBehavior.Editable = false;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
           
            if (dataSource == null)
            {
                txtDiscount.EditValue = 0;
                txtDiscountDescription.Text = "";
                chkGiamgia.Checked = false;
                txtBeforeTaxAmount.EditValue = 0;
                txtTaxAmount.EditValue = 0;
                txtInvoiceAmount.EditValue = 0;
                txtStockTransactionNo.Text = "";
                txtTenkho.Text = "";
                txtNguoigiaonhan.Text = "";
                btnEditDonvi.Text = "";
                txtPTVC.Text = "";
                txtNguoiVC.Text = "";
                txtCTKT.Text = "";
                txtLydoNX.Text = "";
                txtDescription.Text = "";
                //lookUpEditDonVi.EditValue="";
                txtInvoiceMau.Text="";
                txtInvoiceSeri.Text = ""; 
                txtInvoiceSo.Text = ""; 
                //ats.InvoiceNgay = dateEditInvoice.DateTime;
                txtInvoiceThueXuat.EditValue = 0;
                gridControl1.DataSource = null;
            }
        }

        private void UCAccountTransactionStock_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                int len1 = Account.MaterialAccount.Length;
                int len2 = Account.ProductAccount.Length;
                if (this.StockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.N1.ToString() || this.StockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.N3.ToString() || this.StockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.X1.ToString() || this.StockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.X3.ToString())
                {
                    repLookUpEditCreditAccountCode.DataSource = new AccountBLL().GetObjectDynamic(" left(AccountCode," + len1.ToString() + ") = '" + VNS.ERP.Data.Accounting.Account.MaterialAccount + "'", "");
                    repLookUpEditDebitAccountCode.DataSource = new AccountBLL().GetObjectDynamic(" left(AccountCode," + len1.ToString() + ") = '" + VNS.ERP.Data.Accounting.Account.MaterialAccount + "'", "");
                }
                else
                {
                    repLookUpEditCreditAccountCode.DataSource = new AccountBLL().GetObjectDynamic(" left(AccountCode, " + len2.ToString() + ") = '" + Account.ProductAccount + "'", "");
                    repLookUpEditDebitAccountCode.DataSource = new AccountBLL().GetObjectDynamic(" left(AccountCode, " + len2.ToString() + ") = '" + Account.ProductAccount + "'", "");
                }
                if (this.StockTransactionTypeCode == enumStockTransactionType.N11.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.N31.ToString())//nhập nguyên liệu mua
                {
                    lookUpEditDonVi.Properties.DataSource = new VendorBLL().GetAll();
                    lbDiscount.Visible = false;
                    txtDiscount.EditValue = 0;
                    txtDiscount.Visible = false;
                    lbDiscountDescription.Visible = false;
                    txtDiscountDescription.Text = "";
                    txtDiscountDescription.Visible = false;
                    chkGiamgia.Visible = false;
                    txtHTTT.Visible = false;
                    txtHTTT.Text = "";
                    lbHTTT.Visible = false;
                    this.btnPrintInvoice.Visible = false;

                    lblPaidDays.Visible = true;
                    txtPaidDays.Visible = true;
                }
                else
                {
                    //Xuất nguyên liệu bán và xuất thành phẩm bán
                    if (this.StockTransactionTypeCode == enumStockTransactionType.X14.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        lookUpEditDonVi.Properties.DataSource = new CustomerBLL().GetAll();
                        
                        chkVAT.Checked = true;
                        //chkVAT.Visible = false;
                        if (this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                        {
                            //button1.Visible = false;
                        }
                    }
                    else
                    {
                        ListBase<Subject> lst = new SubjectBLL().GetListBaseSubjectOutSide();
                        lst.Add(new Subject());
                        lookUpEditDonVi.Properties.DataSource = lst;
                        lookUpEditDonVi.ItemIndex = -1;
                        //lookUpEditDonVi.Enabled = false;
                        grBoxInvoice.Visible = false;
                        btnPrintInvoice.Visible = false;
                        //int deltaTop = gridControl1.Top - grBoxInvoice.Top;
                        //gridControl1.Top -= deltaTop;
                        gridControl1.Height += grBoxInvoice.Height;
                    }
                }
                repLookUpEditItemCode.DataSource = new ItemBLL().GetAll();
                repLookUpEditItemName.DataSource = repLookUpEditItemCode.DataSource;
                repLookUpEditStockIn.DataSource = new StockBLL().GetAll();
                repLookUpEditStockOut.DataSource = new StockBLL().GetAll();
                //repLookUpEditStockIn.DataSource = new SubjectBLL().GetDynamic(" SubjectTypeCode = 'Stock'", "");
                //repLookUpEditStockOut.DataSource = new SubjectBLL().GetDynamic(" SubjectTypeCode = 'Stock'", "");
            }
        }

        private void btnGetFromStockTransaction_Click1(object sender, EventArgs e)
        {
            if (OnbtnGetFromStockTransaction_Click != null) OnbtnGetFromStockTransaction_Click(sender, e);
        }

        private void chkGetFromStockTransaction_CheckedChanged1(object sender, EventArgs e)
        {
            if (OnchkGetFromStockTransaction_CheckedChanged != null) OnchkGetFromStockTransaction_CheckedChanged(sender, e);
            if (chkGetFromStockTransaction.Checked)
            {
                gridView1.OptionsBehavior.Editable = false;
                gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            else
            {
                bool viewMode = (this.Parent.Parent.Parent as VNS.Windows.Controls.EditControlBase).EditMode == VNS.Windows.FormEditMode.VIEW;
                if (!viewMode)
                {
                    gridView1.OptionsBehavior.Editable = true;
                    gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
                }
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridView1.RowCount > 0 && this.gridView1.OptionsBehavior.Editable == true)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.StockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.N1.ToString() || this.StockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.N3.ToString() || this.StockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.X3.ToString() || this.StockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.X1.ToString())
            {
                if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKIN.ToString())
                {
                    if (gridView1.IsNewItemRow(e.FocusedRowHandle))
                    {
                        gridView1.AddNewRow();
                        gridView1.SetRowCellValue(e.FocusedRowHandle, "DebitAccountCode", Account.MaterialAccount);
                        if (gridView1.DataRowCount - 1 >= 0)
                        {
                            gridView1.SetRowCellValue(e.FocusedRowHandle, "StockInCode", gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "StockInCode"));
                        }
                        else
                        {
                            gridView1.SetRowCellValue(e.FocusedRowHandle, "StockInCode", this.StrObject);
                        }
                    }
                }
                if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKOUT.ToString())
                {
                    if (gridView1.IsNewItemRow(e.FocusedRowHandle))
                    {
                        gridView1.AddNewRow();
                        gridView1.SetRowCellValue(e.FocusedRowHandle, "CreditAccountCode", Account.MaterialAccount);
                        if (gridView1.DataRowCount - 1 >= 0)
                        {
                            gridView1.SetRowCellValue(e.FocusedRowHandle, "StockOutCode", gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "StockOutCode"));
                        }
                        else
                        {
                            gridView1.SetRowCellValue(e.FocusedRowHandle, "StockOutCode", this.StrObject);
                        }
                    }
                }
            }
            else
            {
                if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKIN.ToString())
                {
                    if (gridView1.IsNewItemRow(e.FocusedRowHandle))
                    {
                        gridView1.AddNewRow();
                        gridView1.SetRowCellValue(e.FocusedRowHandle, "DebitAccountCode", Account.ProductAccount);
                        if (gridView1.DataRowCount - 1 >= 0)
                        {
                            gridView1.SetRowCellValue(e.FocusedRowHandle, "StockInCode", gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "StockInCode"));
                        }
                        else
                        {
                            gridView1.SetRowCellValue(e.FocusedRowHandle, "StockInCode", this.StrObject);
                        }
                    }
                }
                if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKOUT.ToString())
                {
                    if (gridView1.IsNewItemRow(e.FocusedRowHandle))
                    {
                        gridView1.AddNewRow();
                        gridView1.SetRowCellValue(e.FocusedRowHandle, "CreditAccountCode", Account.ProductAccount);
                        if (gridView1.DataRowCount - 1 >= 0)
                        {
                            gridView1.SetRowCellValue(e.FocusedRowHandle, "StockOutCode", gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "StockOutCode"));
                        }
                        else
                        {
                            gridView1.SetRowCellValue(e.FocusedRowHandle, "StockOutCode", this.StrObject);
                        }
                    }
                }
            }
            if (gridView1.IsNewItemRow(e.FocusedRowHandle))
            {
                gridView1.SetRowCellValue(e.FocusedRowHandle, "Description", txtDescription.Text);
            }
            
        }

        private void lookUpEditStockTransactionTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            Control o = this.Parent;
            while (!(o is VNS.Windows.Forms.FormEditBase))
            {
                o = o.Parent;
            }
            try
            {
                o.Text = (lookUpEditStockTransactionTypeCode.Properties.DataSource as VNS.Common.ListBase<TransactionType>).Search("TransactionTypeCode", lookUpEditStockTransactionTypeCode.EditValue.ToString()).Description;
               // o.Text = lookUpEditStockTransactionTypeCode.GetColumnValue("Description").ToString();
            }
            catch
            {
            }
            
        }

        private void txtDescription_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            txtDescription.Text = txtDescription.Text.Trim();
            ListBase<AccountTransactionStockDetail> lst = gridControl1.DataSource as ListBase<AccountTransactionStockDetail>;
            if(lst!=null)
            {
                foreach(AccountTransactionStockDetail atsd in lst)
                {
                    if (atsd.Description == null || atsd.Description == "" || atsd.Description == this.saveDescription)
                    {
                        atsd.Description = txtDescription.Text;
                    }
                }
            }
            this.saveDescription = txtDescription.Text;
            gridView1.RefreshData();
        }

        private void lookUpEditDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEditDonVi.ItemIndex >= 0)
            {
                if (lookUpEditDonVi.EditValue.ToString() != string.Empty)
                {
                    btnEditDonvi.Text = lookUpEditDonVi.GetColumnValue("SubjectName").ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnAccounted != null) OnAccounted(sender, e);
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!btnEditDonvi.Properties.ReadOnly)
            {
                Subject subjectObj = null;
                Vendor vendorObj = null;
                Customer customerObj = null;
                ListBase<Subject> lst1 = null;
                ListBase<Vendor> lst2 = null;
                ListBase<Customer> lst3 = null;
                string[] fields = { "SubjectCode", "SubjectName" };
                string[] header = { "Mã đối tượng", "Tên đối tượng" };
                if (this.StockTransactionTypeCode == enumStockTransactionType.N11.ToString())//nhập nguyên liệu mua
                {
                    lst2 = new VendorBLL().GetAll();
                    vendorObj = VNS.Windows.Forms.FormSearch.ShowSearch(lst2, fields, header) as Vendor;
                    if (vendorObj != null)
                    {
                        lookUpEditDonVi.EditValue = vendorObj.SubjectCode;
                    }
                }
                else
                {
                    //Xuất nguyên liệu bán và xuất thành phẩm bán
                    if (this.StockTransactionTypeCode == enumStockTransactionType.X14.ToString() || this.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        lst3 = new CustomerBLL().GetAll();
                        customerObj = VNS.Windows.Forms.FormSearch.ShowSearch(lst3, fields, header) as Customer;
                        if (customerObj != null)
                        {
                            lookUpEditDonVi.EditValue = customerObj.SubjectCode;
                        }
                    }
                    else
                    {
                        lst1 = new SubjectBLL().GetListBaseSubjectOutSide();
                        subjectObj = VNS.Windows.Forms.FormSearch.ShowSearch(lst1, fields, header) as Subject;
                        if (subjectObj != null)
                        {
                            lookUpEditDonVi.EditValue = subjectObj.SubjectCode;
                        }
                    }
                }
            }
        }

        private void txtStockTransactionNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //(this.Parent.Parent as UCAccountTransaction).txtAccountTransactionNo
        }

        private void btnGetFromStockTransaction_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtInvoiceThueXuat_EditValueChanged(object sender, EventArgs e)
        {
            txtTaxAmount.EditValue = Math.Round(Convert.ToDecimal(txtInvoiceThueXuat.EditValue) * Convert.ToDecimal(txtBeforeTaxAmount.EditValue), 0);
        }

        private void txtTaxAmount_EditValueChanged(object sender, EventArgs e)
        {
            txtInvoiceAmount.EditValue = Convert.ToDecimal(txtBeforeTaxAmount.EditValue) + Convert.ToDecimal(txtTaxAmount.EditValue);
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            txtBeforeTaxAmount.EditValue = this.TotalAmount - Convert.ToDecimal(txtDiscount.EditValue);
            txtInvoiceAmount.EditValue = Convert.ToDecimal(txtBeforeTaxAmount.EditValue) + Convert.ToDecimal(txtTaxAmount.EditValue);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colAmount1 || e.Column == colAmount11 || e.Column == colQuantity || e.Column == colPrice || e.Column == colPrice1)
            {
                txtBeforeTaxAmount.EditValue = this.TotalAmount - Convert.ToDecimal(txtDiscount.EditValue);
                txtInvoiceAmount.EditValue = Convert.ToDecimal(txtBeforeTaxAmount.EditValue) + Convert.ToDecimal(txtTaxAmount.EditValue);
                txtTaxAmount.EditValue = Math.Round(Convert.ToDecimal(txtBeforeTaxAmount.EditValue) * Convert.ToDecimal(txtInvoiceThueXuat.EditValue),0);
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            EditControlBase parent = (this.Parent.Parent.Parent as EditControlBase);
            if (parent.DataSource != null)
            {
                AccountTransactionStockNew accTSNew = parent.DataSource as AccountTransactionStockNew;
                foreach (AccountTransactionStockDetail accTSD in accTSNew.AccTransactionStock.Detail)
                {
                    totalAmount += accTSD.Amount;
                }
                if (accTSNew.AccTransactionStock.StockTransactionTypeCode.Substring(0, 1) == enumStockTransactionType.N11.ToString().Substring(0, 1))
                {
                    RpInStockAccount rp1 = new RpInStockAccount();
                    RpInStockAccount.Params pr;
                    //pr.Description = accTSNew.AccTransactionStock.LydoNX;
                    pr.DataItem = repLookUpEditItemCode.DataSource;
                    //pr.StockName = accTSNew.AccTransactionStock.Tenkho;
                    //pr.DonVi = accTSNew.AccTransactionStock.Donvi;
                    pr.TotalAmount = totalAmount;
                    pr.AccTSNewObj = accTSNew;
                    rp1.RpParams = pr;
                    rp1.BindData();
                    rp1.ShowPreviewDialog();
                }
                else
                {
                    RpOutStockAccount rp2 = new RpOutStockAccount();
                    RpOutStockAccount.Params pr;
                    //pr.Description = accTSNew.AccTransactionStock.LydoNX;
                    pr.DataItem = repLookUpEditItemCode.DataSource;
                    //pr.StockName = accTSNew.AccTransactionStock.Tenkho;
                    //pr.DonVi = accTSNew.AccTransactionStock.Donvi;
                    pr.TotalAmount = totalAmount;
                    pr.AccTSNewObj = accTSNew;
                    rp2.RpParam = pr;
                    rp2.BindData();
                    rp2.ShowPreviewDialog();
                    //rp2 = new RpStockTransactionDetail2(obj, Description, DataSourceLookupItem, new CustomerBLL().GetAll(), StockName);
                    //rp2.ShowPreviewDialog();
                }
            }
        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
           // MessageBox.Show("dd");
        }

        private void btnPrintReportA4_Click(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            EditControlBase parent = (this.Parent.Parent.Parent as EditControlBase);
            if (parent.DataSource != null)
            {
                AccountTransactionStockNew accTSNew = parent.DataSource as AccountTransactionStockNew;
                foreach (AccountTransactionStockDetail accTSD in accTSNew.AccTransactionStock.Detail)
                {
                    totalAmount += accTSD.CostAmount;
                }
                if (accTSNew.AccTransactionStock.StockTransactionTypeCode.Substring(0, 1) == enumStockTransactionType.N11.ToString().Substring(0, 1))
                {
                    RpInStockAccountA4 rp1 = new RpInStockAccountA4();
                    RpInStockAccountA4.Params pr;
                    //pr.Description = accTSNew.AccTransactionStock.LydoNX;
                    pr.DataItem = repLookUpEditItemCode.DataSource;
                    //pr.StockName = accTSNew.AccTransactionStock.Tenkho;
                    //pr.DonVi = accTSNew.AccTransactionStock.Donvi;
                    pr.TotalAmount = totalAmount;
                    pr.AccTSNewObj = accTSNew;
                    rp1.RpParams = pr;
                    rp1.BindData();
                    rp1.ShowPreviewDialog();
                }
                else
                {
                    RpOutStockAccountA4 rp2 = new RpOutStockAccountA4();
                    RpOutStockAccountA4.Params pr;
                    pr.DataItem = repLookUpEditItemCode.DataSource;
                    pr.TotalAmount = totalAmount;
                    pr.AccTSNewObj = accTSNew;
                    rp2.RpParam = pr;
                    rp2.BindData();
                    rp2.ShowPreviewDialog();
                }
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (this.OnPrintInvoice != null) this.OnPrintInvoice();
        }

        private void btnCopyDescription_Click(object sender, EventArgs e)
        {
            EditControlBase parent = (this.Parent.Parent.Parent as EditControlBase);
            AccountTransactionStockNew accTSNew = parent.DataSource as AccountTransactionStockNew;
            txtDescription.Text = txtDescription.Text.Trim();
            foreach (AccountTransactionStockDetail accTSD in accTSNew.AccTransactionStock.Detail)
            {
                accTSD.Description = txtDescription.Text;
            }
        }

        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                gridView1.MoveFirst();
        }

        
    }
}
