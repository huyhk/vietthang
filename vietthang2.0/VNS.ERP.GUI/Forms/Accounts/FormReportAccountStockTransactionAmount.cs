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
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraGrid.Columns;
using VNS.Windows;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormReportAccountStockTransactionAmount : FormBase
    {
        System.Data.DataTable dt = null;
        AccountReportBLL bll = new AccountReportBLL();
        private string accountCode;
        public FormReportAccountStockTransactionAmount()
        {
            InitializeComponent();
            colOpenQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            colOpenAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col6111NhapKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col6111NhapMua.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col6111TienNhapKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col6111TienNhapMua.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col6111TienXuatKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col6111TienXuatSX.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col6111XuatKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col6111XuatSX.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col632NhapKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col632NhapSX.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col632TienNhapKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col632TienNhapSX.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col632TienXuatBan.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col632TienXuatKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            col632XuatBan.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col632XuatKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;

            colCloseQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            colCloseAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colInQuantity1.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            colInCostAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colOutQuantity1.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            colOutCostAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colInPrice.DisplayFormat.FormatString = AppConfigs.CONFIG_PRICEVNFORMAT;
            colOutPrice.DisplayFormat.FormatString = AppConfigs.CONFIG_PRICEVNFORMAT;

            colOpenAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            col6111TienNhapKhac.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            col6111TienNhapMua.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            col6111TienXuatKhac.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            col6111TienXuatSX.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            col632TienNhapKhac.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            col632TienNhapSX.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            col632TienXuatBan.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            col632TienXuatKhac.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colOpenAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colCloseAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colInCostAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colOutCostAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
            foreach (GridColumn col in gridView1.Columns)
            {
                if (col.DisplayFormat.FormatType == DevExpress.Utils.FormatType.Numeric)
                {
                    col.Width = 100;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (lookUpAccountCode.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("AccountCodeIsNullError", "Bạn chưa chọn tài khoản để báo cáo"));
                return;
            }
            this.accountCode = lookUpAccountCode.EditValue.ToString();
            dt = bll.GetReportDetail(this.accountCode, this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            gridControl1.DataSource = bll.GetReportAmount(this.accountCode, this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            this.RefeshDetail();
            int len1 = Account.ProductAccount.Length;
            int len2 = Account.MaterialAccount.Length;
            int visibleIndex = 4;
            if (accountCode.Length >= len1 && accountCode.Substring(0, len1) == Account.ProductAccount)
            {
                col632NhapSX.Visible = true;
                col632NhapSX.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632TienNhapSX.Visible = true;
                col632TienNhapSX.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632NhapKhac.Visible = true;
                col632NhapKhac.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632TienNhapKhac.Visible = true;
                col632TienNhapKhac.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632XuatBan.Visible = true;
                col632XuatBan.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632TienXuatBan.Visible = true;
                col632TienXuatBan.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632XuatKhac.Visible = true;
                col632XuatKhac.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632TienXuatKhac.Visible = true;
                col632TienXuatKhac.VisibleIndex = visibleIndex;

                col6111NhapMua.Visible = false;
                col6111TienNhapMua.Visible = false;
                col6111NhapKhac.Visible = false;
                col6111TienNhapKhac.Visible = false;
                col6111XuatSX.Visible = false;
                col6111TienXuatSX.Visible = false;
                col6111XuatKhac.Visible = false;
                col632TienXuatKhac.Visible = false;
            }
            if (accountCode.Length >= len2 && accountCode.Substring(0, len2) == Account.MaterialAccount)
            {
                col6111NhapMua.Visible = true;
                col6111NhapMua.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111TienNhapMua.Visible = true;
                col6111TienNhapMua.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111NhapKhac.Visible = true;
                col6111NhapKhac.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111TienNhapKhac.Visible = true;
                col6111TienNhapKhac.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111XuatSX.Visible = true;
                col6111XuatSX.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111TienXuatSX.Visible = true;
                col6111TienXuatSX.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111XuatKhac.Visible = true;
                col6111XuatKhac.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632TienXuatKhac.Visible = true;
                col632TienXuatKhac.VisibleIndex = visibleIndex;

                col632NhapSX.Visible = false;
                col632TienNhapSX.Visible = false;
                col632NhapKhac.Visible = false;
                col632TienNhapKhac.Visible = false;
                col632XuatBan.Visible = false;
                col632TienXuatBan.Visible = false;
                col632XuatKhac.Visible = false;
                col632TienXuatKhac.Visible = false;
            }
            btnPrintReport.Enabled = true;
            btnPrintReportDetail.Enabled = true;
            btnExportToExcel.Enabled = true;
        }
        private void RefeshDetail()
        {
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            DataRowView drv =null;
            if(cr.Count>0) drv=cr.Current as DataRowView;
            if (drv != null)
            {
                //string stockCode = drv.Row["StockCode"].ToString();
                string itemCode = drv.Row["ItemCode"].ToString();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "ItemCode = '" + itemCode + "'";
                gridControl2.DataSource = dv.ToTable();
            }
            else
            {
                gridControl2.DataSource = null;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.RefeshDetail();
        }
        FormProgressBar dlg = null;
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (!chkReportToExcel.Checked)
            {
                RpAccountTransactionAmount rp = new RpAccountTransactionAmount();
                rp.DataSource = VNS.Windows.GridUtils.GetDataView(gridControl1).ToTable();

                RpAccountTransactionAmount.Params pr;
                pr.PeriodText = this.ucDatePeriodSelection1.PeriodText;
                pr.Taikhoan = this.lookUpAccountCode.Text;
                rp.RpParams = pr;
                rp.BindData();
                rp.ShowPreviewDialog();
            }
            else
            {
                dlg = new FormProgressBar();
                if (dlg != null)
                {
                    dlg.Text = this.Text;
                    dlg.Show();
                }
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoTongHopTaiKhoanKhoHang.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\SoTongHopTaiKhoanKhoHang.xls"));
                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                    return;
                }
                System.Data.DataTable dt = GridUtils.GetDataTable(gridView1);
                if (dlg != null)
                {
                    dlg.SetProgressText("Kết xuất ra file Excel...");
                    dlg.SetProgressBarMaximum(dt.Rows.Count);
                }
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoTongHopTaiKhoanKhoHang.xls");
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                ws.Cells[5, 5] = this.ucDatePeriodSelection1.PeriodText;
                int len1 = Account.ProductAccount.Length;
                int len2 = Account.MaterialAccount.Length;
                if (this.accountCode.Length>=len1 && this.accountCode.Substring(0,len1) == Account.ProductAccount)
                {
                    ws.Cells[7, 6] = "Nhập SX";
                    ws.Cells[7, 7] = "Tiền nhập SX";
                    ws.Cells[7, 8] = "Nhập khác";
                    ws.Cells[7, 9] = "Tiền nhập khác";
                    ws.Cells[7, 10] = "Xuất bán";
                    ws.Cells[7, 11] = "Tiền xuất bán";
                    ws.Cells[7, 12] = "Xuất khác";
                    ws.Cells[7, 13] = "Tiền xuất khác";
                }
                
                int row = 7;
                int rowCount = dt.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    if (dlg != null)
                    {
                        dlg.SetProgressText(dt.Rows[i]["ItemCode"].ToString() + "...");
                        dlg.IncreProgressBarValue();
                    }
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                    ws.Cells[row, 1] = dt.Rows[i]["ItemCode"];
                    ws.Cells[row, 2] = dt.Rows[i]["Code2"];
                    ws.Cells[row, 3] = dt.Rows[i]["ItemName"];
                    ws.Cells[row, 4] = dt.Rows[i]["OpenQuantity"];
                    ws.Cells[row, 5] = dt.Rows[i]["OpenAmount"];
                    if (this.accountCode.Length >= len1 && this.accountCode.Substring(0, len1) == Account.ProductAccount)
                    {
                        ws.Cells[row, 6] = dt.Rows[i]["NhapSX"];
                        ws.Cells[row, 7] = dt.Rows[i]["TienNhapSX"];
                        ws.Cells[row, 8] = dt.Rows[i]["NhapKhac"];
                        ws.Cells[row, 9] = dt.Rows[i]["TienNhapKhac"];
                        ws.Cells[row, 10] = dt.Rows[i]["XuatBan"];
                        ws.Cells[row, 11] = dt.Rows[i]["TienXuatBan"];
                        ws.Cells[row, 12] = dt.Rows[i]["XuatKhac"];
                        ws.Cells[row, 13] = dt.Rows[i]["TienXuatKhac"];
                    }
                    if (this.accountCode.Length >= len2 && this.accountCode.Substring(0, len2) == Account.MaterialAccount)
                    {
                        ws.Cells[row, 6] = dt.Rows[i]["NhapMua"];
                        ws.Cells[row, 7] = dt.Rows[i]["TienNhapMua"];
                        ws.Cells[row, 8] = dt.Rows[i]["NhapKhac"];
                        ws.Cells[row, 9] = dt.Rows[i]["TienNhapKhac"];
                        ws.Cells[row, 10] = dt.Rows[i]["XuatSX"];
                        ws.Cells[row, 11] = dt.Rows[i]["TienXuatSX"];
                        ws.Cells[row, 12] = dt.Rows[i]["XuatKhac"];
                        ws.Cells[row, 13] = dt.Rows[i]["TienXuatKhac"];
                    }
                    ws.Cells[row, 14] = dt.Rows[i]["CloseQuantity"];
                    ws.Cells[row, 15] = dt.Rows[i]["CloseAmount"];
                }
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                excelApp.Visible = true;
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
            }
        }

        private void btnPrintReportDetail_Click(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            DataRowView drv = null;
            if (cr.Count > 0) drv = cr.Current as DataRowView;
            if (!chkReportToExcel.Checked)
            {
                if (drv != null)
                {
                    RpAccountTransactionAmounDetailNgang rp = new RpAccountTransactionAmounDetailNgang();
                    RpAccountTransactionAmounDetailNgang.Params pr;
                    pr.ItemCode = drv.Row["ItemCode"].ToString();
                    pr.ItemName = drv.Row["ItemName"].ToString();
                    //pr.StartDate = this.ucDatePeriodSelection1.StartDate;
                    //pr.EndDate = this.ucDatePeriodSelection1.EndDate;
                    pr.AccountCode = this.lookUpAccountCode.Text;
                    pr.OpenQuantity = Convert.ToDecimal(drv.Row["OpenQuantity"]);
                    pr.CloseQuantity = Convert.ToDecimal(drv.Row["CloseQuantity"]);
                    pr.OpenAmount = Convert.ToDecimal(drv.Row["OpenAmount"]);
                    pr.CloseAmount = Convert.ToDecimal(drv.Row["CloseAmount"]);
                    pr.PeriodText = this.ucDatePeriodSelection1.PeriodText;
                    pr.Ngaymoso = this.ucDatePeriodSelection1.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
                    rp.RpParams = pr;
                    rp.DataSource = VNS.Windows.GridUtils.GetDataView(gridControl2).ToTable();
                    rp.BindData();

                    rp.ShowPreviewDialog();
                }
            }
            else
            {
                dlg = new FormProgressBar();
                if (dlg != null)
                {
                    dlg.Text = this.Text;
                    dlg.Show();
                }
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoChiTietTaiKhoanKhoHang.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists2", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\SoChiTietTaiKhoanKhoHang.xls"));
                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                    return;
                }
                System.Data.DataTable dt = GridUtils.GetDataTable(gridView2);
                if (dlg != null)
                {
                    dlg.SetProgressText("Kết xuất ra file Excel...");
                    dlg.SetProgressBarMaximum(dt.Rows.Count);
                }
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoChiTietTaiKhoanKhoHang.xls");
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                ws.Cells[5, 6] = this.ucDatePeriodSelection1.PeriodText;
                if (drv != null)
                {
                    ws.Cells[7, 2] = drv.Row["ItemCode"];
                    ws.Cells[7, 3] = drv.Row["ItemName"];
                    ws.Cells[7, 9] = drv.Row["OpenQuantity"];
                    ws.Cells[7, 11] = drv.Row["OpenAmount"];
                    ws.Cells[13, 9] = drv.Row["CloseQuantity"];
                    ws.Cells[13, 11] = drv.Row["CloseAmount"];
                }
                
                int row = 9;
                int rowCount = dt.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    if (dlg != null)
                    {
                        dlg.SetProgressText(dt.Rows[i]["StockName"].ToString() + "...");
                        dlg.IncreProgressBarValue();
                    }
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                    ws.Cells[row, 1] = dt.Rows[i]["StockTransactionNo"];
                    ws.Cells[row, 2] = dt.Rows[i]["StockTransactionDate"];
                    ws.Cells[row, 3] = dt.Rows[i]["InvoiceSo"];
                    ws.Cells[row, 4] = dt.Rows[i]["StockName"];
                    ws.Cells[row, 5] = dt.Rows[i]["Description"];
                    ws.Cells[row, 6] = dt.Rows[i]["InQuantity"];
                    ws.Cells[row, 7] = dt.Rows[i]["InPrice"];
                    ws.Cells[row, 8] = dt.Rows[i]["InCostAmount"];
                    ws.Cells[row, 9] = dt.Rows[i]["OutQuantity"];
                    ws.Cells[row, 10] = dt.Rows[i]["OutPrice"];
                    ws.Cells[row, 11] = dt.Rows[i]["OutCostAmount"];
                }
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                excelApp.Visible = true;
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
            }
        }


        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            this.RefeshDetail();
        }

        private void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            btnPrintReport.Enabled = false;
            btnPrintReportDetail.Enabled = false;
            btnExportToExcel.Enabled = false;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoChiTietTKKhoHang.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\SoChiTietTKKhoHang.xls"));
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoChiTietTKKhoHang.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Cells[5, 7] = this.ucDatePeriodSelection1.PeriodText;
            ws.Cells[6, 7] = "Tài khoản: " + this.accountCode;
            int row = 8;
            int rowCount = dt.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                row += 1;
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                ws.Cells[row, 1] = dt.Rows[i]["ItemCode"];
                ws.Cells[row, 2] = dt.Rows[i]["ItemName"];
                ws.Cells[row, 3] = dt.Rows[i]["StockTransactionNo"];
                ws.Cells[row, 4] = dt.Rows[i]["StockTransactionDate"];
                ws.Cells[row, 5] = dt.Rows[i]["StockName"];
                ws.Cells[row, 6] = dt.Rows[i]["DonviCode"];
                ws.Cells[row, 7] = dt.Rows[i]["Description"];
                ws.Cells[row, 8] = dt.Rows[i]["InQuantity"];
                ws.Cells[row, 9] = dt.Rows[i]["InPrice"];
                ws.Cells[row, 10] = dt.Rows[i]["InCostAmount"];
                ws.Cells[row, 11] = dt.Rows[i]["OutQuantity"];
                ws.Cells[row, 12] = dt.Rows[i]["OutPrice"];
                ws.Cells[row, 13] = dt.Rows[i]["OutCostAmount"];
            }
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            //if (this.stockCode == string.Empty)
            //{
            //    ws.get_Range("A3", "A3").EntireRow.Delete(true);
            //}
            //ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
            //ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            this.Cursor = Cursors.Default;
        }

        private void FormReportAccountStockTransactionAmount_Load(object sender, EventArgs e)
        {
            int len1 = Account.ProductAccount.Length;
            int len2 = Account.MaterialAccount.Length;
            string strFilter = string.Empty;
            strFilter = " left(AccountCode, " + len1.ToString() + ") = '" + Account.ProductAccount + "' ";
            strFilter += "or left(AccountCode, " + len2.ToString() + ") = '" + Account.MaterialAccount + "'";
            lookUpAccountCode.Properties.DataSource = new AccountBLL().GetObjectDynamic(strFilter, "");
            if ((lookUpAccountCode.Properties.DataSource as ListBase<Account>).Count > 0)
            {
                lookUpAccountCode.EditValue = (lookUpAccountCode.Properties.DataSource as ListBase<Account>)[0].AccountCode;
            }
        }

        private void lookUpAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            btnPrintReport.Enabled = false;
            btnPrintReportDetail.Enabled = false;
            btnExportToExcel.Enabled = false;
        }
    }
}