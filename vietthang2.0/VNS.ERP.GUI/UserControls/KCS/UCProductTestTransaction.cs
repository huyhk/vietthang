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

namespace VNS.ERP.GUI.KCS
{
    public partial class UCProductTestTransaction : VNS.Windows.Controls.EditControlBase
    {
        private string stockCode;
        public string StockCode
        {
            set 
            {
                lookUpStockCode.EditValue = value;
                stockCode = value;
            }
        }
        private enumKCSDepartment department = enumKCSDepartment.KCS;
        public enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
                if (value == enumKCSDepartment.PTN)
                {
                    this.btnEditDetail.Visible = false;
                    this.bandResult.Visible = false;
                }
            }
        }
        public UCProductTestTransaction()
        {
            InitializeComponent();
            this.repTxtPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            this.dateEditTransaction.Properties.Mask.EditMask = AppConfigs.CONFIG_DATEFORMAT;
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                ProductTestTransaction t = this.DataSource as ProductTestTransaction;
                dateEditTransaction.DateTime = t.TransactionDate;
                txtShift.Value = Convert.ToDecimal(t.Shift);
                txtDescription.Text = t.Description;
                txtNguoikiem.Text = t.Nguoikiem;
                if (t.TableDetail == null)
                {
                    t.TableDetail = ProductTestTransaction.StructTableDetail.Clone();
                }
                this.RefreshDataOnGrid();
            }
            base.BindData();
        }
        ListBase<TechnicalTest> lstTechnicalTest = null;
        private void RefreshDataOnGrid()
        {
            DataTable dt = new DataTable();
            int len = this.bandedGridView1.Columns.Count;
            BandedGridColumn[] arrCol = new BandedGridColumn[len-6];
            int colPos = 0;
            foreach (BandedGridColumn bgcol in this.bandedGridView1.Columns)
            {
                if (bgcol.Name.Substring(0,5) == "colRe")
                {
                    arrCol[colPos] = bgcol;
                    colPos++;
                }
            }
            foreach (BandedGridColumn bgcol1 in arrCol)
            {
                this.bandedGridView1.Columns.Remove(bgcol1);
            }
           

            //this.bandedGridView1.Columns.Add(this.colNewProductCode);
            //this.bandedGridView1.Columns.Add(this.colNewSizeCode);
            //this.bandedGridView1.Columns.Add(this.colNewFormulaCode);
            //this.bandedGridView1.Columns.Add(this.colNewLot);
            //this.bandedGridView1.Columns.Add(this.colNewItemEncryptCode);

            //this.colNewProductCode.Visible = true;
            //this.colNewSizeCode.Visible = true;
            //this.colNewFormulaCode.Visible = true;
            //this.colNewLot.Visible = true;
            //this.colNewItemEncryptCode.Visible = true;
            
            dt.Columns.Add(new DataColumn("ProductCode", typeof(string)));
            dt.Columns.Add(new DataColumn("SizeCode", typeof(string)));
            dt.Columns.Add(new DataColumn("FormulaCode", typeof(string)));
            dt.Columns.Add(new DataColumn("Lot", typeof(string)));
            dt.Columns.Add(new DataColumn("ItemEncryptCode", typeof(string)));
            dt.Columns.Add(new DataColumn("NgayCodeBao", typeof(DateTime)));

            ProductTestTransaction t = this.DataSource as ProductTestTransaction;
            if (t != null && t.TableDetail != null)
            {
                foreach (TechnicalTest tt in this.lstTechnicalTest)
                {
                    DataRow[] arrdr = t.TableDetail.Select("TechCode = '" + tt.TechCode + "'");
                    bool loadedColResult = false;
                    bool loadedColRequest = false;
                    foreach (DataRow dr in arrdr)
                    {
                        if (dr["Result"].ToString() != string.Empty && !loadedColResult)
                        {
                            BandedGridColumn col = this.bandedGridView1.Columns.Add();
                            col.OwnerBand = this.bandResult;
                            col.OptionsColumn.AllowMove = false;
                            col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                            col.OptionsColumn.ReadOnly = true;
                            col.Visible = true;
                            col.Name = "colResult" + tt.TechCode;
                            col.Caption = tt.TechName;
                            col.FieldName = "Result" + tt.TechCode;
                            if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                            {
                                col.ColumnEdit = repTxtString;
                            }
                            if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                            {
                                col.ColumnEdit = repTxtDecimal;
                            }
                            if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                            {
                                col.ColumnEdit = repTxtPercent;
                            }
                            dt.Columns.Add(new DataColumn("Result" + tt.TechCode, typeof(string)));
                            loadedColResult = true;
                        }
                        if (Convert.ToBoolean(dr["IsChecked"]) == true && !loadedColRequest)
                        {
                            BandedGridColumn col = this.bandedGridView1.Columns.Add();
                            col.OwnerBand = this.bandRequest;
                            col.OptionsColumn.AllowMove = false;
                            col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                            col.Visible = true;
                            col.Name = "colRequest" + tt.TechCode;
                            col.Caption = tt.TechName;
                            col.FieldName = "Request" + tt.TechCode;

                            DataColumn dc = new DataColumn("Request" + tt.TechCode, typeof(bool));
                            dc.DefaultValue = false;
                            dt.Columns.Add(dc);
                            loadedColRequest = true;
                        }
                        if (loadedColRequest && loadedColResult) break;
                    }
                }
                foreach (DataRow dr1 in t.TableDetail.Rows)
                {
                    string productCode = dr1["ProductCode"].ToString();
                    string sizeCode = dr1["SizeCode"].ToString();
                    string formulaCode = dr1["FormulaCode"].ToString();
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string techCode = dr1["TechCode"].ToString();
                    bool added = false;
                    if (techCode != string.Empty)
                    {
                        DataRow[] arrdr = dt.Select("ItemEncryptCode = '" + itemEncryptCode + "'");
                        if (arrdr.Length > 0)
                        {
                            if (dt.Columns.IndexOf("Result" + techCode) >= 0)
                            {
                                arrdr[0]["Result" + techCode] = dr1["Result"];
                            }
                            if (dt.Columns.IndexOf("Request" + techCode) >= 0)
                            {
                                arrdr[0]["Request" + techCode] = Convert.ToBoolean(dr1["IsChecked"]);
                            }
                            added = true;
                        }
                        else
                        {
                            DataRow dr2 = dt.NewRow();
                            dr2["ProductCode"] = dr1["ProductCode"];
                            dr2["SizeCode"] = dr1["SizeCode"];
                            dr2["FormulaCode"] = dr1["FormulaCode"];
                            dr2["ItemEncryptCode"] = dr1["ItemEncryptCode"];
                            dr2["Lot"] = dr1["Lot"];
                            dr2["NgayCodeBao"] = dr1["NgayCodeBao"];
                            if (dt.Columns.IndexOf("Result" + techCode) >= 0)
                            {
                                dr2["Result" + techCode] = dr1["Result"];
                            }
                            if (dt.Columns.IndexOf("Request" + techCode) >= 0)
                            {
                                dr2["Request" + techCode] = Convert.ToBoolean(dr1["IsChecked"]);
                            }
                            dt.Rows.Add(dr2);
                            added = true;
                        }
                    }
                    if (!added)
                    {
                        DataRow dr2 = dt.NewRow();
                        dr2["ProductCode"] = dr1["ProductCode"];
                        dr2["SizeCode"] = dr1["SizeCode"];
                        dr2["FormulaCode"] = dr1["FormulaCode"];
                        dr2["ItemEncryptCode"] = dr1["ItemEncryptCode"];
                        dr2["Lot"] = dr1["Lot"];
                        dr2["NgayCodeBao"] = dr1["NgayCodeBao"];
                        dt.Rows.Add(dr2);
                    }
                }
                this.gridControl1.DataSource = dt;
            }
        }
        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            if (lookUpStockCode.EditValue == null)
            {
                return -1;
            }
            return base.ValidateData();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new ProductTestTransaction();
            ProductTestTransaction t = this.DataSource as ProductTestTransaction;
            t.TransactionDate = dateEditTransaction.DateTime;
            t.Shift = Convert.ToByte(txtShift.Value);
            t.StockCode = lookUpStockCode.EditValue.ToString();
            t.Description = txtDescription.Text;
            t.Nguoikiem = txtNguoikiem.Text;

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
            dateEditTransaction.Properties.ReadOnly = viewMode;
            txtShift.Properties.ReadOnly = viewMode;
            txtDescription.Properties.ReadOnly = viewMode;
            txtNguoikiem.Properties.ReadOnly = viewMode;
            
            if (this.DataSource == null)
            {
                txtDescription.Text = string.Empty;
            }
            this.btnEditDetail.Enabled = !viewMode;
            base.RefreshControl();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                lookUpStockCode.Properties.DataSource = new StockBLL().GetAll();
                this.lstTechnicalTest = new TechnicalTestBLL().GetAll();
            }
            base.InitDataObject();
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            ProductTestTransaction t= this.DataSource as ProductTestTransaction;
            DataTable dt = t.TableDetail;
            FormEditProductTestTransactionDetail f = new FormEditProductTestTransactionDetail(ref dt, this.dateEditTransaction.DateTime, this.stockCode);
            if (f.ShowDialog() == DialogResult.Yes)
            {
                this.RefreshDataOnGrid();
            }
        }
    }
}

