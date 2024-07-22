using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.ERP.Data.Manufactures;
using VNS.Common;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormApplyTestRequestResult : VNS.Windows.Forms.FormBase
    {
        private bool isProduct = false;
        private string itemEncryptCode = string.Empty;
        ListBase<TechnicalTest> lst = new ListBase<TechnicalTest>();
        public FormApplyTestRequestResult()
        {
            InitializeComponent();
            repTxtPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            repTxtPercent1.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            repTxtPercent2.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
           

        }
        private DataTable dtApplied;
        public DataTable DTApplied
        {
            get 
            {
                return dtApplied;
            }
            set 
            {
                dtApplied = value;
            }
        }
        public FormApplyTestRequestResult(string itemEncryptCode, bool isProduct)
        {
            InitializeComponent();
            repBtnEditApply.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditApply_ButtonClick);
            repBtnEditDeleteApply.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditDeleteApply_ButtonClick);
            this.itemEncryptCode = itemEncryptCode;
            this.isProduct = isProduct;
            if (isProduct)
            {
                this.groupMaterial.Visible = false;
                this.groupProduct.Visible = true;
            }
            else
            {
                this.groupMaterial.Visible = true;
                this.groupProduct.Visible = false;
            }
            DataSet ds = new TestRequestReturnBLL().GetForApplyResult(itemEncryptCode, isProduct);
            gridControlApplied.DataSource = ds.Tables[0];
            this.DTApplied = ds.Tables[0];
            gridControl1.DataSource = ds.Tables[1];
            gridControl2.DataSource = ds.Tables[2];
            gridControl3.DataSource = ds.Tables[3];
        }
        public FormApplyTestRequestResult(DataRow drInfo, bool isProduct)
        {
            InitializeComponent();
            lst = new TechnicalTestBLL().GetAll();
            lookUpEditStock1.Properties.DataSource = new StockBLL().GetAll();
            lookUpEditProduct.Properties.DataSource = new ProductBLL().GetAll();
            lookUpEditSizeCode.Properties.DataSource = new ProductSizeBLL().GetAll();
            lookUpEditFormula.Properties.DataSource = new ProductFormulaBLL2().GetAll();
            //lookUpEditBranchCode.Properties.DataSource = new BranchBLL().GetAll();
            lookUpEditItem.Properties.DataSource = new ItemBLL().GetAll();
            lookUpEditStock.Properties.DataSource = new StockBLL().GetAll();
            lookUpEditCustomer.Properties.DataSource = new VendorBLL().GetAll();

            string itemEncryptCode = drInfo["ItemEncryptCode"].ToString();
            this.itemEncryptCode = itemEncryptCode;
            repBtnEditApply.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditApply_ButtonClick);
            repBtnEditDeleteApply.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditDeleteApply_ButtonClick);
            this.itemEncryptCode = itemEncryptCode;
            this.isProduct = isProduct;
            if (isProduct)
            {
                this.groupMaterial.Visible = false;
                this.groupProduct.Visible = true;
                //dateEditRequest.DateTime = Convert.ToDateTime(drInfo["DateRequest"]);
                txtDescription1.Text = drInfo["Description"].ToString();
                lookUpEditStock1.EditValue = drInfo["StockCode"].ToString();
                dateEditManu.DateTime = Convert.ToDateTime(drInfo["ManuDate"]);
                txtShift.Text = drInfo["Shift"].ToString();
                lookUpEditProduct.EditValue = drInfo["ProductCode"].ToString();
                lookUpEditSizeCode.EditValue = drInfo["SizeCode"].ToString();
                lookUpEditFormula.EditValue = drInfo["FormulaCode"].ToString();
                txtLot.Text = drInfo["Lot"].ToString();
            }
            else
            {
                this.groupMaterial.Visible = true;
                this.groupProduct.Visible = false;
                txtTestTransactionNo.Text = drInfo["TestTransactionNo"].ToString();
                dateEdit1.DateTime = Convert.ToDateTime(drInfo["TestTransactionDate"]);
                //lookUpEditBranchCode.EditValue = drInfo["BranchCode"].ToString();
                lookUpEditItem.EditValue = drInfo["ItemCode"].ToString();
                lookUpEditStock.EditValue = drInfo["StockCode"].ToString();
                txtLocation.Text = drInfo["Location"].ToString();
                if (drInfo.Table.Columns.IndexOf("SubjectCode") >= 0)
                {
                    lookUpEditCustomer.EditValue = drInfo["SubjectCode"].ToString();
                }
                else
                {
                    lookUpEditCustomer.EditValue = drInfo["CustomerCode"].ToString();
                }
                txtPTVC.Text = drInfo["PTVC"].ToString();
                //dateEditStart.DateTime = Convert.ToDateTime(drInfo["StartDate"]);
                //dateEditTo.DateTime = Convert.ToDateTime(drInfo["EndDate"]);
                txtDescription.Text = drInfo["Description"].ToString();
            }
            DataSet ds = new TestRequestReturnBLL().GetForApplyResult(itemEncryptCode, isProduct);
            gridControlApplied.DataSource = ds.Tables[0];
            this.DTApplied = ds.Tables[0];
            gridControl1.DataSource = ds.Tables[1];
            gridControl2.DataSource = ds.Tables[2];
            gridControl3.DataSource = ds.Tables[3];
        }

        void repBtnEditDeleteApply_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = gridViewApplied.GetDataRow(gridViewApplied.FocusedRowHandle);
            string itemEncryptCode = dr["ItemEncryptCode"].ToString();
            string techCode = dr["TechCode"].ToString();
            string subjectCode = string.Empty;
            if (!dr.IsNull("SubjectCode"))
            {
                subjectCode = dr["SubjectCode"].ToString();
            }
            int iError = new TestRequestReturnBLL().CancelApplyResult(itemEncryptCode, techCode, subjectCode, this.isProduct);
            if (iError == 0)
            {
                DataTable dt = gridControl1.DataSource as DataTable;
                DataRow dr1 = dt.NewRow();
                foreach (DataColumn dc in dt.Columns)
                {
                    dr1[dc.Caption] = dr[dc.Caption];
                }
                dt.Rows.Add(dr1);
                gridViewApplied.DeleteRow(gridViewApplied.FocusedRowHandle);
            }
            else
            {
                MessageBox.Show(this.GetTextMessage("CancleApplied" + iError.ToString(), "Bỏ chọn không thành công"));
            }
        }

        void repBtnEditApply_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            string itemEncryptCode = dr["ItemEncryptCode"].ToString();
            string techCode = dr["TechCode"].ToString();
            string subjectCode = string.Empty;
            if (!dr.IsNull("SubjectCode"))
            {
                subjectCode = dr["SubjectCode"].ToString();
            }
            
            int iError = new TestRequestReturnBLL().ApplyResult(itemEncryptCode, techCode, subjectCode, this.isProduct);
            if (iError == 0)
            {
                DataTable dt = gridControlApplied.DataSource as DataTable;
                DataTable dt1 = gridControl1.DataSource as DataTable;
                DataRow[] arrdr = dt.Select("TechCode = '" + techCode + "'");
                foreach (DataRow dr2 in arrdr)
                {
                    DataRow dr3 = dt1.NewRow();
                    foreach (DataColumn dc in dt1.Columns)
                    {
                        dr3[dc.Caption] = dr2[dc.Caption];
                    }
                    dt1.Rows.Add(dr3);
                    dt.Rows.Remove(dr2);
                }
                DataRow dr1 = dt.NewRow();
                foreach (DataColumn dc in dt.Columns)
                {
                    dr1[dc.Caption] = dr[dc.Caption];
                }
                dt.Rows.Add(dr1);
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            else
            {
                MessageBox.Show(this.GetTextMessage("Applied" + iError.ToString(), "Chọn không thành công"));
            }
        }

        private void FormApplyTestRequestResult_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gridControlApplied_Click(object sender, EventArgs e)
        {

        }

        private void gridViewApplied_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "Result")
                return;
            DataRow o = gridViewApplied.GetDataRow(e.RowHandle);
            if (o == null)
                return;
            string techCode = o["TechCode"].ToString();
            TechnicalTest tt = this.lst.Search("TechCode", techCode);
            if (tt != null)
            {
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtDecimal;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtString;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtPercent;
                }
            }
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "Result")
                return;
            DataRow o = gridView1.GetDataRow(e.RowHandle);
            if (o == null)
                return;
            string techCode = o["TechCode"].ToString();
            TechnicalTest tt = this.lst.Search("TechCode", techCode);
            if (tt != null)
            {
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtDecimal1;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtString1;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtPercent1;
                }
            }
        }

        private void gridView2_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "Result")
                return;
            DataRow o = gridView2.GetDataRow(e.RowHandle);
            if (o == null)
                return;
            string techCode = o["TechCode"].ToString();
            TechnicalTest tt = this.lst.Search("TechCode", techCode);
            if (tt != null)
            {
                if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtDecimal2;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtString2;
                }
                if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                {
                    if (("Result").Contains(e.Column.FieldName) && e.Column.Caption != string.Empty)
                        e.RepositoryItem = repTxtPercent2;
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

