using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Common;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors.Repository;

namespace VNS.ERP.GUI.KCS
{
    public partial class UCEncryptCodeReturn : VNS.Windows.Controls.EditControlBase
    {
        public UCEncryptCodeReturn()
        {
            InitializeComponent();
            this.repTxtPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
        }
        ListBase<TechnicalTest> lstTechnicalTest = null;
        private string subjectCode = string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set
            {
                subjectCode = value;
                lookUpSubjectCode.EditValue = value;
            }
        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                this.lstTechnicalTest = new TechnicalTestBLL().GetAll();
                ListBase<Subject> lst = new SubjectBLL().GetTTPT();
                lookUpSubjectCode.Properties.DataSource = lst;
            }
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            txtReturnNo.Properties.ReadOnly = viewMode;
            dateEditReturn.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            btnEditDetailMaterial.Enabled = !viewMode;
            btnEditDetailProduct.Enabled = !viewMode;
            lookUpSubjectCode.Properties.ReadOnly = true;

            if (this.DataSource == null)
            {
                txtDescription.Text = string.Empty;
                txtReturnNo.Text = string.Empty;
            }
            base.RefreshControl();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new EncryptCodeReturn();
            EncryptCodeReturn t = this.DataSource as EncryptCodeReturn;
            t.ReturnNo = txtReturnNo.Text;
            t.ReturnDate = dateEditReturn.DateTime;
            t.SubjectCode = this.subjectCode;
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
        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            txtReturnNo.Text = txtReturnNo.Text.Trim();
            if (lookUpSubjectCode.EditValue == null || this.subjectCode == string.Empty)
            {
                lookUpSubjectCode.Focus();
                return -1;
            }
            return base.ValidateData();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                EncryptCodeReturn t = this.DataSource as EncryptCodeReturn;
                txtReturnNo.Text = t.ReturnNo;
                dateEditReturn.DateTime = t.ReturnDate;
                txtDescription.Text = t.Description;

                if (t.DetailMaterialTable == null)
                {
                    t.DetailMaterialTable = EncryptCodeReturn.StructDetailMaterialTable.Clone();
                }
                if (t.DetailProductTable == null)
                {
                    t.DetailProductTable = EncryptCodeReturn.StructDetailProductTable.Clone();
                }
                this.RefreshDataOnGridMaterial();
                this.RefreshDataOnGridProduct();
            }
            base.BindData();
        }
        private void RefreshDataOnGridProduct()
        {
            DataTable dt = new DataTable();
            int len = this.bandedGridView2.Columns.Count;
            BandedGridColumn[] arrCol = new BandedGridColumn[len - 1];
            int colPos = 0;
            foreach (BandedGridColumn bgcol in this.bandedGridView2.Columns)
            {
                if (bgcol.Name.Substring(0, 5) == "colRe")
                {
                    arrCol[colPos] = bgcol;
                    colPos++;
                }
            }
            foreach (BandedGridColumn bgcol1 in arrCol)
            {
                this.bandedGridView2.Columns.Remove(bgcol1);
            }

            EncryptCodeReturn t = this.DataSource as EncryptCodeReturn;
            if (t != null && t.DetailProductTable != null)
            {
                DataColumn dc1 = new DataColumn("ItemEncryptCode", typeof(string));
                dt.Columns.Add(dc1);
                foreach (TechnicalTest tt in this.lstTechnicalTest)
                {
                    DataRow[] arrdr = t.DetailProductTable.Select("TechCode = '" + tt.TechCode + "'");
                    if (arrdr.Length > 0)
                    {
                        BandedGridColumn col = this.bandedGridView2.Columns.Add();
                        col.OwnerBand = this.bandDetailProduct;
                        col.OptionsColumn.AllowMove = false;
                        col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                        col.OptionsColumn.ReadOnly = true;
                        col.Visible = true;
                        col.Name = "colReturnProduct" + tt.TechCode;
                        col.Caption = tt.TechName;
                        col.FieldName = "Return" + tt.TechCode;
                        if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                        {
                            col.ColumnEdit = repTxtDecimal;
                        }
                        if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                        {
                            col.ColumnEdit = repTxtPercent;
                        }
                        if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                        {
                            col.ColumnEdit = repTxtString;
                        }

                        DataColumn dc = new DataColumn("Return" + tt.TechCode, typeof(string));
                        dc.DefaultValue = string.Empty;
                        dt.Columns.Add(dc);
                    }
                }
                foreach (DataRow dr1 in t.DetailProductTable.Rows)
                {
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string techCode = dr1["TechCode"].ToString();
                    string result = dr1["Result"].ToString();
                    string filter = "ItemEncryptCode = '" + itemEncryptCode + "'";
                    DataRow[] arrdr = dt.Select(filter);
                    if (arrdr.Length > 0)
                    {
                        if (dt.Columns.IndexOf("Return" + techCode) >= 0)
                        {
                            arrdr[0]["Return" + techCode] = result;
                        }
                    }
                    else
                    {
                        DataRow dr2 = dt.NewRow();
                        dr2["ItemEncryptCode"] = itemEncryptCode;

                        if (dt.Columns.IndexOf("Return" + techCode) >= 0)
                        {
                            dr2["Return" + techCode] = result;
                        }
                        dt.Rows.Add(dr2);
                    }
                }
                this.gridControl2.DataSource = dt;
            }
        }
        private void RefreshDataOnGridMaterial()
        {
            DataTable dt = new DataTable();
            int len = this.bandedGridView1.Columns.Count;
            BandedGridColumn[] arrCol = new BandedGridColumn[len - 1];
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

            EncryptCodeReturn t = this.DataSource as EncryptCodeReturn;
            if (t != null && t.DetailMaterialTable != null)
            {
                DataColumn dc1 = new DataColumn("ItemEncryptCode", typeof(string));
                dt.Columns.Add(dc1);
                foreach (TechnicalTest tt in this.lstTechnicalTest)
                {
                    DataRow[] arrdr = t.DetailMaterialTable.Select("TechCode = '" + tt.TechCode + "'");
                    if (arrdr.Length > 0)
                    {
                        BandedGridColumn col = this.bandedGridView1.Columns.Add();
                        col.OwnerBand = this.bandDetailMaterial;
                        col.OptionsColumn.AllowMove = false;
                        col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                        col.OptionsColumn.ReadOnly = true;
                        col.Visible = true;
                        col.Name = "colReturnMaterial" + tt.TechCode;
                        col.Caption = tt.TechName;
                        col.FieldName = "Return" + tt.TechCode;
                        if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                        {
                            col.ColumnEdit = repTxtDecimal;
                        }
                        if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                        {
                            col.ColumnEdit = repTxtPercent;
                        }
                        if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                        {
                            col.ColumnEdit = repTxtString;
                        }

                        DataColumn dc = new DataColumn("Return" + tt.TechCode, typeof(string));
                        dc.DefaultValue = string.Empty;
                        dt.Columns.Add(dc);
                    }
                }
                foreach (DataRow dr1 in t.DetailMaterialTable.Rows)
                {
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string techCode = dr1["TechCode"].ToString();
                    string result = dr1["Result"].ToString();
                    string filter = "ItemEncryptCode = '" + itemEncryptCode + "'";
                    DataRow[] arrdr = dt.Select(filter);
                    if (arrdr.Length > 0)
                    {
                        if (dt.Columns.IndexOf("Return" + techCode) >= 0)
                        {
                            arrdr[0]["Return" + techCode] = result;
                        }
                    }
                    else
                    {
                        DataRow dr2 = dt.NewRow();
                        dr2["ItemEncryptCode"] = itemEncryptCode;

                        if (dt.Columns.IndexOf("Return" + techCode) >= 0)
                        {
                            dr2["Return" + techCode] = result;
                        }
                        dt.Rows.Add(dr2);
                    }
                }
                this.gridControl1.DataSource = dt;
            }
        }

        private void btnEditDetailProduct_Click(object sender, EventArgs e)
        {
            EncryptCodeReturn ecr = this.DataSource as EncryptCodeReturn;
            if (ecr != null)
            {
                DataTable refProductDetail = ecr.DetailProductTable;
                DataTable refMaterialDetail = ecr.DetailMaterialTable;
                FormEditEncryptCodeReturnDetail f = new FormEditEncryptCodeReturnDetail(this.SubjectCode, ref refMaterialDetail, ref refProductDetail);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshDataOnGridProduct();
                    this.RefreshDataOnGridMaterial();
                }
            }
        }

        private void btnEditDetailMaterial_Click(object sender, EventArgs e)
        {

        }

        private void bandedGridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (this.lstTechnicalTest == null) return;
            if (e.Column.FieldName.Length <= "Return".Length || e.Column.FieldName.Substring(0, 6) != "Return")
                return;
            DataRow dr = bandedGridView1.GetDataRow(e.RowHandle);
            if (dr == null)
                return;
            if (dr.Table.Columns.IndexOf(e.Column.FieldName) < 0) return;
            string techCode = e.Column.FieldName.Substring(6);
            TechnicalTest tt = this.lstTechnicalTest.Search("TechCode", techCode);
            if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
            {
                if (dr.IsNull(e.Column.FieldName))
                {
                    e.RepositoryItem = repTxtString;
                }
                else
                {
                    if (dr[e.Column.FieldName].ToString().Trim() == string.Empty)
                    {
                        e.RepositoryItem = repTxtString;
                    }
                    else
                    {
                        e.RepositoryItem = repTxtDecimal;
                    }
                }
            }
            if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
            {
                if (dr.IsNull(e.Column.FieldName))
                {
                    e.RepositoryItem = repTxtString;
                }
                else
                {
                    if (dr[e.Column.FieldName].ToString().Trim() == string.Empty)
                    {
                        e.RepositoryItem = repTxtString;
                    }
                    else
                    {
                        e.RepositoryItem = repTxtPercent;
                    }
                }
            }
        }

        private void bandedGridView2_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (this.lstTechnicalTest == null) return;
            if (e.Column.FieldName.Length <= "Return".Length || e.Column.FieldName.Substring(0, 6) != "Return")
                return;
            DataRow dr = bandedGridView2.GetDataRow(e.RowHandle);
            if (dr == null)
                return;
            if (dr.Table.Columns.IndexOf(e.Column.FieldName) < 0) return;
            string techCode = e.Column.FieldName.Substring(6);
            TechnicalTest tt = this.lstTechnicalTest.Search("TechCode", techCode);
            if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
            {
                if (dr.IsNull(e.Column.FieldName))
                {
                    e.RepositoryItem = repTxtString;
                }
                else
                {
                    if (dr[e.Column.FieldName].ToString().Trim() == string.Empty)
                    {
                        e.RepositoryItem = repTxtString;
                    }
                    else
                    {
                        e.RepositoryItem = repTxtDecimal;
                    }
                }
            }
            if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
            {
                if (dr.IsNull(e.Column.FieldName))
                {
                    e.RepositoryItem = repTxtString;
                }
                else
                {
                    if (dr[e.Column.FieldName].ToString().Trim() == string.Empty)
                    {
                        e.RepositoryItem = repTxtString;
                    }
                    else
                    {
                        e.RepositoryItem = repTxtPercent;
                    }
                }
            }
        }
    }
}

