using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpInOutMaterial : ReportBase1
    {
        public RpInOutMaterial()
        {
            InitializeComponent();
        }
         /// <summary>
        /// Use
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public RpInOutMaterial(object dataSource, DateTime startDate, DateTime endDate)
        {
            
            InitializeComponent();
            txtStartDate.Text = startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtEndDate.Text = endDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.DataSource = dataSource;
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            this.LoadData();
        }
        private void LoadData()
        {
            txtStockCode.DataBindings.Add("Text", this.DataSource, "StockName", "Kho: {0}");
            cellItemCode.DataBindings.Add("Text", this.DataSource, "ItemCode");
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");

            cellOpenQuantity.DataBindings.Add("Text", this.DataSource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellOpenQuantityStock.DataBindings.Add("Text", this.DataSource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellOpenQuantityStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellNhapMua.DataBindings.Add("Text", this.DataSource, "NhapMua", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellNhapMuaStock.DataBindings.Add("Text", this.DataSource, "NhapMua");
            cellNhapMuaStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellNhapNB.DataBindings.Add("Text", this.DataSource, "NhapNB", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellNhapNBStock.DataBindings.Add("Text", this.DataSource, "NhapNB", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellNhapNBStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellNhapSoChe.DataBindings.Add("Text", this.DataSource, "NhapSoChe", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellNhapSoCheStock.DataBindings.Add("Text", this.DataSource, "NhapSoChe", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellNhapSoCheStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellNhapKhac.DataBindings.Add("Text", this.DataSource, "NhapKhac", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellNhapKhacStock.DataBindings.Add("Text", this.DataSource, "NhapKhac", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellNhapKhacStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;


            cellXuatSX.DataBindings.Add("Text", this.DataSource, "XuatSX", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatSXStock.DataBindings.Add("Text", this.DataSource, "XuatSX", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatSXStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellXuatNB.DataBindings.Add("Text", this.DataSource, "XuatNB", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatNBStock.DataBindings.Add("Text", this.DataSource, "XuatNB", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatNBStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellXuatSoChe.DataBindings.Add("Text", this.DataSource, "XuatSoChe", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatSoCheStock.DataBindings.Add("Text", this.DataSource, "XuatSoChe", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatSoCheStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellXuatBan.DataBindings.Add("Text", this.DataSource, "XuatBan", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatBanStock.DataBindings.Add("Text", this.DataSource, "XuatBan", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatBanStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellXuatKhac.DataBindings.Add("Text", this.DataSource, "XuatKhac", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatKhacStock.DataBindings.Add("Text", this.DataSource, "XuatKhac", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellXuatKhacStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;


            cellDeltaStock.DataBindings.Add("Text", this.DataSource, "DeltaStock", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDeltaStockStock.DataBindings.Add("Text", this.DataSource, "DeltaStock", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDeltaStockStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            cellCloseQuantity.DataBindings.Add("Text", this.DataSource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellCloseQuantityStock.DataBindings.Add("Text", this.DataSource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellCloseQuantityStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
        }
    }
}
