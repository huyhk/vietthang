using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormReportBalanceAccount : FormEditBase
    {
        private System.Data.DataTable dtReport = null;
        public System.Data.DataTable DtReport
        {
            get { return dtReport; }
            set { dtReport = value; }
        }
        private DateTime startDate;
        protected DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private DateTime endDate;
        protected DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        private string periodText = string.Empty;
        protected string PeriodText
        {
            get { return periodText; }
            set { periodText = value; }
        }
        private Period periodObj = null;
        protected Period PeriodObj
        {
            get { return periodObj; }
            set { periodObj = value; }
        }
        public FormReportBalanceAccount()
        {
            InitializeComponent();
            this.navigatorFrmEditBase.Visible = false;
            this.btnAdd.Visible = false;
            this.btnSaveNew.Visible = false;
            this.btnSaveClose.Visible = false;
            this.btnRemove.Visible = false;
            btnCancel.Click += new EventHandler(btnCancel_Click);
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;

            this.colOpeningAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.colOldOpeningAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.colClosingAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.colOldClosingAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;

            this.repItemTxtEditAmount.EditFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;
            this.repItemTxtEditAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;

            periodObj = new PeriodBLL().GetMin();
        }
        protected virtual void RefeshDtReport()
        {
            this.DtReport = new AccountReportBLL().ReportBalanceAccount(this.StartDate, this.EndDate);
            gridControl1.DataSource = this.DtReport;
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.RefeshDtReport();
        }
        public override void RefreshButtons(bool buttonOnly)
        {
            this.btnEdit.Enabled = this.EditMode == FormEditMode.VIEW;
            if (this.dtReport == null) btnEdit.Enabled = false;
            this.btnSave.Enabled = this.EditMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.EditMode == FormEditMode.EDIT;
            gridView1.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
            btnReport.Enabled = this.EditMode == FormEditMode.VIEW;
            //button1.Enabled = this.EditMode == FormEditMode.VIEW;
            btnExportToExcel.Enabled = this.EditMode == FormEditMode.VIEW;
            if (this.DtReport == null)
            {
                //button.Enabled = false;
                btnExportToExcel.Enabled = false;
            }
            btnCopy.Enabled = this.EditMode != FormEditMode.VIEW;
            btnCopy1.Enabled = this.EditMode != FormEditMode.VIEW;
            ucDatePeriodSelection1.Enabled = this.EditMode == FormEditMode.VIEW;
            //this.ucDatePeriodSelection1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }
        private void Report_Click()
        {
            this.StartDate = this.ucDatePeriodSelection1.StartDate;
            this.EndDate = this.ucDatePeriodSelection1.EndDate;
            this.periodText = this.ucDatePeriodSelection1.PeriodText;
        
            if (this.EndDate.Month - this.StartDate.Month == 0)//month
            {
                this.colClosingAmount.Caption = "Số cuối tháng (Tính toán)";
                this.colOldClosingAmount.Caption = "Số cuối tháng (Lưu)";
                this.colClosingAmount.Visible = true;
                this.colOldClosingAmount.OptionsColumn.ReadOnly = false;
                if (this.periodObj != null && this.periodObj.StartDate >= this.StartDate)
                {
                    this.colOpeningAmount.Caption = "Số đầu tháng (Tính toán)";
                    this.colOldOpeningAmount.Caption = "Số đầu tháng (Lưu)";
                    this.colOpeningAmount.Visible = true;
                    this.colOldOpeningAmount.OptionsColumn.ReadOnly = false;
                    btnCopy.Visible = true;
                }
                else
                {
                    this.colOldOpeningAmount.Caption = "Số đầu tháng";
                    this.colOpeningAmount.Visible = false;
                    this.colOldOpeningAmount.OptionsColumn.ReadOnly = true;
                    btnCopy.Visible = false;
                }
                
                btnCopy1.Visible = true;
                this.btnEdit.Enabled = true;
            }
            else if (this.EndDate.Month - this.StartDate.Month == 2)//quarter
            {
                this.colClosingAmount.Visible = false;
                this.colOpeningAmount.Visible = false;
                this.colOldClosingAmount.Caption = "Số cuối quý";
                this.colOldOpeningAmount.Caption = "Số đầu quý";
                btnCopy.Visible = false;
                btnCopy1.Visible = false;
                this.btnEdit.Enabled = false;
            }
            else if (this.EndDate.Month - this.StartDate.Month == 11)//year
            {
                this.colClosingAmount.Visible = false;
                this.colOpeningAmount.Visible = false;
                this.colOldClosingAmount.Caption = "Số cuối năm";
                this.colOldOpeningAmount.Caption = "Số đầu năm";
                btnCopy.Visible = false;
                btnCopy1.Visible = false;
                this.btnEdit.Enabled = false;
            }
            else
            {
                this.colClosingAmount.Visible = false;
                this.colOpeningAmount.Visible = false;
                this.colOldClosingAmount.Caption = "Số cuối kỳ";
                this.colOldOpeningAmount.Caption = "Số đầu kỳ";
                btnCopy.Visible = false;
                btnCopy1.Visible = false;
                this.btnEdit.Enabled = false;
            }
            //button1.Enabled = true;
            btnExportToExcel.Enabled = true;
            this.RefeshDtReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Report_Click();
        }
        protected virtual void Copy_Click()
        {
            foreach (DataRow dr in this.DtReport.Rows)
            {
                dr.BeginEdit();
                dr["OldOpeningAmount"] = dr["OpeningAmount"];
                dr.EndEdit();
            }
        }
        protected virtual void Copy1_Click()
        {
            foreach (DataRow dr in this.DtReport.Rows)
            {
                dr.BeginEdit();
                dr["OldClosingAmount"] = dr["ClosingAmount"];
                dr.EndEdit();
            }
        }

        private void btnCopy1_Click(object sender, EventArgs e)
        {
            this.Copy1_Click();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.Copy_Click();
        }
        protected override bool SaveData()
        {
            ErrorMessageType messageType = ErrorMessageType.UPDATE;
            int Error = 0;
            if (this.EndDate.Month - this.StartDate.Month == 0)
            {
                bool updateOldOpeningAmount = false;
                updateOldOpeningAmount = this.PeriodObj != null && this.PeriodObj.StartDate >= this.StartDate;
                Period p = new PeriodBLL().GetByDate(this.StartDate);
                //p1: Next period
                Period p1 = new PeriodBLL().SelectObjectLastMonthSpecify(p.EndDate);
                Error = new AccountReportBLL().UpdateMonthBalanceAccount(p.PeriodCode, p1.PeriodCode, this.DtReport, "RowCode", "OldOpeningAmount", "OldClosingAmount", updateOldOpeningAmount);
            }
           
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }
        FormProgressBar dlg = null;
        protected virtual void ExportToExcel()
        {
            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(this.DtReport.Rows.Count);
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangCanDoi.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\BangCanDoi.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }
            this.Cursor = Cursors.WaitCursor;

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            //Workbook wb = excelApp.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangCanDoi.xls");
            Worksheet ws1 = (Worksheet)wb.Worksheets[1];
            Worksheet ws2 = (Worksheet)wb.Worksheets[2];
            Worksheet ws3 = (Worksheet)wb.Worksheets[3];
            //int i = pivotGridControl.Cells.RowCount;
            //Range range = (Range)ws.get_Range("B2","H2");
            //range.EntireRow.RowHeight = 40;
            //range.Merge(Type.Missing);
            //ws.Cells[4, 1] = "Cho năm tài chính kết thúc ngày 31 tháng 12 năm " + this.StartDate.Year.ToString();
            //ws.Cells[6, 8] = this.PeriodText;
            if (this.EndDate.Month - this.StartDate.Month == 0)
            {
                ws1.Cells[10, 8] = "Số cuối tháng";
                ws1.Cells[10, 10] = "Số đầu tháng";
                ws2.Cells[7, 8] = "Số cuối tháng";
                ws2.Cells[7, 10] = "Số đầu tháng";
                ws3.Cells[7, 8] = "Số cuối tháng";
                ws3.Cells[7, 10] = "Số đầu tháng";
                ws1.Cells[7, 4] = "Tại ngày " + DateTime.DaysInMonth(this.EndDate.Year, this.EndDate.Month).ToString() + " tháng " + this.EndDate.Month.ToString() + " năm " + this.EndDate.Year.ToString();
            }
            else if (this.EndDate.Month - this.StartDate.Month == 2)
            {
                ws1.Cells[10, 8] = "Số cuối quý";
                ws1.Cells[10, 10] = "Số đầu quý";
                ws2.Cells[7, 8] = "Số cuối quý";
                ws2.Cells[7, 10] = "Số đầu quý";
                ws3.Cells[7, 8] = "Số cuối quý";
                ws3.Cells[7, 10] = "Số đầu quý";
                ws1.Cells[7, 4] = "Tại ngày " + DateTime.DaysInMonth(this.EndDate.Year, this.EndDate.Month).ToString() + " tháng " + this.EndDate.Month.ToString() + " năm " + this.EndDate.Year.ToString();
            }
            else if (this.EndDate.Month - this.StartDate.Month == 11)
            {
                ws1.Cells[10, 8] = "Số cuối năm";
                ws1.Cells[10, 10] = "Số đầu năm";
                ws2.Cells[7, 8] = "Số cuối năm";
                ws2.Cells[7, 10] = "Số đầu năm";
                ws3.Cells[7, 8] = "Số cuối năm";
                ws3.Cells[7, 10] = "Số đầu năm";
            }
            else
            {
                ws1.Cells[10, 8] = "Số cuối kỳ";
                ws1.Cells[10, 10] = "Số đầu kỳ";
                ws2.Cells[7, 8] = "Số cuối kỳ";
                ws2.Cells[7, 10] = "Số đầu kỳ";
                ws3.Cells[7, 8] = "Số cuối kỳ";
                ws3.Cells[7, 10] = "Số đầu kỳ";
            }
            ModuleAccounting md = new ModuleBLL().GetModuleAccounting();

            ws1.Cells[1, 1] = ws2.Cells[1, 1] = ws3.Cells[1, 1] = md.TenDonvi;
            ws1.Cells[2, 1] = ws2.Cells[2, 1] = ws3.Cells[2, 1] = "Địa chỉ: " + md.Diachi;
            ws1.Cells[7, 4] = "Tại ngày " + DateTime.DaysInMonth(this.EndDate.Year, this.EndDate.Month).ToString() + " tháng " + this.EndDate.Month.ToString() + " năm " + this.EndDate.Year.ToString();
            ws1.Cells[4, 1] = ws2.Cells[4, 1] = ws3.Cells[4, 1] = "Cho năm tài chính kết thúc ngày " + DateTime.DaysInMonth(this.EndDate.Year, this.EndDate.Month).ToString() + " tháng " + this.EndDate.Month.ToString() + " năm " + this.EndDate.Year.ToString();
            bool cancelws1 = false;
            bool cancelws2 = false;
            int rowCount = this.DtReport.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                string rowCode = this.DtReport.Rows[i]["RowCode"].ToString();
                if (dlg != null)
                {
                    dlg.SetProgressText(rowCode + "...");
                    dlg.IncreProgressBarValue();
                }
               
                int j = 12;
                string cellRowCode = string.Empty;
                
                Worksheet wstmp = ws1;
                if (!cancelws1)
                {
                    j = 12;
                    cellRowCode = ((Range)ws1.Cells[j, 5]).Text.ToString();
                    while (cellRowCode != string.Empty && cellRowCode != rowCode)
                    {
                        j += 1;
                        cellRowCode = ((Range)ws1.Cells[j, 5]).Text.ToString();
                    }
                }
                if (!cancelws2)
                {
                    if (cellRowCode == string.Empty)
                    {
                        j = 9;
                        cellRowCode = ((Range)ws2.Cells[j, 5]).Text.ToString();
                        while (cellRowCode != string.Empty && cellRowCode != rowCode)
                        {
                            j += 1;
                            cellRowCode = ((Range)ws2.Cells[j, 5]).Text.ToString();
                        }
                        cancelws1 = true;
                        wstmp = ws2;
                    }
                }
                if (cellRowCode == string.Empty)
                {
                    j = 9;
                    cellRowCode = ((Range)ws3.Cells[j, 5]).Text.ToString();
                    while (cellRowCode != string.Empty && cellRowCode != rowCode)
                    {
                        j += 1;
                        cellRowCode = ((Range)ws3.Cells[j, 5]).Text.ToString();
                    }
                    cancelws2 = true;
                    wstmp = ws3;
                }
                
                if (Convert.ToDecimal(this.DtReport.Rows[i]["OldClosingAmount"]) == 0)
                {
                    wstmp.Cells[j, 8] = "-";
                }
                else
                {
                    wstmp.Cells[j, 8] = this.DtReport.Rows[i]["OldClosingAmount"];
                }
                if (Convert.ToDecimal(this.DtReport.Rows[i]["OldOpeningAmount"]) == 0)
                {
                    wstmp.Cells[j, 10] = "-";
                }
                else
                {
                    wstmp.Cells[j, 10] = this.DtReport.Rows[i]["OldOpeningAmount"];
                }
            }
            excelApp.Visible = true;
            this.Cursor = Cursors.Default;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            this.ExportToExcel();
        }
    }
}