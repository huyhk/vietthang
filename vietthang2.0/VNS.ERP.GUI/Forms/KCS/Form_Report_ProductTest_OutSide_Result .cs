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
using VNS.Common;
using Microsoft.Office.Interop.Excel;
using VNS.Windows;


namespace VNS.ERP.GUI.KCS
{
    public partial class Form_Report_ProductTest_OutSide_Result : FormBase
    {
        
        public Form_Report_ProductTest_OutSide_Result()
        {
             InitializeComponent();
             this.repNumberic.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;//phan tram
            this.lookUpEditTech.Properties.DataSource = new TechnicalTestBLL().GetAll();
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
                      
            this.lookUpEditProducts.Properties.DataSource = new ProductBLL().GetAll();
            ProductSize t = new ProductSize();
            t.SizeCode = string.Empty;
            ListBase<ProductSize> lst = new ProductSizeBLL().GetAll();
            lst.Insert(0, t);
            this.lookUpEditProductSize.Properties.DataSource = lst;
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);
            
            //TechnicalTest t = (lookUpEditChiTieu.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", lookUpEditChiTieu.EditValue.ToString());
        }

        void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            this.btnExport.Enabled = false ;
            
        }
       
        private void lookUpEditProductSize_EditValueChanged(object sender, EventArgs e)
        {

        }
        KCSReportBLL kcs = new KCSReportBLL();
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(this.lookUpEditTech.EditValue==null)
            {
                MessageBox.Show(this.GetTextMessage("a1","Chưa chọn chỉ tiêu"));
                return;
            }

            if(this.lookUpEditProducts.EditValue==null)
            {
                MessageBox.Show(this.GetTextMessage("a2","Chưa chọn thành phẩm "));
                return;
            }
           
            this.btnExport.Enabled = true;

            DataSet ds = kcs.ReportProductTestOutSideResult(this.lookUpEditProducts.EditValue.ToString(), this.lookUpEditTech.EditValue.ToString(), this.lookUpEditProductSize.EditValue.ToString(), this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            this.gridControl1.DataSource = ds.Tables[0];

            string techCode = lookUpEditTech.EditValue.ToString();

            TechnicalTest tt = (this.lookUpEditTech.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
            if (tt != null)
            {
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    colKetQua.ColumnEdit = repDecimal;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    colKetQua.ColumnEdit = repText;
                    
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    colKetQua.ColumnEdit = repNumberic;
                }
            }
            
        }
        FormProgressBar dlg = null;
        private void btnExport_Click(object sender, EventArgs e)
        {
                        dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\ThongKeKetQuaPhanTichThanhPham.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KCS\\ThongKeKetQuaPhanTichThanhPham.xls"));
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
            TechnicalTest t = (this.lookUpEditTech.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode",lookUpEditTech.EditValue.ToString());
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\ThongKeKetQuaPhanTichThanhPham.xls");
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
            //ws.Cells.FormatConditions.
            string tennl = this.lookUpEditProducts.EditValue.ToString();
            ws.Cells[7, 2] = tennl;
            tennl = this.lookUpEditTech.GetColumnValue("TechName").ToString();
            ws.Cells[8, 2] = tennl;
            if (this.lookUpEditProductSize.EditValue.ToString() != "")
            {
                ws.Cells[7, 3] = "Kích cỡ";
                ws.Cells[7, 4] = this.lookUpEditProductSize.EditValue.ToString();
            }
            ws.Cells[4, 1] = this.ucDatePeriodSelection1.PeriodText.ToString();
            
            int row = 10;
            int rowCount = dt.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                if (dlg != null)
                {

                    dlg.IncreProgressBarValue();
                } 
                row += 1;
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);


                string techCode = lookUpEditTech.EditValue.ToString();

                TechnicalTest tt = (this.lookUpEditTech.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
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
            
                ws.Cells[row, 1] = dt.Rows[i]["TTPT"];
                ws.Cells[row, 2] = dt.Rows[i]["ReturnDate"];
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

        private void Form_Report_ProductTest_OutSide_Result_Load(object sender, EventArgs e)
        {
            lookUpEditProductSize.ItemIndex = 0;
        }
      
      

        
                 
    }
}