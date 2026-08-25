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
    public partial class FormReportAccountStockTransactionQuantity : FormBase
    {
        System.Data.DataTable dt = null;
        AccountReportBLL bll = new AccountReportBLL();
        private string accountCode = string.Empty;
        private DateTime startDate;
        private DateTime endDate;
        public FormReportAccountStockTransactionQuantity()
        {
            InitializeComponent();
            colOpenQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col6111NhapKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col6111NhapMua.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col6111XuatKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col6111XuatSX.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;

            col632NhapKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col632NhapSX.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col632XuatBan.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            col632XuatKhac.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;

            colCloseQuantity.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            colInQuantity1.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            colOutQuantity1.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
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
            this.startDate = this.ucDatePeriodSelection1.StartDate;
            this.endDate = this.ucDatePeriodSelection1.EndDate;
            if (!Account.IsStockReportPeriodValid(this.startDate, this.endDate, this.accountCode))
            {
                MessageBox.Show("Kỳ báo cáo hoặc tài khoản kho không phù hợp với ngày thay đổi định khoản 01/01/2026. Vui lòng tách báo cáo và chọn tài khoản cũ/mới tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dt = bll.GetReportDetailQuantity(this.accountCode, this.startDate, this.endDate);
            gridControl1.DataSource = bll.GetReportQuantity(this.accountCode, this.startDate, this.endDate);
            this.RefeshDetail();
            int len1 = Account.ProductAccount.Length;
            int len2 = Account.MaterialAccount.Length;
            int visibleIndex = 4;
            if (Account.IsProductInventoryAccount(accountCode))
            {
                col632NhapSX.Visible = true;
                col632NhapSX.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632NhapKhac.Visible = true;
                col632NhapKhac.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632XuatBan.Visible = true;
                col632XuatBan.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col632XuatKhac.Visible = true;
                col632XuatKhac.VisibleIndex = visibleIndex;

                col6111NhapMua.Visible = false;
                col6111NhapKhac.Visible = false;
                col6111XuatSX.Visible = false;
                col6111XuatKhac.Visible = false;
            }
            if (Account.IsMaterialInventoryAccount(accountCode))
            {
                col6111NhapMua.Visible = true;
                col6111NhapMua.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111NhapKhac.Visible = true;
                col6111NhapKhac.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111XuatSX.Visible = true;
                col6111XuatSX.VisibleIndex = visibleIndex;
                visibleIndex += 1;
                col6111XuatKhac.Visible = true;
                col6111XuatKhac.VisibleIndex = visibleIndex;

                col632NhapSX.Visible = false;
                col632NhapKhac.Visible = false;
                col632XuatBan.Visible = false;
                col632XuatKhac.Visible = false;
            }
            btnPrintReport.Enabled = true;
            btnPrintReportDetail.Enabled = true;
            btnInTheKho.Enabled = true;
            btnExportStockCardToExcel.Enabled = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.RefeshDetail();
        }
        private void RefeshDetail()
        {
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            DataRowView drv =null;
            if (cr.Count > 0) drv=cr.Current as DataRowView;
            if (drv != null)
            {
                string stockCode = drv.Row["StockCode"].ToString();
                string itemCode = drv.Row["ItemCode"].ToString();
                DataView dv = dt.DefaultView;
                dv.RowFilter = "StockCode = '" + stockCode + "' and ItemCode = '" + itemCode + "'";
                gridControl2.DataSource = dv.ToTable();
            }
            else
            {
                gridControl2.DataSource = null;
            }
        }
        FormProgressBar dlg = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!chkReportToExcel.Checked)
            {
                RpAccountTransactionQuantity rp = new RpAccountTransactionQuantity();
                rp.DataSource = VNS.Windows.GridUtils.GetDataView(gridControl1).ToTable();

                RpAccountTransactionQuantity.Params pr;
                //pr.StartDate = this.ucDatePeriodSelection1.StartDate;
                //pr.EndDate = this.ucDatePeriodSelection1.EndDate;
                pr.PeriodText = this.ucDatePeriodSelection1.PeriodText;
                rp.ParamsObj = pr;
                rp.BindData();
                rp.ShowPreviewDialog();
            }
            else
            {
                dlg = new FormProgressBar();
                if (dlg != null)
                {
                    dlg.Text = this.Text;
                    dlg.SetProgressText("Kết xuất ra file Excel...");
                    dlg.Show();
                }
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoTongHopSLKhoHang.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\SoTongHopSLKhoHang.xls"));
                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                    return;
                }
                System.Data.DataView dv = GridUtils.GetDataView(gridControl1);
              
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoTongHopSLKhoHang.xls");
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                dv.Sort = "SoHieu asc";
                System.Data.DataTable dt = dv.ToTable();
                if (dlg != null)
                    dlg.SetProgressBarMaximum(dt.Rows.Count);
                ws.Cells[5, 4] = this.ucDatePeriodSelection1.PeriodText;
                int len1 = Account.ProductAccount.Length;
                int len2 = Account.MaterialAccount.Length;
                if (Account.IsProductInventoryAccount(this.accountCode))
                {
                    ws.Cells[7, 4] = "Nhập SX";
                    ws.Cells[7, 5] = "Nhập khác";
                    ws.Cells[7, 6] = "Xuất bán";
                    ws.Cells[7, 7] = "Xuất khác";
                }
                int row = 7;
                int rowCount = dt.Rows.Count;
                string stockName = string.Empty;
                for (int i = 0; i < rowCount; i++)
                {
                    if (dlg != null)
                    {
                        dlg.SetProgressText("Kho: "+dt.Rows[i]["StockName"].ToString() + "...");
                        dlg.IncreProgressBarValue();
                    }
                    if(stockName != dt.Rows[i]["StockName"].ToString())
                    {
                        row += 1;
                        ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                        ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                        ((Range)(ws.Cells[row, 1])).Font.Bold = true;
                        stockName=dt.Rows[i]["StockName"].ToString();
                        ws.Cells[row, 1] = "Kho: " + stockName;
                    }
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                   
                    ws.Cells[row, 1] = dt.Rows[i]["ItemCode"];
                    ws.Cells[row, 2] = dt.Rows[i]["ItemName"];
                    ws.Cells[row, 3] = dt.Rows[i]["OpenQuantity"];
                    if (Account.IsProductInventoryAccount(this.accountCode))
                    {
                        ws.Cells[row, 4] = dt.Rows[i]["NhapSX"];
                        ws.Cells[row, 5] = dt.Rows[i]["NhapKhac"];
                        ws.Cells[row, 6] = dt.Rows[i]["XuatBan"];
                        ws.Cells[row, 7] = dt.Rows[i]["XuatKhac"];
                    }
                    if (Account.IsMaterialInventoryAccount(this.accountCode))
                    {
                        ws.Cells[row, 4] = dt.Rows[i]["NhapMua"];
                        ws.Cells[row, 5] = dt.Rows[i]["NhapKhac"];
                        ws.Cells[row, 6] = dt.Rows[i]["XuatSX"];
                        ws.Cells[row, 7] = dt.Rows[i]["XuatKhac"];
                    }
                   
                    ws.Cells[row, 8] = dt.Rows[i]["CloseQuantity"];
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
                    RpAccountTransactionQuantityDetail rp = new RpAccountTransactionQuantityDetail();
                    RpAccountTransactionQuantityDetail.Params pr;
                    pr.StockName = drv.Row["StockName"].ToString();
                    pr.ItemCode = drv.Row["ItemCode"].ToString();
                    pr.ItemName = drv.Row["ItemName"].ToString();
                    //pr.StartDate = this.ucDatePeriodSelection1.StartDate;
                    //pr.EndDate = this.ucDatePeriodSelection1.EndDate;
                    pr.PeriodText = this.ucDatePeriodSelection1.PeriodText;
                    pr.OpenQuantity = Convert.ToDecimal(drv.Row["OpenQuantity"]);
                    pr.CloseQuantity = Convert.ToDecimal(drv.Row["CloseQuantity"]);
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
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoChiTietSLKhoHang.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists2", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\SoChiTietSLKhoHang.xls"));
                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                    return;
                }
                System.Data.DataTable dt = GridUtils.GetDataTable(gridView2);
                if (dlg != null)
                    dlg.SetProgressBarMaximum(dt.Rows.Count);
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoChiTietSLKhoHang.xls");
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                ws.Cells[5, 3] = this.ucDatePeriodSelection1.PeriodText;
                if (drv != null)
                {
                    ws.Cells[6, 2] = drv.Row["StockName"].ToString();
                    ws.Cells[7, 2] = drv.Row["ItemCode"].ToString();
                    ws.Cells[7, 3] = drv.Row["ItemName"].ToString();
                    ws.Cells[7, 6] = Convert.ToDecimal(drv.Row["OpenQuantity"]);
                    ws.Cells[13, 6] = Convert.ToDecimal(drv.Row["CloseQuantity"]);
                }
                
                int row = 9;
                int rowCount = dt.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    if (dlg != null)
                    {
                        dlg.SetProgressText("Ngày: " + dt.Rows[i]["StockTransactionDate"].ToString() + "...");
                        dlg.IncreProgressBarValue();
                    }
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                    ws.Cells[row, 1] = dt.Rows[i]["StockTransactionNo"];
                    ws.Cells[row, 2] = dt.Rows[i]["StockTransactionDate"];
                    ws.Cells[row, 3] = dt.Rows[i]["InvoiceSo"];
                    ws.Cells[row, 4] = dt.Rows[i]["Description"];
                    ws.Cells[row, 5] = dt.Rows[i]["InQuantity"];
                    ws.Cells[row, 6] = dt.Rows[i]["OutQuantity"];
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
            btnInTheKho.Enabled = false;
            btnExportStockCardToExcel.Enabled = false;
        }

        private void btnInTheKho_Click(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            DataRowView drv = null;
            if (cr.Count > 0) drv = cr.Current as DataRowView;
            if (drv != null)
            {
                RpTheKho rp = new RpTheKho();
                RpTheKho.Params pr;
                pr.StockName = drv.Row["StockName"].ToString();
                ListBase<Item> lstItem = new ItemBLL().GetDynamic(" ItemCode = '" + drv.Row["ItemCode"].ToString() +"' ", "");
                Item item = null;
                if (lstItem.Count > 0) item = lstItem[0];
                else item = new Item();
                pr.ItemObj = item;
                pr.StartDate = this.ucDatePeriodSelection1.StartDate;
                pr.OpenQuantity = (decimal)drv.Row["OpenQuantity"];
                rp.RpParams = pr;

                //rp.DataSource = new AccountReportBLL().ReportTheKho(item.ItemCode, drv.Row["StockCode"].ToString(), this.startDate, this.endDate);
                rp.DataSource = VNS.Windows.GridUtils.GetDataView(gridControl2).ToTable();
                rp.BindData();

                rp.ShowPreviewDialog();
            }
        }

        private void btnExportStockCardToExcel_Click(object sender, EventArgs e)
        {
            if (!this.chkReportToExcel.Checked)
            {
                this.btnInTheKho_Click(null, null);
                return;
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\TheKho.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\TheKho.xls"));
                return;
            }
            CurrencyManager cr = this.BindingContext[gridControl1.DataSource] as CurrencyManager;
            DataRowView drv = null;
            if (cr.Count > 0) drv = cr.Current as DataRowView;

            if (drv != null)
            {
                this.Cursor = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\TheKho.xls");
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                ws.Cells[9, 6] = drv.Row["StockName"].ToString();
                ListBase<Item> lstItem = new ItemBLL().GetDynamic(" ItemCode = '" + drv.Row["ItemCode"].ToString() + "' ", "");
                Item item = null;
                if (lstItem.Count > 0) item = lstItem[0];
                else item = new Item();
                //System.Data.DataTable dt1 = new AccountReportBLL().ReportTheKho(item.ItemCode, drv.Row["StockCode"].ToString(), this.startDate, this.endDate);
                System.Data.DataTable dt1 = VNS.Windows.GridUtils.GetDataView(gridControl2).ToTable();
                ws.Cells[7, 5] = item.ItemName;
                ws.Cells[8, 3] = item.Unit;
                ws.Cells[9, 3] = item.ItemCode;
                ws.Cells[9, 9] = drv.Row["OpenQuantity"];
                ws.Cells[15, 9] = drv.Row["CloseQuantity"];
                ws.Cells[18, 3] = this.startDate;

                decimal closeQuantity = (decimal)drv.Row["OpenQuantity"];
                int row = 12;
                int rowCount = dt1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    ws.Cells[row, 2] = dt1.Rows[i]["StockTransactionDate"];
                    if ((decimal)dt1.Rows[i]["InQuantity"] != 0)
                    {
                        ws.Cells[row, 3] = dt1.Rows[i]["StockTransactionNo"];
                        ws.Cells[row, 7] = dt1.Rows[i]["InQuantity"];
                    }
                    else
                    {
                        ws.Cells[row, 4] = dt1.Rows[i]["StockTransactionNo"];
                        ws.Cells[row, 8] = dt1.Rows[i]["OutQuantity"];
                    }
                    
                    
                    ws.Cells[row, 5] = dt1.Rows[i]["Description"];
                    ws.Cells[row, 6] = dt1.Rows[i]["StockTransactionDate"];

                    closeQuantity += (decimal)dt1.Rows[i]["InQuantity"] - (decimal)dt1.Rows[i]["OutQuantity"];
                    ws.Cells[row, 9] = closeQuantity;
                }
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                excelApp.Visible = true;
                
                this.Cursor = Cursors.Default;
            }
        }

        private void FormReportAccountStockTransactionQuantity_Load(object sender, EventArgs e)
        {
            int len1 = Account.ProductAccount.Length;
            int len2 = Account.MaterialAccount.Length;
            string strFilter = string.Empty;
            strFilter = "left(AccountCode,4) = '6111' or left(AccountCode,3) = '152' ";
            strFilter += "or left(AccountCode,3) = '632' or left(AccountCode,3) = '155'";
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
            btnInTheKho.Enabled = false;
            btnExportStockCardToExcel.Enabled = false;
        }
    }
}
