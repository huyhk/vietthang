

/************************************************************************
**	ClassName	: 	TransportContractDetentionPriceDAL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	09-10-2009 08:53 AM
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
	#region TransportContractDetentionPriceDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of TransportContractDetentionPrice.
	/// </summary>
	public class TransportContractDetentionPriceDAL : BaseDAL<TransportContractDetentionPrice>
	{
		public TransportContractDetentionPriceDAL()
		{
		}
		public TransportContractDetentionPriceDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(TransportContractDetentionPrice t)
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
                cmd.CommandText = "usp_TransportContractDetentionPrice_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16,t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@PriceID",System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	            iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.PriceID = (Guid)cmd.Parameters["@PriceID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractDetentionPriceDAL", "Insert(TransportContractDetentionPrice t)", excp.Message);
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
		public override int Update(TransportContractDetentionPrice t)
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
                cmd.CommandText = "usp_TransportContractDetentionPrice_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PriceID",System.Data.DbType.Guid, 16, t.PriceID));
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractDetentionPriceDAL", "Update(TransportContractDetentionPrice t)", excp.Message);
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
		public override int Delete(TransportContractDetentionPrice t)
		{
			           
            return this.Delete( t.PriceID);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(Guid priceID)
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
                cmd.CommandText = "usp_TransportContractDetentionPrice_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PriceID", System.Data.DbType.Guid , 16, priceID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractDetentionPriceDAL", "Delete(TransportContractDetentionPrice t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		
		/// <summary>
		/// Returns an object from database by calling Select StoredProcedure
		/// </summary>		
		public TransportContractDetentionPrice GetByID(Guid priceID)
		{
			int iError = 0;
            bool alreadyOpen = false;			
			TransportContractDetentionPrice obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractDetentionPrice_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PriceID", System.Data.DbType.Guid , 16, priceID));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new TransportContractDetentionPrice(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("TransportContractDetentionPriceDAL", "GetByID(Guid priceID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
		}
		
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_TransportContractDetentionPrice_SelectAll";
			_spSelectDynamic = "usp_TransportContractDetentionPrice_SelectDynamic";
            _spDeleteAll = "usp_TransportContractDetentionPrice_DeleteAll";            
			_spDeleteDynamic = "usp_TransportContractDetentionPrice_DeleteDynamic";
        }

		#endregion


        public int InsertTransportContractDetentionPriceDetail(TransportContractDetentionPriceDetail t)
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
                cmd.CommandText = "usp_TransportContractDetentionPriceDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PriceID", System.Data.DbType.Guid, 16, t.PriceID));
                cmd.Parameters.Add(db.CreateParameter("@TransportType", System.Data.DbType.AnsiString, 20, t.TransportType));
                cmd.Parameters.Add(db.CreateParameter("@DetentionPrice", System.Data.DbType.Decimal, 9, t.DetentionPrice));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractPriceItemDAL", "Insert(TransportContractPriceItem t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int DeleteTransportContractDetentionPriceDetail(Guid priceID)
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
                cmd.CommandText = "usp_TransportContractDetentionPriceDetail_DeleteByPriceID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PriceID", System.Data.DbType.Guid, 16, priceID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractDetentionPriceDAL", "DeleteTransportContractDetentionPriceDetail(Guid priceID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
	}
	#endregion
}

