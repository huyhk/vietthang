using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpAccountTransactionQuantity : ReportBase1
    {
        public struct Params
        {
            //public DateTime StartDate;
            //public DateTime EndDate;
            public string PeriodText;
        }
       
        public Params ParamsObj= new Params();
      
        public RpAccountTransactionQuantity()
        {
            InitializeComponent();
        }
      
        public void BindData()
        {
            this.lbPeriodText.Text = ParamsObj.PeriodText;
            cellItemCode.DataBindings.Add("Text", this.DataSource, "ItemCode");
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            cellOpenQuantity.DataBindings.Add("Text", this.DataSource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellInQuantity.DataBindings.Add("Text", this.DataSource, "InQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellOutQuantity.DataBindings.Add("Text", this.DataSource, "OutQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellCloseQuantity.DataBindings.Add("Text", this.DataSource, "CloseQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellStockName.DataBindings.Add("Text", this.DataSource, "StockName");
        }

    }
}
