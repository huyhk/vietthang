using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpManufactureForEmployeeSub : XtraReport
    {
        public RpManufactureForEmployeeSub()
        {
            InitializeComponent();
           
        }
        public void BindDataDetail()
        {
            this.cellTruongca.DataBindings.Add("Text", DataSource, "EmployeeName");
            this.cell15.DataBindings.Add("Text", DataSource, "L15", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cell22.DataBindings.Add("Text", DataSource, "L22", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cell30.DataBindings.Add("Text", DataSource, "L30", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cell40.DataBindings.Add("Text", DataSource, "L40", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cell50.DataBindings.Add("Text", DataSource, "L50", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cell80.DataBindings.Add("Text", DataSource, "L80", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellKhac.DataBindings.Add("Text", DataSource, "Khac", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotalSL.DataBindings.Add("Text", DataSource, "TotalSL", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellP1.DataBindings.Add("Text", DataSource, "P1", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellP2.DataBindings.Add("Text", DataSource, "P2", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellP3.DataBindings.Add("Text", DataSource, "P3", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellP4.DataBindings.Add("Text", DataSource, "P4", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);
            this.cellTotalPP.DataBindings.Add("Text", DataSource, "TotalPP", AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING);


            this.cell15T.DataBindings.Add("Text", DataSource, "L15");
            this.cell22T.DataBindings.Add("Text", DataSource, "L22");
            this.cell30T.DataBindings.Add("Text", DataSource, "L30");
            this.cell40T.DataBindings.Add("Text", DataSource, "L40");
            this.cell50T.DataBindings.Add("Text", DataSource, "L50");
            this.cell80T.DataBindings.Add("Text", DataSource, "L80");
            this.cellKhacT.DataBindings.Add("Text", DataSource, "Khac");
            this.cellTTSL.DataBindings.Add("Text", DataSource, "TotalSL");
            this.celP1T.DataBindings.Add("Text", DataSource, "P1");
            this.cellP2T.DataBindings.Add("Text", DataSource, "P2");
            this.cellP3T.DataBindings.Add("Text", DataSource, "P3");
            this.cellP4T.DataBindings.Add("Text", DataSource, "P4");
            this.cellTTPT.DataBindings.Add("Text", DataSource, "TotalPP");
        }
        public void BindDataMaster(string PositionEmployeeName)
        {
            this.lblEmployee.Text = PositionEmployeeName;
        }
        
      
    }
}
