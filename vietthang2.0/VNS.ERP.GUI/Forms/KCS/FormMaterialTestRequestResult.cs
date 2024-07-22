using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using DevExpress.XtraGrid;
using VNS.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using VNS.Common;
using VNS.Windows;
namespace VNS.ERP.GUI.KCS
{
    public partial class FormMaterialTestRequestResult : VNS.Windows.Forms.FormBase
    {
        public enum RequestType { Material, ProductOutside, ProductLocal}
        RequestType requestType;
        Guid RequestID;
        DataSet ds;
        public FormMaterialTestRequestResult()
        {
            InitializeComponent();
        }
        public FormMaterialTestRequestResult(Guid pRequestID,RequestType pRequestType)
        {
            InitializeComponent();
            this.RequestID = pRequestID;
            this.requestType = pRequestType;
            //this.Text = pCaption;
        }

        private void FormMaterialTestRequestResult_Load(object sender, EventArgs e)
        {
            this.repPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;

            #region bug from DevExpress, add/remove a temp col
            DevExpress.XtraGrid.Columns.GridColumn coltemp = this.gridViewResult.Columns.Add();
            coltemp.Name = "coltemp";
            coltemp.Visible = true;
            this.gridViewResult.Columns.Remove(coltemp);
            #endregion


            switch (requestType)
            {
                case RequestType.Material:
                    this.Text = "Phiếu trả kết quả kiểm nguyên liệu";
                    ds = new KCSReportBLL().ReportMaterialTestRequestResult(this.RequestID);
                    break;
                case RequestType.ProductOutside:
                    this.Text = "Phiếu trả kết quả kiểm thành phẩm";
                    ds = new KCSReportBLL().ReportProductTestRequestResultOutside(this.RequestID);
                    break;
                case RequestType.ProductLocal:
                    this.Text = "Phiếu trả kết quả kiểm thành phẩm nội bộ";
                    ds = new KCSReportBLL().ReportProductTestRequestResultLocal(this.RequestID);
                    this.gridViewResult.Columns.Remove(this.gridViewResult.Columns["SubjectCode"]);
                    break;
            }
            
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                DevExpress.XtraGrid.Columns.GridColumn col = this.gridViewResult.Columns.Add();
                col.Name = "colResult" + row["TechCode"].ToString();
                col.FieldName = row["TechCode"].ToString();
                col.Caption = row["DisplayText"].ToString();
                
                if (row["ResultType"].ToString() == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    col.ColumnEdit = this.repPercent;
                }
                else if (row["ResultType"].ToString() == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    col.ColumnEdit = this.repDecimal;
                }
                col.Visible = true;

                StyleFormatCondition cn;
                cn = new StyleFormatCondition(FormatConditionEnum.Equal, col, null, ModuleKCS.CONFIG_NORESULT);
                cn.Appearance.BackColor = Color.Red;
                gridViewResult.FormatConditions.Add(cn);

            }
            gridControlResult.DataSource = ds.Tables[0];
        }

        private void gridViewResult_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            object o = gridViewResult.GetRow(e.RowHandle);
            if (o == null)
                return;

            if (!e.Column.Name.StartsWith("colResult"))
                return;

            DataRow row = (o as DataRowView).Row;
            if (row[e.Column.FieldName].ToString() == ModuleKCS.CONFIG_NORESULT)
            {
                e.RepositoryItem = this.repNoKQ;
            }
        }
        FormProgressBar dlg = null;
        private void btnExportExel_Click(object sender, EventArgs e)
        {
            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\BaoCaoKetQuaNguyenLieu.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KCS\\BaoCaoKetQuaNguyenLieu.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }
           
            System.Data.DataTable dt = ds.Tables[0];
            if (dlg != null)
            {
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(dt.Rows.Count);
            }
            //TechnicalTest t = (lookUpEditChiTieu.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", lookUpEditChiTieu.EditValue.ToString());
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\BaoCaoKetQuaNguyenLieu.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            excelApp.Visible = false;
            int a=3;
            
            System.Data.DataTable dt1=ds.Tables[1];
           
            ws.Cells[3, 1] = this.Text;
            for(int r=0;r<ds.Tables[1].Rows.Count;r++)
            {
                ((Range)(ws.Cells[7, a])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
                ((Range)(ws.Cells[8, a])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
                
                 ws.Cells[7, a] = dt1.Rows[r]["DisplayText"].ToString();
                       //if (dt1.Rows[r]["ResultType"].ToString() == enumResultTypeTechnicalTest.Percent.ToString())
                       //{
                       //    ((Range)(ws.Cells[8, a])).NumberFormat = "0.0%";

                       //}
                       //if (dt1.Rows[r]["ResultType"].ToString() == enumResultTypeTechnicalTest.Decimal.ToString())
                       //{
                       //    ((Range)(ws.Cells[8, a])).NumberFormat = "#,#0.00";
                       //    //  ws.Cells[7, a] = r["TechName"].ToString();
                       //}
                      

                a++;
            }
            if (requestType == RequestType.ProductLocal)
            {
                ((Range)(ws.Cells[7, 2])).EntireColumn.Delete(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown);
            }
            ws.get_Range("A" + ((int)(8)).ToString(), "A" + ((int)(8)).ToString()).EntireRow.Copy(Type.Missing);
            ((Range)(ws.Cells[8, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
            
            //this.UneCellule.BorderAround(Excel.XlLineStyle.xlContinuous,Excel.XlBorderWeight.xlThin,Excel.XlColorIndex.xlColorIndexAutomatic,1);
          //  ((Range)(ws.Cells[8, a])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
            int row = 7;
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
                ws.Cells[row, 1] = dt.Rows[i]["ItemEncryptCode"];
                if (requestType != RequestType.ProductLocal)
                {
                    ws.Cells[row, 2] = dt.Rows[i]["SubjectCode"];

                }
                //else
                //{
                //    ((Range)(ws.Cells[row, 2])).EntireColumn.Delete(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown);
                //}
                int j;
                if (requestType == RequestType.ProductLocal)
                    j = 1;
                else
                    j = 2;

                while (j < dt.Columns.Count)
                {
                    ws.Cells[row, j + 1] = dt.Rows[i][j];
                    if (dt.Rows[i][j].ToString() == ModuleKCS.CONFIG_NORESULT)
                    {
                        // ((Range)(ws.Cells[8, a])).NuxlDiagonalDownmberFormat = "#,#0.00";

                        ((Range)(ws.Cells[row, j + 1])).Interior.ColorIndex = 3;
                        //ws.Cells[, a] = "****";
                    }
                    j++;
                }
                                               
                //    if (dt.Rows[i][j].ToString() == ModuleKCS.CONFIG_NORESULT)
                //    {
                //        // ((Range)(ws.Cells[8, a])).NuxlDiagonalDownmberFormat = "#,#0.00";

                //        ((Range)(ws.Cells[row, j + 1])).Interior.ColorIndex = 3;
                //        //ws.Cells[, a] = "****";
                //    }
                //}

                             
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

