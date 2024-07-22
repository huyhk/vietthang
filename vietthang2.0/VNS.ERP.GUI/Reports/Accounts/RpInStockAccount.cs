using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;
using VNS.Utils;

namespace VNS.ERP.GUI
{
    
    public partial class RpInStockAccount : DevExpress.XtraReports.UI.XtraReport
    {
        int STT = 0;
        public struct Params
        {
            // public string Description;
            public object DataItem;
            // public string DonVi;
            // public string StockName;
            public decimal TotalAmount;
            public AccountTransactionStockNew AccTSNewObj;
        }
        public Params RpParams = new Params();
      
        public RpInStockAccount ()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            this.PrintingSystem.ShowMarginsWarning = false;
            ListBase<AccountTransactionStockDetail> detail = new ListBase<AccountTransactionStockDetail>();
            foreach (AccountTransactionStockDetail atsd in RpParams.AccTSNewObj.AccTransactionStock.Detail)
            {
                AccountTransactionStockDetail atsd1 = atsd.Clone() as AccountTransactionStockDetail;
                detail.Add(atsd1);
            }
            while (detail.Count < 7)
            {
                AccountTransactionStockDetail atsd2 = new AccountTransactionStockDetail();
                atsd2.ItemCode = string.Empty;
                detail.Add(atsd2);
            }
            this.DataSource = detail;

            txtKho.Text = this.RpParams.AccTSNewObj.AccTransactionStock.Tenkho;
            txtDonVi.Text = RpParams.AccTSNewObj.AccTransactionStock.Donvi;
            //Vendor v = (RpParams.DataDVGiaoNhan as ListBase<Vendor>).Search("SubjectCode", RpParams.StObj.DVGiao);
            //if (v == null)
            //{
            //    txtDonVi.Text = "";
            //}
            //else
            //{
            //    txtDonVi.Text = v.SubjectName;
            //}

            txtCTKT.Text = RpParams.AccTSNewObj.CTKemtheo;
            txtNguoiGiaoNhan.Text = RpParams.AccTSNewObj.AccTransactionStock.Nguoigiaonhan;
            txtPTVC.Text = RpParams.AccTSNewObj.AccTransactionStock.PTVC;
            txtLyDo.Text = RpParams.AccTSNewObj.AccTransactionStock.LydoNX;
            lbNgay.Text = RpParams.AccTSNewObj.AccountTransactionDate.Day.ToString();
            lbThang.Text = RpParams.AccTSNewObj.AccountTransactionDate.Month.ToString();
            lbNam.Text = RpParams.AccTSNewObj.AccountTransactionDate.Year.ToString();
            txtNguoiVC.Text = RpParams.AccTSNewObj.AccTransactionStock.NguoiVC;
            //ListBase<Transport> lstts = new TransportBLL().GetAll();
            //Transport ts = lstts.Search("SubjectCode", RpParams.StObj.DonviVC);
            //if (ts != null)
            //{
            //    txtNguoiVC.Text = ts.SubjectName;
            //}
            //else
            //{
            //    txtNguoiVC.Text = "";
            //}
            //obj = _obj;
            //dataItem = _dataItem;
            txtSoPhieu.Text = this.RpParams.AccTSNewObj.AccTransactionStock.StockTransactionNo;
            // txtNgay.Text = txtNgay.Text + " " + obj.TransactionDate.ToString(AppConfigs.CONFIG_DATEFORMAT);

            celSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDGia.DataBindings.Add("Text", this.DataSource, "Price", AppConfigs.CONFIG_PRICEVNFORMATZ_STRING);
            cellThanhTien.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            cellTotalThanhTien.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
          //  cellSLYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
           // cellSoBao.DataBindings.Add("Text", this.DataSource, "WrappingCounter", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);

            //cellThanhTien.DataBindings.Add("Text", this.param.StObj.Details, "InLocation");

           // cellTotalYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            celTotalSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity");
           // cellTotalSoBao.DataBindings.Add("Text", this.DataSource, "WrappingCounter");
            this.lbReadAmount.Text = NumberConvert.NumberToSentence(RpParams.TotalAmount, false, "đồng");
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            AccountTransactionStockDetail obj = Detail.Report.GetCurrentRow() as AccountTransactionStockDetail;
            if (obj != null)
            {
                if (obj.ItemCode != string.Empty)
                {
                    this.STT++;
                    string ItemCode = obj.ItemCode;
                    Item Item = (this.RpParams.DataItem as ListBase<Item>).Search("ItemCode", ItemCode);
                    celSLTXN.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                   // cellSLYC.Text = obj.QuantityReg.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                   // cellSoBao.Text = obj.WrappingCounter.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if (Item != null)
                    {
                        this.celItemName.Text = Item.ItemName;
                        this.cellDVT.Text = Item.Unit;
                    }

                    cellSTT.Text = (this.CurrentRowIndex + 1).ToString();
                }
                else
                {
                    this.celSLTXN.Text = "";
                    this.cellSLYC.Text = "";
                    this.cellSoBao.Text = "";
                    this.celItemName.Text = "";
                    this.cellDVT.Text = "";
                    this.cellSTT.Text = "";
                }
            }
        }

        private void cellSoBao_TextChanged(object sender, EventArgs e)
        {
            if (cellSoBao.Text == "0") cellSoBao.Text = "";
        }

        private void cellSLYC_TextChanged(object sender, EventArgs e)
        {
            if (cellSLYC.Text == "0") cellSLYC.Text = "";
        }

        private void celSLTXN_TextChanged(object sender, EventArgs e)
        {
            if (celSLTXN.Text == "0") celSLTXN.Text = "";
        }
    }
}
