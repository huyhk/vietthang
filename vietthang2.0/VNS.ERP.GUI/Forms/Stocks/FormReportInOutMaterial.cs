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
    public partial class FormReportInOutMaterial : FormBase
    {
        /// <summary>
        /// 
        /// </summary>
        private DateTime sDate = DateTime.Today;
        /// <summary>
        /// 
        /// </summary>
        private DateTime eDate = DateTime.Today;
        ListBase<Stock> lstStock = null;
        public FormReportInOutMaterial()
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
            lstReportFor.ValueMember = "EnumID";
            lstReportFor.DisplayMember = "EnumText";
            ListBase<enums> lstEnumItem = EnumDisplays.GetListenumAllItemType();
            //lstEnumItem.Remove(lstEnumItem.Search("EnumID", (byte)enumItemType.Fuel));
            lstEnumItem.Remove(lstEnumItem.Search("EnumID", (byte)enumItemType.Product));
            //lstEnumItem.Remove(lstEnumItem.Search("EnumID", (byte)enumItemType.Waste));
            lstReportFor.DataSource = lstEnumItem;
            this.ucDatePeriodSelection1.WorkingDate = DateTime.Today.AddDays(-1);
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
            string strFilter = "";
            gridView1.ActiveFilter.Clear();
            for (int i = 0; i < lstReportFor.CheckedItems.Count; i++)
            {
                //MessageBox.Show(lstReportFor.CheckedItems[i].ToString());
                if (strFilter != "")
                {
                    strFilter += " or ItemType=" + lstReportFor.CheckedItems[i].ToString();
                }
                else
                {
                    strFilter += "ItemType=" + lstReportFor.CheckedItems[i].ToString();
                }

            }
            if (strFilter != "")
            {
                strFilter = "(" + strFilter + ") and ItemType<>" + ((int)enumItemType.Product).ToString();
            }
            else
            {
                strFilter = "ItemType<>" + ((int)enumItemType.Product).ToString();
            }
            ListBase<enums> lstEnumItem = EnumDisplays.GetListenumAllItemType();
            System.Data.DataTable dt = null;

            if (this.radStock.SelectedIndex == 0)
            {
                dt = new StockTransactionBLL().ReportInOutMaterialSumStock(sDate, eDate, this.chkIncludeTemp.Checked);
            }
            else
            {
                if (stockCode == string.Empty)
                {
                    dt = new StockTransactionBLL().ReportInOutMaterial(sDate, eDate);
                }
                else
                {
                    dt = new StockTransactionBLL().ReportInOutMaterialForStockCode(sDate, eDate, stockCode);
                }
            }
            //DataTable dt = new StockTransactionBLL().ReportInOutMaterial(sDate, eDate);
            dt.Columns.Add("ItemTypeName", typeof(String));
            dt.Columns.Add("ItemTypeOrder", typeof(int));
            foreach (DataRow row in dt.Rows)
            {
                enums enu = lstEnumItem.Search("EnumID", byte.Parse(row["ItemType"].ToString()));
                int i = lstEnumItem.IndexOf(enu);
                row.BeginEdit();
                row["ItemTypeName"] = enu.EnumText;
                row["ItemTypeOrder"] = i;
                row.EndEdit();
            }
            DataView dv = dt.DefaultView;
            if (strFilter != "")
            {
                dv.RowFilter = strFilter;
            }
            gridControl1.DataSource = dv.ToTable();
            btnPrint.Enabled = true;
        }
        FormProgressBar dlg = null;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (checkEditReportToExcel.Checked == false)
            {
                if (this.chkReportPhanloai.Checked)
                {
                    RpInOutMaterial2 rp = new RpInOutMaterial2(VNS.Windows.GridUtils.GetDataView(gridControl1).ToTable(), sDate, eDate);
                    rp.ShowPreviewDialog();
                }
                else
                {
                    RpInOutMaterial rp = new RpInOutMaterial(VNS.Windows.GridUtils.GetDataView(gridControl1).ToTable(), sDate, eDate);
                    //RpStockInOutProduct rp = new RpStockInOutProduct(gridControl1.DataSource, sDate, eDate);
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
                this.Cursor = Cursors.WaitCursor;
                if (chkReportPhanloai.Checked == false)
                {
                    ExportToExcel(GridUtils.GetDataView(this.gridControl1).ToTable());
                }
                else
                {
                    DataView dv = GridUtils.GetDataView(this.gridControl1);
                    dv.Sort = "StockCode,ItemTypeOrder";
                    ExportToExcelType(dv.ToTable());
                }
                this.Cursor = Cursors.Default;
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
            }

        }

        private void dateEditStart_EditValueChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (lstStock.Count > 0)
            {
                lookUpStock.ItemIndex = 0;
            }
        }

        private void ExportToExcel(System.Data.DataTable dtSourced)
        {
            Workbook wb = null;
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\Baocaonhapxuatnguyenlieu.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Kho\\Baocaonhapxuatnguyenlieu.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                this.Cursor = Cursors.Default;
                return;
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\Baocaonhapxuatnguyenlieu.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            int columnCurrent = 1;
            int currentLine = 9;

            ws.Cells[4, 7] = this.sDate;
            ws.Cells[4, 9] = this.eDate;
            if (dlg != null)
                dlg.SetProgressBarMaximum(dtSourced.Rows.Count);

            DataRow row1 = dtSourced.Rows[0];
            string stock = row1["StockName"].ToString();

            ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
            ((Range)ws.Cells[currentLine + 1, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
            currentLine++;

            ws.Cells[currentLine, columnCurrent] = "Kho:" + stock;
            ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;
            int sumLines = 10;
            int sumCols = 3;
            //columnCurrent++;

            //ws.Cells[currentLine, columnCurrent] = stock;
            //((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;
            //((Range)(ws.Cells[currentLine, columnCurrent])).Font.Italic = true;
            //columnCurrent++;
            currentLine++;
            //int sumLines = 0;
            foreach (DataRow row in dtSourced.Rows)
            {
                string tam = row["StockName"].ToString();
                if (dlg != null)
                {
                    dlg.SetProgressText("Kho: " + row["StockName"].ToString() + "...");
                    dlg.IncreProgressBarValue();
                }
                columnCurrent = 1;
                if (tam != stock)
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        ((Range)(ws.Cells[sumLines, sumCols])).FormulaR1C1 = "=SUM(R[1]C:R[" + (currentLine - sumLines - 1) + "]C)";
                        ((Range)(ws.Cells[sumLines, sumCols])).Font.Bold = true;
                        sumCols++;

                    }

                    columnCurrent = 1;
                    ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                    ws.Cells[currentLine, columnCurrent] = "Kho:" + tam;
                    ((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;
                    int tamLine = currentLine;
                    sumLines = tamLine;
                    sumCols = 3;
                    //columnCurrent++;

                    //ws.Cells[currentLine, columnCurrent] = tam;
                    //((Range)(ws.Cells[currentLine, columnCurrent])).Font.Bold = true;
                    //((Range)(ws.Cells[currentLine, columnCurrent])).Font.Italic = true;
                    stock = tam;
                    currentLine++;
                }

                columnCurrent = 1;
                ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
                ((Range)ws.Cells[currentLine, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                ws.Cells[currentLine, columnCurrent] = row["ItemCode"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["ItemName"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["OpenQuantity"];
                ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["NhapMua"];
                ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["NhapNB"];
                ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["NhapSoChe"];
                ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["NhapKhac"];
                ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatSX"];
                ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatNB"];
                ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatSoChe"];
                ((Range)(ws.Cells[currentLine, columnCurrent])).NumberFormat = "#,##0.00";
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatBan"];
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

            for (int i = 1; i <= 12; i++)
            {
                ((Range)(ws.Cells[sumLines, sumCols])).FormulaR1C1 = "=SUM(R[1]C:R[" + (currentLine - sumLines - 1) + "]C)";
                ((Range)(ws.Cells[sumLines, sumCols])).Font.Bold = true;
                sumCols++;
            }

            ws.get_Range("A9", "A9").EntireRow.Delete(true);
            ws.get_Range("A" + currentLine.ToString(), "A" + currentLine.ToString()).EntireRow.Delete(true);
            ws.Cells[currentLine + 2, 1] = "Kế toán kho";
            ws.Cells[currentLine + 2, 5] = "Thủ kho";
            ws.Cells[currentLine + 2, 8] = "Phụ trách bộ phận";
            excelApp.Visible = true;
        }


        private void ExportToExcelType(System.Data.DataTable dtSourced)
        {
            Workbook wb = null;
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\Baocaonhapxuatnguyenlieu2.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Kho\\Baocaonhapxuatnguyenlieu2.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                this.Cursor = Cursors.Default;
                return;
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\Baocaonhapxuatnguyenlieu2.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            int columnCurrent = 1;
            int currentLine = 15;

            ws.Cells[4, 7] = this.sDate;
            ws.Cells[4, 9] = this.eDate;
            if (dlg != null)
                dlg.SetProgressBarMaximum(dtSourced.Rows.Count);

            DataRow row1 = dtSourced.Rows[0];
            string stock = row1["StockName"].ToString();
            string type = row1["ItemTypeName"].ToString();

            ws.get_Range("A9", "A12").EntireRow.Copy(Type.Missing);
            ((Range)ws.Cells[currentLine + 1, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
            currentLine++;
            ws.Cells[currentLine, columnCurrent] = "Kho: " + stock;

            currentLine++;
            ws.Cells[currentLine, 1] = type;
            int count = 0;
            foreach (DataRow row in dtSourced.Rows)
            {
                string tamStock = row["StockName"].ToString();
                string tamType = row["ItemTypeName"].ToString();

                if (dlg != null)
                {
                    dlg.SetProgressText("Kho: " + row["StockName"].ToString() + "...");
                    dlg.IncreProgressBarValue();
                }

                columnCurrent = 1;
                if (tamStock != stock)
                {
                    ws.get_Range("A" + (currentLine + 1).ToString(), "A" + (currentLine + 4).ToString()).EntireRow.Delete(true);
                    ws.get_Range("A9", "A12").EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine + 1, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                    currentLine++;
                    ws.Cells[currentLine, columnCurrent] = "Kho: " + tamStock;
                    stock = tamStock;
                    currentLine++;
                    columnCurrent = 1;
                    ws.Cells[currentLine, 1] = tamType;
                    type = tamType;
                    count = 0;

                }
                else
                {
                    if (tamType != type)
                    {
                        ws.get_Range("A" + (currentLine + 1).ToString(), "A" + (currentLine + 1).ToString()).EntireRow.Delete(true);
                        ws.get_Range("A10", "A12").EntireRow.Copy(Type.Missing);
                        ((Range)ws.Cells[currentLine + 1, columnCurrent]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                        currentLine++;
                        ws.Cells[currentLine, columnCurrent] = tamType;
                        type = tamType;
                        count = 0;
                    }

                    else
                    {
                        if (count > 0)
                        {
                            ws.get_Range("A11", "A11").EntireRow.Copy(Type.Missing);
                            ((Range)ws.Cells[currentLine + 1, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                        }
                    }
                }
                currentLine++;
                ws.Cells[currentLine, columnCurrent] = row["ItemCode"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["ItemName"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["OpenQuantity"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["NhapMua"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["NhapNB"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["NhapSoChe"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["NhapKhac"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatSX"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatNB"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatSoChe"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatBan"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["XuatKhac"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["DeltaStock"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["CloseQuantity"];
                columnCurrent++;
                ws.Cells[currentLine, columnCurrent] = row["CloseManufactureQuantity"];
                count++;
            }
            ws.get_Range("A" + (currentLine + 1).ToString(), "A" + (currentLine + 1).ToString()).EntireRow.Delete(true);
            ws.get_Range("A9", "A15").EntireRow.Delete(true);
            ws.Cells[currentLine - 3, 1] = "Kế toán kho";
            ws.Cells[currentLine - 3, 5] = "Thủ kho";
            ws.Cells[currentLine - 3, 8] = "Phụ trách bộ phận";
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
    }
}