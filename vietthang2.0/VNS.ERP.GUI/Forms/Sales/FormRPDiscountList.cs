using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data.Sales;
using DevExpress.XtraGrid.Columns;

namespace VNS.ERP.GUI.Forms.Sales
{
    public partial class FormRPDiscountList : FormBase
    {
        public FormRPDiscountList()
        {
            InitializeComponent();
        }
        string Cus = string.Empty;
        public FormRPDiscountList(string cus)
        {
            InitializeComponent();
            Cus = cus;
        }
        DataTable dt = null;
        DataTable dt2 = null;
        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (Cus=="GS")
                dt = new SaleReportBLL().Discount_List_GS(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            else
            dt = new SaleReportBLL().Discount_List(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            this.gridControl1.DataSource = dt;
            this.gridView1.BestFitColumns();
            dt2 = this.GetTB2();

            for (int i = gridView2.Columns.Count - 1; i >= 2; i--)
            {
                gridView2.Columns.RemoveAt(i);
            }

            for (int i = 2; i <= dt2.Columns.Count - 1;i++ )
            {
                GridColumn gc = gridView2.Columns.Add();
                gc.Caption = dt2.Columns[i].ColumnName;
                gc.FieldName = dt2.Columns[i].ColumnName;
                gc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gc.DisplayFormat.FormatString = "n0";
                gc.Visible = true;
            }
            this.gridControl2.DataSource = dt2;
            this.gridView2.BestFitColumns();
        }

        private void btnRP1_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "excel files (*.xls)|*.xls|All files (*.*)|*.*";
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.gridView1.ExportToXls(f.FileName);
            }

     
        }
        DataTable GetTB2()
        {
            DataTable dx = new DataTable();
            dx.Columns.Add("CustomerCode", typeof(string)).DefaultValue = "";
            dx.Columns.Add("CustomerName", typeof(string)).DefaultValue = "";

            foreach (DataRow row in dt.Rows)
            {
                Boolean b = false;
                DataRow rowx1 = null;
                foreach (DataRow rowx in dx.Rows)
                {
                    if (rowx["CustomerCode"].ToString() == row["CustomerCode"].ToString())
                    {
                        b = true;
                        rowx1 = rowx;
                        break;
                    }
                }
                if (!b)
                {
                    rowx1 = dx.NewRow();
                    rowx1["CustomerCode"] = row["CustomerCode"];
                    rowx1["CustomerName"] = row["SubjectName"];
                    dx.Rows.Add(rowx1);
                }

                b = false;
                string colName = row["DiscountName"].ToString();
                foreach (DataColumn col in dx.Columns)
                {

                    if (col.ColumnName == colName)
                    {
                        b = true;
                        break;
                    }
                }
                if (!b)
                {
                    dx.Columns.Add(colName, typeof(decimal)).DefaultValue = 0;
                    //rowx1[colName] =/* (decimal)rowx1[colName] + */(decimal)row["DiscountAmount"];
                }
                //else
                if (rowx1[colName]==System.DBNull.Value)
                    rowx1[colName] = (decimal)row["DiscountAmount"];
                else
                    rowx1[colName] = (decimal)rowx1[colName] + (decimal)row["DiscountAmount"];
            }
            return dx;
        }
        private void btnRP2_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "excel files (*.xls)|*.xls|All files (*.*)|*.*";
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.gridView2.ExportToXls(f.FileName);
            }
        }
    }
}
