using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class FormCheckWeightItem : FormBase
    {
        public ListBase<StockTransactionSumDetail> lststsd = new ListBase<StockTransactionSumDetail>();
        public ListBase<WeightItem> lstWeightItemChose = new ListBase<WeightItem>();
        GridCheckMarksSelection sel;
        private bool isReceive;

    /// <summary>
        /// Not use
    /// </summary>
        public FormCheckWeightItem()
        {
            InitializeComponent();
            //this.gridControl1.DataSource = new WeightItemBLL().GetByIsReceive(true);
        }
        /// <summary>
        /// Use to call from FormList
        /// </summary>
        /// <param name="_TransactionID">TransactionID of CurrentItem in FormList</param>
        /// <param name="_IsReceive"></param>
        /// <param name="_StockCode"></param>
        public FormCheckWeightItem(Guid _TransactionID, bool _IsReceive, string _StockCode)
        {
            InitializeComponent();
            lookUpEditDVGiao.DataSource = new VendorBLL().GetAll();
            lookupEditDVNhan.DataSource = new CustomerBLL().GetAll();
            lookUpEditDVVanChuyen.DataSource = new VendorBLL().GetForVanchuyen();// new TransportBLL().GetAll();
            lookUpEditKhoGiao.DataSource = new StockBLL().GetAll();
            lookUpEditKhoNhan.DataSource = new StockBLL().GetAll();
            isReceive = _IsReceive;
            if (isReceive)
            {
                colDVNhan.Visible = false;
                colKhoNhan.Visible = false;
            }
            else
            {
                colDVGiao.Visible = false;
                colKhoGiao.Visible = false;
            }
            this.gridControl1.DataSource = new WeightItemBLL().GetForCheckFromStockTransaction(_TransactionID, _IsReceive, _StockCode);
            this.repositoryItemLookUpEdit2.DataSource = new EmployeeBLL().GetAll();
            this.repositoryItemLookUpEdit1.DataSource = new ItemBLL().GetAll();
            sel = new GridCheckMarksSelection(gridView1);
            sel.CheckMarkColumn.VisibleIndex = 0;
            int count = (gridControl1.DataSource as ListBase<WeightItem>).Count;
            sel.ClearSelection();
            for (int i = 0; i < count; i++)
            {
                if ((gridControl1.DataSource as ListBase<WeightItem>)[i].TransactionID != Guid.Empty && (gridControl1.DataSource as ListBase<WeightItem>)[i].TransactionID != null)
                {
                    sel.SelectRow(i, true);
                    gridView1.FocusedRowHandle = i;
                }
            }
            if (StockTransactionBLL.lstWeightItemChose != null && StockTransactionBLL.lstWeightItemChose.Count > 0)
            {
                foreach (WeightItem wi in StockTransactionBLL.lstWeightItemChose)
                {
                    WeightItem wi1 = (gridControl1.DataSource as ListBase<WeightItem>).Search("WeightID", wi.WeightID);
                    if (wi1 != null)
                    {
                        int j = (gridControl1.DataSource as ListBase<WeightItem>).IndexOf(wi1);
                        sel.SelectRow(j, true);
                        gridView1.FocusedRowHandle = j;
                    }
                }
            }

            //sel.CheckMarkColumn.SortIndex = 0;
            //sel.CheckMarkColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            colWeightDate.SortIndex = 0;
            colWeightDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            colWeightDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            colWeightCode.SortIndex = 1;
            colWeightCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            colWeightCode.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool NotFound=true;
            ListBase<StockTransactionSumDetail> lststsd1;
            StockTransactionBLL stbll = new StockTransactionBLL();
            for (int i = 0; i < sel.SelectedCount; i++)
            {
                WeightItem wi = new WeightItem();
                wi.WeightID = (sel.GetSelectedRow(i) as WeightItem).WeightID;
                lststsd1 = stbll.GetDetailsByWeightIDInWeighItemResult(wi.WeightID, isReceive);
                lstWeightItemChose.Add(wi);
                if (isReceive)
                {
                    foreach (StockTransactionSumDetail stsd in lststsd1)
                    {
                        if (lststsd.Count > 0)
                        {
                            NotFound = true;
                            foreach (StockTransactionSumDetail stsd2 in lststsd)
                            {
                                if (NotFound)
                                {
                                    if (stsd2.ItemCode == stsd.ItemCode)
                                    {
                                        stsd2.Quantity += stsd.Quantity;
                                        stsd2.WrappingCounter += stsd.WrappingCounter;
                                        stsd2.QuantityInclWrapping += stsd.QuantityInclWrapping;
                                        foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                        {
                                            StockTransactionDetail stocktd1 = stsd2.lstStockTransactionDetail.Search("InLocation", std.InLocation);
                                            if (stocktd1 != null)
                                            {
                                                stocktd1.Quantity += std.Quantity;
                                            }
                                            else
                                            {
                                                stocktd1 = new StockTransactionDetail();
                                                stocktd1.ItemCode = std.ItemCode;
                                                stocktd1.Quantity = std.Quantity;
                                                stocktd1.InLocation = std.InLocation;
                                                stsd2.lstStockTransactionDetail.Add(stocktd1);
                                            }
                                        }
                                        NotFound = false;
                                        break;
                                    }
                                }
                            }
                        }

                        if (NotFound)
                        {
                            StockTransactionSumDetail stsd1 = (StockTransactionSumDetail)stsd.Clone();
                            lststsd.Add(stsd1);
                        }
                    }
                }
                else
                {
                    foreach (StockTransactionSumDetail stsd in lststsd1)
                    {
                        if (lststsd.Count > 0)
                        {
                            NotFound = true;
                            foreach (StockTransactionSumDetail stsd2 in lststsd)
                            {
                                if (NotFound)
                                {
                                    if (stsd2.ItemCode == stsd.ItemCode)
                                    {
                                        stsd2.Quantity += stsd.Quantity;
                                        foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                        {
                                            StockTransactionDetail stocktd1 = stsd2.lstStockTransactionDetail.Search("OutLocation", std.OutLocation);
                                            if (stocktd1 != null)
                                            {
                                                stocktd1.Quantity += std.Quantity;
                                            }
                                            else
                                            {
                                                stocktd1 = new StockTransactionDetail();
                                                stocktd1.ItemCode = std.ItemCode;
                                                stocktd1.Quantity = std.Quantity;
                                                stocktd1.OutLocation = std.OutLocation;
                                                stsd2.lstStockTransactionDetail.Add(stocktd1);
                                            }
                                        }
                                        NotFound = false;
                                        break;
                                    }
                                }
                            }
                        }

                        if (NotFound)
                        {
                            StockTransactionSumDetail stsd1 = (StockTransactionSumDetail)stsd.Clone();
                            lststsd.Add(stsd1);
                        }
                    }
                   
                }
               
              
            }
            foreach (StockTransactionSumDetail stsd2 in lststsd)
            {
                stsd2.Quantity = 0;
                foreach (StockTransactionDetail std in stsd2.lstStockTransactionDetail)
                {
                    stsd2.Quantity += std.Quantity;
                }

            }
            if (sel.SelectedCount > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}