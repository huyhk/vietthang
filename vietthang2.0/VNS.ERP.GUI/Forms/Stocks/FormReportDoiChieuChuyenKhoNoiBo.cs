using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Stocks
{
    public partial class FormReportDoiChieuChuyenKhoNoiBo : FormBase
    {
        public FormReportDoiChieuChuyenKhoNoiBo()
        {
            InitializeComponent();
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate.AddDays(-1);
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            FormProgressBar dlg = new FormProgressBar();
           
            DataSet ds = new StockReportBLL().ReportDoiChieuChuyenKhoNoiBo(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            System.Data.DataTable dt = ds.Tables[0];
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(dt.Rows.Count);
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\BangDoichieuChuyenkhoNoibo.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Kho\\BangDoichieuChuyenkhoNoibo.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\BangDoichieuChuyenkhoNoibo.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            int rowCount = dt.Rows.Count;
            string outStockCode = string.Empty;
            string inStockCode = string.Empty;
            
            int rowCaptionPos = 6;
            int row = rowCaptionPos;
            int startColOutStock = 6;
            int startColInStock = 3;
            int colWriteOutStock = -1;
            int colWriteInStock = -1;
            bool endOutStock = false;
            DataRow dr = null;
            string[] outStockColString = { "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI" };
            int endOutStockColPos = 1;
            string[] inStockColString = { "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
            int endInStockColPos = 1;
            string cellItemCode = string.Empty;

            for (int i = 0; i < rowCount; i++)
            {
                if (dlg != null)
                {
                    dlg.SetProgressText("Kho: " + dt.Rows[i]["StockCode"].ToString()+"...");
                    dlg.IncreProgressBarValue();
                }
                dr = dt.Rows[i];
                if(!endOutStock) endOutStock = (int)dr["InStock"]==1;
                if (!endOutStock)
                {
                    if (outStockCode != dr["StockCode"].ToString())
                    {
                        ws.get_Range(outStockColString[endOutStockColPos] + "1", outStockColString[endOutStockColPos] + "1").EntireColumn.Copy(Type.Missing);
                        ((Range)(ws.Cells[1, endOutStockColPos + startColOutStock])).EntireColumn.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                        outStockCode = dr["StockCode"].ToString();
                        colWriteOutStock +=1;
                        ws.Cells[rowCaptionPos, startColOutStock + endOutStockColPos - 1] = outStockCode;
                        endOutStockColPos += 1;
                    }
                }
                else
                {
                    if (inStockCode != dr["StockCode"].ToString())
                    {
                        ws.get_Range(inStockColString[endInStockColPos] + "1", inStockColString[endInStockColPos] + "1").EntireColumn.Copy(Type.Missing);
                        ((Range)(ws.Cells[1, endInStockColPos + startColInStock])).EntireColumn.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                        inStockCode = dr["StockCode"].ToString();
                        colWriteInStock +=1;
                        ws.Cells[rowCaptionPos, startColInStock + endInStockColPos - 1] = inStockCode;
                        endInStockColPos += 1;
                        endOutStockColPos += 1;
                    }
                }
                bool itemCodeNotFound = true;
                for (int j = 6 + 1; j <= row; j++)
                {
                    cellItemCode=((Range)ws.Cells[j, 1]).Text.ToString();
                    if (cellItemCode == dr["ItemCode"].ToString())
                    {
                        if (!endOutStock)
                        {
                            ws.Cells[j, startColOutStock + colWriteOutStock] = dr["Quantity"];
                        }
                        else
                        {
                            ws.Cells[j, startColInStock + colWriteInStock] = dr["Quantity"];
                        }
                        itemCodeNotFound = false;
                        j = row + 1;//break
                    }
                }
                if (itemCodeNotFound)
                {
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    ws.Cells[row, 1] = dr["ItemCode"];
                    ws.Cells[row, 2] = dr["ItemName"];
                    if (!endOutStock)
                    {
                        ws.Cells[row, startColOutStock + colWriteOutStock] = dr["Quantity"];
                    }
                    else
                    {
                        ws.Cells[row, startColInStock + colWriteInStock] = dr["Quantity"];
                    }
                }
            }
           
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range(outStockColString[endOutStockColPos - 1] + "1", outStockColString[endOutStockColPos - 1] + "1").EntireColumn.Delete(true);
            ws.get_Range(outStockColString[endOutStockColPos - 1] + "1", outStockColString[endOutStockColPos - 1] + "1").EntireColumn.Delete(true);
            ws.get_Range(inStockColString[endInStockColPos - 1] + "1", inStockColString[endInStockColPos - 1] + "1").EntireColumn.Delete(true);
            ws.get_Range(inStockColString[endInStockColPos - 1] + "1", inStockColString[endInStockColPos - 1] + "1").EntireColumn.Delete(true);

            ws.Cells[3, 5] = "đến ngày";
            ws.Cells[3, 4] = this.ucDatePeriodSelection1.StartDate;
            ws.Cells[3, 6] = this.ucDatePeriodSelection1.EndDate;
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }
    }
}