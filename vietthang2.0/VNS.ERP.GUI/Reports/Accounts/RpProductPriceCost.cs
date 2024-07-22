using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpProductPriceCost : ReportBase1
    {
        public struct Params
        {
            public string period;
            public decimal sumNVL;
            public decimal sumNC;
            public decimal sumSXC;           

            public DataTable dtNVL;
            public DataTable dtNCSXC;
            public DataTable dt;
        }
        public Params RpParams;


        public RpProductPriceCost()
        {
            InitializeComponent();
            //BinData();
        }

        public void BinData()
        {
            //RpSubProductPriceCost1.Params pr1 = new RpSubProductPriceCost1.Params();       
            (this.subreport1.ReportSource as RpSubProductPriceCost1).DataSource = this.RpParams.dtNVL;
            (this.subreport1.ReportSource as RpSubProductPriceCost1).BinData();

            //RpSubProducePriceCost2.Params pr2 = new RpSubProducePriceCost2.Params(); 
            (this.subreport2.ReportSource as RpSubProductPriceCost2).DataSource = this.RpParams.dtNCSXC;
            (this.subreport2.ReportSource as RpSubProductPriceCost2).BinData();         
         

            txtPeriod.Text = this.RpParams.period;
            txtPriceNVL.Text = this.RpParams.sumNVL.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            txtPriceNC.Text = this.RpParams.sumNC.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            txtPriceSXC.Text = this.RpParams.sumSXC.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);
            decimal sum=this.RpParams.sumNVL + this.RpParams.sumNC + this.RpParams.sumSXC;
            txtPriceSum.Text = sum.ToString(AppConfigs.CONFIG_AMOUNTNTFORMAT);


            txtItemCode.DataBindings.Add("Text", this.DataSource, "ItemCode");
            txtSum_Quantity.DataBindings.Add("Text", this.DataSource, "Sum_Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            txtPriceCostNVL.DataBindings.Add("Text", this.DataSource, "PriceCostNVL", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);
            txtNCPriceCost.DataBindings.Add("Text", this.DataSource, "NCPriceCost", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);
            txtSXCPriceCost.DataBindings.Add("Text", this.DataSource, "SXCPriceCost", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);
            txtPriceCostInput.DataBindings.Add("Text", this.DataSource, "PriceCostInput", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);
            txtAmountCost.DataBindings.Add("Text", this.DataSource, "AmountCost", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);


          
            txtTotalQuantity.DataBindings.Add("Text", this.DataSource, "Sum_Quantity");
            txtTotalQuantity.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;

            //txtTotalPriceNVL.DataBindings.Add("Text", this.DataSource, "PriceCostNVL");
            //txtTotalPriceNVL.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;

            //txtTotalPriceNC.DataBindings.Add("Text", this.DataSource, "NCPriceCost");
            //txtTotalPriceNC.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;

            //txtTotalPriceSXC.DataBindings.Add("Text", this.DataSource, "SXCPriceCost");
            //txtTotalPriceSXC.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;

            //txtTotalPrice.DataBindings.Add("Text", this.DataSource, "PriceCostInput");
            //txtTotalPrice.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;

            txtTotalAmount.DataBindings.Add("Text", this.DataSource, "AmountCost");
            txtTotalAmount.Summary.FormatString = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;
       
        }


    }
}
