using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Windows;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraGrid;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormReportInvoiceOutItem : FormBase
    {
        public FormReportInvoiceOutItem()
        {
            InitializeComponent();
           
            this.repTxtThueSuat.EditFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.repTxtThueSuat.DisplayFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.repTxtThueSuat.Mask.EditMask = AppConfigs.CONFIG_PERCENTFORMAT;
            colDoanhSo.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colThueGTGT.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
           // colDoanhSo.EditFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colDoanhSo.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colThueGTGT.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
           // this.ucSelectBranch1.InitDataSourceBranch();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            if (this.ucSelectBranch1.BranchCode == null)
            {
                MessageBox.Show(this.GetTextMessage("", "Chưa chọn chi nhánh!"));
                return;
            }

            gridControl1.DataSource = new AccountReportBLL().ReportInvoiceOutItems(this.ucSelectBranch1.BranchCode, this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            btnPrintReport.Enabled = true;
            btnExportToExcel.Enabled = true;
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {

            RpInvoiceOutItems rp = new RpInvoiceOutItems();
            rp.DataSource = GridUtils.GetDataTable(gridView1);

            RpInvoiceOutItems.Params pr;
            pr.diaChi = this.ucSelectBranch1.DiaChi;
            pr.masoThue = this.ucSelectBranch1.MSThue;
            pr.nameText = this.ucSelectBranch1.TenTruSoKinhDoanh;
            pr.periodText = this.ucDatePeriodSelection1.PeriodText;
            rp.param = pr;
            rp.BindData();
            rp.ShowPreviewDialog();

        }

        private void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            btnPrintReport.Enabled = false;
            btnExportToExcel.Enabled = false;
        }

        private void ucSelectBranch1_OnBranchChanged(object sender, EventArgs e)
        {
            btnPrintReport.Enabled = false;
            btnExportToExcel.Enabled = false;
        }
        FormProgressBar dlg = null;
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = GridUtils.GetDataTable(gridView1);
            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(dt.Rows.Count);
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangKeHHBan.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\BangKeHHBan.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }
            
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangKeHHBan.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            ws.Cells[5, 5] = this.ucDatePeriodSelection1.PeriodText;
            int row = 10;
            int rowCount = dt.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                if (dlg != null)
                {
                    dlg.SetProgressText("Ngày: " + ((DateTime)dt.Rows[i]["Ngay"]).ToString(AppConfigs.CONFIG_DATEFORMAT) + "...");
                    dlg.IncreProgressBarValue();
                }
                row += 1;
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                ws.Cells[row, 1] = dt.Rows[i]["KyHieu"];
                ws.Cells[row, 2] = dt.Rows[i]["SoHD"];
                ws.Cells[row, 3] = dt.Rows[i]["Ngay"];
                ws.Cells[row, 4] = dt.Rows[i]["TenNguoiMua"];
                ws.Cells[row, 5] = dt.Rows[i]["MSThue"];
                ws.Cells[row, 6] = dt.Rows[i]["MatHang"];
                ws.Cells[row, 7] = dt.Rows[i]["DoanhSo"];
                ws.Cells[row, 8] = dt.Rows[i]["ThueSuat"];
                ws.Cells[row, 9] = dt.Rows[i]["ThueGTGT"];
                ws.Cells[row, 10] = dt.Rows[i]["GhiChu"];
            }
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }

        private void FormReportInvoiceOutItem_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
                AddCondition();
            }
        }
        void AddCondition()
        {
            StyleFormatCondition cn;
            cn = new StyleFormatCondition(FormatConditionEnum.Greater, gridView1.Columns["SL"], null, 1);
            cn.ApplyToRow = true;
            cn.Appearance.BackColor = Color.Red;
            gridView1.FormatConditions.Add(cn);
        }
    }
}