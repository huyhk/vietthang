using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Windows;
using DevExpress.XtraGrid;
using DevExpress.Utils;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormRpCustomerDeptOpening : FormBase
    {
        DataTable dt;
        string productType;
        public FormRpCustomerDeptOpening(string pProductType)
        {
            InitializeComponent();
            this.cboTungay.DateTime = Contexts.WorkingDate;

            productType = pProductType;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dt = (new CustomerDeptOpeningBLL()).ReportsCustomerDeptOpening(this.cboTungay.DateTime, productType);
            this.gridControl.DataSource = dt;
            if (this.gridView.RowCount > 0)
                this.btnReports.Enabled = true;
            else
                this.btnReports.Enabled = false;
            ConditionsAdjustment();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (this.gridView.RowCount > 0)
            {
                DataView dv = GridUtils.GetDataView(gridControl);
                RpCustomerDeptOpening rpt = new RpCustomerDeptOpening(dv);
                rpt.BindDataMaster(this.cboTungay.Text);
                rpt.ShowPreviewDialog();
            }
        }
        private void ConditionsAdjustment()
        {
            gridView.FormatConditions.Clear();
            StyleFormatCondition cn;
            cn = new StyleFormatCondition(FormatConditionEnum.LessOrEqual, gridView.Columns["DueDate"], null, this.cboTungay.DateTime);
            cn.ApplyToRow = true;
            cn.Appearance.BackColor = Color.Red;
            gridView.FormatConditions.Add(cn);
            cn = new StyleFormatCondition(FormatConditionEnum.Equal, gridView.Columns["DueDate"], null, null);
            cn.ApplyToRow = true;
            cn.Appearance.BackColor = Color.Empty;
            cn.Appearance.ForeColor = Color.Empty;
            gridView.FormatConditions.Add(cn);
            gridView.BestFitColumns();
        }
    }
}