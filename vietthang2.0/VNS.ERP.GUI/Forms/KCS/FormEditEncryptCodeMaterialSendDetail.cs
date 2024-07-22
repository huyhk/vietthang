using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;

namespace VNS.ERP.GUI.KCS
{
    public partial class FormEditEncryptCodeMaterialSendDetail : VNS.Windows.Forms.FormBase
    {
        private DataTable dtItemEncryptCode = null;
        private DataTable dtDetail = null;
        private DataTable dtAllDetail = null;
        private string subjectCode = string.Empty;
        private DataTable refDetail = null;
        private bool isProduct = false;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        public FormEditEncryptCodeMaterialSendDetail()
        {
            InitializeComponent();
            repLookUpTechnicalTest1.DataSource = new TechnicalTestBLL().GetAll();
        }
        public FormEditEncryptCodeMaterialSendDetail(string subjectCode)
        {
            InitializeComponent();
            repLookUpTechnicalTest1.DataSource = new TechnicalTestBLL().GetAll();
            this.SubjectCode = subjectCode;
            DataSet ds = new EncryptCodeSendBLL().GetMaterialEncryptCodeNotSend(subjectCode);
            ds.Relations.Add("Detail1", ds.Tables[0].Columns["ItemEncryptCode"], ds.Tables[1].Columns["ItemEncryptCode"]);
            ds.Relations.Add("Detail2", ds.Tables[2].Columns["ItemEncryptCode"], ds.Tables[3].Columns["ItemEncryptCode"]);
            this.dtAllDetail = ds.Tables[1];
            this.dtItemEncryptCode = ds.Tables[2];
            this.dtDetail = ds.Tables[3];
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
            this.gridControlRequest.DataSource = this.dtDetail;
        }
        public FormEditEncryptCodeMaterialSendDetail(string subjectCode, ref DataTable refDetail)
        {
            InitializeComponent();
            repLookUpTechnicalTest1.DataSource = new TechnicalTestBLL().GetAll();
            this.refDetail = refDetail;
            this.SubjectCode = subjectCode;
            DataSet ds = new EncryptCodeSendBLL().GetMaterialEncryptCodeNotSend(subjectCode);
            ds.Relations.Add("Detail1", ds.Tables[0].Columns["ItemEncryptCode"], ds.Tables[1].Columns["ItemEncryptCode"]);
            ds.Relations.Add("Detail2", ds.Tables[2].Columns["ItemEncryptCode"], ds.Tables[3].Columns["ItemEncryptCode"]);
            this.dtAllDetail = ds.Tables[1];
            this.dtItemEncryptCode = ds.Tables[2];
            this.dtDetail = ds.Tables[3];
            this.dtDetail.Columns["IsChecked"].DataType = typeof(Boolean);
            foreach (DataRow dr in refDetail.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                DataRow[] arrdr = this.dtItemEncryptCode.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                if (arrdr.Length == 0)
                {
                    DataRow dr1 = this.dtItemEncryptCode.NewRow();
                    dr1["ItemEncryptCode"] = itemEncryptCode;
                    this.dtItemEncryptCode.Rows.Add(dr1);
                    dr1 = this.dtDetail.NewRow();
                    dr1["ItemEncryptCode"] = itemEncryptCode;
                    dr1["TechCode"] = dr["TechCode"];
                    dr1["IsChecked"] = true;
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
                        dr1["IsChecked"] = true;
                        this.dtDetail.Rows.Add(dr1);
                    }
                    else
                    {
                        arrdr1[0]["IsChecked"] = true;
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
            this.gridControlRequest.DataSource = this.dtDetail;
        }
        public FormEditEncryptCodeMaterialSendDetail(string subjectCode, ref DataTable refDetail, bool isProduct)
        {
            InitializeComponent();
            this.isProduct = isProduct;
            repLookUpTechnicalTest1.DataSource = new TechnicalTestBLL().GetAll();
            this.refDetail = refDetail;
            this.SubjectCode = subjectCode;
            DataSet ds = null;
            if (isProduct)
            {
                ds = new EncryptCodeSendBLL().GetProductEncryptCodeNotSend(subjectCode);
            }
            else
            {
                ds = new EncryptCodeSendBLL().GetMaterialEncryptCodeNotSend(subjectCode);
            }
            
            ds.Relations.Add("Detail1", ds.Tables[0].Columns["ItemEncryptCode"], ds.Tables[1].Columns["ItemEncryptCode"]);
            ds.Relations.Add("Detail2", ds.Tables[2].Columns["ItemEncryptCode"], ds.Tables[3].Columns["ItemEncryptCode"]);
            this.dtAllDetail = ds.Tables[1];
            this.dtItemEncryptCode = ds.Tables[2];
            this.dtDetail = ds.Tables[3];
            this.dtDetail.Columns["IsChecked"].DataType = typeof(Boolean);
            foreach (DataRow dr in refDetail.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                DataRow[] arrdr = this.dtItemEncryptCode.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                if (arrdr.Length == 0)
                {
                    DataRow dr1 = this.dtItemEncryptCode.NewRow();
                    dr1["ItemEncryptCode"] = itemEncryptCode;
                    this.dtItemEncryptCode.Rows.Add(dr1);
                    dr1 = this.dtDetail.NewRow();
                    dr1["ItemEncryptCode"] = itemEncryptCode;
                    dr1["TechCode"] = dr["TechCode"];
                    dr1["IsChecked"] = true;
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
                        dr1["IsChecked"] = true;
                        this.dtDetail.Rows.Add(dr1);
                    }
                    else
                    {
                        arrdr1[0]["IsChecked"] = true;
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
                        dr3["IsChecked"] = false;
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
            this.gridControlRequest.DataSource = this.dtDetail;
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
                
                this.dtItemEncryptCode.Rows.Add(dr);
                DataRow[] arrdr = this.dtAllDetail.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                foreach (DataRow dr1 in arrdr)
                {
                    dr = this.dtDetail.NewRow();
                    dr["ItemEncryptCode"] = dr1["ItemEncryptCode"];
                    dr["TechCode"] = dr1["TechCode"];
                    dr["IsChecked"] = false;
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
            this.refDetail.Rows.Clear();
            foreach (DataRow dr in this.dtItemEncryptCode.Rows)
            {
                foreach (DataRow dr1 in dr.GetChildRows("Detail2"))
                {
                    if (Convert.ToBoolean(dr1["IsChecked"]) == true)
                    {
                        DataRow dr2 = this.refDetail.NewRow();
                        dr2["ItemEncryptCode"] = dr["ItemEncryptCode"];
                        dr2["TechCode"] = dr1["TechCode"];
                        this.refDetail.Rows.Add(dr2);
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
    }
}

