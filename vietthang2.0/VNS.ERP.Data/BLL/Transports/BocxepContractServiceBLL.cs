using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    #region BocxepContractServiceBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of BocxepContractService.
    /// </summary>
    public class BocxepContractServiceBLL : IBusiness
    {
        private BocxepContractServiceDAL dal = new BocxepContractServiceDAL();
        public BocxepContractServiceBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        //public ListBase<BocxepContractService> GetAll()
        //{
        //    return dal.GetObjectAll();
        //}
        /// <summary>
        /// Gets all objects 
        /// </summary>
        //public ListBase<BocxepContractService> GetDynamic(string whereCondition, string orderExpression)
        //{
        //    return dal.GetObjectDynamic(whereCondition, orderExpression);
        //}
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(BocxepContractService t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (BocxepService bs in t.ListBocxepService)
                {
                    bs.ServiceID = t.ServiceID;
                    iError = dal.InsertBocxepService(bs);
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
        public int Update(BocxepContractService t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
                iError = dal.DeleteBocxepService(t.ServiceID);
            if (iError == 0)
            {
                foreach (BocxepService bs in t.ListBocxepService)
                {
                    bs.ServiceID = t.ServiceID;
                    iError = dal.InsertBocxepService(bs);
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
        public int Delete(Guid serviceID)
        {

            return dal.Delete(serviceID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(BocxepContractService t)
        {

            return dal.Delete(t.ServiceID);
        }

        public ListBase<BocxepContractService> GetByContractNo(string contractNo)
        {
            return dal.GetByContractNo(contractNo);
        }
        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as BocxepContractService);
        }

        public int Update(object obj)
        {
            return this.Update(obj as BocxepContractService);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as BocxepContractService);
        }

        #endregion

    }
    #endregion
}