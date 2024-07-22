using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using DevExpress.XtraGrid.Views.BandedGrid;
using VNS.Windows.Forms;
using System.Collections;

namespace VNS.ERP.GUI.KCS
{
    public partial class UCTestRequestReturn : VNS.Windows.Controls.EditControlBase
    {
        public bool IsReveived
        {
            set { this.chkIsReceived.Checked = value; }
        }
        public delegate void UpdateIsReceved(bool IsReceived);
        public event UpdateIsReceved OnUpdateIsReceved;
        private enumKCSDepartment department;// = enumKCSDepartment.PTN;
        public enumKCSDepartment Department
        {
            get { return department; }
            set 
            { 
                department = value;
                if (value == enumKCSDepartment.PTN)
                {
                    this.btnEditDetail.Visible = true;
                    this.btnReceived.Visible = false;

                    //this.bandedGridViewMaterial.OptionsCustomization.ShowBandsInCustomizationForm = false;

                    this.colItemCode.Visible = false;
                    this.colItemCode.OptionsColumn.ShowInCustomizationForm = false;
                    this.colStockCode.Visible = false;
                    this.colStockCode.OptionsColumn.ShowInCustomizationForm = false;
                    this.colLocation.Visible = false;
                    this.colLocation.OptionsColumn.ShowInCustomizationForm = false;
                    this.colSubjectCode.Visible = false;
                    this.colSubjectCode.OptionsColumn.ShowInCustomizationForm = false;
                    this.colPTVC.Visible = false;
                    this.colPTVC.OptionsColumn.ShowInCustomizationForm = false;

                    this.colDescription.Visible = false;
                    this.colDescription.OptionsColumn.ShowInCustomizationForm = false;

                    this.colStockCode1.Visible = false;
                    this.colStockCode1.OptionsColumn.ShowInCustomizationForm = false;
                    this.colManuDate.Visible = false;
                    this.colManuDate.OptionsColumn.ShowInCustomizationForm = false;
                    this.colShift.Visible = false;
                    this.colShift.OptionsColumn.ShowInCustomizationForm = false;
                    this.colProductCode.Visible = false;
                    this.colProductCode.OptionsColumn.ShowInCustomizationForm = false;
                    this.colSizeCode.Visible = false;
                    this.colSizeCode.OptionsColumn.ShowInCustomizationForm = false;
                    this.colFormulaCode.Visible = false;
                    this.colFormulaCode.OptionsColumn.ShowInCustomizationForm = false;
                    this.colLot.Visible = false;
                    this.colLot.OptionsColumn.ShowInCustomizationForm = false;
                    this.colDescription1.Visible = false;
                    this.colDescription1.OptionsColumn.ShowInCustomizationForm = false;
                }
                else
                {
                    this.btnEditDetail.Visible = false;
                    this.btnReceived.Visible = true;

                    //this.bandedGridViewMaterial.OptionsCustomization.ShowBandsInCustomizationForm = true;
                    //this.colBranchCode.Visible = true;
                    //this.colBranchCode.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colItemCode.Visible = true;
                    //this.colItemCode.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colStockCode.Visible = true;
                    //this.colStockCode.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colLocation.Visible = true;
                    //this.colLocation.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colSubjectCode.Visible = true;
                    //this.colSubjectCode.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colPTVC.Visible = true;
                    //this.colPTVC.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colStartDate.Visible = true;
                    //this.colStartDate.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colEndDate.Visible = true;
                    //this.colEndDate.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colDescription.Visible = false;
                    //this.colDescription.OptionsColumn.ShowInCustomizationForm = true;

                    //this.colStockCode1.Visible = true;
                    //this.colStockCode1.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colManuDate.Visible = true;
                    //this.colManuDate.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colShift.Visible = true;
                    //this.colShift.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colProductCode.Visible = true;
                    //this.colProductCode.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colSizeCode.Visible = true;
                    //this.colSizeCode.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colFormulaCode.Visible = true;
                    //this.colFormulaCode.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colLot.Visible = true;
                    //this.colLot.OptionsColumn.ShowInCustomizationForm = true;
                    //this.colDescription1.Visible = false;
                    //this.colDescription1.OptionsColumn.ShowInCustomizationForm = true;
                }
            }
        }
        ListBase<TechnicalTest> lstTechnicalTest = null;
        public UCTestRequestReturn()
        {
            InitializeComponent();
            this.repTxtPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            this.repTxtPercent1.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            this.repTxtPercentApplied.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;


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
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            txtDescription.Properties.ReadOnly = viewMode;
            dateEditReturn.Properties.ReadOnly = viewMode;
            btnEditDetail.Enabled = !viewMode;
            chkIsReceived.Properties.ReadOnly = true;

            if (this.DataSource == null)
            {
                txtDescription.Text = string.Empty;
                chkIsReceived.Checked = false;
            }
            
            base.RefreshControl();
        }
        protected override void AssignData()
        {
            if (this.DataSource == null) this.DataSource = new TestRequestReturn();
            TestRequestReturn t = this.DataSource as TestRequestReturn;
            t.DateReturn = dateEditReturn.DateTime;
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
        //protected override int ValidateData()
        //{
        //    txtDescription.Text = txtDescription.Text.Trim();
        //    return base.ValidateData();
        //}
        protected override void BindData()
        {
            if (DataSource != null)
            {
                TestRequestReturn t = this.DataSource as TestRequestReturn;
                dateEditReturn.DateTime = t.DateReturn;
                txtDescription.Text = t.Description;
                chkIsReceived.Checked = t.IsReceived;
                if (t.MaterialDetailTable == null)
                {
                    t.MaterialDetailTable = TestRequestReturn.StructMaterialDetailTable.Clone();
                }
                if (t.ProductDetailTable == null)
                {
                    t.ProductDetailTable = TestRequestReturn.StructProductDetailTable.Clone();
                }
                this.RefreshDataOnGridMaterial();
                this.RefreshDataOnGridProduct();
            }
            base.BindData();
        }
        private void RefreshDataOnGridProduct()
        {
            ListBase<ProductQualityStandards> lstProductQualityStandards = new ProductQualityStandardsBLL().GetByDate(this.dateEditReturn.DateTime);
            DataTable dt = new DataTable();
            int len = this.bandedGridViewProduct.Columns.Count;
            BandedGridColumn[] arrCol = new BandedGridColumn[len - 4];
            int colPos = 0;
            foreach (BandedGridColumn bgcol in this.bandedGridViewProduct.Columns)
            {
                if (bgcol.Name.Substring(0, 5) == "colRe")
                {
                    arrCol[colPos] = bgcol;
                    colPos++;
                }
            }
            foreach (BandedGridColumn bgcol1 in arrCol)
            {
                this.bandedGridViewProduct.Columns.Remove(bgcol1);
            }

            TestRequestReturn t = this.DataSource as TestRequestReturn;
            if (t != null && t.ProductDetailTable != null)
            {
                DataColumn dc1 = new DataColumn("DateRequest", typeof(DateTime));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Description", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("StockCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("ManuDate", typeof(DateTime));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Shift", typeof(byte));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("ProductCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("SizeCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("FormulaCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Lot", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("ItemEncryptCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("TTPT", typeof(string));
                dt.Columns.Add(dc1);

                foreach (TechnicalTest tt in this.lstTechnicalTest)
                {
                    DataRow[] arrdr = t.ProductDetailTable.Select("TechCode = '" + tt.TechCode + "'");
                    if (arrdr.Length > 0)
                    {
                        BandedGridColumn col = this.bandedGridViewProduct.Columns.Add();
                        col.OwnerBand = this.bandResult1;
                        col.OptionsColumn.AllowMove = false;
                        col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                        col.OptionsColumn.ReadOnly = true;
                        col.Visible = true;
                        col.Name = "colResultProduct" + tt.TechCode;
                        col.Caption = tt.TechName;
                        col.FieldName = "Result" + tt.TechCode;
                        if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                        {
                            col.ColumnEdit = repTxtDecimal1;
                        }
                        if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                        {
                            col.ColumnEdit = repTxtPercent1;
                        }
                        if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                        {
                            col.ColumnEdit = repTxtString1;
                        }

                        DataColumn dc = new DataColumn("Result" + tt.TechCode, typeof(string));
                        dc.DefaultValue = string.Empty;
                        dt.Columns.Add(dc);
                        dc = new DataColumn("AppliedResult" + tt.TechCode, typeof(bool));
                        dc.DefaultValue = true;
                        dt.Columns.Add(dc);
                    }
                }
                foreach (DataRow dr1 in t.ProductDetailTable.Rows)
                {
                    DateTime dateRequest = Convert.ToDateTime(dr1["DateRequest"]);
                    string description = dr1["Description"].ToString();
                    string stockCode = dr1["StockCode"].ToString();
                    DateTime manuDate = Convert.ToDateTime(dr1["ManuDate"]);
                    byte shift = Convert.ToByte(dr1["Shift"]);
                    string productCode = dr1["ProductCode"].ToString();
                    string sizeCode = dr1["SizeCode"].ToString();
                    string formulaCode = dr1["FormulaCode"].ToString();
                    string lot = dr1["Lot"].ToString();
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string ttpt = string.Empty;
                    if (!dr1.IsNull("TTPT"))
                    {
                        ttpt = dr1["TTPT"].ToString();
                    }
                    string techCode = dr1["TechCode"].ToString();
                    string result = string.Empty;
                    if (!dr1.IsNull("Result"))
                    {
                        result = dr1["Result"].ToString();
                    }

                    DataRow drSearch = null;
                    foreach (DataRow drsearch in dt.Rows)
                    {
                        if (Convert.ToDateTime(drsearch["DateRequest"]) == dateRequest && drsearch["ItemEncryptCode"].ToString() == itemEncryptCode && drsearch["TTPT"].ToString() == ttpt)
                        {
                            drSearch = drsearch;
                            break;
                        }
                    }

                    if (drSearch != null)
                    {
                        if (dt.Columns.IndexOf("Result" + techCode) >= 0)
                        {
                            drSearch["Result" + techCode] = result;
                            if (!ProductQualityStandardsBLL.CheckQuality(result, lstProductQualityStandards, productCode, techCode))
                                drSearch.SetColumnError("Result" + techCode, "không đạt");
                        }
                    }
                    else
                    {
                        DataRow dr2 = dt.NewRow();
                        dr2["DateRequest"] = dateRequest;
                        dr2["Description"] = description;
                        dr2["StockCode"] = stockCode;
                        dr2["ManuDate"] = manuDate;
                        dr2["Shift"] = shift;
                        dr2["ProductCode"] = productCode;
                        dr2["SizeCode"] = sizeCode;
                        dr2["FormulaCode"] = formulaCode;
                        dr2["Lot"] = lot;
                        dr2["ItemEncryptCode"] = itemEncryptCode;
                        dr2["TTPT"] = ttpt;
                        if (dt.Columns.IndexOf("Result" + techCode) >= 0)
                        {
                            dr2["Result" + techCode] = result;
                            if (!ProductQualityStandardsBLL.CheckQuality(result, lstProductQualityStandards, productCode, techCode))
                                dr2.SetColumnError("Result" + techCode, "không đạt");
                        }
                        dt.Rows.Add(dr2);
                    }
                }
                this.gridCtrlProduct.DataSource = dt;
            }
        }
        private void RefreshDataOnGridMaterial()
        {
            ListBase<MaterialQualityStandards> lstMaterialQualityStandards = new MaterialQualityStandardsBLL().GetByDate(this.dateEditReturn.DateTime);
            DataTable dt = new DataTable();
            int len = this.bandedGridViewMaterial.Columns.Count;
            BandedGridColumn[] arrCol = new BandedGridColumn[len - 10];
            int colPos = 0;
            foreach (BandedGridColumn bgcol in this.bandedGridViewMaterial.Columns)
            {
                if (bgcol.Name.Substring(0, 5) == "colRe")
                {
                    arrCol[colPos] = bgcol;
                    colPos++;
                }
            }
            foreach (BandedGridColumn bgcol1 in arrCol)
            {
                this.bandedGridViewMaterial.Columns.Remove(bgcol1);
            }

            TestRequestReturn t = this.DataSource as TestRequestReturn;
            if (t != null && t.MaterialDetailTable != null)
            {
                DataColumn dc1 = new DataColumn("TestTransactionNo", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("TestTransactionDate", typeof(DateTime));
                dt.Columns.Add(dc1);
                //dc1 = new DataColumn("BranchCode", typeof(string));
                //dt.Columns.Add(dc1);
                dc1 = new DataColumn("ItemCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("StockCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Location", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("SubjectCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("PTVC", typeof(string));
                dt.Columns.Add(dc1);
                //dc1 = new DataColumn("StartDate", typeof(DateTime));
                //dt.Columns.Add(dc1);
                //dc1 = new DataColumn("EndDate", typeof(DateTime));
                //dt.Columns.Add(dc1);
                dc1 = new DataColumn("ItemEncryptCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("TTPT", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Description", typeof(string));
                dt.Columns.Add(dc1);
                foreach (TechnicalTest tt in this.lstTechnicalTest)
                {
                    DataRow[] arrdr = t.MaterialDetailTable.Select("TechCode = '" + tt.TechCode + "'");
                    if (arrdr.Length > 0)
                    {
                        BandedGridColumn col = this.bandedGridViewMaterial.Columns.Add();
                        col.OwnerBand = this.bandResult;
                        col.OptionsColumn.AllowMove = false;
                        col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                        col.OptionsColumn.ReadOnly = true;
                        col.Visible = true;
                        col.Name = "colResultMaterial" + tt.TechCode;
                        col.Caption = tt.TechName;
                        col.FieldName = "Result" + tt.TechCode;
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

                        DataColumn dc = new DataColumn("Result" + tt.TechCode, typeof(string));
                        dc.DefaultValue = string.Empty;
                        dt.Columns.Add(dc);
                        dc = new DataColumn("AppliedResult" + tt.TechCode, typeof(bool));
                        dc.DefaultValue = true;
                        dt.Columns.Add(dc);
                    }
                }
                foreach (DataRow dr1 in t.MaterialDetailTable.Rows)
                {
                    string testTransactionNo = dr1["TestTransactionNo"].ToString();
                    DateTime testTransactionDate = Convert.ToDateTime(dr1["TestTransactionDate"]);
                    //string branchCode = string.Empty;
                    //if (!dr1.IsNull("BranchCode"))
                    //{
                    //    branchCode = dr1["BranchCode"].ToString();
                    //}
                    string itemCode = string.Empty;
                    if (!dr1.IsNull("ItemCode"))
                    {
                        itemCode = dr1["ItemCode"].ToString();
                    }
                    string stockCode = string.Empty;
                    if (!dr1.IsNull("StockCode"))
                    {
                        stockCode = dr1["StockCode"].ToString();
                    }
                    string location = string.Empty;
                    if (!dr1.IsNull("Location"))
                    {
                        location = dr1["Location"].ToString();
                    }
                    string subjectCode = string.Empty;
                    if (!dr1.IsNull("SubjectCode"))
                    {
                        subjectCode = dr1["SubjectCode"].ToString();
                    }
                    string ptvc = string.Empty;
                    if (!dr1.IsNull("PTVC"))
                    {
                        ptvc = dr1["PTVC"].ToString();
                    }
                    //DateTime startDate = Convert.ToDateTime(dr1["StartDate"]);
                    //DateTime endDate = Convert.ToDateTime(dr1["EndDate"]);
                    string ttpt = string.Empty;
                    if (!dr1.IsNull("TTPT"))
                    {
                        ttpt = dr1["TTPT"].ToString();
                    }
                    string description = string.Empty;
                    if (!dr1.IsNull("Description"))
                    {
                        description = dr1["Description"].ToString();
                    }
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string techCode = dr1["TechCode"].ToString();
                    string result = string.Empty;
                    if (!dr1.IsNull("Result"))
                    {
                        result = dr1["Result"].ToString();
                    }

                    string filter = "TestTransactionNo = '" + testTransactionNo + "' and ItemEncryptCode = '" + itemEncryptCode + "'";
                    filter += " and TTPT = '" + ttpt + "'";
                    DataRow[] arrdr = dt.Select(filter);
                    if (arrdr.Length > 0)
                    {
                        if (dt.Columns.IndexOf("Result" + techCode) >= 0)
                        {
                            arrdr[0]["Result" + techCode] = result;
                            if (!MaterialQualityStandardsBLL.CheckQuality(result, lstMaterialQualityStandards, itemCode, techCode))
                                arrdr[0].SetColumnError("Result" + techCode, "không đạt");
                        }
                    }
                    else
                    {
                        DataRow dr2 = dt.NewRow();
                        dr2["TestTransactionNo"] = testTransactionNo;
                        dr2["TestTransactionDate"] = testTransactionDate;
                        //dr2["BranchCode"] = branchCode;
                        dr2["ItemCode"] = itemCode;
                        dr2["StockCode"] = stockCode;
                        dr2["Location"] = location;
                        dr2["SubjectCode"] = subjectCode;
                        dr2["PTVC"] = ptvc;
                        //dr2["StartDate"] = startDate;
                        //dr2["EndDate"] = endDate;
                        dr2["TTPT"] = ttpt;
                        dr2["ItemEncryptCode"] = itemEncryptCode;
                        dr2["Description"] = description;
                        if (dt.Columns.IndexOf("Result" + techCode) >= 0)
                        {
                            dr2["Result" + techCode] = result;
                            if (!MaterialQualityStandardsBLL.CheckQuality(result, lstMaterialQualityStandards, itemCode, techCode))
                                dr2.SetColumnError("Result" + techCode, "không đạt");
                        }
                        dt.Rows.Add(dr2);
                    }
                }
                this.gridCtrlMaterial.DataSource = dt;
            }
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            TestRequestReturn t = this.DataSource as TestRequestReturn;
            ListBase<EncryptCodeReturn> lstEncryptCodeReturnForCheck = new EncryptCodeReturnBLL().GetForTestRequestReturnCheck(t.ReturnID);
            string[] fields = new string[] { "ReturnNo", "ReturnDate", "SubjectCode" };
            string[] headers = new string[] { "Số", "Ngày", "TTPT" };
            object checkResult = FormCheck.Show(lstEncryptCodeReturnForCheck, fields, headers, -1, "ReturnID", t.Link, "EncryptCodeReturnID");
            if (checkResult != null)
            {
                ArrayList lstEncryptCodeReturnChecked = checkResult as ArrayList;
                t.Link.Clear();
                t.ProductDetailTable.Rows.Clear();
                t.MaterialDetailTable.Rows.Clear();
                foreach (EncryptCodeReturn ecr in lstEncryptCodeReturnChecked)
                {
                    foreach (DataRow dr in ecr.DetailMaterialTableForTestRequestReturnCheck.Rows)
                    {
                        DataRow dr1 = t.MaterialDetailTable.NewRow();
                        dr1["TestTransactionNo"] = dr["TestTransactionNo"];
                        dr1["TestTransactionDate"] = dr["TestTransactionDate"];
                        //dr1["BranchCode"] = dr["BranchCode"];
                        dr1["ItemCode"] = dr["ItemCode"];
                        dr1["StockCode"] = dr["StockCode"];
                        dr1["Location"] = dr["Location"];
                        dr1["SubjectCode"] = dr["SubjectCode"];
                        dr1["PTVC"] = dr["PTVC"];
                        //dr1["StartDate"] = dr["StartDate"];
                        //dr1["EndDate"] = dr["EndDate"];
                        dr1["Description"] = dr["Description"];
                        dr1["ItemEncryptCode"] = dr["ItemEncryptCode"];
                        dr1["TechCode"] = dr["TechCode"];
                        dr1["TTPT"] = dr["TTPT"];
                        dr1["Result"] = dr["Result"];
                        t.MaterialDetailTable.Rows.Add(dr1);
                    }
                    foreach (DataRow dr in ecr.DetailProductTableForTestRequestReturnCheck.Rows)
                    {
                        DataRow dr1 = t.ProductDetailTable.NewRow();
                        dr1["DateRequest"] = dr["DateRequest"];
                        dr1["Description"] = dr["Description"];
                        dr1["StockCode"] = dr["StockCode"];
                        dr1["ManuDate"] = dr["ManuDate"];
                        dr1["Shift"] = dr["Shift"];
                        dr1["ProductCode"] = dr["ProductCode"];
                        dr1["SizeCode"] = dr["SizeCode"];
                        dr1["FormulaCode"] = dr["FormulaCode"];
                        dr1["Lot"] = dr["Lot"];
                        dr1["ItemEncryptCode"] = dr["ItemEncryptCode"];
                        dr1["TechCode"] = dr["TechCode"];
                        dr1["TTPT"] = dr["TTPT"];
                        dr1["Result"] = dr["Result"];
                        t.ProductDetailTable.Rows.Add(dr1);
                    }
                    TestRequestReturnLink trrl = new TestRequestReturnLink();
                    trrl.EncryptCodeReturnID = ecr.ReturnID;
                    trrl.RequestReturnID = t.ReturnID;
                    t.Link.Add(trrl);
                }
                this.RefreshDataOnGridMaterial();
                this.RefreshDataOnGridProduct();
            }
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            chkIsReceived.Checked = !chkIsReceived.Checked;
            if (this.OnUpdateIsReceved != null) this.OnUpdateIsReceved(chkIsReceived.Checked);
        }

        private void bandedGridViewMaterial_DoubleClick(object sender, EventArgs e)
        {
            if (this.Department == enumKCSDepartment.QLCL)
            {
                if (bandedGridViewMaterial.FocusedRowHandle >= 0)
                {
                    DataRow dr = bandedGridViewMaterial.GetDataRow(bandedGridViewMaterial.FocusedRowHandle);
                    if (dr != null)
                    {
                        FormApplyTestRequestResult f = new FormApplyTestRequestResult(dr, false);
                        f.ShowDialog();
                        //DataTable dt = bandedGridViewMaterial.DataSource as DataTable;
                        //dt.AcceptChanges();
                        //foreach (DataRow dr1 in f.DTApplied.Rows)
                        //{
                        //    string techCode = dr1["TechCode"].ToString();
                        //    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                        //    string ttpt = dr1["SubjectCode"].ToString();
                        //    //bandedGridViewMaterial.cel
                        //    //colBranchCode.AppearanceCell.
                        //}
                    }
                }
            }
        }

        private void bandedGridViewProduct_DoubleClick(object sender, EventArgs e)
        {
            if (this.Department == enumKCSDepartment.QLCL)
            {
                if (bandedGridViewProduct.FocusedRowHandle >= 0)
                {
                    DataRow dr = bandedGridViewProduct.GetDataRow(bandedGridViewProduct.FocusedRowHandle);
                    if (dr != null)
                    {
                        FormApplyTestRequestResult f = new FormApplyTestRequestResult(dr, true);
                        f.ShowDialog();
                    }
                }
            }
            
        }

        private void bandedGridViewMaterial_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (this.lstTechnicalTest == null) return;
            if (e.Column.FieldName.Length <=6 || e.Column.FieldName.Substring(0, 6) != "Result")
                return;
            //if (e.RowHandle >= 0)
            //{
            DataRow o = bandedGridViewMaterial.GetDataRow(e.RowHandle);
            if (o == null)
                return;
            
            string techCode = e.Column.FieldName.Substring(6);
            if (o.Table.Columns.IndexOf("AppliedResult" + techCode) < 0) return;
            if (o.Table.Columns.IndexOf(e.Column.FieldName) < 0) return;

            bool isApplied = Convert.ToBoolean(o["AppliedResult" + techCode]);
            TechnicalTest tt = this.lstTechnicalTest.Search("TechCode", techCode);

            if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
            {
                if (o.IsNull(e.Column.FieldName))
                {
                    e.RepositoryItem = repTxtString;
                }
                else
                {
                    if (o[e.Column.FieldName].ToString().Trim() == string.Empty)
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
                if (o.IsNull(e.Column.FieldName))
                {
                    e.RepositoryItem = repTxtString;
                }
                else
                {
                    if (o[e.Column.FieldName].ToString().Trim() == string.Empty)
                    {
                        e.RepositoryItem = repTxtString;
                    }
                    else
                    {
                        e.RepositoryItem = repTxtPercent;
                    }
                }
            }

            if (tt != null)
            {
                //if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                //{
                //    if (isApplied) e.RepositoryItem = repTxtDecimalApplied;
                //    else e.RepositoryItem = repTxtDecimal;
                //}
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    if (isApplied) e.RepositoryItem = repTxtStringApplied;
                    else e.RepositoryItem = repTxtString;
                }
                //if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                //{
                //    if (isApplied) e.RepositoryItem = repTxtPercentApplied;
                //    else e.RepositoryItem = repTxtPercent;
                //}
            }
        }

        private void bandedGridViewProduct_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (this.lstTechnicalTest == null) return;
            if (e.Column.FieldName.Length <= 6 || e.Column.FieldName.Substring(0, 6) != "Result")
                return;
            //if (e.RowHandle >= 0)
            //{
            DataRow o = bandedGridViewProduct.GetDataRow(e.RowHandle);
            if (o == null)
                return;

            string techCode = e.Column.FieldName.Substring(6);
            if (o.Table.Columns.IndexOf("AppliedResult" + techCode) < 0) return;
            if (o.Table.Columns.IndexOf(e.Column.FieldName) < 0) return;

            bool isApplied = Convert.ToBoolean(o["AppliedResult" + techCode]);
            TechnicalTest tt = this.lstTechnicalTest.Search("TechCode", techCode);

            if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
            {
                if (o.IsNull(e.Column.FieldName))
                {
                    e.RepositoryItem = repTxtString;
                }
                else
                {
                    if (o[e.Column.FieldName].ToString().Trim() == string.Empty)
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
                if (o.IsNull(e.Column.FieldName))
                {
                    e.RepositoryItem = repTxtString;
                }
                else
                {
                    if (o[e.Column.FieldName].ToString().Trim() == string.Empty)
                    {
                        e.RepositoryItem = repTxtString;
                    }
                    else
                    {
                        e.RepositoryItem = repTxtPercent;
                    }
                }
            }

            if (tt != null)
            {
                //if (tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                //{
                //    if (isApplied) e.RepositoryItem = repTxtDecimalApplied;
                //    else e.RepositoryItem = repTxtDecimal;
                //}
                if (tt.ResultType == enumResultTypeTechnicalTest.Text.ToString())
                {
                    //if (isApplied) e.RepositoryItem = repTxtStringApplied;
                    //else e.RepositoryItem = repTxtString;
                    e.RepositoryItem = repTxtString;
                }
                //if (tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                //{
                //    if (isApplied) e.RepositoryItem = repTxtPercentApplied;
                //    else e.RepositoryItem = repTxtPercent;
                //}
            }
        }
    }
}

