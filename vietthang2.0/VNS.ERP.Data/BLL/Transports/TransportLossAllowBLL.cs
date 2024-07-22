
/************************************************************************
**	ClassName	: 	TransportLossAllowBLL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	26-10-2009 01:18 PM
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
	#region TransportLossAllowBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of TransportLossAllow.
	/// </summary>
	public class TransportLossAllowBLL : IBusiness
	{
		private TransportLossAllowDAL dal = new TransportLossAllowDAL();		
		public TransportLossAllowBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TransportLossAllow >  GetAll()
		{
			return GetListTransportLossAllow( dal.GetAll());
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private ListBase<TransportLossAllow> GetListTransportLossAllow(DataSet ds)
        {
            DataRelation drTransportLossAllowTransportType = ds.Relations.Add("relTransportLossAllowTransportType", ds.Tables[0].Columns["AllowID"], ds.Tables[1].Columns["AllowID"]);
            DataRelation drTransportLossAllowTransportItemType = ds.Relations.Add("relTransportLossAllowTransportItemType", ds.Tables[0].Columns["AllowID"], ds.Tables[2].Columns["AllowID"]);
            DataRelation drTransportLossAllowItem = ds.Relations.Add("relTransportLossAllowItem", ds.Tables[0].Columns["AllowID"], ds.Tables[3].Columns["AllowID"]);
            ListBase<TransportLossAllow> lstTLA = new ListBase<TransportLossAllow>();
            foreach (DataRow rowTLA in ds.Tables[0].Rows)
            {
                TransportLossAllow oTLA = new TransportLossAllow(rowTLA);
                foreach (DataRow rowTLAI in rowTLA.GetChildRows(drTransportLossAllowItem))
                {
                    TransportLossAllowItem oTLAI = new TransportLossAllowItem(rowTLAI);
                    oTLA.TransportLossAllowItemList.Add(oTLAI);
                }
                foreach (DataRow rowTLAIT in rowTLA.GetChildRows(drTransportLossAllowTransportItemType))
                {
                    TransportLossAllowTransportItemType oTLAIT = new TransportLossAllowTransportItemType(rowTLAIT);
                    oTLA.TransportLossAllowTransportItemTypeList.Add(oTLAIT);
                }
                foreach (DataRow rowTLATT in rowTLA.GetChildRows(drTransportLossAllowTransportType))
                {
                    TransportLossAllowTransportType oTLATT = new TransportLossAllowTransportType(rowTLATT);
                    oTLA.TransportLossAllowTransportTypeList.Add(oTLATT);
                }
                lstTLA.Add(oTLA);
            }
            return lstTLA;
        }		
		/// <summary>
		/// Inserts an TransportLossAllow.
        /// Insert 3 list detail: list TransportLossAllowTransportType, TransportLossAllowTransportItemType, TransportLossAllowItem.
		/// </summary>
		public int Insert(TransportLossAllow t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (TransportLossAllowTransportType detail in t.TransportLossAllowTransportTypeList)
                {
                    detail.AllowID = t.AllowID;
                    iError = dal.InsertTransportLossAllowTransportType(detail);
                    if (iError != 0)
                    {
                        iError = -10;
                        break;
                    }
                }
            }
            if (iError == 0)
            {
                foreach (TransportLossAllowTransportItemType detail in t.TransportLossAllowTransportItemTypeList)
                {
                    detail.AllowID = t.AllowID;
                    iError = dal.InsertTransportLossAllowTransportItemType(detail);
                    if (iError != 0)
                    {
                        iError = -11;
                        break;
                    }
                }
            }
            if (iError == 0)
            {
                foreach (TransportLossAllowItem item in t.TransportLossAllowItemList)
                {
                    item.AllowID = t.AllowID;
                    iError = dal.InsertTransportLossAllowItem(item);
                    if (iError != 0)
                    {
                        iError = -12;
                        break;
                    }
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
        /// Updates an existing TransportLossAllow in database. 
        /// Delete and insert 3 list detail(list TransportLossAllowTransportType, TransportLossAllowTransportItemType, TransportLossAllowItem).
		/// </summary>
		public int Update(TransportLossAllow t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
                iError = dal.DeleteTransportLossAllowTransportType(t.AllowID);
            if (iError == 0)
                iError = dal.DeleteTransportLossAllowTransportItemType(t.AllowID);
            if (iError == 0)
                iError = dal.DeleteTransportLossAllowItem(t.AllowID);
            if (iError == 0)
            {
                foreach (TransportLossAllowTransportType detail in t.TransportLossAllowTransportTypeList)
                {
                    detail.AllowID = t.AllowID;
                    iError = dal.InsertTransportLossAllowTransportType(detail);
                    if (iError != 0)
                    {
                        iError = -10;
                        break;
                    }
                }
            }
            if (iError == 0)
            {
                foreach (TransportLossAllowTransportItemType detail in t.TransportLossAllowTransportItemTypeList)
                {
                    detail.AllowID = t.AllowID;
                    iError = dal.InsertTransportLossAllowTransportItemType(detail);
                    if (iError != 0)
                    {
                        iError = -11;
                        break;
                    }
                }
            }
            if (iError == 0)
            {
                foreach (TransportLossAllowItem item in t.TransportLossAllowItemList)
                {
                    item.AllowID = t.AllowID;
                    iError = dal.InsertTransportLossAllowItem(item);
                    if (iError != 0)
                    {
                        iError = -12;
                        break;
                    }
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
        /// Deletes an TransportLossAllow from database by Id
		/// </summary>		
		public int Delete(Guid allowID )
		{      
            return dal.Delete( allowID);
		}
		
		/// <summary>
        /// Deletes an TransportLossAllow from database 
		/// </summary>		
		public int Delete(TransportLossAllow t)
		{      
            return dal.Delete( t.AllowID);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportLossAllow);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportLossAllow);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportLossAllow);
        }

        #endregion
		
	}
	#endregion
}

