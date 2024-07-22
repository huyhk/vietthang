using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Transports
{
    #region TransportCompensationPriceBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of TransportCompensationPrice.
    /// </summary>
    public class TransportCompensationPriceBLL : IBusiness
    {
        private TransportCompensationPriceDAL dal = new TransportCompensationPriceDAL();
        public TransportCompensationPriceBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportCompensationPrice> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TransportCompensationPrice> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(TransportCompensationPrice t)
        {
            return dal.Insert(t);
        }

        /// <summary>
        /// Updates an existing object in database 
        /// </summary>
        public int Update(TransportCompensationPrice t)
        {
            return dal.Update(t);
        }


        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(Guid compensationID)
        {

            return dal.Delete(compensationID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(TransportCompensationPrice t)
        {

            return dal.Delete(t.CompensationID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportCompensationPrice);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportCompensationPrice);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportCompensationPrice);
        }

        #endregion

    }
    #endregion
}