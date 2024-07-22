using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportXuatTBAmountDetails : ReportBase1
    {
        object lstDatasource;
        public ReportXuatTBAmountDetails()
        {
            InitializeComponent();
        }
        public ReportXuatTBAmountDetails(string periodText, string stockName, string groupName, string equipmentName, DataTable dt)
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
            this.txtVattuCode.DataBindings.Add("Text", lstDatasource, "VattuCode");
            this.txtVattuName.DataBindings.Add("Text", lstDatasource, "VattuName");
            this.txtQuantity.DataBindings.Add("Text", lstDatasource, "Quantity",AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.txtAmount.DataBindings.Add("Text", lstDatasource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
        }
    }
}
