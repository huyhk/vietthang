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
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.KCS
{
    public partial class UCTechnicalTestReturn : VNS.Windows.Controls.EditControlBase
    {
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        public bool IsReveived
        {
            set { this.chkIsReceived.Checked = value; }
        }
        
        public delegate void UpdateIsReceved(bool IsReceived);
        public event UpdateIsReceved OnUpdateIsReceved;
        private enumKCSDepartment department = enumKCSDepartment.PTN;
        public enumKCSDepartment Department
        {
            get { return department; }
            set
            {
                department = value;
                if (department == enumKCSDepartment.PTN)
                {
                    btnReceived.Visible = false;
                    colBranchName.Visible = false;
                    colCustomerName.Visible = false;
                    colDescription.Visible = false;
                    colDescription1.Visible = false;
                    colEndDate.Visible = false;
                    colFormulaCode.Visible = false;
                    colItemName.Visible = false;
                    colLocation.Visible = false;
                    colLot.Visible = false;
                    colProductCode.Visible = false;
                    colPTVC.Visible = false;
                    colShift.Visible = false;
                    colSizeCode.Visible = false;
                    colStartDate.Visible = false;
                    colStockName.Visible = false;
                    colStockName1.Visible = false;
                    colTestTransactionDate.Visible = false;
                    colTestTransactionNo.Visible = false;
                    colTransactionDate1.Visible = false;
                }
                else
                {
                    btnReceived.Visible = true;
                    //colBranchName.Visible = true;
                    colCustomerName.Visible = true;
                    colDescription.Visible = false;
                    colDescription1.Visible = false;
                    //colEndDate.Visible = true;
                    colFormulaCode.Visible = true;
                    colItemName.Visible = true;
                    colLocation.Visible = true;
                    colLot.Visible = true;
                    colProductCode.Visible = true;
                    colPTVC.Visible = true;
                    colShift.Visible = true;
                    colSizeCode.Visible = true;
                    //colStartDate.Visible = true;
                    colStockName.Visible = true;
                    colStockName1.Visible = true;
                    colTestTransactionDate.Visible = true;
                    colTestTransactionNo.Visible = true;
                    colTransactionDate1.Visible = true;
                }
            }
        }
        ListBase<TechnicalTest> lstTechnicalTest = null;
        public UCTechnicalTestReturn()
        {
            InitializeComponent();
            this.repTxtPercent.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            this.repTxtPercent1.Mask.EditMask = ModuleKCS.CONFIG_TECH_PERCENTFORMAT;
            

        }
        protected override void InitDataObject()
        {
            base.InitDataObject();
            if (!this.DesignMode)
            {
                this.lstTechnicalTest = new TechnicalTestBLL().GetAll();
                this.lookUpEditStockCode.Properties.DataSource = new StockBLL().GetAll();
            }
        }
        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            lookUpEditStockCode.Properties.ReadOnly = true;
            txtDescription.Properties.ReadOnly = viewMode;
            dateEditReturn.Properties.ReadOnly = viewMode;
            btnEditDetailMaterial.Enabled = !viewMode;
            btnEditDetailProduct.Enabled = !viewMode;
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
            if (this.DataSource == null) this.DataSource = new TechnicalTestReturn();
            TechnicalTestReturn t = this.DataSource as TechnicalTestReturn;
            t.StockCode = lookUpEditStockCode.EditValue.ToString();
            t.ReturnDate = dateEditReturn.DateTime;
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
            return base.ValidateData();
        }
        protected override void BindData()
        {
            if (DataSource != null)
            {
                TechnicalTestReturn t = this.DataSource as TechnicalTestReturn;
                lookUpEditStockCode.EditValue = this.stockCode;
                dateEditReturn.DateTime = t.ReturnDate;
                txtDescription.Text = t.Description;
                chkIsReceived.Checked = t.IsReceived;
                if (t.MaterialDetailTable == null)
                {
                    t.MaterialDetailTable = TechnicalTestReturn.StructMaterialDetailTable.Clone();
                }
                if (t.ProductDetailTable == null)
                {
                    t.ProductDetailTable = TechnicalTestReturn.StructProductDetailTable.Clone();
                }
                this.RefreshDataOnGridMaterial();
                this.RefreshDataOnGridProduct();
            }
            base.BindData();
        }
        private void RefreshDataOnGridProduct()
        {
            ListBase<ProductQualityStandards> lstProductQualityStandards = new ProductQualityStandardsBLL().GetByDate(this.dateEditReturn.DateTime);
            System.Data.DataTable dt = new System.Data.DataTable();
            int len = this.bandedGridView2.Columns.Count;
            BandedGridColumn[] arrCol = new BandedGridColumn[len - 9];
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

            TechnicalTestReturn t = this.DataSource as TechnicalTestReturn;
            if (t != null && t.ProductDetailTable != null)
            {
                DataColumn dc1 = new DataColumn("ItemEncryptCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("ProductCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("SizeCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("FormulaCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Lot", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("StockCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("StockName", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("TransactionDate", typeof(DateTime));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Shift", typeof(byte));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Description", typeof(string));
                dt.Columns.Add(dc1);

                foreach (TechnicalTest tt in this.lstTechnicalTest)
                {
                    DataRow[] arrdr = t.ProductDetailTable.Select("TechCode = '" + tt.TechCode + "'");
                    if (arrdr.Length > 0)
                    {
                        BandedGridColumn col = this.bandedGridView2.Columns.Add();
                        col.OwnerBand = this.bandDetailProduct;
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
                    }
                }
                foreach (DataRow dr1 in t.ProductDetailTable.Rows)
                {
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    string productCode = string.Empty;
                    if (!dr1.IsNull("ProductCode"))
                    {
                        productCode = dr1["ProductCode"].ToString();
                    }
                    string sizeCode = string.Empty;
                    if (!dr1.IsNull("SizeCode"))
                    {
                        sizeCode = dr1["SizeCode"].ToString();
                    }
                    string formulaCode = string.Empty;
                    if (!dr1.IsNull("FormulaCode"))
                    {
                        formulaCode = dr1["FormulaCode"].ToString();
                    }
                    string stockCode = string.Empty;
                    if (!dr1.IsNull("StockCode"))
                    {
                        stockCode = dr1["StockCode"].ToString();
                    }
                    byte shift = 0;
                    if (!dr1.IsNull("Shift"))
                    {
                        shift = Convert.ToByte(dr1["Shift"]);
                    }
                    DateTime transDate = DateTime.MinValue;
                    if (!dr1.IsNull("TransactionDate"))
                    {
                        transDate = Convert.ToDateTime(dr1["TransactionDate"]);
                    }
                    string lot = string.Empty;
                    if (!dr1.IsNull("Lot"))
                    {
                        lot = dr1["Lot"].ToString();
                    }
                    string stockName = string.Empty;
                    if (!dr1.IsNull("StockName"))
                    {
                        stockName = dr1["StockName"].ToString();
                    }
                    string description = string.Empty;
                    if (!dr1.IsNull("Description"))
                    {
                        description = dr1["Description"].ToString();
                    }
                    string techCode = string.Empty;
                    if (!dr1.IsNull("TechCode"))
                    {
                        techCode = dr1["TechCode"].ToString();
                    }
                    string result = string.Empty;
                    if (!dr1.IsNull("Result"))
                    {
                        result = dr1["Result"].ToString();
                    }

                    DataRow drSearch = null;
                    foreach (DataRow drsearch in dt.Rows)
                    {
                        bool searchResult = drsearch["ItemEncryptCode"].ToString() == itemEncryptCode;
                        searchResult = searchResult && drsearch["ProductCode"].ToString() == productCode;
                        searchResult = searchResult && drsearch["SizeCode"].ToString() == sizeCode;
                        searchResult = searchResult && drsearch["FormulaCode"].ToString() == formulaCode;
                        searchResult = searchResult && drsearch["StockCode"].ToString() == stockCode;
                        searchResult = searchResult && Convert.ToByte(drsearch["Shift"]) == shift;
                        searchResult = searchResult && Convert.ToDateTime(drsearch["TransactionDate"]) == transDate;
                        if (searchResult)
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

                        dr2["ItemEncryptCode"] = itemEncryptCode;
                        dr2["ProductCode"] = productCode;
                        dr2["SizeCode"] = sizeCode;
                        dr2["FormulaCode"] = formulaCode;
                        dr2["Lot"] = lot;
                        dr2["StockCode"] = stockCode;
                        dr2["StockName"] = stockName;
                        dr2["TransactionDate"] = transDate;
                        dr2["Shift"] = shift;
                        dr2["Description"] = description;
                        if (dt.Columns.IndexOf("Result" + techCode) >= 0)
                        {
                            dr2["Result" + techCode] = result;
                            if (!ProductQualityStandardsBLL.CheckQuality(result, lstProductQualityStandards, productCode, techCode))
                                dr2.SetColumnError("Result" + techCode, "không đạt");
                        }
                        dt.Rows.Add(dr2);
                    }
                }
                this.gridControl2.DataSource = dt;
            }
        }
        private void RefreshDataOnGridMaterial()
        {
            ListBase<MaterialQualityStandards> lstMaterialQualityStandards = new MaterialQualityStandardsBLL().GetByDate(this.dateEditReturn.DateTime);
            System.Data.DataTable dt = new System.Data.DataTable();
            int len = this.bandedGridView1.Columns.Count;
            BandedGridColumn[] arrCol = new BandedGridColumn[len - 12];
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

            TechnicalTestReturn t = this.DataSource as TechnicalTestReturn;
            if (t != null && t.MaterialDetailTable != null)
            {
                DataColumn dc1 = new DataColumn("ItemEncryptCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("IsApplied", typeof(bool));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("TestTransactionID", typeof(Guid));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("TestTransactionNo", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("TestTransactionDate", typeof(DateTime));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("BranchCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("BranchName", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("ItemCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("ItemName", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("StockCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("StockName", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Location", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("CustomerCode", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("CustomerName", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("PTVC", typeof(string));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("StartDate", typeof(DateTime));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("EndDate", typeof(DateTime));
                dt.Columns.Add(dc1);
                dc1 = new DataColumn("Description", typeof(string));
                dt.Columns.Add(dc1);
                foreach (TechnicalTest tt in this.lstTechnicalTest)
                {
                    DataRow[] arrdr = t.MaterialDetailTable.Select("TechCode = '" + tt.TechCode + "'");
                    if (arrdr.Length > 0)
                    {
                        BandedGridColumn col = this.bandedGridView1.Columns.Add();
                        col.OwnerBand = this.bandDetailMaterial;
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
                    }
                }
                foreach (DataRow dr1 in t.MaterialDetailTable.Rows)
                {
                    string itemEncryptCode = dr1["ItemEncryptCode"].ToString();
                    bool isApplied = false;
                    if (!dr1.IsNull("IsApplied"))
                    {
                        isApplied = Convert.ToBoolean(dr1["IsApplied"]);
                    }
                    Guid testTransactionID = Guid.Empty;
                    if (!dr1.IsNull("TestTransactionID"))
                    {
                        testTransactionID = (Guid)dr1["TestTransactionID"];
                    }
                    string testTransactionNo = string.Empty;
                    if (!dr1.IsNull("TestTransactionNo"))
                    {
                        testTransactionNo = dr1["TestTransactionNo"].ToString();
                    }
                    DateTime testTransactionDate = DateTime.MinValue;
                    if (!dr1.IsNull("TestTransactionDate"))
                    {
                        testTransactionDate = Convert.ToDateTime(dr1["TestTransactionDate"]);
                    }
                    string branchCode = string.Empty;
                    if (!dr1.IsNull("BranchCode"))
                    {
                        branchCode = dr1["BranchCode"].ToString();
                    }
                    string branchName = string.Empty;
                    if (!dr1.IsNull("BranchName"))
                    {
                        branchName = dr1["BranchName"].ToString();
                    }
                    string itemCode = string.Empty;
                    if (!dr1.IsNull("ItemCode"))
                    {
                        itemCode = dr1["ItemCode"].ToString();
                    }
                    string itemName = string.Empty;
                    if (!dr1.IsNull("ItemName"))
                    {
                        itemName = dr1["ItemName"].ToString();
                    }
                    string stockCode = string.Empty;
                    if (!dr1.IsNull("StockCode"))
                    {
                        stockCode = dr1["StockCode"].ToString();
                    }
                    string stockName = string.Empty;
                    if (!dr1.IsNull("StockName"))
                    {
                        stockName = dr1["StockName"].ToString();
                    }
                    string location = string.Empty;
                    if (!dr1.IsNull("Location"))
                    {
                        location = dr1["Location"].ToString();
                    }

                    string customerCode = string.Empty;
                    if (!dr1.IsNull("CustomerCode"))
                    {
                        customerCode = dr1["CustomerCode"].ToString();
                    }
                    string customerName = string.Empty;
                    if (!dr1.IsNull("CustomerName"))
                    {
                        customerName = dr1["CustomerName"].ToString();
                    }
                    string ptvc = string.Empty;
                    if (!dr1.IsNull("PTVC"))
                    {
                        ptvc = dr1["PTVC"].ToString();
                    }
                    DateTime startDate = DateTime.MinValue;
                    if (!dr1.IsNull("StartDate"))
                    {
                        startDate = Convert.ToDateTime(dr1["StartDate"]);
                    }
                    DateTime endDate = DateTime.MinValue;
                    if (!dr1.IsNull("EndDate"))
                    {
                        endDate = Convert.ToDateTime(dr1["EndDate"]);
                    }
                    string description = string.Empty;
                    if (!dr1.IsNull("Description"))
                    {
                        description = dr1["Description"].ToString();
                    }
                    
                    string techCode = dr1["TechCode"].ToString();
                    string result = string.Empty;
                    if (!dr1.IsNull("Result"))
                    {
                        result = dr1["Result"].ToString();
                    }

                    string filter = "TestTransactionNo = '" + testTransactionNo + "' and ItemEncryptCode = '" + itemEncryptCode + "'";
                
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
                        dr2["ItemEncryptCode"] = itemEncryptCode;
                        dr2["IsApplied"] = isApplied;
                        dr2["TestTransactionID"] = testTransactionID;
                        dr2["TestTransactionNo"] = testTransactionNo;
                        dr2["TestTransactionDate"] = testTransactionDate;
                        dr2["BranchCode"] = branchCode;
                        dr2["BranchName"] = branchName;
                        dr2["ItemCode"] = itemCode;
                        dr2["ItemName"] = itemName;
                        dr2["StockCode"] = stockCode;
                        dr2["StockName"] = stockName;
                        dr2["Location"] = location;
                        dr2["CustomerCode"] = customerCode;
                        dr2["CustomerName"] = customerName;
                        dr2["PTVC"] = ptvc;
                        dr2["StartDate"] = startDate;
                        dr2["EndDate"] = endDate;
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
                this.gridControl1.DataSource = dt;
            }
        }
        private void btnEditDetailMaterial_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xls file (*.xls) | *.xls";
            string fileName = string.Empty;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(fileName);
                Worksheet ws = null;
                ws = (Worksheet)wb.Worksheets[1];
                //((Style)(((Range)ws.Cells[0, 0]).Style)).NumberFormat = "";
                int startTechCodePos = 5;
                int endTechCodePos = 5;
                string techCode = ((Range)ws.Cells[2, endTechCodePos]).Text.ToString();
                if (techCode == string.Empty) endTechCodePos -= 1;
                else
                {
                    while (techCode != string.Empty)
                    {
                        endTechCodePos += 1;
                        techCode = ((Range)ws.Cells[2, endTechCodePos]).Text.ToString();
                    }
                    endTechCodePos -= 1;
                }
                if (endTechCodePos >= startTechCodePos)
                {
                    TechnicalTestReturn t = this.DataSource as TechnicalTestReturn;
                    int row = 3;
                    string itemEncryptCode = ((Range)ws.Cells[row, 3]).Text.ToString();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Columns.Add(new DataColumn("ItemEncryptCode", typeof(string)));
                    dt.Columns.Add(new DataColumn("TechCode", typeof(string)));
                    dt.Columns.Add(new DataColumn("Description", typeof(string)));
                    t.MaterialDetailTable.Rows.Clear();
                    while (itemEncryptCode != string.Empty)
                    {
                        for (int i = startTechCodePos; i <= endTechCodePos; i++)
                        {
                            if (((Range)ws.Cells[row, i]).Value2 != null)
                            {
                                string result = ((Range)ws.Cells[row, i]).Value2.ToString().Trim();
                                //string result1 = result.Replace("0", "");
                                //result1 = result1.Replace(".", "");
                                //result1 = result1.Replace(",", "");
                                techCode = ((Range)ws.Cells[2, i]).Text.ToString();
                                TechnicalTest tt = this.lstTechnicalTest.Search("TechCode", techCode);
                                //if (result1 != string.Empty)
                                //{
                                    Guid returnID = t.ReturnID;
                                    int status = new TechnicalTestReturnBLL().CheckResultImportStatus(returnID, itemEncryptCode, techCode, false);
                                    if (status == -1)
                                    {
                                        DataRow dr = dt.NewRow();
                                        dr["ItemEncryptCode"] = itemEncryptCode;
                                        dr["TechCode"] = techCode;
                                        dr["Description"] = "Kết quả phân tích đã được trả ở phiếu khác";
                                        dt.Rows.Add(dr);
                                    }
                                    if (status == -2 || status == -3)
                                    {
                                        DataRow dr = dt.NewRow();
                                        dr["ItemEncryptCode"] = itemEncryptCode;
                                        dr["TechCode"] = techCode;
                                        dr["Description"] = "Kết quả không được yêu cầu phân tích";
                                        dt.Rows.Add(dr);
                                    }
                                    if (status == 0)
                                    {
                                        DataRow dr = t.MaterialDetailTable.NewRow();
                                        dr["ItemEncryptCode"] = itemEncryptCode;
                                        dr["TechCode"] = techCode;
                                        if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                                        {
                                            decimal d = 0;
                                            try
                                            {
                                                d = Convert.ToDecimal(result);
                                            }
                                            catch
                                            {
                                            }
                                            d = d / 100;
                                            dr["Result"] = d.ToString();
                                        }
                                        else if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                                        {
                                            decimal d = 0;
                                            try
                                            {
                                                d = Convert.ToDecimal(result);
                                            }
                                            catch
                                            {
                                            }
                                            d = Math.Round(d, 1);
                                            dr["Result"] = d.ToString().Replace(',','.');
                                        }
                                        else
                                        {
                                            dr["Result"] = result;
                                        }

                                        t.MaterialDetailTable.Rows.Add(dr);
                                    }
                                //}
                            }
                        }
                        row++;
                        itemEncryptCode = ((Range)ws.Cells[row, 3]).Text.ToString();
                    }
                    this.RefreshDataOnGridMaterial();
                    if (dt.Rows.Count>0)
                    {
                        FormInfoImportTechnicalTestReturnDetail f = new FormInfoImportTechnicalTestReturnDetail(dt);
                        f.Show();
                    }
                }
                excelApp.Quit();
            }
        }

        private void btnReceived_Click(object sender, EventArgs e)
        {
            chkIsReceived.Checked = !chkIsReceived.Checked;
            if (this.OnUpdateIsReceved != null) this.OnUpdateIsReceved(chkIsReceived.Checked);
        }

        private void btnEditDetailProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xls file (*.xls) | *.xls";
            string fileName = string.Empty;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(fileName);
                Worksheet ws = null;
                ws = (Worksheet)wb.Worksheets[1];
                int startTechCodePos = 5;
                int endTechCodePos = 5;
                string techCode = ((Range)ws.Cells[2, endTechCodePos]).Text.ToString();
                if (techCode == string.Empty) endTechCodePos -= 1;
                else
                {
                    while (techCode != string.Empty)
                    {
                        endTechCodePos += 1;
                        techCode = ((Range)ws.Cells[2, endTechCodePos]).Text.ToString();
                    }
                    endTechCodePos -= 1;
                }
                if (endTechCodePos >= startTechCodePos)
                {
                    TechnicalTestReturn t = this.DataSource as TechnicalTestReturn;
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Columns.Add(new DataColumn("ItemEncryptCode", typeof(string)));
                    dt.Columns.Add(new DataColumn("TechCode", typeof(string)));
                    dt.Columns.Add(new DataColumn("Description", typeof(string)));
                    int row = 3;
                    string itemEncryptCode = ((Range)ws.Cells[row, 3]).Text.ToString();
                    t.ProductDetailTable.Rows.Clear();
                    while (itemEncryptCode != string.Empty)
                    {
                        for (int i = startTechCodePos; i <= endTechCodePos; i++)
                        {
                            if (((Range)ws.Cells[row, i]).Value2 != null)
                            {
                                string result = ((Range)ws.Cells[row, i]).Value2.ToString();
                                //string result1 = result.Replace("0", "");
                                //result1 = result1.Replace(".", "");
                                //result1 = result1.Replace(",", "");
                                techCode = ((Range)ws.Cells[2, i]).Text.ToString();
                                TechnicalTest tt = this.lstTechnicalTest.Search("TechCode", techCode);
                                //if (result1 != string.Empty)
                                //{
                                    Guid returnID = t.ReturnID;
                                    int status = new TechnicalTestReturnBLL().CheckResultImportStatus(returnID, itemEncryptCode, techCode, true);
                                    if (status == -1)
                                    {
                                        DataRow dr = dt.NewRow();
                                        dr["ItemEncryptCode"] = itemEncryptCode;
                                        dr["TechCode"] = techCode;
                                        dr["Description"] = "Kết quả phân tích đã được trả ở phiếu khác";
                                        dt.Rows.Add(dr);
                                    }
                                    if (status == -2 || status == -3)
                                    {
                                        DataRow dr = dt.NewRow();
                                        dr["ItemEncryptCode"] = itemEncryptCode;
                                        dr["TechCode"] = techCode;
                                        dr["Description"] = "Kết quả không được yêu cầu phân tích";
                                        dt.Rows.Add(dr);
                                    }
                                    if (status == 0)
                                    {
                                        DataRow dr = t.ProductDetailTable.NewRow();
                                        dr["ItemEncryptCode"] = itemEncryptCode;
                                        dr["TechCode"] = techCode;
                                        if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Percent.ToString())
                                        {
                                            decimal d = 0;
                                            try
                                            {
                                                d = Convert.ToDecimal(result);
                                            }
                                            catch
                                            {
                                            }
                                            d = d / 100;
                                            dr["Result"] = d.ToString();
                                        }
                                        else if (tt != null && tt.ResultType == enumResultTypeTechnicalTest.Decimal.ToString())
                                        {
                                            decimal d = 0;
                                            try
                                            {
                                                d = Convert.ToDecimal(result);
                                            }
                                            catch
                                            {
                                            }
                                            d = Math.Round(d, 1);
                                            
                                            dr["Result"] = d.ToString().Replace(',','.');
                                        }
                                        else
                                        {
                                            dr["Result"] = result;
                                        }
                                        t.ProductDetailTable.Rows.Add(dr);
                                    }
                                //}
                            }
                        }
                        row++;
                        itemEncryptCode = ((Range)ws.Cells[row, 3]).Text.ToString();
                    }
                    this.RefreshDataOnGridProduct();
                    if (dt.Rows.Count > 0)
                    {
                        FormInfoImportTechnicalTestReturnDetail f = new FormInfoImportTechnicalTestReturnDetail(dt);
                        f.Show();
                    }
                }
                excelApp.Quit();
            }
        }

        private void bandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Department == enumKCSDepartment.QLCL)
            {
                if (bandedGridView1.FocusedRowHandle >= 0)
                {
                    DataRow dr = bandedGridView1.GetDataRow(bandedGridView1.FocusedRowHandle);
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

        private void bandedGridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (this.lstTechnicalTest == null) return;
            if (e.Column.FieldName.Length <= "Result".Length || e.Column.FieldName.Substring(0, 6) != "Result")
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
            if (e.Column.FieldName.Length <= "Result".Length || e.Column.FieldName.Substring(0, 6) != "Result")
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

