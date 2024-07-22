using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpManufactureForLine : ReportBase1
    {
        public RpManufactureForLine()
        {
            InitializeComponent();
        }
        public RpManufactureForLine(DataTable dt)
        {
            InitializeComponent();
            this.DataSource = dt;
        }
        public void BindDataDetail()
        {
            this.PrintingSystem.ShowMarginsWarning = false;
            this.cellLineSX.DataBindings.Add("Text", DataSource, "LineSX","Line: {0:###.###}");
            this.cellDescription.DataBindings.Add("Text", DataSource, "Description");
            this.cell15SL.DataBindings.Add("Text", DataSource, "L15SL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell15DM.DataBindings.Add("Text", DataSource, "L15DM", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell22SL.DataBindings.Add("Text", DataSource, "L22SL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell22DM.DataBindings.Add("Text", DataSource, "L22DM", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell30SL.DataBindings.Add("Text", DataSource, "L30SL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell30DM.DataBindings.Add("Text", DataSource, "L30DM", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell40SL.DataBindings.Add("Text", DataSource, "L40SL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell40DM.DataBindings.Add("Text", DataSource, "L40DM", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell50SL.DataBindings.Add("Text", DataSource, "L50SL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell50DM.DataBindings.Add("Text", DataSource, "L50DM", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell80SL.DataBindings.Add("Text", DataSource, "L80SL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cell80DM.DataBindings.Add("Text", DataSource, "L80DM", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cellKhacSL.DataBindings.Add("Text", DataSource, "KhacSL", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cellKhacDM.DataBindings.Add("Text", DataSource, "KhacDM", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.cellTotal.DataBindings.Add("Text", DataSource, "Total");
            this.cellTotal.Summary.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;
        }
        public void BindDataMaster(ArrayList array)
        {
            this.cellNhamay.Text = array[0].ToString();
            this.cellTungay.Text = array[1].ToString();
            this.cellDenngay.Text = array[2].ToString();
        }
        
    }
}
