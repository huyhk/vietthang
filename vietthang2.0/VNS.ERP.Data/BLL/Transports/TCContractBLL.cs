
/************************************************************************
**	ClassName	: 	TCContractBLL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	14-12-2009 03:48 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Transports
{
	#region TCContractBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of TCContract.
	/// </summary>
	public class TCContractBLL : IBusiness
	{
		private TCContractDAL dal = new TCContractDAL();		
		public TCContractBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TCContract >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(TCContract t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (TCContractPrice ttcp in t.ListTCContractPrice)
                {
                    ttcp.ContractID = t.ContractID;
                    iError = dal.InsertTCContractPrice(ttcp);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
		}		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
		public int Update(TCContract t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
                iError = dal.DeleteTCContractPrice(t.ContractID);
            if (iError == 0)
            {
                foreach (TCContractPrice tccp in t.ListTCContractPrice)
                {
                    tccp.ContractID = t.ContractID;
                    iError = dal.InsertTCContractPrice(tccp);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
		}

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<TCContract> GetAll()
        {
            return DS2List(dal.GetAll());
        }
        private ListBase<TCContract> DS2List(DataSet ds)
        {
            DataRelation drTCContractPrice = ds.Relations.Add(ds.Tables[0].Columns["ContractID"], ds.Tables[1].Columns["ContractID"]);
            ListBase<TCContract> lst = new ListBase<TCContract>();
            foreach (DataRow rowTCContract in ds.Tables[0].Rows)
            {
                TCContract oTCContract = new TCContract(rowTCContract);
                foreach (DataRow rowTCContractPrice in rowTCContract.GetChildRows(drTCContractPrice))
                {
                    TCContractPrice oTCContractPrice = new TCContractPrice(rowTCContractPrice);
                    oTCContract.ListTCContractPrice.Add(oTCContractPrice);
                }
                lst.Add(oTCContract);
            }
            return lst;
        }
        ///// <summary>
        ///// Returns an object by ID
        ///// </summary>		
        //public TCContract GetByID(Guid contractID )
        //{
			           
        //    return dal.GetByID( contractID);
        //}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(Guid contractID )
		{
			           
            return dal.Delete( contractID);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(TCContract t)
		{
			           
            return dal.Delete( t.ContractID);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TCContract);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TCContract);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TCContract);
        }

        #endregion
		
	}
	#endregion
}

