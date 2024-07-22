using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormEditAccountTransactionStock : VNS.Windows.Forms.FormEditBase
    {
        //private bool callFromOrtherDe
        private string stockTransactionTypeCode;
        public string StockTransactionTypeCode
        {
            get { return stockTransactionTypeCode; }
            set
            {
                stockTransactionTypeCode = value;
                this.ucAccountTransactionStock11.code = value;
                this.ucAccountTransactionStock11.StockTransactionTypeCode = value;
                this.ucAccountTransactionStock11.SetAccountSample(value);
            }
        }
        //private string strSpecialType = string.Empty;
        //public string StrSpecialType
        //{
        //    get { return strSpecialType; }
        //    set 
        //    { 
        //        strSpecialType = value;
        //        this.ucAccountTransactionStock11.StrSpecialType = value;
        //    }
        //}
        public string StrObject
        {
            get { return this.ucAccountTransactionStock11.StrObject; }
            set { this.ucAccountTransactionStock11.StrObject = value; }
        }
        private string accountTransactionTypeCode;
        /// <summary>
        /// Get or set AccountTransactionTypeCode property
        /// </summary>
        public string AccountTransactionTypeCode
        {
            get { return accountTransactionTypeCode; }
            set
            {
                accountTransactionTypeCode = value;
                this.ucAccountTransactionStock11.AccountTransactionTypeCode = value;
            }
        }
        AccountTransactionStockNewBLL bll = new AccountTransactionStockNewBLL();
        /// <summary>
        /// Default constructor
        /// </summary>
        public FormEditAccountTransactionStock()
        {
            InitializeComponent();
            this.Business = bll;
            this.ucAccountTransactionStock11.OnSelectSTFail += new VNS.ERP.GUI.UserControls.UCAccountTransactionStock1.SelectSTFail(ucAccountTransactionStock11_OnSelectSTFail);
            //this.DataSource = bll.GetAll();
        }

        void ucAccountTransactionStock11_OnSelectSTFail()
        {
            MessageBox.Show(this.GetTextMessage("MultiSelectSTError", "Các phiếu xuất kho phải cùng tháng, cùng số hóa đơn, cùng ngày hóa đơn, cùng số seri, cùng mẫu hóa đơn và giá bán phải thống nhất!"));
        }
        /// <summary>
        /// Constructor InitializeComponent and set AccountTransactionTypeCode property for this
        /// </summary>
        /// <param name="accountTransactionTypeValue">Use to set AccountTransactionTypeCode proterty for this</param>
        public FormEditAccountTransactionStock(string accountTransactionTypeValue)
        {
            InitializeComponent();
            this.Business = bll;
            this.AccountTransactionTypeCode = accountTransactionTypeValue;
            this.MessagePrefix = "FormEditAccountTransaction-";
            this.LayoutFile = "FormEditAccountTransaction.xml";
            this.ucAccountTransactionStock11.OnSelectSTFail += new VNS.ERP.GUI.UserControls.UCAccountTransactionStock1.SelectSTFail(ucAccountTransactionStock11_OnSelectSTFail);
            //this.AllowSaveAndClose = false;
            
            //this.Text = text;
        }
        private bool accountedOnload = false;
        public FormEditAccountTransactionStock(string accountTransactionTypeValue, bool accountedOnload)
        {
            InitializeComponent();
            this.Business = bll;
            this.AccountTransactionTypeCode = accountTransactionTypeValue;
            this.MessagePrefix = "FormEditAccountTransaction-";
            this.LayoutFile = "FormEditAccountTransaction.xml";
            this.accountedOnload = accountedOnload;
            //if (this.accountedOnload) this.ucAccountTransactionStock11.Accounted();

            this.ucAccountTransactionStock11.OnSelectSTFail += new VNS.ERP.GUI.UserControls.UCAccountTransactionStock1.SelectSTFail(ucAccountTransactionStock11_OnSelectSTFail);
            //this.AllowSaveAndClose = false;

            //this.Text = text;
        }
        /// <summary>
        /// Call On accounted  function on this constructor
        /// </summary>
        /// <param name="accountTransactionTypeValue"></param>
        /// <param name="stockTransactionTypeCode"></param>
        public FormEditAccountTransactionStock(string accountTransactionTypeValue, string stockTransactionTypeCode)
        {
            InitializeComponent();
            this.Business = bll;
            this.StockTransactionTypeCode = stockTransactionTypeCode;
            this.AccountTransactionTypeCode = accountTransactionTypeValue;
            this.MessagePrefix = "FormEditAccountTransaction-";
            this.LayoutFile = "FormEditAccountTransaction.xml";
            
            this.ucAccountTransactionStock11.Accounted();

            this.ucAccountTransactionStock11.OnSelectSTFail += new VNS.ERP.GUI.UserControls.UCAccountTransactionStock1.SelectSTFail(ucAccountTransactionStock11_OnSelectSTFail);
            //this.AllowSaveAndClose = false;

            //this.Text = text;
        }

        public void Accounted()
        {
            this.ucAccountTransactionStock11.Accounted();
        }
        private void FormEditAccountTransactionStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode != VNS.Windows.FormEditMode.VIEW)
            {
                this.CancelItem();
            }
        }
        public void GetAccTransStockDetailFromAccountSample(string accountSampleCode)
        {
            AccountSample accSample = new AccountSample();
            accSample.Detail1 = new AccountSampleBLL().GetDetail1ByID(accountSampleCode);
            accSample.Detail2 = new AccountSampleBLL().GetDetail2ByID(accountSampleCode);
            AccountTransactionStockNew accTrans = this.CurrentItem as AccountTransactionStockNew;
            foreach (AccountSampleDetail1 accSampleDetail1 in accSample.Detail1)
            {
                AccountTransactionDetail1 accTransDetail1 = new AccountTransactionDetail1();
                accTransDetail1.AccountCode = accSampleDetail1.AccountCode;
                accTransDetail1.SubjectCode = accSampleDetail1.SubjectCode;
                accTransDetail1.ClassificationCode = accSampleDetail1.ClassificationCode;
                accTransDetail1.Description = accSampleDetail1.Description;
                if (accTrans.Detail1 == null) accTrans.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                accTrans.Detail1.Add(accTransDetail1);
            }
            foreach (AccountSampleDetail2 accSampleDetail2 in accSample.Detail2)
            {
                AccountTransactionDetail2 accTransDetail2 = new AccountTransactionDetail2();
                accTransDetail2.DebitAccountCode = accSampleDetail2.DebitAccountCode;
                accTransDetail2.DebitSubjectCode = accSampleDetail2.DebitSubjectCode;
                accTransDetail2.DebitClassificationCode = accSampleDetail2.DebitClassificationCode;
                accTransDetail2.CreditAccountCode = accSampleDetail2.CreditAccountCode;
                accTransDetail2.CreditSubjectCode = accSampleDetail2.CreditSubjectCode;
                accTransDetail2.CreditClassificationCode = accSampleDetail2.CreditClassificationCode;
                accTransDetail2.Description = accSampleDetail2.Description;
                if( accTrans.Detail2 == null)  accTrans.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                accTrans.Detail2.Add(accTransDetail2);
            }
        }
        public void GetDataFromStockTransaction(StockTransaction t)
        {
            AccountTransactionStockNew accTrans = this.CurrentItem as AccountTransactionStockNew;

            if (accTrans.AccTransactionStock == null) accTrans.AccTransactionStock = new AccountTransactionStock();

            accTrans.AccountTransactionNo = t.TransactionNo;
            accTrans.AccountTransactionDate = t.TransactionDate;
            accTrans.Description = t.Description;
            accTrans.AccTransactionStock.StockTransactionNo = t.TransactionNo;
            accTrans.AccTransactionStock.StockTransactionDate = t.TransactionDate;
            accTrans.AccTransactionStock.Nguoigiaonhan = t.NguoiGiaoNhan;
            accTrans.AccTransactionStock.PTVC = t.PTVC;
            accTrans.AccTransactionStock.NguoiVC = t.DonviVC;
            accTrans.AccTransactionStock.Chungtukemtheo = t.CTKemTheo;
            accTrans.AccTransactionStock.Description = t.Description;
           
            this.ucAccountTransactionStock11.BindData2();
            
            
            if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKIN.ToString())
            {
                accTrans.AccTransactionStock.Tenkho = t.InStock;
                accTrans.AccTransactionStock.Donvi = t.DVGiao;
                foreach (StockTransactionSumDetail stsd in t.Details)
                {
                    AccountTransactionStockDetail atsd = new AccountTransactionStockDetail();
                    atsd.StockInCode = t.InStock;
                    atsd.ItemCode = stsd.ItemCode;
                    atsd.Quantity = stsd.Quantity;
                    atsd.CostAmount = stsd.AmountCost;
                    atsd.Amount = stsd.AmountIn;
                    atsd.CostAmount = atsd.Amount;
                    atsd.Price = stsd.PriceIn;
                    if (accTrans.AccTransactionStock.Detail == null) accTrans.AccTransactionStock.Detail = new VNS.Common.ListBase<AccountTransactionStockDetail>();
                    accTrans.AccTransactionStock.Detail.Add(atsd);
                }
            }
            if (this.AccountTransactionTypeCode == enumAccountTransactionType.STOCKOUT.ToString())
            {
                accTrans.AccTransactionStock.Tenkho = t.OutStock;
                foreach (StockTransactionSumDetail stsd in t.Details)
                {
                    AccountTransactionStockDetail atsd = new AccountTransactionStockDetail();
                    atsd.StockOutCode = t.OutStock;
                    atsd.ItemCode = stsd.ItemCode;
                    atsd.Quantity = stsd.Quantity;
                    atsd.CostAmount = stsd.AmountCost;
                    atsd.Amount = stsd.AmountOut;
                    //atsd.CostAmount = atsd.Amount;
                    atsd.Price = stsd.PriceOut;
                    if (accTrans.AccTransactionStock.Detail == null) accTrans.AccTransactionStock.Detail = new VNS.Common.ListBase<AccountTransactionStockDetail>();
                    accTrans.AccTransactionStock.Detail.Add(atsd);
                }
            }

            if (accTrans.Detail2.Count > 0)
            {
                foreach (AccountTransactionStockDetail accTransStockDetail in accTrans.AccTransactionStock.Detail)
                {
                    accTransStockDetail.DebitAccountCode = accTrans.Detail2[0].DebitAccountCode;
                    accTransStockDetail.CreditAccountCode = accTrans.Detail2[0].CreditAccountCode;
                }
            }

            AccountStock accStock = new AccountStock();
            accStock.AccountTransactionID = accTrans.AccountTransactionID;
            accStock.StockTransactionID = t.TransactionID;
            if (accTrans.AccTransactionStock.LstAccountStock == null) accTrans.AccTransactionStock.LstAccountStock = new VNS.Common.ListBase<AccountStock>();
            accTrans.AccTransactionStock.LstAccountStock.Add(accStock);
        }
        public override void AddNewItem()
        {
            base.AddNewItem();
            this.ucAccountTransactionStock11.SetAccountSample(this.StockTransactionTypeCode);
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            
        }
        private void FormEditAccountTransactionStock_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            
            this.WindowState = FormWindowState.Maximized;
            if (this.accountedOnload && !this.DesignMode)
            {
                this.Accounted();
                this.ucAccountTransactionStock11.TabSelectedIndex = 1;
            }
            this.Visible = true;
        }

        private void btnPrintCTPS_Click(object sender, EventArgs e)
        {
            RPAccountCTPS rp = new RPAccountCTPS();
            //rp.DataSource = this.DataSource as ListBase<AccountTransaction>;
            ListBase<AccountTransaction> lst = new ListBase<AccountTransaction>();
            lst.Add(this.CurrentItem as AccountTransaction);
            rp.BindData(lst);

            rp.ShowPreview();
        }
    }
}