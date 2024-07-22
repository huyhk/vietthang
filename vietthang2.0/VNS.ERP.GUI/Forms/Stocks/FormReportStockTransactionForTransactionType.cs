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
using VNS.Common;

namespace VNS.ERP.GUI.Stocks
{
    public partial class FormReportStockTransactionForTransactionType : FormBase
    {
        public FormReportStockTransactionForTransactionType()
        {
            InitializeComponent();
            this.lookupTransactionTypeCode.Properties.DataSource = new TransactiontypeBLL().GetAll();
            ListBase<Stock> lstStock = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
            if (Contexts.CurrentUser.BranchCode == "")
            {
                Stock st = new Stock();
                st.StockName = "Tất cả";
                lstStock.Insert(0, st);

                Stock st2 = new Stock();
                st2.StockCode = "SD+SD02";
                st2.StockName = "Cụm Sa Đéc";
                lstStock.Insert(1, st2);
            }
            this.lookUpStockCode.Properties.DataSource = lstStock;
            btnExportToExcel.Enabled = false;
            pivotGridFieldQuantity.ValueFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            pivotGridFieldQuantity.TotalValueFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            pivotGridFieldQuantity.TotalCellFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            pivotGridFieldQuantity.GrandTotalCellFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
            pivotGridFieldQuantity.CellFormat.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT;
        }
        private System.Data.DataTable dtReport = null;
        private System.Data.DataTable DtReport
        {
            get { return dtReport; }
            set { dtReport = value; }
        }

        private DateTime startDate;
        private DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private DateTime endDate;
        private DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        private string transactionTypeCode;
        private string TransactionTypeCode
        {
            get { return transactionTypeCode; }
            set { transactionTypeCode = value; }
        }
        private string transactionTypeText;
        private string TransactionTypeText
        {
            get { return transactionTypeText; }
            set { transactionTypeText = value; }
        }
        private string stockCode;
        private string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private string stockName;
        private string StockName
        {
            get { return stockName; }
            set { stockName = value; }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (lookupTransactionTypeCode.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-1", "Chưa chọn loại nhập/xuất!"));
                return;
            }
            if (lookUpStockCode.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("VALIDATE-2", "Chưa chọn kho!"));
                return;
            }

            this.StartDate = this.ucDatePeriodSelection1.StartDate;
            this.EndDate = this.ucDatePeriodSelection1.EndDate;
            if (this.ucDatePeriodSelection1.CheckedGroup == 1)
            {
                this.StartDate = new DateTime(StartDate.Year, (int)this.txtMonth.Value, 1);
                this.EndDate = this.StartDate.AddYears(1).AddDays(-1);
            }
            this.TransactionTypeCode = this.lookupTransactionTypeCode.EditValue.ToString();
            this.StockCode = this.lookUpStockCode.EditValue.ToString();
            this.TransactionTypeText = this.lookupTransactionTypeCode.GetColumnValue("Description").ToString();
            this.StockName = this.lookUpStockCode.GetColumnValue("StockName").ToString();
            this.DtReport = new StockTransactionBLL().ReportForTransactionType(this.StartDate, this.EndDate, this.StockCode, this.TransactionTypeCode);
            pivotGridControl1.DataSource = this.DtReport;
            if (this.ucDatePeriodSelection1.EndDate.Month - this.ucDatePeriodSelection1.StartDate.Month == 0)
            {
                this.pivotGridFieldDateOrMonth.Caption = this.GetTextMessage("DateCaption", "Ngày");
            }
            else
            {
                this.pivotGridFieldDateOrMonth.Caption = this.GetTextMessage("MonthCaption", "Tháng");
            }
            btnExportToExcel.Enabled = true;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            Workbook wb;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            if (this.ucDatePeriodSelection1.EndDate.Month - this.ucDatePeriodSelection1.StartDate.Month == 0)
            {
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\BCCTtheoloaiNXThang.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Kho\\BCCTtheoloaiNXThang.xls"));
                    return;
                }
                wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\BCCTtheoloaiNXThang.xls");
            }
            else
            {
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\BCCTtheoloaiNXNam.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Kho\\BCCTtheoloaiNXNam.xls"));
                    return;
                }
                wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\BCCTtheoloaiNXNam.xls");
            }
            
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            ws.Cells[3, 4] = this.StartDate;
            ws.Cells[3, 6] = this.StockName;
            ws.Cells[4, 4] = this.TransactionTypeText;
            if (this.ucDatePeriodSelection1.CheckedGroup == 1)
            {
                ws.Cells[7, 3] = StartDate.ToString("MM/yyyy");
                ws.Cells[7, 4] = StartDate.AddMonths(1).ToString("MM/yyyy");
                ws.Cells[7, 5] = StartDate.AddMonths(2).ToString("MM/yyyy");
                ws.Cells[7, 6] = StartDate.AddMonths(3).ToString("MM/yyyy");
                ws.Cells[7, 7] = StartDate.AddMonths(4).ToString("MM/yyyy");
                ws.Cells[7, 8] = StartDate.AddMonths(5).ToString("MM/yyyy");
                ws.Cells[7, 9] = StartDate.AddMonths(6).ToString("MM/yyyy");
                ws.Cells[7, 10] = StartDate.AddMonths(7).ToString("MM/yyyy");
                ws.Cells[7, 11] = StartDate.AddMonths(8).ToString("MM/yyyy");
                ws.Cells[7, 12] = StartDate.AddMonths(9).ToString("MM/yyyy");
                ws.Cells[7, 13] = StartDate.AddMonths(10).ToString("MM/yyyy");
                ws.Cells[7, 14] = StartDate.AddMonths(11).ToString("MM/yyyy");
            }

                //System.Data.DataTable dt = VNS.Windows.GridUtils.GetDataView(gridControl1).ToTable();
                int rowCount = this.DtReport.Rows.Count;
            string itemCode = string.Empty;
            int row = 7;

            Int16 dateOrMonth = 0;
            for (int i = 0; i < rowCount; i++)
            {
                if (itemCode != this.DtReport.Rows[i]["ItemCode"].ToString())
                {
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    ws.Cells[row, 1] = this.DtReport.Rows[i]["ItemCode"];
                    ws.Cells[row, 2] = this.DtReport.Rows[i]["ItemName"];
                    itemCode = this.DtReport.Rows[i]["ItemCode"].ToString();
                }
                if (this.ucDatePeriodSelection1.CheckedGroup == 1)
                {
                    dateOrMonth = Convert.ToInt16(this.DtReport.Rows[i]["MonthDiff"]);
                    dateOrMonth += 1;
                }
                else
                    dateOrMonth = Convert.ToInt16(this.DtReport.Rows[i]["DateOrMonth"]);
                dateOrMonth += 2;
                ws.Cells[row, dateOrMonth] = this.DtReport.Rows[i]["Quantity"];
            }
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            //ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
            //ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
        }

        private void FormReportStockTransactionForTransactionType_Load(object sender, EventArgs e)
        {
            this.lookupTransactionTypeCode.ItemIndex = 0;
            this.lookUpStockCode.ItemIndex = 0;
            this.ucDatePeriodSelection1.WorkingDate = DateTime.Today.AddDays(-1);
        }

        private void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            btnExportToExcel.Enabled = false;
        }

        private void lookUpStockCode_EditValueChanged(object sender, EventArgs e)
        {
            btnExportToExcel.Enabled = false;
        }

        private void lookupTransactionTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            btnExportToExcel.Enabled = false;
        }
    }
}