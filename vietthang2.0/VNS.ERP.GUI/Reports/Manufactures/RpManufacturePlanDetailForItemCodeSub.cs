using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpManufacturePlanDetailForItemCodeSub : XtraReport
    {
        public RpManufacturePlanDetailForItemCodeSub()
        {
            InitializeComponent();
        }

        public struct Params
        {
            public string StockName;
        }
        public Params RpParams;
        public void BindDataDetail(string stockName)
        {
            this.cellItemCode.DataBindings.Add("Text", DataSource, "ItemCode");
            this.cellItemName.DataBindings.Add("Text", DataSource, "ItemName");
            this.cellFormulaCode.DataBindings.Add("Text", DataSource, "FormulaCode");
            this.cellUnitWeight.DataBindings.Add("Text", DataSource, "UnitWeight", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellPlanWeight.DataBindings.Add("Text", DataSource, "PlanWeight",AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellLinesxNo.DataBindings.Add("Text", DataSource, "LinesxNo","Line {0:##} ");
            this.cellPlanWrapping.DataBindings.Add("Text", DataSource, "PlanWrapping", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellPlanWrappingTotalG.DataBindings.Add("Text", DataSource, "PlanWrapping");
            this.cellPlanWrappingTotalR.DataBindings.Add("Text", DataSource, "PlanWrapping");
            this.cellTotalShift.DataBindings.Add("Text", DataSource, "Shift","TOTAL CA {0:##}");
            this.cellTotalStock.Text = "TOTAL " + stockName.ToUpper();
            this.cellTotalPlanWeight.DataBindings.Add("Text", DataSource, "PlanWeight");
            this.cellTotalGroup.DataBindings.Add("Text", DataSource, "PlanWeight");
            this.cellProductWeight.DataBindings.Add("Text", DataSource, "ProductWeight", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellWrap.DataBindings.Add("Text", DataSource, "Wrapping", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellTatolGroupPW.DataBindings.Add("Text", DataSource, "ProductWeight");
            this.cellTatolGroupW.DataBindings.Add("Text", DataSource, "Wrapping");
            this.cellTotalPW.DataBindings.Add("Text", DataSource, "ProductWeight");
            this.cellTotalW.DataBindings.Add("Text", DataSource, "Wrapping");
            this.cellDate.DataBindings.Add("Text", DataSource, "DatePlan",AppConfigs.CONFIG_DATEFORMAT_STRING);
            this.cellDescription.DataBindings.Add("Text", DataSource, "Description");

            this.cellTatolGroupPW.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellTatolGroupW.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellTotalPW.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellTotalW.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellPlanWrappingTotalG.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellPlanWrappingTotalR.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellTotalPlanWeight.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellTotalGroup.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            //this.cellTotalGroupD.DataBindings.Add("Text", DataSource, "Description");

        }
    }
}
