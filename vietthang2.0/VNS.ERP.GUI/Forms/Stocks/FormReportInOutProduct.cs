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
using Microsoft.Office.Interop.Excel;
using VNS.Windows;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace VNS.ERP.GUI.Stocks
{
    public partial class FormReportInOutProduct : FormBase
    {
        /// <summary>
        /// 
        /// </summary>
        private DateTime sDate=DateTime.Today;
        /// <summary>
        /// 
        /// </summary>
        private DateTime eDate = DateTime.Today;
        ListBase<Stock> lstStock = null;
        public FormReportInOutProduct()
        {
            InitializeComponent();
            lstStock = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
            if (Contexts.CurrentUser.BranchCode == string.Empty)
            {
                Stock stock = new Stock();
                stock.StockCode = string.Empty;
                stock.StockName = string.Empty;
                lstStock.Insert(0, stock);
            }
            lookUpStock.Properties.DataSource = lstStock;
            this.ucDatePeriodSelection1.WorkingDate = DateTime.Today.AddDays(-1);
        }

        private void FormReportInOutProduct_Load(object sender, EventArgs e)
        {
            if (lstStock.Count > 0)
            {
                lookUpStock.ItemIndex = 0;
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string stockCode = string.Empty;
            if (lookUpStock.EditValue != null)
            {
                stockCode = lookUpStock.EditValue.ToString();
            }
            else
            {
                MessageBox.Show(this.GetTextMessage("MsgErrorStockNull", "Bạn không được phân quyền thực hiện báo cáo này!"));
                return;
            }
            sDate = this.ucDatePeriodSelection1.StartDate;
            eDate = this.ucDatePeriodSelection1.EndDate;

            if (this.radStock.SelectedIndex == 0)
            {
                gridControl1.DataSource = new StockTransactionBLL().ReportInOutProductSumStock(sDate, eDate, this.chkIncludeTemp.Checked);
            }
            else
            {
                if (stockCode == string.Empty)
                {
                    gridControl1.DataSource = new StockTransactionBLL().ReportInOutProduct(sDate, eDate);
                }
                else
                {
                    gridControl1.DataSource = new StockTransactionBLL().ReportInOutProductForStockCode(sDate, eDate, stockCode);
                }
            }
            gridView1.ActiveFilter.Clear();
            btnPrint.Enabled = true;
        }

        FormProgressBar dlg = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.gridControl1.DataSource != null)
            {
                if (checkEditReportExcel.Checked == false)
                {
                    RpStockInOutProduct rp = new RpStockInOutProduct(VNS.Windows.GridUtils.GetDataView(gridControl1).ToTable(), sDate, eDate);
                    //RpStockInOutProduct rp = new RpStockInOutProduct(gridControl1.DataSource, sDate, eDate);
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
                    this.Cursor = Cursors.WaitCursor;
                    ExportToExcel(GridUtils.GetDataView(this.gridControl1).ToTable());
                    this.Cursor = Cursors.Default;
                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                }
            }
            
           
        }

        private void dateEditStart_EditValueChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
        }

        private void ExportToExcel(System.Data.DataTable dtSourced)
        {
            Workbook wb = null;
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\Baocaoxuatnhapthanhpham.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Kho\\Baocaoxuatnhapthanhpham.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                this.Cursor = Cursors.Default;
                return;
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\Baocaoxuatnhapthanhpham.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            int columnCurrent = 1;
            int currentLine = 9;
            ws.Cells[4, 6] = this.sDate;
            ws.Cells[4, 8] = this.eDate;
            if (dlg != null)
                dlg.SetProgressBarMaximum(dtSourced.Rows.Count);

            DataRow row1 = dtSourced.Rows[0];
            string stock = row1["StockName"].ToString();

            ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
            ((Range)ws.Cells[currentLine + 1, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
            currentLine++;

            ws.Cells[currentLine, columnCurrent] = "Kho:" + stock;
            ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;
            ////columnCurrent++;
            ////ws.Cells[currentLine, columnCurrent] = stock;
            ////((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;
            ////((Range)(ws.Cells[currentLine, columnCurrent])).Font.Italic = true;
            currentLine++;
            int sumLines = currentLine;
            foreach (DataRow row in dtSourced.Rows)
            {
                string tam = row["StockName"].ToString();
                if (dlg != null)
                {
                    dlg.SetProgressText("Kho " + row["StockName"].ToString() + "...");
                    dlg.IncreProgressBarValue();
                }
                columnCurrent = 1;
                if (tam != stock)
                {


                    ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                    ws.Cells[currentLine, columnCurrent] = "Tổng cộng";
                    ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;

                    columnCurrent = columnCurrent + 2;
                    if (sumLines > 11)
                    {
                        for (int i = 1; i <= 11; i++)
                        {
                            ((Range)(ws.Cells[currentLine, columnCurrent])).FormulaR1C1 = "=SUM(R[" + (sumLines - currentLine) + "]C:R[-1]C)";
                            ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;

                            columnCurrent++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= 11; i++)
                        {
                            ((Range)(ws.Cells[currentLine, columnCurrent])).FormulaR1C1 = "=SUM(R[" + (11 - currentLine) + "]C:R[-1]C)";
                            ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;

                            columnCurrent++;
                        }
                    }
                    currentLine++;
                    columnCurrent = 1;
                    ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                    ws.Cells[currentLine, columnCurrent] = "Kho:" + tam;
                    ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;
                    //columnCurrent++;

                    //ws.Cells[currentLine, columnCurrent] = tam;
                    //((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;
                    //((Range)(ws.Cells[currentLine, columnCurrent])).Font.Italic = true;
                    stock = tam;
                    currentLine++;
                    int tamLine = currentLine;
                    sumLines = tamLine;
                   
                }

                    ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                    //string a = row["ItemCode"].ToString();
                    //ws.Cells[currentLine, columnCurrent] = a;
                    ws.Cells[currentLine, columnCurrent] = row["ItemCode"];
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["ItemName"];
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["OpenQuantity"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["NhapSX"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["NhapNB"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["NhapXL"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["NhapKhac"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["XuatBan"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["XuatNB"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["XuatXL"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["XuatKhac"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["DeltaStock"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    columnCurrent++;
                    ws.Cells[currentLine, columnCurrent] = row["CloseQuantity"];
                    ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                    currentLine++;
     
            }
            columnCurrent = 1;
            ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
            ((Range)ws.Cells[currentLine, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
            ws.Cells[currentLine, columnCurrent] = "Tổng cộng";
            ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;

            columnCurrent = columnCurrent + 2;
            for (int i = 1; i <= 11; i++)
            {
                ((Range)(ws.Cells[currentLine, columnCurrent])).FormulaR1C1 = "=SUM(R[" + (sumLines - currentLine) + "]C:R[-1]C)";
                ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;

                columnCurrent++;
            }
            currentLine++;
            ws.get_Range("A9", "A9").EntireRow.Delete(true);
            ws.get_Range("A" + currentLine.ToString(), "A" + currentLine.ToString()).EntireRow.Delete(true);
            ws.Cells[currentLine + 2, 1] = "Kế toán kho";
            ws.Cells[currentLine + 2, 5] = "Thủ kho";
            ws.Cells[currentLine + 2, 8] = "Phụ trách bộ phận";
            excelApp.Visible = true;
        }

        private void chkIncludeTemp_EditValueChanged(object sender, EventArgs e)
        {
            this.radStock.SelectedIndex = 0;
        }

        private void lookUpStock_EditValueChanged(object sender, EventArgs e)
        {
            this.radStock.SelectedIndex = 1;
        }
        //private void ExportToExcel()
        //{
        //    string fileName = null;
        //    saveFileDialog1.FileName = fileName;
        //    if (gridControl1.DataSource != null)
        //    {
        //        saveFileDialog1.Filter = "XLS FILE| *xls";
        //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            Cursor currentCursor = Cursor.Current;
        //            try
        //            {
        //                fileName = saveFileDialog1.FileName + ".xls";
        //                gridView1.ExportToExcel(fileName);
        //            }
        //            finally 
        //            {
        //                Cursor.Current = currentCursor;
        //                OpenFile(fileName);
        //            }
        //        }
            //}
        //}

        //private void OpenFile(string fileName)
        //{
        //    System.Diagnostics.Process process = new  System.Diagnostics.Process();
        //    process.StartInfo.FileName = fileName;
        //    process.StartInfo.Verb = "Open";
        //    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
        //    process.Start();
        //}
    }
}