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
using VNS.Windows;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.KCS
{
    public partial class Form_Report_ProductTest_OutSide_Result_For_QLCL : FormBase
    {
        public Form_Report_ProductTest_OutSide_Result_For_QLCL()
        {
            InitializeComponent();
            this.repPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT ;
           // this.r.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
            this.lookUpEditProducts.Properties.DataSource = new ProductBLL().GetAll();
            this.lookUpEditProductSize.Properties.DataSource = new ProductSizeBLL().GetAll();
            this.lookUpEditTech.Properties.DataSource = new TechnicalTestBLL().GetAll();
            ProductSize p = new ProductSize();
            p.SizeCode = string.Empty;
            ListBase<ProductSize> lst = new ProductSizeBLL().GetAll();
            lst.Insert(0,p);
            lookUpEditProductSize.Properties.DataSource = lst;
            lookUpEditProductSize.ItemIndex = 0;
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(ucDatePeriodSelection1_OnEditValueChanged);
            btnExport.Enabled = false;
           
        }

        void ucDatePeriodSelection1_OnEditValueChanged(object sender, EventArgs e)
        {
            this.btnExport.Enabled = false;
        }
        KCSReportBLL kcs = new KCSReportBLL();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool flag;
            if (this.checkEdit1.Checked ==true)
                flag = true;
            else
                flag = false;
            if (lookUpEditProductSize.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("a1", "Chưa chọn kích cỡ "));
                return;
            }
            if (lookUpEditProducts.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("a2", "Chưa chọn sản phẩm"));
                return;
            }
            if (lookUpEditTech.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("a3", "Chưa chọn chỉ tiêu"));
                return;
            }
            string techcode = this.lookUpEditTech.EditValue.ToString();
            TechnicalTest tt = (this.lookUpEditTech.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", techcode);
            if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
            {
                colKetQua.ColumnEdit = repNumber;
            }
            if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
            {
                colKetQua.ColumnEdit = repPercent;
            }
            if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
            {
                colKetQua.ColumnEdit = repText;
            }

            DataSet ds = kcs.ReportProductTestOutSideResultForQLCL(lookUpEditProducts.EditValue.ToString(), this.lookUpEditTech.EditValue.ToString(), this.lookUpEditProductSize.EditValue.ToString(), flag, this.ucDatePeriodSelection1.StartDate, ucDatePeriodSelection1.EndDate);
            this.gridControl1.DataSource = ds.Tables[0];
            this.btnExport.Enabled = true;
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
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\ThongKeKetQuaPhanTichThanhPham_QLCL.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists1", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KCS\\ThongKeKetQuaPhanTichThanhPham_QLCL"));
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
            TechnicalTest t = (this.lookUpEditTech.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", lookUpEditTech.EditValue.ToString());
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KCS\\ThongKeKetQuaPhanTichThanhPham_QLCL");
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            string tennl = this.lookUpEditProducts.EditValue.ToString();
            ws.Cells[7, 2] = tennl;
            tennl = this.lookUpEditTech.GetColumnValue("TechName").ToString();
            ws.Cells[8, 2] = tennl;

            if (this.lookUpEditProductSize.EditValue.ToString()!= string.Empty)
            {
                ws.Cells[7, 3] = "Kích cỡ";
                ws.Cells[7, 4] = this.lookUpEditProductSize.EditValue.ToString();
            }
            ws.Cells[4, 1] = this.ucDatePeriodSelection1.PeriodText.ToString();
            int row = 10;
            int rowCount = dt.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                row += 1;
                if (dlg != null)
                {
                    dlg.IncreProgressBarValue();
                 }
                    
                string techcode = this.lookUpEditTech.EditValue.ToString();
                TechnicalTest tt = (this.lookUpEditTech.Properties.DataSource as ListBase<TechnicalTest>).Search("TechCode", techcode);
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    ((Range)(ws.Cells[row, 5])).NumberFormat = "0.00%";
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    ((Range)(ws.Cells[row, 5])).NumberFormat = "#,#0.00";
                }

                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);

                ws.Cells[row, 1] = dt.Rows[i]["StockName"];
                ws.Cells[row, 2] = dt.Rows[i]["ManuDate"];
                ws.Cells[row, 3] = dt.Rows[i]["Lot"];
                ws.Cells[row, 4] = dt.Rows[i]["TTPT"];
                ws.Cells[row, 5] = dt.Rows[i]["Result"];
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

        private void Form_Report_ProductTest_OutSide_Result_For_QLCL_Load(object sender, EventArgs e)
        {
            lookUpEditProductSize.ItemIndex = 0;
        }
    }
}