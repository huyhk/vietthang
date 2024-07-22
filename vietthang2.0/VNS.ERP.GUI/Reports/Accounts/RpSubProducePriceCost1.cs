using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpSubProductPriceCost1 : XtraReport
    {
        public RpSubProductPriceCost1()
        {
            InitializeComponent();
        }
        public void BinData()
        {
            txtProductCode.DataBindings.Add("Text", this.DataSource, "ProductCode");
            txtCostAmount.DataBindings.Add("Text", this.DataSource, "CostAmount", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            txtQuantity.DataBindings.Add("Text", this.DataSource, "Quantity",AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            txtCostCalculator.DataBindings.Add("Text", this.DataSource, "CostCalculator", AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING);
            txtPriceCost.DataBindings.Add("Text", this.DataSource, "PriceCost", AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING);
        }
    }
}