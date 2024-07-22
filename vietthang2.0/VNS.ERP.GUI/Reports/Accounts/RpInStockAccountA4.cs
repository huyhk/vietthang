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
    public partial class RpInStockAccountA4 : ReportBase12
    {
        int STT = 0;
        public struct Params
        {
            public object DataItem;
            public decimal TotalAmount;
            public AccountTransactionStockNew AccTSNewObj;
        }
        public Params RpParams = new Params();
        public RpInStockAccountA4()
        {
            InitializeComponent();
            cellTotalSLTXN.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTotalSLYC.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTotalThanhTien.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
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
            //while (detail.Count < 7)
            //{
            //    AccountTransactionStockDetail atsd2 = new AccountTransactionStockDetail();
            //    atsd2.ItemCode = string.Empty;
            //    detail.Add(atsd2);
            //}
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
            txtLyDo.Text = RpParams.AccTSNewObj.AccTransactionStock.Description;
            txtNgay.Text = "Ngày " + RpParams.AccTSNewObj.AccountTransactionDate.Day.ToString();
            txtNgay.Text += " tháng " + RpParams.AccTSNewObj.AccountTransactionDate.Month.ToString();
            txtNgay.Text += " năm " + RpParams.AccTSNewObj.AccountTransactionDate.Year.ToString();
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
            txtSoPhieu.Text += this.RpParams.AccTSNewObj.AccTransactionStock.StockTransactionNo;
            // txtNgay.Text = txtNgay.Text + " " + obj.TransactionDate.ToString(AppConfigs.CONFIG_DATEFORMAT);

            cellSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSLYC.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDGia.DataBindings.Add("Text", this.DataSource, "CostPrice", AppConfigs.CONFIG_PRICEVNFORMATZ_STRING);
            cellThanhTien.DataBindings.Add("Text", this.DataSource, "CostAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            cellTotalThanhTien.DataBindings.Add("Text", this.DataSource, "CostAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            //  cellSLYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            // cellSoBao.DataBindings.Add("Text", this.DataSource, "WrappingCounter", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);

            //cellThanhTien.DataBindings.Add("Text", this.param.StObj.Details, "InLocation");

            // cellTotalYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity");
            cellTotalSLYC.DataBindings.Add("Text", this.DataSource, "Quantity");
            // cellTotalSoBao.DataBindings.Add("Text", this.DataSource, "WrappingCounter");
            this.lbReadNumber.Text = NumberConvert.NumberToSentence(RpParams.TotalAmount, false, "đồng");
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
                    cellSLTXN.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    cellSLYC.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
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
                    this.cellSLTXN.Text = "";
                    this.cellSLYC.Text = "";
                    //this.cellSoBao.Text = "";
                    this.celItemName.Text = "";
                    this.cellDVT.Text = "";
                    this.cellSTT.Text = "";
                }
            }
        }

        private void cellSLYC_TextChanged(object sender, EventArgs e)
        {
            if (cellSLYC.Text == "0") cellSLYC.Text = "";
        }

        private void celSLTXN_TextChanged(object sender, EventArgs e)
        {
            if (cellSLTXN.Text == "0") cellSLTXN.Text = "";
        }
    }
}
