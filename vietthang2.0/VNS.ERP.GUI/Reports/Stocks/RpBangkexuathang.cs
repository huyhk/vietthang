using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;
using System.Data;

namespace VNS.ERP.GUI
{
    public partial class RpBangkexuathang : ReportBase1
    {
        string date, kho;
        DataSet ds;
        DataTable dt0, dt1;
        public RpBangkexuathang(string pDate, string pKho, DataSet pDs, DataTable pDt)
        {
            InitializeComponent();
            this.date = pDate;
            this.kho = pKho;
            this.ds = pDs;
            this.dt0 = pDt;
            SortTable();
            this.DataSource = dt1;
            BindData();
        }

        private void BindData()
        {
            this.txtDate.Text = date;
            this.txtKho.Text += kho;
            this.txtLoaihang.DataBindings.Add("Text", this.DataSource, "Loaihang");
            this.txtSobao.DataBindings.Add("Text", this.DataSource, "Sobao", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtYeucau.DataBindings.Add("Text", this.DataSource, "Yeucau", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtThucxuat.DataBindings.Add("Text", this.DataSource, "Thucxuat", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtCodeSanpham.DataBindings.Add("Text", this.DataSource, "CodeSanpham");
         }


        string transactionID1 = "";
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.GetCurrentColumnValue("TransactionID") != null)
            {
                string transactionID2 = this.GetCurrentColumnValue("TransactionID").ToString();
                if (this.transactionID1 != transactionID2)
                {
                    foreach (System.Data.DataRow row in dt0.Rows)
                    {
                        if (row["TransactionID"].ToString() == this.GetCurrentColumnValue("TransactionID").ToString())
                        {
                            this.txtSoCt.Text = row["SoCt"].ToString();
                            this.txtKhachhang.Text = row["Khachhang"].ToString();
                            this.ttxtNguoinhan.Text = row["Nguoinhan"].ToString();
                            this.txtTenPTVC.Text = row["TenPTVC"].ToString();
                            transactionID1 = transactionID2;
                        }
                    }
                }
                else
                {
                    this.txtSoCt.Text ="";
                    this.txtKhachhang.Text = "";
                    this.ttxtNguoinhan.Text = "";
                    this.txtTenPTVC.Text = "";
                }
            }
        }
        private void SortTable()
        {
            dt1 = ds.Tables[1].Clone();
            foreach (DataRow row in dt0.Rows)
            {
                foreach (DataRow row1 in ds.Tables[0].Rows)
                {
                    if(row1["TransactionID"].ToString()==row["TransactionID"].ToString())
                        foreach (DataRow row2 in row1.GetChildRows("Details"))
                        {
                            dt1.ImportRow(row2);
                        }
                }
            }
        }
    }
}
