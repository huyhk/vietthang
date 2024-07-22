using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data.KCS;
using DevExpress.XtraGrid;
using VNS.ERP.Data;
using Microsoft.Office.Interop.Excel;
using VNS.Windows;
using DevExpress.XtraGrid.Columns;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormReportResultOutside : FormBase
    {
        public bool ByDateSend;
        KCSReportBLL obj = new KCSReportBLL();
        DataSet ds;
        public FormReportResultOutside()
        {
            InitializeComponent();
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);


        }

        void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            this.btnExport.Enabled = false;
            //	throw new Exception("The method or operation is not implemented.");
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
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\BaoCaoKetQuaKiemNgoai.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KCS\\BaoCaoKetQuaKiemNgoai.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }

            System.Data.DataTable dt = GridUtils.GetDataView(this.gridControl1).ToTable();

            //dt.Rows[0][9]=
            if (dlg != null)
            {
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(dt.Rows.Count);
            }
            //TechnicalTest t = (lookUpEditChiTieu.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", lookUpEditChiTieu.EditValue.ToString());
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\BaoCaoKetQuaKiemNgoai.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            //excelApp.Visible = false;
            //bat dau xuat cot nguyen lieu tu cot a
            //int a = 10;

            //System.Data.DataTable dt1 = ds.Tables[1];
            ws.Cells[4, 6] = this.ucDatePeriodSelection1.StartDate;
            ws.Cells[4, 8] = this.ucDatePeriodSelection1.EndDate;


            int k = 11;
            foreach (DataRow row1 in ds.Tables[1].Rows)
            {
                //kẻ khung cho ô[7,k] 
                ((Range)(ws.Cells[7, k])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
                //kẻ khung cho ô[8,k] de copy
                ((Range)(ws.Cells[8, k])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
                ws.Cells[7, k++] = row1["DisplayText"].ToString();
                //ws.get_Range("A" + ((int)(8)).ToString(), "A" + ((int)(8)).ToString()).EntireRow.Copy(Type.Missing);
                //((Range)(ws.Cells[8, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

            }
            ws.get_Range("A" + ((int)(8)).ToString(), "A" + ((int)(8)).ToString()).EntireRow.Copy(Type.Missing);
            ((Range)(ws.Cells[8, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

            int row = 7;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                row += 1;
                if (dlg != null)
                {
                    dlg.IncreProgressBarValue();
                }
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                ws.Cells[row, 1] = dt.Rows[i]["SubjectCode"];
                ws.Cells[row, 2] = dt.Rows[i]["SendDate"];

                ws.Cells[row, 3] = dt.Rows[i]["ItemEncryptCode"];
                ws.Cells[row, 4] = dt.Rows[i]["ItemName"];
                ws.Cells[row, 5] = dt.Rows[i]["Ngaynhap"];
                ws.Cells[row, 6] = dt.Rows[i]["FormulaCode"];
                ws.Cells[row, 7] = dt.Rows[i]["Lot"];
                ws.Cells[row, 8] = dt.Rows[i]["Shift"];
                ws.Cells[row, 9] = dt.Rows[i]["Kho"];
                ws.Cells[row, 10] = dt.Rows[i]["Khachhang"];
                int a = 11;
                //xuất các côt nguyen liệu
                foreach (DataRow row1 in ds.Tables[1].Rows)
                {

                    ws.Cells[row, a++] = dt.Rows[i][row1["TechCode"].ToString()];//lấy dữ liệu của cột có tên filenamelà row1["TechCode"].ToString()
                }

            }






            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.rbSendDate.Checked == true)
                ByDateSend = false;
            if (this.rbReturnDate.Checked == true)
                ByDateSend = true;

            for (int i = this.gridView1.Columns.Count - 1; i >= 10; i--)
            {

                DevExpress.XtraGrid.Columns.GridColumn col1 = this.gridView1.Columns[i];
                this.gridView1.Columns.Remove(col1);
                //DevExpress.XtraGrid.Columns.GridColumn col2 = this.gridView1.Columns[1];
                //this.gridView1.Columns.Remove(col2);
            }


            ds = obj.ReportResultOutside(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, ByDateSend);
            this.gridControl1.DataSource = ds.Tables[0];
            this.btnExport.Enabled = true;
            //this.gridControl1.DataSource = ds.Tables[1];
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                DevExpress.XtraGrid.Columns.GridColumn col = this.gridView1.Columns.Add();
                col.Name = "colResult" + row["TechCode"].ToString();
                col.FieldName = row["TechCode"].ToString();
                col.Caption = row["DisplayText"].ToString();

                if (row["ResultType"].ToString() == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    col.ColumnEdit = this.repPercent;
                }
                else if (row["ResultType"].ToString() == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    col.ColumnEdit = this.repTxtDecimal;
                }
                col.Visible = true;

                StyleFormatCondition cn;
                cn = new StyleFormatCondition(FormatConditionEnum.Equal, col, null, ModuleKCS.CONFIG_NORESULT);
                cn.Appearance.BackColor = Color.Red;
                gridView1.FormatConditions.Add(cn);

            }
            //           gridControlResult.DataSource = ds.Tables[0];
        }

        private void FormReportResultOutside_Load(object sender, EventArgs e)
        {
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
        }




    }
}