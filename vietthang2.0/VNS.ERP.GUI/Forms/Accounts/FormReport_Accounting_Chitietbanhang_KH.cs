using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;

using VNS.ERP.Data.Accounting;
using VNS.ERP.GUI.Reports.Accounts;
using DevExpress.XtraGrid.Views.Grid;
using VNS.Windows;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormReport_Accounting_Chitietbanhang_KH : FormBase
    {
        DataSet ds;
        public FormReport_Accounting_Chitietbanhang_KH()
        {
            InitializeComponent();
            AccountReportBLL obj = new AccountReportBLL();
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);
            this.btnExport.Enabled = false;
            this.btnExportExcel.Enabled = false;
        }

        void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            this.btnExport.Enabled = false;
            this.btnExportExcel.Enabled = false;
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ds = new AccountReportBLL().Accounting_Report_Chitietbanhang_KH(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            ds.Relations.Add("ChildView", ds.Tables[0].Columns["SubjectCode"], ds.Tables[1].Columns["SubjectCode"]);
            ds.Relations.Add("Item", ds.Tables[0].Columns["SubjectCode"], ds.Tables[2].Columns["SubjectCode"]);
            gridControl1.DataSource = null;
            gridControl1.DataSource = ds.Tables[0];

            gridView1.ExpandAllGroups();
           // ConditionsAdjustment();
            this.btnExport.Enabled = true;
            this.btnExportExcel.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            int i = this.gridView1.FocusedRowHandle;
            this.gridView1.ExpandMasterRow(i);
            DataRow row = this.gridView1.GetDataRow(i);
            GridView gvDetail = (GridView)this.gridView1.GetDetailView(i, 0);
            if (gvDetail != null)
            {
                    object obj = GridUtils.GetDataTable(gvDetail);
                    Report_Account_ChiTietBanHang rp = new Report_Account_ChiTietBanHang();

                    Report_Account_ChiTietBanHang.Params pr;
                    //pr.soLuong = (decimal)row["Soluong"];
                   // pr.EndingAmount = (decimal)row["CloseAmount"];
                    pr.doanhThuThuan = (decimal)row[3];
                    pr.giaVon = (decimal)row[4];
                    pr.laiGop = (decimal)row[5];

                    pr.startDate =this.ucDatePeriodSelection1.StartDate ;
                    pr.endDate = this.ucDatePeriodSelection1.EndDate;
                    pr.ngayMoSo = this.ucDatePeriodSelection1.StartDate;
                    
                    pr.itemName = row["ItemName"].ToString();
                    rp.RpParams = pr;

                    rp.DataSource = obj;
                    rp.BindDataDetail();
                    rp.ShowPreviewDialog();
            }
         //   Report_Account_ChiTietBanHang rp = new Report_Account_ChiTietBanHang(VNS.Windows.GridUtils.GetDataView(gridControl1).ToTable());
            //rp.DataSource =ds.Tables[1];
            //rp.BindDataDetail();
           // rp.ShowPreviewDialog();

        }
        FormProgressBar dlg = null;
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            int i = this.gridView1.FocusedRowHandle;
            this.gridView1.ExpandMasterRow(i);
            System.Data.DataRow row = this.gridView1.GetDataRow(i);
            GridView gvDetail = (GridView)this.gridView1.GetDetailView(i, 0);
            System.Data.DataTable dt = new System.Data.DataTable();
            if (gvDetail != null)
            {
                dt = GridUtils.GetDataTable(gvDetail);
            }

            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
            }

            this.Cursor = Cursors.WaitCursor;
            ExportDetailSaleToExcel(dt,row);
            this.Cursor = Cursors.Default;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }
        private void ExportDetailSaleToExcel(System.Data.DataTable dt, System.Data.DataRow row)
        {

            Workbook wb = null;
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\ChiTietBanHang_KH.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\ChiTietBanHang_KH.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                this.Cursor = Cursors.Default;
                return;
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\ChiTietBanHang_KH.xls");
            Worksheet ws = (Worksheet)wb.Worksheets["ChiTietBanHang"];
            int currentLine = 12;
            ws.Cells[5, 5] = row["SubjectName"].ToString();
            ws.Cells[6, 5] = this.ucDatePeriodSelection1.StartDate;
            ws.Cells[6, 7] = this.ucDatePeriodSelection1.EndDate;
            ws.Cells[13, 11] = (decimal)row[3];
            ws.Cells[14, 11] = (decimal)row[4];
            ws.Cells[15, 11] = (decimal)row[5];
            ws.Cells[18, 2] = "-Ngày mở sổ: " + this.ucDatePeriodSelection1.StartDate.ToString("dd/MM/yyyy");
            if (dlg != null)
            {
                dlg.SetProgressBarMaximum(dt.Rows.Count);
            }
            //int pageCount = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dlg != null)
                {
                    dlg.SetProgressText("Đang in ngày " + Convert.ToDateTime(dt.Rows[i]["NgayGhiso"].ToString()).ToString("dd/MM/yyyy"));
                    dlg.IncreProgressBarValue();
                }
                (ws.Rows[11, Type.Missing] as Range).EntireRow.Copy(Type.Missing);
                (ws.Rows[currentLine, Type.Missing] as Range).EntireRow.Insert(Type.Missing, Type.Missing);
                ws.Cells[currentLine, 1] = dt.Rows[i]["NgayGhiso"];
                ws.Cells[currentLine, 2] = dt.Rows[i]["SoChungtu"].ToString();
                ws.Cells[currentLine, 3] = dt.Rows[i]["NgayChungtu"];
                ws.Cells[currentLine, 4] = dt.Rows[i]["ItemName"];
                ws.Cells[currentLine, 8] = dt.Rows[i]["TKDU"];
                ws.Cells[currentLine, 9] = dt.Rows[i]["Soluong"];
                ws.Cells[currentLine, 10] = dt.Rows[i]["Dongia"];
                ws.Cells[currentLine, 11] = dt.Rows[i]["Thanhtien"];
                //if (pageCount != ws.HPageBreaks.Count && i < dt.Rows.Count)
                //{
                //    pageCount = pageCount + 1;
                //}
                currentLine = currentLine + 1;
            }
            //ws.Cells[currentLine + 5, 2] = "-Sổ này có " + (pageCount+1).ToString() + " trang, đánh số từ 1 đến "+ (pageCount+1).ToString();
            ws.get_Range("A11", "A11").EntireRow.Delete(true);
            (ws.Rows[currentLine-1, Type.Missing] as Range).EntireRow.Delete(true);
            excelApp.Visible = true;

        }

        private void btnTonghopExcel_Click(object sender, EventArgs e)
        {
            Workbook wb = null;
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoTonghopBanhangKhachhangA.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\SoTonghopBanhangKhachhangA.xls"));
                return;
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoTonghopBanhangKhachhangA.xls");
            Worksheet ws = (Worksheet)wb.ActiveSheet;

            ws.Cells[5, 1] = this.ucDatePeriodSelection1.PeriodText;
            int currentLine = 9;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                (ws.Rows[8, Type.Missing] as Range).EntireRow.Copy(Type.Missing);
                (ws.Rows[currentLine, Type.Missing] as Range).EntireRow.Insert(Type.Missing, Type.Missing);

                ws.Cells[currentLine, 1] = row["SubjectCode"];
                ws.Cells[currentLine, 2] = row["SubjectName"];
                ws.Cells[currentLine, 3] = row["Soluong"];
                ws.Cells[currentLine, 4] = row["Thanhtien"];
                ws.Cells[currentLine, 5] = row["Tienvon"];
                ws.Cells[currentLine, 6] = row["Laigop"];

                currentLine++;
            }

            (ws.Rows[currentLine, Type.Missing] as Range).EntireRow.Delete(true);
            (ws.Rows[8, Type.Missing] as Range).EntireRow.Delete(true);
            excelApp.Visible = true;
        }

        private void btnRPKhachhang_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoTonghopBanhangKhachhang.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\SoTonghopBanhangKhachhang.xls"));
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\SoTonghopBanhangKhachhang.xls");


            System.Data.DataSet ds2 = new AccountReportBLL().Accounting_Report_LaigopKhachhang(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            ds2.Relations.Add("ChildView", ds2.Tables[0].Columns["DonviCode"], ds2.Tables[1].Columns["DonviCode"]);

            DataRow row = this.gridView1.GetFocusedDataRow();

            Worksheet ws = (Worksheet)wb.Worksheets[1];

            int lineMau = 8;
            int lineCurrent = 10;
            //foreach (DataRow row in ds2.Tables[0].Rows)
            //{
                lineCurrent++;

                ws.get_Range(ws.Cells[lineMau, 1], ws.Cells[lineMau + 2, 1]).EntireRow.Copy(Type.Missing);
                (ws.Rows[lineCurrent, Type.Missing] as Range).EntireRow.Insert(Type.Missing, Type.Missing);

                ws.Cells[lineCurrent, 1] = row["SubjectCode"];
                ws.Cells[lineCurrent, 2] = row["SubjectName"];
                bool f = false;
                foreach (DataRow rowD in row.GetChildRows("Item"))
                {
                    lineCurrent++;
                    if (!f)
                        f = true;
                    else
                        ((Range)ws.Cells[lineCurrent, 1]).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    ws.Cells[lineCurrent, 1] = rowD["ItemCode"];
                    ws.Cells[lineCurrent, 2] = rowD["ItemName"];
                    ws.Cells[lineCurrent, 3] = rowD["Soluong"];
                    ws.Cells[lineCurrent, 4] = rowD["Thanhtien"];
                    ws.Cells[lineCurrent, 5] = rowD["Tienvon"];
                    ws.Cells[lineCurrent, 6] = rowD["Laigop"];
                }
                (ws.Rows[lineCurrent + 1, Type.Missing] as Range).EntireRow.Delete(true);
            //}
            //((Range)ws.Cells[lineCurrent, 1]).EntireRow.Delete(Type.Missing);
            ws.get_Range(ws.Cells[lineMau, 1], ws.Cells[lineMau + 2, 1]).EntireRow.Delete(Type.Missing);

            ws.Cells[5, 1] = this.ucDatePeriodSelection1.PeriodText;
            this.Cursor = Cursors.Default;

            excelApp.Visible = true;
        }
    }
}