using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class ReportBaoCaoTongKetChiPhiBocXep : ReportBase1
    {
        public ReportBaoCaoTongKetChiPhiBocXep(string dateTime, string stockName, string bocxepSubjectName, DataSet ds)
        {
            InitializeComponent();

            this.xrlbBocxepSubjectName.Text = "Đơn vị bốc xếp: " + bocxepSubjectName;
            this.xrlbStockName.Text = "Tại kho: " + stockName;
            this.xrlbDateTime.Text = dateTime;

            this.DataSource = ds;
            this.DetailReport.DataMember = "LoaiHangChiTietCongViec";

            SetCollumnData();

        }
        private void SetCollumnData()
        {
            this.xrToBocXepName.DataBindings.Add("Text", this.DataSource, "ItemName");
            this.xrToBocXepQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.xrToBocXepAmountTronggio.DataBindings.Add("Text", this.DataSource, "AmountTronggio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrToBocXepAmountNgoaigio.DataBindings.Add("Text", this.DataSource, "AmountNgoaigio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrToBocXepTotalAmount.DataBindings.Add("Text", this.DataSource, "TotalAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            //datarelation
            this.xrServiceName.DataBindings.Add("Text", this.DataSource, "LoaiHangChiTietCongViec.ServiceName");
            this.xrQuantity.DataBindings.Add("Text", this.DataSource, "LoaiHangChiTietCongViec.Quantity", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.xrAmountTronggio.DataBindings.Add("Text", this.DataSource, "LoaiHangChiTietCongViec.AmountTronggio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrAmountNgoaigio.DataBindings.Add("Text", this.DataSource, "LoaiHangChiTietCongViec.AmountNgoaigio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrTotalAmountDetail.DataBindings.Add("Text", this.DataSource, "LoaiHangChiTietCongViec.TotalAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            //sum
            this.xrTotalQuantity.DataBindings.Add("Text", this.DataSource, "Quantity");
            this.xrTotalAmountTronggio.DataBindings.Add("Text", this.DataSource, "AmountTronggio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrTotalAmountNgoaigio.DataBindings.Add("Text", this.DataSource, "AmountNgoaigio", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.xrSumTotalAmount.DataBindings.Add("Text", this.DataSource, "TotalAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);

            this.xrTotalQuantity.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;
            this.xrTotalAmountTronggio.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;
            this.xrTotalAmountTronggio.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;
            this.xrSumTotalAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;
        }
    }
}
