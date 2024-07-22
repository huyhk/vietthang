using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportBusinessResult : ReportBase3
    {
        public struct Params
        {
            public string captionAmount;
            public string captionPreAmount;
            public string periodText;
            public decimal reportYear;
        }
        public Params param = new Params();
        public ReportBusinessResult()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            //this.lbtmp.BringToFront();
            this.lbPeriodText.Text = this.param.periodText;
            this.ReportYear = this.param.reportYear;
            this.lbCaptionAmount.Text = this.param.captionAmount;
            this.lbCaptionPreAmount.Text = this.param.captionPreAmount;
            // this.lbTittle.Text += " (" + this.param.thueSuat.ToString() + "%)";

            cellDescription.DataBindings.Add("Text", this.DataSource, "Description");
            cellRowCode.DataBindings.Add("Text", this.DataSource, "RowCode");
            cellThuyetMinh.DataBindings.Add("Text", this.DataSource, "ThuyetMinh");
            //cellAmount.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            //cellPreAmount.DataBindings.Add("Text", this.DataSource, "PreAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string rowCode=Detail.Report.GetCurrentColumnValue("RowCode").ToString();
            if (rowCode == "60")
            {
                cellAmount.Borders = DevExpress.XtraPrinting.BorderSide.Top;
                cellPreAmount.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            }
            if (rowCode == "23")
            {
                cellAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cellPreAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cellDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cellRowCode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cellThuyetMinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //cellPreAmount.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            }
            if (rowCode != "23")
            {
                cellAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cellPreAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cellDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cellRowCode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cellThuyetMinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //cellPreAmount.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            }
            //else
            //{
            //    cellAmount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            //    cellPreAmount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            //}
            if (rowCode == "70")
            {
                xrLine4.Visible = true;
                xrLine5.Visible = true;
                cellAmount.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
                cellPreAmount.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
            }
            decimal oldAmount = Convert.ToDecimal(Detail.Report.GetCurrentColumnValue("OldAmount"));
            decimal preAmount = Convert.ToDecimal(Detail.Report.GetCurrentColumnValue("PreAmount"));
            if (oldAmount == 0)
            {
                cellAmount.Text = "-";
            }
            else
            {
                cellAmount.Text = oldAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            }
            if (preAmount == 0)
            {
                cellPreAmount.Text = "-";
            }
            else
            {
                cellPreAmount.Text = preAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            }
            //DateTime.d
            //else
            //{
            //    cellAmount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            //    cellPreAmount.Borders = DevExpress.XtraPrinting.BorderSide.None;
            //}
        }
    }
}
