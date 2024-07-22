using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using System.Data;

namespace VNS.ERP.GUI
{
    public partial class RpBaocaoTonkhoTheoCayhang : ReportBase1
    {
        
        public RpBaocaoTonkhoTheoCayhang(DataTable dt, string date, string stock)
        {
            InitializeComponent();
            this.txtDate.Text = date;
            this.txtStock.Text += stock;
            this.DataSource = dt;
            BindData();
        }
        private void BindData()
        {
            this.txtItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            this.txtStockLocationCode.DataBindings.Add("Text", this.DataSource, "StockLocationCode");
            this.txtTondauky.DataBindings.Add("Text", this.DataSource, "Tondauky", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtNhapMua.DataBindings.Add("Text", this.DataSource, "NhapMua", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtNhapKhac.DataBindings.Add("Text", this.DataSource, "NhapKhac", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtXuatSX.DataBindings.Add("Text", this.DataSource, "XuatSX", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtXuatKhac.DataBindings.Add("Text", this.DataSource, "XuatKhac", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtChenhlechkho.DataBindings.Add("Text", this.DataSource, "Chenhlechkho", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtToncuoiky.DataBindings.Add("Text", this.DataSource, "Toncuoiky", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtNgaynhap.DataBindings.Add("Text", this.DataSource, "Ngaynhap", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.txtNgaycuoi.DataBindings.Add("Text", this.DataSource, "Ngaycuoi", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.txtSongayluukho.DataBindings.Add("Text", this.DataSource, "Songayluukho", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.GetCurrentColumnValue("ItemName") != null)
            {
                if ((bool)this.GetCurrentColumnValue("Uutiensudung") == true)
                    this.txtUTSD.Text = "X";
                else
                    this.txtUTSD.Text = "";
            }
        }
    }
}
