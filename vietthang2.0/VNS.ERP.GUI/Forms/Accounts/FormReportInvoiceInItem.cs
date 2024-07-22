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
    public partial class FormReportInvoiceInItem : FormBase
    {
        //PeriodBLL bll = new PeriodBLL();
        //Period periodObject = null;
        public FormReportInvoiceInItem()
        {
            InitializeComponent();
            
          //  lookUpEditDate.Properties.DataSource = bll.GetDynamic("IsClosed=0", "StartDate asc");
            this.txtTaxRate.Properties.EditFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.txtTaxRate.Properties.DisplayFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.txtTaxRate.Properties.Mask.EditMask = AppConfigs.CONFIG_PERCENTFORMAT;
            this.repTxtThueSuat.EditFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.repTxtThueSuat.DisplayFormat.FormatString = AppConfigs.CONFIG_PERCENTFORMAT;
            this.repTxtThueSuat.Mask.EditMask = AppConfigs.CONFIG_PERCENTFORMAT;
            colDoanhSo.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colThueGTGT.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
           // colDoanhSo.EditFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colDoanhSo.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colThueGTGT.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            //this.ucSelectBranch1.InitDataSourceBranch();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            if (this.ucSelectBranch1.BranchCode == null)
            {
                MessageBox.Show(this.GetTextMessage("Validate-1", "Chưa chọn chi nhánh!"));
                return;
            }
            if (this.txtTKKemtheo.Text==string.Empty)
                gridControl1.DataSource = new AccountReportBLL().ReportInvoiceInItems(Decimal.Parse(txtTaxRate.EditValue.ToString()), this.ucSelectBranch1.BranchCode, this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            else
                gridControl1.DataSource = new AccountReportBLL().ReportInvoiceInItems2(Decimal.Parse(txtTaxRate.EditValue.ToString()), this.ucSelectBranch1.BranchCode, this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, this.txtTKKemtheo.Text);
            if (Convert.ToDecimal(txtTaxRate.EditValue) == 0)
            {
                colThueSuat.Visible = false;
                colThueGTGT.Visible = false;
            }
            else
            {
                colThueSuat.Visible = true;
                colThueGTGT.Visible = true;
            }
            btnPrintReport.Enabled = true;
            btnExportToExcel.Enabled = true;
        }

       

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtTaxRate.EditValue) != 0)
            {
                RpInvoiceInItems rp = new RpInvoiceInItems();
                rp.DataSource = GridUtils.GetDataTable(gridView1);

                RpInvoiceInItems.Params pr;
                pr.diaChi = this.ucSelectBranch1.DiaChi;
                pr.masoThue = this.ucSelectBranch1.MSThue;
                pr.nameText = this.ucSelectBranch1.TenTruSoKinhDoanh;
                pr.thueSuat = Convert.ToDecimal(txtTaxRate.EditValue) * 100;
                pr.periodText = this.ucDatePeriodSelection1.PeriodText;
                rp.param = pr;
                rp.BindData();
                rp.ShowPreviewDialog();
            }
            else
            {
                RpInvoiceInItems0Percent rp = new RpInvoiceInItems0Percent();
                rp.DataSource = GridUtils.GetDataTable(gridView1);

                RpInvoiceInItems0Percent.Params pr;
                pr.diaChi = this.ucSelectBranch1.DiaChi;
                pr.masoThue = this.ucSelectBranch1.MSThue;
                pr.nameText = this.ucSelectBranch1.TenTruSoKinhDoanh;
                pr.thueSuat = Convert.ToDecimal(txtTaxRate.EditValue) * 100;
                pr.periodText = this.ucDatePeriodSelection1.PeriodText;
                rp.param = pr;
                rp.BindData();
                rp.ShowPreviewDialog();
            }
        }

        private void txtTaxRate_EditValueChanged(object sender, EventArgs e)
        {
            btnPrintReport.Enabled = false;
            btnExportToExcel.Enabled = false;
        }

        private void FormReportInvoiceInItem_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
            }
        }

        private void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            btnPrintReport.Enabled = false;
            btnExportToExcel.Enabled = false;
        }

        private void ucSelectBranch1_OnBranchChanged(object sender, EventArgs e)
        {
            btnPrintReport.Enabled = false;
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
            if (Convert.ToDecimal(txtTaxRate.EditValue) != 0)
            {
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangKeHHMua.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\BangKeHHMua.xls"));
                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                    return;
                }
            }
            else
            {
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangKeHHMuaCoHD.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists2", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\BangKeHHMuaCoHD.xls"));
                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                    return;
                }
            }
        
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = null;
            if (Convert.ToDecimal(txtTaxRate.EditValue) != 0)
            {
                wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangKeHHMua.xls");
            }
            else
            {
                wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangKeHHMuaCoHD.xls");
            }
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            ws.Cells[4, 5] = this.ucDatePeriodSelection1.PeriodText;
            int row = 9;
            int rowCount = dt.Rows.Count;
            if (Convert.ToDecimal(txtTaxRate.EditValue) != 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    if (dlg != null)
                    {
                        dlg.SetProgressText("Ngày: " + ((DateTime)dt.Rows[i]["Ngay"]).ToString(AppConfigs.CONFIG_DATEFORMAT)+"...");
                        dlg.IncreProgressBarValue();
                    }
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    ws.Cells[row, 1] = dt.Rows[i]["KyHieu"];
                    ws.Cells[row, 2] = dt.Rows[i]["SoHD"];
                    ws.Cells[row, 3] = dt.Rows[i]["Ngay"];
                    ws.Cells[row, 4] = dt.Rows[i]["TenNguoiBan"];
                    ws.Cells[row, 5] = dt.Rows[i]["MSThue"];
                    ws.Cells[row, 6] = dt.Rows[i]["MatHang"];
                    ws.Cells[row, 7] = dt.Rows[i]["DoanhSo"];
                    ws.Cells[row, 8] = dt.Rows[i]["ThueSuat"];
                    ws.Cells[row, 9] = dt.Rows[i]["ThueGTGT"];
                    ws.Cells[row, 10] = dt.Rows[i]["GhiChu"];
                }
            }
            else
            {
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
                    ws.Cells[row, 4] = dt.Rows[i]["TenNguoiBan"];
                    ws.Cells[row, 5] = dt.Rows[i]["MSThue"];
                    ws.Cells[row, 6] = dt.Rows[i]["MatHang"];
                    ws.Cells[row, 7] = dt.Rows[i]["DoanhSo"];
                    //ws.Cells[row, 8] = dt.Rows[i]["ThueSuat"];
                    ws.Cells[row, 8] = dt.Rows[i]["GhiChu"];
                }
            }
           
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }
    }
}