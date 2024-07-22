using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.ERP.Data;
using VNS.Common;
using System.Threading;

namespace VNS.ERP.GUI
{
    public partial class RpInventoryDetail2 : ReportBase1
    {
        DateTime FromDate, ToDate;
        string StockName;
        object ItemDataSource;
        object lstDatasource;
        public bool IsManufacture = false;
        bool IsLocation = false;
        public RpInventoryDetail2()
        {
            InitializeComponent();
        }
         public RpInventoryDetail2(DateTime _FromDate,DateTime _ToDate,string _StockName, bool  _Location , object _ItemDataSource,  object _lstDatasource)
        {
            InitializeComponent();
            FromDate = _FromDate;
            ToDate = _ToDate;
            StockName = _StockName;
            ItemDataSource = _ItemDataSource;
            lstDatasource = _lstDatasource;
            IsLocation = _Location;
            this.DataSource = lstDatasource;
            Bindata();
        }
        private void Bindata()
        {
            string ItemCode = (ItemDataSource as DataRowView).Row["ItemCode"].ToString();
            object obj = new ItemBLL().GetAll();
            Item _Item = (obj as ListBase<Item>).Search("ItemCode", ItemCode);
            if (_Item != null)
                lbUnit.Text = lbUnit.Text + " " + _Item.Unit;

            txtFromDate.Text = FromDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtToDate.Text = ToDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            lbStockName.Text = lbStockName.Text + " " + StockName;
            if ((ItemDataSource as DataRowView).Row["ItemName"] != null)
                lbItemName.Text = lbItemName.Text + " " + (ItemDataSource as DataRowView).Row["ItemName"].ToString();
            lbItemCode.Text = lbItemCode.Text + " " + ItemCode;

            if (IsLocation)
                lbLocationCode.Text = lbLocationCode.Text + (ItemDataSource as DataRowView).Row["LocationCode"].ToString();
            else
                lbLocationCode.Visible = false;
                        
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo ("en-us");
            Opening = Convert.ToDecimal((ItemDataSource as DataRowView).Row["OpenQuantity"]);
            if (Opening != null)
                txtOpen.Text = Convert.ToDecimal(Opening).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            this.celTransactionDate.DataBindings.Add("Text", lstDatasource, "TransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.celDescription.DataBindings.Add("Text", lstDatasource, "Description");
            this.celInQuantity.DataBindings.Add("Text", lstDatasource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            this.celOutQuantity.DataBindings.Add("Text", lstDatasource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
        }
        object Opening;
        int i = 0;
        decimal valueBefor = 0;

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            object Row = xrTable2.Report.GetCurrentRow();
            decimal result = 0;
            i = i + 1;
            object InQuantity = (Row as DataRowView).Row["InQuantity"];
            object OutQuantity = (Row as DataRowView).Row["OutQuantity"];
            Thread.CurrentThread.CurrentCulture = new  System.Globalization.CultureInfo("en-us");
            if (InQuantity != null && OutQuantity != null)
                if (i == 1)
                    result = Convert.ToDecimal(Opening) + Convert.ToDecimal(InQuantity) - Convert.ToDecimal(OutQuantity);
                else
                    result = valueBefor + Convert.ToDecimal(InQuantity) - Convert.ToDecimal(OutQuantity);

            valueBefor = result;
            celClosing.Text = result.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
           

        }

    }
}
