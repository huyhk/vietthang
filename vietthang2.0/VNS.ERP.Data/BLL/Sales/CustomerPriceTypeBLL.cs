using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Sales
{
    #region CustomerPriceTypeBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of CustomerPriceType.
    /// </summary>
    public class CustomerPriceTypeBLL : IBusiness
    {
        private CustomerPriceTypeDAL dal = new CustomerPriceTypeDAL();
        public CustomerPriceTypeBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<CustomerPriceType> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<CustomerPriceType> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(CustomerPriceType t)
        {
            return dal.Insert(t);
        }


        /// <summary>
        /// Updates an existing object in database 
        /// </summary>
        public int Update(CustomerPriceType t)
        {
            return dal.Update(t);
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
        public int Delete(CustomerPriceType t)
        {

            return dal.Delete(t.PriceID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as CustomerPriceType);
        }

        public int Update(object obj)
        {
            return this.Update(obj as CustomerPriceType);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as CustomerPriceType);
        }

        #endregion

    }
    #endregion
}