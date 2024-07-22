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
    public partial class FormEditProductTestTransactionDetail : VNS.Windows.Forms.FormBase
    {
        private DateTime transactionDate = Contexts.WorkingDate;
        private string stockCode = string.Empty;
        public FormEditProductTestTransactionDetail()
        {
            InitializeComponent();
            this.repTxtPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
        }
       
        public FormEditProductTestTransactionDetail(ref DataTable mainDataSourceDetail)
        {
            InitializeComponent();
            this.lookUpEditProduct.Properties.DataSource = new ProductBLL().GetAll();
            this.lookUpEditSize.Properties.DataSource = new ProductSizeBLL().GetAll();
            ListBase<ProductFormula2> lstPF = new ProductFormulaBLL2().GetAll();
            lstPF.Insert(0,new ProductFormula2());
            this.lookUpEditFormula.Properties.DataSource = lstPF;

            this.MainDataSourceDetail = mainDataSourceDetail;
        }
        public FormEditProductTestTransactionDetail(ref DataTable mainDataSourceDetail, DateTime transactionDate)
        {
            InitializeComponent();
            this.transactionDate = transactionDate;
            this.lookUpEditProduct.Properties.DataSource = new ProductBLL().GetAll();
            this.lookUpEditSize.Properties.DataSource = new ProductSizeBLL().GetAll();
            ListBase<ProductFormula2> lstPF = new ProductFormulaBLL2().GetAll();
            lstPF.Insert(0, new ProductFormula2());
            this.lookUpEditFormula.Properties.DataSource = lstPF;

            this.MainDataSourceDetail = mainDataSourceDetail;
        }
        public FormEditProductTestTransactionDetail(ref DataTable mainDataSourceDetail, DateTime transactionDate, string stockCode)
        {
            InitializeComponent();
            this.stockCode = stockCode;
            this.transactionDate = transactionDate;
            this.lookUpEditProduct.Properties.DataSource = new ProductBLL().GetAll();
            this.lookUpEditSize.Properties.DataSource = new ProductSizeBLL().GetAll();

            //tri
            this.repLookUpTechnicalTest1.DataSource = new TechnicalTestBLL().GetAll();
            //
            ListBase<ProductFormula2> lstPF = new ProductFormulaBLL2().GetAll();
            lstPF.Insert(0, new ProductFormula2());
            this.lookUpEditFormula.Properties.DataSource = lstPF;

            this.MainDataSourceDetail = mainDataSourceDetail;
        }
        DataTable dtProduct = null;
        DataTable dtItemEncryptCode = null;
        DataTable dtResult = null;
        DataTable dtRequest = null;
        private DataSet dsAllData = new DataSet();
        ListBase<TechnicalTest> lstTechnicalTest = null;
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
                this.txtNgayCodebao.DateTime = this.ngayCodeBao;
                if (value != null)
                {
                    this.dtProduct = value.Clone();
                    this.dtProduct.Columns.Remove("Lot");
                    this.dtProduct.Columns.Remove("TestTransactionID");
                    this.dtProduct.Columns.Remove("ItemEncryptCode");
                    this.dtProduct.Columns.Remove("TechCode");
                    this.dtProduct.Columns.Remove("TechName");
                    this.dtProduct.Columns.Remove("Result");
                    this.dtProduct.Columns.Remove("IsChecked");
                    this.dsAllData.Tables.Add(this.dtProduct);

                    //TestTransactionID
                    this.dtItemEncryptCode = value.Clone();
                    this.dtItemEncryptCode.TableName = "dtItemEncryptCode";
                    this.dtItemEncryptCode.Columns.Remove("TestTransactionID");
                    this.dtItemEncryptCode.Columns.Remove("TechCode");
                    this.dtItemEncryptCode.Columns.Remove("TechName");
                    this.dtItemEncryptCode.Columns.Remove("Result");
                    this.dtItemEncryptCode.Columns.Remove("IsChecked");
                    this.dsAllData.Tables.Add(this.dtItemEncryptCode.Clone());

                    this.dtResult = value.Clone();
                    this.dtResult.TableName = "dtResult";
                    this.dtResult.Columns.Remove("TestTransactionID");
                    this.dtResult.Columns.Remove("ProductCode");
                    this.dtResult.Columns.Remove("SizeCode");
                    this.dtResult.Columns.Remove("FormulaCode");
                    this.dtResult.Columns.Remove("Lot");
                    this.dtResult.Columns.Remove("NgayCodeBao");
                    this.dtResult.Columns.Remove("IsChecked");
                    this.dsAllData.Tables.Add(this.dtResult.Clone());

                    this.dtRequest = value.Clone();
                    this.dtRequest.TableName = "dtRequest";
                    this.dtRequest.Columns.Remove("TestTransactionID");
                    this.dtRequest.Columns.Remove("ProductCode");
                    this.dtRequest.Columns.Remove("SizeCode");
                    this.dtRequest.Columns.Remove("FormulaCode");
                    this.dtRequest.Columns.Remove("Lot");
                    this.dtRequest.Columns.Remove("Result");
                    this.dtRequest.Columns["IsChecked"].DataType = typeof(Boolean);
                    this.dtRequest.Columns["IsChecked"].DefaultValue = false;
                    this.dsAllData.Tables.Add(this.dtRequest.Clone());

                    foreach (DataRow dr in value.Rows)
                    {
                        DataRow dr1 = null;
                        string filter = "ProductCode = '" + dr["ProductCode"].ToString() + "'" + " and SizeCode = '" + dr["SizeCode"].ToString() + "'";
                        filter += " and FormulaCode = '" + dr["FormulaCode"].ToString() + "' and NgayCodeBao = '" + ((DateTime)dr["NgayCodeBao"]).ToShortDateString()+"'";
                        if (this.dtProduct.Select(filter).Length == 0)
                        {
                            dr1 = this.dtProduct.NewRow();
                            dr1["ProductCode"] = dr["ProductCode"];
                            dr1["SizeCode"] = dr["SizeCode"];
                            dr1["FormulaCode"] = dr["FormulaCode"];
                            dr1["NgayCodeBao"] = dr["NgayCodeBao"];
                            this.dtProduct.Rows.Add(dr1);
                        }
                        filter = "ItemEncryptCode = '" + dr["ItemEncryptCode"].ToString() + "'";
                        if (this.dsAllData.Tables[1].Select(filter).Length == 0)
                        {
                            dr1 = this.dsAllData.Tables[1].NewRow();
                            dr1["ProductCode"] = dr["ProductCode"];
                            dr1["SizeCode"] = dr["SizeCode"];
                            dr1["FormulaCode"] = dr["FormulaCode"];
                            dr1["NgayCodeBao"] = dr["NgayCodeBao"];
                            dr1["ItemEncryptCode"] = dr["ItemEncryptCode"];
                            dr1["Lot"] = dr["Lot"];
                            this.dsAllData.Tables[1].Rows.Add(dr1);
                        }
                        dr1 = this.dsAllData.Tables[2].NewRow();
                        dr1["ItemEncryptCode"] = dr["ItemEncryptCode"];
                        dr1["TechCode"] = dr["TechCode"];
                        dr1["Result"] = dr["Result"];
                        this.dsAllData.Tables[2].Rows.Add(dr1);

                        bool isChecked = Convert.ToBoolean(dr["IsChecked"]);
                        if (isChecked)
                        {
                            dr1 = this.dsAllData.Tables[3].NewRow();
                            dr1["ItemEncryptCode"] = dr["ItemEncryptCode"];
                            dr1["TechCode"] = dr["TechCode"];
                            dr1["IsChecked"] = true;
                            this.dsAllData.Tables[3].Rows.Add(dr1);
                        }
                    }
                    if (lstTechnicalTest == null)
                    {
                        lstTechnicalTest = new TechnicalTestBLL().GetAll();
                    }
                    foreach (TechnicalTest tt in lstTechnicalTest)
                    {
                        DataRow drow = null;
                        if (tt.KCSTest)
                        {
                            drow = this.dtResult.NewRow();
                            drow["TechCode"] = tt.TechCode;
                            drow["TechName"] = tt.TechName;
                            drow["Result"] = string.Empty;
                        
//-----------------------------------DisplayText ko co-----------------------------------------------------------------
                            //drow["DisplayText"] = tt.DisplayText;
                            this.dtResult.Rows.Add(drow);
                        }
                        if (tt.PTNTest)
                        {
                            drow = this.dtRequest.NewRow();
                            drow["TechCode"] = tt.TechCode;
                            drow["TechName"] = tt.TechName;
                            drow["IsChecked"] =  false;
                            this.dtRequest.Rows.Add(drow);
                        }
                    }
                    gridControlProduct.DataSource = this.dtProduct;
                    gridControlItemEncryptCode.DataSource = this.dtItemEncryptCode;

                    
                    gridControlRequest.DataSource = this.dtRequest;
                    gridControlResult.DataSource = this.dtResult;

                }
            }
        }

        private void RefreshItemEncryptCode()
        {
            DataRow dr = gridViewProduct.GetDataRow(gridViewProduct.FocusedRowHandle);
            string filter = "ProductCode = '" + dr["ProductCode"].ToString() + "'" + " and SizeCode = '" + dr["SizeCode"].ToString() + "'";
            filter += " and FormulaCode = '" + dr["FormulaCode"].ToString() + "' and NgayCodeBao = '" + ((DateTime)dr["NgayCodeBao"]).ToShortDateString() + "'";

            this.dtItemEncryptCode.Rows.Clear();
            DataRow[] arrdr = this.dsAllData.Tables[1].Select(filter);
            foreach (DataRow dr2 in arrdr)
            {
                DataRow dr1 = this.dtItemEncryptCode.NewRow();
                foreach (DataColumn dc in this.dtItemEncryptCode.Columns)
                {
                    dr1[dc.Caption] = dr2[dc.Caption];
                }
                this.dtItemEncryptCode.Rows.Add(dr1);
            }
            if (gridViewProduct.FocusedRowHandle >= 0)
            {
                DataRow dr1 = gridViewProduct.GetDataRow(gridViewProduct.FocusedRowHandle);
                this.dtItemEncryptCode.Columns["ProductCode"].DefaultValue = dr1["ProductCode"];
                this.dtItemEncryptCode.Columns["SizeCode"].DefaultValue = dr1["SizeCode"];
                this.dtItemEncryptCode.Columns["FormulaCode"].DefaultValue = dr1["FormulaCode"];
                this.dtItemEncryptCode.Columns["NgayCodeBao"].DefaultValue = dr1["NgayCodeBao"];
            }
            //this.UpdategridViewItemEncryptCodeDataForcusChanges();
            //if (this.gridViewItemEncryptCode.RowCount > 0)
            //{
            //    dr = this.gridViewItemEncryptCode.GetDataRow(this.gridViewItemEncryptCode.FocusedRowHandle);
            //    txtLot.Text = dr["Lot"].ToString();
            //    txtItemEncryptCode.Text = dr["ItemEncryptCode"].ToString();
            //    this.gridControlRequest.Enabled = true;
            //    this.gridControlResult.Enabled = true;
            //    this.RefreshRequestAndResult();
            //}
            //else
            //{
            //    txtLot.Text = "";
            //    txtItemEncryptCode.Text = "";
            //    this.gridControlRequest.Enabled = false;
            //    this.gridControlResult.Enabled = false;
            //}
        }
        private void RefreshRequestAndResult()
        {
            DataRow dr = gridViewItemEncryptCode.GetDataRow(gridViewItemEncryptCode.FocusedRowHandle);
            string filter = "ItemEncryptCode = '" + dr["ItemEncryptCode"].ToString() + "'";
            DataRow[] arrdr = this.dsAllData.Tables[2].Select(filter);
            foreach (DataRow drResult1 in this.dtResult.Rows)
            {
                drResult1["Result"] = string.Empty;
            }
            foreach (DataRow drRequest1 in this.dtRequest.Rows)
            {
                drRequest1["IsChecked"] = false;
            }
            foreach (DataRow drResult in arrdr)
            {
                string techCode = drResult["TechCode"].ToString();
                DataRow[] dr1 = this.dtResult.Select("TechCode = '" + techCode + "'");
                if (dr1.Length > 0)
                {
                    dr1[0]["Result"] = drResult["Result"];
                }
            }
            arrdr = this.dsAllData.Tables[3].Select(filter);
            foreach (DataRow drRequest in arrdr)
            {
                string techCode = drRequest["TechCode"].ToString();
                DataRow[] dr1 = this.dtRequest.Select("TechCode = '" + techCode + "'");
                if (dr1.Length > 0)
                {
                    dr1[0]["IsChecked"] = true;
                }
            }
        }
        private string productCode = string.Empty;
        private string sizeCode = string.Empty;
        private string formulaCode = string.Empty;
        private DateTime ngayCodeBao = DateTime.Today;
        private void gridViewProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.UpdateGridViewProductDataForcusChanges();
        }

        private void UpdateGridViewProductDataForcusChanges()
        {
            if (gridViewProduct.FocusedRowHandle >= 0)
            {
                DataRow dr = gridViewProduct.GetDataRow(gridViewProduct.FocusedRowHandle);
                lookUpEditProduct.EditValue = dr["ProductCode"].ToString();
                this.productCode = dr["ProductCode"].ToString();
                lookUpEditSize.EditValue = dr["SizeCode"].ToString();
                this.sizeCode = dr["SizeCode"].ToString();
                lookUpEditFormula.EditValue = dr["FormulaCode"].ToString();
                this.formulaCode = dr["FormulaCode"].ToString();
                txtNgayCodebao.DateTime = (DateTime)dr["NgayCodeBao"];
                this.ngayCodeBao = txtNgayCodebao.DateTime;
                this.RefreshItemEncryptCode();
                this.btnAddItemEncryptCode.Enabled = true;
                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = true;
                this.UpdategridViewItemEncryptCodeDataForcusChanges();
            }
            else
            {
                this.dtItemEncryptCode.Rows.Clear();
                this.gridControlRequest.Enabled = false;
                this.gridControlResult.Enabled = false;
                this.btnAdd.Enabled = false;
                this.btnUpdate.Enabled = false;
                this.btnAddItemEncryptCode.Enabled = false;
            }
        }

        private void gridViewProduct_ColumnFilterChanged(object sender, EventArgs e)
        {
            this.UpdateGridViewProductDataForcusChanges();
        }

        private void gridViewItemEncryptCode_ColumnFilterChanged(object sender, EventArgs e)
        {
            this.UpdategridViewItemEncryptCodeDataForcusChanges();
        }
        private string lot = string.Empty;
        private string itemEncryptCode = string.Empty;
        private void UpdategridViewItemEncryptCodeDataForcusChanges()
        {
            this.gridViewProduct.CloseEditor();
            this.gridViewRequest.CloseEditor();
            if (gridViewItemEncryptCode.FocusedRowHandle >= 0)
            {
                DataRow dr = gridViewItemEncryptCode.GetDataRow(gridViewItemEncryptCode.FocusedRowHandle);
                //txtLot.Text = dr["Lot"].ToString();
                this.lot = dr["Lot"].ToString();
                //txtItemEncryptCode.Text = dr["ItemEncryptCode"].ToString();
                this.itemEncryptCode = dr["ItemEncryptCode"].ToString();
                this.gridControlRequest.Enabled = true;
                this.gridControlResult.Enabled = true;
                this.btnUpdateItemEncryptCode.Enabled = true;
                this.RefreshRequestAndResult();
            }
            else
            {
                txtLot.Text = "";
                txtItemEncryptCode.Text = "";
                this.lot = string.Empty;
                this.itemEncryptCode = string.Empty;
                this.gridControlRequest.Enabled = false;
                this.gridControlResult.Enabled = false;
                this.btnUpdateItemEncryptCode.Enabled = false;
            }
        }

        private void gridViewItemEncryptCode_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.UpdategridViewItemEncryptCodeDataForcusChanges();
        }
        private void UpdateResult()
        {
            //DataRow dr2 = gridViewItemEncryptCode.GetDataRow(gridViewItemEncryptCode.FocusedRowHandle);
            //string itemEncryptCode = dr2["ItemEncryptCode"].ToString();
            string filer = "ItemEncryptCode = '" + this.itemEncryptCode + "'";
            DataRow[] arrdr = this.dsAllData.Tables[2].Select(filer);
            foreach (DataRow dr3 in arrdr)
            {
                this.dsAllData.Tables[2].Rows.Remove(dr3);
            }

            foreach (DataRow dr in this.dtResult.Rows)
            {
                dr["ItemEncryptCode"] = this.itemEncryptCode;
                if (dr["Result"].ToString().Trim() != string.Empty && dr["Result"].ToString().Trim() != "0")
                {
                    DataRow dr1 = this.dsAllData.Tables[2].NewRow();
                    foreach (DataColumn dc in this.dtResult.Columns)
                    {
                        dr1[dc.Caption] = dr[dc.Caption];
                        if (dr1.IsNull(dc.Caption))
                        {
                            dr1[dc.Caption] = string.Empty;
                        }
                    }
                    this.dsAllData.Tables[2].Rows.Add(dr1);
                }
            }
        }
        public void UpdateRequest()
        {
            //string itemEncryptCode = string.Empty;
            //if (gridViewItemEncryptCode.FocusedRowHandle >= 0)
            //{
            //    DataRow dr2 = gridViewItemEncryptCode.GetDataRow(gridViewItemEncryptCode.FocusedRowHandle);
            //    itemEncryptCode = dr2["ItemEncryptCode"].ToString();
            //}
            string filer = "ItemEncryptCode = '" + this.itemEncryptCode + "'";
            DataRow[] arrdr = this.dsAllData.Tables[3].Select(filer);
            foreach (DataRow dr3 in arrdr)
            {
                this.dsAllData.Tables[3].Rows.Remove(dr3);
            }

            foreach (DataRow dr in this.dtRequest.Rows)
            {
                dr["ItemEncryptCode"] = this.itemEncryptCode;
                if(Convert.ToBoolean(dr["IsChecked"]) == true)
                {
                    DataRow dr1 = this.dsAllData.Tables[3].NewRow();
                    foreach (DataColumn dc in this.dtRequest.Columns)
                    {
                        dr1[dc.Caption] = dr[dc.Caption];
                    }
                    this.dsAllData.Tables[3].Rows.Add(dr1);
                }
            }
        }
      
        private void gridViewResult_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            this.UpdateResult();
        }

        private void gridControlResult_Validating(object sender, CancelEventArgs e)
        {
            this.gridViewResult.CloseEditor();
            this.UpdateResult();
        }

        private void gridViewRequest_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            this.UpdateRequest();
        }

        private void gridControlRequest_Validating(object sender, CancelEventArgs e)
        {
            this.gridViewRequest.CloseEditor();
            this.UpdateRequest();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lookUpEditProduct.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("ProductNullError", "Bạn chưa chọn thành phẩm!"));
                return;
            }
            if (this.lookUpEditSize.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("SizeCodeNullError", "Bạn chưa chọn mã kích cỡ!"));
                return;
            }
            string formulaCode = string.Empty;
            if (this.lookUpEditFormula.EditValue != null)
            {
                formulaCode = lookUpEditFormula.EditValue.ToString();
            }
            string productCode = lookUpEditProduct.EditValue.ToString();
            string sizeCode = lookUpEditSize.EditValue.ToString();
            DateTime ngayCodebao = txtNgayCodebao.DateTime;
            string filter = "ProductCode = '" + productCode + "' and SizeCode = '" + sizeCode + "' and FormulaCode = '" + formulaCode + "' and NgayCodeBao = '" + ngayCodebao.ToShortDateString() + "'";
            if (this.dtProduct.Select(filter).Length > 0)
            {
                MessageBox.Show(this.GetTextMessage("ProductIsExists", "Thành phẩm, kích thước, công thức và ngày code bao đã tồn tại!"));
                return;
            }
            DataRow dr = this.dtProduct.NewRow();
            dr["ProductCode"] = productCode;
            dr["SizeCode"] = sizeCode;
            dr["FormulaCode"] = formulaCode;
            dr["NgayCodeBao"] = ngayCodebao;
            this.productCode = productCode;
            this.sizeCode = sizeCode;
            this.formulaCode = formulaCode;
            this.ngayCodeBao = ngayCodebao;
            this.dtProduct.Rows.Add(dr);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void AddItemEncryptCode()
        {
            txtLot.Text = txtLot.Text.Trim();
            //txtItemEncryptCode.Text = txtItemEncryptCode.Text.Trim();
            this.BuildItemEncryptCode();
            if (txtItemEncryptCode.Text == string.Empty)
            {
                MessageBox.Show(this.GetTextMessage("ItemEnryptCodeNullError", "Bạn chưa nhập mã mẫu!"));
                return;
            }
            string filter = "ItemEncryptCode = '" + txtItemEncryptCode.Text + "'";
            if (this.dsAllData.Tables[1].Select(filter).Length > 0)
            {
                MessageBox.Show(this.GetTextMessage("ItemEnryptCodeIsExist", "Mã mẫu đã tồn tại!"));
                return;
            }
            DataRow dr = this.dtItemEncryptCode.NewRow();
            dr["Lot"] = txtLot.Text;
            dr["ItemEncryptCode"] = txtItemEncryptCode.Text;
            dr["ProductCode"] = this.productCode;
            dr["SizeCode"] = this.sizeCode;
            dr["FormulaCode"] = this.formulaCode;
            dr["NgayCodeBao"] = this.ngayCodeBao;
            this.dtItemEncryptCode.Rows.Add(dr);

            dr = this.dsAllData.Tables[1].NewRow();
            dr["Lot"] = txtLot.Text;
            dr["ItemEncryptCode"] = txtItemEncryptCode.Text;
            dr["ProductCode"] = this.productCode;
            dr["SizeCode"] = this.sizeCode;
            dr["FormulaCode"] = this.formulaCode;
            dr["NgayCodeBao"] = this.ngayCodeBao;
            this.dsAllData.Tables[1].Rows.Add(dr);
            this.itemEncryptCode = txtItemEncryptCode.Text;
            this.lot = txtLot.Text;
            txtLot.Text = string.Empty;

            //
            foreach (DataRow row in this.dtRequest.Rows)
            {
                row["ItemEncryptCode"] = this.itemEncryptCode;
                //if (Convert.ToBoolean(dr["IsChecked"]) == true)
                //{
                    DataRow dr1 = this.dsAllData.Tables[3].NewRow();
                    foreach (DataColumn dc in this.dtRequest.Columns)
                    {
                        dr1[dc.Caption] = row[dc.Caption];
                    }
                    dr1["IsChecked"] = true;
                    this.dsAllData.Tables[3].Rows.Add(dr1);
                //}
            }
            //
            //gridControlResult.Focus();
        }
        private void btnAddItemEncryptCode_Click(object sender, EventArgs e)
        {
            AddItemEncryptCode();
        }

        private void DeleteRequestAndResult(string itemEncryptCode)
        {
            string filer = "ItemEncryptCode = '" + itemEncryptCode + "'";
            DataRow[] arrdr = this.dsAllData.Tables[3].Select(filer);
            foreach (DataRow dr in arrdr)
            {
                this.dsAllData.Tables[3].Rows.Remove(dr);
            }

            arrdr = this.dsAllData.Tables[2].Select(filer);
            foreach (DataRow dr in arrdr)
            {
                this.dsAllData.Tables[2].Rows.Remove(dr);
            }
        }
        
        private void gridViewItemEncryptCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridViewItemEncryptCode.RowCount > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DataRow dr = this.gridViewItemEncryptCode.GetDataRow(this.gridViewItemEncryptCode.FocusedRowHandle);
                    string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                    DataRow[] arrdr = this.dsAllData.Tables[1].Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                    this.dsAllData.Tables[1].Rows.Remove(arrdr[0]);
                    this.DeleteRequestAndResult(itemEncryptCode);

                    this.gridViewItemEncryptCode.DeleteRow(this.gridViewItemEncryptCode.FocusedRowHandle);

                    if (this.gridViewItemEncryptCode.RowCount > 0)
                    {
                        dr = this.gridViewItemEncryptCode.GetDataRow(this.gridViewItemEncryptCode.FocusedRowHandle);
                        txtLot.Text = dr["Lot"].ToString();
                        txtItemEncryptCode.Text = dr["ItemEncryptCode"].ToString();
                        this.RefreshRequestAndResult();
                    }
                    else
                    {
                        txtLot.Text = "";
                        txtItemEncryptCode.Text = "";
                    }
                }
            }
        }

        private void gridViewProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.gridViewProduct.RowCount > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DataRow dr = this.gridViewProduct.GetDataRow(this.gridViewProduct.FocusedRowHandle);
                    string productCode = dr["ProductCode"].ToString();
                    string sizeCode = dr["SizeCode"].ToString();
                    string formulaCode = dr["FormulaCode"].ToString();

                    DataRow[] arrdr = this.dsAllData.Tables[1].Select("ProductCode = '" + productCode + "' and SizeCode = '" + sizeCode + "' and FormulaCode = '" + formulaCode + "'");
                    foreach (DataRow dr1 in arrdr)
                    {
                        string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                        this.dsAllData.Tables[1].Rows.Remove(dr1);
                        this.DeleteRequestAndResult(itemEncryptCode);
                    }

                    this.gridViewProduct.DeleteRow(this.gridViewProduct.FocusedRowHandle);

                    if (this.gridViewProduct.RowCount > 0)
                    {
                        this.RefreshItemEncryptCode();
                    }
                    else
                    {
                        this.dtItemEncryptCode.Rows.Clear();
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (DataRow drCheckOK in this.dtProduct.Rows)
            {
                string filter = "ProductCode = '" + drCheckOK["ProductCode"].ToString() + "'";
                filter += " and SizeCode = '" + drCheckOK["SizeCode"].ToString() + "'";
                filter += " and FormulaCode = '" + drCheckOK["FormulaCode"].ToString() + "'";
                DataRow[] arrdr = this.dsAllData.Tables[1].Select(filter);
                if (arrdr.Length == 0)
                {
                    MessageBox.Show(this.GetTextMessage("ItemEncrypCodeNotExistError", "Ứng với mỗi thành phẩm, kích thước, công thức phải có ít nhất một mã mẫu!"));
                    return;
                }
            }
            this.mainDataSourceDetail.Rows.Clear();
            DataRelation drResult = this.dsAllData.Relations.Add("Result", this.dsAllData.Tables[1].Columns["ItemEncryptCode"], this.dsAllData.Tables[2].Columns["ItemEncryptCode"]);
            DataRelation drRequest = this.dsAllData.Relations.Add("Request", this.dsAllData.Tables[1].Columns["ItemEncryptCode"], this.dsAllData.Tables[3].Columns["ItemEncryptCode"]);
            foreach (DataRow dr in this.dtProduct.Rows)
            {
                string filter = "ProductCode = '" + dr["ProductCode"].ToString() + "'";
                filter += " and SizeCode = '" + dr["SizeCode"].ToString() + "'";
                filter += " and FormulaCode = '" + dr["FormulaCode"].ToString() + "' and NgayCodeBao = '"
                    + ((DateTime)dr["NgayCodeBao"]).ToShortDateString()+"'";
                DataRow[] arrdr = this.dsAllData.Tables[1].Select(filter);
                foreach (DataRow dr1 in arrdr)
                {
                    bool added = false;
                    foreach (DataRow dr2 in dr1.GetChildRows(drResult))
                    {
                        DataRow drMain = this.mainDataSourceDetail.NewRow();
                        drMain["ProductCode"] = dr["ProductCode"];
                        drMain["SizeCode"] = dr["SizeCode"];
                        drMain["FormulaCode"] = dr["FormulaCode"];
                        drMain["NgayCodeBao"] = dr["NgayCodeBao"];
                        drMain["Lot"] = dr1["Lot"];
                        drMain["ItemEncryptCode"] = dr1["ItemEncryptCode"];
                        drMain["TechCode"] = dr2["TechCode"];
                        drMain["TechName"] = dr2["TechName"];
                        drMain["Result"] = dr2["Result"];
                        drMain["IsChecked"] = false;
                        this.mainDataSourceDetail.Rows.Add(drMain);
                        added = true;
                    }
                    foreach (DataRow dr3 in dr1.GetChildRows(drRequest))
                    {
                        string filter1 = "ProductCode = '" + dr["ProductCode"].ToString() + "'";
                        filter1 += " and SizeCode = '" + dr["SizeCode"].ToString() + "'";
                        filter1 += " and FormulaCode = '" + dr["FormulaCode"].ToString() + "'";
                        filter1 += " and ItemEncryptCode = '" + dr1["ItemEncryptCode"].ToString() + "'";
                        filter1 += " and TechCode = '" + dr3["TechCode"].ToString() + "'";
                        DataRow[] arrdr1 = this.mainDataSourceDetail.Select(filter1);
                        if (arrdr1.Length > 0)
                        {
                            arrdr1[0]["IsChecked"] = true;
                            added = true;
                        }
                        else
                        {
                            DataRow drMain = this.mainDataSourceDetail.NewRow();
                            drMain["ProductCode"] = dr["ProductCode"];
                            drMain["SizeCode"] = dr["SizeCode"];
                            drMain["FormulaCode"] = dr["FormulaCode"];
                            drMain["NgayCodeBao"] = dr["NgayCodeBao"];
                            drMain["Lot"] = dr1["Lot"];
                            drMain["ItemEncryptCode"] = dr1["ItemEncryptCode"];
                            drMain["TechCode"] = dr3["TechCode"];
                            drMain["TechName"] = dr3["TechName"];
                            drMain["Result"] = string.Empty;
                            drMain["IsChecked"] = true;
                            this.mainDataSourceDetail.Rows.Add(drMain);
                            added = true;
                        }
                    }
                    if (!added)
                    {
                        DataRow drMain = this.mainDataSourceDetail.NewRow();
                        drMain["ProductCode"] = dr["ProductCode"];
                        drMain["SizeCode"] = dr["SizeCode"];
                        drMain["FormulaCode"] = dr["FormulaCode"];
                        drMain["NgayCodeBao"] = dr["NgayCodeBao"];
                        drMain["Lot"] = dr1["Lot"];
                        drMain["ItemEncryptCode"] = dr1["ItemEncryptCode"];
                        drMain["TechCode"] = string.Empty;
                        drMain["TechName"] = string.Empty;
                        drMain["Result"] = string.Empty;
                        drMain["IsChecked"] = false;
                        this.mainDataSourceDetail.Rows.Add(drMain);
                    }
                }
            }
            this.DialogResult = DialogResult.Yes;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridViewProduct.FocusedRowHandle >= 0)
            {
                DataRow dr = this.gridViewProduct.GetDataRow(gridViewProduct.FocusedRowHandle);
                string productCode = dr["ProductCode"].ToString();
                string sizeCode = dr["SizeCode"].ToString();
                string formulaCode = dr["FormulaCode"].ToString();

                if (lookUpEditProduct.EditValue == null)
                {
                    MessageBox.Show(this.GetTextMessage("ProductNullError", "Bạn chưa chọn thành phẩm!"));
                    return;
                }
                if (this.lookUpEditSize.EditValue == null)
                {
                    MessageBox.Show(this.GetTextMessage("SizeCodeNullError", "Bạn chưa chọn mã kích cỡ!"));
                    return;
                }
                string formulaCode1 = string.Empty;
                if (this.lookUpEditFormula.EditValue != null)
                {
                    formulaCode1 = lookUpEditFormula.EditValue.ToString();
                }
                string productCode1 = lookUpEditProduct.EditValue.ToString();
                string sizeCode1 = lookUpEditSize.EditValue.ToString();
                DateTime ngayCodeBao1 = this.txtNgayCodebao.DateTime;
                string filter = "ProductCode = '" + productCode1 + "' and SizeCode = '" + sizeCode1 + "' and FormulaCode = '" + formulaCode1 + "'";
                if (this.dtProduct.Select(filter).Length > 0)
                {
                    if (productCode != productCode1 || sizeCode != sizeCode1 || formulaCode != formulaCode1)
                    {
                        MessageBox.Show(this.GetTextMessage("ProductIsExists", "Thành phẩm, kích thước, và công thức đã tồn tại!"));
                        return;
                    }
                }
                dr["ProductCode"] = productCode1;
                dr["SizeCode"] = sizeCode1;
                dr["FormulaCode"] = formulaCode1;
                dr["NgayCodeBao"] = ngayCodeBao1;
                foreach (DataRow dr1 in this.dtItemEncryptCode.Rows)
                {
                    dr1["ProductCode"] = productCode1;
                    dr1["SizeCode"] = sizeCode1;
                    dr1["FormulaCode"] = formulaCode1;
                    dr1["NgayCodeBao"] = ngayCodeBao1;
                }
                filter = "ProductCode = '" + productCode + "' and SizeCode = '" + sizeCode + "' and FormulaCode = '" + formulaCode + "'";
                DataRow[] arrdr1 = this.dsAllData.Tables[1].Select(filter);
                foreach (DataRow dr2 in arrdr1)
                {
                    dr2["ProductCode"] = productCode1;
                    dr2["SizeCode"] = sizeCode1;
                    dr2["FormulaCode"] = formulaCode1;
                    dr2["NgayCodeBao"] = ngayCodeBao1;
                }
                this.productCode = productCode1;
                this.sizeCode = sizeCode1;
                this.formulaCode = formulaCode1;
                this.ngayCodeBao = ngayCodeBao1;
            }
        }

        private void btnUpdateItemEncryptCode_Click(object sender, EventArgs e)
        {
            if (this.gridViewItemEncryptCode.FocusedRowHandle >= 0)
            {
                DataRow dr = this.gridViewItemEncryptCode.GetDataRow(this.gridViewItemEncryptCode.FocusedRowHandle);
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string lot = dr["Lot"].ToString();
                txtLot.Text = txtLot.Text.Trim();
                txtItemEncryptCode.Text = txtItemEncryptCode.Text.Trim();
                if (txtItemEncryptCode.Text == string.Empty)
                {
                    MessageBox.Show(this.GetTextMessage("ItemEnryptCodeNullError", "Bạn chưa nhập mã mẫu!"));
                    return;
                }
                
                string filter = "ItemEncryptCode = '" + txtItemEncryptCode.Text + "'";
                if (this.dsAllData.Tables[1].Select(filter).Length > 0 && itemEncryptCode != txtItemEncryptCode.Text)
                {
                    MessageBox.Show(this.GetTextMessage("ItemEnryptCodeIsExist", "Mã mẫu đã tồn tại!"));
                    return;
                }
                dr["Lot"] = txtLot.Text;
                dr["ItemEncryptCode"] = txtItemEncryptCode.Text;
                filter = "ItemEncryptCode = '" + itemEncryptCode + "'";
                DataRow[] arrdr = dsAllData.Tables[1].Select(filter);
                foreach (DataRow dr1 in arrdr)
                {
                    dr1["Lot"] = txtLot.Text;
                    dr1["ItemEncryptCode"] = txtItemEncryptCode.Text;
                }
                arrdr = dsAllData.Tables[2].Select(filter);
                foreach (DataRow dr2 in arrdr)
                {
                    dr2["ItemEncryptCode"] = txtItemEncryptCode.Text;
                }
                arrdr = dsAllData.Tables[3].Select(filter);
                foreach (DataRow dr3 in arrdr)
                {
                    dr3["ItemEncryptCode"] = txtItemEncryptCode.Text;
                }

                this.itemEncryptCode = txtItemEncryptCode.Text;
                this.lot = txtLot.Text;
            }
        }

        private void gridViewResult_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string techCode = gridViewResult.GetDataRow(e.RowHandle)["TechCode"].ToString();
                TechnicalTest tt = lstTechnicalTest.Search("TechCode", techCode);
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

        private void txtItemEncryptCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.BuildItemEncryptCode();
        }
        private void BuildItemEncryptCode()
        {
            string d = this.transactionDate.Day.ToString();
            string m = this.transactionDate.Month.ToString();
            string y = this.transactionDate.Year.ToString();
            if (d.Length == 1) d = "0" + d;
            if (m.Length == 1) m = "0" + m;
            txtLot.Text = txtLot.Text.Trim();
            txtItemEncryptCode.Text = this.productCode + this.sizeCode + "-" + d + m + y.Substring(2) + "-" + txtLot.Text; ;
        }

        private void txtLot_Validating(object sender, CancelEventArgs e)
        {
            this.BuildItemEncryptCode();
        }

        private void btnAddMultiItemEncryptCode_Click(object sender, EventArgs e)
        {
            FormMultiProductLot f = new FormMultiProductLot();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string lineCode = f.LineCode;
                int frequency = f.Frequency;
                int fromLot = f.FromLot;
                int toLot = f.ToLot;
                while (fromLot <= toLot)
                {
                    this.txtLot.EditValue = lineCode + fromLot.ToString().Trim().PadLeft(3, '0');
                    AddItemEncryptCode();
                    fromLot += frequency;
                }
            }
        }
    }
}

