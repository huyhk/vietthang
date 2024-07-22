using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportEquipmentSXCodeAmountDetails : ReportBase1
    {
        object lstDatasource;
        public ReportEquipmentSXCodeAmountDetails()
        {
            InitializeComponent();
        }
        public ReportEquipmentSXCodeAmountDetails(string periodText, string stockName, string line, string equipmentSXName, DataTable dt)
        {
            InitializeComponent();
            txtPeriodText.Text = periodText;
            txtStockName.Text = stockName;
            txtLineSxNo.Text = line;
            txtEquipmentsxName.Text = equipmentSXName;
            lstDatasource = dt;
            this.DataSource = lstDatasource;
            BindData();
        }


        public void BindData()
        {
            this.txtVattuCode.DataBindings.Add("Text", lstDatasource, "VattuCode");
            this.txtVattuName.DataBindings.Add("Text", lstDatasource, "VattuName");
            this.txtQuantity.DataBindings.Add("Text", lstDatasource, "Quantity",AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtAmount.DataBindings.Add("Text", lstDatasource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
        }
    }
}
