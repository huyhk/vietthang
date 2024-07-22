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
    public partial class FormReportBusinessResult : FormAccountReportBase
    {
        public FormReportBusinessResult()
        {
            InitializeComponent();
            this.MessagePrefix = "FormAccountReportBase-";
            this.LayoutFile = "FormAccountReportBase.xml";
        }
        protected override void RefeshDtReport()
        {
            this.DtReport = new AccountReportBLL().ReportBusinessResult(this.PreStartDate, this.PreEndDate, this.StartDate, this.EndDate);
            base.RefeshDtReport();
        }
        protected override bool SaveData()
        {
            ErrorMessageType messageType = ErrorMessageType.UPDATE;
            int Error = 0;
            if (this.EndDate.Month - this.StartDate.Month == 0)
            {
                bool updateOpenings = false;
                updateOpenings = this.PeriodObj != null && this.PeriodObj.StartDate >= this.StartDate;
                Period p = new PeriodBLL().GetByDate(this.StartDate);
                Error = new AccountReportBLL().UpdateMonthBusinessResult(p.PeriodCode, this.DtReport, "RowCode", "OldAmount", "PreAmount", updateOpenings);
            }
            if (this.EndDate.Month - this.StartDate.Month == 2 && this.PeriodObj != null && this.PeriodObj.StartDate >= this.StartDate)
            {
                Period p = new PeriodBLL().GetByDate(this.StartDate);
                Error = new AccountReportBLL().UpdateQuarterAmountReportBusinessResultOpenings(this.DtReport, "RowCode", "PreAmount");
            }
            if (this.EndDate.Month - this.StartDate.Month == 11 && this.PeriodObj != null && this.PeriodObj.StartDate >= this.StartDate)
            {
                Period p = new PeriodBLL().GetByDate(this.StartDate);
                Error = new AccountReportBLL().UpdateYearAmountReportBusinessResultOpenings(this.DtReport, "RowCode", "PreAmount");
            }
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }

        protected override void PreviewReport()
        {
            ReportBusinessResult rp = new ReportBusinessResult();
            ReportBusinessResult.Params pr = new ReportBusinessResult.Params();
            if (this.EndDate.Month - this.StartDate.Month == 0)
            {
                pr.captionAmount = "Tháng này";
                pr.captionPreAmount = "Tháng trước";
            }
            else if (this.EndDate.Month - this.StartDate.Month == 2)
            {
                pr.captionAmount = "Quý này";
                pr.captionPreAmount = "Quý trước";
            }
            else if (this.EndDate.Month - this.StartDate.Month == 11)
            {
                pr.captionAmount = "Năm nay";
                pr.captionPreAmount = "Năm trước";
            }
            else
            {
                pr.captionAmount = "Kỳ này";
                pr.captionPreAmount = "Kỳ trước";
            }
            pr.periodText = this.PeriodText;
            pr.reportYear = this.StartDate.Year;
            rp.param = pr;
            rp.DataSource = this.DtReport;
            rp.BindData();
            rp.ShowPreviewDialog();
            base.PreviewReport();
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
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\KetQuaKinhDoanh.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\KetQuaKinhDoanh.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            //Workbook wb = excelApp.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\KetQuaKinhDoanh.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            //int i = pivotGridControl.Cells.RowCount;
            //Range range = (Range)ws.get_Range("B2","H2");
            //range.EntireRow.RowHeight = 40;
            //range.Merge(Type.Missing);
            //ws.Cells[4, 1] = "Cho năm tài chính kết thúc ngày 31 tháng 12 năm " + this.StartDate.Year.ToString();
            ModuleAccounting md = new ModuleBLL().GetModuleAccounting();
            ws.Cells[1, 1] = md.TenDonvi;
            ws.Cells[2, 1] = "Địa chỉ: " + md.Diachi;
            //ws.Cells[7, 4] = "Tại ngày " + DateTime.DaysInMonth(this.EndDate.Year, this.EndDate.Month).ToString() + " tháng " + this.EndDate.Month.ToString() + " năm " + this.EndDate.Year.ToString();
            ws.Cells[4, 1] = "Cho năm tài chính kết thúc ngày " + DateTime.DaysInMonth(this.EndDate.Year, this.EndDate.Month).ToString() + " tháng " + this.EndDate.Month.ToString() + " năm " + this.EndDate.Year.ToString();
            ws.Cells[6, 8] = this.PeriodText;
            if (this.EndDate.Month - this.StartDate.Month == 0)
            {
                ws.Cells[9, 9] = "Tháng này";
                ws.Cells[9, 11] = "Tháng trước";
            }
            else if (this.EndDate.Month - this.StartDate.Month == 2)
            {
                ws.Cells[9, 9] = "Quý này";
                ws.Cells[9, 11] = "Quý trước";
            }
            else if (this.EndDate.Month - this.StartDate.Month == 11)
            {
                ws.Cells[9, 9] = "Năm nay";
                ws.Cells[9, 11] = "Năm trước";
            }
            else
            {
                ws.Cells[9, 9] = "Kỳ này";
                ws.Cells[9, 11] = "Kỳ trước";
            }
            int rowCount = this.DtReport.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                if (dlg != null)
                {
                    dlg.IncreProgressBarValue();
                }
                if (Convert.ToDecimal(this.DtReport.Rows[i]["OldAmount"]) == 0)
                {
                    ws.Cells[10 + i, 9] = "-";
                }
                else
                {
                    ws.Cells[10 + i, 9] = this.DtReport.Rows[i]["OldAmount"];
                }
                if (Convert.ToDecimal(this.DtReport.Rows[i]["PreAmount"]) == 0)
                {
                    ws.Cells[10 + i, 11] = "-";
                }
                else
                {
                    ws.Cells[10 + i, 11] = this.DtReport.Rows[i]["PreAmount"];
                }
            }
            excelApp.Visible = true;
            base.ExportToExcel();
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }
    }
}