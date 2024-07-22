using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class SaleRequestBLL:IBusiness
    {
        private SaleRequestDAL dal = new SaleRequestDAL();
        private SaleRequestDetailDAL dal1;
        public SaleRequestBLL()
        { }
        public SaleRequests GetItemMaxInvoiceNo(string invoiceMau)
        {
            return dal.GetItemMaxInvoiceNo(invoiceMau);
        }
        public SaleRequests GetByCurrentInvoiceSeri()
        {
            return dal.GetByCurrentInvoiceSeri();
        }
        public ListBase<SaleRequests> GetAll()
        {
            return dal.GetObjectAll();
        }
        public SaleRequests GetBySaleRequestNo(string saleRequestNo)
        {
            return dal.GetBySaleRequestNo(saleRequestNo);
        }
        public int Insert(SaleRequests t)
        {
            int iError=0;
            bool alreadyOpen = false;
            t.UserCreated = Contexts.CurrentUser.LoginName;
            try
            {
                if (dal.DBHelper.State != System.Data.ConnectionState.Open)
                    dal.DBHelper.Open();
                else
                    alreadyOpen = true;
                dal1 = new SaleRequestDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    foreach (SaleRequestDetails Detail in t.Details)
                    {
                        Detail.SaleRequestID = t.SaleRequestID;
                        if (iError == 0)
                        {
                            if (Detail.QuantityReq > 0)
                            {
                                iError = dal1.Insert(Detail);
                            }
                        }
                        else
                            break;
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestBLL", "Insert(SaleRequests t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                   dal.Commit();
               else
                   dal.Rollback();
                if (!alreadyOpen)
                    dal.Close();
            }
            return iError;

        }
        public int Update(SaleRequests t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            try
            {
                if (dal.DBHelper.State != System.Data.ConnectionState.Open)
                    dal.DBHelper.Open();
                else
                    alreadyOpen = true;
                dal1 = new SaleRequestDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                iError = dal.Update(t);
                if (iError == 0)
                {
                    iError= dal1.Delete(t.SaleRequestID);
                    if (iError == 0)
                    {
                        foreach (SaleRequestDetails Detail in t.Details)
                        {
                            Detail.SaleRequestID = t.SaleRequestID;
                            if (iError == 0)
                            {
                                if (Detail.QuantityReq > 0)
                                {
                                    iError = dal1.Insert(Detail);
                                }
                            }
                            else
                                break;
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestBLL", "Update(SaleRequests t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                if (!alreadyOpen)
                    dal.Close();
            }
            return iError;
        }

        public int Delete(SaleRequests t)
        {
            return dal.Delete(t);
        }
        public ListBase<SaleRequests> GetAllSaleRequestByStockCode(string _StockCode)
        {
            return dal.GetAllSaleRequestByStockCode(_StockCode);
        }

        public ListBase<SaleRequests> GetObjectByTimeStockCode(DateTime startDate, DateTime endDate, string stockCode, string productType)
        {
            return dal.GetObjectByTimeStockCode(startDate, endDate, stockCode, productType);
        }
        //public ListBase<SaleRequests> GetSaleRequestByStockCode(string _StockCode)
        //{
        //    return dal.GetSaleRequestByStockCode(_StockCode);
        //}
        public ListBase<SaleRequestDetails> GetSaleRequestDetailByID(Guid _SaleRequestID)
        {
            dal1 = new SaleRequestDetailDAL(dal.DBHelper);
            return dal1.GetSaleRequestDetailByID(_SaleRequestID);
        }

        public DataTable GetForSTCheck(string _StockCode, DateTime d, string currentSoDH)
        {
            return dal.GetForSTCheck(_StockCode, d, currentSoDH);
        }
        public DataSet GetSaleRequestDetailByIsFinished_ID(string customerOrderNo)
        {
            dal1 = new SaleRequestDetailDAL(dal.DBHelper);
            return dal1.GetSaleRequestDetailByIsFinished_ID(customerOrderNo,true);
        }
        public DataTable ReportsSaleRequestsForItems(DateTime tungay, DateTime denngay, string productType)
        {
            DataTable dt = dal.ReportsSaleRequestsForItems(tungay, denngay, productType);
            Guid oldSaleID = new Guid();
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dt.Rows[i];
                Guid saleID = (Guid) row["SaleRequestID"];
                if (saleID != oldSaleID)
                    oldSaleID = saleID;
                else
                {
                    row.BeginEdit();
                    row["InvoiceAmount"] = 0;
                    row.EndEdit();
                }
            }
            return dt;
        }
        public SaleRequests GetTopBySuffixSaleRequestNo(string suffix)
        {
            return dal.GetTopBySuffixSaleRequestNo(suffix);
        }

        public ListBase<SaleRequests> GetByBranchCode(DateTime startDate, DateTime endDate, string branchCode)
        { return dal.GetByBranchCode(startDate, endDate, branchCode); }

        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as SaleRequests);
        }

        public int Update(object obj)
        {
            return this.Update(obj as SaleRequests);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as SaleRequests);
        }

        #endregion

        public int UpdateDiscountID(Guid SaleRequestID, Guid DiscountID)
        { return dal.UpdateDiscountID(SaleRequestID, DiscountID); }
    }
}
