using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpTheKho : ReportBase2
    {
        private int numPage;
        public struct Params
        {
            public Item ItemObj;
            public string StockName;
            public DateTime StartDate;
            public decimal OpenQuantity;
        }
        public Params RpParams = new Params();
        public RpTheKho()
        {
            InitializeComponent();
            //cellTotalTonDau.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTotalSLNhap.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTotalSLXuat.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            cellTotalSLTon.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }
        public void BindData()
        {
            this.PrintingSystem.ShowMarginsWarning = false;
            lbItemName.Text = this.RpParams.ItemObj.ItemName;
            lbDVTinh.Text = this.RpParams.ItemObj.Unit;
            lbMaSo.Text = this.RpParams.ItemObj.ItemCode;
            lbKho.Text = this.RpParams.StockName;
            this.txtOpenQuantity.Text = this.RpParams.OpenQuantity.ToString("#,##0");
            this.lbOpenDate.Text = this.RpParams.StartDate.ToString("dd/MM/yyyy");
          
            //cellSTT.DataBindings.Add("Text", this.DataSource, "STT");
            cellNgayCT.DataBindings.Add("Text", this.DataSource, "StockTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            //cellSoCTNhap.DataBindings.Add("Text", this.DataSource, "SoCTNhap");
            //cellSoCTXuat.DataBindings.Add("Text", this.DataSource, "SoCTXuat");
            cellDescription.DataBindings.Add("Text", this.DataSource, "Description");
            cellNgayNX.DataBindings.Add("Text", this.DataSource, "StockTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            //cellTonDau.DataBindings.Add("Text", this.DataSource, "TonDau", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            //cellTotalTonDau.DataBindings.Add("Text", this.DataSource, "TonDau");
            cellSLNhap.DataBindings.Add("Text", this.DataSource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalSLNhap.DataBindings.Add("Text", this.DataSource, "InQuantity");
            cellSLXuat.DataBindings.Add("Text", this.DataSource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalSLXuat.DataBindings.Add("Text", this.DataSource, "OutQuantity");
            //cellSLTon.DataBindings.Add("Text", this.DataSource, "TonCuoi", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
           // cellTotalSLTon.DataBindings.Add("Text", this.DataSource, "TonCuoi");
        }

        private void RpTheKho_AfterPrint(object sender, EventArgs e)
        {
            //lbEndPageNo.Text = this.numPage.ToString();
            //if (this.numPage < 10) lbEndPageNo.Text = "0"+this.numPage.ToString();
            //else lbEndPageNo.Text = this.numPage.ToString();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.numPage += 1;
            if (this.numPage < 10)
            {
                this.xrPageInfo1.Format = "Trang 0{0}";
                //lbEndPageNo.Text = "0" + this.numPage.ToString();
                //lbSoTrang.Text = "0" + this.numPage.ToString();
            }
            else
            {
                this.xrPageInfo1.Format = "Trang {0}";
                //lbEndPageNo.Text = this.numPage.ToString();
                //lbSoTrang.Text = this.numPage.ToString();
            }
        }
        int stt = 0;
        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            stt++;
            this.RpParams.OpenQuantity += (decimal)this.GetCurrentColumnValue("InQuantity") - (decimal)this.GetCurrentColumnValue("OutQuantity");

            this.cellSTT.Text = stt.ToString();
            this.cellSLTon.Text = this.RpParams.OpenQuantity.ToString("#,##0");
            if ((decimal)this.GetCurrentColumnValue("InQuantity") != 0)
            {
                this.cellSoCTNhap.Text = this.GetCurrentColumnValue("StockTransactionNo").ToString();
                this.cellSoCTXuat.Text = "";
            }
            else
            {
                this.cellSoCTNhap.Text = "";
                this.cellSoCTXuat.Text = this.GetCurrentColumnValue("StockTransactionNo").ToString();
            }
        }
    }
}
