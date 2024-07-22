using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region VesselInsuranceContractBLL
    /// <summary>
    /// This object represents the properties and methods of a Business Layer of VesselInsuranceContract.
    /// </summary>
    public class VesselInsuranceContractBLL : IBusiness
    {
        private VesselInsuranceContractDAL dal = new VesselInsuranceContractDAL();
        public VesselInsuranceContractBLL()
        {
        }
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<VesselInsuranceContract> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<VesselInsuranceContract> GetByDate(DateTime fromDate, DateTime toDate)
        {
            return dal.GetByDate(fromDate, toDate);
        }

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<VesselInsuranceContract> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int Insert(VesselInsuranceContract t)
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
        public int Update(VesselInsuranceContract t)
        {
            return dal.Update(t);
        }

        /// <summary>
        /// Returns an object by ID
        /// </summary>		
        public VesselInsuranceContract GetByID(Guid contractID)
        {

            return dal.GetByID(contractID);
        }

        /// <summary>
        /// Deletes an object from database by Id
        /// </summary>		
        public int Delete(Guid contractID)
        {

            return dal.Delete(contractID);
        }

        /// <summary>
        /// Deletes an object from database 
        /// </summary>		
        public int Delete(VesselInsuranceContract t)
        {

            return dal.Delete(t.ContractID);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as VesselInsuranceContract);
        }

        public int Update(object obj)
        {
            return this.Update(obj as VesselInsuranceContract);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as VesselInsuranceContract);
        }

        #endregion

    }
    #endregion
}
