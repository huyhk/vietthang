using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpManufacturePlanDetailForSizeCodeSub : XtraReport
    {
        public RpManufacturePlanDetailForSizeCodeSub()
        {
            InitializeComponent();
        }
        public void BindDataDetail()
        {
            this.cellSizeCode.DataBindings.Add("Text", DataSource, "SizeCode", "Viên {0:}");
            this.cellTotalPlanWeight.DataBindings.Add("Text", DataSource, "PlanWeight", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellPlanWrapping.DataBindings.Add("Text", DataSource, "PlanWrapping", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellProductWeight.DataBindings.Add("Text", DataSource, "ProductWeight", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            this.cellWrapping.DataBindings.Add("Text", DataSource, "Wrapping", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
           

            this.cellTotalProductWeightKH.DataBindings.Add("Text", DataSource, "PlanWeight");
            this.cellTotalProductWeightTH.DataBindings.Add("Text", DataSource, "ProductWeight");

            this.cellTotalWrappingKH.DataBindings.Add("Text", DataSource, "PlanWrapping");
            this.cellTotalWrappingTH.DataBindings.Add("Text", DataSource, "Wrapping");

            this.txtDescription.DataBindings.Add("Text", DataSource, "Description");

            this.cellTotalProductWeightKH.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellTotalProductWeightTH.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellTotalWrappingKH.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
            this.cellTotalWrappingTH.Summary.FormatString = AppConfigs.CONFIG_QUANTITYSALEFORMATZ_STRING;
        }
    }
}
