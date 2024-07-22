using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.GUI.Equipments
{
    public partial class FormImportVattu : VNS.Windows.Forms.FormBase
    {
        ListBase<Vattu> lst = new ListBase<Vattu>();
        public FormImportVattu()
        {
            InitializeComponent();
            this.gridControl1.DataSource = lst;
        }

        private void btnXemmau_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            Workbook wb = excelApp.Workbooks.Add(Type.Missing);
            Worksheet ws = (Worksheet)wb.Worksheets[1];


            ws.Cells[1, 1] = "Mã vật tư";
            ((Range)ws.Cells[1, 1]).ColumnWidth = 15;
            ws.Cells[1, 2] = "Tên vật tư";
            ((Range)ws.Cells[1, 2]).ColumnWidth = 40;
            ws.Cells[1, 3] = "Đơn vị tính";
            ((Range)ws.Cells[1, 3]).ColumnWidth = 15;
            ws.Cells[1, 4] = "Ghi chú";
            ((Range)ws.Cells[1, 4]).ColumnWidth = 40;

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "xls";
            openFileDialog1.Filter = "Excel documents (*.xls)|*.xls";
            openFileDialog1.Title = "Chọn file import";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Open(filePath, 0, true, Type.Missing, Type.Missing, Type.Missing,
                    true, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                try
                {
                    lst.Clear();
                    int currentLine = 2;
                    string itemCode = ((Range)ws.Cells[currentLine, 1]).Text.ToString();

                    while (itemCode != string.Empty)
                    {
                        Vattu item = new Vattu();
                        item.VattuCode = ((Range)ws.Cells[currentLine, 1]).Text.ToString();
                        item.VattuName = ((Range)ws.Cells[currentLine, 2]).Text.ToString();
                        item.Unit = ((Range)ws.Cells[currentLine, 3]).Text.ToString();
                        item.Description = ((Range)ws.Cells[currentLine, 4]).Text.ToString();

                        

                        
                        lst.Add(item);

                        currentLine++;
                        itemCode = ((Range)ws.Cells[currentLine, 1]).Text.ToString();
                    }

                    this.gridView1.BestFitColumns();
                }
                catch
                {
                    MessageBox.Show("Lỗi import");
                }
                finally
                {
                    excelApp.Quit();
                }
            }
        }

        private void btnProcessImport_Click(object sender, EventArgs e)
        {
            ListBase<Vattu> lstTemp = new ListBase<Vattu>();
            VattuBLL bll = new VattuBLL();
            ListBase<Vattu> lstAll = bll.GetAll();
            foreach (Vattu item in lst)
            {
                if (lstAll.Search("VattuCode",item.VattuCode) != null)
                {
                    item.Description = "Trùng mã vật tư";
                    lstTemp.Add(item);
                }
                else
                {
                    int iError = bll.Insert(item);
                    if (iError != 0)
                    {
                        item.Description = "Lỗi import";
                        lstTemp.Add(item);
                    }
                }

            }
            string msg = string.Format("Import thành công {0} mặt hàng.", lst.Count - lstTemp.Count);
            if (lstTemp.Count > 0)
                msg = msg + string.Format("\n {0} dòng bị lỗi không import được", lstTemp.Count);
            lst.Clear();
            foreach (Vattu item in lstTemp)
                lst.Add(item);
            this.gridView1.BestFitColumns();

            MessageBox.Show(msg, "Kết quả import");
        }
    }
}
