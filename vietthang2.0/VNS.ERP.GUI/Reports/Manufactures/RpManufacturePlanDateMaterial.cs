using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using System.Configuration;
using System.Collections.Generic;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpManufacturePlanDateMaterial : ReportBase1
    {
        public RpManufacturePlanDateMaterial()
        {
            InitializeComponent();
        }
        public RpManufacturePlanDateMaterial(object dataSourceHeader, object dataSourceDetail, string stockName)
        {
            InitializeComponent();
            this.DataSource = dataSourceDetail;
            cellPlanDate.Text =(dataSourceHeader as ManufacturePlanDetail).DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            cellPlanDate1.Text = (dataSourceHeader as ManufacturePlanDetail).DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            cellPlanDate2.Text = (dataSourceHeader as ManufacturePlanDetail).DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            cellPlanDate3.Text = (dataSourceHeader as ManufacturePlanDetail).DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            cellPlanDate4.Text = (dataSourceHeader as ManufacturePlanDetail).DetailDate.AddDays(-1).ToString(AppConfigs.CONFIG_DATEFORMAT);
            cellPlanDate5.Text = (dataSourceHeader as ManufacturePlanDetail).DetailDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            cellStockName.Text = stockName;
            this.LoadData();
        }
        private void LoadData()
        {
            cellDeltaQuantity.DataBindings.Add("Text", this.DataSource, "DeltaQuantity",AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalDeltaQuantity.DataBindings.Add("Text", this.DataSource, "DeltaQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellItemCode.DataBindings.Add("Text", this.DataSource, "MaterialCode");
            cellItemName.DataBindings.Add("Text", this.DataSource, "ItemName");
            cellOpenQuantity.DataBindings.Add("Text", this.DataSource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalOpenQuantity.DataBindings.Add("Text", this.DataSource, "OpenQuantity", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellPlanWeightShift1.DataBindings.Add("Text", this.DataSource, "PlanWeightShift1", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalPlanWeightShift1.DataBindings.Add("Text", this.DataSource, "PlanWeightShift1", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellPlanWeightShift2.DataBindings.Add("Text", this.DataSource, "PlanWeightShift2", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalPlanWeightShift2.DataBindings.Add("Text", this.DataSource, "PlanWeightShift2", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellPlanWeightShift3.DataBindings.Add("Text", this.DataSource, "PlanWeightShift3", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalPlanWeightShift3.DataBindings.Add("Text", this.DataSource, "PlanWeightShift3", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalRequest.DataBindings.Add("Text", this.DataSource, "TotalRequest", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            cellTotalAllRequest.DataBindings.Add("Text", this.DataSource, "TotalRequest", AppConfigs.CONFIG_QUANTITYFORMAT_STRING);
            
        }
    }
}
