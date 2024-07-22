using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportEquipment_VattuInventory_OldTH2 : ReportBase1
    {
        object lstDatasource;
        public ReportEquipment_VattuInventory_OldTH2()
        {
            InitializeComponent();
        }
        public ReportEquipment_VattuInventory_OldTH2(string periodText, DataTable dt)
        {
            InitializeComponent();
            this.txtPeriodText.Text = periodText;
            lstDatasource = dt;
            this.DataSource = lstDatasource;
            BindData();
        }
        public void BindData()
        {
            this.txtStockName.DataBindings.Add("Text", lstDatasource, "StockName");
            this.txtVattuCode.DataBindings.Add("Text", lstDatasource, "VattuCode");
            this.txtVattuName.DataBindings.Add("Text", lstDatasource, "VattuName");
            this.txtTypeName.DataBindings.Add("Text", lstDatasource, "TypeName");
            this.txtOpenQuantity.DataBindings.Add("Text", lstDatasource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtInQuantity.DataBindings.Add("Text", lstDatasource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtOutQuantity.DataBindings.Add("Text", lstDatasource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtCloseQuantity.DataBindings.Add("Text", lstDatasource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtOpenAmount.DataBindings.Add("Text", lstDatasource, "OpenAmount", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtInAmount.DataBindings.Add("Text", lstDatasource, "InAmount", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtOutAmount.DataBindings.Add("Text", lstDatasource, "OutAmount", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtCloseAmount.DataBindings.Add("Text", lstDatasource, "CloseAmount", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);


            this.txtSumOpenQuantity.DataBindings.Add("Text", lstDatasource, "OpenQuantity");
            this.txtSumOpenQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtSumInQuantity.DataBindings.Add("Text", lstDatasource, "InQuantity");
            this.txtSumInQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtSumOutQuantity.DataBindings.Add("Text", lstDatasource, "OutQuantity");
            this.txtSumOutQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            this.txtSumCloseQuantity.DataBindings.Add("Text", lstDatasource, "CloseQuantity");
            this.txtSumCloseQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;

            this.txtSumOpenAmount.DataBindings.Add("Text", lstDatasource, "OpenAmount");
            this.txtSumOpenAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;
            this.txtSumInAmount.DataBindings.Add("Text", lstDatasource, "InAmount");
            this.txtSumInAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;
            this.txtSumOutAmount.DataBindings.Add("Text", lstDatasource, "OutAmount");
            this.txtSumOutAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;
            this.txtSumCloseAmount.DataBindings.Add("Text", lstDatasource, "CloseAmount");
            this.txtSumCloseAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;


        }
    }
}
