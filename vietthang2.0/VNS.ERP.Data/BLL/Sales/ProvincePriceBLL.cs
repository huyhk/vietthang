using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Sales
{
    #region ProvincePriceBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of CustomerPriceType.
    /// </summary>
    public class ProvincePriceBLL : IBusiness
    {
        private ProvincePriceDAL dal = new ProvincePriceDAL();
        public ProvincePriceBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<ProvincePrice> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<ProvincePrice> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(ProvincePrice t)
        {
            return dal.Insert(t);
        }


        /// <summary>
        /// Updates an existing object in database 
        /// </summary>
        public int Update(ProvincePrice t)
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
        public int Delete(ProvincePrice t)
        {

            return dal.Delete(t.PriceID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as ProvincePrice);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ProvincePrice);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ProvincePrice);
        }

        #endregion

    }
    #endregion
}