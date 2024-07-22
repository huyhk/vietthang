
/************************************************************************
**	ClassName	: 	TransportContractFeeBLL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	02-12-2009 08:39 AM
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
	#region TransportContractFeeBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of TransportContractFee.
	/// </summary>
	public class TransportContractFeeBLL : IBusiness
	{
		private TransportContractFeeDAL dal = new TransportContractFeeDAL();		
		public TransportContractFeeBLL()
		{
		}
		#region Stored procedure wrappers
		
        ///// <summary>
        ///// Gets all objects 
        ///// </summary>
        //public ListBase< TransportContractFee >  GetAll()
        //{
        //    return dal.GetObjectAll();
        //}				
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(TransportContractFee t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            t.UpdateTotalAmount();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (TransportContractFeeDetail tcfd in t.ListTransportContractFeeDetail)
                {
                    tcfd.FeeID = t.FeeID;
                    iError = dal.InsertTransportContractFeeDetail(tcfd);
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
		public int Update(TransportContractFee t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            t.UpdateTotalAmount();
            iError = dal.Update(t);
            if (iError == 0)
                iError = dal.DeleteTransportContractFeeDetail(t.FeeID);
            if (iError == 0)
            {
                foreach (TransportContractFeeDetail tcfd in t.ListTransportContractFeeDetail)
                {
                    tcfd.FeeID = t.FeeID;
                    iError = dal.InsertTransportContractFeeDetail(tcfd);
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
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(Guid feeID )
		{     
            return dal.Delete( feeID);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(TransportContractFee t)
		{      
            return dal.Delete( t.FeeID);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportContractFee);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportContractFee);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportContractFee);
        }

        #endregion
		
	}
	#endregion
}

