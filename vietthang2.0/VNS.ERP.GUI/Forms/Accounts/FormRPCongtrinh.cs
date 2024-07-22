using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data.Accounting;
using Microsoft.Office.Interop.Excel;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Forms.Accounts
{
    public partial class FormRPCongtrinh : VNS.Windows.Forms.FormBase
    {
        DataSet ds = null;
        public FormRPCongtrinh()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            ds = new AccountReportBLL().Congtrinh(this.ucDatePeriodSelection1.StartDate, ucDatePeriodSelection1.EndDate);
            //ds.Relations.Add(new DataRelation("Details",
            //    new DataColumn[] { ds.Tables[0].Columns["CongtrinhCode"], ds.Tables[0].Columns["AccountCode"] },
            //    new DataColumn[] { ds.Tables[1].Columns["CongtrinhCode"], ds.Tables[1].Columns["AccountCode"] }
            //        ));
            ds.Relations.Add(new DataRelation("Details",ds.Tables[0].Columns["CongtrinhCode"],ds.Tables[1].Columns["CongtrinhCode"]));
            this.gridControl1.DataSource = ds.Tables[0];
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\Chitietcongtrinh.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\Chitietcongtrinh.xls"));

                return;
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\Chitietcongtrinh.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            //DataRow row1 = this.gridView1.GetFocusedDataRow();

            int cLine = 6;
            foreach (DataRow row1 in ds.Tables[0].Rows)
            foreach (DataRow row in row1.GetChildRows("Details"))
            {
                int cRow = 1;
                ws.Cells[cLine, cRow++] = cLine - 5;
                ws.Cells[cLine, cRow++] = row["CongtrinhCode"].ToString();
                ws.Cells[cLine, cRow++] = row["CongtrinhName"].ToString();
                ws.Cells[cLine, cRow++] = row["AccountCode"].ToString();
                ws.Cells[cLine, cRow++] = (DateTime)row["AccountTransactionDate"];
                ws.Cells[cLine, cRow++] = row["AccountTransactionNo"].ToString();
                ws.Cells[cLine, cRow++] = row["Description"].ToString();
                ws.Cells[cLine, cRow++] = row["DebitAmount"];
                ws.Cells[cLine, cRow++] = row["CreditAmount"];

                cLine++;
            }

            ws.Cells[3, 1] = this.ucDatePeriodSelection1.PeriodText;

            excelApp.Visible = true;
        }
    }
}
