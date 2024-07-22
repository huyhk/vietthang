using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data.KCS;
using VNS.Common;
using VNS.Windows;
using VNS.ERP.Data;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors.Repository;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.KCS
{
    public partial class Form_KCS_Report_THPTTP : FormBase
    {
        KCSReportBLL kcs = new KCSReportBLL();
        DataSet ds;
        private bool ptNL;
        public Form_KCS_Report_THPTTP(string text, bool ptNL)
        {
            InitializeComponent();
            this.Text = text;
            this.ptNL = ptNL;
            if (ptNL)
            {
                this.bancolProducCode.Caption = "Nguyên liệu";
                this.lblShift.Visible = false;
                this.txtShift.Visible = false;
            }
            else
            {
                this.bancolProducCode.Caption = "Thành phẩm";
            }
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
           //this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);
            //this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);
            ListBase<Stock> lst = new StockBLL().GetAll();
            Stock s = new Stock();
            s.StockCode = "";
            s.StockName = "";
            lst.Insert(0, s);
            this.lkStockCode.Properties.DataSource = lst;
            lkStockCode.ItemIndex = 0;
            this.btnExportExcel.Enabled = false;

            //do datasourse cho lk
            this.replkTechCode.DataSource = new TechnicalTestBLL().GetAll();
        }
        void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            this.btnExportExcel.Enabled = false;
            //throw new Exception("The method or operation is not implemented.");
        }
        //void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        //{
        //    //throw new Exception("The method or operation is not implemented.");
        //    btnExportExcel.Enabled = false;
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.ptNL)
                ds = kcs.KCS_Report_THPTTP(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, this.lkStockCode.EditValue.ToString(), ptNL);
            else
                ds = kcs.KCS_Report_THPTTP(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, this.lkStockCode.EditValue.ToString(), Convert.ToInt32(this.txtShift.EditValue));
            this.gridControl1.DataSource = ds.Tables[0];
            this.btnExportExcel.Enabled = true;
        }
        private void Form_KCS_Report_THPTTP_Load(object sender, EventArgs e)
        {
            lkStockCode.ItemIndex = 0;
        }
        FormProgressBar dlg = null;
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.Show();
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\BaoCaoTongHopPhanTichThanhPham.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KCS\\BaoCaoTongHopPhanTichThanhPham.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }
            DataSet dsConvert = new DataSet();
            dsConvert.Tables.Add(GridUtils.GetDataTable(bandedGridView1));
            dsConvert.Tables.Add(ds.Tables[1].Copy());
            dsConvert.Tables.Add(ds.Tables[2].Copy());

            DataSet ds_convert = new KCSReportBLL().KCS_Report_THPTTP_Convert(dsConvert, ptNL);
            System.Data.DataTable dt1 = ds_convert.Tables[0];
            System.Data.DataTable dt2 = ds_convert.Tables[1];

            if (dlg != null)
            {
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.SetProgressBarMaximum(dt1.Rows.Count);
            }
            //TechnicalTest t = (lookUpEditChiTieu.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", lookUpEditChiTieu.EditValue.ToString());
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\BaoCaoTongHopPhanTichThanhPham.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            excelApp.Visible = false;
            if (ptNL)
                ws.Cells[4, 3] = "BÁO CÁO TỔNG HỢP PHÂN TÍCH NGUYÊN LIỆU";
            else
            {
                ws.Cells[4, 3] = "BÁO CÁO TỔNG HỢP PHÂN TÍCH THÀNH PHẨM";
                if (Convert.ToInt32(this.txtShift.EditValue) != 0)
                    ws.Cells[7, 6] = "Ca : " + this.txtShift.Text;
            }
             string stockname=this.lkStockCode.GetColumnValue("StockName").ToString();
             if (stockname != "")
             {
                 ws.Cells[6, 6] = "Nhà máy: " + stockname;
             }
             //ws.Cells[5, 6] = this.ucDatePeriodSelection1.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
             //ws.Cells[5,8]=this.ucDatePeriodSelection1.EndDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
             ws.Cells[5, 6] = this.ucDatePeriodSelection1.PeriodText;
             //((Range)(ws.Cells[1, 3])).ColumnWidth = 40;
   
            for (int col = 1; col < dt1.Columns.Count; col++)
            {
                ((Range)(ws.Cells[9, col])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
               
                ws.Cells[9, col] = dt1.Columns[col].Caption.ToString();

            }
            int row = 9;
            //((Range)(ws.Cells[1, 3])).ColumnWidth = 40;
            int col_TTNgoai = dt1.Columns.IndexOf("Des2");
            ((Range)(ws.Cells[1, col_TTNgoai])).ColumnWidth = 20;

            foreach (DataRow row1 in dt2.Rows)
            {

                DataRow[] ldr = dt1.Select("ProductCode='" + row1["ProductCode"].ToString() + "'");

                ws.Cells[++row, 1] = row1["ProductCode"];
                //((Range)(ws.Cells[row, 1])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
                //((Range)(ws.Cells[row, 1])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
                ((Range)(ws.Cells[row, 1])).Font.Bold=true ;
                //((Range)(ws.Columns[1,3])).Select.ColumnWidth = 50;
               //Columns("F:F")ColumnWidth = 100;
                for (int  dr =0;dr<ldr.Length ;dr++)
                {
                    row++;
                  
                    for (int j = 1; j < dt1.Columns.Count; j++)
                    {

                       DataRow r=ldr[dr];
                        
                        ws.Cells[row, j] = r[j];

                        if (dr >= 3)
                        {

                            ((Range)(ws.Cells[row, j])).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, 1);
                            

                        }
                    
                     }
                   

                }


                // }
                //ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                //ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                excelApp.Visible = true;
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;

            }


        }

    
       
    }
}