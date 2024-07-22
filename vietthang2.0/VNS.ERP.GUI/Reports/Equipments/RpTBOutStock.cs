using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Utils;
using VNS.ERP.Data.Equipments;
//using VNS.Utils;

namespace VNS.ERP.GUI.Equipments
{
   

    public partial class RpTBOutStock : XtraReport
    {
        int STT = 0;
        
        //public struct Params
        //{
        //    public string Description;
        //    public object DataItem;
        //    public object DataDVGiaoNhan;
        //    public string StockName;
        //    public string KhoGiaoNhan;
        //    public decimal TotalSLTXN;
        //    public StockTransaction StObj;
        //}
        public struct Params
        {
            public string Description;
            public object DataItem;
            public string DVGiaoNhan;
            public string NguoiGiaoNhan;
            public string StockName;
            public decimal TotalSLTXN;
            public VattuTransaction StObj;
            //public string KhoGiaoNhan;
        }
        public Params RpParam;

        public RpTBOutStock()
        {
            InitializeComponent();

        }
        public void BindData()
        {
            txtKho.Text = this.RpParam.StockName;
            txtDonVi.Text = RpParam.DVGiaoNhan;

            //if (this.RpParam.StObj.IsLocalTransaction)
            //{
            //    txtDonVi.Text = this.RpParam.KhoGiaoNhan;
            //}

            txtNguoiGiaoNhan.Text = RpParam.NguoiGiaoNhan;
            //txtPTVC.Text = RpParam.StObj.PTVC;
            txtLyDo.Text = RpParam.Description;
            lbNgay.Text = RpParam.StObj.TransactionDate.Day.ToString();
            lblNgaybt.Text = RpParam.StObj.TransactionDate.Day.ToString();
            lbThang.Text = RpParam.StObj.TransactionDate.Month.ToString();
            lblThangbt.Text = RpParam.StObj.TransactionDate.Month.ToString();
            lbNam.Text = RpParam.StObj.TransactionDate.Year.ToString();
            lblNambt.Text = RpParam.StObj.TransactionDate.Year.ToString();
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
            //ListBase<StockTransactionSumDetail> detail = new ListBase<StockTransactionSumDetail>();
            //foreach (StockTransactionSumDetail stsd in RpParam.StObj.Details)
            //{
            //    StockTransactionSumDetail stsd1 = stsd.Clone() as StockTransactionSumDetail;
            //    detail.Add(stsd1);
            //}
            //while (detail.Count < 6)
            //{
            //    StockTransactionSumDetail stsd2 = new StockTransactionSumDetail();
            //    stsd2.ItemCode = string.Empty;
            //    detail.Add(stsd2);

            //}
            ListBase<VattuTransactionDetail> detail = new ListBase<VattuTransactionDetail>();
            foreach (VattuTransactionDetail stsd in RpParam.StObj.ListVattuTransactionDetail)
            {
                VattuTransactionDetail stsd1 = stsd.Clone() as VattuTransactionDetail;
                if (stsd1.EquipmentSxCode == "")
                    stsd1.EquipmentSxCode = stsd1.EquipmentCode;
                detail.Add(stsd1);
            }
            while (detail.Count < 6)
            {
                VattuTransactionDetail stsd2 = new VattuTransactionDetail();
                stsd2.VattuCode = string.Empty;
                detail.Add(stsd2);
            }
            this.DataSource = detail;

            txtSoPhieu.Text = this.RpParam.StObj.TransactionNo;
            celSLTXN2.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMATZ_STRING);
            cellSLYC2.DataBindings.Add("Text", this.DataSource, "EquipmentSxCode");//, AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            //cellTotalYC.DataBindings.Add("Text", this.DataSource, "QuantityReg", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            celTotalSLTXN.DataBindings.Add("Text", this.DataSource, "Quantity");
            //this.lblBangchu.Text = NumberConvert.NumberToSentence(RpParam.TotalSLTXN);

            this.PrintingSystem.ShowMarginsWarning = false;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //StockTransactionSumDetail obj = Detail.Report.GetCurrentRow() as StockTransactionSumDetail;
            //if (obj != null)
            //{
            //    if (obj.ItemCode != string.Empty)
            //    {
            //        this.STT++;
            //        string ItemCode = obj.ItemCode;
            //        Item Item = (this.RpParam.DataItem as ListBase<Item>).Search("ItemCode", ItemCode);
            //        celSLTXN.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            //        cellSLYC.Text = obj.QuantityReg.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
            //        if (Item != null)
            //        {
            //            this.celItemName.Text = Item.ItemName;
            //            this.cellDVT.Text = Item.Unit;
            //        }

            //        cellSTT.Text = (this.RowIndex + 1).ToString();
            //    }
            //    else
            //    {
            //        celSLTXN.Text = "";
            //        cellSLYC.Text = "";
            //        this.celItemName.Text = "";
            //        this.cellDVT.Text = "";
            //        cellSTT.Text = "";
            //    }
            //}
            VattuTransactionDetail obj = Detail.Report.GetCurrentRow() as VattuTransactionDetail;
            if (obj != null)
            {
                if (obj.VattuCode != string.Empty)
                {
                    this.STT++;
                    string ItemCode = obj.VattuCode;
                    Vattu Item = (this.RpParam.DataItem as ListBase<Vattu>).Search("VattuCode", ItemCode);
                    //celSLTXN.Text = obj.Quantity.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    //cellSLYC.Text = obj.QuantityReg.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    //cellSoBao.Text = obj.WrappingCounter.ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if (Item != null)
                    {
                        this.celItemName2.Text = Item.VattuName;
                        this.cellDVT2.Text = Item.Unit;
                    }

                    //cellSTT.Text = (this.RowIndex + 1).ToString();
                }
                else
                {
                    this.celSLTXN2.Text = "";
                    this.cellSLYC2.Text = "";
                    //this.cellSoBao.Text = "";
                    this.celItemName2.Text = "";
                    this.cellDVT2.Text = "";
                    //this.cellSTT.Text = "";
                }
            }
        }

        private void cellSLYC_TextChanged(object sender, EventArgs e)
        {
            if (cellSLYC2.Text == "0") cellSLYC2.Text = "";
        }

        private void celSLTXN_TextChanged(object sender, EventArgs e)
        {
            if (celSLTXN2.Text == "0") celSLTXN2.Text = "";
        }
    }
}
