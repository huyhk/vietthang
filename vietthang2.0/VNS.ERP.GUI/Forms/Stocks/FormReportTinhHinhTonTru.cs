using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Stocks
{
    public partial class FormReportTinhHinhTonTru : FormBase
    {
        private DataSet ds = null;
        private DateTime toDate = DateTime.Today;
        private string stockCode = string.Empty;
        private string stockName = string.Empty;
        private int days = 30;
        public FormReportTinhHinhTonTru()
        {
            InitializeComponent();
            ListBase<Stock> lstStock = new StockBLL().GetAllForMember(Contexts.CurrentUser.MemberID);
            if (Contexts.CurrentUser.BranchCode == string.Empty)
            {
                Stock stock = new Stock();
                stock.StockCode = string.Empty;
                stock.StockName = string.Empty;
                lstStock.Insert(0, stock);
            }
            this.lookUpStockCode.Properties.DataSource = lstStock;
            ListBase<enums> lstEnumItem = EnumDisplays.GetListenumAllItemType();
            lstEnumItem.Remove(lstEnumItem.Search("EnumID", (byte)enumItemType.Product));
            lstReportFor.DataSource = lstEnumItem;
            dateEditToDate.DateTime = Contexts.WorkingDate;
        }

        private void FormReportTinhHinhTonTru_Load(object sender, EventArgs e)
        {
            lookUpStockCode.ItemIndex = 0;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            FormProgressBar dlg = new FormProgressBar();
            if (dlg != null)
            {
                dlg.Text = this.Text;
                dlg.SetProgressText("Kết xuất ra file Excel...");
                dlg.Show();
            }
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\TinhhinhTontru.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\Kho\\TinhhinhTontru.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                return;
            }
          
            this.toDate = dateEditToDate.DateTime;
            this.stockCode = lookUpStockCode.EditValue.ToString();
            this.stockName = lookUpStockCode.GetColumnValue("StockName").ToString();
            this.days = Convert.ToInt16(txtDays.EditValue);
            ds = new StockReportBLL().ReportsTinhHinhTonTru(this.toDate, this.stockCode, this.days);
            DataView dv = ds.Tables[0].DefaultView;
            System.Data.DataTable dt = null;
            string rowFilter = string.Empty;
            if (optProduct.Checked)
            {
                rowFilter += "ItemType=" + ((byte)enumItemType.Product).ToString();
            }
            else
            {
                for (int i = 0; i < lstReportFor.CheckedItems.Count; i++)
                {
                    if (rowFilter != "")
                    {
                        rowFilter += " or ItemType=" + lstReportFor.CheckedItems[i].ToString();
                    }
                    else
                    {
                        rowFilter += "ItemType=" + lstReportFor.CheckedItems[i].ToString();
                    }
                }
                if (rowFilter == string.Empty)
                {
                    rowFilter += "ItemType <>" + ((byte)enumItemType.Product).ToString();
                }
                else
                {
                    rowFilter += "and ItemType <>" + ((byte)enumItemType.Product).ToString();
                }
            }
            dv.RowFilter = rowFilter;
            dt = dv.ToTable();

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\Kho\\TinhhinhTontru.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            ws.Cells[3, 4] = this.stockName;
            ws.Cells[4, 4] = this.toDate;
            if (optProduct.Checked)
            {
                ws.Cells[6, 4] = "Bán bình quân (kg/ngày)";
                ws.Cells[2, 2] = "TÌNH HÌNH TỒN TRỮ THÀNH PHẨM";
            }
            else
            {
                ws.Cells[6, 4] = "Sử dụng bình quân (kg/ngày)";
                ws.Cells[2, 2] = "TÌNH HÌNH TỒN TRỮ NGUYÊN LIỆU";
            }
            int row = 6;
            int rowCount = dt.Rows.Count;
            if (dlg != null)
                dlg.SetProgressBarMaximum(dt.Rows.Count);
            for (int i = 0; i < rowCount; i++)
            {
                if (dlg != null)
                {
                    dlg.SetProgressText(dt.Rows[i]["ItemCode"].ToString() + "...");
                    dlg.IncreProgressBarValue();
                }
                row += 1;
                ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Copy(Type.Missing);
                ((Range)(ws.Cells[row + 1, 1])).EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, Type.Missing);
                ws.Cells[row, 1] = dt.Rows[i]["ItemCode"];
                ws.Cells[row, 2] = dt.Rows[i]["ItemName"];
                ws.Cells[row, 3] = dt.Rows[i]["Tonkho"];
                ws.Cells[row, 4] = dt.Rows[i]["Sudungbinhquan"];
            }
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            ws.get_Range("A" + ((int)(row + 1)).ToString(), "A" + ((int)(row + 1)).ToString()).EntireRow.Delete(true);
            if (this.stockCode == string.Empty)
            {
                ws.get_Range("A3", "A3").EntireRow.Delete(true);
            }
            //ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
            //ws.get_Range("A" + ((int)(row)).ToString(), "A" + ((int)(row)).ToString()).EntireRow.Delete(true);
            excelApp.Visible = true;
            if (dlg != null)
                dlg.Dispose();
            dlg = null;
        }

        private void optMaterial_CheckedChanged(object sender, EventArgs e)
        {
            lstReportFor.Enabled = optMaterial.Checked;
        }
    }
}