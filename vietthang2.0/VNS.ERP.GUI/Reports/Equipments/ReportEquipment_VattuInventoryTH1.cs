using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportEquipment_VattuInventoryTH1 : ReportBase1
    {
        object lstDatasource;
        public ReportEquipment_VattuInventoryTH1()
        {
            InitializeComponent();
        }
        public ReportEquipment_VattuInventoryTH1(string periodText, DataTable dt)
        {
            InitializeComponent();
            txtPeriodText.Text = periodText;
            lstDatasource = dt;
            this.DataSource = lstDatasource;
            BindData();
        }
        public void BindData()
        {
            this.txtStockName.DataBindings.Add("Text", lstDatasource, "StockName");
            this.txtVattuCode.DataBindings.Add("Text", lstDatasource, "VattuCode");
            this.txtVattuName.DataBindings.Add("Text", lstDatasource, "VattuName");
            this.txtOpenQuantity.DataBindings.Add("Text", lstDatasource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtInQuantity.DataBindings.Add("Text", lstDatasource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtOutQuantity.DataBindings.Add("Text", lstDatasource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtCloseQuantity.DataBindings.Add("Text", lstDatasource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);

            this.txtSumOpenQuantity.DataBindings.Add("Text", lstDatasource, "OpenQuantity");
            this.txtSumOpenQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtSumInQuantity.DataBindings.Add("Text", lstDatasource, "InQuantity");
            this.txtSumInQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtSumOutQuantity.DataBindings.Add("Text", lstDatasource, "OutQuantity");
            this.txtSumOutQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtSumCloseQuantity.DataBindings.Add("Text", lstDatasource, "CloseQuantity");
            this.txtSumCloseQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

        }
    }
}
