using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Windows;
using Microsoft.Office.Interop.Excel;
namespace VNS.ERP.GUI.KCS
{
    public partial class FormReportMaterialTestRequestNotReturn : FormBase
    {
        KCSReportBLL kcs = new KCSReportBLL();
        public FormReportMaterialTestRequestNotReturn()
        {
            InitializeComponent();
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);
            //this.ucDatePeriodSelection1.OnEditValueChanged +=new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged); 
            this.btnImportExel.Enabled = false;
        }

        void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            this.btnImportExel.Enabled =false;
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //this.business = kcs;
            this.btnImportExel.Enabled = true;
            DateTime tungay = this.ucDatePeriodSelection1.StartDate;
            DateTime denngay = this.ucDatePeriodSelection1.EndDate;
            System.Data.DataTable dt = kcs.ReportMaterialTestRequestNotReturn(tungay, denngay);
            this.gridControl1.DataSource = dt;
            btnImportExel.Enabled = true;
        }
        FormProgressBar dlg = null;
        private void btnImportExel_Click(object sender, EventArgs e)
        {
         
                dlg = new FormProgressBar();
                if (dlg != null)
                {
                    dlg.Text = this.Text;
                    dlg.Show();
                }
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\Danh_sach_yeu_cau_kiem_nghiem_ko_tra_ra_kq.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KCS\\Danh_sach_yeu_cau_kiem_nghiem_ko_tra_ra_kq.xls"));
                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                    return;
                }
                System.Data.DataTable dt = GridUtils.GetDataTable(gridView1);
                if (dlg != null)
                {
                    dlg.SetProgressText("Kết xuất ra file Excel...");
                    dlg.SetProgressBarMaximum(dt.Rows.Count);
                }
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\Danh_sach_yeu_cau_kiem_nghiem_ko_tra_ra_kq.xls");
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                //ws.Cells[5, 5] = this.ucDatePeriodSelection1.PeriodText;
                    //ws.Cells[7, 1] = "Phiếu kiểm số";
                    //ws.Cells[7, 2] = "Ngày kiểm";
                    //ws.Cells[7, 3] = "Tên Nguyên liệu";
                    //ws.Cells[7, 4] = "Tại kho";
                    //ws.Cells[7, 5] = "Khách hàng";
                    //ws.Cells[7, 6] = "PTVC";
                    //ws.Cells[7, 7] = "Ngày yêu cầu";
                    //ws.Cells[7, 8] = "Mã mẫu";
                    //ws.Cells[7, 9] = "Đơn vị phân tích";
                    //ws.Cells[7, 10] = "Chỉ tiêu";

                ws.Cells[4, 4] = this.ucDatePeriodSelection1.PeriodText.ToString();

                int row = 6;
                int rowCount = dt.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    if (dlg != null)
                    {
                       // dlg.SetProgressText(dt.Rows[i]["ItemCode"].ToString() + "...");
                        dlg.IncreProgressBarValue();
                    }
                    row += 1;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    //TestTransactionDate ItemName StockName CustomerName PTVC DateRequest ItemEncryptCode TTPT TechName
                    ws.Cells[row, 1] = dt.Rows[i]["TestTransactionNo"];
                    ws.Cells[row, 2] = dt.Rows[i]["TestTransactionDate"];
                    ws.Cells[row, 3] = dt.Rows[i]["ItemName"];
                    ws.Cells[row, 4] = dt.Rows[i]["StockName"];
                    ws.Cells[row, 5] = dt.Rows[i]["CustomerName"];
                    ws.Cells[row, 6] = dt.Rows[i]["PTVC"];
                    ws.Cells[row, 7] = dt.Rows[i]["DateRequest"];
                    ws.Cells[row, 8] = dt.Rows[i]["ItemEncryptCode"];
                    ws.Cells[row, 9] = dt.Rows[i]["TTPT"];
                    ws.Cells[row, 10] = dt.Rows[i]["TechName"];
    
                    
                }
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                excelApp.Visible = true;
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
            
        }

        private void ucDatePeriodSelection1_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}