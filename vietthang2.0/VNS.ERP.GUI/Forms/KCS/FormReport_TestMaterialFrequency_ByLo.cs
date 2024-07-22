using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Windows;
using Microsoft.Office.Interop.Excel;
using VNS.Common;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormReport_TestMaterialFrequency_ByLo : FormBase
    {
        DataSet ds;
        DateTime fromDate, toDate;
        public FormReport_TestMaterialFrequency_ByLo()
        {
            InitializeComponent();
        }

        private void FormReport_TestMaterialFrequency_ByLo_Load(object sender, EventArgs e)
        {
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;
            this.repLookUpVendor.DataSource = new SubjectBLL().GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fromDate = this.ucDatePeriodSelection1.StartDate;
            toDate = this.ucDatePeriodSelection1.EndDate;
            ds = new KCSReportBLL().ReportTestMaterialFrequency_ByLo(fromDate, toDate);
            gridControl1.DataSource = null;
            gridControl1.DataSource = ds.Tables[0];
            gridView1.ExpandAllGroups();
            ConditionsAdjustment();
        }
        private void ConditionsAdjustment()
        {
            StyleFormatCondition cn;
            cn = new StyleFormatCondition(FormatConditionEnum.Greater, gridView3.Columns["Sokiemthieu"], null, 0);
            cn.ApplyToRow = true;
            cn.Appearance.BackColor = Color.Red;
            gridView3.FormatConditions.Add(cn);
        }
    }
}

