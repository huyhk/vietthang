using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Accounting
{
    #region UyNhiemChiPrintBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of UyNhiemChiPrint.
    /// </summary>
    public class UyNhiemChiPrintBLL : IBusiness
    {
        private UyNhiemChiPrintDAL dal = new UyNhiemChiPrintDAL();
        public UyNhiemChiPrintBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<UyNhiemChiPrint> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<UyNhiemChiPrint> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(UyNhiemChiPrint t)
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
        public int Update(UyNhiemChiPrint t)
        {
            return dal.Update(t);
        }

        /// <summary>
        /// Returns an object by ID
        /// </summary>		
        public UyNhiemChiPrint GetByID(string subjectCode)
        {

            return dal.GetByID(subjectCode);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(string subjectCode)
        {

            return dal.Delete(subjectCode);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(UyNhiemChiPrint t)
        {

            return dal.Delete(t.SubjectCode);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as UyNhiemChiPrint);
        }

        public int Update(object obj)
        {
            return this.Update(obj as UyNhiemChiPrint);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as UyNhiemChiPrint);
        }

        #endregion

    }
    #endregion
}