using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI.Reports.Accounts
{
    public partial class Report_Account_ChiTietBanHang : ReportBase2
    {
        public Report_Account_ChiTietBanHang()
        {
            InitializeComponent();
        }
        public struct Params
        {
           public   DateTime startDate;
           public  DateTime endDate;
           public  string itemName;
           //public  decimal soLuong;
            public DateTime ngayMoSo;
            public decimal doanhThuThuan;
            public decimal giaVon;
            public decimal laiGop;

        }
        public Params RpParams;

        //public Report_Account_ChiTietBanHang(object dsDeTail)
        //{
        //    InitializeComponent();
        //    this.DataSource = dsDeTail;
        //    BindDataDetail();
        //}
        public void BindDataDetail()
        {
            this.cellNgaymoso.Text = RpParams.ngayMoSo.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.cellTuNgay.Text = RpParams.startDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.cellDenNgay.Text = RpParams.endDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.cellItemName.Text = "Tên sản phẩm:  " + RpParams.itemName;
            //this.cellSoLuong1.Text = RpParams.soLuong.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.cellDoanhThuThuan.Text = RpParams.doanhThuThuan.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.cellGiaVon.Text = RpParams.giaVon.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            this.cellLaiGop.Text = RpParams.laiGop.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);


            //lblOpening.Text = RpParams.OpeningAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);
            //lblClosing.Text = RpParams.EndingAmount.ToString(AppConfigs.CONFIG_AMOUNTVNFORMAT);

            //this.cellAccountTransactionDate.DataBindings.Add("Text", DataSource, "AccountTransactionDate", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellNgayThangGhiso.DataBindings.Add("Text",DataSource,"NgayGhiso",AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellSoChungtu.DataBindings.Add("Text", DataSource, "SoChungtu");
            this.cellNgayChungtu.DataBindings.Add("Text", DataSource, "NgayChungtu", AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellDiengiai.DataBindings.Add("Text", DataSource, "Diengiai");
            this.cellTKDU.DataBindings.Add("Text", DataSource, "TKDU");
            this.cellSoluong.DataBindings.Add("Text", DataSource, "Soluong", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            this.cellDongia.DataBindings.Add("Text", DataSource, "Dongia", AppConfigs.CONFIG_PRICEVNFORMAT_STRING); ;
            this.celThanhtien.DataBindings.Add("Text", DataSource, "Thanhtien", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
        }


            //this.cellDiengiai.DataBindings.Add("text",
        
    }
}
