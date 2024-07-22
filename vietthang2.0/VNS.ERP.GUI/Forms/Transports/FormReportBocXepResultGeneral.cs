using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Transports;
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraPrinting;
using DevExpress.Utils;

namespace VNS.ERP.GUI.Transports
{
    public partial class FormReportBocXepResultGeneral : VNS.Windows.Forms.FormBase
    {
        private TransportReportBLL bll = new TransportReportBLL();
        public FormReportBocXepResultGeneral()
        {
            InitializeComponent();
            SetDataSource();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetDataSource();
        }

        private void SetDataSource()
        {
            this.pivotGridControl1.DataSource = bll.Report_BocxepResultGeneral(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (this.checkEdit1.Checked.Equals(true))
                ExportToExcel();
            else
            {
                //this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
                //this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
                //this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
                //this.pivotGridControl1.ShowPrintPreview();
                this.printableComponentLink1 = new PrintableComponentLink();
                this.printableComponentLink1.Component = this.pivotGridControl1;
                this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
                this.printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
                this.printableComponentLink1.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(null, new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "",
                "Page [Page # of Pages #]",
                ""}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near));
                this.printableComponentLink1.PrintingSystem = this.printingSystem1;
                this.printableComponentLink1.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.printableComponentLink1_CreateReportHeaderArea);
                this.printableComponentLink1.ShowPreview();
                //this.pivotGridControl1.OptionsView.ShowFilterHeaders = true;
                //this.pivotGridControl1.OptionsView.ShowDataHeaders = true;
                //this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = true;
            }
        }
        /// <summary>
        /// Export PivotData to Excel
        /// </summary>
        private void ExportToExcel()
        {
            string fileName = System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Vanchuyen\\BaocaoTonghopKetquaBocxep.xls";
            #region"Xet cac thuoc tinh cua PivotGrid truoc khi xuat du lieu ra excel"
            //this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            //this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            //this.pivotGridControl1.Appearance.Cell.BackColor = Color.White;
            //this.pivotGridControl1.Appearance.FieldHeader.BackColor = Color.White;
            //this.pivotGridControl1.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            //this.pivotGridControl1.Appearance.FieldValueGrandTotal.BackColor = Color.White;
            //this.pivotGridControl1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            //this.pivotGridControl1.Appearance.TotalCell.BackColor = Color.White;
            #endregion
            this.pivotGridControl1.ExportToXls(fileName, true);
            //dem so cot tren pivotGrid( RowArea, DataArea) tao thanh cot trong excel
            int count = 0;
            foreach (DevExpress.XtraPivotGrid.PivotGridField field in this.pivotGridControl1.Fields)
            {
                if (field.Area == DevExpress.XtraPivotGrid.PivotArea.RowArea)
                {
                    count = count + 1;
                }
                else if (field.Area == DevExpress.XtraPivotGrid.PivotArea.DataArea)
                {
                    count = count + 1;
                }
            }
            //Xu ly lai excel
            #region "Xu ly lai file excel vua xuat du lieu ra"
            Workbook wb = null;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(fileName);
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.get_Range("A1", "A1").EntireColumn.Delete(true);
            ws.get_Range("A1", "A2").EntireRow.Delete(true);
            ws.get_Range(ws.Cells[1, 1], ws.Cells[1, count]).EntireRow.Select();
            //ws.get_Range("A1", "A1").EntireRow.Copy(Type.Missing);
            ws.get_Range("A1", "A1").EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
            for (int i = 1; i <= count; i++)
            {
                ws.Cells[1, i] = string.Empty;
            }
            ws.get_Range(ws.Cells[2, 1], ws.Cells[2, count]).Select();
            ws.get_Range(ws.Cells[2, 1], ws.Cells[2, count]).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
            ws.get_Range(ws.Cells[2, 1], ws.Cells[2, count]).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
            ws.get_Range(ws.Cells[2, 1], ws.Cells[2, count]).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
            ws.get_Range(ws.Cells[1, 1], ws.Cells[1, count]).MergeCells = true;
            ws.get_Range(ws.Cells[2, 1], ws.Cells[2, count]).MergeCells = true;
            ws.get_Range(ws.Cells[3, 1], ws.Cells[3, count]).MergeCells = true;
            //chử nằm giữa của ô (Merge and Center)
            ws.get_Range(ws.Cells[2, 1], ws.Cells[2, count]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.get_Range(ws.Cells[3, 1], ws.Cells[3, count]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //chử canh giữa (FormatCells --> Alignment --> Vertical = Center)
            ws.get_Range("A2", "A2").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            ws.get_Range("A3", "A3").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            ws.get_Range(ws.Cells[1, 1], ws.Cells[1, count]).Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            ws.get_Range(ws.Cells[2, 1], ws.Cells[2, count]).Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            ws.get_Range(ws.Cells[3, 1], ws.Cells[3, count]).Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            ws.Cells[1, 1] = "Công ty cổ phần thủy sản Việt Thắng";
            ws.Cells[2, 1] = "BÁO CÁO KẾT QUẢ BỐC XẾP TỔNG HỢP";
            ws.get_Range("A2", "A2").RowHeight = 22;
            ws.Cells[3, 1] = ucDatePeriodSelection1.PeriodText;
            ws.get_Range("A2", "A2").Font.Bold = true;
            ws.get_Range("A2", "A2").Font.Size = 14;
            File.Delete(fileName);
            //int countRow = this.pivotGridControl1.ListSource.Count + 4;
            //ws.get_Range(ws.Cells[1, 1], ws.Cells[countRow, count]).Interior.Color = System.Drawing.Color.White.ToArgb();

            //ws.get_Range(ws.Cells[1, 1], ws.Cells[countRow, count]).Interior.ColorIndex = -4142;
            #endregion
            #region"tao lai cac thuoc tinh ban dau cu pivotGrid"
            //this.pivotGridControl1.OptionsView.ShowFilterHeaders = true;
            //this.pivotGridControl1.OptionsView.ShowDataHeaders = true;
            //this.pivotGridControl1.Appearance.Cell.BackColor = Color.Empty;
            //this.pivotGridControl1.Appearance.FieldHeader.BackColor = Color.Empty;
            //this.pivotGridControl1.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
            //this.pivotGridControl1.Appearance.FieldValueGrandTotal.BackColor = Color.Empty;
            //this.pivotGridControl1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
            //this.pivotGridControl1.Appearance.TotalCell.BackColor = Color.Empty;
            #endregion
            excelApp.Visible = true;
        }

        private void printableComponentLink1_CreateReportHeaderArea(object sender, DevExpress.XtraPrinting.CreateAreaEventArgs e)
        {
            TextBrick tb = new TextBrick();
            tb.Text = "CÔNG TY CỔ PHẦN THỦY SẢN VIỆT THẮNG";
            tb.Font = new System.Drawing.Font("Arial", 10);
            tb.Rect = new RectangleF(3, 5, 300, 25);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            //tb.HorzAlignment = DevExpress.Utils.HorzAlignment.Near;
            e.Graph.DrawBrick(tb);

            BrickStringFormat bsf = new BrickStringFormat(StringAlignment.Center);

            tb = new TextBrick();
            tb.Text = "Báo cáo kết quả bốc xếp";
            tb.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold);
            tb.Rect = new RectangleF(150, 30, 400, 35);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            tb.StringFormat = bsf;
            //tb.HorzAlignment = DevExpress.Utils.HorzAlignment.Near;
            //tb.Style.TextAlignment = TextAlignment.MiddleCenter;
            e.Graph.DrawBrick(tb);


            tb = new TextBrick();
            tb.Text = this.ucDatePeriodSelection1.PeriodText;
            tb.Font = new System.Drawing.Font("Arial", 10);
            tb.Rect = new RectangleF(150, 65, 400, 25);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            tb.StringFormat = bsf;
            //tb. = DevExpress.Utils.HorzAlignment.Center;
            //tb.Style.TextAlignment = TextAlignment.MiddleCenter;

            e.Graph.DrawBrick(tb);
        }
    }
}

