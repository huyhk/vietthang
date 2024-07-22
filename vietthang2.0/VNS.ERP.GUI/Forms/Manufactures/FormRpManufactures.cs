using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;
using VNS.Windows.Forms;
using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraPivotGrid;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormRpManufactures : FormBase
    {
        FormProgressBar formProgress;
        private ManufactureBLL manufactureBLL;
        ListBase<Stock> lstStocks;
        private DateTime StartDate=Contexts.WorkingDate;
        private DateTime EndDate=Contexts.WorkingDate;
        DataSet ds;
        public FormRpManufactures()
        {
            InitializeComponent();
            this.cboDenngay.DateTime = Contexts.WorkingDate;
        }

        private void FormRpManufactures_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                manufactureBLL = new ManufactureBLL();
                lstStocks = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
                if (Contexts.CurrentUser.BranchCode == string.Empty)
                {
                    Stock stock = new Stock();
                    stock.StockCode = "";
                    lstStocks.Insert(0, stock);
                }
                this.cboKho.Properties.DataSource = lstStocks;
                this.cboKho.ItemIndex = 0;
                this.btnExportMSExcel.Enabled = false;
                this.btnPrintPreviews.Enabled = false;
            }
           
        }

        void InitCustomTotals()
        {
            pivotGridTotal.TotalsVisibility = PivotTotalsVisibility.CustomTotals;
            pivotGridTotal.CustomTotals.Add(PivotSummaryType.Average);
            pivotGridTotal.CustomTotals.Add(PivotSummaryType.Sum);
            pivotGridTotal.CustomTotals.Add(PivotSummaryType.Max);
            pivotGridTotal.CustomTotals.Add(PivotSummaryType.Min);
          
        }
      
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int day, month, year;
            string stockCode="";
            if (this.cboKho.EditValue != null)
                stockCode = this.cboKho.EditValue.ToString();
            //{
                month = this.cboDenngay.DateTime.Month;
                year = this.cboDenngay.DateTime.Year;
                day = 1;
                StartDate = new DateTime(year, month, day);
                day = DateTime.DaysInMonth(year, month);
                EndDate = new DateTime(year, month, day);
                ds = manufactureBLL.ReportManufactureDS(stockCode, StartDate, EndDate);
                this.pivotGridControl.DataSource = ds.Tables[0];
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.btnExportMSExcel.Enabled = true;
                    this.btnPrintPreviews.Enabled = true;
                }
                else
                {
                    this.btnPrintPreviews.Enabled = false;
                    this.btnExportMSExcel.Enabled = false;
                }
            //}
        }
        private string ShowSaveFileDialog(string title, string filter)
        {
            //SaveFileDialog dlg = new SaveFileDialog();
            //string name = Application.ProductName;
            //int n = name.LastIndexOf(".") + 1;
            //if (n > 0) name = name.Substring(n, name.Length - n);
            //dlg.Title = "Kết xuất ra" + title;
            //dlg.FileName = name;
            //dlg.Filter = filter;
            //if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }
        private void OpenFile(string fileName)
        {
            //if (MessageBox.Show("Bạn có muốn mở file này không ?", "Kết xuất ra...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    try
            //    {
            //        System.Diagnostics.Process process = new System.Diagnostics.Process();
            //        process.StartInfo.FileName = fileName;
            //        process.StartInfo.Verb = "Open";
            //        process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            //        process.Start();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Lỗi export Excel.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        void ExportTo(string title, string filter, string exportFormat)
        {
            if (pivotGridControl == null) return;
            string fileName = ShowSaveFileDialog(title, filter);
            if (fileName != "")
            {
                this.Refresh();
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;

                switch (exportFormat)
                {
                    case "HTML": pivotGridControl.ExportToHtml(fileName);
                        break;
                    case "MHT": pivotGridControl.ExportToMht(fileName);
                        break;
                    case "PDF": pivotGridControl.ExportToPdf(fileName);
                        break;
                    case "XLS": pivotGridControl.ExportToXls(fileName);
                        break;
                    case "RTF": pivotGridControl.ExportToRtf(fileName);
                        break;
                    case "TXT": pivotGridControl.ExportToText(fileName);
                        break;
                }
             
                Cursor.Current = currentCursor;
                OpenFile(fileName);
            }
        }
        private void btnExportMSExcel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
           //ExportTo("Microsoft Excel Document", "Microsoft Excel|*.xls", "XLS");
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Sanxuat\\TonghopSXThang.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Sanxuat\\TonghopSXThang.xls"));
                this.Cursor = Cursors.Default;
                return;
            }
            formProgress = new FormProgressBar();
            if (formProgress != null)
            {
                formProgress.Text = this.Text + " " + this.cboDenngay.Text;
                formProgress.SetProgressText("Chuẩn bị cấu trúc file");
                formProgress.SetProgressBarMaximum(10);
                formProgress.Show(this);
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            //Workbook wb = excelApp.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Sanxuat\\TonghopSXThang.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            Range range;
            int i = 0;
            int j = 0;
            int colLine;
            int colPP;
            //int i = pivotGridControl.Cells.RowCount;
            //Range range = (Range)ws.get_Range("B2","H2");
            //range.EntireRow.RowHeight = 40;
            //range.Merge(Type.Missing);
            
            System.Data.DataTable dtStock = new System.Data.DataTable();
            dtStock.Columns.Add("StockCode", typeof(string));
            dtStock.Columns.Add("ColSum", typeof(int));
            dtStock.Columns.Add("ColPP", typeof(int));

            System.Data.DataTable dtLine = new System.Data.DataTable();
            dtLine.Columns.Add("StockCode", typeof(string));
            dtLine.Columns.Add("LineSxNo", typeof(int));
            dtLine.Columns.Add("ColLine", typeof(int));

            int numberOfLine = 0;
            int numberOfStock = 0;

            int line = -1;
            string stockCode = "";

            if (formProgress != null)
            { formProgress.IncreProgressBarValue(); }

            //thêm column cho Phế phẩm các nhà máy
            foreach (DataRow row in ds.Tables[4].Rows)
            {
                if ((stockCode != row["StockCode"].ToString()))
                {
                    stockCode = row["StockCode"].ToString();
                    numberOfStock++;
                    if (numberOfStock > 1)
                    {
                        ws.get_Range("L1", "Q1").EntireColumn.Copy(Type.Missing);
                        ws.get_Range("R1", "R1").Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                    }
                }
            }
            if (formProgress != null)
            { formProgress.IncreProgressBarValue(); }

            //delete columns tổng Phế phẩm nếu chỉ có 1 nhà máy
            if (numberOfStock == 1)
            {
                ws.get_Range("R1", "S1").EntireColumn.Delete(Type.Missing);
            }

            if (formProgress != null)
            { formProgress.IncreProgressBarValue(); }

            //thêm column cho tổng product nhà máy
            if (numberOfStock > 2)
            {
                for (i = 3; i <= numberOfStock; i++)
                {
                    ws.get_Range("K1", "K1").EntireColumn.Copy(Type.Missing);
                    ws.get_Range("K1", "K1").Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                }
            }
            if (formProgress != null)
            { formProgress.IncreProgressBarValue(); }

            //delete columns tổng product nếu chỉ có 1 nhà máy
            if (numberOfStock == 1)
            {
                ws.get_Range("J1", "K1").EntireColumn.Delete(Type.Missing);
                ws.Cells[5, 9] = stockCode;
            }
            if (formProgress != null)
            { formProgress.IncreProgressBarValue(); }

            //thêm column cho các line
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                if (line != Convert.ToInt32(row["LineSXNo"]))
                {
                    line = Convert.ToInt32(row["LineSXNo"]);
                    numberOfLine++;
                    
                    colLine = (numberOfLine - 1) * 4 + 2;
                    if (numberOfLine > 1)
                    {
                        ws.get_Range("B1", "E1").EntireColumn.Copy(Type.Missing);
                        ((Range)ws.Cells[1, colLine]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                    }
                    ws.Cells[4, colLine] = "Line " + row["LineSXNo"].ToString();
                    System.Data.DataRow rowLine = dtLine.NewRow();
                    rowLine["StockCode"] = row["StockCode"];
                    rowLine["LineSxNo"] = row["LineSxNo"];
                    rowLine["ColLine"] = colLine;
                    dtLine.Rows.Add(rowLine);
                }

            }
            if (formProgress != null)
            { formProgress.IncreProgressBarValue(); }

            //set công thức cho tổng từng ca
            string ctCa = "RC[-4]";
            if (numberOfLine > 1)
            {
                for (i = 2; i <= numberOfLine; i++)
                    ctCa += ",RC[-"+Convert.ToString(i*4)+"]";
            }
            ctCa = "=IF(CONCATENATE(" + ctCa + ")<>\"\",SUM(" + ctCa + "),\"\")";
            for (i=6;i<=36;i++)
                for (j=numberOfLine * 4 + 2;j<=numberOfLine * 4 + 4;j++)
                    ((Range)ws.Cells[i, j]).FormulaR1C1 = ctCa;
            for (j = numberOfLine * 4 + 2; j <= numberOfLine * 4 + 4; j++)
                ((Range)ws.Cells[43, j]).FormulaR1C1 = ctCa;

            if (formProgress != null)
            { formProgress.IncreProgressBarValue(); }

            //lưu column tổng product
            int colSumAll = numberOfLine * 4 + 5;
            int colSumStock;
            int colPPStock;
            int colSumPP;
            string ctSumPP = "";
            if (numberOfStock > 1)
            {
                colSumPP = 6 + numberOfLine * 4 + numberOfStock * 7;
                stockCode = "";
                i = 0;
                //set công thức cho Sum Product từng nhà máy, công thức % Phế phẩm 
                foreach (DataRow row in ds.Tables[4].Rows)
                {
                    if ((stockCode != row["StockCode"].ToString()))
                    {
                        stockCode = row["StockCode"].ToString();
                        i++;
                        colSumStock = colSumAll + i;
                        ws.Cells[5, colSumStock] = stockCode;
                        colPPStock = colSumAll + numberOfStock + (i - 1) * 6 + 1;
                        ws.Cells[4, colPPStock] = "Phế phẩm - " + stockCode;
                        System.Data.DataRow rowStock = dtStock.NewRow();
                        rowStock["StockCode"] = row["StockCode"];
                        rowStock["ColSum"] = colSumStock;
                        rowStock["ColPP"] = colPPStock;
                        dtStock.Rows.Add(rowStock);

                        // lưu công thức cho cột sum phế phẩm
                        if (ctSumPP == "")
                        {
                            ctSumPP = "RC[-" + Convert.ToString(colSumPP - colPPStock - 4) + "]";
                        }
                        else
                        {
                            ctSumPP += ",RC[-" + Convert.ToString(colSumPP - colPPStock - 4) + "]";
                        }
                        //công thức cho cột Sum từng Stock
                        string ctStock = "";
                        foreach (DataRow rowLine in dtLine.Rows)
                        {
                            if (stockCode == rowLine["StockCode"].ToString())
                            {
                                if (ctStock == "")
                                {
                                    ctStock = "RC[-" + Convert.ToString(colSumStock - (int)rowLine["ColLine"] - 3) + "]";
                                }
                                else
                                {
                                    ctStock += ",RC[-" + Convert.ToString(colSumStock - (int)rowLine["ColLine"] - 3) + "]";
                                }
                            }
                            
                        }
                        ctStock = "=IF(CONCATENATE(" + ctStock + ")<>\"\",SUM(" + ctStock + "),\"\")";
                        for (j = 6; j <= 36; j++)
                        {
                            ((Range)ws.Cells[j, colSumStock]).FormulaR1C1 = ctStock;
                        }
                        ((Range)ws.Cells[43, colSumStock]).FormulaR1C1 = ctStock;

                        
                        //công thức cho cột phần trăm phế phẩm/sản lượng
                        string sCol1 = Convert.ToString(colPPStock + 5 - colSumStock);
                        string ctPerPP = "=IF(RC[-" + sCol1 + "]=\"\",\"\",IF(RC[-" + sCol1 + "]=0,0,RC[-1]/RC[-" + sCol1 + "]))";
                        //công thức cho cột tổng phế phẩm
                        string ctSumSLPP = "=IF(RC[-" + Convert.ToString(colPPStock + 4 - colSumStock) + "]=\"\",\"\",SUM(RC[-1]:RC[-4]))";
                        for (j = 6; j <= 36; j++)
                        {
                            ((Range)ws.Cells[j, colPPStock + 5]).FormulaR1C1 = ctPerPP;
                            ((Range)ws.Cells[j, colPPStock + 4]).FormulaR1C1 = ctSumSLPP;
                        }
                        ((Range)ws.Cells[43, colPPStock + 5]).FormulaR1C1 = ctPerPP;
                    }
                }
                //set công thức cho 2 cột sum Phế phẩm
                ctSumPP = "=IF(CONCATENATE(" + ctSumPP + ")<>\"\",SUM(" + ctSumPP + "),\"\")";
                for (j = 6; j <= 36; j++)
                {
                    ((Range)ws.Cells[j, colSumPP]).FormulaR1C1 = ctSumPP;
                    //((Range)ws.Cells[j, colSumPP + 1]).FormulaR1C1 = "=RC[-1]/RC[-" + Convert.ToString(colSumPP + 1 - colSumAll) + "]";
                }
                ((Range)ws.Cells[43, colSumPP]).FormulaR1C1 = ctSumPP;
            }
            else
            {
                System.Data.DataRow rowStock = dtStock.NewRow();
                rowStock["StockCode"] = stockCode;
                rowStock["ColSum"] = colSumAll;
                rowStock["ColPP"] = colSumAll + 1;
                dtStock.Rows.Add(rowStock);

                //công thức cho cột phần trăm phế phẩm/sản lượng
                string ctPerPP = "=IF(RC[-6]=\"\",\"\",IF(RC[-6]=0,0,RC[-1]/RC[-6]))";
                string ctSumSLPP = "=IF(RC[-5]=\"\",\"\",SUM(RC[-1]:RC[-4]))";
                for (j = 6; j <= 36; j++)
                {
                    ((Range)ws.Cells[j, colSumAll + 6]).FormulaR1C1 = ctPerPP;
                    ((Range)ws.Cells[j, colSumAll + 5]).FormulaR1C1 = ctSumSLPP;
                }
                ((Range)ws.Cells[43, colSumAll + 6]).FormulaR1C1 = ctPerPP;
            }
            if (formProgress != null)
            { formProgress.SetProgressBarValue(10); }

          //  excelApp.Visible = true;

            line = -1;
            i = 0;
            j = 2;
            if (formProgress != null)
            {
                formProgress.SetProgressText("Ghi data sản xuất cho từng line");
                formProgress.SetProgressBarMaximum(ds.Tables[1].Rows.Count);
                //formProgress.IncreProgressBarValue();
            }
            //set data sản xuất cho từng line
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                if (formProgress != null)
                { formProgress.IncreProgressBarValue(); }
                if (line != Convert.ToInt32(row["LineSXNo"]))
                {
                    if (line >= 0)
                        j = j + 4;
                    line = Convert.ToInt32(row["LineSXNo"]);
                }
                i = ((DateTime)row["ManufactureDate"]).Day + 5;
                //int j = (Convert.ToInt32(row["LineSXNo"]) - 1) * 4 + Convert.ToInt32(row["Shift"]) + 1;
                ws.Cells[i, j + Convert.ToInt32(row["Shift"]) - 1] = row["ProductWeight"];
            }


            //((Range)ws.Cells[1,colSumAll]).EntireColumn.Select();

            if (formProgress != null)
            {
                formProgress.SetProgressText("Ghi data cho phế phẩm từng nhà máy");
                formProgress.SetProgressBarMaximum(ds.Tables[2].Rows.Count);
                //formProgress.IncreProgressBarValue();
            }
            //set data cho phế phẩm từng stock
            stockCode = "";
            foreach (DataRow row in ds.Tables[2].Rows)
            {
                if (formProgress != null)
                { formProgress.IncreProgressBarValue(); }
                if (stockCode != row["StockCode"].ToString())
                {
                    stockCode = row["StockCode"].ToString();
                    foreach (DataRow rowStock in dtStock.Rows)
                    {
                        if (stockCode == rowStock["StockCode"].ToString())
                        {
                            j = (int)rowStock["ColPP"];
                            ((Range)ws.Cells[1, j+5]).EntireColumn.Select();
                            break;
                        }
                    }
                }
                i = ((DateTime)row["ManufactureDate"]).Day + 5;
                int j2 = j;
                string wasteCode = row["ItemCode"].ToString();
                switch (wasteCode)
                {
                    case "06.PP01":
                        break;
                    case "06.PP02":
                        j2 = j + 1;
                        break;
                    case "06.PP03":
                        j2 = j + 2;
                        break;
                    case "06.PP04":
                        j2 = j + 3;
                        break;
                    default:
                        j2 = 0;
                        break;
                }
                if (j == 0) break;
                if (j2 > 0)
                ws.Cells[i, j2] = row["ProductWeight"];
            }

            if (formProgress != null)
            {
                formProgress.SetProgressText("Ghi data cho phần phân tích cơ cấu");
                formProgress.SetProgressBarMaximum(ds.Tables[3].Rows.Count);
                //formProgress.IncreProgressBarValue();
            }
            //set data cho phần phân tích cơ cấu
            string sizeCode = "";
            i = 43;
            foreach (DataRow row in ds.Tables[3].Rows)
            {
                if (formProgress != null)
                { formProgress.IncreProgressBarValue(); }
                if (sizeCode != row["SizeCode"].ToString())
                {
                    sizeCode = row["SizeCode"].ToString();
                    i = i + 2;
                    ws.get_Range("A43", "A44").EntireRow.Copy(ws.get_Range("A" + i.ToString(), "A" + ((int)(i + 1)).ToString()).EntireRow);
                    ws.get_Range("A" + i.ToString(), "A" + ((int)(i + 1)).ToString()).EntireRow.Select();
                    ws.Cells[i, 1] = row["SizeName"].ToString();

                }
                j = 0;
                if (Convert.ToInt32(row["LineSXNo"]) > 0)
                {
                    foreach (DataRow rowLine in dtLine.Rows)
                    {
                        if (row["LineSXNo"].ToString() == rowLine["LineSXNo"].ToString())
                        {
                            j = Convert.ToInt32(rowLine["ColLine"]) + Convert.ToInt32(row["Shift"]) - 1;
                        }
                    }
                    //j = (Convert.ToInt32(row["LineSXNo"]) - 1) * 4 + Convert.ToInt32(row["Shift"]) + 1;
                }
                else
                {
                    foreach (DataRow rowStock in dtStock.Rows)
                    {
                        if (row["StockCode"].ToString() == rowStock["StockCode"].ToString())
                        {
                            j = Convert.ToInt32(rowStock["ColPP"]);
                        }
                    }

                    string wasteCode = row["ItemCode"].ToString();
                    switch (wasteCode)
                    {
                        case "06.PP01":
                            break;
                        case "06.PP02":
                            j = j + 1;
                            break;
                        case "06.PP03":
                            j = j + 2;
                            break;
                        case "06.PP04":
                            j = j + 3;
                            break;
                        default:
                            j = 0;
                            break;
                    }
                    if (j == 0) break;
                }
                ws.Cells[i, j] = row["ProductWeight"];
                //Range cell = (Range)ws.Cells[1, 1];

                //int j = (Convert.ToInt32(row["LineSXNo"]) - 1) * 4 + Convert.ToInt32(row["Shift"]) + 1;
                //ws.Cells[i, j] = row["ProductWeight"];
            }
            ws.get_Range("A43", "A44").EntireRow.Delete(true);
            ws.Cells[3, 5] = this.cboDenngay.DateTime;
            ws.Cells[3, 3] = "THÁNG";
            ws.Cells[2, 2] = "BÁO CÁO TỔNG HỢP THÁNG";
            ((Range)ws.Cells[2, 2]).Font.Size = 20;
            if (formProgress != null)
                formProgress.Close();
            excelApp.Visible = true;
            this.Cursor = Cursors.Default;
        }

        private void btnPrintPreviews_Click(object sender, EventArgs e)
        {
            if (pivotGridControl == null) return;
            pivotGridControl.ShowPrintPreview();
        }

       
    }
}