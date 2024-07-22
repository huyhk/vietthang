using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportBaoCaoTongKetKhoiLuongBocXep : ReportBase1
    {
        public ReportBaoCaoTongKetKhoiLuongBocXep(DataSet ds, string textDateTime, string bocXepName, string stockName)
        {
            InitializeComponent();

            this.xrlbDateTime.Text = textDateTime;
            this.xrlbBocxepSubjectName.Text ="Đơn vị bốc xếp: "+ bocXepName;
            this.xrlbStockName.Text ="Tại kho: "+ stockName;

            this.DataSource = ds;
            this.DetailReport.DataMember = "ChiTietCongViec";
            SetCollumnData();

        }

        private void SetCollumnData()
        {
            this.xrToBocXepName.DataBindings.Add("Text", this.DataSource, "ToBocxepName");
            this.xrToBocXepQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.xrToBocXepAmountTronggio.DataBindings.Add("Text", this.DataSource, "AmountTronggio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrToBocXepAmountNgoaigio.DataBindings.Add("Text", this.DataSource, "AmountNgoaigio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrToBocXepTotalAmount.DataBindings.Add("Text", this.DataSource, "TotalAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            //datarelation
            this.xrServiceName.DataBindings.Add("Text", this.DataSource, "ChiTietCongViec.ServiceName");
            this.xrQuantity.DataBindings.Add("Text", this.DataSource, "ChiTietCongViec.Quantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.xrAmountTronggio.DataBindings.Add("Text", this.DataSource, "ChiTietCongViec.AmountTronggio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrAmountNgoaigio.DataBindings.Add("Text", this.DataSource, "ChiTietCongViec.AmountNgoaigio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrTotalAmountDetail.DataBindings.Add("Text", this.DataSource, "ChiTietCongViec.TotalAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            //sum
            this.xrTotalQuantity.DataBindings.Add("Text", this.DataSource, "Quantity");
            this.xrTotalAmountTronggio.DataBindings.Add("Text", this.DataSource, "AmountTronggio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrTotalAmountNgoaigio.DataBindings.Add("Text", this.DataSource, "AmountNgoaigio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrSumTotalAmount.DataBindings.Add("Text", this.DataSource, "TotalAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);

            this.xrTotalQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;
            this.xrTotalAmountTronggio.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;
            this.xrSumTotalAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;
        }

    }
}
