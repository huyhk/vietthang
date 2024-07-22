using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using DevExpress.XtraGrid.Views.BandedGrid;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class UCProductTestRequest : VNS.Windows.Controls.EditControlBase
    {
        ListBase<TechnicalTest> lstTechnicalTest = null;
        public delegate void UpdateIsReceved(bool IsReceived);
        public event UpdateIsReceved OnUpdateIsReceved;
        private enumKCSDepartment department = enumKCSDepartment.QLCL;
        public enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
                if (value == enumKCSDepartment.QLCL)
                {
                    this.btnEditDetail.Visible = true;
                    this.btnReceived.Visible = false;
                }
                if (value == enumKCSDepartment.PTN)
                {
                    this.btnEditDetail.Visible = false;
                    this.btnReceived.Visible = true;

                    this.colProduct.Visible = false;
                    this.colStockName.Visible = false;
                    this.colManuDate.Visible = false;
                    this.colShift.Visible = false;
                    this.colSizeCode.Visible = false;
                    this.colLot.Visible = false;
                    this.colFormulaCode.Visible = false;

                    this.colProduct.OptionsColumn.ShowInCustomizationForm = false;
                    this.colStockName.OptionsColumn.ShowInCustomizationForm = false;
                    this.colManuDate.OptionsColumn.ShowInCustomizationForm = false;
                    this.colShift.OptionsColumn.ShowInCustomizationForm = false;
                    this.colSizeCode.OptionsColumn.ShowInCustomizationForm = false;
                    this.colLot.OptionsColumn.ShowInCustomizationForm = false;
                    this.colFormulaCode.OptionsColumn.ShowInCustomizationForm = false;
                }
            }
        }
        public bool IsReveived
        {
            set { this.chkIsReceived.Checked = value; }
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                ProductTestRequest t = this.DataSource as ProductTestRequest;
                dateEditRequest.DateTime = t.DateRequest;
                txtDescription.Text = t.Description;
                chkIsReceived.Checked = t.IsReceived;
                if (t.DetailTable == null)
                {
                    t.DetailTable = ProductTestRequest.StructDetailTable.Clone();
                }
                this.RefreshDataOnGrid();
            }
            base.BindData();
        }
        private void RefreshDataOnGrid()
        {
            DataTable dt = new DataTable();
            int len = this.bandedGridView1.Columns.Count;
            BandedGridColumn[] arrCol = new BandedGridColumn[len - 9];
            int colPos = 0;
            foreach (BandedGridColumn bgcol in this.bandedGridView1.Columns)
            {
                if (bgcol.Name.Substring(0, 5) == "colRe")
                {
                    arrCol[colPos] = bgcol;
                    colPos++;
                }
            }
            foreach (BandedGridColumn bgcol1 in arrCol)
            {
                this.bandedGridView1.Columns.Remove(bgcol1);
            }

            dt.Columns.Add(new DataColumn("ItemEncryptCode", typeof(string)));
            dt.Columns.Add(new DataColumn("TechCode", typeof(string)));
            dt.Columns.Add(new DataColumn("TechName", typeof(string)));
            dt.Columns.Add(new DataColumn("SubjectCode", typeof(string)));
            dt.Columns.Add(new DataColumn("SubjectName", typeof(string)));
            dt.Columns.Add(new DataColumn("StockName", typeof(string)));
            dt.Columns.Add(new DataColumn("ManuDate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Shift", typeof(byte)));
            dt.Columns.Add(new DataColumn("ProductCode", typeof(string)));
            dt.Columns.Add(new DataColumn("SizeCode", typeof(string)));
            dt.Columns.Add(new DataColumn("FormulaCode", typeof(string)));
            dt.Columns.Add(new DataColumn("Lot", typeof(string)));


            ProductTestRequest t = this.DataSource as ProductTestRequest;
            if (t != null && t.DetailTable != null)
            {
                foreach (TechnicalTest tt in this.lstTechnicalTest)
                {
                    DataRow[] arrdr = t.DetailTable.Select("TechCode = '" + tt.TechCode + "'");
                    if (arrdr.Length > 0)
                    {
                        BandedGridColumn col = this.bandedGridView1.Columns.Add();
                        col.OwnerBand = this.bandRequest;
                        col.OptionsColumn.AllowMove = false;
                        col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                        col.OptionsColumn.ReadOnly = true;
                        col.Visible = true;
                        col.Name = "colRequest" + tt.TechCode;
                        col.Caption = tt.TechName;
                        col.FieldName = "Request" + tt.TechCode;

                        DataColumn dc = new DataColumn("Request" + tt.TechCode, typeof(bool));
                        dc.DefaultValue = false;
                        dt.Columns.Add(dc);
                    }
                }
                foreach (DataRow dr1 in t.DetailTable.Rows)
                {
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string techCode = dr1["TechCode"].ToString();
                    string techName= dr1["TechName"].ToString();
                    string subjectCode = dr1["SubjectCode"].ToString();
                    string subjectName = dr1["SubjectName"].ToString();
                    string stockName = dr1["StockName"].ToString();
                    DateTime manuDate = Convert.ToDateTime(dr1["ManuDate"]);
                    byte shift = Convert.ToByte(dr1["Shift"]);
                    string productCode = dr1["ProductCode"].ToString();
                    string sizeCode = dr1["SizeCode"].ToString();
                    string formulaCode = dr1["FormulaCode"].ToString();
                    string lot = dr1["Lot"].ToString();

                    string filter = "ItemEncryptCode = '" + itemEncryptCode + "'";
                    filter += " and SubjectCode = '" + subjectCode + "'";
                    DataRow[] arrdr = dt.Select(filter);
                    if (arrdr.Length > 0)
                    {
                        if (dt.Columns.IndexOf("Request" + techCode) >= 0)
                        {
                            arrdr[0]["Request" + techCode] = true;
                        }
                    }
                    else
                    {
                        DataRow dr2 = dt.NewRow();
                        dr2["ItemEncryptCode"] = itemEncryptCode;
                        dr2["TechCode"] = techCode;
                        dr2["TechName"] = techName;
                        dr2["SubjectCode"] = subjectCode;
                        dr2["SubjectName"] = subjectName;
                        dr2["StockName"] = stockName;
                        dr2["ManuDate"] = manuDate;
                        dr2["Shift"] = shift;
                        dr2["ProductCode"] = dr1["ProductCode"];
                        dr2["SizeCode"] = dr1["SizeCode"];
                        dr2["FormulaCode"] = dr1["FormulaCode"];
                        dr2["Lot"] = lot;

                        if (dt.Columns.IndexOf("Request" + techCode) >= 0)
                        {
                            dr2["Request" + techCode] = true;
                        }
                        dt.Rows.Add(dr2);
                    }
                }
                this.gridControl1.DataSource = dt;
            }
        }
        public UCProductTestRequest()
        {
            InitializeComponent();
          
            
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                this.lstTechnicalTest = new TechnicalTestBLL().GetAll();
            }
        }
        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new ProductTestRequest();
            ProductTestRequest t = this.DataSource as ProductTestRequest;
            t.DateRequest = dateEditRequest.DateTime;
            t.Description = txtDescription.Text;

            if (this.EditMode == VNS.Windows.FormEditMode.ADD)
            {
                t.UserCreated = Contexts.CurrentUser.LoginName;
                t.DateCreated = DateTime.Now;
            }
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            t.DateUpdated = DateTime.Now;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            dateEditRequest.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            chkIsReceived.Properties.ReadOnly = true;
            btnEditDetail.Enabled = !viewMode;

            if (this.DataSource == null)
            {
                txtDescription.Text = string.Empty;
                chkIsReceived.Checked = false;
            }
            base.RefreshControl();
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            chkIsReceived.Checked = !chkIsReceived.Checked;
            if (this.OnUpdateIsReceved != null) this.OnUpdateIsReceved(chkIsReceived.Checked);
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            ProductTestRequest ptr = this.DataSource as ProductTestRequest;
            DataTable dt = ptr.DetailTable;
            FormEditProductTestRequestDetail f = new FormEditProductTestRequestDetail(ref dt);
            if (f.ShowDialog() == DialogResult.Yes)
            {
                this.RefreshDataOnGrid();
            }
        }
    }
}

