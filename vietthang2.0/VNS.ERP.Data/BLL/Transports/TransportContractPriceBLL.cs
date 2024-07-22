using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Transports
{
    #region TransportContractPriceBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of TransportContractPrice.
    /// </summary>
    public class TransportContractPriceBLL : IBusiness
    {
        private TransportContractPriceDAL dal = new TransportContractPriceDAL();
        public TransportContractPriceBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportContractPrice> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportContractPrice> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(TransportContractPrice t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (TransportContractPriceItem item in t.ListTransportContractPriceItem)
                {
                    item.PriceID = t.PriceID;
                    iError = dal.InsertItem(item);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
            {
                foreach (TransportContractPriceDetail detail in t.ListTransportContractPriceDetail)
                {
                    detail.PriceID = t.PriceID;
                    iError = dal.InsertDetail(detail);
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
        public int Update(TransportContractPrice t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
                iError = dal.DeleteItem(t.PriceID);
            if (iError == 0)
                iError = dal.DeleteDetail(t.PriceID);
            if (iError == 0)
            {
                foreach (TransportContractPriceItem item in t.ListTransportContractPriceItem)
                {
                    item.PriceID = t.PriceID;
                    iError = dal.InsertItem(item);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
            {
                foreach (TransportContractPriceDetail detail in t.ListTransportContractPriceDetail)
                {
                    detail.PriceID = t.PriceID;
                    iError = dal.InsertDetail(detail);
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
        public int Delete(Guid priceID)
        {

            return dal.Delete(priceID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(TransportContractPrice t)
        {

            return dal.Delete(t.PriceID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportContractPrice);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportContractPrice);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportContractPrice);
        }

        #endregion

    }
    #endregion
}