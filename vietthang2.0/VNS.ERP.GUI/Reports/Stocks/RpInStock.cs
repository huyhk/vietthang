using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Utils;

namespace VNS.ERP.GUI
{
    
    public partial class RpInStock : DevExpress.XtraReports.UI.XtraReport
    {
        int STT = 0;
        public struct Params
        {
            public string Description;
            public object DataItem;
            public object DataDVGiaoNhan;
            public string StockName;
            public decimal TotalSLTXN;
            public StockTransaction StObj;
            public string KhoGiaoNhan;
        }
        public Params RpParams = new Params();
      
        public RpInStock()
        {
            InitializeComponent();
            //this.RpParams.LstStock = new StockBLL().GetAll();
        }

        public void BindData()
        {
            this.PrintingSystem.ShowMarginsWarning = false;
            ListBase<StockTransactionSumDetail> detail = new ListBase<StockTransactionSumDetail>();
            foreach (StockTransactionSumDetail stsd in RpParams.StObj.Details)
            {
                StockTransactionSumDetail stsd1 = stsd.Clone() as StockTransactionSumDetail;
                detail.Add(stsd1);
            }
            while (detail.Count < 7)
            {
                StockTransactionSumDetail stsd2 = new StockTransactionSumDetail();
                stsd2.ItemCode = string.Empty;
                detail.Add(stsd2);
            }
            this.DataSource = detail;

            txtKho.Text = RpParams.StockName;
            Vendor v = (RpParams.DataDVGiaoNhan as ListBase<Vendor>).Search("SubjectCode", RpParams.StObj.DVGiao);
            if (v == null)
            {
                txtDonVi.Text = "";
            }
            else
            {
                txtDonVi.Text = v.SubjectName;
            }
            if (this.RpParams.StObj.IsLocalTransaction)
            {
                //Stock st = this.RpParams.LstStock.Search("StockCode", this.RpParams.StObj.KhoGiaoNhan);
                txtDonVi.Text = this.RpParams.KhoGiaoNhan;
            }

            txtCTKT.Text = RpParams.StObj.CTKemTheo;
            txtNguoiGiaoNhan.Text = RpParams.StObj.NguoiGiaoNhan;
            txtPTVC.Text = RpParams.StObj.PTVC;
            txtLyDo.Text = RpParams.Description;
            lbNgay.Text = RpParams.StObj.TransactionDate.Day.ToString();
            lbThang.Text = RpParams.StObj.TransactionDate.Month.ToString();
            lbNam.Text = RpParams.StObj.TransactionDate.Year.ToString();
            ListBase<Vendor> lstts = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
            Vendor ts = lstts.Search("SubjectCode", RpParams.StObj.DonviVC);
            if (ts != null)
            {
                txtNguoiVC.Text = ts.SubjectName;
            }
            else
            {
                txtNguoiVC.Text = "";
            }
            //obj = _obj;
            //dataItem = _dataItem;
            txtSoPhieu.Text = this.RpParams.StObj.TransactionNo;
            // txtNgay.Text = txtNgay.Text + " " + obj.TransactionDate.ToString(AppConfigs.CONFIG_DATEFORMAT);

            celSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSLYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSoBao.DataBindings.Add("Text", this.DataSource, "WrappingCounter", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);

            //cellThanhTien.DataBindings.Add("Text", this.param.StObj.Details, "InLocation");


            cellTotalYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            celTotalSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity");
            cellTotalSoBao.DataBindings.Add("Text", this.DataSource, "WrappingCounter");
            this.lbReadAmount.Text = NumberConvert.NumberToSentence(RpParams.TotalSLTXN);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            StockTransactionSumDetail obj = Detail.Report.GetCurrentRow() as StockTransactionSumDetail;
            if (obj != null)
            {
                if (obj.ItemCode != string.Empty)
                {
                    this.STT++;
                    string ItemCode = obj.ItemCode;
                    Item Item = (this.RpParams.DataItem as ListBase<Item>).Search("ItemCode", ItemCode);
                    celSLTXN.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    cellSLYC.Text = obj.QuantityReg.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    cellSoBao.Text = obj.WrappingCounter.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
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
