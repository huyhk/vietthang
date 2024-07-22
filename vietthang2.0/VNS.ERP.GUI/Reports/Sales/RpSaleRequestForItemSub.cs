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
    public partial class RpSaleRequestForItemSub : ReportBase1
    {
        private ListBase<Item> lstItems;
        public RpSaleRequestForItemSub()
        {
            InitializeComponent();
            lstItems = (new ItemBLL()).GetbyItemtype((int)enumItemType.Product);
        }
     
        public void BindDataDetail()
        {
            this.cellSLYC.DataBindings.Add("Text", DataSource, "QuantityReq",AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotal.DataBindings.Add("Text", DataSource, "QuantityReq",AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotal.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMAT_STRING;
        }
        public void BindDataMaster(SaleRequests sale,ArrayList array)
        {
            this.cellSo.Text = sale.SaleRequestNo;
            this.cellNgay.Text = sale.SaleRequestDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            this.cellDonvimua.Text = array[0].ToString();
            this.cellSoPTVC.Text = sale.PTVC;
            this.cellXuattaikho.Text = array[1].ToString();
            this.cellNguoinhanhang.Text = sale.NguoiGiaoNhan;
            this.cellNguoivanchuyen.Text = array[2].ToString();
            this.cellLydo.Text = array[3].ToString();
            this.cellLien.Text = array[4].ToString();
            this.cellText.Text = array[5].ToString();
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
