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
    public partial class FormEditProductTestRequestDetail : VNS.Windows.Forms.FormBase
    {
        ProductTestEncryptCodeBLL bll = new ProductTestEncryptCodeBLL();
        DataSet dsAllEncryptCode = null;
        DataSet dsSelectEncryptCode = null;
        private DataTable dtRequestDetail = null;
        private DataTable mainDataSourceDetail = null;
        public DataTable MainDataSourceDetail
        {
            get
            {
                return this.mainDataSourceDetail;
            }
            set
            {
                this.mainDataSourceDetail = value;
                if (value != null)
                {
                    this.dsSelectEncryptCode = this.dsAllEncryptCode.Clone();
                    foreach (DataRow dr in value.Rows)
                    {
                        string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                        DataRow[] searchResult = this.dsSelectEncryptCode.Tables[0].Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                        if (searchResult.Length == 0)
                        {
                            DataRow dr1 = this.dsSelectEncryptCode.Tables[0].NewRow();
                            foreach (DataColumn dc in this.dsSelectEncryptCode.Tables[0].Columns)
                            {
                                dr1[dc.Caption] = dr[dc.Caption];
                            }
                            this.dsSelectEncryptCode.Tables[0].Rows.Add(dr1);
                        }
                        DataRow dr2 = this.dsSelectEncryptCode.Tables[1].NewRow();
                        dr2["ItemEncryptCode"] = dr["ItemEncryptCode"];
                        dr2["SubjectCode"] = dr["SubjectCode"];
                        dr2["SubjectName"] = dr["Subjectname"];
                        dr2["TechCode"] = dr["TechCode"];
                        dr2["TechName"] = dr["TechName"];
                        this.dsSelectEncryptCode.Tables[1].Rows.Add(dr2);
                    }
                }
            }
        }
        public FormEditProductTestRequestDetail()
        {
            InitializeComponent();
        }
        public FormEditProductTestRequestDetail(ref DataTable mainDataSourceDetail)
        {
            InitializeComponent();
            lookUpPeriod.Properties.DataSource = new PeriodBLL().GetAll();
            lookUpPeriod.EditValue = Contexts.WorkingPeriod.PeriodCode;
            ListBase<Subject> lst = new SubjectBLL().GetTTPT();
            lookUpDVPT.Properties.DataSource = lst;
            ListBase<Subject> lst1 = new ListBase<Subject>();
            foreach (Subject s in lst) 
            {
                lst1.Add(s.Clone() as Subject);
            }
            repoLookUpDVPT.DataSource = lst1;

            ListBase<TechnicalTest> lstTech = new TechnicalTestBLL().GetAll();
            ListBase<TechnicalTest> lstTech1 = new ListBase<TechnicalTest>();
            foreach (TechnicalTest tt in lstTech)
            {
                lstTech1.Add(tt.Clone() as TechnicalTest);
            }
            repLookUpTechCode.DataSource = lstTech1;
            this.gridCtrlTechnicalTest.DataSource = lstTech;
            this.MainDataSourceDetail = mainDataSourceDetail;
            this.gridCtrSelectEncryptCode.DataSource = this.dsSelectEncryptCode.Tables[0];
            this.btnSelectTechCode.Enabled = this.dsSelectEncryptCode.Tables[0].Rows.Count > 0;
            this.repBtnEditItemEncryptCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditItemEncryptCode_ButtonClick);
            //this.repBtnEditEncryptCode2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(repBtnEditEncryptCode2_ButtonClick);
        }

        void repBtnEditItemEncryptCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Thêm mã
            if (e.Button.Caption == this.repBtnEditItemEncryptCode.Buttons[0].Caption)
            {
                CurrencyManager cr = this.BindingContext[this.gridCtrlAllEncryptCode.DataSource] as CurrencyManager;
                if (cr != null && cr.Count > 0)
                {
                    DataRowView dr = cr.Current as DataRowView;
                    ProductTestEncryptCode ptec = new ProductTestEncryptCode();
                    ptec.StockCode = dr["StockCode"].ToString();
                    ptec.ManuDate = Convert.ToDateTime(dr["ManuDate"]);
                    ptec.Shift = Convert.ToByte(dr["Shift"]);
                    ptec.ProductCode = dr["ProductCode"].ToString();
                    ptec.SizeCode = dr["SizeCode"].ToString();
                    ptec.FormulaCode = dr["FormulaCode"].ToString();
                    ptec.Lot = dr["Lot"].ToString();
                    FormEditProductEncryptCode f = new FormEditProductEncryptCode(VNS.Windows.FormEditMode.ADD, ref ptec);
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        DataRow dr1 = this.dsAllEncryptCode.Tables[0].NewRow();
                        dr1["StockCode"] = ptec.StockCode;
                        dr1["StockName"] = dr["StockName"];
                        dr1["ManuDate"] = ptec.ManuDate;
                        dr1["Shift"] = ptec.Shift;
                        dr1["ProductCode"] = ptec.ProductCode;
                        dr1["SizeCode"] = ptec.SizeCode;
                        dr1["FormulaCode"] = ptec.FormulaCode;
                        dr1["Lot"] = ptec.Lot;
                        dr1["ItemEncryptCode"] = ptec.ItemEncryptCode;
                        this.dsAllEncryptCode.Tables[0].Rows.Add(dr1);
                    }
                }
            }
            //Sửa mã
            if (e.Button.Caption == this.repBtnEditItemEncryptCode.Buttons[1].Caption)
            {
                CurrencyManager cr = this.BindingContext[this.gridCtrlAllEncryptCode.DataSource] as CurrencyManager;
                if (cr != null && cr.Count > 0)
                {
                    DataRowView dr = cr.Current as DataRowView;
                    string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                    ListBase<ProductTestEncryptCode> lstptec = this.bll.GetDynamic("ItemEncryptCode = '" + itemEncryptCode + "'", "");
                    if (lstptec.Count == 0)
                    {
                        MessageBox.Show(this.GetTextMessage("DELETEEncryptCode-1", "Mã mẫu đã bị xóa!"));
                        dr["ItemEncryptCode"] = string.Empty;
                        return;
                    }
                    ProductTestEncryptCode ptec = lstptec[0];

                    FormEditProductEncryptCode f = new FormEditProductEncryptCode(VNS.Windows.FormEditMode.EDIT, ref ptec);
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        dr["ItemEncryptCode"] = ptec.ItemEncryptCode;
                    }
                }
            }
            //Xóa mã
            if (e.Button.Caption == this.repBtnEditItemEncryptCode.Buttons[2].Caption)
            {
                CurrencyManager cr = this.BindingContext[this.gridCtrlAllEncryptCode.DataSource] as CurrencyManager;
                if (cr != null && cr.Count > 0)
                {
                    DataRowView dr = cr.Current as DataRowView;
                    if (MessageBox.Show(this.GetTextMessage("DELETEEncryptCodeConfirm", "Bạn có đồng ý xóa mã mẫu?"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                        int iError = this.bll.DeleteByItemEncryptCode(itemEncryptCode);
                        if (iError == 0)
                        {
                            this.gridViewAllEncryptCode.DeleteRow(gridViewAllEncryptCode.FocusedRowHandle);
                        }
                        else
                        {
                            MessageBox.Show(this.GetTextMessage("DELETEEncryptCode" + iError.ToString(), "Xóa không thành công!"));
                        }
                    }
                }
            }
        }
        private void RefeshListAllEncriptCode()
        {
            Period p = (lookUpPeriod.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpPeriod.EditValue.ToString());
            this.dsAllEncryptCode = this.bll.GetByManuDate(p.StartDate, p.EndDate);
            this.dtRequestDetail = this.dsAllEncryptCode.Tables[1].Clone();
            this.gridCtrRequestDetail.DataSource = this.dtRequestDetail;
            //this.dsAllEncryptCode.Relations.Add("Detail", this.dsAllEncryptCode.Tables[0].Columns["ItemEncryptCode"], this.dsAllEncryptCode.Tables[1].Columns["ItemEncryptCode"]);
            this.gridCtrlAllEncryptCode.DataSource = dsAllEncryptCode.Tables[0];
            this.gridCtrlAllEncryptCode.RefreshDataSource();
            this.gridCtrlAllEncryptCode.Refresh();
            this.gridViewAllEncryptCode.RefreshData();
        }

        private void lookUpPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null)
            {
                this.RefeshListAllEncriptCode();
                this.RefreshRequestDetail();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lookUpPeriod.EditValue != null)
            {
                this.RefeshListAllEncriptCode();
                this.RefreshRequestDetail();
            }
        }
        private void RefreshRequestDetail()
        {
            if (gridCtrSelectEncryptCode.DataSource != null)
            {
                CurrencyManager cr = this.BindingContext[gridCtrSelectEncryptCode.DataSource] as CurrencyManager;
                if (cr != null && cr.Count > 0)
                {
                    DataRowView dr = cr.Current as DataRowView;
                    this.dtRequestDetail.Rows.Clear();
                    string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                    DataRow[] selectResult = this.dsSelectEncryptCode.Tables[1].Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                    foreach (DataRow dr1 in selectResult)
                    {
                        DataRow dr2 = this.dtRequestDetail.NewRow();
                        foreach (DataColumn dc in this.dtRequestDetail.Columns)
                        {
                            dr2[dc.Caption] = dr1[dc.Caption];
                        }
                        this.dtRequestDetail.Rows.Add(dr2);
                    }
                    this.gridCtrRequestDetail.RefreshDataSource();
                    this.gridCtrRequestDetail.Refresh();
                }
            }
        }

        private void gridViewSelectEncryptCode_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.RefreshRequestDetail();
        }

        private void btnSelectEncryptCode_Click(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridCtrlAllEncryptCode.DataSource] as CurrencyManager;
            if (cr != null && cr.Count > 0)
            {
                DataRowView dr = cr.Current as DataRowView;
                //if (dr["ItemEncryptCode"] is DBNull)
                //{
                //    MessageBox.Show(this.GetTextMessage("", "Phiếu kiểm này chưa được tạo mã mẫu, không thể gửi yêu cầu phân tích!"));
                //    return;
                //}
                string encryptCode = dr["ItemEncryptCode"].ToString();
                DataRow[] selectResult = this.dsSelectEncryptCode.Tables[0].Select("ItemEncryptCode = '" + encryptCode + "'");
                if (selectResult.Length > 0)
                {
                    MessageBox.Show(this.GetTextMessage("ItemEncryptCodeIsExists", "Mã mẫu đã được chọn!"));
                    return;
                }
                DataRow dr1 = this.dsSelectEncryptCode.Tables[0].NewRow();
                foreach (DataColumn dc in this.dsSelectEncryptCode.Tables[0].Columns)
                {
                    dr1[dc.Caption] = dr[dc.Caption];
                }
                this.dsSelectEncryptCode.Tables[0].Rows.Add(dr1);
                this.btnSelectTechCode.Enabled = true;
                this.gridViewSelectEncryptCode.RefreshData();
                this.gridCtrSelectEncryptCode.RefreshDataSource();
                this.gridCtrSelectEncryptCode.Refresh();
            }
        }

        private void btnSelectTechCode_Click(object sender, EventArgs e)
        {
            string subjectCode = string.Empty;
            string subjectName = string.Empty;
            if (lookUpDVPT.EditValue != null)
            {
                subjectCode = lookUpDVPT.EditValue.ToString();
                subjectName = lookUpDVPT.GetColumnValue("SubjectName").ToString();
            }
            else
            {
                MessageBox.Show(this.GetTextMessage("SubjectCodeIsNull", "Bạn chưa chọn nơi gửi đi phân tích!"));
                return;
            }
            string itemEncryptCode = string.Empty;
            CurrencyManager cr1 = this.BindingContext[this.gridCtrSelectEncryptCode.DataSource] as CurrencyManager;
            if (cr1 != null && cr1.Count > 0)
            {
                DataRowView dr1 = cr1.Current as DataRowView;
                itemEncryptCode = dr1["ItemEncryptCode"].ToString();
            }
            CurrencyManager cr = this.BindingContext[this.gridCtrlTechnicalTest.DataSource] as CurrencyManager;
            if (cr != null && cr.Count > 0)
            {
                TechnicalTest tt = cr.Current as TechnicalTest;
                string techCode = tt.TechCode;
                string filter = "ItemEncryptCode = '" + itemEncryptCode + "' and TechCode = '" + techCode + "'";
                filter = filter + " and SubjectCode = '" + subjectCode + "'";
                DataRow[] selectResult = this.dtRequestDetail.Select(filter);
                if (selectResult.Length > 0)
                {
                    MessageBox.Show(this.GetTextMessage("SubjectCodeTechCodeIsExists", "Chỉ tiêu tương ứng với đơn vị phân tích đã tồn tại!"));
                }
                else
                {
                    DataRow dr2 = this.dtRequestDetail.NewRow();
                    dr2["ItemEncryptCode"] = itemEncryptCode;
                    dr2["SubjectCode"] = subjectCode;
                    dr2["SubjectName"] = subjectName;
                    dr2["TechCode"] = techCode;
                    dr2["TechName"] = tt.TechName;
                    this.dtRequestDetail.Rows.Add(dr2);

                    DataRow dr3 = this.dsSelectEncryptCode.Tables[1].NewRow();
                    dr3["ItemEncryptCode"] = itemEncryptCode;
                    dr3["SubjectCode"] = subjectCode;
                    dr3["SubjectName"] = subjectName;
                    dr3["TechCode"] = techCode;
                    dr3["TechName"] = tt.TechName;
                    this.dsSelectEncryptCode.Tables[1].Rows.Add(dr3);
                }
            }
        }

        private void gridViewSelectEncryptCode_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (gridViewSelectEncryptCode.RowCount > 0)
            {
                this.RefreshRequestDetail();
                this.btnSelectTechCode.Enabled = true;
            }
            else
            {
                this.btnSelectTechCode.Enabled = false;
            }
        }

        private void gridViewSelectEncryptCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridViewSelectEncryptCode.RowCount > 0)
            {
                if (e.KeyCode == Keys.Delete)
                    this.gridViewSelectEncryptCode.DeleteRow(this.gridViewSelectEncryptCode.FocusedRowHandle);
            }
            if (this.gridViewSelectEncryptCode.RowCount == 0)
            {
                this.btnSelectTechCode.Enabled = false;
            }
        }

        private void gridViewRequestDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridViewRequestDetail.RowCount > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    CurrencyManager cr = this.BindingContext[this.gridCtrRequestDetail.DataSource] as CurrencyManager;
                    if (cr != null && cr.Count > 0)
                    {
                        DataRowView dr = cr.Current as DataRowView;
                        string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                        string techCode = dr["TechCode"].ToString();
                        string subjectCode = dr["SubjectCode"].ToString();
                        string filer = "ItemEncryptCode = '" + itemEncryptCode + "' and TechCode = '" + techCode + "'";
                        filer += " and SubjectCode = '" + subjectCode + "'";
                        DataRow[] selectResult = this.dsSelectEncryptCode.Tables[1].Select(filer);
                        this.dsSelectEncryptCode.Tables[1].Rows.Remove(selectResult[0]);
                        this.gridViewRequestDetail.DeleteRow(this.gridViewRequestDetail.FocusedRowHandle);
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.MainDataSourceDetail.Rows.Clear();
            foreach (DataRow dr in this.dsSelectEncryptCode.Tables[0].Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                DataRow[] selectResult = this.dsSelectEncryptCode.Tables[1].Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                foreach (DataRow dr1 in selectResult)
                {
                    DataRow dr2 = this.MainDataSourceDetail.NewRow();
                    foreach (DataColumn dc in this.dsSelectEncryptCode.Tables[0].Columns)
                    {
                        dr2[dc.Caption] = dr[dc.Caption];
                    }
                    dr2["TechCode"] = dr1["TechCode"];
                    dr2["TechName"] = dr1["TechName"];
                    dr2["SubjectCode"] = dr1["SubjectCode"];
                    dr2["SubjectName"] = dr1["SubjectName"];
                    this.MainDataSourceDetail.Rows.Add(dr2);
                }
            }
            this.DialogResult = DialogResult.Yes;
        }

        private void FormEditProductTestRequestDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnNewItemEncryptCode_Click(object sender, EventArgs e)
        {
            ProductTestEncryptCode ptec = new ProductTestEncryptCode();
            FormProductEncryptCode f = new FormProductEncryptCode(VNS.Windows.FormEditMode.ADD, ref ptec);
            if (f.ShowDialog() == DialogResult.Yes)
            {
                DataRow dr1 = this.dsAllEncryptCode.Tables[0].NewRow();
                dr1["StockCode"] = ptec.StockCode;
                dr1["StockName"] = f.StockName;
                dr1["ManuDate"] = ptec.ManuDate;
                dr1["Shift"] = ptec.Shift;
                dr1["ProductCode"] = ptec.ProductCode;
                dr1["SizeCode"] = ptec.SizeCode;
                dr1["FormulaCode"] = ptec.FormulaCode;
                dr1["Lot"] = ptec.Lot;
                dr1["ItemEncryptCode"] = ptec.ItemEncryptCode;
                this.dsAllEncryptCode.Tables[0].Rows.Add(dr1);
            }
        }
    }
}

