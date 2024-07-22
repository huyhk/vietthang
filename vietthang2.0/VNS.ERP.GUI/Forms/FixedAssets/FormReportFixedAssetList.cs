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
using Microsoft.Office.Interop.Excel;
using VNS.Windows;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormReportFixedAssetList : FormBase
    {
        AccountReportBLL a = new AccountReportBLL();
        public FormReportFixedAssetList()
        {
            InitializeComponent();
            DataSet ds= a.ReportFixedAssetList();
            this.gridControl1.DataSource = ds.Tables[0];
            gridView1.ExpandAllGroups();
        }
        FormProgressBar dlg = null;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\DanhMucTaiSanCoDinh.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\DanhMucTaiSanCoDinh.xls"));
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
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\DanhMucTaiSanCoDinh.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            
            //ws.Cells[5, 5] = this.ucDatePeriodSelection1.PeriodText;
            //ws.Cells[7, 1] = "Phiếu kiểm số";
            
            //ws.Cells[7, 4] = "Tại kho";
            //ws.Cells[7, 5] = "Khách hàng";
            //ws.Cells[7, 6] = "PTVC";
            //ws.Cells[7, 7] = "Ngày yêu cầu";
            //ws.Cells[7, 8] = "Mã mẫu";
            //ws.Cells[7, 9] = "Đơn vị phân tích";
            //ws.Cells[7, 10] = "Chỉ tiêu";
            int row = 11;
            int rowCount = dt.Rows.Count;
            ws.Cells[9, 1] = dt.Rows[0]["SubjectName"];
            ws.Cells[10, 2] = dt.Rows[0]["AccountName"];
            ws.Cells[row, 3] = dt.Rows[0]["FixedAssetCode"];
            ws.Cells[row, 4] = dt.Rows[0]["FixedAssetName"];
            ws.Cells[row, 5] = dt.Rows[0]["StartDate"];
            ws.Cells[row, 6] = dt.Rows[0]["OriginalPrice"];
            ws.Cells[row, 7] = dt.Rows[0]["Description"];
            int i = 1;
            do
            {
            

                                    
                //if (dlg != null)
                //{
                //    dlg.SetProgressText(dt.Rows[i]["ItemCode"].ToString() + "...");
                //    dlg.IncreProgressBarValue();
                //}
                row += 1;
                
                if (dlg != null)
                {
                    dlg.IncreProgressBarValue();
                }
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                if (dt.Rows[i]["SubjectName"].ToString() != dt.Rows[i - 1]["SubjectName"].ToString())
                {
                    ws.Cells[row, 1] = dt.Rows[i]["SubjectName"];
                    row++;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                }

                if (dt.Rows[i]["AccountName"].ToString() != dt.Rows[i - 1]["AccountName"].ToString())
                {
                    ws.Cells[row, 2] = dt.Rows[i]["AccountName"];
                    row++;
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                }
    
                ws.Cells[row, 3] = dt.Rows[i]["FixedAssetCode"];
                ws.Cells[row, 4] = dt.Rows[i]["FixedAssetName"];
                ws.Cells[row, 5] = dt.Rows[i]["StartDate"];
                ws.Cells[row, 6] = dt.Rows[i]["OriginalPrice"];
                ws.Cells[row, 7] = dt.Rows[i]["Description"];
                i++;

            }while(i< rowCount);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;        
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
       }
}