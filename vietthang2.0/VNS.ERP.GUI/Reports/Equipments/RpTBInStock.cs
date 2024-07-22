using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Utils;
using VNS.ERP.Data.Equipments;

namespace VNS.ERP.GUI.Equipments
{
    
    public partial class RpTBInStock : DevExpress.XtraReports.UI.XtraReport
    {
        int STT = 0;
        public struct Params
        {
            public string Description;
            public object DataItem;
            public string DVGiaoNhan;
            public string StockName;
            public decimal TotalSLTXN;
            public VattuTransaction StObj;
            //public string KhoGiaoNhan;
        }
        public Params RpParams = new Params();
      
        public RpTBInStock()
        {
            InitializeComponent();
            //this.RpParams.LstStock = new StockBLL().GetAll();
        }

        public void BindData()
        {
            this.PrintingSystem.ShowMarginsWarning = false;
            ListBase<VattuTransactionDetail> detail = new ListBase<VattuTransactionDetail>();
            foreach (VattuTransactionDetail stsd in RpParams.StObj.ListVattuTransactionDetail)
            {
                VattuTransactionDetail stsd1 = stsd.Clone() as VattuTransactionDetail;
                detail.Add(stsd1);
            }
            while (detail.Count < 7)
            {
                VattuTransactionDetail stsd2 = new VattuTransactionDetail();
                stsd2.VattuCode = string.Empty;
                detail.Add(stsd2);
            }
            this.DataSource = detail;

            txtKho.Text = RpParams.StockName;
            txtDonVi.Text = RpParams.DVGiaoNhan;

            //if (this.RpParams.StObj.IsLocalTransaction)
            //{
            //    //Stock st = this.RpParams.LstStock.Search("StockCode", this.RpParams.StObj.KhoGiaoNhan);
            //    txtDonVi.Text = this.RpParams.KhoGiaoNhan;
            //}

            txtCTKT.Text = RpParams.StObj.CTKemtheo;
            //txtNguoiGiaoNhan.Text = RpParams.StObj.NguoiGiaoNhan;
            //txtPTVC.Text = RpParams.StObj.PTVC;
            txtLyDo.Text = RpParams.Description;
            lbNgay.Text = RpParams.StObj.TransactionDate.Day.ToString();
            lbThang.Text = RpParams.StObj.TransactionDate.Month.ToString();
            lbNam.Text = RpParams.StObj.TransactionDate.Year.ToString();
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
            txtSoPhieu.Text = this.RpParams.StObj.TransactionNo;
            // txtNgay.Text = txtNgay.Text + " " + obj.TransactionDate.ToString(AppConfigs.CONFIG_DATEFORMAT);

            celSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            cellSLYC.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            //cellSoBao.DataBindings.Add("Text", this.DataSource, "WrappingCounter", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellDGia.DataBindings.Add("Text", this.DataSource, "Price", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            cellThanhTien.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING);
            //cellThanhTien.DataBindings.Add("Text", this.param.StObj.Details, "InLocation");


            cellTotalYC.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalYC.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            celTotalSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity");
            celTotalSLTXN.Summary.FormatString = AppConfigs.CONFIG_QUANTITYFORMAT_STRING;
            cellTienSum.DataBindings.Add("Text", this.DataSource, "Amount", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);
            //cellTotalSoBao.DataBindings.Add("Text", this.DataSource, "WrappingCounter");
            this.lbReadAmount.Text = NumberConvert.NumberToSentence(RpParams.TotalSLTXN) + " đồng";
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            VattuTransactionDetail obj = Detail.Report.GetCurrentRow() as VattuTransactionDetail;
            if (obj != null)
            {
                if (obj.VattuCode != string.Empty)
                {
                    this.STT++;
                    string ItemCode = obj.VattuCode;
                    Vattu Item = (this.RpParams.DataItem as ListBase<Vattu>).Search("VattuCode", ItemCode);
                    //celSLTXN.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    //cellSLYC.Text = obj.QuantityReg.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    //cellSoBao.Text = obj.WrappingCounter.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if (Item != null)
                    {
                        //if (Item.VattuName.Length > 20)
                        //{
                        //    this.celItemName.Text = "";
                        //    this.lblItemName8.Text = Item.VattuName;
                        //    this.lblItemName8.Visible = true;
                        //}
                        //else
                        //{
                        //    this.celItemName.Text = Item.VattuName;
                        //    this.lblItemName8.Text = "";
                        //    this.lblItemName8.Visible = false;
                        //}
                        //this.lblItemName2.Text = Item.VattuName;
                        this.celItemName.Text = Item.VattuName;
                        this.cellDVT.Text = Item.Unit;
                    }

                    //cellSTT.Text = (this.RowIndex + 1).ToString();
                }
                else
                {
                    this.celSLTXN.Text = "";
                    this.cellSLYC.Text = "";
                    //this.cellSoBao.Text = "";
                    this.celItemName.Text = "";
                    this.cellDVT.Text = "";
                    //this.cellSTT.Text = "";
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
