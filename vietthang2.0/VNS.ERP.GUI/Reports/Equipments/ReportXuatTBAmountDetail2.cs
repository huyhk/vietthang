using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportXuatTBAmountDetail2 : ReportBase1
    {
        object lstDatasource;
        public ReportXuatTBAmountDetail2()
        {
            InitializeComponent();
        }
        public ReportXuatTBAmountDetail2(string periodText, string stockName, string groupName, string equipmentName, DataTable dt)
        {
            InitializeComponent();
            txtPeriodText.Text = periodText;
            txtStockName.Text = stockName;
            txtGroupName.Text = groupName;
            txtEquipmentsxName.Text = equipmentName;
            lstDatasource = dt;
            this.DataSource = lstDatasource;
            BindData();
        }
        public void BindData()
        {
            this.txtTransactionDateS.DataBindings.Add("Text", lstDatasource, "TransactionDate",AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.txtTransactionNoS.DataBindings.Add("Text", lstDatasource, "TransactionNo");
            this.txtVattuCode.DataBindings.Add("Text", lstDatasource, "VattuCode");
            this.txtVattuName.DataBindings.Add("Text", lstDatasource, "VattuName");
            this.txtQuantity.DataBindings.Add("Text", lstDatasource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtAmount.DataBindings.Add("Text", lstDatasource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);

            this.txtSumAmount.DataBindings.Add("Text", lstDatasource, "Amount");
            this.txtSumAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;
            this.txtSumQuantity.DataBindings.Add("Text", lstDatasource, "Quantity");
            this.txtSumQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
        }
    }
}
