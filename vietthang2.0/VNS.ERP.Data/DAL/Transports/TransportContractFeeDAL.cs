

/************************************************************************
**	ClassName	: 	TransportContractFeeDAL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	02-12-2009 08:41 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data.Transports
{
	#region TransportContractFeeDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of TransportContractFee.
	/// </summary>
	public class TransportContractFeeDAL : BaseDAL<TransportContractFee>
	{
		public TransportContractFeeDAL()
		{
		}
		public TransportContractFeeDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(TransportContractFee t)
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
                cmd.CommandText = "usp_TransportContractFee_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@ContractID",System.Data.DbType.Guid, 16, t.ContractID));
                if (t.BatchID != Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@BatchID", System.Data.DbType.Guid, 16, t.BatchID));
                cmd.Parameters.Add(db.CreateParameter("@FeeID",System.Data.DbType.Guid, 16, 0, ParameterDirection.Output));
                
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate",System.Data.DbType.DateTime, 8, t.EndDate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@TotalAmount", System.Data.DbType.Decimal, 9, t.TotalAmount));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.FeeID = (Guid)cmd.Parameters["@FeeID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractFeeDAL", "Insert(TransportContractFee t)", excp.Message);
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
		public override int Update(TransportContractFee t)
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
                cmd.CommandText = "usp_TransportContractFee_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID",System.Data.DbType.Guid, 16, t.ContractID));
                if (t.BatchID != Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@BatchID", System.Data.DbType.Guid, 16, t.BatchID));
                cmd.Parameters.Add(db.CreateParameter("@FeeID",System.Data.DbType.Guid, 16, t.FeeID));
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate",System.Data.DbType.DateTime, 8, t.EndDate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@TotalAmount", System.Data.DbType.Decimal, 9, t.TotalAmount));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractFeeDAL", "Update(TransportContractFee t)", excp.Message);
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
		public override int Delete(TransportContractFee t)
		{
			           
            return this.Delete( t.FeeID);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(Guid feeID)
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
                cmd.CommandText = "usp_TransportContractFee_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@FeeID", System.Data.DbType.Guid , 16, feeID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractFeeDAL", "Delete(TransportContractFee t)", excp.Message);
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
            //_spSelectAll = "usp_TransportContractFee_SelectAll";
            //_spSelectDynamic = "usp_TransportContractFee_SelectDynamic";
            //_spDeleteAll = "usp_TransportContractFee_DeleteAll";            
            //_spDeleteDynamic = "usp_TransportContractFee_DeleteDynamic";
        }

		#endregion

        #region"TransportContractFeeDetail"
        public int InsertTransportContractFeeDetail(TransportContractFeeDetail t)
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
                cmd.CommandText = "usp_TransportContractFeeDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.FeeID));
                cmd.Parameters.Add(db.CreateParameter("@FeeCode", System.Data.DbType.AnsiString, 20, t.FeeCode));
                cmd.Parameters.Add(db.CreateParameter("@UnitName", System.Data.DbType.String, 20, t.UnitName));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate", System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@TotalAmount", System.Data.DbType.Decimal, 9, t.TotalAmount));
                cmd.Parameters.Add(db.CreateParameter("@Decription", System.Data.DbType.String, 100, t.Decription));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractFeeDAL", "InsertTransportContractFeeDetail(TransportContractFeeDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int DeleteTransportContractFeeDetail(Guid feeID)
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
                cmd.CommandText = "usp_TransportContractFeeDetail_DeleteByFeeID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FeeID", System.Data.DbType.Guid, 16, feeID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractFeeDAL", "DeleteTransportContractFeeDetail(Guid feeID)", excp.Message);
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

