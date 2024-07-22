
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Accounting
{
    #region CongtrinhBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of Kheuocvay.
    /// </summary>
    public class CongtrinhBLL : IBusiness
    {
        private CongtrinhDAL dal = new CongtrinhDAL();
        public CongtrinhBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<Congtrinh> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<Congtrinh> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(Congtrinh t)
        {
            return dal.Insert(t);
        }

        /// <summary>
        /// Updates an existing object in database 
        /// </summary>
        public int Update(Congtrinh t)
        {
            return dal.Update(t);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(string vayID)
        {
            return dal.Delete(vayID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(Congtrinh t)
        {

            return dal.Delete(t.CongtrinhCode);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Congtrinh);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Congtrinh);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Congtrinh);
        }

        #endregion

    }
    #endregion
}

