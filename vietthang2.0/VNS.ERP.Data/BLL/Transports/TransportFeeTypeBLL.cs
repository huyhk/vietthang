using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    #region TransportFeeTypeBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of TransportFeeType.
    /// </summary>
    public class TransportFeeTypeBLL : IBusiness
    {
        private TransportFeeTypeDAL dal = new TransportFeeTypeDAL();
        public TransportFeeTypeBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportFeeType> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportFeeType> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(TransportFeeType t)
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
        public int Update(TransportFeeType t)
        {
            return dal.Update(t);
        }

        /// <summary>
        /// Returns an object by ID
        /// </summary>		
        public TransportFeeType GetByID(string typeCode)
        {

            return dal.GetByID(typeCode);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(string typeCode)
        {

            return dal.Delete(typeCode);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(TransportFeeType t)
        {

            return dal.Delete(t.TypeCode);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportFeeType);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportFeeType);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportFeeType);
        }

        #endregion

    }
    #endregion
}