using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using VNS.Utils;

namespace VNS.ERP.GUI
{
    public partial class RpSaleRequestList : ReportBase1
    {
        private ListBase<Item> lstItems;
        public RpSaleRequestList()
        {
            InitializeComponent();
            lstItems = (new ItemBLL()).GetbyItemtype((int)enumItemType.Product);
        }
     
        public void BindDataDetail()
        {
            this.cellSLYC.DataBindings.Add("Text", DataSource, "QuantityReq",AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotal.DataBindings.Add("Text", DataSource, "QuantityReq",AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotal.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING;

            this.cellSLTX.DataBindings.Add("Text", DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotalTX.DataBindings.Add("Text", DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotalTX.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING;
        }
        public void BindDataMaster(SaleRequests sale)
        {
            this.cellDescription.Text = sale.SaleRequestNo;
            this.cellXuattaikho.Text = sale.StockCode;

            this.DataSource = sale.Details;
            BindDataDetail();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            object obj = this.GetCurrentRow();
            if ((obj as SaleRequestDetails).ItemCode != "")
            {
                this.cellSTT.Text = (this.CurrentRowIndex + 1).ToString();
                this.cellDVT.Text = "Kg";
                this.cellTen.Text = lstItems.Search("ItemCode", (obj as SaleRequestDetails).ItemCode).ItemName;
            }
            else
            {
                this.cellTen.Text = "";
                this.cellDVT.Text = "";
                this.cellSTT.Text = "";
                this.cellSLYC.Text = "";
            }

        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.cellBangchu.Text = NumberConvert.NumberToSentence(decimal.Parse(this.cellTotal.Summary.GetResult().ToString()))+" Kg";
        }
      
    }
}
