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
using VNS.Common;
using VNS.Windows;
using VNS.ERP.GUI.Accounting;

namespace VNS.ERP.GUI.Stocks
{
    public partial class FormStockTransactionDetail : FormEditBase
    {
       
       private ListBase<StockTransactionSumDetail> lststsd;
       StockTransactionBLL obj = new StockTransactionBLL();
       protected enumStockTransaction _StockTrans;
       public enumStockTransaction StockTrans
       {
           get { return _StockTrans; }
           set
           {
               _StockTrans = value;
               //this.usrDetailStockTransactionDetail1.StockTransaction = value;
           }
        }
        /// <summary>
        /// Not use
        /// </summary>
        /// <param name="pstgd"></param>
        public FormStockTransactionDetail(ParameterStockTransactionGetData pstgd)
        {
            this.PSTGD = pstgd;
            this.usrDetailStockTransactionDetail1.SetLookupEditInStockDataSource(new StockBLL().GetAll());
            this.usrDetailStockTransactionDetail1.SetLookupEditOutStockDataSource(new StockBLL().GetAll());
            usrDetailStockTransactionDetail1.SetLookupEditForDepartmentDataSource(EnumDisplays.GetListenumStockTransactionForDepartment());
        }
        public FormStockTransactionDetail(StockTransaction stockTransaction)
        {
            InitializeComponent();
            this.usrDetailStockTransactionDetail1.SetLookupEditInStockDataSource(new StockBLL().GetAll());
            this.usrDetailStockTransactionDetail1.SetLookupEditOutStockDataSource(new StockBLL().GetAll());
            this.usrDetailStockTransactionDetail1.SetItemDataSource(new ItemBLL().GetAll());
            usrDetailStockTransactionDetail1.SetLookupEditForDepartmentDataSource(EnumDisplays.GetListenumStockTransactionForDepartment());
            ListBase<Stock> LookupEditKhoGiaoDSr = new StockBLL().GetAll();
            LookupEditKhoGiaoDSr.Add(new Stock());
            ListBase<Stock> LookupEditKhoNhanDSr = new StockBLL().GetAll();
            LookupEditKhoNhanDSr.Add(new Stock());
            this.usrDetailStockTransactionDetail1.SetLookupEditKhoGiaoDSr(LookupEditKhoGiaoDSr);
            this.usrDetailStockTransactionDetail1.SetLookupEditKhoNhanDSr(LookupEditKhoNhanDSr);
            //this.usrDetailStockTransactionDetail1.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetByStockTransaction(this.StockTransaction));
            ListBase<Vendor> lstVendor1 = new VendorBLL().GetAll();
            lstVendor1.Add(new Vendor());
            ListBase<Customer> lstVendor2 = new CustomerBLL().GetAll();
            lstVendor2.Add(new Customer());
            ListBase<Vendor> lstTransport = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
            lstTransport.Add(new Vendor());
            this.usrDetailStockTransactionDetail1.SetLookupEditDVGiaoDSr(lstVendor1);
            this.usrDetailStockTransactionDetail1.SetLookupEditDVNhanDSr(lstVendor2);
            this.usrDetailStockTransactionDetail1.SetLookupEditDVVanChuyenDSr(lstTransport);
            this.Business = obj;


            this.usrDetailStockTransactionDetail1.IsOne = true;
            this.DataSource = stockTransaction;

            if (stockTransaction.InStock != "")
            {
                SetInStockStatus();
                SetInStock(stockTransaction.InStock);
                this.usrDetailStockTransactionDetail1.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.In));
                this.Text = "Phiếu nhập kho";
            }
            else
            {
                SetOutStockStatus();
                SetOutStock(stockTransaction.OutStock);
                this.usrDetailStockTransactionDetail1.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.Out));
                this.Text = "Phiếu xuất kho";
            }
            this.AllowAddNew = false;
        }
        /// <summary>
        /// Use to call in FormList
        /// </summary>
        public FormStockTransactionDetail()
        {
            InitializeComponent();
            this.usrDetailStockTransactionDetail1.SetLookupEditInStockDataSource(new StockBLL().GetAll());
            this.usrDetailStockTransactionDetail1.SetLookupEditOutStockDataSource(new StockBLL().GetAll());
            this.usrDetailStockTransactionDetail1.SetItemDataSource(new ItemBLL().GetAll());
            usrDetailStockTransactionDetail1.SetLookupEditForDepartmentDataSource(EnumDisplays.GetListenumStockTransactionForDepartment());
            ListBase<Stock> LookupEditKhoGiaoDSr = new StockBLL().GetAll();
            LookupEditKhoGiaoDSr.Add(new Stock());
            ListBase<Stock> LookupEditKhoNhanDSr = new StockBLL().GetAll();
            LookupEditKhoNhanDSr.Add(new Stock());
            this.usrDetailStockTransactionDetail1.SetLookupEditKhoGiaoDSr(LookupEditKhoGiaoDSr);
            this.usrDetailStockTransactionDetail1.SetLookupEditKhoNhanDSr(LookupEditKhoNhanDSr);
            //this.usrDetailStockTransactionDetail1.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetByStockTransaction(this.StockTransaction));
            ListBase<Vendor> lstVendor1 = new VendorBLL().GetAll();
            lstVendor1.Add(new Vendor());
            ListBase<Customer> lstVendor2 = new CustomerBLL().GetAll();
            lstVendor2.Add(new Customer());
            ListBase<Vendor> lstTransport = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
            lstTransport.Add(new Vendor());
            this.usrDetailStockTransactionDetail1.SetLookupEditDVGiaoDSr(lstVendor1);
            this.usrDetailStockTransactionDetail1.SetLookupEditDVNhanDSr(lstVendor2);
            this.usrDetailStockTransactionDetail1.SetLookupEditDVVanChuyenDSr(lstTransport);
            this.Business = obj;
        }
        /// <summary>
        /// Not use
        /// </summary>
        /// <param name="StockTransaction"></param>
        public FormStockTransactionDetail(enumStockTransaction StockTransaction)
        {
            InitializeComponent();      
            this.StockTrans = StockTransaction;
            this.usrDetailStockTransactionDetail1.SetLookupEditInStockDataSource(new StockBLL().GetAll());
            this.usrDetailStockTransactionDetail1.SetLookupEditOutStockDataSource(new StockBLL().GetAll());
            this.usrDetailStockTransactionDetail1.SetItemDataSource(new ItemBLL().GetAll());
            this.usrDetailStockTransactionDetail1.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetByStockTransaction(this.StockTrans));
            usrDetailStockTransactionDetail1.SetLookupEditForDepartmentDataSource(EnumDisplays.GetListenumStockTransactionForDepartment());
            this.Business = obj;
        }
        protected ParameterStockTransactionGetData _pstgd;
        public ParameterStockTransactionGetData PSTGD
        {
            get { return _pstgd; }
            set 
            {
                _pstgd = value;
                if (value.CreatedType != enumStockTransactionCreatedType.DefaultValue)
                {
                    this.helpProvider1.HelpNamespace = Application.StartupPath + "//Helps//Kho.chm";
                    this.helpProvider1.SetHelpKeyword(this, this.GetTextMessage("ConfirmHelpKeyWord", "Xac nhan phieu nhap xuat kho"));
                    this.helpProvider1.SetHelpString(this, this.GetTextMessage("ConfirmHelpKeyWord", "Xac nhan phieu nhap xuat kho"));
                    
                    this.AllowAddNew = false;
                    this.AllowDelete = false;
                    //this.AllowEdit = true;
                    this.AllowSaveAndNew = false;
                    //this.statusBar.Text = "";
                }
                else
                {
                    this.helpProvider1.HelpNamespace = Application.StartupPath + "//Helps//Kho.chm";
                    this.helpProvider1.SetHelpKeyword(this, this.GetTextMessage("DefaultHelpKeyWord", "Phieu nhap xuat kho"));
                    this.helpProvider1.SetHelpString(this, this.GetTextMessage("DefaultHelpKeyWord", "Phieu nhap xuat kho"));
                }
                this.usrDetailStockTransactionDetail1.PSTGD = value;
            }
        }
        public void SetInStock(string _StockCode)
        {
            this.usrDetailStockTransactionDetail1.SetInStock(_StockCode);
        }
        public void SetOutStock(string _StockCode)
        {
            this.usrDetailStockTransactionDetail1.SetOutStock(_StockCode);
        }
        //public void CallAddNewItem()
        //{
        //    this.AddNewItem();
        //}
        public void SetInStockStatus()
        {
            usrDetailStockTransactionDetail1.IsInStock = true;
            this.usrDetailStockTransactionDetail1.SetInStockStatus();
        }
        public void SetOutStockStatus()
        {
            usrDetailStockTransactionDetail1.IsOutStock = true;
            this.usrDetailStockTransactionDetail1.SetOutStockStatus();
        }
        public void SetMoveStatus()
        {
            this.usrDetailStockTransactionDetail1.SetMoveStatus();
        }
        public override void AddNewItem()
        {
            base.AddNewItem();
           // this.BackupDetail();
            btnPrint.Enabled = false;
            StockTransactionBLL.lstWeightItemChose = null;
        }
        public override void EditItem()
        {
            base.EditItem();
           // this.BackupDetail();
            btnPrint.Enabled = false;
            StockTransactionBLL.lstWeightItemChose = null;
        }
        
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            btnPrint.Enabled = this.EditMode == FormEditMode.VIEW && this.CurrentItem != null;
            button2.Enabled = this.EditMode == FormEditMode.VIEW && this.CurrentItem != null;
            button1.Enabled = this.EditMode == FormEditMode.VIEW && !this.usrDetailStockTransactionDetail1.IsMove && this.CurrentItem != null;
        }
        private void BackupDetail()
        {
            lststsd = new ListBase<StockTransactionSumDetail>();
            if (this.CurrentItem != null)
            {
                if ((this.CurrentItem as StockTransaction).Details != null)
                {
                    foreach (StockTransactionSumDetail stsd in (this.CurrentItem as StockTransaction).Details)
                    {
                        StockTransactionSumDetail stsd1 = new StockTransactionSumDetail();
                        stsd1 = (StockTransactionSumDetail)stsd.Clone();
                        lststsd.Add(stsd1);
                    }
                }
            }
            //int i;
            //for (i = 0; i < numTransportCode; i++)
            //{
            //    if ((this.CurrentItem as WeightItem).lstWeightItemDetail[i] != null)
            //    {
            //        arrlstwid[i] = new ListBase<WeightItemDetail>();
            //        foreach (WeightItemDetail wid in (this.CurrentItem as WeightItem).lstWeightItemDetail[i])
            //        {
            //            WeightItemDetail wid1 = new WeightItemDetail();
            //            wid1 = (WeightItemDetail)wid.Clone();
            //            arrlstwid[i].Add(wid1);
            //        }
            //    }
            //}
        }
        public override void CancelItem()
        {
            //if (this.EditMode != FormEditMode.ADD)
            //{
            //    (this.CurrentItem as StockTransaction).Details = lststsd;
            //}
            base.CancelItem();
            btnPrint.Enabled = true;
            StockTransactionBLL.lstWeightItemChose = null;
        }
        //override ade

        private void FormStockTransactionDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
            {
                this.CancelItem();
            }
            StockTransactionBLL.lstWeightItemChose = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           StockTransaction obj = (StockTransaction)this.CurrentItem;
           if (obj != null)
           {
               string Description = this.usrDetailStockTransactionDetail1.DescriptionTransTypeCode;
               object DataSourceLookupItem = this.usrDetailStockTransactionDetail1.DataSourceLookupItem;
               string StockName = this.usrDetailStockTransactionDetail1.CurrentStockName;
               RpStockTransactionDetail1 rp1;
               RpStockTransactionDetail2 rp2;
               string khoGiaoNhan = this.usrDetailStockTransactionDetail1.KhoGiaoNhan;
               if (obj.InStock != "")
               {
                   rp1 = new RpStockTransactionDetail1(obj, Description, DataSourceLookupItem, new VendorBLL().GetAll(), StockName, khoGiaoNhan);
                   rp1.ShowPreviewDialog();
               }
               else
               {
                   rp2 = new RpStockTransactionDetail2(obj, Description, DataSourceLookupItem, new CustomerBLL().GetAll(), StockName, khoGiaoNhan);
                   rp2.ShowPreviewDialog();
               }
               
              
           }
        }

        private void FormStockTransactionDetail_Load(object sender, EventArgs e)
        {
            //this.usrDetailStockTransactionDetail1.RefeshColQuantityReadOnly();
        }

        private void FormStockTransactionDetail_Shown(object sender, EventArgs e)
        {
            this.usrDetailStockTransactionDetail1.RefeshColQuantityReadOnly();
        }

        private void FormStockTransactionDetail_SizeChanged(object sender, EventArgs e)
        {
            //this.usrDetailStockTransactionDetail1.RefeshColQuantityReadOnly();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.CurrentItem == null)
            {
                MessageBox.Show(this.GetTextMessage("ErrorButton1Click-2", "Chưa có phiếu"));
                return;
            }
            if (this.usrDetailStockTransactionDetail1.TransactionTypeCode == null)
            {
                MessageBox.Show(this.GetTextMessage("ErrorButton1Click-1", "Chưa xác định mã N/X"));
            }
            else
            {
                FormEditAccountTransactionStock f = null;
                if (this.usrDetailStockTransactionDetail1.IsInStock)
                {
                    f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKIN.ToString());
                }
                else
                {
                    f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                }
                f.StockTransactionTypeCode = this.usrDetailStockTransactionDetail1.TransactionTypeCode.ToString();
                SetFormPrivilege(f);
                f.DataSource = new ListBase<AccountTransactionStockNew>();
                f.AddNewItem();
                f.GetAccTransStockDetailFromAccountSample(f.StockTransactionTypeCode);
                f.GetDataFromStockTransaction(this.CurrentItem as StockTransaction);
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal totalSL = 0;
            if (this.CurrentItem != null)
            {
                foreach (StockTransactionSumDetail accSum in ((StockTransaction)this.CurrentItem).Details)
                {
                    totalSL += accSum.Quantity;
                }

                string khoGiaoNhan = this.usrDetailStockTransactionDetail1.KhoGiaoNhan;
                if ((this.CurrentItem as StockTransaction).InStock != "")
                {
                    RpInStock rp1 = new RpInStock();
                    RpInStock.Params pr;
                    pr.KhoGiaoNhan = khoGiaoNhan;
                    pr.Description = this.usrDetailStockTransactionDetail1.DescriptionTransTypeCode;
                    pr.DataItem = this.usrDetailStockTransactionDetail1.DataSourceLookupItem;
                    pr.StockName = this.usrDetailStockTransactionDetail1.CurrentStockName;
                    pr.DataDVGiaoNhan = new VendorBLL().GetAll();
                    pr.TotalSLTXN = totalSL;
                    pr.StObj = (StockTransaction)this.CurrentItem;
                    rp1.RpParams = pr;
                    rp1.BindData();
                    rp1.ShowPreviewDialog();
                }
                else
                {
                    RpOutStock rp2 = new RpOutStock();
                    RpOutStock.Params pr;
                    pr.KhoGiaoNhan = khoGiaoNhan;
                    pr.Description = this.usrDetailStockTransactionDetail1.DescriptionTransTypeCode;
                    pr.DataItem = this.usrDetailStockTransactionDetail1.DataSourceLookupItem;
                    pr.StockName = this.usrDetailStockTransactionDetail1.CurrentStockName;
                    pr.DataDVGiaoNhan = new CustomerBLL().GetAll();
                    pr.TotalSLTXN = totalSL;
                    pr.StObj = (StockTransaction)this.CurrentItem;
                    rp2.RpParam = pr;
                    rp2.BindData();
                    rp2.ShowPreviewDialog();
                    //rp2 = new RpStockTransactionDetail2(obj, Description, DataSourceLookupItem, new CustomerBLL().GetAll(), StockName);
                    //rp2.ShowPreviewDialog();
                }


            }
        }
    }
}