using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpInvoiceInItems0Percent : DevExpress.XtraReports.UI.XtraReport
    {
        public struct Params
        {
            public Decimal thueSuat;
            public string masoThue;
            public string diaChi;
            public string nameText;
            public string periodText;
        }
        public Params param = new Params();
        public RpInvoiceInItems0Percent()
        {
            InitializeComponent();
        }
        public void BindData()
        {
            //this.lbtmp.BringToFront();
            this.lbAddress.Text = this.param.diaChi;
            this.lbNameText.Text = this.param.nameText;
            this.lbPeriodText.Text = this.param.periodText;
            this.lbTaxCode.Text = this.param.masoThue;
            //this.lbTittle.Text += " (" + this.param.thueSuat.ToString() + "%)";

            cellKyHieu.DataBindings.Add("Text", this.DataSource, "KyHieu");
            cellSoHD.DataBindings.Add("Text", this.DataSource, "SoHD");
            cellNgay.DataBindings.Add("Text", this.DataSource, "Ngay", AppConfigs.CONFIG_DATEFORMAT_STRING);
            cellTenNguoiBan.DataBindings.Add("Text", this.DataSource, "TenNguoiBan");
            cellMSThue.DataBindings.Add("Text", this.DataSource, "MSThue");
            cellMatHang.DataBindings.Add("Text", this.DataSource, "MatHang");
            cellDoanhSo.DataBindings.Add("Text", this.DataSource, "DoanhSo", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            //cellThueSuat.DataBindings.Add("Text", this.DataSource, "ThueSuat", AppConfigs.CONFIG_PERCENTFORMAT_STRING);
            //cellThueGTGT.DataBindings.Add("Text", this.DataSource, "ThueGTGT", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            cellGhiChu.DataBindings.Add("Text", this.DataSource, "GhiChu");
        }
    }
}
