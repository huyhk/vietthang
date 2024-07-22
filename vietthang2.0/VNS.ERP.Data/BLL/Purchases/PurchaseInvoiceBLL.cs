using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    #region PurchaseInvoiceBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of PurchaseInvoice.
    /// </summary>
    public class PurchaseInvoiceBLL : IBusiness
    {
        private PurchaseInvoiceDAL dal = new PurchaseInvoiceDAL();
        public PurchaseInvoiceBLL()
        {
        }
        #region Stored procedure wrappers

        public ListBase<PurchaseInvoice> GetByDateAndSubject(DateTime fromDate, DateTime toDate, string subjectCode)
        {
            return dal.GetByDateAndSubject(fromDate, toDate, subjectCode);
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<PurchaseInvoice> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(PurchaseInvoice t)
        {
            int iError = 0;
            t.UserCreated = Contexts.CurrentUser.LoginName;
            t.DateCreated = DateTime.Today;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (PurchaseInvoiceDetail d in t.ListPurchaseInvoiceDetail)
                {
                    d.InvoiceID = t.InvoiceID;
                    iError = dal.InsertDetail(d);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }
        /// <summary>
        /// Updates an existing object in database 
        /// </summary>
        public int Update(PurchaseInvoice t)
        {
            int iError = 0;
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            t.DateUpdated = DateTime.Today;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal.DeleteDetail(t.InvoiceID);
            }
            if (iError == 0)
            {
                foreach (PurchaseInvoiceDetail d in t.ListPurchaseInvoiceDetail)
                {
                    d.InvoiceID = t.InvoiceID;
                    iError = dal.InsertDetail(d);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(Guid invoiceID)
        {
            return dal.Delete(invoiceID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(PurchaseInvoice t)
        {
            return dal.Delete(t.InvoiceID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as PurchaseInvoice);
        }

        public int Update(object obj)
        {
            return this.Update(obj as PurchaseInvoice);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as PurchaseInvoice);
        }

        #endregion

        public DataTable GetTransactionNotInvoiced(string subjectCode, Guid invoiceID)
        {
            return dal.GetTransactionNotInvoiced(subjectCode, invoiceID);
        }
    }
    #endregion
}