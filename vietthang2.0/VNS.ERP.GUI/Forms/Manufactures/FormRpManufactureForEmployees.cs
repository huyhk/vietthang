using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Windows;
using System.Collections;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormRpManufactureForEmployees : FormBase
    {
        private System.Data.DataTable dtShiftLeader;
        private System.Data.DataTable dtEmployeeID1;
        private System.Data.DataTable dtEmployeeID2;
        public FormRpManufactureForEmployees()
        {
            InitializeComponent();
            this.cboDenngay.DateTime = Contexts.WorkingDate;
            this.cboTungay.DateTime = Contexts.WorkingDate;
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ManufactureShiftBLL mn = new ManufactureShiftBLL();
            System.Data.DataTable dt = mn.GetReportsForEmployee(cboKho.EditValue.ToString(), cboTungay.DateTime, cboDenngay.DateTime);
            GetDataSouncedGridControll(dt);
            gridControlShiftLeader.DataSource = dtShiftLeader;
            gridControlEmployeeID1.DataSource = dtEmployeeID1;
            gridControlEmployeeID2.DataSource = dtEmployeeID2;
           if(dt.Rows.Count>0)
               btnReports.Enabled = true;
           else
               btnReports.Enabled = false;

           foreach (GridColumn col in this.bandedGridView1.Columns)
           {
               if (col != this.colEmployee)
               {
                   col.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
                   col.SummaryItem.SummaryType = SummaryItemType.Sum;
                   col.SummaryItem.FieldName = col.FieldName;
                   if ((decimal)col.SummaryItem.SummaryValue == 0)
                   {
                       col.SummaryItem.DisplayFormat ="";
                       col.SummaryItem.SummaryType = SummaryItemType.None;
                       col.SummaryItem.FieldName = "";
                   }
               }

           }
           foreach (GridColumn col in this.bandedGridView2.Columns)
           {
               if (col != this.colEmployeeID1)
               {
                   col.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
                   col.SummaryItem.SummaryType = SummaryItemType.Sum;
                   col.SummaryItem.FieldName = col.FieldName;
                   if ((decimal)col.SummaryItem.SummaryValue == 0)
                   {
                       col.SummaryItem.DisplayFormat = "";
                       col.SummaryItem.SummaryType = SummaryItemType.None;
                       col.SummaryItem.FieldName = "";
                   }
               }

           }
           foreach (GridColumn col in this.bandedGridView3.Columns)
           {
               if (col != this.colEmployeeID2)
               {
                   col.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
                   col.SummaryItem.SummaryType = SummaryItemType.Sum;
                   col.SummaryItem.FieldName = col.FieldName;
                   if ((decimal)col.SummaryItem.SummaryValue == 0)
                   {
                       col.SummaryItem.DisplayFormat = "";
                       col.SummaryItem.SummaryType = SummaryItemType.None;
                       col.SummaryItem.FieldName = "";
                   }
               }

           }
            
        }

        private void GetDataSouncedGridControll(System.Data.DataTable dt)
        {
           //dtShiftLeader = new DataTable();
           DataView dv = dt.DefaultView;
           dv.RowFilter = "EmployeeType=1";
           dtShiftLeader = dv.ToTable();

           dv.RowFilter = "EmployeeType=3";
           dtEmployeeID1 = dv.ToTable();

           dv.RowFilter = "EmployeeType=2";
           dtEmployeeID2 = dv.ToTable();
          
        }

        private void FormRpManufactureForEmployees_Load(object sender, EventArgs e)
        {
            this.cboKho.Properties.DataSource = (new StockBLL()).GetAllForMember(Contexts.CurrentUser.MemberID);
            this.cboKho.ItemIndex = 0;
            btnReports.Enabled = false;
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            if (this.chkExcel.Checked)
            {
                this.ReportExcel();
                return;
            }
            ArrayList array = new ArrayList();
            array.Add(this.cboKho.Text);
            array.Add(this.cboTungay.Text);
            array.Add(this.cboDenngay.Text);
            RpManufactureForEmployeeMaster rpt = new RpManufactureForEmployeeMaster(dtShiftLeader, dtEmployeeID1, dtEmployeeID2);
            rpt.BindDataMaster(array);
            rpt.BindDataDetail();
            rpt.ShowPreviewDialog();
        }
        void ReportExcel()
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Sanxuat\\Baocaosanluongsanxuat.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            this.Cursor = Cursors.WaitCursor;
            try
            {
                int currentLine = 20;
                foreach (DataRow row in dtEmployeeID2.Rows)
                {
                    ((Range)ws.Cells[19, 1]).EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                    ws.Cells[currentLine, 1] = row["EmployeeName"];
                    ws.Cells[currentLine, 2] = row["L15"];
                    ws.Cells[currentLine, 3] = row["L22"];
                    ws.Cells[currentLine, 4] = row["L30"];
                    ws.Cells[currentLine, 5] = row["L40"];
                    ws.Cells[currentLine, 6] = row["L50"];
                    ws.Cells[currentLine, 7] = row["L80"];
                    ws.Cells[currentLine, 8] = row["Khac"];
                    ws.Cells[currentLine, 9] = row["TotalSL"];
                    ws.Cells[currentLine, 10] = row["P1"];
                    ws.Cells[currentLine, 11] = row["P2"];
                    ws.Cells[currentLine, 12] = row["P3"];
                    ws.Cells[currentLine, 13] = row["P4"];
                    ws.Cells[currentLine, 14] = row["TotalPP"];

                    currentLine++;
                }

                ((Range)ws.Cells[currentLine, 1]).EntireRow.Delete(true);
                ((Range)ws.Cells[19, 1]).EntireRow.Delete(true);


                currentLine = 15;
                foreach (DataRow row in dtEmployeeID1.Rows)
                {
                    ((Range)ws.Cells[14, 1]).EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                    ws.Cells[currentLine, 1] = row["EmployeeName"];
                    ws.Cells[currentLine, 2] = row["L15"];
                    ws.Cells[currentLine, 3] = row["L22"];
                    ws.Cells[currentLine, 4] = row["L30"];
                    ws.Cells[currentLine, 5] = row["L40"];
                    ws.Cells[currentLine, 6] = row["L50"];
                    ws.Cells[currentLine, 7] = row["L80"];
                    ws.Cells[currentLine, 8] = row["Khac"];
                    ws.Cells[currentLine, 9] = row["TotalSL"];
                    ws.Cells[currentLine, 10] = row["P1"];
                    ws.Cells[currentLine, 11] = row["P2"];
                    ws.Cells[currentLine, 12] = row["P3"];
                    ws.Cells[currentLine, 13] = row["P4"];
                    ws.Cells[currentLine, 14] = row["TotalPP"];

                    currentLine++;
                }

                ((Range)ws.Cells[currentLine, 1]).EntireRow.Delete(true);
                ((Range)ws.Cells[14, 1]).EntireRow.Delete(true);


                currentLine = 10;
                foreach (DataRow row in dtShiftLeader.Rows)
                {
                    ((Range)ws.Cells[9, 1]).EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                    ws.Cells[currentLine, 1] = row["EmployeeName"];
                    ws.Cells[currentLine, 2] = row["L15"];
                    ws.Cells[currentLine, 3] = row["L22"];
                    ws.Cells[currentLine, 4] = row["L30"];
                    ws.Cells[currentLine, 5] = row["L40"];
                    ws.Cells[currentLine, 6] = row["L50"];
                    ws.Cells[currentLine, 7] = row["L80"];
                    ws.Cells[currentLine, 8] = row["Khac"];
                    ws.Cells[currentLine, 9] = row["TotalSL"];
                    ws.Cells[currentLine, 10] = row["P1"];
                    ws.Cells[currentLine, 11] = row["P2"];
                    ws.Cells[currentLine, 12] = row["P3"];
                    ws.Cells[currentLine, 13] = row["P4"];
                    ws.Cells[currentLine, 14] = row["TotalPP"];

                    currentLine++;
                }

                ((Range)ws.Cells[currentLine, 1]).EntireRow.Delete(true);
                ((Range)ws.Cells[9, 1]).EntireRow.Delete(true);

                ws.Cells[5, 2] = this.cboKho.Text;
                ws.Cells[5, 6] = this.cboTungay.DateTime;
                ws.Cells[5, 9] = this.cboDenngay.DateTime;

                excelApp.Visible = true;
            }
            catch
            {
                excelApp.Quit();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            
        }
    }
}