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

namespace VNS.ERP.GUI.KCS
{
    public partial class FormEditEncryptCodeReturnDetail : VNS.Windows.Forms.FormBase
    {
        private DataTable dtItemEncryptCode = null;
        private DataTable dtDetail = null;
        private DataTable dtAllDetail = null;
        private string subjectCode = string.Empty;
        private DataTable refProductDetail = null;
        private DataTable refMaterialDetail = null;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        public FormEditEncryptCodeReturnDetail()
        {
            InitializeComponent();
        }
        public FormEditEncryptCodeReturnDetail(string subjectCode, ref DataTable refMaterialDetail, ref DataTable refProductDetail)
        {
            InitializeComponent();
            reLookUpTechCode.DataSource = new TechnicalTestBLL().GetAll();
            this.refProductDetail = refProductDetail;
            this.refMaterialDetail = refMaterialDetail;
            this.SubjectCode = subjectCode;
            DataSet ds = new EncryptCodeReturnBLL().GetEncryptCodeNotReturn(subjectCode);
            ds.Relations.Add("Detail1", ds.Tables[0].Columns["ItemEncryptCode"], ds.Tables[1].Columns["ItemEncryptCode"]);
            ds.Relations.Add("Detail2", ds.Tables[2].Columns["ItemEncryptCode"], ds.Tables[3].Columns["ItemEncryptCode"]);
            this.dtAllDetail = ds.Tables[1];
            this.dtItemEncryptCode = ds.Tables[2];
            this.dtDetail = ds.Tables[3];
            foreach (DataRow dr in refMaterialDetail.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                DataRow[] arrdr = this.dtItemEncryptCode.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                if (arrdr.Length == 0)
                {
                    DataRow dr1 = this.dtItemEncryptCode.NewRow();
                    dr1["ItemEncryptCode"] = itemEncryptCode;
                    dr1["IsProduct"] = false;
                    this.dtItemEncryptCode.Rows.Add(dr1);
                    dr1 = this.dtDetail.NewRow();
                    dr1["ItemEncryptCode"] = itemEncryptCode;
                    dr1["TechCode"] = dr["TechCode"];
                    dr1["Result"] = dr["Result"];
                    this.dtDetail.Rows.Add(dr1);
                }
                else
                {
                    string techCode = dr["TechCode"].ToString();
                    DataRow[] arrdr1 = this.dtDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "' and TechCode = '" + techCode + "'");
                    if (arrdr1.Length == 0)
                    {
                        DataRow dr1 = this.dtDetail.NewRow();
                        dr1["ItemEncryptCode"] = itemEncryptCode;
                        dr1["TechCode"] = techCode;
                        dr1["Result"] = dr["Result"];
                        this.dtDetail.Rows.Add(dr1);
                    }
                    else
                    {
                        arrdr1[0]["Result"] = dr["Result"];
                    }
                }
                arrdr = dtAllDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                foreach (DataRow dr2 in arrdr)
                {
                    string techCode = dr2["TechCode"].ToString();
                    if (this.dtDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "' and TechCode = '" + techCode + "'").Length == 0)
                    {
                        DataRow dr3 = this.dtDetail.NewRow();
                        dr3["ItemEncryptCode"] = itemEncryptCode;
                        dr3["TechCode"] = techCode;
                        dr3["Result"] = string.Empty;
                        this.dtDetail.Rows.Add(dr3);
                    }
                }
            }
            foreach (DataRow drProduct in refProductDetail.Rows)
            {
                string itemEncryptCode = drProduct["ItemEncryptCode"].ToString();
                DataRow[] arrdr = this.dtItemEncryptCode.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                if (arrdr.Length == 0)
                {
                    DataRow dr1 = this.dtItemEncryptCode.NewRow();
                    dr1["ItemEncryptCode"] = itemEncryptCode;
                    dr1["IsProduct"] = true;
                    this.dtItemEncryptCode.Rows.Add(dr1);
                    dr1 = this.dtDetail.NewRow();
                    dr1["ItemEncryptCode"] = itemEncryptCode;
                    dr1["TechCode"] = drProduct["TechCode"];
                    dr1["Result"] = drProduct["Result"];
                    this.dtDetail.Rows.Add(dr1);
                }
                else
                {
                    string techCode = drProduct["TechCode"].ToString();
                    DataRow[] arrdr1 = this.dtDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "' and TechCode = '" + techCode + "'");
                    if (arrdr1.Length == 0)
                    {
                        DataRow dr1 = this.dtDetail.NewRow();
                        dr1["ItemEncryptCode"] = itemEncryptCode;
                        dr1["TechCode"] = techCode;
                        dr1["Result"] = drProduct["Result"];
                        this.dtDetail.Rows.Add(dr1);
                    }
                    else
                    {
                        arrdr1[0]["Result"] = drProduct["Result"];
                    }
                }
                arrdr = dtAllDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                foreach (DataRow dr2 in arrdr)
                {
                    string techCode = dr2["TechCode"].ToString();
                    if (this.dtDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "' and TechCode = '" + techCode + "'").Length == 0)
                    {
                        DataRow dr3 = this.dtDetail.NewRow();
                        dr3["ItemEncryptCode"] = itemEncryptCode;
                        dr3["TechCode"] = techCode;
                        dr3["Result"] = string.Empty;
                        this.dtDetail.Rows.Add(dr3);
                    }
                }
            }
            this.gridCtrlAllItemEncryptCode.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.btnSelectItemEncryptCode.Enabled = true;
            }
            else
            {
                this.btnSelectItemEncryptCode.Enabled = false;
            }
            this.gridCtrlSelectedItemEncryptCode.DataSource = dtItemEncryptCode;
            this.gridCtrlResult.DataSource = this.dtDetail;
        }

        private void FormEditEncryptCodeReturnDetail_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridViewSelectedItemEncryptCode_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewSelectedItemEncryptCode.FocusedRowHandle >= 0)
            {
                this.dtDetail.AcceptChanges();
                DataRow drv = gridViewSelectedItemEncryptCode.GetDataRow(gridViewSelectedItemEncryptCode.FocusedRowHandle) as DataRow;
                string itemEncryptCode = drv["ItemEncryptCode"].ToString();
                this.dtDetail.DefaultView.RowFilter = "ItemEncryptCode = '" + itemEncryptCode + "'";
            }
        }

        private void gridViewSelectedItemEncryptCode_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (gridViewSelectedItemEncryptCode.FocusedRowHandle >= 0)
            {
                this.dtDetail.AcceptChanges();
                DataRow drv = gridViewSelectedItemEncryptCode.GetDataRow(gridViewSelectedItemEncryptCode.FocusedRowHandle) as DataRow;
                string itemEncryptCode = drv["ItemEncryptCode"].ToString();
                this.dtDetail.DefaultView.RowFilter = "ItemEncryptCode = '" + itemEncryptCode + "'";
            }
            else
            {
                this.dtDetail.DefaultView.RowFilter = "ItemEncryptCode = ''";
            }
        }

        private void btnSelectItemEncryptCode_Click(object sender, EventArgs e)
        {
            if (gridViewAllItemEncryptCode.FocusedRowHandle >= 0)
            {
                DataRow drv = gridViewAllItemEncryptCode.GetDataRow(gridViewAllItemEncryptCode.FocusedRowHandle) as DataRow;
                string itemEncryptCode = drv["ItemEncryptCode"].ToString();
                if (this.dtItemEncryptCode.Select("ItemEncryptCode = '" + itemEncryptCode + "'").Length > 0)
                {
                    MessageBox.Show(this.GetTextMessage("ExistsItemEncryptCode", "Mã mẫu đã được chọn!"));
                    return;
                }
                DataRow dr = this.dtItemEncryptCode.NewRow();
                dr["ItemEncryptCode"] = itemEncryptCode;
                dr["IsProduct"] = drv["IsProduct"];
                this.dtItemEncryptCode.Rows.Add(dr);

                DataRow[] arrdr = this.dtAllDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                foreach (DataRow dr1 in arrdr)
                {
                    dr = this.dtDetail.NewRow();
                    dr["ItemEncryptCode"] = dr1["ItemEncryptCode"];
                    dr["TechCode"] = dr1["TechCode"];
                    dr["Result"] = dr1["Result"];
                    this.dtDetail.Rows.Add(dr);
                }
                this.dtDetail.AcceptChanges();
            }
        }

        private void gridViewAllItemEncryptCode_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (gridViewAllItemEncryptCode.FocusedRowHandle >= 0)
            {
                this.btnSelectItemEncryptCode.Enabled = true;
            }
            else
            {
                this.btnSelectItemEncryptCode.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.refProductDetail.Rows.Clear();
            this.refMaterialDetail.Rows.Clear();
            foreach (DataRow dr in this.dtItemEncryptCode.Rows)
            {
                if (Convert.ToBoolean(dr["IsProduct"]))
                {
                    foreach (DataRow dr1 in dr.GetChildRows("Detail2"))
                    {
                        if (dr1["Result"].ToString() != string.Empty)
                        {
                            DataRow dr2 = this.refProductDetail.NewRow();
                            dr2["ItemEncryptCode"] = dr["ItemEncryptCode"];
                            dr2["TechCode"] = dr1["TechCode"];
                            dr2["Result"] = dr1["Result"];
                            this.refProductDetail.Rows.Add(dr2);
                        }
                    }
                }
                else
                {
                    foreach (DataRow dr1 in dr.GetChildRows("Detail2"))
                    {
                        if (dr1["Result"].ToString() != string.Empty)
                        {
                            DataRow dr2 = this.refMaterialDetail.NewRow();
                            dr2["ItemEncryptCode"] = dr["ItemEncryptCode"];
                            dr2["TechCode"] = dr1["TechCode"];
                            dr2["Result"] = dr1["Result"];
                            this.refMaterialDetail.Rows.Add(dr2);
                        }
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void gridViewSelectedItemEncryptCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridViewSelectedItemEncryptCode.RowCount > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    string itemEncryptCode = gridViewSelectedItemEncryptCode.GetDataRow(gridViewSelectedItemEncryptCode.FocusedRowHandle)["ItemEncryptCode"].ToString();
                    DataRow[] arrdr = this.dtDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                    foreach (DataRow dr in arrdr)
                    {
                        this.dtDetail.Rows.Remove(dr);
                    }
                    this.gridViewSelectedItemEncryptCode.DeleteRow(this.gridViewSelectedItemEncryptCode.FocusedRowHandle);
                }
            }
            if (this.gridViewSelectedItemEncryptCode.RowCount > 0)
            {
                string itemEncryptCode = gridViewSelectedItemEncryptCode.GetDataRow(gridViewSelectedItemEncryptCode.FocusedRowHandle)["ItemEncryptCode"].ToString();
                this.dtDetail.DefaultView.RowFilter = "ItemEncryptCode = '" + itemEncryptCode + "'";
            }
            else
            {
                this.dtDetail.DefaultView.RowFilter = "ItemEncryptCode = ''";
            }
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string techCode = gridView1.GetDataRow(e.RowHandle)["TechCode"].ToString();
                TechnicalTest tt = (reLookUpTechCode.DataSource as ListBase<TechnicalTest>).Search("TechCode", techCode);
                if (tt != null)
                {
                    if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                    {
                        if (("Result").Contains(e.Column.FieldName))
                            e.RepositoryItem = repTxtDecimal;
                    }
                    if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                    {
                        if (("Result").Contains(e.Column.FieldName))
                            e.RepositoryItem = repTxtString;
                    }
                    if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                    {
                        if (("Result").Contains(e.Column.FieldName))
                            e.RepositoryItem = repTxtPercent;
                    }
                }
            }
        }
    }
}

