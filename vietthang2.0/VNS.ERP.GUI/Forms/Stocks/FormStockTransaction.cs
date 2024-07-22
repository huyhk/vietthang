using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI.Stocks
{
    public enum enumFormStockTransaction { In=1, Out, Confirm}
    public partial class FormStockTransaction : FormEditBase
    {
        
        StockTransactionBLL obj = new StockTransactionBLL();
        public ParameterStockTransactionGetData pstgd;
        public byte TypeTransaction;
        public FormStockTransaction()
        {
            InitializeComponent();
        }
        /// <summary>
        /// xuat nhap kho
        /// </summary>
        /// <param name="_TypeTransaction"> 1: In, 2: Out, 3:Confirm</param>
        public FormStockTransaction(byte _TypeTransaction)
        {
            InitializeComponent();
            this.Business = obj;
            lookUpEditDVGiao.DataSource = new VendorBLL().GetAll();
            lookUpEditDVNhan.DataSource = new CustomerBLL().GetAll();
            lookUpEditKhoGiao.DataSource = new StockBLL().GetAll();
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            lookUpEditKhoNhan.DataSource = new StockBLL().GetAll();
            repLookUpVessel.DataSource = new VesselBLL().GetAll();

            this.helpProvider1.HelpNamespace = Application.StartupPath + "//helps//Kho.chm";
            this.helpProvider1.SetHelpKeyword(this, this.GetTextMessage("DefaultHelpKeyWord", "Phieu nhap xuat kho"));
            this.helpProvider1.SetHelpString(this, this.GetTextMessage("DefaultHelpKeyWord", "Phieu nhap xuat kho"));
            
            if (_TypeTransaction == 1)//in
            {
                pstgd = new ParameterStockTransactionGetData();
                pstgd.GenType1 = enumStockTransactionGenType.DefaultValue;
                pstgd.GenType2 = enumStockTransactionGenType.DefaultValue;
                pstgd.MoveStock = false;
                pstgd.OutStock = false;
                pstgd.Status1 = enumStockTransactionStatus.Confirm;
                pstgd.Status2 = enumStockTransactionStatus.Confirm;
                pstgd.StockTransaction = enumStockTransaction.In;
                pstgd.CreatedType = enumStockTransactionCreatedType.DefaultValue;
                
                this.Text = "Nhập kho";
                colForDepartment.UnGroup();
                colTransactionTypeCode.Group();
              
                //colTransactionTypeCode.SortIndex = 0;
                //colTransactionNo.SortIndex = colTransactionTypeCode.SortIndex + 1;
                //colTransactionNo.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
                //colTransactionNo.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                colDVNhan.Visible = false;
                colKhoNhan.Visible = false;
                colSoDH.Visible = false;
               
               // this.IsInStock = true;
                //colGetByWeightItems.Visible
              
            }
            if (_TypeTransaction == 2)//out
            {
                pstgd = new ParameterStockTransactionGetData();
                pstgd.GenType1 = enumStockTransactionGenType.DefaultValue;
                pstgd.GenType2 = enumStockTransactionGenType.DefaultValue;
                pstgd.MoveStock = false;
                pstgd.OutStock = true;
                pstgd.Status1 = enumStockTransactionStatus.Confirm;
                pstgd.Status2 = enumStockTransactionStatus.Confirm;
                pstgd.StockTransaction = enumStockTransaction.Out;
                pstgd.CreatedType = enumStockTransactionCreatedType.DefaultValue;
                colForDepartment.UnGroup();
                colTransactionTypeCode.Group();
               
                //colTransactionTypeCode.SortIndex = 0;
                this.Text = "Xuất kho";
                //colTransactionNo.SortIndex = 1;
                //colTransactionNo.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
                //colTransactionNo.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                colDVGiao.Visible = false;
                colKhoGiao.Visible = false;
                colSoHD.Visible = false;
                //this.IsOutStock = true;
            }
            if (_TypeTransaction == 3)//confirm
            {
                this.helpProvider1.SetHelpKeyword(this, this.GetTextMessage("ConfirmHelpKeyWord", "Xac nhan phieu nhap xuat kho"));
                this.helpProvider1.SetHelpString(this, this.GetTextMessage("ConfirmHelpKeyWord", "Xac nhan phieu nhap xuat kho"));

                pstgd = new ParameterStockTransactionGetData();
                pstgd.GenType1 = enumStockTransactionGenType.InProduct;
                pstgd.GenType2 = enumStockTransactionGenType.InWaste;
                pstgd.MoveStock = false;
                pstgd.OutStock = false;
                //lookUpPeriod.Visible = false;
                lbPeriod.Visible = false;
                pstgd.Status1 = enumStockTransactionStatus.WaitingConfirm;
                pstgd.Status2 = enumStockTransactionStatus.WaitingReConfirm;
                pstgd.StockTransaction = enumStockTransaction.In;
                pstgd.CreatedType = enumStockTransactionCreatedType.ByManufacture;
                colIsAuto.Visible = false;
                colTransactionTypeCode.UnGroup();
                colStatus.Group();
                colForDepartment.Group();
                this.Text =  "Xác nhận xuất/nhập kho cho các bộ phận khác";;
            }
            if (_TypeTransaction == 4)//move: not use
            {
                pstgd = new ParameterStockTransactionGetData();
                pstgd.GenType1 = enumStockTransactionGenType.DefaultValue;
                pstgd.GenType2 = enumStockTransactionGenType.DefaultValue;
                pstgd.MoveStock = true;
                pstgd.OutStock = false;
                pstgd.Status1 = enumStockTransactionStatus.Confirm;
                pstgd.Status2 = enumStockTransactionStatus.Confirm;
                pstgd.StockTransaction = enumStockTransaction.Move;
                pstgd.CreatedType = enumStockTransactionCreatedType.DefaultValue;

                colForDepartment.UnGroup();
                colTransactionTypeCode.Group();
                this.Text = "Chuyển kho";
            }

            TypeTransaction = _TypeTransaction;
            if (pstgd.CreatedType != enumStockTransactionCreatedType.DefaultValue)
            {
                colGetByWeightItems.Visible = false;
                //lookUpStockCode.Visible = false;
                //lbStockCode.Visible = false;
                //gridControl1.Height += gridControl1.Top - lbStockCode.Top;
                //gridControl1.Top = lbStockCode.Top;
                colOutStock.Visible = false;
                colInStock.Visible = false;
                colTransactionNo.Visible = true;
                colTransactionDate.Visible = true;
                colDescription.Visible = true;
                colStatus.Visible = true;
                
                colTransactionTypeCode.Visible = true;
                this.lookUpStockCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
                this.lookUpStockCode.EditValueChanged += new EventHandler(lookUpStockCode_EditValueChanged);
                try
                {
                    lookUpStockCode.EditValue = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[0].StockCode;
                }
                catch { }
                //pstgd.StockCode = "";
                // this.DataSource = new StockTransactionBLL().GetData(pstgd);
                this.AllowAddNew = false;
                this.AllowDelete = false;
                this.btnRemove.Visible = false;
            }
            else
            {
                this.colStatus.Visible = false;

                this.lookUpStockCode.Properties.DataSource = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
                this.lookUpStockCode.EditValueChanged += new EventHandler(lookUpStockCode_EditValueChanged);
                try
                {
                    lookUpStockCode.EditValue = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[0].StockCode;
                }
                catch { }
               
            }
            this.LookUpEditTTCode.DataSource = new TransactiontypeBLL().GetAll();
            this.LookUpEditStatus.DataSource = EnumDisplays.GetListStockTransactionStatus();
            LookUpEditForDepartment.DataSource = EnumDisplays.GetListenumStockTransactionForDepartment();
            this.CreatedType = pstgd.CreatedType;
            if (_TypeTransaction == 1)
            {
                this.IsInStock = true;
            }
            if (_TypeTransaction == 2)
            {
                this.IsOutStock = true;
            }
        }
        /// <summary>
        /// not use
        /// </summary>
        /// <param name="_pstgd"></param>
        /// <param name="_TypeTransaction"></param>
        public FormStockTransaction(ParameterStockTransactionGetData _pstgd, byte _TypeTransaction)
        {
            InitializeComponent();
            this.Business = obj;
            pstgd = _pstgd;
            TypeTransaction = _TypeTransaction;
            if (pstgd.CreatedType != enumStockTransactionCreatedType.DefaultValue)
            {
               

                colGetByWeightItems.Visible = false;
                //lookUpStockCode.Visible = false;
                //lbStockCode.Visible = false;
                //gridControl1.Height += gridControl1.Top - lbStockCode.Top;
                //gridControl1.Top = lbStockCode.Top;
                colOutStock.Visible = false;
                colInStock.Visible = false;
              
              
                this.lookUpStockCode.Properties.DataSource = new StockBLL().GetAll();
                this.lookUpStockCode.EditValueChanged += new EventHandler(lookUpStockCode_EditValueChanged);
                try
                {
                    lookUpStockCode.EditValue = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[0].StockCode;
                }
                catch { }
                //pstgd.StockCode = "";
               // this.DataSource = new StockTransactionBLL().GetData(pstgd);
             
            }
            else
            {
                this.colStatus.Visible = false;
                this.lookUpStockCode.Properties.DataSource = new StockBLL().GetAll();
                this.lookUpStockCode.EditValueChanged += new EventHandler(lookUpStockCode_EditValueChanged);
                try
                {
                    lookUpStockCode.EditValue = (lookUpStockCode.Properties.DataSource as ListBase<Stock>)[0].StockCode;
                }
                catch { }
            }
            LookUpEditForDepartment.DataSource = EnumDisplays.GetListenumStockTransactionForDepartment();
            this.CreatedType = pstgd.CreatedType;
        }

        void lookUpStockCode_EditValueChanged(object sender, EventArgs e)
        {
            pstgd.StockCode = lookUpStockCode.EditValue.ToString();
            this.RefeshListDataSource();
            //this.gridView1.RefreshEditor(

            //this.gridControl1.DataSource = this.DataSource;
           
            //throw new Exception("The method or operation is not implemented.");
        }
        private void RefeshListDataSource()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            if (TypeTransaction == 1)//InStock
            {
                this.DataSource = new StockTransactionBLL().GetDataInStockForPeriod(pstgd.StockCode, (short)pstgd.StockTransaction, p.StartDate, p.EndDate);
            }
            if (TypeTransaction == 2)//OutStock
            {
                this.DataSource = new StockTransactionBLL().GetDataOutStockForPeriod(pstgd.StockCode, (short)pstgd.StockTransaction, p.StartDate, p.EndDate);
            }
            if (TypeTransaction == 3)//Confirm
            {
                this.DataSource = new StockTransactionBLL().GetDataConfirmForPeriod(pstgd.StockCode, p.StartDate, p.EndDate);
            }
            this.gridControl1.RefreshDataSource();
            this.gridControl1.Refresh();
            this.gridView1.RefreshData();
        }
        public FormStockTransaction(enumStockTransaction _StockTransaction, bool ConfirmForManufacture)
        {
            InitializeComponent();
           // stockTransaction = _StockTransaction;
            if (ConfirmForManufacture)
            {
               //this.DataSource = obj.GetByStockTransaction(_StockTransaction);
            }      
            
            this.gridControl1.DataSource = this.DataSource;
            this.Business = obj;
        }
        protected bool _IsInStock=false;
        public bool IsInStock
        {
            get { return _IsInStock; }
            set
            {
                _IsInStock = value;
                if (this.CreatedType == enumStockTransactionCreatedType.DefaultValue)
                {
                    colInStock.Visible = false;
                    colOutStock.Visible = false;
                }
            }
        }
        protected bool _IsOutStock=false;
        public bool IsOutStock
        {
            get { return _IsOutStock; }
            set
            {
                _IsOutStock = value;
                if (this.CreatedType == enumStockTransactionCreatedType.DefaultValue)
                {
                    colInStock.Visible = false;
                    colOutStock.Visible = false;
                }
            }
        }
        protected bool _IsMove=false;
        public bool IsMove
        {
            get { return _IsMove; }
            set
            {
                _IsMove = value;
                if (value)
                {
                    colGetByWeightItems.Visible = false;
                    lookUpStockCode.Visible = false;
                    lbStockCode.Visible = false;
                    gridControl1.Height += gridControl1.Top - lbStockCode.Top;
                    gridControl1.Top = lbStockCode.Top;
                    colInStock.Visible = true;
                    colOutStock.Visible = true;
                }
            }
        }
        protected enumStockTransactionCreatedType _CreatedType;
        public enumStockTransactionCreatedType CreatedType
        {
            get { return _CreatedType; }
            set 
            { 
                _CreatedType = value;
            }
        }

        public override void EditItem()
        {
            //base.EditItem();
            FormStockTransactionDetail f = new FormStockTransactionDetail();
            SetFormPrivilege(f);
            if (this.IsMove) f.SetMoveStatus();
            if (this.IsInStock)
            {
                f.SetInStockStatus();
                f.SetInStock(lookUpStockCode.EditValue.ToString());
            }
            if (this.IsOutStock)
            {
                f.SetOutStockStatus();
                f.SetOutStock(lookUpStockCode.EditValue.ToString());
            }
            f.PSTGD = pstgd;
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            f.EditItem();
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<StockTransaction>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        public override void AddNewItem()
        {
            //base.AddNewItem();
            FormStockTransactionDetail f = new FormStockTransactionDetail();
            SetFormPrivilege(f);
            if (this.IsMove) f.SetMoveStatus();
            if (this.IsInStock)
            {
                f.SetInStockStatus();
                f.SetInStock(lookUpStockCode.EditValue.ToString());
            }
            if (this.IsOutStock)
            {
                f.SetOutStockStatus();
                f.SetOutStock(lookUpStockCode.EditValue.ToString());
            }
            //CurrencyManager cr =
            f.PSTGD = pstgd;
            f.DataSource = this.DataSource; 
            f.AddNewItem();
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<StockTransaction>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void FormStockTransaction_Load(object sender, EventArgs e)
        {
            if (pstgd.CreatedType != enumStockTransactionCreatedType.DefaultValue)
            {
                this.AllowAddNew = false;
                this.AllowDelete = false;
                this.btnRemove.Visible = false;
            }
            this.gridControl1.RefreshDataSource();
            this.gridView1.ExpandAllGroups();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormStockTransactionDetail f = new FormStockTransactionDetail();
            SetFormPrivilege(f);
            if (this.IsMove) f.SetMoveStatus();
            if (this.IsInStock)
            {
                f.SetInStockStatus();
                f.SetInStock(lookUpStockCode.EditValue.ToString());
            }
            if (this.IsOutStock)
            {
                f.SetOutStockStatus();
                f.SetOutStock(lookUpStockCode.EditValue.ToString());
            }
            f.PSTGD = pstgd;
            f.DataSource = this.DataSource;
            f.CurrentItem = this.CurrentItem;
            //f.EditItem();
            f.Text = this.Text;
            this.ShowChildForm(f);
            if ((this.DataSource as ListBase<StockTransaction>).Count > 0)
            {
                this.CurrentItem = f.CurrentItem;
            }
            else
            {
                this.CurrentItem = null;
            }
            gridControl1.RefreshDataSource();
            this.RefreshButtons();
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpStockCode.EditValue != null)
            {
                this.RefeshListDataSource();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lookUpStockCode.EditValue != null && lookUpPeriod.EditValue !=null)
            {
                this.RefeshListDataSource();
            }
        }
        //override 
    }
}