using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    #region TransportContractBatchBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of TransportContractBatch.
    /// </summary>
    public class TransportContractBatchBLL : IBusiness
    {
        private TransportContractBatchDAL dal = new TransportContractBatchDAL();
        public TransportContractBatchBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportContractBatch> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportContractBatch> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(TransportContractBatch t)
        {
            return dal.Insert(t);
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
        public int Update(TransportContractBatch t)
        {
            return dal.Update(t);
        }

        /// <summary>
        /// Returns an object by ID
        /// </summary>		
        public TransportContractBatch GetByID(Guid batchID)
        {

            return dal.GetByID(batchID);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(Guid batchID)
        {

            return dal.Delete(batchID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(TransportContractBatch t)
        {

            return dal.Delete(t.BatchID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportContractBatch);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportContractBatch);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportContractBatch);
        }

        #endregion

        public ListBase<TransportContractBatch> GetByContractNo(string contractNo)
        { return dal.GetByContractNo(contractNo); }

    }
    #endregion
}
