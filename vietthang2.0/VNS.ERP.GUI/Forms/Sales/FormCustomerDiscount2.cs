using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using Microsoft.Office.Interop.Excel;
using VNS.Context;
using VNS.Common;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormCustomerDiscount2 : FormEditBase
    {
        CustomerDiscount2BLL obj = new CustomerDiscount2BLL();
        string sProductType = string.Empty;
        public FormCustomerDiscount2(string productType)
        {
            InitializeComponent();
            repItemLookUpEditDiscountTypeCode.DataSource = new CustomerDiscountTypeBLL().GetAll();
            repLookUpEditProvince.DataSource = new ProvinceBLL().GetAll();
            this.ucCustomerDiscount21.SetDss();
            this.Business = obj;
            sProductType = productType;
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
            this.ucCustomerDiscount21.CustomerCode = (cr.Current as Customer).SubjectCode;
            this.DataSource = obj.GetBySubjectCode((cr.Current as Customer).SubjectCode);
        }

        private void gridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
            this.ucCustomerDiscount21.CustomerCode = (cr.Current as Customer).SubjectCode;
            this.DataSource = obj.GetBySubjectCode((cr.Current as Customer).SubjectCode);
        }
        public override void RefreshButtons()
        {
            gridControl2.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            base.RefreshButtons();
        }

        private void FormCustomerDiscount2_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = new CustomerBLL().GetCustomer(sProductType);
            gridControl2.RefreshDataSource();
            gridControl1.RefreshDataSource();
            this.dateEdit1.DateTime = DateTime.Today;
        }
        protected override bool Save()
        {
            bool ret=false;
            ret= base.Save();
            return ret;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new SaleReportBLL().GetReportsCustomerDiscount(this.dateEdit1.DateTime);
            ExportExcelDinhMucChietKhau(ds, this.dateEdit1.DateTime);
        }
        private void ExportExcelDinhMucChietKhau(System.Data.DataSet ds, DateTime t)
        {
            Workbook wb = null;

            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Banhang\\DinhMucChietKhau.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Banhang\\DinhMucChietKhau.xls"));
                this.Cursor = Cursors.Default;
                return;
            }
            FormProgressBar dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.SetProgressText("Kết xuất dữ liệu ra file Excel...");
                dlg.Show();
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Banhang\\DinhMucChietKhau.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            //do du lieu
            ws.Cells[5, 4] = t.Date;
            int currentLine = 9;
            System.Data.DataRelation dr = ds.Relations.Add("relProvinceCode", ds.Tables[0].Columns["ProvinceCode"], ds.Tables[1].Columns["ProvinceCode"]);
            int len = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (((DataRow[])row.GetChildRows("relProvinceCode")).Length > 0)
                    len = len + 1 + ((DataRow[])row.GetChildRows("relProvinceCode")).Length;
            }
            if (dlg != null)
                dlg.SetProgressBarMaximum(len);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (((DataRow[])row.GetChildRows("relProvinceCode")).Length > 0)
                {
                    ws.get_Range("A8", "A8").EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine + 1, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                    ws.Cells[currentLine+1, 1] = row["ProvinceName"];
                    currentLine++;
                    if (dlg != null)
                        dlg.IncreProgressBarValue();
                    foreach (DataRow childRow in row.GetChildRows("relProvinceCode"))
                    {
                        ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
                        ((Range)ws.Cells[currentLine + 1, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                        ws.Cells[currentLine + 1, 2] = childRow["CustomerCode"];
                        ws.Cells[currentLine + 1, 3] = childRow["SubjectName"];
                        if(Convert.ToDecimal( childRow["CKINVOICE"].ToString()) != 0) ws.Cells[currentLine + 1, 4] = childRow["CKINVOICE"];
                        if (Convert.ToDecimal(childRow["CKQUARTER"].ToString()) != 0) ws.Cells[currentLine + 1, 5] = childRow["CKQUARTER"];
                        if (Convert.ToDecimal(childRow["CKYEAR"].ToString()) != 0) ws.Cells[currentLine + 1, 6] = childRow["CKYEAR"];
                        if (Convert.ToDecimal(childRow["CKSANLUONG"].ToString()) != 0) ws.Cells[currentLine + 1, 7] = childRow["CKSANLUONG"];
                        if (Convert.ToDecimal(childRow["CKDOCQUYEN"].ToString()) != 0) ws.Cells[currentLine + 1, 8] = childRow["CKDOCQUYEN"];
                        currentLine++;
                        if (dlg != null)
                            dlg.IncreProgressBarValue();
                    }
                }
            }
            currentLine = currentLine + 1;
            ws.get_Range("A"+currentLine.ToString(), "A"+ currentLine.ToString()).EntireRow.Delete(true);
            ws.get_Range("A8", "A9").EntireRow.Delete(true);
            if (dlg != null)
                dlg.Close();
            excelApp.Visible = true;
        }

        private void btnExportAllDataToExcel_Click(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new SaleReportBLL().GetReportsCustomerDiscountAll();
            ExportExcelDinhMucChietKhauAll(ds);
        }
        private void ExportExcelDinhMucChietKhauAll(System.Data.DataSet ds)
        {
            Workbook wb = null;

            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Banhang\\DinhMucChietKhau_ToanBo.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Banhang\\DinhMucChietKhau_ToanBo.xls"));
                this.Cursor = Cursors.Default;
                return;
            }
            FormProgressBar dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.SetProgressText("Kết xuất dữ liệu ra file Excel...");
                dlg.Show();
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Banhang\\DinhMucChietKhau_ToanBo.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            //do du lieu
            int currentLine = 9;
            ds.Relations.Add("relProvinceCode", ds.Tables[0].Columns["ProvinceCode"], ds.Tables[1].Columns["ProvinceCode"]);
            ds.Relations.Add("relCustomerCode", ds.Tables[1].Columns["SubjectCode"], ds.Tables[2].Columns["CustomerCode"]);
            int len = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                len = len + 1;
                foreach(DataRow childRow in row.GetChildRows("relProvinceCode"))
                    len = len + 1 + ((DataRow[])childRow.GetChildRows("relCustomerCode")).Length;
            }
            if (dlg != null)
                dlg.SetProgressBarMaximum(len);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (((DataRow[])row.GetChildRows("relProvinceCode")).Length > 0)
                {
                    ws.get_Range("A7", "A7").EntireRow.Copy(Type.Missing);
                    ((Range)ws.Cells[currentLine + 1, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                    ws.Cells[currentLine + 1, 1] = row["ProvinceName"];
                    currentLine++;
                    if (dlg != null)
                        dlg.IncreProgressBarValue();
                    foreach (DataRow childRow1 in row.GetChildRows("relProvinceCode"))
                    {
                        ws.get_Range("A8", "A8").EntireRow.Copy(Type.Missing);
                        ((Range)ws.Cells[currentLine + 1, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                        ws.Cells[currentLine + 1, 2] = childRow1["SubjectCode"];
                        ws.Cells[currentLine + 1, 3] = childRow1["SubjectName"];
                        currentLine++;
                        if (dlg != null)
                            dlg.IncreProgressBarValue();

                        foreach (DataRow childRow2 in childRow1.GetChildRows("relCustomerCode"))
                        {
                            ws.get_Range("A9", "A9").EntireRow.Copy(Type.Missing);
                            ((Range)ws.Cells[currentLine + 1, 1]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                            ws.Cells[currentLine + 1, 4] = childRow2["StartDate"];
                            if (Convert.ToDecimal(childRow2["CKINVOICE"].ToString()) != 0) ws.Cells[currentLine + 1, 5] = childRow2["CKINVOICE"];
                            if (Convert.ToDecimal(childRow2["CKQUARTER"].ToString()) != 0) ws.Cells[currentLine + 1, 6] = childRow2["CKQUARTER"];
                            if (Convert.ToDecimal(childRow2["CKYEAR"].ToString()) != 0) ws.Cells[currentLine + 1, 7] = childRow2["CKYEAR"];
                            if (Convert.ToDecimal(childRow2["CKSANLUONG"].ToString()) != 0) ws.Cells[currentLine + 1, 8] = childRow2["CKSANLUONG"];
                            if (Convert.ToDecimal(childRow2["CKDOCQUYEN"].ToString()) != 0) ws.Cells[currentLine + 1, 9] = childRow2["CKDOCQUYEN"];
                            currentLine++;
                            if (dlg != null)
                                dlg.IncreProgressBarValue();
                        }
                    }
                }
            }
            currentLine = currentLine +1;
            ws.get_Range("A" + currentLine.ToString(), "A" + currentLine.ToString()).EntireRow.Delete(true);
            ws.get_Range("A7", "A9").EntireRow.Delete(true);
            if (dlg != null)
                dlg.Close();
            excelApp.Visible = true;
        }
    }
}