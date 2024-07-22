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
using VNS.Windows;

namespace VNS.ERP.GUI.Stocks
{
    public partial class FormWeightItemDetail : FormEditBase
    {
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        public bool isReceive;
        WeightItemBLL weightItemBLLObj = new WeightItemBLL();
        ListBase<WeightItemDetail>[] arrlstwid;
        int numTransportCode = 6;
        public FormWeightItemDetail()
        {
            InitializeComponent();
            this.Business = weightItemBLLObj;
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupEmp(new EmployeeBLL().GetAll());
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupItem(new ItemBLL().GetAll());
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupStockCode(new StockBLL().GetAll());
            //this.usrDetailGroupWeightItemDetail1.SetTransports(new StockTransportBLL().GetAll("0001"),"0001");
            this.editControl = this.usrDetailGroupWeightItemDetail1;
            //this.dataSource = weightItemBLLObj.GetPKWithDetails("0001", "0001");
        }
        public FormWeightItemDetail(bool _IsReceive, string stockCode)
        {
            InitializeComponent();
            this.stockCode = stockCode;
            this.helpProvider1.HelpNamespace = Application.StartupPath + "//Helps//Kho.chm";
            this.helpProvider1.SetHelpKeyword(this,this.GetTextMessage("DefaultHelpKeyWord", "Phieu can xe phao nhap xuat kho"));
            this.helpProvider1.SetHelpString(this, this.GetTextMessage("DefaultHelpKeyWord", "Phieu can xe phao nhap xuat kho"));
            this.Business = weightItemBLLObj;
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupEmp(new EmployeeBLL().GetByStockCodeAndGroupEmployee(this.stockCode, enumEmployeeGroup.EmployeeWeight.ToString()));
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupItem(new ItemBLL().GetAll());
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupStockCode(new StockBLL().GetAll());
            if (_IsReceive)
            {
                this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupTransTypeCode(new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.In));
            }
            else
            {
                this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupTransTypeCode(new TransactiontypeBLL().GetByStockTransaction(enumStockTransaction.Out));
            }
            isReceive = _IsReceive;
            this.usrDetailGroupWeightItemDetail1.isReceive = isReceive;
            //this.usrDetailGroupWeightItemDetail1.SetTransports(new StockTransportBLL().GetAll("0001"),"0001");
            this.editControl = this.usrDetailGroupWeightItemDetail1;
            //this.dataSource = weightItemBLLObj.GetPKWithDetails("0001", "0001");
            ListBase<Stock> LookupEditKhoGiaoDSr = new StockBLL().GetAll();
            LookupEditKhoGiaoDSr.Add(new Stock());
            ListBase<Stock> LookupEditKhoNhanDSr = new StockBLL().GetAll();
            LookupEditKhoNhanDSr.Add(new Stock());
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupEditKhoGiao(LookupEditKhoGiaoDSr);
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupEditKhoNhan(LookupEditKhoNhanDSr);
            //this.usrDetailStockTransactionDetail1.SetLookupTransactionTypeCodeDataSource(new TransactiontypeBLL().GetByStockTransaction(this.StockTransaction));
            ListBase<Vendor> lstVendor1 = new VendorBLL().GetAll();
            lstVendor1.Add(new Vendor());
            ListBase<Customer> lstVendor2 = new CustomerBLL().GetAll();
            lstVendor2.Add(new Customer());
            ListBase<Vendor> lstTransport = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
            lstTransport.Add(new Vendor());
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupEditDVGiao(lstVendor1);
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupEditDVNhan(lstVendor2);
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupEditDVVanChuyen(lstTransport);
        }
        public FormWeightItemDetail(object dataSourceObj)
        {
            InitializeComponent();
            this.SetDataSource(dataSourceObj);
            this.Business = weightItemBLLObj;
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupEmp(new EmployeeBLL().GetAll());
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupItem(new ItemBLL().GetAll());
            this.usrDetailGroupWeightItemDetail1.SetDataSourceLookupStockCode(new StockBLL().GetAll());
            //this.usrDetailGroupWeightItemDetail1.SetTransports(new StockTransportBLL().GetAll("0001"),"0001");
            this.editControl = this.usrDetailGroupWeightItemDetail1;
        }
        public void SetStockCode(string stockCode)
        {
            this.usrDetailGroupWeightItemDetail1.SetStockCode(stockCode);
        }
        public void SetDataSource(object obj)
        {
            this.DataSource = obj;
        }
        private void FormWeightItemDetail_Load(object sender, EventArgs e)
        {
            //this.usrDetailWeighItemDetail1.Top = 
        }

        private void FormWeightItemDetail_Resize(object sender, EventArgs e)
        {
            this.usrDetailGroupWeightItemDetail1.Width = this.Width+15; //- this.usrDetailGroupWeightItemDetail1.Left;
        }
       
        public override void AddNewItem()
        {
            base.AddNewItem();
            //this.BackupDetail();
        }
        public override void EditItem()
        {
            base.EditItem();
            //this.BackupDetail();
        }
        private void BackupDetail()
        {
            arrlstwid = new ListBase<WeightItemDetail>[numTransportCode];
            int i;
            for (i = 0; i < numTransportCode; i++)
            {
                if ((this.CurrentItem as WeightItem).lstWeightItemDetail[i] != null)
                {
                    arrlstwid[i] = new ListBase<WeightItemDetail>();
                    foreach (WeightItemDetail wid in (this.CurrentItem as WeightItem).lstWeightItemDetail[i])
                    {
                        WeightItemDetail wid1 = new WeightItemDetail();
                        wid1 = (WeightItemDetail)wid.Clone();
                        arrlstwid[i].Add(wid1);
                    }
                }
            }
        }
        public override void CancelItem()
        {
            //this.EditMode = FormEditMode.VIEW;
            base.CancelItem();
        }

        private void FormWeightItemDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                base.CancelItem();
            }
        }
    }
}