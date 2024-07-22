using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
    public class VesselTransactionBLL : IBusiness
    {
        VesselTransactionDAL dal = new VesselTransactionDAL();
        VesselTransactionInvoiceDAL dalDetail = null;
        VesselTransactionInvoiceDetailDAL dalDetailInvoice = null;
        public VesselTransactionBLL() { }
        public ListBase<VesselTransaction> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<VesselTransaction> GetForPeriod(DateTime startDate, DateTime endDate)
        {
            return dal.GetForPeriod(startDate,endDate);
        }
        public int Insert(VesselTransaction t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new VesselTransactionInvoiceDAL(dal.DBHelper);
            dalDetailInvoice = new VesselTransactionInvoiceDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (VesselTransactionInvoice detail in t.DetailInvoice)
                {
                    detail.TransactionID = t.TransactionID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
                    }
                    if (iError == 0)
                    {
                        foreach (VesselTransactionInvoiceDetail detailInvoice in detail.Detail)
                        {
                            detailInvoice.InvoiceID = detail.InvoiceID;
                            if (iError == 0)
                            {
                                iError = dalDetailInvoice.Insert(detailInvoice);
                            }
                            if (iError != 0) break;
                        }
                    }
                    if (iError != 0) break;
                }
            }

            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Update(VesselTransaction t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new VesselTransactionInvoiceDAL(dal.DBHelper);
            dalDetailInvoice = new VesselTransactionInvoiceDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.TransactionID);
            }
            if (iError == 0)
            {
                foreach (VesselTransactionInvoice detail in t.DetailInvoice)
                {
                    detail.TransactionID = t.TransactionID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
                    }
                    if (iError == 0)
                    {
                        foreach (VesselTransactionInvoiceDetail detailInvoice in detail.Detail)
                        {
                            detailInvoice.InvoiceID = detail.InvoiceID;
                            if (iError == 0)
                            {
                                iError = dalDetailInvoice.Insert(detailInvoice);
                            }
                            if (iError != 0) break;
                        }
                    }
                    if (iError != 0) break;
                }
            }

            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Delete(VesselTransaction t)
        {
            return dal.Delete(t);
        }

        public DataTable GetSearch()
        {
            return dal.GetSearch();
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as VesselTransaction);
        }
        public int Update(object obj)
        {
            return this.Update(obj as VesselTransaction);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as VesselTransaction);
        }
        #endregion


    }
}
