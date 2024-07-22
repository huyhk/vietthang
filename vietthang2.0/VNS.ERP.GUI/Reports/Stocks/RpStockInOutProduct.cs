using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Threading;
using System.Globalization;
using VNS.Common;
namespace VNS.ERP.GUI
{
    public partial class RpStockInOutProduct : ReportBase1
    {
        object dataSource=null;
        /// <summary>
        /// not use
        /// </summary>
        public RpStockInOutProduct()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Use
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public RpStockInOutProduct(object dataSource, DateTime startDate, DateTime endDate)
        {
            
            InitializeComponent();
           txtStartDate.Text = startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            txtEndDate.Text = endDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.dataSource = dataSource;
            this.DataSource = dataSource;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            this.LoadData();
            this.PrintingSystem.ShowMarginsWarning = false;
            this.PrintingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
        }
        private void LoadData()
        {
            txtStockCode.DataBindings.Add("Text", dataSource, "StockName");
            cellItemCode.DataBindings.Add("Text", DataSource, "ItemCode");
            cellItemName.DataBindings.Add("Text", DataSource, "ItemName");
            cellOpenQuantity.DataBindings.Add("Text", dataSource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalOpenQuantity.DataBindings.Add("Text", dataSource, "OpenQuantity");
            cellTotalOpenQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            cellNhapKhac.DataBindings.Add("Text", dataSource, "NhapKhac", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalNhapKhac.DataBindings.Add("Text", dataSource, "NhapKhac", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalNhapKhac.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            //cellNhapKK.DataBindings.Add("Text", dataSource, "NhapKK", "{0:###,###,###,##0.00}");
            cellNhapXL.DataBindings.Add("Text", dataSource, "NhapXL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalNhapXL.DataBindings.Add("Text", dataSource, "NhapXL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalNhapXL.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            cellNhapSX.DataBindings.Add("Text", dataSource, "NhapSX", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalNhapSX.DataBindings.Add("Text", dataSource, "NhapSX", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalNhapSX.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            cellNhapNB.DataBindings.Add("Text", dataSource, "NhapNB", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalNhapNB.DataBindings.Add("Text", dataSource, "NhapNB", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalNhapNB.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            cellXuatBan.DataBindings.Add("Text", dataSource, "XuatBan", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalXuatBan.DataBindings.Add("Text", dataSource, "XuatBan", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalXuatBan.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            cellXuatKhac.DataBindings.Add("Text", dataSource, "XuatKhac", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalXuatKhac.DataBindings.Add("Text", dataSource, "XuatKhac", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalXuatKhac.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            //cellXuatKK.DataBindings.Add("Text", dataSource, "XuatKK", "{0:###,###,###,##0.00}");
            cellXuatXL.DataBindings.Add("Text", dataSource, "XuatXL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalXuatXL.DataBindings.Add("Text", dataSource, "XuatXL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalXuatXL.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            cellXuatNB.DataBindings.Add("Text", dataSource, "XuatNB", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalXuatNB.DataBindings.Add("Text", dataSource, "XuatNB", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalXuatNB.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            cellDeltaStock.DataBindings.Add("Text", dataSource, "DeltaStock", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalDeltaStock.DataBindings.Add("Text", dataSource, "DeltaStock", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalDeltaStock.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;

            cellCloseQuantity.DataBindings.Add("Text", dataSource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalCloseQuantity.DataBindings.Add("Text", dataSource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            cellTotalCloseQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;
        }

        private void RpStockInOutProduct_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //object obj = Detail.Report.GetCurrentRow();
            //if (obj != null)
            //{
            //   // cellTotalSoBao.Text = Convert.ToString(Convert.ToDecimal(cellTotalSoBao.Text) + (obj as StockTransactionSumDetail).WrappingCounter);
            //}
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //cellTotalCloseQuantity.Text = "0";
            //cellTotalDeltaStock.Text = "0";
            //cellTotalNhapKhac.Text = "0";
            //cellTotalNhapXL.Text = "0";
            //cellTotalNhapSX.Text = "0";
            //cellTotalNhapNB.Text = "0";
            //cellTotalOpenQuantity.Text = "0";
            //cellTotalXuatBan.Text = "0";
            //cellTotalXuatKhac.Text = "0";
            //cellTotalXuatXL.Text = "0";
            //cellTotalXuatNB.Text = "0";
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            //cellTotalCloseQuantity.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalCloseQuantity.Text) + Convert.ToDecimal(cellCloseQuantity.Text)).ToString("N");
            //cellTotalDeltaStock.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalDeltaStock.Text) + Convert.ToDecimal(cellDeltaStock.Text)).ToString("N"); ;
            //cellTotalNhapKhac.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalNhapKhac.Text) + Convert.ToDecimal(cellNhapKhac.Text)).ToString("N"); ;

            //cellTotalNhapXL.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalNhapXL.Text) + Convert.ToDecimal(cellNhapXL.Text)).ToString("N"); ;
            //cellTotalNhapSX.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalNhapSX.Text) + Convert.ToDecimal(cellNhapSX.Text)).ToString("N"); ;
            //cellTotalNhapNB.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalNhapNB.Text) + Convert.ToDecimal(cellNhapNB.Text)).ToString("N"); ;
            //cellTotalOpenQuantity.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalOpenQuantity.Text) + Convert.ToDecimal(cellOpenQuantity.Text)).ToString("N"); ;
            //cellTotalXuatBan.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalXuatBan.Text) + Convert.ToDecimal(cellXuatBan.Text)).ToString("N"); ;
            //cellTotalXuatKhac.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalXuatKhac.Text) + Convert.ToDecimal(cellXuatKhac.Text)).ToString("N"); ;
            //cellTotalXuatXL.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalXuatXL.Text) + Convert.ToDecimal(cellXuatXL.Text)).ToString("N"); ;
            //cellTotalXuatNB.Text = Convert.ToDecimal(Convert.ToDecimal(cellTotalXuatNB.Text) + Convert.ToDecimal(cellXuatNB.Text)).ToString("N"); ;
        }

        private void RpStockInOutProduct_AfterPrint(object sender, EventArgs e)
        {
            //this.PrintingSystem.ShowMarginsWarning = false;
            //this.PrintingSystem.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            //this.PaperKind=System.Drawing.Printing.PaperKind.A4;
            

        }
    }
}
