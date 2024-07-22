using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Windows;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormAccountReportBase : FormEditBase
    {
        private System.Data.DataTable dtReport = null;
        public System.Data.DataTable DtReport
        {
            get { return dtReport; }
            set { dtReport = value; }
        }
        private DateTime preStartDate;
        protected DateTime PreStartDate
        {
            get { return preStartDate; }
            set { preStartDate = value; }
        }
        private DateTime preEndDate;
        protected DateTime PreEndDate
        {
            get { return preEndDate; }
            set { preEndDate = value; }
        }
        private DateTime startDate;
        protected DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private DateTime endDate;
        protected DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        private string periodText = string.Empty;
        protected string PeriodText
        {
            get { return periodText; }
            set { periodText = value; }
        }
        private Period periodObj = null;
        protected Period PeriodObj
        {
            get { return periodObj; }
            set { periodObj = value; }
        }
        public FormAccountReportBase()
        {
            InitializeComponent();
            this.navigatorFrmEditBase.Visible = false;
            this.btnAdd.Visible = false;
            this.btnSaveNew.Visible = false;
            this.btnSaveClose.Visible = false;
            this.btnRemove.Visible = false;
            btnCancel.Click += new EventHandler(btnCancel_Click);
            this.ucDatePeriodSelection1.WorkingDate = Contexts.WorkingDate;

            this.colAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.colOldAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.colPreAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;

            this.repItemTxtEditAmount.EditFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;
            this.repItemTxtEditAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMATZ_STRING;
            
        }
       
        /// <summary>
        /// 
        /// </summary>
        protected virtual void RefeshDtReport()
        {
            gridControl1.DataSource = this.DtReport;
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.RefeshDtReport();
        }
        public override void RefreshButtons(bool buttonOnly)
        {
            this.btnEdit.Enabled = this.EditMode == FormEditMode.VIEW;
            if (this.dtReport == null) btnEdit.Enabled = false;
            this.btnSave.Enabled = this.EditMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.EditMode == FormEditMode.EDIT;
            gridView1.OptionsBehavior.Editable = this.editMode == FormEditMode.EDIT;
            btnReport.Enabled = this.EditMode == FormEditMode.VIEW;
            button1.Enabled = this.EditMode == FormEditMode.VIEW;
            btnExportToExcel.Enabled = this.EditMode == FormEditMode.VIEW;
            if (this.DtReport == null)
            {
                button1.Enabled = false;
                btnExportToExcel.Enabled = false;
            }
            btnCopy.Enabled = this.EditMode != FormEditMode.VIEW;
            ucDatePeriodSelection1.Enabled = this.EditMode == FormEditMode.VIEW;
            //this.ucDatePeriodSelection1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }
        private void Report_Click()
        {
            this.StartDate = this.ucDatePeriodSelection1.StartDate;
            this.EndDate = this.ucDatePeriodSelection1.EndDate;
            this.periodText = this.ucDatePeriodSelection1.PeriodText;
            if (this.periodObj != null && this.periodObj.StartDate >= this.StartDate)
            {
                this.colPreAmount.OptionsColumn.ReadOnly = false;
                this.btnEdit.Enabled = true;
            }
            else
            {
                this.colPreAmount.OptionsColumn.ReadOnly = true;
                this.btnEdit.Enabled = false;
            }
            if (this.EndDate.Month - this.StartDate.Month == 0)//month
            {
                this.PreStartDate = this.StartDate.AddMonths(-1);
                this.PreEndDate = this.EndDate.AddMonths(-1);
                this.colAmount.Caption = "Tháng này (Tính toán)";
                this.colOldAmount.Caption = "Tháng này (Lưu)";
                this.colPreAmount.Caption = "Tháng trước";
                this.colOldAmount.OptionsColumn.ReadOnly = false;
                this.colOldAmount.Visible = true;
                btnCopy.Visible = true;
                this.btnEdit.Enabled = true;
            }
            else if (this.EndDate.Month - this.StartDate.Month == 2)//quarter
            {
                this.PreStartDate = this.StartDate.AddMonths(-3);
                this.PreEndDate = this.EndDate.AddMonths(-3);
                this.colAmount.Caption = "Quý này";
                this.colPreAmount.Caption = "Quý trước";
                this.colOldAmount.Visible = false;
                this.colOldAmount.OptionsColumn.ReadOnly = true;
                btnCopy.Visible = false;
            }
            else if (this.EndDate.Month - this.StartDate.Month == 11)//year
            {
                this.PreStartDate = this.StartDate.AddYears(-1);
                this.PreEndDate = this.EndDate.AddYears(-1);
                this.colAmount.Caption = "Năm nay";
                this.colPreAmount.Caption = "Năm trước";
                this.colOldAmount.Visible = false;
                this.colOldAmount.OptionsColumn.ReadOnly = true;
                btnCopy.Visible = false;
            }
            else
            {
                this.PreStartDate = this.StartDate.AddYears(-1);
                this.PreEndDate = this.StartDate.AddDays(-1);//this.EndDate.AddYears(-1);
                this.colAmount.Caption = "Kỳ này";
                this.colPreAmount.Caption = "Năm trước";
                this.colOldAmount.Visible = false;
                this.colOldAmount.OptionsColumn.ReadOnly = true;
                btnCopy.Visible = false;
            }
            button1.Enabled = true;
            btnExportToExcel.Enabled = true;
            this.RefeshDtReport();
        }
        
        protected virtual void Copy_Click()
        {
            foreach (DataRow dr in this.DtReport.Rows)
            {
                dr.BeginEdit();
                dr["OldAmount"] = dr["Amount"];
                dr.EndEdit();
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.Copy_Click();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Report_Click();
        }

        private void FormAccountReportBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                periodObj = new PeriodBLL().GetMin();
            }
        }
        protected virtual void PreviewReport()
        { 

        }
        protected virtual void ExportToExcel()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.PreviewReport();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            this.ExportToExcel();
        }
    }
}