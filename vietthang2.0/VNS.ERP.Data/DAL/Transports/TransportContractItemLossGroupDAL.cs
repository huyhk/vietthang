

/************************************************************************
**	ClassName	: 	TransportContractItemLossGroupDAL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	20-11-2009 03:14 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.ERP.Data.Transports;

namespace VNS.ERP.Data
{
	#region TransportContractItemLossGroupDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of TransportContractItemLossGroup.
	/// </summary>
	public class TransportContractItemLossGroupDAL : BaseDAL<TransportContractItemLossGroup>
	{
		public TransportContractItemLossGroupDAL()
		{
		}
		public TransportContractItemLossGroupDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(TransportContractItemLossGroup t)
		{
			int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractItemLossGroup_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@ContractID",System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@GroupID",System.Data.DbType.Guid, 16, 0, ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GroupName",System.Data.DbType.String, 50, t.GroupName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	            iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.GroupID = (Guid)cmd.Parameters["@GroupID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractItemLossGroupDAL", "Insert(TransportContractItemLossGroup t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		/// <summary>
		/// Updates an existing object in database by calling Update StoredProcedure
		/// </summary>
		public override int Update(TransportContractItemLossGroup t)
		{
			int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractItemLossGroup_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID",System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@GroupID",System.Data.DbType.Guid, 16, t.GroupID));
                cmd.Parameters.Add(db.CreateParameter("@GroupName",System.Data.DbType.String, 50, t.GroupName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractItemLossGroupDAL", "Update(TransportContractItemLossGroup t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>
		public override int Delete(TransportContractItemLossGroup t)
		{    
            return this.Delete( t.GroupID);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(Guid groupID)
		{
			int iError = 0;
            bool alreadyOpen = false;			
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractItemLossGroup_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@GroupID", System.Data.DbType.Guid , 16, groupID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractItemLossGroupDAL", "Delete(TransportContractItemLossGroup t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_TransportContractItemLossGroup_SelectAll";
            //_spSelectDynamic = "usp_TransportContractItemLossGroup_SelectDynamic";
            //_spDeleteAll = "usp_TransportContractItemLossGroup_DeleteAll";            
            //_spDeleteDynamic = "usp_TransportContractItemLossGroup_DeleteDynamic";
        }

		#endregion

        #region"TransportContractItemLossGroupItem"

        /// <summary>
        /// Delete All row( in table TransportContractItemLossGroupItems) that GroupID = groupID. 
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public int DeleteTransportContractItemLossGroupItem(Guid groupID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractItemLossGroupItem_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GroupID", System.Data.DbType.Guid, 16, groupID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractItemLossGroupDAL", "DeleteTransportContractItemLossGroupItem(Guid groupID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int InsertTransportContractItemLossGroupItem(TransportContractItemLossGroupItem t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractItemLossGroupItem_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@GroupID", System.Data.DbType.Guid, 16, t.GroupID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractItemLossGroupDAL", "InsertTransportContractItemLossGroupItem(TransportContractItemLossGroupItem t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion

        #region"TransportContractItemLossGroupCompenPrice"
        /// <summary>
        /// Delete All row( in table TransportContractItemLossGroupCompenPrices) that GroupID = groupID. 
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public int DeleteTransportContractItemLossGroupCompenPrice(Guid groupID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractItemLossGroupCompenPrice_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GroupID", System.Data.DbType.Guid, 16, groupID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractItemLossGroupDAL", "DeleteTransportContractItemLossGroupCompenPrice(Guid groupID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int InsertTransportContractItemLossGroupCompenPrice(TransportContractItemLossGroupCompenPrice t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractItemLossGroupCompenPrice_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@GroupID", System.Data.DbType.Guid, 16, t.GroupID));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, t.EndDate));
                cmd.Parameters.Add(db.CreateParameter("@CompensationPrice", System.Data.DbType.Decimal, 9, t.CompensationPrice));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractItemLossGroupDAL", "InsertTransportContractItemLossGroupCompenPrice(TransportContractItemLossGroupCompenPrice t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion
    }
	#endregion
}

