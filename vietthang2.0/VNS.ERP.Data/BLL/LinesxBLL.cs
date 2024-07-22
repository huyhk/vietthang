using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    #region LinesxsBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of Linesxs.
    /// </summary>
    public class LinesxsBLL : IBusiness
    {
        private LinesxsDAL dal = new LinesxsDAL();
        public LinesxsBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<Linesxs> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<Linesxs> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(Linesxs t)
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
        public int Update(Linesxs t)
        {
            return dal.Update(t);
        }

        /// <summary>
        /// Returns an object by ID
        /// </summary>		
        public Linesxs GetByID(int linesxNo)
        {

            return dal.GetByID(linesxNo);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(int linesxNo)
        {

            return dal.Delete(linesxNo);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(Linesxs t)
        {

            return dal.Delete(t.LinesxNo);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Linesxs);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Linesxs);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Linesxs);
        }

        #endregion

    }
    #endregion
}