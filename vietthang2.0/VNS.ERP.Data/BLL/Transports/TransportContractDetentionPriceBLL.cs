
/************************************************************************
**	ClassName	: 	TransportContractDetentionPriceBLL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	09-10-2009 08:57 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;
using VNS.ERP.Data.DAL;
using VNS.ERP.Data.Transports;
namespace VNS.ERP.Data
{
	#region TransportContractDetentionPriceBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of TransportContractDetentionPrice.
	/// </summary>
	public class TransportContractDetentionPriceBLL : IBusiness
	{
		private TransportContractDetentionPriceDAL dal = new TransportContractDetentionPriceDAL();		
		public TransportContractDetentionPriceBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TransportContractDetentionPrice >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TransportContractDetentionPrice >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(TransportContractDetentionPrice t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (TransportContractDetentionPriceDetail detentionPriceDetail in t.ListTransportContractDetentionPriceDetail)
                {
                    detentionPriceDetail.PriceID = t.PriceID;
                    iError = dal.InsertTransportContractDetentionPriceDetail(detentionPriceDetail);
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
		public int Update(TransportContractDetentionPrice t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
                iError = dal.DeleteTransportContractDetentionPriceDetail(t.PriceID);
            if (iError == 0)
            {
                foreach (TransportContractDetentionPriceDetail detentionPriceDetail in t.ListTransportContractDetentionPriceDetail)
                {
                    detentionPriceDetail.PriceID = t.PriceID;
                    iError = dal.InsertTransportContractDetentionPriceDetail(detentionPriceDetail);
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
		/// Returns an object by ID
		/// </summary>		
		public TransportContractDetentionPrice GetByID(Guid priceID )
		{         
            return dal.GetByID( priceID);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(Guid priceID )
		{
			           
            return dal.Delete( priceID);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(TransportContractDetentionPrice t)
		{
			           
            return dal.Delete( t.PriceID);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportContractDetentionPrice);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportContractDetentionPrice);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportContractDetentionPrice);
        }

        #endregion
		
	}
	#endregion
}

