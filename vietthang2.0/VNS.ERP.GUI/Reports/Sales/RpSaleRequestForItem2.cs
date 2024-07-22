using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using VNS.Utils;

namespace VNS.ERP.GUI
{
    public partial class RpSaleRequestForItem2 : XtraReport
    {
        private ListBase<Item> lstItems = (new ItemBLL()).GetbyItemtype((int)enumItemType.Product);
        public RpSaleRequestForItem2()
        {
            InitializeComponent();
        }
        public struct Params
        {
            public string Donvimua;
            public string Xuattaikho;
            public string Nguoivanchuyen;
            public string Lydo;
            public string So;
            public DateTime Ngay;
            public string SoPTVC;
            public string NguoiGiaoNhan;

        }
        public Params RpParams;
       

        public void BindDataDetail()
        {
            //Header.
            this.PrintingSystem.ShowMarginsWarning = false;
            this.cellSo.Text = RpParams.So;
            this.cellNgay.Text = RpParams.Ngay.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.cellSoPTVC.Text = RpParams.SoPTVC;
            this.cellNguoinhanhang.Text = RpParams.NguoiGiaoNhan;
            this.cellDonvimua.Text = RpParams.Donvimua;
            this.cellXuattaikho.Text = RpParams.Xuattaikho;
            this.cellNguoivanchuyen.Text = RpParams.Nguoivanchuyen;
            this.cellLydo.Text = RpParams.Lydo;
            //Detail
            this.cellSLYC.DataBindings.Add("Text", DataSource, "QuantityReq", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotal.DataBindings.Add("Text", DataSource, "QuantityReq", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotal.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING;
        }


        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            object obj = this.GetCurrentRow();
            if ((obj as SaleRequestDetails).ItemCode != "")
            {
                this.cellSTT.Text = (this.CurrentRowIndex + 1).ToString();
                this.cellDVT.Text = "Kg";
                this.cellTen.Text = lstItems.Search("ItemCode", (obj as SaleRequestDetails).ItemCode).ItemName;
            }
            else
            {
                this.cellTen.Text = "";
                this.cellDVT.Text = "";
                this.cellSTT.Text = "";
                this.cellSLYC.Text = "";
            }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.cellBangchu.Text = NumberConvert.NumberToSentence(decimal.Parse(this.cellTotal.Summary.GetResult().ToString()))+" Kg";
        }
    }
}
