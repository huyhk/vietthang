using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;
using VNS.Windows;
using System.Collections;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormManufacturePlanDetail : FormEditBase
    {
        private ManufacturePlanBLL manufacturePlanBLL = new ManufacturePlanBLL();
        //private ListBase<ManufacturePlanDetail> lst;
        private string StockCode = "";
        private string StockName = "";
        public FormManufacturePlanDetail()
        {
            InitializeComponent();
            this.Business = manufacturePlanBLL;
        }

        public FormManufacturePlanDetail(string pStockCode)
        {
            InitializeComponent();
            this.Business = manufacturePlanBLL;
            StockCode = pStockCode;
        }
        public FormManufacturePlanDetail(string pStockCode, string stockName)
        {
            InitializeComponent();
            this.Business = manufacturePlanBLL;
            StockCode = pStockCode;
            StockName = stockName;
        }


        public override void AddNewItem()
        {
            this.ucManufacturePlanDetail1.StockCode = StockCode;
            base.AddNewItem();
        }
        public override void EditItem()
        {
            this.ucManufacturePlanDetail1.StockCode = StockCode;
            base.EditItem();
        }


        private void FormManufacturePlanDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode == FormEditMode.ADD)
                CancelNew();
            if (this.EditMode == FormEditMode.EDIT)
                CancelItem();
        }

        private void btnPrintMaterial_Click(object sender, EventArgs e)
        {
            if (this.ckExportExcel.Checked == true)
                PrintMaterial_Excel();
            else
                PrintMaterial_DevExpress();
        }
        private void PrintMaterial_DevExpress()
        {
            ManufacturePlanDetail mp = (this.ucManufacturePlanDetail1.GetDetailSelect());
            if (mp == null)
                return;
            RpManufacturePlanDateMaterial rp = new RpManufacturePlanDateMaterial(mp, manufacturePlanBLL.GetDetailMaterial(mp.ManufacturePlanID, mp.DetailDate), this.ucManufacturePlanDetail1.StockName);
                
                
                rp.ShowPreviewDialog();
        

        }



        FormProgressBar dlg = null;
        private void PrintMaterial_Excel()
        {
            ManufacturePlanDetail mp = (this.ucManufacturePlanDetail1.GetDetailSelect());
            if (mp == null)
                return;

            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Sanxuat\\BaoCaoKeHoachSanXuatNguyenLieu.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Sanxuat\\BaoCaoKeHoachSanXuatNguyenLieu"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }
            
            System.Data.DataTable dt = manufacturePlanBLL.GetDetailMaterial(mp.ManufacturePlanID, mp.DetailDate);
            if (dlg != null)
            {
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(dt.Rows.Count);
            }
            // TechnicalTest t = (this.lookUpEditTech.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", 

            //lookUpEditTech.EditValue.ToString());
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Sanxuat\\BaoCaoKeHoachSanXuatNguyenLieu");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Cells[7, 4] = this.ucManufacturePlanDetail1.StockName;
            ws.Cells[7, 6] = mp.DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            ws.Cells[9, 4] = mp.DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            ws.Cells[9, 5] = mp.DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            ws.Cells[9, 6] = mp.DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            ws.Cells[10, 7] = mp.DetailDate.AddDays(-1).ToString(AppConfigs.CONFIG_DATEFORMAT);
            ws.Cells[10, 8] = mp.DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);

            int row = 10;
            int rowCount = dt.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                row += 1;
                if (dlg != null)
                {
                    dlg.IncreProgressBarValue();
                }


                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                ws.Cells[row, 1] = dt.Rows[i]["MaterialCode"];
                ws.Cells[row, 2] = dt.Rows[i]["ItemName"];
                ws.Cells[row, 3] = dt.Rows[i]["TotalRequest"];
                ws.Cells[row, 4] = dt.Rows[i]["PlanWeightShift1"];
                ws.Cells[row, 5] = dt.Rows[i]["PlanWeightShift2"];
                ws.Cells[row, 6] = dt.Rows[i]["PlanWeightShift3"];
                ws.Cells[row, 7] = dt.Rows[i]["OpenQuantity"];
                ws.Cells[row, 8] = dt.Rows[i]["DeltaQuantity"];

            }
           
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }

        public override void RefreshButtons()
        {
            this.btnPrintMaterial.Enabled = this.EditMode == FormEditMode.VIEW;
            this.btnReports.Enabled = this.EditMode == FormEditMode.VIEW;
            base.RefreshButtons();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (this.ckExportExcel.Checked == false)
                Report_DevExpress();
            else
                Report_Excel();
        }
        private void Report_DevExpress()
        {
            ReportManufacturePlanDetail rpt = new ReportManufacturePlanDetail();
            ReportManufacturePlanDetail.Params pr;
            pr.Date = (this.CurrentItem as ManufacturePlan).PlanDate;
            pr.StockName = StockName;
            pr.dt1 = manufacturePlanBLL.GetReportForSizeCode((this.CurrentItem as ManufacturePlan).PlanNo);
            pr.dt2 = manufacturePlanBLL.GetReportForItemCode((this.CurrentItem as ManufacturePlan).PlanNo);
            pr.PlanNo = (this.CurrentItem as ManufacturePlan).PlanNo;
            pr.Description = (this.CurrentItem as ManufacturePlan).Description;
            rpt.RpParams = pr;
            rpt.BindDataDetail();
            rpt.ShowPreviewDialog();
        }
        private void Report_Excel()
        {
            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Sanxuat\\KeHoachSanXuat.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Sanxuat\\KeHoachSanXuat"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }
            ManufacturePlan mp = this.CurrentItem as ManufacturePlan;
            System.Data.DataTable dt = manufacturePlanBLL.GetReportForSizeCode((this.CurrentItem as ManufacturePlan).PlanNo);
            System.Data.DataTable dtable = manufacturePlanBLL.GetReportForItemCode((this.CurrentItem as ManufacturePlan).PlanNo);

            //sap xep trong datatble
            DataView dv =new DataView();
            dv = dtable.DefaultView;
            dv.Sort="DatePlan,Shift ASC";
            System.Data.DataTable dt1 =new System.Data.DataTable();
            dt1= dv.ToTable(); 

            if (dlg != null)
            {
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(dt.Rows.Count);
            }
            // TechnicalTest t = (this.lookUpEditTech.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", 

            //lookUpEditTech.EditValue.ToString());
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Sanxuat\\KeHoachSanXuat");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
           
            ws.Cells[7,4]=(this.CurrentItem as ManufacturePlan).PlanNo;
            ws.Cells[7,6] = (this.CurrentItem as ManufacturePlan).PlanDate;
            ws.Cells[22, 2] = (this.CurrentItem as ManufacturePlan).Description;
            ws.Cells[7,8] = StockName;
           
            int row = 10;
            int rowCount = dt.Rows.Count;
         
            //ws.get_Range("A10", "A12").EntireRow.Copy(Type.Missing);
            //((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
            //row+=1;
            if (rowCount != 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    row += 1;
                    if (dlg != null)
                    {
                        dlg.IncreProgressBarValue();
                    }

                    if (i != 0)
                        ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                    ws.Cells[row, 2] = "Viên " + dt.Rows[i]["SizeCode"];
                    ws.Cells[row, 6] = dt.Rows[i]["PlanWeight"];
                    ws.Cells[row, 7] = dt.Rows[i]["PlanWrapping"];
                    ws.Cells[row, 8] = dt.Rows[i]["ProductWeight"];
                    ws.Cells[row, 9] = dt.Rows[i]["Wrapping"];
                    //ws.Cells[row, 10] = dt1.Rows[i]["Description"];

                }




                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            }
            else
                row += 2;
            //dong dau tien cua datatable 2
      
            
            //copy ,insert tu dong 13,19("nhom1 tong lon")
            //ws.get_Range("A13", "A19").EntireRow.Copy(Type.Missing);
            //((Range)(ws.Cells[row +1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
          
            // copy nhom 3 dong con vo row+4
          
            int a = row;// vi trí nhóm tổng nhỏ dau tien

            //copy ,insert nhom tong nhỏ dau tien
            ws.get_Range("A" + ((int)(a + 1)).ToString(), "A" + ((int)(a + 3)).ToString()).EntireRow.Copy(Type.Missing);
            row += 3;
            ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

           
            // ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
            //insert vo dong 16


            row++;
            //in dòng 0
            ws.Cells[row, 1] = dt1.Rows[0]["ItemCode"];
            ws.Cells[row, 2] = dt1.Rows[0]["ItemName"];
            ws.Cells[row, 3] = dt1.Rows[0]["FormulaCode"];
            ws.Cells[row, 4] = dt1.Rows[0]["UnitWeight"];
            ws.Cells[row, 6] = dt1.Rows[0]["PlanWeight"];
            ws.Cells[row, 5] = "Line" + dt1.Rows[0]["LinesxNo"];
            ws.Cells[row, 7] = dt1.Rows[0]["PlanWrapping"];
            ws.Cells[row, 8] = dt1.Rows[0]["ProductWeight"];
            ws.Cells[row, 9] = dt1.Rows[0]["Wrapping"];
            ws.Cells[row, 10] = dt1.Rows[0]["Description"];
            
            //ws.Cells[row, 2] = "TOTAL CA " + dt1.Rows[0]["Shift"];
            int j;
            for (j = 1; j < dt1.Rows.Count ; j++)
            {
                //cùng nhóm
                
                if ((dt1.Rows[j]["DatePlan"].ToString() == dt1.Rows[j - 1]["DatePlan"].ToString()) && (dt1.Rows[j]["Shift"].ToString() == dt1.Rows[j - 1]["Shift"].ToString()))
                {
                    //ws.get_Range("A16", "A16").EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row+1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    row++;
                }
                else
                {
                    ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                    row+=1;
                    ws.Cells[row, 1] = dt1.Rows[j-1]["DatePlan"];
                    ws.Cells[row, 2] = "TOTAL CA " + dt1.Rows[j-1]["Shift"];
                
                   // //ws.get_Range("A" + ((int)(row--)).ToString(), "A" + ((int)(row--)).ToString()).EntireRow.Delete(true);
                   // ws.get_Range("A16", "A18").EntireRow.Copy(Type.Missing);
                   // ((Range)(ws.Cells[row, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                    ws.get_Range("A" + ((int)(a + 1)).ToString(), "A" + ((int)(a + 3)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row + 1,1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    row++;
                    
                }
                ws.Cells[row, 1] = dt1.Rows[j]["ItemCode"];
                ws.Cells[row, 2] = dt1.Rows[j]["ItemName"];
                ws.Cells[row, 3] = dt1.Rows[j]["FormulaCode"];
                ws.Cells[row, 4] = dt1.Rows[j]["UnitWeight"];
                ws.Cells[row, 6] = dt1.Rows[j]["PlanWeight"];
                ws.Cells[row, 5] = "Line" + dt1.Rows[j]["LinesxNo"];
                ws.Cells[row, 7] = dt1.Rows[j]["PlanWrapping"];
                ws.Cells[row, 8] = dt1.Rows[j]["ProductWeight"];
                ws.Cells[row, 9] = dt1.Rows[j]["Wrapping"];
                ws.Cells[row, 10] = dt1.Rows[j]["Description"];



              






                
            //    ws.Cells[vt_rowsum, 1] = dt1.Rows[j]["DatePlan"];
            //    ws.Cells[row, 2] = "TOTAL CA " +dt1.Rows[j]["Shift"];
            //    ((Range)(ws.Cells[vt_rowsum, 6])).Font.Bold = true;
            //    ((Range)(ws.Cells[vt_rowsum, 7])).Font.Bold = true;
            //    ((Range)(ws.Cells[vt_rowsum, 8])).Font.Bold = true;
            //    ((Range)(ws.Cells[vt_rowsum, 9])).Font.Bold = true;



            }

            ////   ws.Cells[row, 10] = dt1.Rows[j]["Shift"];
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            row++;
            ws.Cells[row, 1] = dt1.Rows[j-1]["DatePlan"];
            
            ////ws.Cells[row,



            //delete nhóm tông con o vitri cuoi
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 3)).ToString()).EntireRow.Delete(true);

            ws.Cells[row, 2] = "TOTAL CA " + dt1.Rows[j - 1]["Shift"];
            row++;
            ws.Cells[row, 2] = "TOTAL " + StockName;


            //delete nhóm tổng con o vtri đầu
            ws.get_Range("A" + ((int)(a + 1)).ToString(), "A" + ((int)(a + 3)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;


        }

        private void btnMTS_Click(object sender, EventArgs e)
        {
            int i = this.manufacturePlanBLL.UpdateMTS((this.CurrentItem as ManufacturePlan).ManufacturePlanID);
            if (i == 0)
                MessageBox.Show("Cập nhật thành công!");
            else
                MessageBox.Show("Cập nhật không thành công!");
        }
    }  
}