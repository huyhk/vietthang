using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;
using VNS.Windows;
using VNS.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using VNS.Utils;

namespace VNS.ERP.GUI
{
    public partial class UCAccountTransaction : EditControlBase
    {
        private ListBase<KheUocVay> lstKheuocvay;

        private AccountBLL accountBLL;
        private ListBase<Account> lstAcc;
        private DataView dv;
        private int index = -1;
        private DataView dvAccClass;
        private ListBase<Currency> lstCurrency;
        private AccountTransactionBLL accountTransactionBLL;
        private AccountSampleBLL accountSampleBLL;
        private ListBase<AccountSample> lstAccountSample;
        private AccountClassificationBLL accClassBLL;
        private SubjectBLL subjectBLL;
        private ListBase<Subject> lstSubject;
        private ListBase<AccountTransactionTypeDetail> lstTypeDetails = null;
        private string strbranchCode = "";
        private bool checkIsBindData = false;
        public string code = string.Empty;
        public string strTypeCode="";

        private DataTable dvClone=null;
        private DataTable dvAccClassClone = null;

        public string Description
        {
            get { return txtDescription.Text.Trim(); }
            set { txtDescription.Text = value; }
        }
        private string accountTransactionTypeCode;
        public virtual string AccountTransactionTypeCode
        {
            get { return accountTransactionTypeCode; }
            set
            {
                accountTransactionTypeCode = value;
                if (value != null)
                {
                    if (value == enumAccountTransactionType.BANKOUT.ToString() || value == enumAccountTransactionType.BANKIN.ToString() || value == enumAccountTransactionType.GENERAL.ToString())
                        this.tabTienvay.PageVisible = true;
                    else
                        this.tabTienvay.PageVisible = false;
                }
            }
        }
        private string strObject=string.Empty;
        public virtual string StrObject
        {
            get { return strObject; }
            set { strObject = value; }
        }

        public DateTime AccountTransactionDate
        {
            get { return cboAccountTransactionDate.DateTime; }
        }

        public UCAccountTransaction()
        {
            InitializeComponent();
            this.cboAccountTransactionDate.DateTime = Contexts.WorkingDate;

            ItemLookBranchCode.Enter += new EventHandler(ItemLook_Enter);
            ItemLookupCustomerCode.Enter += new EventHandler(ItemLook_Enter);
            ItemLookUpAccountCode.Enter += new EventHandler(ItemLook_Enter);
            cboSubjectCode1.Enter += new EventHandler(ItemLook_Enter);
            cboClassificationCode1.Enter += new EventHandler(ItemLook_Enter);
            ItemLookUpDebitAccountCode.Enter += new EventHandler(ItemLook_Enter);
            cboDebitSubject.Enter += new EventHandler(ItemLook_Enter);
            cboDebitClassification.Enter += new EventHandler(ItemLook_Enter);
            ItemLookUpEditCreditAccountCode.Enter += new EventHandler(ItemLook_Enter);
            cboCreditSubject.Enter += new EventHandler(ItemLook_Enter);
            cboCreditClassification.Enter += new EventHandler(ItemLook_Enter);
            ItemLookBranchCode1.Enter += new EventHandler(ItemLook_Enter);

            //if (Contexts.CurrentUser.IsAdmin)
            //    this.chkCheckSubject.Visible = true;
        }

        void ItemLook_Enter(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                DevExpress.XtraEditors.LookUpEdit repLookup = sender as DevExpress.XtraEditors.LookUpEdit;
                if (repLookup != null)
                {
                    repLookup.ShowPopup();
                }
            }
        }

        public virtual void BindData2()
        {
            AccountTransaction accTrans = this.DataSource as AccountTransaction;
            this.txtAccountTransactionNo.Text = accTrans.AccountTransactionNo;
            this.cboAccountTransactionDate.DateTime = accTrans.AccountTransactionDate;
            this.txtHovaTen.Text = accTrans.PersonName;
            this.txtDiachi.Text = accTrans.Address;
            this.txtChungtu.Text = accTrans.CTKemtheo;
            this.txtDescription.Text = accTrans.Description;
        }

        public void RefeshDataDetail()
        {
            gridView1.RefreshData();
            gridView2.RefreshData();
            gridView3.RefreshData();
        }

        protected override void BindData()
        {
            if (this.DataSource == null)
                this.DataSource = new AccountTransaction();
            this.txtAccountTransactionNo.Text = (this.DataSource as AccountTransaction).AccountTransactionNo;
            this.cboAccountTransactionDate.DateTime = (this.DataSource as AccountTransaction).AccountTransactionDate;
            this.cboSubjectcode2.EditValue = (this.DataSource as AccountTransaction).SubjectCode2;
            this.txtHovaTen.Text = (this.DataSource as AccountTransaction).PersonName;
            this.txtDiachi.Text = (this.DataSource as AccountTransaction).Address;
            this.txtChungtu.Text = (this.DataSource as AccountTransaction).CTKemtheo;
            this.txtDescription.Text = (this.DataSource as AccountTransaction).Description;
            this.txtSoHopdong.Text = (this.DataSource as AccountTransaction).SoHopdong;

            this.cboNgayCT.DateTime = (this.DataSource as AccountTransaction).NgayCT;
            if ((this.DataSource as AccountTransaction).Detail1 == null && this.EditMode != FormEditMode.ADD )
                (new AccountTransactionBLL()).GetDetailAccountTransaction(this.DataSource as AccountTransaction);
            if ((this.DataSource as AccountTransaction).Detail1 == null && this.EditMode == FormEditMode.ADD)
                (this.DataSource as AccountTransaction).Detail1 = new ListBase<AccountTransactionDetail1>();
           this.gridControl1.DataSource = (this.DataSource as AccountTransaction).Detail1;
           this.gridView1.TopRowIndex = 0;
           if ((this.DataSource as AccountTransaction).Detail1.Count >= 1)
               LoadTextNameDetail1((this.DataSource as AccountTransaction).Detail1[0]);
            if ((this.DataSource as AccountTransaction).Detail2 == null && this.EditMode == FormEditMode.ADD)
                (this.DataSource as AccountTransaction).Detail2 = new ListBase<AccountTransactionDetail2>();
            if ((this.DataSource as AccountTransaction).Detail2 == null && this.EditMode == FormEditMode.EDIT)
                (this.DataSource as AccountTransaction).Detail2 = new ListBase<AccountTransactionDetail2>();
            this.gridControl2.DataSource = (this.DataSource as AccountTransaction).Detail2;
            this.gridView2.TopRowIndex = 0;
            if((this.DataSource as AccountTransaction).Detail2.Count>=1)
                LoadTextNameDetail2((this.DataSource as AccountTransaction).Detail2[0]);
            if ((this.DataSource as AccountTransaction).Invoice == null && this.EditMode == FormEditMode.EDIT)
                (this.DataSource as AccountTransaction).Invoice = new ListBase<Invoice>();
            if ((this.DataSource as AccountTransaction).Invoice == null && this.EditMode == FormEditMode.ADD)
                (this.DataSource as AccountTransaction).Invoice = new ListBase<Invoice>();
            this.gridControl3.DataSource = (this.DataSource as AccountTransaction).Invoice;
            this.gridView3.TopRowIndex = 0;
            if ((this.DataSource as AccountTransaction).BuyNoInvoice == null && this.EditMode == FormEditMode.EDIT)
                (this.DataSource as AccountTransaction).BuyNoInvoice = new ListBase<BuyNoInvoice>();
            if ((this.DataSource as AccountTransaction).BuyNoInvoice == null && this.EditMode == FormEditMode.ADD)
                (this.DataSource as AccountTransaction).BuyNoInvoice = new ListBase<BuyNoInvoice>();
            this.gridControl4.DataSource = (this.DataSource as AccountTransaction).BuyNoInvoice;
            this.gridView4.TopRowIndex = 0;
           
            checkIsBindData = true;

            this.lokKheuocvay.EditValue = (this.DataSource as AccountTransaction).Tienvay.KheuocvayID;
            this.txtTienvayDueDate.DateTime = (this.DataSource as AccountTransaction).Tienvay.NextDatePaid;
            this.chkTratattoan.Checked = (this.DataSource as AccountTransaction).Tienvay.LastPaid;
        }
        private void LoadTextNameDetail1(AccountTransactionDetail1 accDetail)
        {
            if (accDetail.AccountCode != string.Empty)
            {
                this.txtAccountName.Text = lstAcc.Search("AccountCode", accDetail.AccountCode).AccountName;
                dv.Sort = "SubjectCode ASC";
                int i = dv.Find(accDetail.SubjectCode);
                if (i >= 0)
                {
                    this.txtSubjectName.Text = dv[i]["SubjectName"].ToString();
                }
                else
                    this.txtSubjectName.Text = "";
                dvAccClass.Sort = "ClassificationCode ASC";
                int l = dvAccClass.Find(accDetail.ClassificationCode);
                if (l >= 0)
                    this.txtClassificationName.Text = dvAccClass[l]["ClassificationName"].ToString();
                else
                    this.txtClassificationName.Text = "";
            }
        }
        private void LoadTextNameDetail2(AccountTransactionDetail2 accDetail)
        {
            if (accDetail.DebitAccountCode != string.Empty && accDetail.CreditAccountCode != string.Empty)
            {
                Account acc=lstAcc.Search("AccountCode", accDetail.DebitAccountCode);
                if(acc !=null)
                    this.txtAccountName1.Text = acc.AccountName;
                else
                    this.txtAccountName1.Text = "";
                acc = lstAcc.Search("AccountCode", accDetail.CreditAccountCode);
                if(acc !=null)
                    this.txtAccountName2.Text = lstAcc.Search("AccountCode", accDetail.CreditAccountCode).AccountName;
                else
                    this.txtAccountName2.Text ="";
                int i = dv.Find(accDetail.DebitSubjectCode);
                int j = dv.Find(accDetail.CreditSubjectCode);
                if (i >= 0)
                    this.txtSubjectName1.Text = dv[i]["SubjectName"].ToString();
                else
                    this.txtSubjectName1.Text = "";
                if (j >= 0)
                    this.txtSubjectName2.Text = dv[j]["SubjectName"].ToString();
                else
                    this.txtSubjectName2.Text = "";
                dvAccClass.Sort = "ClassificationCode ASC";
                int l = dvAccClass.Find(accDetail.DebitClassificationCode);
                int m = dvAccClass.Find(accDetail.CreditClassificationCode);
                if (l >= 0)
                    this.txtClassifiCationName1.Text = dvAccClass[l]["ClassificationName"].ToString();
                else
                    this.txtClassifiCationName1.Text = "";
                if (m >= 0)
                    this.txtClassificationName2.Text = dvAccClass[m]["ClassificationName"].ToString();
                else
                    this.txtClassificationName2.Text = "";
            }
        }
        protected override int ValidateData()
        {
            bool checkSubjectCode = false, checkClassification = false;
            decimal totalDebitAmount = 0;
            decimal totalCreditAmount = 0;
            RemoveObject((this.gridControl1.DataSource as ListBase<AccountTransactionDetail1>), (this.gridControl2.DataSource as ListBase<AccountTransactionDetail2>),
                (this.gridControl3.DataSource as ListBase<Invoice>),(this.gridControl4.DataSource as ListBase<BuyNoInvoice> ));
            if (this.txtAccountTransactionNo.Text == string.Empty)
            {
                this.txtAccountTransactionNo.Focus();
                return -1;
            }
            foreach (AccountTransactionDetail1 accdDetail1 in (this.gridControl1.DataSource as ListBase<AccountTransactionDetail1>))
            {
                totalDebitAmount += accdDetail1.DebitAmount;
                totalCreditAmount += accdDetail1.CreditAmount;

                if (this.chkCheckSubject.Checked)
                {
                    checkSubjectCode = CheckDataInCellSubjectCode(accdDetail1.SubjectCode, accdDetail1.AccountCode);
                    //Ngày 27/10/2007 bỏ phần kiểm tra Yếu tố có phù hợp với Tài khoản khi Save, còn phần kiểm tra trên From thì vẫn dữ nguyên.
                    //checkClassification = CheckDataInCellClassificationCode(accdDetail1.ClassificationCode, accdDetail1.AccountCode);
                    if (checkSubjectCode == false)
                        return -3;
                }
                //if (checkClassification == false)
                //    return -4;
                if (accdDetail1.DebitAmount != 0 && accdDetail1.CreditAmount != 0)
                {
                    return -7;
                }
            }
            if (totalDebitAmount != totalCreditAmount)
                return -2;
            if (accountTransactionBLL.CheckAccountDetailKind((this.DataSource as AccountTransaction).Detail1) == 1 || (accountTransactionBLL.CheckAccountDetailKind((this.DataSource as AccountTransaction).Detail1) == 2))
            {
                if (accountTransactionBLL.CompareDetail1(this.DataSource as AccountTransaction) == false)
                {
                    accountTransactionBLL.RefeshDetail2(this.DataSource as AccountTransaction);
                }
            }
            if (accountTransactionBLL.CompareDetail1(this.DataSource as AccountTransaction) == false)
                return -5;
            foreach(Invoice invoice in (this.gridControl3.DataSource as ListBase<Invoice>))
            {
                if (invoice.Tienthue != 0 && invoice.Khongchiuthue == true)
                    return -8;
                if (invoice.BranchCode == string.Empty)
                    return -9;
            }
            foreach (BuyNoInvoice buyNo in (this.gridControl4.DataSource as ListBase<BuyNoInvoice>))
            {
                if (buyNo.BranchCode == string.Empty)
                    return -10;
            }
            if(this.cboAccountTransactionDate.DateTime < this.cboNgayCT.DateTime)
            {
                return -70;
            }
            if (!(this.DataSource as AccountTransaction).Check133())
            {
                MessageBox.Show("Thuế đầu vào và tk 133 không khớp!");
            }
            AutoCompleteUtils.AddAutoCompleteSource(this.txtHovaTen);
            return 0;
        }

        protected override void AssignData()
        {
            if (this.DataSource == null)
                this.DataSource = new AccountTransaction();
            (this.DataSource as AccountTransaction).AccountTransactionNo = this.txtAccountTransactionNo.Text;
            (this.DataSource as AccountTransaction).AccountTransactionDate = this.cboAccountTransactionDate.DateTime;
            (this.DataSource as AccountTransaction).PersonName = this.txtHovaTen.Text;
            (this.DataSource as AccountTransaction).Address = this.txtDiachi.Text;
            (this.DataSource as AccountTransaction).CTKemtheo = this.txtChungtu.Text;
            (this.DataSource as AccountTransaction).Description = this.txtDescription.Text;
            (this.DataSource as AccountTransaction).SoHopdong = this.txtSoHopdong.Text;

            (this.DataSource as AccountTransaction).NgayCT = this.cboNgayCT.DateTime;
            (this.DataSource as AccountTransaction).SubjectCode1 = strObject;
            (this.DataSource as AccountTransaction).SubjectCode2 = this.cboSubjectcode2.EditValue.ToString();
            (this.DataSource as AccountTransaction).AccountTransactionTypeCode = AccountTransactionTypeCode;
            (this.DataSource as AccountTransaction).DetailTransactionCode= strTypeCode;

            (this.DataSource as AccountTransaction).Tienvay.KheuocvayID = (Guid)this.lokKheuocvay.EditValue;
            (this.DataSource as AccountTransaction).Tienvay.NextDatePaid = this.txtTienvayDueDate.DateTime;
            (this.DataSource as AccountTransaction).Tienvay.LastPaid = this.chkTratattoan.Checked;


            if(this.EditMode==FormEditMode.ADD)
                (this.DataSource as AccountTransaction).UserCreated = Contexts.CurrentUser.LoginName;
            (this.DataSource as AccountTransaction).UserUpdated = Contexts.CurrentUser.LoginName;
            AutoCompleteUtils.SaveAutoComplete(this.txtHovaTen);
            AutoCompleteUtils.SaveAutoComplete(this.txtAddress);
            AutoCompleteUtils.SaveAutoComplete(this.txtTenMathang);
            AutoCompleteUtils.SaveAutoComplete(this.txtTenNguoiban);
            AutoCompleteUtils.SaveAutoComplete(this.txtTenDonvi);
            AutoCompleteUtils.SaveAutoComplete(this.txtTenMathangIn);
            AutoCompleteUtils.SaveAutoComplete(this.txtMasothue);
            AutoCompleteUtils.SaveAutoComplete(this.txtMauHoadon);
            AutoCompleteUtils.SaveAutoComplete(this.txtSoSeri);
            base.AssignData();
        }

        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == FormEditMode.VIEW;
            this.txtTienvayDueDate.Properties.ReadOnly = viewMode;
            this.chkTratattoan.Properties.ReadOnly = viewMode;


            this.btnCopyDescription.Enabled = this.EditMode != FormEditMode.VIEW;
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtAccountTransactionNo.Properties.ReadOnly = false;
                this.cboAccountTransactionDate.Properties.ReadOnly = false;
                this.txtHovaTen.ReadOnly = false;
                this.txtDiachi.Properties.ReadOnly = false;
                this.txtChungtu.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtSoHopdong.ReadOnly = false;
                this.gridView1.OptionsBehavior.Editable = true;
                this.gridView2.OptionsBehavior.Editable = true;
                this.gridView3.OptionsBehavior.Editable = true;
                this.gridView4.OptionsBehavior.Editable = true;
                this.cboAccountSample.Properties.ReadOnly = false;
                this.cboSubjectcode2.Properties.ReadOnly = false;
                this.cboNgayCT.Properties.ReadOnly = false;
                this.txtAccountTransactionNo.Focus();
                this.txtSubjectName.Text = "";
                this.txtClassificationName.Text = "";
                this.txtClassifiCationName1.Text = "";
                this.txtClassificationName2.Text = "";
                this.txtSubjectName1.Text = "";
                this.txtSubjectName2.Text = "";
                this.txtAccountName.Text = "";
                this.txtAccountName1.Text = "";
                this.txtAccountName2.Text = "";

                //BuynoInvoice
                this.cboNgaymua.Properties.ReadOnly = false;
                this.txtSoluong.Properties.ReadOnly = false;
                this.txtDongia.Properties.ReadOnly = false;
                this.txtTienthanhtoan.Properties.ReadOnly = false;
                this.txtGhichu.Properties.ReadOnly = false;
                this.cboBranchCode.Properties.ReadOnly = false;
                this.txtTenMathang.ReadOnly = false;
                this.txtTenNguoiban.ReadOnly = false;
                this.txtAddress.ReadOnly = false;
                this.btnAddGrid.Enabled = true;
                this.btnAddInvoice.Enabled = true;
                RefreshTextBoxInvoice(false);
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtAccountTransactionNo.Properties.ReadOnly = false;
                this.cboAccountTransactionDate.Properties.ReadOnly = false;
                this.txtHovaTen.ReadOnly = false;
                this.txtDiachi.Properties.ReadOnly = false;
                this.txtChungtu.Properties.ReadOnly = false;
                this.gridView1.OptionsBehavior.Editable = true;
                this.gridView2.OptionsBehavior.Editable = true;
                this.gridView3.OptionsBehavior.Editable = true;
                this.gridView4.OptionsBehavior.Editable = true;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtSoHopdong.ReadOnly = false;
                this.cboSubjectcode2.Properties.ReadOnly = false;
                this.cboNgayCT.Properties.ReadOnly = false;
                this.cboAccountSample.Properties.ReadOnly = false;
                this.cboAccountSample.EditValue = "";
                this.txtAccountTransactionNo.Focus();

                //BuynoInvoice
                this.cboNgaymua.Properties.ReadOnly = false;
                this.txtSoluong.Properties.ReadOnly = false;
                this.txtDongia.Properties.ReadOnly = false;
                this.txtTienthanhtoan.Properties.ReadOnly = false;
                this.txtGhichu.Properties.ReadOnly = false;
                this.cboBranchCode.Properties.ReadOnly = false;
                this.txtTenMathang.ReadOnly = false;
                this.txtTenNguoiban.ReadOnly = false;
                this.txtAddress.ReadOnly = false;
                this.btnAddGrid.Enabled = true;
                this.btnAddInvoice.Enabled = true;
                RefreshTextBoxInvoice(false);
            }
            else
            {
                this.txtAccountTransactionNo.Properties.ReadOnly = true;
                this.cboAccountTransactionDate.Properties.ReadOnly = true;
                this.txtHovaTen.ReadOnly = true;
                this.txtDiachi.Properties.ReadOnly = true;
                this.txtChungtu.Properties.ReadOnly = true;
                this.gridView1.OptionsBehavior.Editable = false;
                this.gridView2.OptionsBehavior.Editable = false;
                this.gridView3.OptionsBehavior.Editable = false;
                this.gridView4.OptionsBehavior.Editable = false;
                this.txtDescription.Properties.ReadOnly = true;
                this.txtSoHopdong.ReadOnly = true;
                this.cboAccountSample.Properties.ReadOnly = true;
                this.cboSubjectcode2.Properties.ReadOnly = true;
                this.cboNgayCT.Properties.ReadOnly = true;
                this.cboAccountSample.EditValue = "";
                this.txtAccountTransactionNo.Focus();

                //BuynoInvoice
                this.cboNgaymua.Properties.ReadOnly = true;
                this.txtSoluong.Properties.ReadOnly = true;
                this.txtDongia.Properties.ReadOnly = true;
                this.txtTienthanhtoan.Properties.ReadOnly = true;
                this.txtGhichu.Properties.ReadOnly = true;
                this.cboBranchCode.Properties.ReadOnly = true;
                this.txtTenMathang.ReadOnly = true;
                this.txtTenNguoiban.ReadOnly = true;
                this.txtAddress.ReadOnly = true;
                this.btnAddGrid.Enabled = false;
                this.btnAddInvoice.Enabled = false;
                RefreshTextBoxInvoice(true);
            }
            ClearTextBuynoInvoice();
            ClearTextInvoice();
            RefreshGrildView();
            base.RefreshControl();
        }

        private void RefreshGrildView()
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                this.gridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                this.gridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                this.gridView4.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
            else
            {
                this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                this.gridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                this.gridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                this.gridView4.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }
        private void UCAccountTransaction_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.ConfirmOwner();
                if (Contexts.CurrentUser.IsAdmin)
                    this.chkCheckSubject.Visible = true;
            }
        }

        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                DataTable dtSubject = null;
                DataTable dtClassification = null;
                lstTypeDetails = new AccountTransactionTypeDetailBLL().GetAll();
                accClassBLL = new AccountClassificationBLL();
                subjectBLL = new SubjectBLL();
                this.colTienthue.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
                ListBase<Branch> lstBranch = new BranchBLL().GetAll();
                lstSubject=subjectBLL.GetAll();
                accountTransactionBLL = new AccountTransactionBLL();
                accountBLL = new AccountBLL();
                lstAcc = accountBLL.GetAll();//accountBLL.GetListAccountIsNotParentAccount();
                if(dvAccClassClone==null)
                    dvAccClassClone = accClassBLL.GetAllToDataTable();
                if(dvAccClass==null)
                    dvAccClass = dvAccClassClone.Copy().DefaultView;
                lstCurrency = new ListBase<Currency>();
                lstCurrency = (new CurrencyBL()).GetAll();
                Currency cr = new Currency();
                cr.CurrencyCode = "";
                lstCurrency.Add(cr);
                lstCurrency.Sort("CurrencyCode", ListSortDirection.Descending);
                this.cboBranchCode.Properties.DataSource = lstBranch;
                foreach (Account acc in lstAcc)
                {
                    if (acc.LstAccSubjectType == null)
                    {
                        acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                    }
                }
                this.ItemLookUpAccountCode.DataSource = lstAcc;
                this.ItemLookUpDebitAccountCode.DataSource = lstAcc;
                this.ItemLookUpEditCreditAccountCode.DataSource = lstAcc;
                this.ItemLookUpEditCurrency.DataSource = lstCurrency;
                if (accountSampleBLL == null)
                {
                    accountSampleBLL = new AccountSampleBLL();
                    if(this.DataSource!=null)
                    lstAccountSample = accountSampleBLL.GetListAccountSamplesByTypeCode((this.DataSource as AccountTransaction).AccountTransactionTypeCode);
                }
                this.cboAccountSample.Properties.DataSource = lstAccountSample;
                if(dvClone==null)
                    dvClone = subjectBLL.GetAllToDataTable();
                if (dv == null) 
                    dv = dvClone.Copy().DefaultView;
                dtSubject = dvClone;//subjectBLL.GetAllToDataTable();
                dtClassification = dvAccClassClone;// accClassBLL.GetAllToDataTable();
                this.cboSubjectCode1.DataSource = dtSubject;
                this.cboClassificationCode1.DataSource = dtClassification;
                this.cboDebitSubject.DataSource = dtSubject;
                this.cboDebitClassification.DataSource = dtClassification;
                this.cboCreditSubject.DataSource = dtSubject;
                this.cboCreditClassification.DataSource = dtClassification;

                //this.cboSubjectCode1.Buttons.Clear();
                //this.cboClassificationCode1.Buttons.Clear();
                //this.cboDebitSubject.Buttons.Clear();
                //this.cboDebitClassification.Buttons.Clear();
                //this.cboCreditSubject.Buttons.Clear();
                //this.cboCreditClassification.Buttons.Clear();

                this.ItemLookUpAccountCode.Buttons.Clear();
                this.ItemLookUpDebitAccountCode.Buttons.Clear();
                this.ItemLookUpEditCreditAccountCode.Buttons.Clear();

                this.ItemLookBranchCode.DataSource = lstBranch;
                this.ItemLookBranchCode1.DataSource = lstBranch;
                lstSubject.Insert(0,(new Subject()));
                this.cboSubjectcode2.Properties.DataSource =lstSubject ;
                this.ItemLookupCustomerCode.DataSource = lstSubject;
                this.cboCustomerCode.Properties.DataSource = lstSubject;
                this.cboChinhanh.Properties.DataSource = lstBranch;
                //if (this.StrObject == string.Empty && this.strTypeCode == string.Empty)
                //    this.txtAccountTransactionNo.Properties.Buttons.Clear();
                if (strObject != string.Empty)
                {
                    Subject sobj= lstSubject.Search("SubjectCode", StrObject);
                    this.txtObject.Text =sobj.SubjectName;
                    strbranchCode = sobj.BranchCode;
                }
                else
                {
                    this.txtObject.Visible = false;
                    this.lblObject.Visible = false;
                    //this.tableLayoutPanel2.ColumnStyles[0].SizeType = SizeType.Percent;
                    //this.tableLayoutPanel2.ColumnStyles[0].Width = 20.63686F;
                }
                if (strTypeCode == string.Empty)
                {
                    this.txtTransactionTypeCode.Visible = false;
                    this.lblTransactionTypeCode.Visible = false;
                }
                else
                    this.txtTransactionTypeCode.Text = lstTypeDetails.Search("DetailTransactionCode", strTypeCode).DetailTransactionName;
                this.cboBranchCode.EditValue = strbranchCode;
                this.cboChinhanh.EditValue = this.GetStrBrandCode();
                this.cboNgayHoadon.DateTime = Contexts.WorkingDate;
                this.cboNgaymua.DateTime = Contexts.WorkingDate;
                AutoCompleteUtils.LoadAutoComplete(this.txtHovaTen);
                AutoCompleteUtils.LoadAutoComplete(this.txtAddress);
                AutoCompleteUtils.LoadAutoComplete(this.txtTenNguoiban);
                AutoCompleteUtils.LoadAutoComplete(this.txtTenMathang);
                AutoCompleteUtils.LoadAutoComplete(this.txtTenMathangIn);
                AutoCompleteUtils.LoadAutoComplete(this.txtTenDonvi);
                AutoCompleteUtils.LoadAutoComplete(this.txtMasothue);
                AutoCompleteUtils.LoadAutoComplete(this.txtMauHoadon);
                AutoCompleteUtils.LoadAutoComplete(this.txtSoSeri);

                lstKheuocvay = new KheUocVayBLL().GetAll();
                lstKheuocvay.Insert(0, new KheUocVay());
                this.lokKheuocvay.Properties.DataSource = lstKheuocvay;

                ListBase<Congtrinh> lstCongtrinh = new CongtrinhBLL().GetAll();
                lstCongtrinh.Insert(0, new Congtrinh());
                this.repCongtrinh.DataSource = lstCongtrinh;
            }
        }

        /// <summary>
        /// Lấy AccountSample đưa vào luới.
        /// Có hai trường hợp: nếu AccountTransactionCodeType=AccountSampleCode 
        /// thì tham số truyền vòa là rỗng hoặc null. Ngược lại AccountTransactionCodeType!=AccountSampleCode
        /// thi tham số truyền vào là AccountSampleCode;
        /// </summary>
        /// <param name="accountSampleCode"></param>
        public void SetAccountSample(string accountSampleCode)
        {
             accountSampleBLL = new AccountSampleBLL();
            AccountSample accSple;
             lstAccountSample = accountSampleBLL.GetListAccountSamplesByTypeCode(this.AccountTransactionTypeCode);
            if (this.EditMode == FormEditMode.ADD)
            {
                if(accountSampleCode==string.Empty || accountSampleCode==null)
                    accSple = lstAccountSample.Search("AccountSampleCode", this.AccountTransactionTypeCode);
                else
                    accSple = lstAccountSample.Search("AccountSampleCode", accountSampleCode);
                if (accSple != null)
                {
                    accountSampleBLL.GetDetailAccountSamples(accSple);
                    SetDataSoucedGetAccountSample(accSple);
                    if (checkIsBindData == true)
                    {
                        this.gridControl1.DataSource = (this.DataSource as AccountTransaction).Detail1;
                        this.gridControl2.DataSource = (this.DataSource as AccountTransaction).Detail2;
                    }
                }
            }
        }
        private void cboAccountSample_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cboAccountSample.ItemIndex >= 0)
            {
                accountSampleBLL.GetDetailAccountSamples(lstAccountSample[this.cboAccountSample.ItemIndex]);
                SetDataSoucedGetAccountSample(lstAccountSample[this.cboAccountSample.ItemIndex]);
                this.gridControl1.DataSource = (this.DataSource as AccountTransaction).Detail1;
                this.gridControl2.DataSource = (this.DataSource as AccountTransaction).Detail2;
            }
        }

        #region gridControl1
        /// <summary>
        /// Kiểm tra AccountCode trước khi Leave khỏi cell của Gridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemLookUpAccountCode_Leave(object sender, EventArgs e)
        {
            
                index = -1;
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            if (cr.Count > 0)
            {
                index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail1).AccountCode);
                if (index >= 0)
                {
                    this.txtAccountName.Text = lstAcc[index].AccountName;
                    if (lstAcc[index].DetailSubject == false)
                    {
                        (cr.Current as AccountTransactionDetail1).SubjectCode = "";
                        this.colSubjectCode.OptionsColumn.AllowFocus = false;
                        this.txtSubjectName.Text = "";
                    }
                    else
                        this.colSubjectCode.OptionsColumn.AllowFocus = true;

                    if (lstAcc[index].DetailClassification == false)
                    {
                        (cr.Current as AccountTransactionDetail1).ClassificationCode = "";
                        this.colClassificationCode.OptionsColumn.AllowFocus = false;
                        this.txtClassificationName.Text = "";
                    }
                    else
                        this.colClassificationCode.OptionsColumn.AllowFocus = true;

                    string acc = lstAcc[index].AccountCode.Substring(0, 3);
                    if (acc == "241" || acc == "211")
                        this.colCongtrinh.OptionsColumn.AllowFocus = true;
                    else
                    {
                        this.colCongtrinh.OptionsColumn.AllowFocus = false;
                        (cr.Current as AccountTransactionDetail1).CongtrinhCode = "";
                    }
                }

            }
        }
        /// <summary>
        /// Lấy gía trị hiện thời trên cell đưa vào CurrencyManager;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemLookUpAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (this.gridView1.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail1).AccountCode = this.gridView1.ActiveEditor.Text;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ListBase<AccountTransactionDetail1> lstDetai1l= (this.gridControl1.DataSource as ListBase<AccountTransactionDetail1>);
                if (!gridView1.IsFocusedView)
                   return;
                if (e.FocusedRowHandle == -999999)
                    return;
                dv.RowFilter = "";
                dvAccClass.RowFilter = "";
                decimal totalDebitAmount = 0;
                decimal totalCreditAmount = 0;
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if (this.editMode != FormEditMode.VIEW)
                    if (this.txtDescription.Text != string.Empty && (cr.Current as AccountTransactionDetail1).Description == string.Empty)
                        this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, colDescription, this.txtDescription.Text);
                    if (gridView1.IsNewItemRow(e.FocusedRowHandle))
                    {
                        if (!this.gridView1.IsFirstRow)
                        {
                            this.gridView1.AddNewRow();
                            this.gridView1.SetRowCellValue(e.FocusedRowHandle, colDescription, this.txtDescription.Text);
                        }
                        foreach (AccountTransactionDetail1 accdDetail1 in lstDetai1l)
                        {
                            totalDebitAmount += accdDetail1.DebitAmount;
                            totalCreditAmount += accdDetail1.CreditAmount;
                        }
                        if (totalDebitAmount > totalCreditAmount)
                        {
                            totalCreditAmount = totalDebitAmount - totalCreditAmount;
                            gridView1.SetRowCellValue(e.FocusedRowHandle, colCreditAmount, totalCreditAmount);
                            gridView1.SetRowCellValue(e.FocusedRowHandle, colDebitAmount, 0);
                        }
                        else if (totalDebitAmount < totalCreditAmount)
                        {
                            totalDebitAmount = totalCreditAmount - totalDebitAmount;
                            gridView1.SetRowCellValue(e.FocusedRowHandle, colCreditAmount, 0);
                            gridView1.SetRowCellValue(e.FocusedRowHandle, colDebitAmount, totalDebitAmount);
                        }
                    }
                    else
                    {
                        if (lstDetai1l[e.FocusedRowHandle].DebitAmount == 0 && lstDetai1l[e.FocusedRowHandle].CreditAmount == 0)
                        {
                            foreach (AccountTransactionDetail1 accdDetail1 in lstDetai1l)
                            {
                                totalDebitAmount += accdDetail1.DebitAmount;
                                totalCreditAmount += accdDetail1.CreditAmount;
                            }
                            if (totalDebitAmount > totalCreditAmount)
                            {
                                totalCreditAmount = totalDebitAmount - totalCreditAmount;
                                gridView1.SetRowCellValue(e.FocusedRowHandle, colCreditAmount, totalCreditAmount);
                                gridView1.SetRowCellValue(e.FocusedRowHandle, colDebitAmount, 0);
                            }
                            else if (totalDebitAmount < totalCreditAmount)
                            {
                                totalDebitAmount = totalCreditAmount - totalDebitAmount;
                                gridView1.SetRowCellValue(e.FocusedRowHandle, colCreditAmount, 0);
                                gridView1.SetRowCellValue(e.FocusedRowHandle, colDebitAmount, totalDebitAmount);
                            }
                        }
                    }


                    index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail1).AccountCode);
                    if (index >= 0)
                    {
                        this.txtAccountName.Text = lstAcc[index].AccountName;
                        if (lstAcc[index].DetailSubject == false)
                        {
                            (cr.Current as AccountTransactionDetail1).SubjectCode = "";
                            this.colSubjectCode.OptionsColumn.AllowFocus = false;
                            this.txtSubjectName.Text = "";
                        }
                        else
                        {
                            this.colSubjectCode.OptionsColumn.AllowFocus = true;
                            dv.Sort = "SubjectCode ASC";
                            int i = dv.Find((cr.Current as AccountTransactionDetail1).SubjectCode);
                            if (i >= 0)
                            {
                                this.txtSubjectName.Text = dv[i]["SubjectName"].ToString();
                            }
                            else
                                this.txtSubjectName.Text = "";
                        }
                        if (lstAcc[index].DetailClassification == false)
                        {
                            (cr.Current as AccountTransactionDetail1).ClassificationCode = "";
                            this.txtClassificationName.Text = "";
                            this.colClassificationCode.OptionsColumn.AllowFocus = false;
                        }
                        else
                        {
                            dvAccClass.Sort = "ClassificationCode ASC";
                            this.colClassificationCode.OptionsColumn.AllowFocus = true;
                            int k = dvAccClass.Find((cr.Current as AccountTransactionDetail1).ClassificationCode);
                            if (k >= 0)
                                this.txtClassificationName.Text = dvAccClass[k]["ClassificationName"].ToString();
                            else
                                this.txtClassificationName.Text = "";
                        }
                        if ((cr.Current as AccountTransactionDetail1).CurrencyCode == "")
                        {
                            this.colRate.OptionsColumn.AllowFocus = false;
                            this.colDebitAmountNT.OptionsColumn.AllowFocus = false;
                            this.colCreditAmountNT.OptionsColumn.AllowFocus = false;
                        }
                        else
                        {
                            this.colRate.OptionsColumn.AllowFocus = true;
                            this.colDebitAmountNT.OptionsColumn.AllowFocus = true;
                            this.colCreditAmountNT.OptionsColumn.AllowFocus = true;
                        }

                    string acc = lstAcc[index].AccountCode.Substring(0, 3);
                    if (acc == "241" || acc == "211")
                        this.colCongtrinh.OptionsColumn.AllowFocus = true;
                    else
                        this.colCongtrinh.OptionsColumn.AllowFocus = false;
                }

                }
                else
                {
                    this.gridView1.AddNewRow();
                    this.gridView1.SetRowCellValue(e.FocusedRowHandle, colDescription, this.txtDescription.Text);
                }
        }
        private void gridView1_GotFocus(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if (this.txtDescription.Text != string.Empty && (cr.Current as AccountTransactionDetail1).Description == string.Empty)
                        this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, colDescription, this.txtDescription.Text);

                    index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail1).AccountCode);
                    if (index >= 0)
                    {
                        string acc = lstAcc[index].AccountCode.Substring(0, 3);
                        if (acc == "241" || acc == "211")
                            this.colCongtrinh.OptionsColumn.AllowFocus = true;
                        else
                            this.colCongtrinh.OptionsColumn.AllowFocus = false;
                    }
                }
            }
        }
       
        private FormEditBase owner;

        private void ConfirmOwner()
        {
            Control o = this.Parent;
            while (!(o is FormEditBase))
            {
                o = o.Parent;
            }
            this.owner = o as FormEditBase;
        }

        private void cboSubjectCode1_Leave(object sender, EventArgs e)
        {
            if (this.chkCheckSubject.Checked == false)
                return;
            string strFilter = "";
            index = -1;
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            if (cr.Count > 0)
            {
                index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail1).AccountCode);
                if (index >= 0)
                {
                    foreach (AccountSubjectType accObj in lstAcc[index].LstAccSubjectType)
                    {
                        strFilter += "'" + accObj.SubjectTypeCode + "',";
                    }
                    if (!strFilter.Equals(""))
                    {
                        strFilter = "SubjectTypeCode in (" + strFilter + ")";
                        dv.RowFilter = strFilter;
                    }
                }
                if ((cr.Current as AccountTransactionDetail1).SubjectCode == "")
                {
                    if ((cr.Current as AccountTransactionDetail1).AccountCode != "")
                        if (this.gridView1.ActiveEditor == null)
                        {

                            SetDataRowCellSubjectCode(dv, this.gridView1, this.colSubjectCode);
                        }
                        else
                            CheckValueCellSubjectCodeFocus(this.gridView1.ActiveEditor.Text, dv, this.gridView1, this.colSubjectCode);
                }
                else
                    CheckValueCellSubjectCodeFocus((cr.Current as AccountTransactionDetail1).SubjectCode, dv, this.gridView1, this.colSubjectCode);
            }
        }

        private void cboSubjectCode1_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (this.gridView1.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail1).SubjectCode = this.gridView1.ActiveEditor.Text;
            }
        }

        private void cboClassificationCode1_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (this.gridView1.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail1).ClassificationCode = this.gridView1.ActiveEditor.Text;
            }
        }

        private void cboClassificationCode1_Leave(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                index = -1;
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail1).AccountCode);
                    if ((cr.Current as AccountTransactionDetail1).ClassificationCode == "")
                    {
                        if (index >= 0)
                        {
                            dvAccClass.RowFilter = "ClassificationTypeCode in ('" + lstAcc[index].ClassificationTypeCode + "')";

                            if (lstAcc[index].ClassificationTypeCode != "")
                            {
                                SetDataRowCellClassificationCode(lstAcc[index].ClassificationTypeCode, this.gridView1, this.colClassificationCode);
                            }
                        }
                    }
                    else
                        CheckValueCellClassificationFocus((cr.Current as AccountTransactionDetail1).ClassificationCode, this.gridView1, this.colClassificationCode, index);
                }
            }
        }
       
        private void ItemLookUpEditCurrency_Leave(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if ((cr.Current as AccountTransactionDetail1).CurrencyCode == "")
                    {
                        this.colRate.OptionsColumn.AllowFocus = false;
                        this.colDebitAmountNT.OptionsColumn.AllowFocus = false;
                        this.colCreditAmountNT.OptionsColumn.AllowFocus = false;
                    }
                    else
                    {
                        this.colRate.OptionsColumn.AllowFocus = true;
                        this.colDebitAmountNT.OptionsColumn.AllowFocus = true;
                        this.colCreditAmountNT.OptionsColumn.AllowFocus = true;
                    }
                }
            }
        }

        private void ItemLookUpEditCurrency_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (this.gridView1.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail1).CurrencyCode = this.gridView1.ActiveEditor.Text;
            }
        }
     
 #endregion

        #region gridControl2

        private void ItemLookUpDebitAccountCode_Leave(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                int indexDebit = -1;
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    indexDebit = ItemLookUpDebitAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail2).DebitAccountCode);
                    if (indexDebit >= 0)
                    {
                        this.txtAccountName1.Text = lstAcc[indexDebit].AccountName;
                        if (lstAcc[indexDebit].DetailSubject == false)
                        {
                            (cr.Current as AccountTransactionDetail2).DebitSubjectCode = "";
                            this.colDebitSubjectCode.OptionsColumn.AllowFocus = false;
                            this.txtSubjectName1.Text = "";
                        }
                        else
                            this.colDebitSubjectCode.OptionsColumn.AllowFocus = true;

                        if (lstAcc[indexDebit].DetailClassification == false)
                        {
                            (cr.Current as AccountTransactionDetail2).DebitClassificationCode = "";
                            this.colDebitClassificationCode.OptionsColumn.AllowFocus = false;
                            this.txtClassifiCationName1.Text = "";
                        }
                        else
                            this.colDebitClassificationCode.OptionsColumn.AllowFocus = true;
                    }
                }
            }
        }

        private void ItemLookUpDebitAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (this.gridView2.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail2).DebitAccountCode = this.gridView2.ActiveEditor.Text;
            }
        }
     
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
                if (!this.gridView2.IsFocusedView)
                    return;
                if (e.FocusedRowHandle == -999999)
                    return;

                dv.RowFilter = "";
                dvAccClass.RowFilter = "";
                int indexDebit = -1;
                int indexCredit = -1;
                ///Debit
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                        if (this.editMode != FormEditMode.VIEW)
                        if (this.txtDescription.Text != string.Empty && (cr.Current as AccountTransactionDetail2).Description == string.Empty)
                            this.gridView2.SetRowCellValue(this.gridView2.FocusedRowHandle, colDescription2, this.txtDescription.Text);
                        if (gridView2.IsNewItemRow(e.FocusedRowHandle))
                        {
                            if (!this.gridView2.IsFirstRow)
                            {
                                gridView2.AddNewRow();
                                gridView2.SetRowCellValue(e.FocusedRowHandle, colDescription2, this.txtDescription.Text);
                            }
                        }
                    indexDebit = ItemLookUpDebitAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail2).DebitAccountCode);
                    if (indexDebit >= 0)
                    {
                        this.txtAccountName1.Text = lstAcc[indexDebit].AccountName;
                        if (lstAcc[indexDebit].DetailSubject == false)
                        {
                            (cr.Current as AccountTransactionDetail2).DebitSubjectCode = "";
                            this.colDebitSubjectCode.OptionsColumn.AllowFocus = false;
                            this.txtSubjectName1.Text = "";
                        }
                        else
                        {
                            this.colDebitSubjectCode.OptionsColumn.AllowFocus = true;
                            dv.Sort = "SubjectCode ASC";
                            int t = dv.Find((cr.Current as AccountTransactionDetail2).DebitSubjectCode);
                            if (t >= 0)
                            {
                                this.txtSubjectName1.Text = dv[t]["SubjectName"].ToString();
                            }
                            else
                                this.txtSubjectName1.Text = "";
                        }
                        if (lstAcc[indexDebit].DetailClassification == false)
                        {
                            (cr.Current as AccountTransactionDetail2).DebitClassificationCode = "";
                            this.colDebitClassificationCode.OptionsColumn.AllowFocus = false;
                            this.txtClassifiCationName1.Text = "";
                        }
                        else
                        {

                            this.colDebitClassificationCode.OptionsColumn.AllowFocus = true;
                            dvAccClass.Sort = "ClassificationCode ASC";
                            int h = dvAccClass.Find((cr.Current as AccountTransactionDetail2).DebitClassificationCode);
                            if (h >= 0)
                                this.txtClassifiCationName1.Text = dvAccClass[h]["ClassificationName"].ToString();
                            else
                                this.txtClassifiCationName1.Text = "";

                        }
                    }
                    ///Credit
                    indexCredit = ItemLookUpEditCreditAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail2).CreditAccountCode);
                    if (indexCredit >= 0)
                    {
                        this.txtAccountName2.Text = lstAcc[indexCredit].AccountName;
                        if (lstAcc[indexCredit].DetailSubject == false)
                        {
                            (cr.Current as AccountTransactionDetail2).CreditSubjectCode = "";
                            this.colCreditSubjectCode.OptionsColumn.AllowFocus = false;
                            this.txtSubjectName2.Text = "";
                        }
                        else
                        {
                            this.colCreditSubjectCode.OptionsColumn.AllowFocus = true;
                            dv.Sort = "SubjectCode ASC";
                            int m = dv.Find((cr.Current as AccountTransactionDetail2).CreditSubjectCode);
                            if (m >= 0)
                            {
                                this.txtSubjectName2.Text = dv[m]["SubjectName"].ToString();
                            }
                            else
                                this.txtSubjectName2.Text = "";
                        }
                        if (lstAcc[indexCredit].DetailClassification == false)
                        {
                            (cr.Current as AccountTransactionDetail2).CreditClassificationCode = "";
                            this.colCreditClassificationCode.OptionsColumn.AllowFocus = false;
                            this.txtClassificationName2.Text = "";
                        }
                        else
                        {
                            this.colCreditClassificationCode.OptionsColumn.AllowFocus = true;
                            dvAccClass.Sort = "ClassificationCode ASC";
                            int l = dvAccClass.Find((cr.Current as AccountTransactionDetail2).CreditClassificationCode);
                            if (l >= 0)
                                this.txtClassificationName2.Text = dvAccClass[l]["ClassificationName"].ToString();
                            else
                                this.txtClassificationName2.Text = "";
                        }
                    }
                }
                else
                {
                        gridView2.AddNewRow();
                        gridView2.SetRowCellValue(e.FocusedRowHandle, colDescription2, this.txtDescription.Text);
                   }
        }
        private void gridView2_GotFocus(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if (this.txtDescription.Text != string.Empty && (cr.Current as AccountTransactionDetail2).Description == string.Empty)
                        this.gridView2.SetRowCellValue(this.gridView2.FocusedRowHandle, colDescription2, this.txtDescription.Text);
                }
            }
        }

        private void cboDebitSubject_EditValueChanged(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (this.gridView2.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail2).DebitSubjectCode = this.gridView2.ActiveEditor.Text;
            }
        }

        private void cboDebitSubject_Leave(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                int indexDebit = -1;
                string strFilter = "";
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    indexDebit = ItemLookUpEditCreditAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail2).DebitAccountCode);
                    if (indexDebit >= 0)
                    {
                        foreach (AccountSubjectType accObj in lstAcc[indexDebit].LstAccSubjectType)
                        {
                            strFilter += "'" + accObj.SubjectTypeCode + "',";
                        }
                        if (!strFilter.Equals(""))
                        {
                            strFilter = "SubjectTypeCode in (" + strFilter + ")";
                            dv.RowFilter = strFilter;
                        }
                    }


                    if ((cr.Current as AccountTransactionDetail2).DebitSubjectCode == "")
                    {
                        if ((cr.Current as AccountTransactionDetail2).DebitAccountCode != "")
                            if (this.gridView2.ActiveEditor == null)
                            {

                                SetDataRowCellSubjectCode(dv, this.gridView2, this.colDebitSubjectCode);
                            }
                            else
                                CheckValueCellSubjectCodeFocus(this.gridView2.ActiveEditor.Text, dv, this.gridView2, this.colDebitSubjectCode);
                    }
                    else
                        CheckValueCellSubjectCodeFocus((cr.Current as AccountTransactionDetail2).DebitSubjectCode, dv, this.gridView2, this.colDebitSubjectCode);

                }
            }
        }

        private void cboDebitClassification_EditValueChanged(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (this.gridView2.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail2).DebitClassificationCode = this.gridView2.ActiveEditor.Text;
            }
        }

        private void cboDebitClassification_Leave(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                int indexDebit = -1;
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    indexDebit = ItemLookUpDebitAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail2).DebitAccountCode);
                    if ((cr.Current as AccountTransactionDetail2).DebitClassificationCode == "")
                    {

                        if (indexDebit >= 0)
                        {
                            dvAccClass.RowFilter = "ClassificationTypeCode in ('" + lstAcc[indexDebit].ClassificationTypeCode + "')";

                            if (lstAcc[indexDebit].ClassificationTypeCode != "")
                            {
                                SetDataRowCellClassificationCode(lstAcc[indexDebit].ClassificationTypeCode, this.gridView2, this.colDebitClassificationCode);
                            }
                        }
                    }
                    else
                        CheckValueCellClassificationFocus((cr.Current as AccountTransactionDetail2).DebitClassificationCode, this.gridView2, this.colDebitClassificationCode, indexDebit);
                }
            }
        }
      
        private void ItemLookUpEditCreditAccountCode_Leave(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                int indexCredit = -1;
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    indexCredit = ItemLookUpEditCreditAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail2).CreditAccountCode);
                    if (indexCredit >= 0)
                    {
                        this.txtAccountName2.Text = lstAcc[indexCredit].AccountName;
                        if (lstAcc[indexCredit].DetailSubject == false)
                        {
                            (cr.Current as AccountTransactionDetail2).CreditSubjectCode = "";
                            this.colCreditSubjectCode.OptionsColumn.AllowFocus = false;
                            this.txtSubjectName2.Text = "";
                        }
                        else
                            this.colCreditSubjectCode.OptionsColumn.AllowFocus = true;

                        if (lstAcc[indexCredit].DetailClassification == false)
                        {
                            (cr.Current as AccountTransactionDetail2).CreditClassificationCode = "";
                            this.colCreditClassificationCode.OptionsColumn.AllowFocus = false;
                            this.txtClassificationName2.Text = "";
                        }
                        else
                            this.colCreditClassificationCode.OptionsColumn.AllowFocus = true;
                    }
                    else
                    {
                        this.colCreditClassificationCode.OptionsColumn.AllowFocus = true;
                        this.colCreditSubjectCode.OptionsColumn.AllowFocus = true;
                    }
                }
            }
        }

        private void ItemLookUpEditCreditAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (this.gridView2.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail2).CreditAccountCode = this.gridView2.ActiveEditor.Text;
            }
        }

        private void cboCreditSubject_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (this.gridView2.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail2).CreditSubjectCode = this.gridView2.ActiveEditor.Text;
            }
        }

        private void cboCreditSubject_Leave(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                string strFilter = "";
                int indexCredit = -1;
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;

                if (cr.Count > 0)
                {
                    indexCredit = ItemLookUpEditCreditAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail2).CreditAccountCode);
                    if (indexCredit >= 0)
                    {
                        foreach (AccountSubjectType accObj in lstAcc[indexCredit].LstAccSubjectType)
                        {
                            strFilter += "'" + accObj.SubjectTypeCode + "',";
                        }
                        if (!strFilter.Equals(""))
                        {
                            strFilter = "SubjectTypeCode in (" + strFilter + ")";
                            dv.RowFilter = strFilter;
                        }
                    }

                    if ((cr.Current as AccountTransactionDetail2).CreditSubjectCode == "")
                    {
                        if ((cr.Current as AccountTransactionDetail2).CreditAccountCode != "")
                            if (this.gridView2.ActiveEditor == null)
                            {

                                SetDataRowCellSubjectCode(dv, this.gridView2, this.colCreditSubjectCode);
                            }
                            else
                                CheckValueCellSubjectCodeFocus(this.gridView2.ActiveEditor.Text, dv, this.gridView2, this.colCreditSubjectCode);
                    }
                    else
                        CheckValueCellSubjectCodeFocus((cr.Current as AccountTransactionDetail2).CreditSubjectCode, dv, this.gridView2, this.colCreditSubjectCode);
                }
            }
        }

        private void cboCreditClassification_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (this.gridView2.ActiveEditor != null)
                    (cr.Current as AccountTransactionDetail2).CreditClassificationCode = this.gridView2.ActiveEditor.Text;
            }
        }

        private void cboCreditClassification_Leave(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                int indexCredit = -1;
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    indexCredit = ItemLookUpEditCreditAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail2).CreditAccountCode);
                    if ((cr.Current as AccountTransactionDetail2).CreditClassificationCode == "")
                    {

                        if (indexCredit >= 0)
                        {
                            dvAccClass.RowFilter = "ClassificationTypeCode in ('" + lstAcc[indexCredit].ClassificationTypeCode + "')";

                            if (lstAcc[indexCredit].ClassificationTypeCode != "")
                            {
                                SetDataRowCellClassificationCode(lstAcc[indexCredit].ClassificationTypeCode, this.gridView2, this.colCreditClassificationCode);
                            }
                        }
                    }
                    else
                        CheckValueCellClassificationFocus((cr.Current as AccountTransactionDetail2).CreditClassificationCode, this.gridView2, this.colCreditClassificationCode, indexCredit);
                }
            }
        }

#endregion

        #region SetDataSounceForCell

        /// <summary>
        /// Check text in cell of columns  SubjectCode
        /// </summary>
        /// <param name="value"></param>
        /// <param name="dv"></param>
        /// <param name="gv"></param>
        /// <param name="col"></param>
        private void CheckValueCellSubjectCodeFocus(string value, DataView dv, GridView gv, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            dv.Sort = "SubjectCode ASC";
            if (dv.Find(value) < 0)
                SetDataRowCellSubjectCode(dv, gv, col);
        }
        /// <summary>
        /// Check text in cell of columns  ClassificationCode
        /// </summary>
        /// <param name="value"></param>
        /// <param name="gv"></param>
        /// <param name="col"></param>
        private void CheckValueCellClassificationFocus(string value, GridView gv, DevExpress.XtraGrid.Columns.GridColumn col,int indexForcus)
        {
            dvAccClass.Sort = "ClassificationCode ASC";
            if (dvAccClass.Find(value) < 0)
                SetDataRowCellClassificationCode(lstAcc[indexForcus].ClassificationTypeCode, gv, col);
        }
        /// <summary>
        /// Select DataSource for cell of columns SubjectCode
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="gv"></param>
        /// <param name="col"></param>
        private void SetDataRowCellSubjectCode(DataView dv, GridView gv, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            if (dv.Count > 0)
            {
                string[] fields ={ "SubjectCode", "SubjectName" };
                string[] header ={ "Mã đối tượng", "Tên đối tượng" };
                DataRowView drv = (FormSearch.ShowSearch(dv, fields, header) as DataRowView);
                if (this.editMode == FormEditMode.ADD || this.editMode == FormEditMode.EDIT)
                {
                    if (drv != null)
                    {
                        gv.SetRowCellValue(gv.FocusedRowHandle, col, drv["SubjectCode"].ToString());
                        this.txtSubjectName.Text = drv["SubjectName"].ToString();
                        this.txtSubjectName1.Text = drv["SubjectName"].ToString();
                        this.txtSubjectName2.Text = drv["SubjectName"].ToString();
                    }
                }
            }
        }
        /// <summary>
        /// Select DataSource for cell of columns ClassificationCode
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="gv"></param>
        /// <param name="col"></param>
        private void SetDataRowCellClassificationCode(string classificationTypeCode, GridView gv, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            dvAccClass.RowFilter = "ClassificationTypeCode in ('" + classificationTypeCode + "')";
            string[] fields ={ "ClassificationCode", "ClassificationName" };
            string[] header ={ "Mã yếu tố", "Tên yếu tố" };
            DataRowView accClass = (FormSearch.ShowSearch(dvAccClass, fields, header) as DataRowView);
            if (this.editMode == FormEditMode.ADD || this.editMode == FormEditMode.EDIT)
            {
                if (accClass != null)
                {
                    this.colClassificationCode.OptionsColumn.AllowFocus = true;
                    gv.SetRowCellValue(gv.FocusedRowHandle, col, accClass["ClassificationCode"].ToString());
                    this.txtClassificationName.Text = accClass["ClassificationName"].ToString();
                    this.txtClassificationName2.Text = accClass["ClassificationName"].ToString();
                    this.txtClassifiCationName1.Text = accClass["ClassificationName"].ToString();
                }
            }
        }
        /// <summary>
        /// Kiểm tra giá trị của SubjectCode trong rows.
        /// return: true,false.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CheckDataInCellSubjectCode(string value,string accountCode)
        {
            bool check = true;
            string strFilter = "";
            Account acc = lstAcc.Search("AccountCode", accountCode);
            if (acc != null)
            {
                if (acc.DetailSubject == false)
                {
                    return (value == string.Empty);
                        
                }
                else
                {
                    foreach (AccountSubjectType accObj in acc.LstAccSubjectType)
                    {
                        strFilter += "'" + accObj.SubjectTypeCode + "',";
                    }
                    if (!strFilter.Equals(""))
                    {
                        strFilter = "SubjectTypeCode in (" + strFilter + ")";
                        dv.RowFilter = strFilter;
                    }
                    dv.Sort = "SubjectCode ASC";
                    if (dv.Find(value) < 0)
                        check = false;
                    else
                        check = true;
                }
            }
            return check;
        }
        /// <summary>
        /// kiểm tra giá tri của Classification trong rows.
        /// returen true, false.
        /// </summary>
        /// <param name="accountCode"></param>
        /// <returns></returns>
        private bool CheckDataInCellClassificationCode(string value,string accountCode)
        {
            bool check = true;
            Account acc = lstAcc.Search("AccountCode", accountCode);
            if (acc != null)
            if (acc.DetailClassification == false)
                return true;
            else
            {
                dvAccClass.RowFilter = "ClassificationTypeCode in ('" + acc.ClassificationTypeCode + "')";
                dvAccClass.Sort = "ClassificationCode ASC";
                if (dvAccClass.Find(value) < 0)
                    check = false;
                else
                    check = true;
            }
            return check;
        }

        #endregion

        private void btnFromToDetail2_Click(object sender, EventArgs e)
        {
                this.tapPage2.PageVisible = true;
                this.xtraTabControl1.SelectedTabPage = this.tapPage2;
                btnFromToDetail2.Enabled = false;
        }

        private void btnGetFromDetail1_Click(object sender, EventArgs e)
        {
            if (accountTransactionBLL.CheckAccountDetailKind(this.gridControl1.DataSource as ListBase<AccountTransactionDetail1>) != 3)
            {
                if (this.gridView1.RowCount > 1)
                {
                    (this.DataSource as AccountTransaction).Detail1 = (this.gridControl1.DataSource as ListBase<AccountTransactionDetail1>);
                    accountTransactionBLL.RefeshDetail2(this.DataSource as AccountTransaction);
                    if ((this.DataSource as AccountTransaction).Detail2.Count == 0)
                        MessageBox.Show((this.owner as FormEditBase).GetTextMessage("VALIDATE-6", ""), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        this.gridControl2.DataSource = (this.DataSource as AccountTransaction).Detail2;
                }
                else
                    MessageBox.Show((this.owner as FormEditBase).GetTextMessage("VALIDATE-6", ""), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show((this.owner as FormEditBase).GetTextMessage("VALIDATE-6", ""), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGenToDetail1_Click(object sender, EventArgs e)
        {
            if (this.gridView2.RowCount > 1)
            {
                accountTransactionBLL.RefeshDetail1(this.DataSource as AccountTransaction);
                if ((this.DataSource as AccountTransaction).Detail1.Count == 0)
                    MessageBox.Show((this.owner as FormEditBase).GetTextMessage("VALIDATE-6", ""), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show((this.owner as FormEditBase).GetTextMessage("VALIDATE-6", ""), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                if (this.gridView1.RowCount > 0 && this.gridView1.OptionsBehavior.Editable == true)
                {
                    if (e.KeyCode == Keys.Delete)
                        if (this.gridView1.FocusedRowHandle < 0)
                        { }
                        else
                            this.gridView1.DeleteRow(this.gridView1.FocusedRowHandle);
                    if (e.KeyCode == Keys.Insert)
                        if (this.gridView1.FocusedRowHandle < 0)
                        { }
                        else
                        {
                            System.Type type = (gridView1.DataSource as IList)[0].GetType();
                            object obj = Activator.CreateInstance(type);
                            (gridView1.DataSource as IList).Insert(this.gridView1.FocusedRowHandle, obj);
                        }
                }
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                if (this.gridView2.RowCount > 0 && this.gridView2.OptionsBehavior.Editable == true)
                {
                    if (e.KeyCode == Keys.Delete)
                        if (this.gridView2.FocusedRowHandle >= 0)
                            this.gridView2.DeleteRow(this.gridView2.FocusedRowHandle);
                }
            }
        }

        /// <summary>
        /// Gán Detail1 của AccountSample vào DataSourced Gridcontrol.
        /// </summary>
        /// <param name="accSp"></param>
        /// <returns></returns>
        private void SetDataSoucedGetAccountSample(AccountSample accSp)
        {
            ///Trường hợp của Detail1 và Detail2 khi cả hai có Count=0;
            if (dvClone == null)
            {
                subjectBLL = new SubjectBLL();
                accClassBLL = new AccountClassificationBLL();
                accountBLL = new AccountBLL();
                dvClone = (subjectBLL.GetAllToDataTable());
                dv = dvClone.Copy().DefaultView;
                dvAccClassClone = accClassBLL.GetAllToDataTable();
                dvAccClass = dvAccClassClone.Copy().DefaultView;
                lstAcc = accountBLL.GetAll();// accountBLL.GetListAccountIsNotParentAccount();
            }
            dv.RowFilter = "";
            dvAccClass.RowFilter = "";
            dv.Sort= "SubjectCode ASC";
            dvAccClass.Sort = "ClassificationCode ASC";
                (this.DataSource as AccountTransaction).Detail1 = new ListBase<AccountTransactionDetail1>();
                (this.DataSource as AccountTransaction).Detail2 = new ListBase<AccountTransactionDetail2>();
                foreach(AccountSampleDetail1 dt1 in accSp.Detail1)
                {
                    AccountTransactionDetail1 accDt1=new AccountTransactionDetail1();
                    accDt1.AccountCode=dt1.AccountCode;
                    this.txtAccountName.Text = lstAcc.Search("AccountCode",dt1.AccountCode).AccountName;
                    if (dt1.SubjectCode == string.Empty)
                    {
                        accDt1.SubjectCode = GetDefaultCellValueSubjectCode(strObject, dt1.AccountCode);
                        //tri added 070920
                        dv.RowFilter = "";
                        //
                        if (accDt1.SubjectCode == string.Empty && this.cboSubjectcode2.EditValue != null)
                        {
                            accDt1.SubjectCode = GetDefaultCellValueSubjectCode(this.cboSubjectcode2.EditValue.ToString(), dt1.AccountCode);
                            //tri added070920
                            dv.RowFilter = "";
                            //
                        }
                    }
                    else
                        accDt1.SubjectCode = dt1.SubjectCode;
                    if (accDt1.SubjectCode != string.Empty)
                        this.txtSubjectName.Text = dv[dv.Find(accDt1.SubjectCode)]["SubjectName"].ToString();
                    if (dt1.ClassificationCode == string.Empty)
                    {
                        accDt1.ClassificationCode = GetDefaultCellValueClassificationCode(strbranchCode, dt1.AccountCode);
                        //tri added 070920
                        dvAccClass.RowFilter = "";
                        //end added
                    }
                    else
                        accDt1.ClassificationCode = dt1.ClassificationCode;
                    if(accDt1.ClassificationCode !=string.Empty)
                        this.txtClassificationName.Text = dvAccClass[dvAccClass.Find(accDt1.ClassificationCode)]["ClassificationName"].ToString();
                    (this.DataSource as AccountTransaction).Detail1.Add(accDt1);
                }
                if (this.gridControl1.DataSource != null)
                {
                    if ((this.gridControl1.DataSource as ListBase<AccountTransactionDetail1>).Count > 0)
                    {
                        foreach (AccountTransactionDetail1 detail1 in (this.gridControl1.DataSource as ListBase<AccountTransactionDetail1>))
                        {
                            if (detail1.DebitAmount != 0 || detail1.CreditAmount != 0)
                                foreach (AccountTransactionDetail1 acountDetai in (this.DataSource as AccountTransaction).Detail1)
                                {
                                    acountDetai.Description = detail1.Description;
                                    if (acountDetai.AccountCode == detail1.AccountCode)
                                    {
                                        acountDetai.DebitAmount = detail1.DebitAmount;
                                        acountDetai.CreditAmount = detail1.CreditAmount;
                                        break;
                                    }
                                }
                        }
                    }
                }
                foreach(AccountSampleDetail2 dt2 in accSp.Detail2)
                {
                    AccountTransactionDetail2 accDt2=new AccountTransactionDetail2();
                    accDt2.DebitAccountCode=dt2.DebitAccountCode;
                    accDt2.DebitSubjectCode=dt2.DebitSubjectCode;
                    accDt2.DebitClassificationCode=dt2.DebitClassificationCode;
                    accDt2.CreditAccountCode=dt2.CreditAccountCode;
                    accDt2.CreditSubjectCode=dt2.CreditSubjectCode;
                    accDt2.CreditClassificationCode=dt2.CreditClassificationCode;
                    (this.DataSource as AccountTransaction).Detail2.Add(accDt2);
                }
        }

        protected virtual string GetStrBrandCode()
        {
            string s = this.strbranchCode;
            if(this.AccountTransactionTypeCode == enumAccountTransactionType.GENERAL.ToString())
            {
                s = "NM.1SD";
            }
            return s;
        }

        private void gridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                if (this.gridView3.RowCount > 0 && this.gridView3.OptionsBehavior.Editable == true)
                {
                    if (e.KeyCode == Keys.Delete)
                        this.gridView3.DeleteRow(this.gridView3.FocusedRowHandle);
                }
            }
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                if (!this.gridView3.IsFocusedView)
                    return;
            if (e.FocusedRowHandle == -999999)
                return;
           
                CurrencyManager cr = this.BindingContext[this.gridControl3.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if (strbranchCode != string.Empty && (cr.Current as Invoice).BranchCode == string.Empty)
                    {
                        (cr.Current as Invoice).BranchCode = this.GetStrBrandCode();
                        Subject s = this.cboSubjectcode2.GetSelectedDataRow() as Subject;
                        (cr.Current as Invoice).TenDonvi = s.SubjectName; //this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                        (cr.Current as Invoice).Masothue = s.TaxCode;//this.cboSubjectcode2.GetColumnValue("TaxCode").ToString();
                    }
                    if (this.gridView3.IsNewItemRow(e.FocusedRowHandle))
                    {
                        if (!this.gridView3.IsFirstRow)
                        {
                            this.gridView3.AddNewRow();
                            (cr.Current as Invoice).BranchCode = this.GetStrBrandCode();
                            (cr.Current as Invoice).TenDonvi = objSubjectCode2.SubjectName;//this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                            (cr.Current as Invoice).Masothue = objSubjectCode2.TaxCode;//this.cboSubjectcode2.GetColumnValue("TaxCode").ToString();
                        }
                    }
                }
                else
                {
                    this.gridView3.AddNewRow();
                    (cr.Current as Invoice).BranchCode = this.GetStrBrandCode();
                    (cr.Current as Invoice).TenDonvi = objSubjectCode2.SubjectName;//this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                    (cr.Current as Invoice).Masothue = objSubjectCode2.TaxCode;//this.cboSubjectcode2.GetColumnValue("TaxCode").ToString();
                }
            }
        }

        private void gridView3_GotFocus(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl3.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if (strbranchCode != string.Empty && (cr.Current as Invoice).BranchCode == string.Empty)
                    {
                        (cr.Current as Invoice).BranchCode = this.GetStrBrandCode();
                        (cr.Current as Invoice).TenDonvi = objSubjectCode2.SubjectName;//this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                        (cr.Current as Invoice).Masothue = objSubjectCode2.TaxCode;//this.cboSubjectcode2.GetColumnValue("TaxCode").ToString();
                    }
                }
            }
        }

        private void gridView4_GotFocus(object sender, EventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl4.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if (strbranchCode != string.Empty && (cr.Current as BuyNoInvoice).BranchCode == string.Empty)
                    {
                        (cr.Current as BuyNoInvoice).BranchCode = strbranchCode;
                        (cr.Current as Invoice).TenDonvi = objSubjectCode2.SubjectName;//this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                        (cr.Current as Invoice).Masothue = objSubjectCode2.TaxCode;//this.cboSubjectcode2.GetColumnValue("TaxCode").ToString();
                    }
                }
            }
        }

        private void gridView4_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                if (!this.gridView4.IsFocusedView)
                    return;
                if (e.FocusedRowHandle == -999999)
                    return;
                CurrencyManager cr = this.BindingContext[this.gridControl4.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if (strbranchCode != string.Empty && (cr.Current as BuyNoInvoice).BranchCode == string.Empty)
                        (cr.Current as Invoice).BranchCode = strbranchCode;
                    if (this.gridView4.IsNewItemRow(e.FocusedRowHandle))
                    {
                        if (!this.gridView4.IsFirstRow)
                        {
                            this.gridView4.AddNewRow();
                            (cr.Current as BuyNoInvoice).BranchCode = strbranchCode;
                        }
                    }
                }
                else
                {
                    this.gridView4.AddNewRow();
                    (cr.Current as BuyNoInvoice).BranchCode = strbranchCode;
                }
            }
        }

        private void gridView4_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                if (this.gridView4.RowCount > 0 && this.gridView4.OptionsBehavior.Editable == true)
                {
                    if (e.KeyCode == Keys.Delete)
                        this.gridView4.DeleteRow(this.gridView4.FocusedRowHandle);
                }
            }
        }

        private void ItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        
            string[] fields ={ "SubjectCode", "SubjectName", "Address", "TaxCode" };
            string[] header ={ "Mã", "Tên đơn vị", "Địa chỉ", "Mã số thuế" };
            DataRowView dr = (FormSearch.ShowSearch(subjectBLL.GetSubjectsOutSideToDataTable(), fields, header) as DataRowView);
            if (this.editMode != FormEditMode.VIEW)
            {
                if (dr != null)
                {
                    this.gridView3.SetRowCellValue(this.gridView3.FocusedRowHandle, colTenDonvi, dr["SubjectName"].ToString());
                    this.gridView3.SetRowCellValue(this.gridView3.FocusedRowHandle, colMasothue, dr["TaxCode"].ToString());
                }
            }
        }

     /// <summary>
     /// Remove Object when Code is Empty
     /// </summary>
     /// <param name="detail1"></param>
     /// <param name="detail2"></param>
       private void RemoveObject(ListBase<AccountTransactionDetail1> detail1, ListBase<AccountTransactionDetail2> detail2,ListBase<Invoice> lstInvoice,ListBase<BuyNoInvoice> lstBuyNo)
       {
            int count = detail1.Count;
            for (int i = 0; i < count; i++)
            {
                if (detail1[i].AccountCode == string.Empty)
                {
                    detail1.RemoveAt(i);
                    i -= 1;
                    count -= 1;
                }
            }

            count = detail2.Count;
            for (int i = 0; i < count; i++)
            {
                if (detail2[i].DebitAccountCode == string.Empty && detail2[i].CreditAccountCode == string.Empty)
                {
                    detail2.RemoveAt(i);
                    i -= 1;
                    count -= 1;
                }
            }

            //count = lstInvoice.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    if (lstInvoice[i].Doanhso==0)
            //    {
            //        lstInvoice.RemoveAt(i);
            //        i -= 1;
            //        count -= 1;
            //    }
            //}

            count = lstBuyNo.Count;
            for (int i = 0; i < count; i++)
            {
                if (lstBuyNo[i].TienThanhtoan == 0)
                {
                    lstBuyNo.RemoveAt(i);
                    i -= 1;
                    count -= 1;
                }
            }
       }
       Subject objSubjectCode2 = new Subject();
        private void cboSubjectcode2_EditValueChanged(object sender, EventArgs e)
        {
            objSubjectCode2 = this.cboSubjectcode2.GetSelectedDataRow() as Subject;
            if (this.EditMode != FormEditMode.VIEW)
            {
                if (this.cboSubjectcode2.EditValue.ToString()!=string.Empty)  //.ItemIndex != -1)
                {

                    this.txtHovaTen.Text = objSubjectCode2.SubjectName;

                    //if (this.cboSubjectcode2.GetColumnValue("SubjectName").ToString() != string.Empty)
                    //    this.txtHovaTen.Text = this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                    //else
                    //    this.txtHovaTen.Text = "";
                    //if (this.cboSubjectcode2.GetColumnValue("Nguoilienhe").ToString() != string.Empty)
                    //    this.txtHovaTen.Text = this.cboSubjectcode2.GetColumnValue("Nguoilienhe").ToString();
                    //else
                    //    this.txtHovaTen.Text = "";
                    //Tri edit 07/08/24
                    if (AccountTransactionTypeCode == "CASHIN" || AccountTransactionTypeCode == "CASHOUT")
                        this.txtDiachi.Text = objSubjectCode2.SubjectName; // this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                    else
                        this.txtDiachi.Text = objSubjectCode2.Address;//this.cboSubjectcode2.GetColumnValue("Address").ToString();

                    if (AccountTransactionTypeCode == "CASHIN" || AccountTransactionTypeCode == "BANKIN")
                    {
                        string code = this.cboSubjectcode2.EditValue.ToString();
                        if (code.StartsWith("GD") || code.StartsWith("GT") || code.StartsWith("GSBD"))
                        {
                            this.txtDescription.Text = "Thu tiền bán thức ăn gia súc, gia cầm - " + objSubjectCode2.SubjectName;//this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                        }
                        else
                        {
                            try
                            {
                                int c2 = Convert.ToInt32(code.Substring(0, 2));
                                if (c2 >= 1 && c2 <= 30)
                                    this.txtDescription.Text = "Thu tiền bán thức ăn thủy sản - " + objSubjectCode2.SubjectName;//this.cboSubjectcode2.GetColumnValue("SubjectName").ToString();
                            }
                            catch { }
                        }
                    }
                }
            }
         
        }

        private void cboSubjectcode2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string[] fields = { "SubjectCode", "SubjectName", "Address", "TaxCode" };
            string[] header = { "Mã", "Tên đơn vị", "Địa chỉ", "Mã số thuế" };
            Subject dr = (FormSearch.ShowSearch((this.cboSubjectcode2.Properties.DataSource), fields, header) as Subject);
            if (this.editMode != FormEditMode.VIEW)
            {
                if (dr != null)
                {
                    this.cboSubjectcode2.EditValue = dr.SubjectCode;
                    //if (dr.Nguoilienhe != string.Empty)
                    //    this.txtHovaTen.Text = dr.Nguoilienhe;
                    //else
                    //    this.txtHovaTen.Text = "";

                    //this.txtHovaTen.Text = dr.SubjectName;
                    //this.txtDiachi.Text = dr.Address;
                }
            }
        }

        private string BuildNKCNo()
        {
            string month = this.cboAccountTransactionDate.DateTime.ToString("MM");
            string year = this.cboAccountTransactionDate.DateTime.ToString("yy");
            string suffix = "/" + month + "NKC" + year;

            string no = "001" + suffix;
            AccountTransaction acc = accountTransactionBLL.GetTopBySuffixAccountTransactionNo(suffix, 3);
            if (acc != null)
            {
                no = (Convert.ToInt32(acc.AccountTransactionNo.Substring(0, 3)) + 1).ToString("00#") + suffix;
            }
            return no;
        }
        public string BuildAccountTransactionNo(string strcode)
        {
            string lastSuffix="";
            if (this.EditMode != FormEditMode.VIEW)
            {
                string SoHieu = "";
                string year = "";
                string suffix = "";
                if (lstSubject.Count>0)
                {
                        SoHieu =lstSubject.Search("SubjectCode",StrObject).SoHieu;
                }
                year = this.cboAccountTransactionDate.DateTime.Year.ToString().Substring(4 - 2);
                suffix = "/" + year + "-" + SoHieu + strcode;
                AccountTransaction acc = accountTransactionBLL.GetTopBySuffixAccountTransactionNo(suffix);
                if (acc == null)
                {
                  lastSuffix = "0001" + suffix;
                
                }
                else
                {
                    if (this.EditMode == FormEditMode.EDIT)
                    {
                        if ((DataSource as AccountTransaction).AccountTransactionNo != acc.AccountTransactionNo)
                        {
                            Int16 iprefix = Convert.ToInt16(acc.AccountTransactionNo.Substring(0, 4));
                            iprefix += 1;
                            string sprefix = iprefix.ToString();
                            while (sprefix.Length < 4) sprefix = "0" + sprefix;
                            lastSuffix = sprefix + suffix;
                        }
                        else
                        {
                            if ((DataSource as AccountTransaction).AccountTransactionNo != this.txtAccountTransactionNo.Text.Trim())
                            {
                               lastSuffix = (DataSource as AccountTransaction).AccountTransactionNo;
                            }
                        }
                    }
                    else
                    {
                        Int16 iprefix = Convert.ToInt16(acc.AccountTransactionNo.Substring(0, 4));
                        iprefix += 1;
                        string sprefix = iprefix.ToString();
                        while (sprefix.Length < 4) sprefix = "0" + sprefix;
                        lastSuffix  = sprefix + suffix;
                    }
                }
            }
            return lastSuffix;
        }

        private void txtAccountTransactionNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                if (this.code == string.Empty)
                    this.txtAccountTransactionNo.Text = BuildNKCNo();
                else
                    this.txtAccountTransactionNo.Text = BuildAccountTransactionNo(code);
            }

        }
        private string GetDefaultCellValueSubjectCode(string strObj, string accountCode)
        {
            Account accSP = new Account();
            int index1 = 0;
            string strFilter = "";
            string strReturn = "";
             accSP= lstAcc.Search("AccountCode", accountCode);
          //  index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode",accountCode);
           // index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", accountCode);
             if (accSP != null)
                {
                    if (accSP.DetailSubject == true)
                        foreach (AccountSubjectType accObj in accSP.LstAccSubjectType)
                    {
                        strFilter += "'" + accObj.SubjectTypeCode + "',";
                    }

                    if (!strFilter.Equals(""))
                    {
                        strFilter = "SubjectTypeCode in (" + strFilter + ")";
                        dv.RowFilter = strFilter;
                    }
                    //tri added 070920
                    else
                        dv.RowFilter = "SubjectTypeCode = ''";
                }
                if (accountCode != string.Empty)
                {
                    dv.Sort = "SubjectCode ASC";
                    index1 = dv.Find(strObj);
                    if (index1 >= 0)
                    {
                        strReturn = strObj;
                    }
                }
                return strReturn;
        }

        private void DefaultCellValueSubjectCode(string strObj,string strSubjectCode2)
        {
            
            int index1=0;
            int index2 = 0;
            string strFilter = "";
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            if (cr.Count > 0)
            {
                index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail1).AccountCode);
                if (index >= 0)
                {
                    if (lstAcc[index].DetailSubject == true)
                    foreach (AccountSubjectType accObj in lstAcc[index].LstAccSubjectType)
                    {
                        strFilter += "'" + accObj.SubjectTypeCode + "',";
                    }
                    if (!strFilter.Equals(""))
                    {
                        strFilter = "SubjectTypeCode in (" + strFilter + ")";
                        dv.RowFilter = strFilter;
                    }
                }
                if ((cr.Current as AccountTransactionDetail1).AccountCode != string.Empty)
                {
                    dv.Sort = "SubjectCode ASC";
                    index1= dv.Find(strObj) ;
                    index2=dv.Find(strSubjectCode2);
                    if (index1>= 0)
                    {
                        //this.cboSubjectCode1.BeginUpdate();
                        (cr.Current as AccountTransactionDetail1).SubjectCode = strObject;
                        this.txtSubjectName.Text = dv[index1]["SubjectName"].ToString();
                        //this.cboSubjectCode1.EndUpdate();
                        gridView1.UpdateCurrentRow();
                    }
                    else if(index2>=0)
                    {
                        //this.cboSubjectCode1.BeginUpdate();
                        (cr.Current as AccountTransactionDetail1).SubjectCode = strSubjectCode2;
                        this.txtSubjectName.Text = dv[index2]["SubjectName"].ToString();
                        //this.cboSubjectCode1.EndUpdate();
                        gridView1.UpdateCurrentRow();
                    }
                  
                }
           }
        }

        private void cboSubjectCode1_Enter(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW && StrObject!=string.Empty)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if ((cr.Current as AccountTransactionDetail1).SubjectCode == string.Empty)
                        DefaultCellValueSubjectCode(strObject,this.cboSubjectcode2.EditValue.ToString());
                }
            }
        }
        private string GetDefaultCellValueClassificationCode(string strClass, string accountCode)
        {
            string strFilter = "";
            string strReturn = "";
            int i = -1;
            Account accSP = new Account();
            accSP = lstAcc.Search("AccountCode", accountCode);
          //  index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", accountCode);
            if (accSP != null)
            {
                //tri edit 070920
                //if (lstAcc[index].ClassificationTypeCode != "")
                //{
                    //end edit
                    strFilter = "ClassificationTypeCode = ('" + accSP.ClassificationTypeCode + "')";
                    dvAccClass.RowFilter = strFilter;
                //}
            }

            if (accountCode != string.Empty)
            {
                dvAccClass.Sort = "ClassificationCode ASC";
                i = dvAccClass.Find(strClass);
                if (i >= 0)
                {
                    strReturn = strClass;
                }
            }
            return strReturn;
        }
        private void DefaultCellValueClassificationCode(string strClass)
        {
            string strFilter = "";
            int i = -1;
            CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
            if (cr.Count > 0)
            {
                index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountTransactionDetail1).AccountCode);
                if (index >= 0)
                {
              
                        strFilter = "ClassificationTypeCode = ('" + lstAcc[index].ClassificationTypeCode + "')";
                        dvAccClass.RowFilter = strFilter;
                    }
                }
                if ((cr.Current as AccountTransactionDetail1).AccountCode != string.Empty)
                {
                    dvAccClass.Sort = "ClassificationCode ASC";
                    i = dvAccClass.Find(strClass);
                    if (i >= 0)
                    {
                        //this.cboClassificationCode1.BeginUpdate();
                        (cr.Current as AccountTransactionDetail1).ClassificationCode = strClass;
                        this.txtClassificationName.Text = dvAccClass[i]["ClassificationName"].ToString();
                        this.gridView1.UpdateCurrentRow();
                        //this.cboClassificationCode1.EndUpdate();
                    }
                }
       }

        private void cboClassificationCode1_Enter(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW && StrObject != string.Empty)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl1.DataSource] as CurrencyManager;
                if (cr.Count > 0)
                {
                    if ((cr.Current as AccountTransactionDetail1).ClassificationCode == string.Empty)
                        DefaultCellValueClassificationCode(strbranchCode);
                }
            }
        }

        private void xtraTabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    switch (xtraTabControl1.SelectedTabPageIndex)
                    {
                        case 0:
                            if (this.gridView1.RowCount == 1)
                            {
                                SendKeys.Send("{TAB}");
                                SendKeys.Send("{DOWN}");
                            }
                            else
                                SendKeys.Send("{TAB}");
                            break;
                        case 1:
                            if (this.gridView2.RowCount == 1)
                            {
                                SendKeys.Send("{TAB}");
                                SendKeys.Send("{DOWN}");
                            }
                            else
                                SendKeys.Send("{TAB}");
                            break;
                        case 2:
                            if (this.gridView3.RowCount == 1)
                            {
                                SendKeys.Send("{TAB}");
                                SendKeys.Send("{DOWN}");
                            }
                            else
                                SendKeys.Send("{TAB}");
                            break;
                        case 3:
                            if (this.gridView4.RowCount == 1)
                            {
                                SendKeys.Send("{TAB}");
                                SendKeys.Send("{DOWN}");
                            }
                            else
                                SendKeys.Send("{TAB}");
                            break;
                    }
                }
            }
        }

        private void txtHovaTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtDiachi.Focus();
        }

        private void ItemLookupCustomerCode_Leave(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl3.DataSource] as CurrencyManager;
            string customerName = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("SubjectName").ToString();
            string maSoThue = (sender as DevExpress.XtraEditors.LookUpEdit).GetColumnValue("TaxCode").ToString();
            if ( (cr.Current as Invoice).MaDonvi != string.Empty)
            {
                this.gridView3.SetRowCellValue(gridView3.FocusedRowHandle, this.colTenDonvi, customerName);
                this.gridView3.SetRowCellValue(gridView3.FocusedRowHandle, this.colMasothue, maSoThue);
            }
        }

        private void ItemLookupCustomerCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl3.DataSource] as CurrencyManager;
                if (this.gridView3.ActiveEditor != null)
                    (cr.Current as Invoice).MaDonvi = this.gridView3.ActiveEditor.Text;
            }
        }
        #region BuyNoInvoice
        //14/09/2007
        private void txtTenNguoiban_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtAddress.Focus();
        }
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtTenMathang.Focus();
        }

        private void txtTenMathang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtSoluong.Focus();
        }
        private void btnAddGrid_Click(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                AddDataToGridBuyNoInvoice();
                AutoCompleteUtils.AddAutoCompleteSource(this.txtTenNguoiban);
                AutoCompleteUtils.AddAutoCompleteSource(this.txtTenMathang);
                AutoCompleteUtils.AddAutoCompleteSource(this.txtAddress);
                ClearTextBuynoInvoice();
                this.cboNgaymua.Focus();
            }
        }
        private void AddDataToGridBuyNoInvoice()
        {
            BuyNoInvoice buyno = new BuyNoInvoice();
            buyno.Ngaymua = this.cboNgaymua.DateTime;
            buyno.TenNguoiban = this.txtTenNguoiban.Text;
            buyno.Diachi = this.txtAddress.Text;
            buyno.TenMathang = this.txtTenMathang.Text;
            buyno.Soluong = Convert.ToDecimal(this.txtSoluong.EditValue.ToString());
            buyno.Dongia = Convert.ToDecimal(this.txtDongia.EditValue.ToString());
            buyno.TienThanhtoan = Convert.ToDecimal(this.txtTienthanhtoan.EditValue.ToString());
            buyno.BranchCode = this.cboBranchCode.EditValue.ToString();
            buyno.Ghichu = this.txtGhichu.Text;
            (this.DataSource as AccountTransaction).BuyNoInvoice.Add(buyno);
        }
      
        private void ClearTextBuynoInvoice()
        {
           // this.cboNgaymua.DateTime = this.cboAccountTransactionDate.DateTime;
            this.txtTenNguoiban.Text = "";
            this.txtAddress.Text = "";
            this.txtTenMathang.Text = "";
            this.txtSoluong.EditValue = 0;
            this.txtDongia.EditValue =0.00;
            this.txtTienthanhtoan.EditValue = 0;
            this.cboBranchCode.EditValue = strbranchCode;
            this.txtGhichu.Text = "";
        }

        private void txtSoluong_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
                if (Convert.ToDecimal(this.txtDongia.EditValue.ToString()) != 0 && Convert.ToDecimal(this.txtSoluong.EditValue.ToString()) != 0)
                this.txtTienthanhtoan.EditValue = decimal.Round((Convert.ToDecimal(this.txtDongia.EditValue.ToString()) * Convert.ToDecimal(this.txtSoluong.EditValue.ToString())), 0);
        }

        private void txtDongia_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            if (Convert.ToDecimal(this.txtDongia.EditValue.ToString()) != 0 && Convert.ToDecimal(this.txtSoluong.EditValue.ToString()) != 0)
                this.txtTienthanhtoan.EditValue = decimal.Round((Convert.ToDecimal(this.txtDongia.EditValue.ToString()) * Convert.ToDecimal(this.txtSoluong.EditValue.ToString())), 0);
        }

        private void txtTienthanhtoan_EditValueChanged(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            if (Convert.ToDecimal(this.txtTienthanhtoan.EditValue.ToString()) != 0 && Convert.ToDecimal(this.txtSoluong.EditValue.ToString()) != 0)
                this.txtDongia.EditValue = decimal.Round((Convert.ToDecimal(this.txtTienthanhtoan.EditValue.ToString()) / Convert.ToDecimal(this.txtSoluong.EditValue.ToString())), 2);
        }
        #endregion

        #region Invoice

        private void txtTenDonvi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtMasothue.Focus();
        }

        private void txtTenMathangIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtMota.Focus();
        }
       
        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                AddDataToGridInvoice();
                AutoCompleteUtils.AddAutoCompleteSource(this.txtTenDonvi);
                AutoCompleteUtils.AddAutoCompleteSource(this.txtTenMathangIn);
                AutoCompleteUtils.AddAutoCompleteSource(this.txtMasothue);
                AutoCompleteUtils.AddAutoCompleteSource(this.txtMauHoadon);
                AutoCompleteUtils.AddAutoCompleteSource(this.txtSoSeri);
                ClearTextInvoice();
                this.txtMauHoadon.Focus();
            }
        }

        private void AddDataToGridInvoice()
        {
            Invoice invoice = new Invoice();
            invoice.Dauvao = this.checkDauvao.Checked;
            invoice.MauHoadon = this.txtMauHoadon.Text;
            invoice.SoSeri = this.txtSoSeri.Text;
            invoice.SoHoadon = this.txtSoHoadon.Text;
            invoice.NgayHoadon = this.cboNgayHoadon.DateTime;
            invoice.TenDonvi = this.txtTenDonvi.Text;
            invoice.Masothue = this.txtMasothue.Text;
            invoice.Doanhso = Convert.ToDecimal(this.txtDoanhso.EditValue.ToString());
            invoice.Thuexuat = Convert.ToDecimal(this.txtThuexuat.EditValue.ToString());
            invoice.Tienthue = Convert.ToDecimal(this.txtTienthue.EditValue.ToString());
            invoice.TenMathang = this.txtTenMathangIn.Text;
            invoice.Description = this.txtMota.Text;
            invoice.Khongchiuthue = this.checkKhongchiuthue.Checked;
            invoice.BranchCode = this.cboChinhanh.EditValue.ToString();
            invoice.Nhapkhau = this.checkNhapkhau.Checked;
            (this.DataSource as AccountTransaction).Invoice.Add(invoice);
        }
        private void ClearTextInvoice()
        {
            this.txtMauHoadon.Text="";
            this.txtSoSeri.Text="";
            this.txtSoHoadon.Text="";
            this.txtTenDonvi.Text="";
            this.txtMasothue.Text="";
            this.txtThuexuat.EditValue = 0.00;
            this.txtTienthue.EditValue = 0;
            this.txtDoanhso.EditValue = 0;
            this.txtTenMathangIn.Text="";
            this.txtMota.Text="";
            this.checkKhongchiuthue.Checked=false;
            this.checkNhapkhau.Checked = false;
            this.cboChinhanh.EditValue=this.GetStrBrandCode();
            this.cboCustomerCode.ItemIndex = 0;
        }
        private void cboCustomerCode_EditValueChanged(object sender, EventArgs e)
        {
            this.txtTenDonvi.Text = this.cboCustomerCode.GetColumnValue("SubjectName").ToString();
            this.txtMasothue.Text = this.cboCustomerCode.GetColumnValue("TaxCode").ToString();
        }
        private void RefreshTextBoxInvoice(bool flat)
        {
            this.checkDauvao.Properties.ReadOnly = flat;
            this.txtMauHoadon.ReadOnly = flat;
            this.txtSoSeri.ReadOnly = flat;
            this.txtSoHoadon.Properties.ReadOnly = flat;
            this.txtTenDonvi.ReadOnly = flat;
            this.txtMasothue.ReadOnly = flat;
            this.txtThuexuat.Properties.ReadOnly = flat;
            this.txtTienthue.Properties.ReadOnly = flat;
            this.txtDoanhso.Properties.ReadOnly = flat;
            this.txtTenMathangIn.ReadOnly = flat;
            this.txtMota.Properties.ReadOnly = flat;
            this.checkKhongchiuthue.Properties.ReadOnly = flat;
            this.checkNhapkhau.Properties.ReadOnly = flat;
            this.cboChinhanh.Properties.ReadOnly = flat;
            this.cboNgayHoadon.Properties.ReadOnly = flat;
            this.cboCustomerCode.Properties.ReadOnly = flat;
        }
        private void checkDauvao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtMauHoadon.Focus();
        }
        private void txtMauHoadon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtSoSeri.Focus();
        }

        private void txtSoSeri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtSoHoadon.Focus();
        }

      
        private void checkKhongchiuthue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.checkNhapkhau.Focus();
        }
        private void checkNhapkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnAddInvoice.Focus();
        }

        private void txtThuexuat_Validating(object sender, CancelEventArgs e)
        {
            if (this.editMode != FormEditMode.VIEW)
            {
                if (Convert.ToDecimal(this.txtDoanhso.EditValue.ToString()) != 0)
                {
                    this.txtTienthue.EditValue =decimal.Round(Convert.ToDecimal(this.txtDoanhso.EditValue.ToString()) * Convert.ToDecimal(this.txtThuexuat.EditValue.ToString()),0);
                }
            }
        }
        private void txtMasothue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtDoanhso.Focus();
        }
        #endregion

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCopyDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Text = txtDescription.Text.Trim();
            AccountTransaction t = (this.DataSource as AccountTransaction);
            if (t.Detail1 != null)
            {
                foreach (AccountTransactionDetail1 td1 in t.Detail1)
                {
                    td1.Description = txtDescription.Text;
                }
            }
            if (t.Detail2 != null)
            {
                foreach (AccountTransactionDetail2 td2 in t.Detail2)
                {
                    td2.Description = txtDescription.Text;
                    td2.Description2 = txtDescription.Text;
                }
            }
            this.gridView1.RefreshData();
            this.gridView2.RefreshData();
        }

        private void lokKheuocvay_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.editMode == FormEditMode.VIEW)
                return;
            string[] fields ={ "VayNo", "VayDate", "Description" };
            string[] header ={ "Số khế ước", "Ngày", "Diễn giải" };
            ListBase<KheUocVay> lst = new ListBase<KheUocVay>();
            lst.Add(new KheUocVay());
            foreach (KheUocVay kuv in lstKheuocvay)
                if (kuv.SubjectCode == this.StrObject || this.StrObject=="")
                    lst.Add(kuv);

            KheUocVay ku = FormSearch.ShowSearch(lst, fields, header) as KheUocVay;
            if (ku != null)
                this.lokKheuocvay.EditValue = ku.VayID;
        }


    }
}
