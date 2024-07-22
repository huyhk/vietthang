
/************************************************************************
**	ClassName	: 	TransportContractItemLossGroupBLL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	20-11-2009 03:36 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;
using VNS.ERP.Data.Transports;
namespace VNS.ERP.Data
{
	#region TransportContractItemLossGroupBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of TransportContractItemLossGroup.
	/// </summary>
	public class TransportContractItemLossGroupBLL : IBusiness
	{
		private TransportContractItemLossGroupDAL dal = new TransportContractItemLossGroupDAL();		
		public TransportContractItemLossGroupBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        //public ListBase< TransportContractItemLossGroup >  GetAll()
        //{
        //    return dal.GetObjectAll();
        //}		

		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(TransportContractItemLossGroup t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            //Insert TransportContractItemLossGroupItem
            if (iError == 0)
            {
                foreach (TransportContractItemLossGroupItem itemLossGroupItem in t.ListTransportContractItemLossGroupItem)
                {
                    itemLossGroupItem.GroupID = t.GroupID;
                    iError = dal.InsertTransportContractItemLossGroupItem(itemLossGroupItem);
                    if (iError != 0)
                        break;
                }
            }
            //Insert TransportContractItemLossGroupCompenPrice
            if (iError == 0)
            {
                foreach (TransportContractItemLossGroupCompenPrice itemLossGroupCompenPrice in t.ListTransportContractItemLossGroupCompenPrice)
                {
                    itemLossGroupCompenPrice.GroupID = t.GroupID;
                    iError = dal.InsertTransportContractItemLossGroupCompenPrice(itemLossGroupCompenPrice);
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
		public int Update(TransportContractItemLossGroup t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
                iError = dal.DeleteTransportContractItemLossGroupCompenPrice(t.GroupID);
            if (iError == 0)
                iError = dal.DeleteTransportContractItemLossGroupItem(t.GroupID);
            if (iError == 0)
            {
                foreach (TransportContractItemLossGroupCompenPrice itemLossGroupCompenPrice in t.ListTransportContractItemLossGroupCompenPrice)
                {
                    itemLossGroupCompenPrice.GroupID = t.GroupID;
                    iError = dal.InsertTransportContractItemLossGroupCompenPrice(itemLossGroupCompenPrice);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
            {
                foreach (TransportContractItemLossGroupItem itemLossGroupItem in t.ListTransportContractItemLossGroupItem)
                {
                    itemLossGroupItem.GroupID = t.GroupID;
                    iError = dal.InsertTransportContractItemLossGroupItem(itemLossGroupItem);
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
		public int Delete(Guid groupID )
		{
            return dal.Delete( groupID);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(TransportContractItemLossGroup t)
		{
			           
            return dal.Delete( t.GroupID);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportContractItemLossGroup);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportContractItemLossGroup);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportContractItemLossGroup);
        }

        #endregion
		
	}
	#endregion
}

