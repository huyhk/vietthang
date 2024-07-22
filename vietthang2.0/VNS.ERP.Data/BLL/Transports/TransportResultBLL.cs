using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Transports
{
    #region TransportResultBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of TransportResult.
    /// </summary>
    public class TransportResultBLL : IBusiness
    {
        private TransportResultDAL dal = new TransportResultDAL();
        public TransportResultBLL()
        {
        }
        #region Stored procedure wrappers

        public ListBase<TransportResult> GetByRouteAndDate(string routeCode, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetByRouteAndDate(routeCode, fromDate, toDate);
            return Ds2List(ds);
        }
        public ListBase<TransportResult> Ds2List(DataSet ds)
        {
            ListBase<TransportResult> lst = new ListBase<TransportResult>();
            if (ds != null)
            {
                DataRelation dr1 = ds.Relations.Add(ds.Tables[0].Columns["ResultID"], ds.Tables[1].Columns["ResultID"]);
                DataRelation dr2 = ds.Relations.Add(ds.Tables[1].Columns["Detail1ID"], ds.Tables[2].Columns["Detail1ID"]);
                DataRelation dr3 = ds.Relations.Add(ds.Tables[1].Columns["Detail1ID"], ds.Tables[3].Columns["Detail1ID"]);

                foreach (DataRow rowH in ds.Tables[0].Rows)
                {
                    TransportResult oH = new TransportResult(rowH);
                    foreach (DataRow rowD1 in rowH.GetChildRows(dr1))
                    {
                        TransportResultDetail1 oD1 = new TransportResultDetail1(rowD1);
                        foreach (DataRow rowD2 in rowD1.GetChildRows(dr2))
                        {
                            oD1.ListTransportResultDetail2.Add(new TransportResultDetail2(rowD2));
                        }
                        foreach (DataRow rowD3 in rowD1.GetChildRows(dr3))
                        {
                            oD1.ListTransportResultDetail3.Add(new TransportResultDetail3(rowD3));
                        }
                        oH.ListTransportResultDetail1.Add(oD1);
                    }
                    lst.Add(oH);
                }
            }
            return lst;
        }
        ///// <summary>
        ///// Gets all objects 
        ///// </summary>
        //public ListBase<TransportResult> GetAll()
        //{
        //    return dal.GetObjectAll();
        //}
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportResult> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(TransportResult t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (TransportResultDetail1 dt1 in t.ListTransportResultDetail1)
                {
                    dt1.ResultID = t.ResultID;
                    iError = dal.InsertDetail1(dt1);
                    if (iError == 0)
                    {
                        foreach (TransportResultDetail2 dt2 in dt1.ListTransportResultDetail2)
                        {
                            dt2.Detail1ID = dt1.Detail1ID;
                            iError = dal.InsertDetail2(dt2);
                            if (iError != 0)
                                break;
                        }
                    }
                    if (iError == 0)
                    {
                        foreach (TransportResultDetail3 dt3 in dt1.ListTransportResultDetail3)
                        {
                            dt3.Detail1ID = dt1.Detail1ID;
                            iError = dal.InsertDetail3(dt3);
                            if (iError != 0)
                                break;
                        }
                    }
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
        public int Update(TransportResult t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal.DeleteDetail1(t.ResultID);
            }
            if (iError == 0)
            {
                foreach (TransportResultDetail1 dt1 in t.ListTransportResultDetail1)
                {
                    dt1.ResultID = t.ResultID;
                    iError = dal.InsertDetail1(dt1);
                    if (iError == 0)
                    {
                        foreach (TransportResultDetail2 dt2 in dt1.ListTransportResultDetail2)
                        {
                            dt2.Detail1ID = dt1.Detail1ID;
                            iError = dal.InsertDetail2(dt2);
                            if (iError != 0)
                                break;
                        }
                    }
                    if (iError == 0)
                    {
                        foreach (TransportResultDetail3 dt3 in dt1.ListTransportResultDetail3)
                        {
                            dt3.Detail1ID = dt1.Detail1ID;
                            iError = dal.InsertDetail3(dt3);
                            if (iError != 0)
                                break;
                        }
                    }
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
        public int Delete(Guid resultID)
        {

            return dal.Delete(resultID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(TransportResult t)
        {

            return dal.Delete(t.ResultID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportResult);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportResult);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportResult);
        }

        #endregion

        //public DataSet GetStockTransaction(string routeCode, string subjectCode, string pTVC, DateTime fromDate, DateTime toDate)
        //{
        //    return dal.GetStockTransaction(routeCode, subjectCode, pTVC, fromDate, toDate);
        //}
        public ListBase<StockTransaction> GetStockTransaction(string routeCode, string subjectCode, string pTVC, DateTime fromDate, DateTime toDate)
        {
            ListBase<StockTransaction> lst = new ListBase<StockTransaction>();
            DataSet ds = dal.GetStockTransaction(routeCode, subjectCode, pTVC, fromDate, toDate);
            if (ds != null && ds.Tables.Count > 0)
            {
                DataRelation dr = ds.Relations.Add(ds.Tables[0].Columns["TransactionID"], ds.Tables[1].Columns["TransactionID"]);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    StockTransaction oS = new StockTransaction(row);
                    oS.Details = new ListBase<StockTransactionSumDetail>();
                    foreach (DataRow rowD in row.GetChildRows(dr))
                        oS.Details.Add(new StockTransactionSumDetail(rowD));
                    lst.Add(oS);
                }
            }
            return lst;
        }

    }
    #endregion
}