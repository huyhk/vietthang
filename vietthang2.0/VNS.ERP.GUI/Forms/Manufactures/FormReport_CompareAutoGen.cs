using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Manufactures;
using VNS.Common;
using VNS.Windows;
using DevExpress.Utils;


namespace VNS.ERP.GUI.Manufactures
{
    public partial class FormReport_CompareAutoGen : FormBase
    {
        ManufactureReportBLL mrp = new ManufactureReportBLL();
        DataTable dt;
        public FormReport_CompareAutoGen()
        {
            InitializeComponent();
            ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dt = mrp.ReportCompareAutoGen(ucDatePeriodSelection1.StartDate, ucDatePeriodSelection1.EndDate, lookUpStockCode.EditValue.ToString());
            gridControl1.DataSource = dt;
        }

        private void FormReport_CompareAutoGen_Load(object sender, EventArgs e)
        {
            this.lookUpStockCode.Properties.DataSource = new StockBLL().GetAll();
            this.lookUpStockCode.ItemIndex = 0;
        }

    }
}

