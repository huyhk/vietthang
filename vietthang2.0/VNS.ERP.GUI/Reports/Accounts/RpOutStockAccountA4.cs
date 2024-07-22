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
    public partial class RpOutStockAccountA4 : ReportBase12
    {
        int STT = 0;

        public struct Params
        {
            public object DataItem;
            public decimal TotalAmount;
            public AccountTransactionStockNew AccTSNewObj;
        }
        public Params RpParam;
        public RpOutStockAccountA4()
        {
            InitializeComponent();
            cellTotalThanhTien.Summary.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            celTotalSLTXN.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTotalYC.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
        }
        public void BindData()
        {
            txtKho.Text = this.RpParam.AccTSNewObj.AccTransactionStock.Tenkho;
            //Customer c = (this.RpParam.DataDVGiaoNhan as ListBase<Customer>).Search("SubjectCode", RpParam.StObj.DVNhan);
            //if (c == null)
            //{
            //    txtDonVi.Text = "";
            //}
            //else
            //{
            //    txtDonVi.Text = c.SubjectName;
            //}
            txtDonVi.Text = RpParam.AccTSNewObj.AccTransactionStock.Donvi;
            txtNguoiGiaoNhan.Text = RpParam.AccTSNewObj.AccTransactionStock.Nguoigiaonhan;
            txtPTVC.Text = RpParam.AccTSNewObj.AccTransactionStock.PTVC;
            txtLyDo.Text = RpParam.AccTSNewObj.AccTransactionStock.LydoNX;
            txtNgay.Text = "Ngày " + RpParam.AccTSNewObj.AccountTransactionDate.Day.ToString();
            txtNgay.Text += " tháng " + RpParam.AccTSNewObj.AccountTransactionDate.Month.ToString();
            txtNgay.Text += " năm " + RpParam.AccTSNewObj.AccountTransactionDate.Year.ToString();
            //lbNgay.Text = RpParam.AccTSNewObj.AccTransactionStock.StockTransactionDate.Day.ToString();
            //lblNgaybt.Text = RpParam.AccTSNewObj.AccTransactionStock.StockTransactionDate.Day.ToString();
            //lbThang.Text = RpParam.AccTSNewObj.AccTransactionStock.StockTransactionDate.Month.ToString();
            //lblThangbt.Text = RpParam.AccTSNewObj.AccTransactionStock.StockTransactionDate.Month.ToString();
            //lbNam.Text = RpParam.AccTSNewObj.AccTransactionStock.StockTransactionDate.Year.ToString();
            //lblNambt.Text = RpParam.AccTSNewObj.AccTransactionStock.StockTransactionDate.Year.ToString();
            //ListBase<Transport> lstts = new TransportBLL().GetAll();
            //Transport ts = lstts.Search("SubjectCode", this.RpParam.StObj.DonviVC);
            //if (ts != null)
            //{
            //    txtNguoiVC.Text = ts.SubjectName;
            //}
            //else
            //{
            //    txtNguoiVC.Text = "";
            //}
            txtNguoiVC.Text = RpParam.AccTSNewObj.AccTransactionStock.NguoiVC;
            ListBase<AccountTransactionStockDetail> detail = new ListBase<AccountTransactionStockDetail>();
            foreach (AccountTransactionStockDetail atsd in RpParam.AccTSNewObj.AccTransactionStock.Detail)
            {
                AccountTransactionStockDetail atsd1 = atsd.Clone() as AccountTransactionStockDetail;
                detail.Add(atsd1);
            }
            //while (detail.Count < 6)
            //{
            //    AccountTransactionStockDetail atsd2 = new AccountTransactionStockDetail();
            //    atsd2.ItemCode = string.Empty;
            //    detail.Add(atsd2);
            //}
            this.DataSource = detail;

            txtSoPhieu.Text += this.RpParam.AccTSNewObj.AccTransactionStock.StockTransactionNo;
            // celSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDGia.DataBindings.Add("Text", this.DataSource, "CostPrice", AppConfigs.CONFIG_PRICEVNFORMATZ_STRING);
            cellThanhTien.DataBindings.Add("Text", this.DataSource, "CostAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            cellTotalThanhTien.DataBindings.Add("Text", this.DataSource, "CostAmount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            //cellSLYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            //cellTotalYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            celTotalSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity");
            cellTotalYC.DataBindings.Add("Text", this.DataSource, "Quantity");
            this.lbReadNumber.Text = NumberConvert.NumberToSentence(RpParam.TotalAmount, false, "đồng");

            this.PrintingSystem.ShowMarginsWarning = false;
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
                    Item Item = (this.RpParam.DataItem as ListBase<Item>).Search("ItemCode", ItemCode);
                    celSLTXN.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    cellSLYC.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if (Item != null)
                    {
                        this.celItemName.Text = Item.ItemName;
                        this.cellDVT.Text = Item.Unit;
                    }

                    cellSTT.Text = (this.CurrentRowIndex + 1).ToString();
                }
                else
                {
                    celSLTXN.Text = "";
                    cellSLYC.Text = "";
                    this.celItemName.Text = "";
                    this.cellDVT.Text = "";
                    cellSTT.Text = "";
                }
            }
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
