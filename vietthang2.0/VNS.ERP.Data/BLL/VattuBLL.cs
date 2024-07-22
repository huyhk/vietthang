using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    #region VattuBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of Vattu.
    /// </summary>
    public class VattuBLL : IBusiness
    {
        private VattuDAL dal = new VattuDAL();
        public VattuBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<Vattu> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<Vattu> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(Vattu t)
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
        public int Update(Vattu t)
        {
            return dal.Update(t);
        }

        /// <summary>
        /// Returns an object by ID
        /// </summary>		
        public Vattu GetByID(string vattuCode)
        {

            return dal.GetByID(vattuCode);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(string vattuCode)
        {

            return dal.Delete(vattuCode);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(Vattu t)
        {

            return dal.Delete(t.VattuCode);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Vattu);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Vattu);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Vattu);
        }

        #endregion

    }
    #endregion
}