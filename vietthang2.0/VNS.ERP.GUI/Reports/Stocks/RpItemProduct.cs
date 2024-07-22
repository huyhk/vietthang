using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class RpItemProduct : DevExpress.XtraReports.UI.XtraReport
    {
        public RpItemProduct()
        {
            InitializeComponent();
            this.Detail.Report.DataSource = new ItemProductBLL().GetAll();
        }
        public void Bindingdata()
        {
       
            this.ItemCode.DataBindings.Add("Text", Detail.Report.DataSource, "ItemCode");
            this.ItemName.DataBindings.Add("Text", Detail.Report.DataSource, "ItemName");
            this.ProductCode.DataBindings.Add("Text", Detail.Report.DataSource, "ProductCode");
            this.WeightCode.DataBindings.Add("Text", Detail.Report.DataSource, "WeightCode", AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING);
            this.SizeCode.DataBindings.Add("Text", Detail.Report.DataSource, "SizeCode");
            this.Description.DataBindings.Add("Text", Detail.Report.DataSource, "Description");

        }

       
    }
}
