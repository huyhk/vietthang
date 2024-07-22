using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.Windows;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using Microsoft.Office.Interop.Excel;
using VNS.Common;
using VNS.ERP.GUI.Accounting;
namespace VNS.ERP.GUI.Sales
{
    public partial class FormReportCustomerDept : FormBase
    {
        private bool reportSaleForYear;
        public bool ReportSaleForYear
        {
            get { return reportSaleForYear; }
            set { reportSaleForYear = value; }
        }

        string productType = string.Empty;
        public FormReportCustomerDept()
        {
            InitializeComponent();
            
        }
        public FormReportCustomerDept(string pProductType)
        {
            InitializeComponent();
            productType = pProductType;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataSet ds = new SaleReportBLL().ReportGeneralTH(dateEditStart.DateTime, dateEditEnd.DateTime, productType, this.chkIncludeDetail.Checked, this.chkgetPaymentAccount.Checked);
            //ds.Relations.Add("DeptDetail", ds.Tables[0].Columns["CustomerCode"],
            //       ds.Tables[1].Columns["CustomerCode"]);
            gridControl1.DataSource = null;
            gridControl1.DataSource = ds.Tables[0];
            btnReport.Enabled = true;
            btnReportDeptDetail.Enabled = true;
            chkExportExcel.Enabled = true;
            gridView1.ExpandAllGroups();
        }
        FormProgressBar dlg = null;
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!chkExportExcel.Checked)
            {
                RpCustomerDept rp = new RpCustomerDept(dateEditStart.DateTime, dateEditEnd.DateTime, GridUtils.GetDataTable(gridView1));
                rp.ShowPreviewDialog();
            }
            else
            {
              
                if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Banhang\\TongHopCongNoKhachHang.xls"))
                {
                    MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Banhang\\TongHopCongNoKhachHang.xls"));
                    return;
                }
               

                System.Data.DataTable dt = GridUtils.GetDataTable(gridView1);
                DataView dv = dt.DefaultView;
                dv.Sort = "ProvinceName asc";
                dt = dv.ToTable();

                dlg = new FormProgressBar();
                if (dlg != null)
                {
                    dlg.Text = this.Text;
                    dlg.Show();
                    dlg.SetProgressText("Kết xuất ra file Excel...");
                    dlg.SetProgressBarMaximum(dt.Rows.Count);
                }

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Banhang\\TongHopCongNoKhachHang.xls");
                Worksheet ws = (Worksheet)wb.Worksheets[1];
                ws.Cells[5, 4] = "Từ ngày " + dateEditStart.DateTime.ToString(AppConfigs.CONFIG_DATEFORMAT) + " đến ngày " + dateEditEnd.DateTime.ToString(AppConfigs.CONFIG_DATEFORMAT);
                
                int row = 8;
                int rowCount = dt.Rows.Count;

                string provinceName1 = string.Empty;
                string provinceName2 = string.Empty;
                decimal openAmount = 0;
                decimal periodSaleQuantity = 0;
                decimal periodSaleAmount = 0;
                decimal PeriodPaymentAmount = 0;
                decimal CloseAmount = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    row += 1;
                    if (dlg != null)
                    {
                        dlg.IncreProgressBarValue();
                    }
                    
                    provinceName1 = dt.Rows[i]["ProvinceName"].ToString();
                    if (provinceName1 != provinceName2)
                    {
                        if (provinceName2 != string.Empty)
                        {
                            ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
                        }

                        ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                        ((Range)(ws.Cells[row, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                        provinceName2 = provinceName1;
                        ws.Cells[row, 1] = "Tỉnh: ";
                        ws.Cells[row, 2] = provinceName1;
                        row += 1;
                    }
                    ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Copy(Type.Missing);
                    ((Range)(ws.Cells[row, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                    ws.Cells[row, 1] = dt.Rows[i]["CustomerCode"];
                    ws.Cells[row, 2] = dt.Rows[i]["SubjectName"];
                    ws.Cells[row, 3] = dt.Rows[i]["OpenAmount"];
                    ws.Cells[row, 4] = Convert.ToDecimal(dt.Rows[i]["PeriodSaleQuantity"]);
                    ws.Cells[row, 5] = Convert.ToDecimal(dt.Rows[i]["PeriodSaleAmount"]);
                    ws.Cells[row, 6] = Convert.ToDecimal(dt.Rows[i]["PeriodPaymentAmount"]);
                   
                    ws.Cells[row, 7] = dt.Rows[i]["CloseAmount"];

                    openAmount += Convert.ToDecimal(dt.Rows[i]["OpenAmount"]);
                    periodSaleQuantity += Convert.ToDecimal(dt.Rows[i]["PeriodSaleQuantity"]);
                    periodSaleAmount += Convert.ToDecimal(dt.Rows[i]["PeriodSaleAmount"]);
                    PeriodPaymentAmount += Convert.ToDecimal(dt.Rows[i]["PeriodPaymentAmount"]);
                    CloseAmount += Convert.ToDecimal(dt.Rows[i]["CloseAmount"]);
                }

                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);

                ws.Cells[row + 1, 3] = openAmount;
                ws.Cells[row + 1, 4] = periodSaleQuantity;
                ws.Cells[row + 1, 5] = periodSaleAmount;
                ws.Cells[row + 1, 6] = PeriodPaymentAmount;
                ws.Cells[row + 1, 7] = CloseAmount;
                //ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
                //ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
                excelApp.Visible = true;
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
            }
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            btnReport.Enabled = false;
            btnReportDeptDetail.Enabled = false;
            chkExportExcel.Enabled = false;
        }

        private void dateEditSale_EditValueChanged(object sender, EventArgs e)
        {
            btnReport1.Enabled = false;
        }

        private void btnBaoCao1_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = new SaleReportBLL().ReportSale(dateEditSale.DateTime);
            gridView2.ExpandAllGroups();
            btnReport1.Enabled = true;
            this.ReportSaleForYear = false;
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            RpSale rp = new RpSale(dateEditSale.DateTime, VNS.Windows.GridUtils.GetDataView(gridControl2).ToTable(), this.ReportSaleForYear);
            rp.ShowPreviewDialog();
        }

        private void btnBaoCao2_Click(object sender, EventArgs e)
        {
            gridControl2.DataSource = new SaleReportBLL().ReportSaleForYear(dateEditSale.DateTime);
            gridView2.ExpandAllGroups();
            btnReport1.Enabled = true;
            this.ReportSaleForYear = true;
        }

        private void btnReportDeptDetail_Click(object sender, EventArgs e)
        {
            int i = this.gridView1.FocusedRowHandle;
            this.gridView1.ExpandMasterRow(i);
            DataRow row = this.gridView1.GetDataRow(i);
            GridView gvDetail = (GridView)this.gridView1.GetDetailView(i, 0);
            if (gvDetail != null)
            {
                if (!chkExportExcel.Checked)
                {
                    object obj = GridUtils.GetDataTable(gvDetail);
                    RpCustomerDeptDetail rp = new RpCustomerDeptDetail();

                    RpCustomerDeptDetail.Params pr;
                    pr.OpeningAmount = (decimal)row["OpenAmount"];
                    pr.EndingAmount = (decimal)row["CloseAmount"];
                    pr.StartDate = dateEditStart.DateTime;
                    pr.EndDate = dateEditEnd.DateTime;
                    pr.CustomerName = row["SubjectName"].ToString();
                    pr.TenKetoan = this.txtAccountName.Text;
                    rp.RpParams = pr;

                    rp.DataSource = obj;
                    rp.BindData();
                    rp.ShowPreviewDialog();
                }
                else
                {
                    if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Banhang\\ChiTietCongNoKhachHang.xls"))
                    {
                        MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Banhang\\ChiTietCongNoKhachHang.xls"));
                        return;
                    }

                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Visible = false;
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                    Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Banhang\\ChiTietCongNoKhachHang.xls");
                    Worksheet ws = (Worksheet)wb.Worksheets[1];
                    ws.Cells[5, 4] = "Từ ngày " + dateEditStart.DateTime.ToString(AppConfigs.CONFIG_DATEFORMAT) + " đến ngày " + dateEditEnd.DateTime.ToString(AppConfigs.CONFIG_DATEFORMAT);

                    ws.Cells[7, 2] = row["SubjectName"];
                    ws.Cells[7, 7] = row["OpenAmount"];
                    //ws.Cells[14, 7] = row["CloseAmount"];

                    System.Data.DataTable dt = GridUtils.GetDataTable(gvDetail);

                    dlg = new FormProgressBar();
                    if (dlg != null)
                    {
                        dlg.Text = this.Text;
                        dlg.Show();
                        dlg.SetProgressText("Kết xuất ra file Excel...");
                        dlg.SetProgressBarMaximum(dt.Rows.Count);
                    }

                    int r = 9;
                    int rowCount = dt.Rows.Count;

                    for (int j = 0; j < rowCount; j++)
                    {
                        r += 1;
                        if (dlg != null)
                        {
                            dlg.IncreProgressBarValue();
                        }
                        ws.get_Range("A" + ((int)(r+1)).ToString(), "A" + ((int)(r+1)).ToString()).EntireRow.Copy(Type.Missing);
                        ((Range)(ws.Cells[r+1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                        ws.Cells[r, 1] = dt.Rows[j]["SoCT"];
                        ws.Cells[r, 2] = dt.Rows[j]["NgayCT"];
                        ws.Cells[r, 3] = dt.Rows[j]["Description"];
                        ws.Cells[r, 4] = dt.Rows[j]["ItemName"];
                        decimal quantity = Convert.ToDecimal(dt.Rows[j]["Quantity"]);
                        if(quantity !=0)
                        {
                            ws.Cells[r, 5] = quantity;
                        }
                        decimal saleAmount = Convert.ToDecimal(dt.Rows[j]["SaleAmount"]);
                        if (saleAmount != 0)
                        {
                            ws.Cells[r, 6] = saleAmount;
                        }
                        decimal paymentAmount = Convert.ToDecimal(dt.Rows[j]["PaymentAmount"]);
                        if (paymentAmount != 0)
                        {
                            ws.Cells[r, 7] = paymentAmount;
                        }
                    }

                    ws.get_Range("A" + ((int)(r + 1)).ToString(), "A" + ((int)(r + 1)).ToString()).EntireRow.Delete(true);
                    ws.get_Range("A" + ((int)(r + 1)).ToString(), "A" + ((int)(r + 1)).ToString()).EntireRow.Delete(true);

                    excelApp.Visible = true;

                    if (dlg != null)
                        dlg.Dispose();
                    dlg = null;
                }
            }
        }

        private void FormReportCustomerDept_Load(object sender, EventArgs e)
        {
            dateEditStart.DateTime = Contexts.WorkingDate;
            dateEditEnd.DateTime = Contexts.WorkingDate;
            dateEditSale.DateTime = Contexts.WorkingDate;

            if (productType == string.Empty)
            {
                this.colSoHieu.Visible = true;
                this.colPropertyValue.GroupIndex = 0;
                this.colSoHieu.GroupIndex = 1;
                this.colTPType.GroupIndex = 2;
            }
        }

        private void btnCallModule_Click(object sender, EventArgs e)
        {
            FormReportAccountTransactionSubject f = new FormReportAccountTransactionSubject("131");
            this.ShowChildForm(f);
        }
    }
}