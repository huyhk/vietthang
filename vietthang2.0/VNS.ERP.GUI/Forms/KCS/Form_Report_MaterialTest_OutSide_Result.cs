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
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class Form_Report_MaterialTest_OutSide_Result : FormBase
    {
       // ItemBLL item = new ItemBLL();
        public Form_Report_MaterialTest_OutSide_Result()
        {
            InitializeComponent();
            this.repPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            this.lookUpEditChiTieu.Properties.DataSource = new TechnicalTestBLL().GetAll();
            this.lookUpEditNguyenLieu.Properties.DataSource = new ItemBLL().GetbyItemtype((int)enumItemType.Material);
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
            this.btnExportExcel.Enabled = false;
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);

        }

        void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            this.btnExportExcel.Enabled = false ;
            
        }
        KCSReportBLL kcs = new KCSReportBLL();
        //private void btnRefresh_Click(object sender, EventArgs e)
        //{
         
        //    if(this.lookUpEditChiTieu.EditValue==null)
        //    {
        //        MessageBox.Show(this.GetTextMessage("a1","Chưa chọn chỉ tiêu"));
        //        return;
        //    }
        //    if (this.lookUpEditNguyenLieu.EditValue == null)
        //    {
        //        MessageBox.Show(this.GetTextMessage("a2", "Chưa chọn nguyên liêu"));
        //        return;
        //    }
        //    this.btnExportExcel.Enabled = true;
        //    DataSet ds = kcs.ReportMaterialTestOutSideResult(this.lookUpEditNguyenLieu.EditValue.ToString(), lookUpEditChiTieu.EditValue.ToString(), this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
        //    this.gridControl1.DataSource = ds.Tables[0];

        //    //this.gridView1.DataSource =

        //}

        
        
        //private void btnExportExcel_Click(object sender, EventArgs e)
        //{
        //    dlg = new FormProgressBar();
        //    if (dlg != null)
        //    {
        //        dlg.Text = this.Text;
        //        dlg.Show();
        //    }
        //    if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\Bang_Thong_Ke_Ket_Qua_Phan_Tich_Nguyen_Lieu.xls"))
        //    {
        //        MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KCS\\Bang_Thong_Ke_Ket_Qua_Phan_Tich_Nguyen_Lieu.xls"));
        //        if (dlg != null)
        //            dlg.Dispose();
        //        dlg = null;
        //        return;
        //    }
        //    System.Data.DataTable dt = GridUtils.GetDataTable(gridView1);
        //    if (dlg != null)
        //    {
        //        dlg.SetProgressText("Kết xuất ra file Excel...");
        //        dlg.SetProgressBarMaximum(dt.Rows.Count);
        //    }
        //    TechnicalTest t = (lookUpEditChiTieu.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", lookUpEditChiTieu.EditValue.ToString());
        //    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
        //    excelApp.Visible = false;
        //    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
        //    Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\Bang_Thong_Ke_Ket_Qua_Phan_Tich_Nguyen_Lieu.xls");
        //    Worksheet ws = (Worksheet)wb.Worksheets[1];

        //    //ws.Cells[5, 5] = this.ucDatePeriodSelection1.PeriodText;
        //    //ws.Cells[7, 1] = "Phiếu kiểm số";
            
        //    //ws.Cells[7, 4] = "Tại kho";
        //    //ws.Cells[7, 5] = "Khách hàng";
        //    //ws.Cells[7, 6] = "PTVC";
        //    //ws.Cells[7, 7] = "Ngày yêu cầu";
        //    //ws.Cells[7, 8] = "Mã mẫu";
        //    //ws.Cells[7, 9] = "Đơn vị phân tích";
        //    //ws.Cells[7, 10] = "Chỉ tiêu";
        //    string tennl = this.lookUpEditNguyenLieu.GetColumnValue("ItemName").ToString();
        //    ws.Cells[7, 2] = tennl;
        //    tennl = this.lookUpEditChiTieu.GetColumnValue("TechName").ToString();
        //    ws.Cells[8, 2] = tennl;
        //    ws.Cells[4, 4] = this.ucDatePeriodSelection1.PeriodText.ToString();
        //    int row = 10;
        //    int rowCount = dt.Rows.Count;
        //    for (int i = 0; i < rowCount; i++)
        //    {
        //        row += 1;
        //        if (dlg != null)
        //        {
        //              dlg.IncreProgressBarValue();
        //        }
                
        //            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
        //            ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                   
        //        ws.Cells[row, 1] = dt.Rows[i]["TTPT"];
        //        ws.Cells[row, 2] = dt.Rows[i]["DateReturn"];
        //        ws.Cells[row, 3] = dt.Rows[i]["Result"];
                     

        //    }
        //    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
        //    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
        //    excelApp.Visible = true;
        //    if (dlg != null)
        //        dlg.Dispose();
        //    dlg = null;          
        //}

        private void ucDatePeriodSelection1_Load(object sender, EventArgs e)
        {

        }
        FormProgressBar dlg = null;
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.lookUpEditChiTieu.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("a1", "Chưa chọn chỉ tiêu"));
                return;
            }
            if (this.lookUpEditNguyenLieu.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("a2", "Chưa chọn nguyên liêu"));
                return;
            }
            this.btnExportExcel.Enabled = true;
            DataSet ds = kcs.ReportMaterialTestOutSideResult(this.lookUpEditNguyenLieu.EditValue.ToString(), lookUpEditChiTieu.EditValue.ToString(), this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            this.gridControl1.DataSource = ds.Tables[0];
            string techCode = lookUpEditChiTieu.EditValue.ToString();
            TechnicalTest tt = (lookUpEditChiTieu.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
            if (tt != null)
            {
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    colKetQua.ColumnEdit = this.repNumber;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    colKetQua.ColumnEdit = repText;

                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    colKetQua.ColumnEdit = this.repPercent;
                }
            }
           

            //this.gridView1.DataSource =

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\Bang_Thong_Ke_Ket_Qua_Phan_Tich_Nguyen_Lieu.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KCS\\Bang_Thong_Ke_Ket_Qua_Phan_Tich_Nguyen_Lieu.xls"));
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
            TechnicalTest t = (lookUpEditChiTieu.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", lookUpEditChiTieu.EditValue.ToString());
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\Bang_Thong_Ke_Ket_Qua_Phan_Tich_Nguyen_Lieu.xls");
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
            string tennl = this.lookUpEditNguyenLieu.GetColumnValue("ItemName").ToString();
            ws.Cells[7, 2] = tennl;
            tennl = this.lookUpEditChiTieu.GetColumnValue("TechName").ToString();
            ws.Cells[8, 2] = tennl;
            ws.Cells[4, 1] = this.ucDatePeriodSelection1.PeriodText.ToString();
            int row = 10;
            int rowCount = dt.Rows.Count;
            string techCode = this.lookUpEditChiTieu.EditValue.ToString();
            TechnicalTest tt = (this.lookUpEditChiTieu.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
            if (tt != null)
            {
                //CellFormat cell = ;
                //if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                //{
                //    //colKetQua.ColumnEdit = repDecimal;


                //}
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    ((Range)(ws.Cells[row, 3])).NumberFormat = "0.00%";
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    ((Range)(ws.Cells[row, 3])).NumberFormat = "#,#0.00";
                }

            }
            for (int i = 0; i < rowCount; i++)
            {
                row += 1;
                if (dlg != null)
                {
                    dlg.IncreProgressBarValue();
                }

                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                ws.Cells[row, 1] = dt.Rows[i]["TTPT"];
                ws.Cells[row, 2] = dt.Rows[i]["DateReturn"];
                ws.Cells[row, 3] = dt.Rows[i]["Result"];


            }
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;          
      
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Report_MaterialTest_OutSide_Result_Load(object sender, EventArgs e)
        {

        }

       

        }

    }