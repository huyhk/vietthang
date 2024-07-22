using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Utils;
//using VNS.Utils;

namespace VNS.ERP.GUI
{
   

    public partial class RpOutStock : XtraReport
    {
        int STT = 0;
        
        public struct Params
        {
            public string Description;
            public object DataItem;
            public object DataDVGiaoNhan;
            public string StockName;
            public string KhoGiaoNhan;
            public decimal TotalSLTXN;
            public StockTransaction StObj;
        }

        public Params RpParam;

        public RpOutStock()
        {
            InitializeComponent();

        }
        public void BindData()
        {
            txtKho.Text = this.RpParam.StockName;
            Customer c = (this.RpParam.DataDVGiaoNhan as ListBase<Customer>).Search("SubjectCode", RpParam.StObj.DVNhan);
            if (c == null)
            {
                txtDonVi.Text = "";
            }
            else
            {
                txtDonVi.Text = c.SubjectName;
            }
            if (this.RpParam.StObj.IsLocalTransaction)
            {
                txtDonVi.Text = this.RpParam.KhoGiaoNhan;
            }

            txtNguoiGiaoNhan.Text = RpParam.StObj.NguoiGiaoNhan;
            txtPTVC.Text = RpParam.StObj.PTVC;
            txtLyDo.Text = RpParam.Description;
            lbNgay.Text = RpParam.StObj.TransactionDate.Day.ToString();
            lblNgaybt.Text = RpParam.StObj.TransactionDate.Day.ToString();
            lbThang.Text = RpParam.StObj.TransactionDate.Month.ToString();
            lblThangbt.Text = RpParam.StObj.TransactionDate.Month.ToString();
            lbNam.Text = RpParam.StObj.TransactionDate.Year.ToString();
            lblNambt.Text = RpParam.StObj.TransactionDate.Year.ToString();
            ListBase<Vendor> lstts = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
            Vendor ts = lstts.Search("SubjectCode", this.RpParam.StObj.DonviVC);
            if (ts != null)
            {
                txtNguoiVC.Text = ts.SubjectName;
            }
            else
            {
                txtNguoiVC.Text = "";
            }
            ListBase<StockTransactionSumDetail> detail = new ListBase<StockTransactionSumDetail>();
            foreach (StockTransactionSumDetail stsd in RpParam.StObj.Details)
            {
                StockTransactionSumDetail stsd1 = stsd.Clone() as StockTransactionSumDetail;
                detail.Add(stsd1);
            }
            while (detail.Count < 6)
            {
                StockTransactionSumDetail stsd2 = new StockTransactionSumDetail();
                stsd2.ItemCode = string.Empty;
                detail.Add(stsd2);

            }
            this.DataSource = detail;

            txtSoPhieu.Text = this.RpParam.StObj.TransactionNo;
            celSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellSLYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            celTotalSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity");
            this.lblBangchu.Text = NumberConvert.NumberToSentence(RpParam.TotalSLTXN);

            this.PrintingSystem.ShowMarginsWarning = false;
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
                    Item Item = (this.RpParam.DataItem as ListBase<Item>).Search("ItemCode", ItemCode);
                    celSLTXN.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    cellSLYC.Text = obj.QuantityReg.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
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
