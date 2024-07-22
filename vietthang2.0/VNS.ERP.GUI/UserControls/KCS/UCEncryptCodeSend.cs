using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.BandedGrid;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class UCEncryptCodeSend : VNS.Windows.Controls.EditControlBase
    {
        
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
        public UCEncryptCodeSend()
        {
            InitializeComponent();
            
        }

        private void UCEncryptCodeSend_Load(object sender, EventArgs e)
        {

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
            buttonEditSendNo.Properties.ReadOnly = viewMode;
            dateEditSend.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            btnEditDetailMaterial.Enabled = !viewMode;
            btnEditDetailProduct.Enabled = !viewMode;
            lookUpSubjectCode.Properties.ReadOnly = true;

            if (this.DataSource == null)
            {
                txtDescription.Text = string.Empty;
                buttonEditSendNo.Text = string.Empty;
            }
            base.RefreshControl();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new EncryptCodeSend();
            EncryptCodeSend t = this.DataSource as EncryptCodeSend;
            t.SendNo = buttonEditSendNo.Text;
            t.SendDate = dateEditSend.DateTime;
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
            buttonEditSendNo.Text = buttonEditSendNo.Text.Trim();
            if (buttonEditSendNo.Text == string.Empty)
            {
                buttonEditSendNo.Focus();
                return -1;
            }
            if (lookUpSubjectCode.EditValue == null || this.subjectCode == string.Empty)
            {
                lookUpSubjectCode.Focus();
                return -2;
            }
            return base.ValidateData();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                EncryptCodeSend t = this.DataSource as EncryptCodeSend;
                buttonEditSendNo.Text = t.SendNo;
                dateEditSend.DateTime = t.SendDate;
                txtDescription.Text = t.Description;
                
                if (t.DetailMaterialTable == null)
                {
                    t.DetailMaterialTable = EncryptCodeSend.StructDetailMaterialTable.Clone();
                }
                if (t.DetailProductTable == null)
                {
                    t.DetailProductTable = EncryptCodeSend.StructDetailProductTable.Clone();
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

            EncryptCodeSend t = this.DataSource as EncryptCodeSend;
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
                        col.Name = "colRequestProduct" + tt.TechCode;
                        col.Caption = tt.TechName;
                        col.FieldName = "Request" + tt.TechCode;

                        DataColumn dc = new DataColumn("Request" + tt.TechCode, typeof(bool));
                        dc.DefaultValue = false;
                        dt.Columns.Add(dc);
                    }
                }
                foreach (DataRow dr1 in t.DetailProductTable.Rows)
                {
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string techCode = dr1["TechCode"].ToString();
                    string filter = "ItemEncryptCode = '" + itemEncryptCode + "'";
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

                        if (dt.Columns.IndexOf("Request" + techCode) >= 0)
                        {
                            dr2["Request" + techCode] = true;
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

            EncryptCodeSend t = this.DataSource as EncryptCodeSend;
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
                        col.Name = "colRequestMaterial" + tt.TechCode;
                        col.Caption = tt.TechName;
                        col.FieldName = "Request" + tt.TechCode;

                        DataColumn dc = new DataColumn("Request" + tt.TechCode, typeof(bool));
                        dc.DefaultValue = false;
                        dt.Columns.Add(dc);
                    }
                }
                foreach (DataRow dr1 in t.DetailMaterialTable.Rows)
                {
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string techCode = dr1["TechCode"].ToString();
                    string filter = "ItemEncryptCode = '" + itemEncryptCode + "'";
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

        private void btnEditDetailMaterial_Click(object sender, EventArgs e)
        {
            EncryptCodeSend ecs = this.DataSource as EncryptCodeSend;
            if (ecs != null)
            {
                DataTable refDetail = ecs.DetailMaterialTable;
                FormEditEncryptCodeMaterialSendDetail f = new FormEditEncryptCodeMaterialSendDetail(this.SubjectCode, ref refDetail, false);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshDataOnGridMaterial();
                }
            }
        }

        private void btnEditDetailProduct_Click(object sender, EventArgs e)
        {
            EncryptCodeSend ecs = this.DataSource as EncryptCodeSend;
            if (ecs != null)
            {
                DataTable refDetail = ecs.DetailProductTable;
                FormEditEncryptCodeMaterialSendDetail f = new FormEditEncryptCodeMaterialSendDetail(this.SubjectCode, ref refDetail, true);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshDataOnGridProduct();
                }
            }
        }

        private void buttonEditSendNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.editMode != VNS.Windows.FormEditMode.VIEW)
            {
                this.buttonEditSendNo.Text = new EncryptCodeSendBLL().EncryptCodeSendsSetNewNo(this.dateEditSend.DateTime);
            }
        }
    }
}

