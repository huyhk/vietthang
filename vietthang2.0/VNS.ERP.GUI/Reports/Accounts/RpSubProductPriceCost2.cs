using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpSubProductPriceCost2 : XtraReport
    {
        public RpSubProductPriceCost2()
        {
            InitializeComponent();          
            //BinData();
        }
        public void BinData()
        {
            txtProductSizeCode.DataBindings.Add("Text", this.DataSource, "ProductSizeCode");
            txtCapacity.DataBindings.Add("Text", this.DataSource, "Capacity");
            txtQuantity.DataBindings.Add("Text", this.DataSource, "Quantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            txtTimes.DataBindings.Add("Text", this.DataSource, "Times");
            txtNCPriceCost.DataBindings.Add("Text", this.DataSource, "NCPriceCost", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);
            txtSXCPriceCost.DataBindings.Add("Text", this.DataSource, "SXCPriceCost", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);
        }     

    }
}