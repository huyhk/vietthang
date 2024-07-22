using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportEquipmentSXCodeAmountTH : ReportBase1
    {
        object lstDatasource;
        public ReportEquipmentSXCodeAmountTH()
        {
            InitializeComponent();
        }
        public ReportEquipmentSXCodeAmountTH(string periodText, DataTable dt)
        {
            InitializeComponent();
            txtPeriodText.Text = periodText;
            lstDatasource = dt;
            this.DataSource = lstDatasource;
            BindData();
        }


        public void BindData()
        {
            this.txtSumStock.DataBindings.Add("Text", lstDatasource, "StockName");
            this.txtSumLine.DataBindings.Add("Text", lstDatasource, "LineSxNo");
            this.txtEquipmentSXNo.DataBindings.Add("Text", lstDatasource, "EquipmentsxName");
            this.txtAmount.DataBindings.Add("Text", lstDatasource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);

            this.txtSumAmountStockName.DataBindings.Add("Text", lstDatasource, "Amount");
            this.txtSumAmountStockName.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtSumAnountLine.DataBindings.Add("Text", lstDatasource, "Amount");
            this.txtSumAnountLine.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtTotalAmount.DataBindings.Add("Text", lstDatasource, "Amount");
            this.txtTotalAmount.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

        }

        //string StockCode2;
        //int LineSo2;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //string StockCode1 = this.GetCurrentColumnValue("StockCode").ToString();
            //int LineSo1 = Convert.ToInt32(this.GetCurrentColumnValue("LineSxNo"));

            //if (StockCode1 != StockCode2)
            //{
            //    this.txtStockName.Text = this.GetCurrentColumnValue("StockName").ToString();
            //    this.txtLinesxNo.Text = LineSo1.ToString();
            //    //this.txtEquipmentSXNo.Text = this.GetCurrentColumnValue("EquipmentsxName").ToString();
            //    //this.txtAmount.Text = Convert.ToDecimal(this.GetCurrentColumnValue("Amount")).ToString();
            //}
            //else
            //{
            //    this.txtStockName.Text = "";
            //    if (LineSo1 != LineSo2)
            //        this.txtLinesxNo.Text = LineSo1.ToString();
            //    else
            //        this.txtLinesxNo.Text = "";
            //    //this.txtEquipmentSXNo.Text = this.GetCurrentColumnValue("EquipmentsxName").ToString();
            //    //this.txtAmount.Text = Convert.ToDecimal(this.GetCurrentColumnValue("Amount")).ToString();
            //}
            //StockCode2 = StockCode1;
            //LineSo2 = LineSo1;
        }

    }
}
