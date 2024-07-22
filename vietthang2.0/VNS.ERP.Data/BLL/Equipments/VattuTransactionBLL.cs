using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Equipments
{
    #region VattuTransactionBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of VattuTransaction.
    /// </summary>
    public class VattuTransactionBLL : IBusiness
    {
        private VattuTransactionDAL dal = new VattuTransactionDAL();
        public VattuTransactionBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<VattuTransaction> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<VattuTransaction> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(VattuTransaction t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (VattuTransactionDetail detail in t.ListVattuTransactionDetail)
                {
                    detail.TransactionID = t.TransactionID;
                    iError = dal.InsertDetail(detail);
                    if (iError != 0)
                        break;
                }
                //if (iError == 0)
                //{
                //    foreach (VattuTransactionDetail detail in t.ListVattuTransactionDetailOld)
                //    {
                //        detail.TransactionID = t.TransactionID;
                //        iError = dal.InsertDetail(detail);
                //        if (iError != 0)
                //            break;
                //    }
                //}
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }
        /// <summary>
        /// Delete all rows 
        /// </summary>
        public int DeleteAll()
        {
            return dal.DeleteAll();
        }
        /// <summary>
        /// Delete rows by dynamic criteria
        /// </summary>
        public int DeleteDynamic(string whereCondidion)
        {
            return dal.DeleteDynamic(whereCondidion);
        }

        /// <summary>
        /// Updates an existing object in database 
        /// </summary>
        public int Update(VattuTransaction t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal.DeleteDetail(t.TransactionID);
                if (iError == 0)
                {
                    foreach (VattuTransactionDetail detail in t.ListVattuTransactionDetail)
                    {
                        detail.TransactionID = t.TransactionID;
                        iError = dal.InsertDetail(detail);
                        if (iError != 0)
                            break;
                    }
                    //if (iError == 0)
                    //{
                    //    foreach (VattuTransactionDetail detail in t.ListVattuTransactionDetailOld)
                    //    {
                    //        detail.TransactionID = t.TransactionID;
                    //        iError = dal.InsertDetail(detail);
                    //        if (iError != 0)
                    //            break;
                    //    }
                    //}
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
        /// Returns an object by ID
        /// </summary>		
        public VattuTransaction GetByID(Guid transactionID)
        {

            return dal.GetByID(transactionID);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(Guid transactionID)
        {

            return dal.Delete(transactionID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(VattuTransaction t)
        {

            return dal.Delete(t.TransactionID);
        }

        public ListBase<VattuTransaction> GetByStockAndTypeAndDate(string stockCode, string transactionType, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetByStockAndTypeAndDate(stockCode, transactionType, fromDate, toDate);
            return Ds2List(ds);
        }
        private ListBase<VattuTransaction> Ds2List(DataSet ds)
        {
            ListBase<VattuTransaction> lst = new ListBase<VattuTransaction>();
            DataRelation dr = ds.Relations.Add("VattuTransaction", ds.Tables[0].Columns["TransactionID"], ds.Tables[1].Columns["TransactionID"]);
            foreach (DataRow rowH in ds.Tables[0].Rows)
            {
                VattuTransaction objH = new VattuTransaction();
                objH.FromDataRow(rowH);
                foreach (DataRow rowD in rowH.GetChildRows(dr))
                {
                    VattuTransactionDetail objD = new VattuTransactionDetail();
                    objD.FromDataRow(rowD);
                    //if (objD.VattuOldType == string.Empty)
                        objH.ListVattuTransactionDetail.Add(objD);
                    //else
                    //    objH.ListVattuTransactionDetailOld.Add(objD);
                }
                lst.Add(objH);
            }
            return lst;
        }

        public string GetNextTransactionNo(string typeCode, DateTime date, string stockCode)
        {
            return dal.GetNextTransactionNo(typeCode, date, stockCode);
        }
        #endregion

        #region Transaction Type
        public ListBase<VattuTransactionType> GetTypes(string transactionType)
        {
            return dal.GetVattuTransactionTypeDynamic("InOutType='" + transactionType + "'","TypeCode2");
        }
        //public ListBase<VattuTransactionType> Get
        #endregion
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as VattuTransaction);
        }

        public int Update(object obj)
        {
            return this.Update(obj as VattuTransaction);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as VattuTransaction);
        }

        #endregion

    }
    #endregion
}
