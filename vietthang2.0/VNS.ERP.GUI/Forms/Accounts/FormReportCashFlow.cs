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
using VNS.Windows;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormReportCashFlow : FormAccountReportBase
    {
        public FormReportCashFlow()
        {
            InitializeComponent();
            this.MessagePrefix = "FormAccountReportBase-";
            this.LayoutFile = "FormAccountReportBase.xml";
        }
        protected override void RefeshDtReport()
        {
            this.DtReport = new AccountReportBLL().ReportCashFlow(this.PreStartDate, this.PreEndDate, this.StartDate, this.EndDate);
            base.RefeshDtReport();
        }
        protected override int ValidateData()
        {
            foreach (DataRow dr in this.DtReport.Rows)
            {
                string rowCode = dr["RowCode"].ToString();
                if (rowCode == string.Empty)
                {
                    decimal oldAmount = Convert.ToDecimal(dr["OldAmount"]);
                    decimal preAmount = Convert.ToDecimal(dr["PreAmount"]);
                    if (oldAmount != 0 || preAmount != 0) return -1;
                }
            }
            return base.ValidateData();
        }
        protected override bool SaveData()
        {
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int ret = ValidateData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return false;
            }
            messageType = ErrorMessageType.UPDATE;
            int Error = 0;
            if (this.EndDate.Month - this.StartDate.Month == 0)
            {
                bool updateOpenings = false;
                updateOpenings = this.PeriodObj != null && this.PeriodObj.StartDate >= this.StartDate;
                Period p = new PeriodBLL().GetByDate(this.StartDate);
                Error = new AccountReportBLL().UpdateMonthCashFlow(p.PeriodCode, this.DtReport, "RowCode", "OldAmount", "PreAmount", updateOpenings);
            }
            if (this.EndDate.Month - this.StartDate.Month == 2 && this.PeriodObj != null && this.PeriodObj.StartDate >= this.StartDate)
            {
                Period p = new PeriodBLL().GetByDate(this.StartDate);
                Error = new AccountReportBLL().UpdateQuarterAmountReportCashFlowOpenings(this.DtReport, "RowCode", "PreAmount");
            }
            if (this.EndDate.Month - this.StartDate.Month == 11 && this.PeriodObj != null && this.PeriodObj.StartDate >= this.StartDate)
            {
                Period p = new PeriodBLL().GetByDate(this.StartDate);
                Error = new AccountReportBLL().UpdateYearAmountReportCashFlowOpenings(this.DtReport, "RowCode", "PreAmount");
            }
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }
         FormProgressBar dlg = null;
        protected override void ExportToExcel()
        {
            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(this.DtReport.Rows.Count);

            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\LuuChuyenTienTe.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\LuuChuyenTienTe.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            //Workbook wb = excelApp.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\LuuChuyenTienTe.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            //int i = pivotGridControl.Cells.RowCount;
            //Range range = (Range)ws.get_Range("B2","H2");
            //range.EntireRow.RowHeight = 40;
            //range.Merge(Type.Missing);
            //ws.Cells[4, 1] = "Cho năm tài chính kết thúc ngày 31 tháng 12 năm " + this.StartDate.Year.ToString();
            ws.Cells[7, 7] = this.PeriodText;
            if (this.EndDate.Month - this.StartDate.Month == 0)
            {
                ws.Cells[10, 9] = "Tháng này";
                ws.Cells[10, 11] = "Tháng trước";
            }
            if (this.EndDate.Month - this.StartDate.Month == 2)
            {
                ws.Cells[10, 9] = "Quý này";
                ws.Cells[10, 11] = "Quý trước";
            }
            if (this.EndDate.Month - this.StartDate.Month == 11)
            {
                ws.Cells[10, 9] = "Năm nay";
                ws.Cells[10, 11] = "Năm trước";
            }
            int rowCount = this.DtReport.Rows.Count;
            int j = 0;
            for (int i = 0; i < rowCount; i++)
            {
                string rowCode = this.DtReport.Rows[j]["RowCode"].ToString();
                if (dlg != null)
                {
                    dlg.SetProgressText(rowCode + "...");
                    dlg.IncreProgressBarValue();
                }
         
                if (rowCode != string.Empty)
                {
                    if (Convert.ToDecimal(this.DtReport.Rows[i]["OldAmount"]) == 0)
                    {
                        ws.Cells[11 + j, 9] = "-";
                    }
                    else
                    {
                        ws.Cells[11 + j, 9] = this.DtReport.Rows[i]["OldAmount"];
                    }
                    if (Convert.ToDecimal(this.DtReport.Rows[i]["PreAmount"]) == 0)
                    {
                        ws.Cells[11 + j, 11] = "-";
                    }
                    else
                    {
                        ws.Cells[11 + j, 11] = this.DtReport.Rows[i]["PreAmount"];
                    }
                }
                j += 1;
            }
            excelApp.Visible = true;
            base.ExportToExcel();
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }
    }
}