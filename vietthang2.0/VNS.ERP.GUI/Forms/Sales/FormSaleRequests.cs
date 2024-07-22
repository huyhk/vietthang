using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;
using VNS.Windows;
using System.Threading;
using Microsoft.Office.Interop.Excel;



namespace VNS.ERP.GUI.Sales
{
    public partial class FormSaleRequests : FormEditBase
    {
        private SaleRequestBLL _SaleRequestBLL = new SaleRequestBLL();
        private ListBase<SaleRequests> lstSaleRequests = new ListBase<SaleRequests>();
        private SaleReportBLL salaRp = null;
        string productType;

        public FormSaleRequests(string pProductType)
        {
            InitializeComponent();
            this.Business = _SaleRequestBLL;

            productType = pProductType;
        }
        public override void AddNewItem()
        {
            if (this.lookUpStockCode.ItemIndex >= 0)
            {
                FormSaleRequestDetails frm = new FormSaleRequestDetails(this.lookUpStockCode.EditValue.ToString(), this.productType);
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.AddNewItem();
                this.ShowChildForm(frm);
                if ((this.DataSource as ListBase<SaleRequests>).Count > 0)
                {
                    this.CurrentItem = frm.CurrentItem;

                    this.gridView.FocusedRowHandle = lstSaleRequests.IndexOf(this.CurrentItem as SaleRequests);
                }
                else
                {
                    this.CurrentItem = null;
                }

                gridControl.RefreshDataSource();
                this.RefreshButtons();
            }
        }
        public override void EditItem()
        {
            if (this.lookUpStockCode.ItemIndex >= 0)
            {
                FormSaleRequestDetails frm = new FormSaleRequestDetails(this.lookUpStockCode.EditValue.ToString(), this.productType);
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.CurrentItem = this.CurrentItem;
                frm.EditItem();
                this.ShowChildForm(frm);
                if ((this.DataSource as ListBase<SaleRequests>).Count > 0)
                {
                    this.CurrentItem = frm.CurrentItem;
                }
                else
                {
                    this.CurrentItem = null;
                }
                gridControl.RefreshDataSource();
            }
        }
        public override void Delete()
        {
            if ((this.currentItem as SaleRequests).IsFinished == true)
            {
                this.editMode = FormEditMode.VIEW;
                MessageBox.Show("Phiếu yêu cầu xuất bán này đã thực hiện, không cho phép xóa!!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                base.Delete();
            }
        }
        private void FormSaleRequests_Load(object sender, EventArgs e)
        {
            if (productType == string.Empty)
                this.Text = "Phiếu yêu cầu xuất nội bộ";
            this.lookUpStockCode.Properties.DataSource = (new StockBLL()).GetAllForMember(Contexts.CurrentUser.MemberID);
            this.lookUpStockCode.ItemIndex = 0;
            this.ItemLookCustomerCode.DataSource = (new CustomerBLL()).GetAll();
            this.ItemLookTransportCode.DataSource = new VendorBLL().GetForVanchuyen();// (new TransportBLL()).GetAll();
            salaRp = new SaleReportBLL();

            this.repDiscountID.DataSource = new CustomerDiscountListBLL().GetAll();

            GetData();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.lookUpStockCode.ItemIndex >= 0)
            {
                FormSaleRequestDetails frm = new FormSaleRequestDetails(this.lookUpStockCode.EditValue.ToString(), this.productType);
                SetFormPrivilege(frm);
                frm.DataSource = this.DataSource;
                frm.CurrentItem = this.CurrentItem;
                this.ShowChildForm(frm);
                if ((this.DataSource as ListBase<SaleRequests>).Count > 0)
                {
                    this.CurrentItem = frm.CurrentItem;
                }
                else
                {
                    this.CurrentItem = null;
                }
                gridControl.RefreshDataSource();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dtSource = null;
            dtSource = salaRp.GetItemCodeReports(this.lookUpStockCode.EditValue.ToString(), this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate);
            if (dtSource.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = false;
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                Workbook wb = excelApp.Workbooks.Add(Type.Missing);
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                ws.Cells[1, 1] = "BẢNG THỐNG KÊ HÀNG TỒN CHƯA XUẤT " + this.ucDatePeriodSelection1.PeriodText;
                ws.Cells[2, 1] = "Số TT";
                ws.Cells[2, 2] = "Tên hàng";
                ws.Cells[2, 3] = "Số lượng";
                int i = 3;
                int j = 1;
                int count=0;
                foreach (DataRow row in dtSource.Rows)
                {
                    j = 1;
                    count += 1;
                    ws.Cells[i, j] = count;
                    Range range = (Range)ws.get_Range("A"+i.ToString(), "A"+j.ToString());
                    range.EntireRow.RowHeight = 15;
                   
              //      range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlColumnDataType.   XlVAlign.xlVAlignCenter;

                    j += 1;
                    ws.Cells[i, j] = row["ItemCode"];
                    Range range3 = (Range)ws.get_Range("B" + i.ToString(), "B" + j.ToString());
                    range3.EntireRow.RowHeight = 15;
                    range3.EntireColumn.ColumnWidth = 25;
                    j += 1;
                    ws.Cells[i, j] = row["QuantityReq"];
                    Range range4 = (Range)ws.get_Range("C" + i.ToString(), "C" + j.ToString());
                    range4.EntireRow.RowHeight =15;
                 //   range4.FormatConditions=
                 //   range4.Cells.FormatConditions =MaskedTextResultHint.
                 
                    i += 1;
                }
                ws.Cells[i, 3] = "=Sum(C3:C" + (i-1)+")";
                Range range5 = (Range)ws.Cells[i, 3];
                Range range1 = (Range)ws.Cells[1, 1];
                range1.EntireRow.RowHeight = 20;
                range1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
             //   range.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
             //   range.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
                range1.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
             //   range1.Merge(Type.Missing);
                range5.EntireRow.RowHeight = 20;
                range5.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                ws.Cells[i, 2] = "Tổng cộng: ";
                //MergeRange();
                //Microsoft.Office.Interop.Excel.Style style = excelApp.ThisWorkbook.Styles.Add("NewStyle", range);
                //style.Font.Name = "Verdana";
                //style.Font.Size = 12;
                //style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                //style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
                //style.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
                excelApp.Visible = true;
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }
        void GetData()
        {
            lstSaleRequests = _SaleRequestBLL.GetObjectByTimeStockCode(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, this.lookUpStockCode.EditValue.ToString(), this.productType);
            this.DataSource = lstSaleRequests;
        }

        private void btnSumItem_Click(object sender, EventArgs e)
        {
            SaleRequests obj = new SaleRequests();
            obj.Details = new ListBase<SaleRequestDetails>();
            obj.StockCode = this.lookUpStockCode.Text;

            bool bAll = this.chkAll.Checked;

            if (bAll)
            {
                gridView.SelectAll();
                obj.SaleRequestNo = this.ucDatePeriodSelection1.PeriodText;
            }

            int[] aI = gridView.GetSelectedRows();
            if (aI.Length == 0)
            {
                return;
            }

            foreach (int i in aI)
            {
                SaleRequests s = gridView.GetRow(i) as SaleRequests;
                if (s.Details == null)
                    s.Details = (new SaleRequestBLL()).GetSaleRequestDetailByID(s.SaleRequestID);

                foreach (SaleRequestDetails d in s.Details)
                {
                    SaleRequestDetails dR = obj.Details.Search("ItemCode", d.ItemCode);
                    if (dR == null)
                    {
                        dR = new SaleRequestDetails();
                        dR.ItemCode = d.ItemCode;
                        dR.QuantityReq = d.QuantityReq;
                        if (bAll)
                            dR.Quantity = d.Quantity;

                        obj.Details.Add(dR);
                    }
                    else
                    {
                        dR.QuantityReq += d.QuantityReq;
                        if (bAll)
                            dR.Quantity += d.Quantity;
                    }
                }
                if (!bAll)
                    obj.SaleRequestNo += " " + s.SaleRequestNo;
            }

            obj.Details.Sort("ItemCode", ListSortDirection.Ascending);

            RpSaleRequestList rp = new RpSaleRequestList();
            rp.BindDataMaster(obj);
            rp.ShowPreview();
        }
    }
}