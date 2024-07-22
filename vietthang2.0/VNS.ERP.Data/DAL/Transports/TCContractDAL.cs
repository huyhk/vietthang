

/************************************************************************
**	ClassName	: 	TCContractDAL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	14-12-2009 03:54 PM
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
	#region TCContractDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of TCContract.
	/// </summary>
	public class TCContractDAL : BaseDAL<TCContract>
	{
		public TCContractDAL()
		{
		}
		public TCContractDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(TCContract t)
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
                cmd.CommandText = "usp_TCContract_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@ContractID",System.Data.DbType.Guid, 16, 0, ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo",System.Data.DbType.String, 20, t.ContractNo));
                cmd.Parameters.Add(db.CreateParameter("@ContractDate",System.Data.DbType.DateTime, 8, t.ContractDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate",System.Data.DbType.DateTime, 8, t.EndDate));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate",System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
			
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ContractID = (Guid)cmd.Parameters["@ContractID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TCContractDAL", "Insert(TCContract t)", excp.Message);
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
		public override int Update(TCContract t)
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
                cmd.CommandText = "usp_TCContract_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID",System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo",System.Data.DbType.String, 20, t.ContractNo));
                cmd.Parameters.Add(db.CreateParameter("@ContractDate",System.Data.DbType.DateTime, 8, t.ContractDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate",System.Data.DbType.DateTime, 8, t.EndDate));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate",System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TCContractDAL", "Update(TCContract t)", excp.Message);
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
		public override int Delete(TCContract t)
		{
			           
            return this.Delete( t.ContractID);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(Guid contractID)
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
                cmd.CommandText = "usp_TCContract_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid , 16, contractID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TCContractDAL", "Delete(TCContract t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}

        public DataSet GetAll()
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TCContract_SelectAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TCContractDAL", "GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
		/// <summary>
		/// Returns an object from database by calling Select StoredProcedure
		/// </summary>		
        //public TCContract GetByID(Guid contractID)
        //{
        //    int iError = 0;
        //    bool alreadyOpen = false;			
        //    TCContract obj = null;
        //    try
        //    {
        //        DbDataReader reader = null;
        //        if (db.State != System.Data.ConnectionState.Open)
        //            db.Open();
        //        else
        //            alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_TCContract_Select";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid , 16, contractID));
				
        //        cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
        //        reader = db.ExecuteReader(cmd);
        //        if (reader.Read())
        //            obj = new TCContract(reader);
        //    }
        //    catch (Exception excp)
        //    {                
        //        Write2Log.WriteLogs("TCContractDAL", "GetByID(Guid contractID)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen)
        //            db.Close();
        //    }
        //    return obj;
        //}
		
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_TCContract_SelectAll";
            //_spSelectDynamic = "usp_TCContract_SelectDynamic";
            //_spDeleteAll = "usp_TCContract_DeleteAll";            
            //_spDeleteDynamic = "usp_TCContract_DeleteDynamic";
        }

		#endregion

        #region"TCContractPrice"
        public int InsertTCContractPrice(TCContractPrice t)
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
                cmd.CommandText = "usp_TCContractPrice_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@TCRouteCode", System.Data.DbType.String, 20, t.TCRouteCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.String, 20, t.ItemType));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TCContractDAL", "InsertTCContractPrice(TCContractPrice t)", excp.Message);
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
        /// <param name="contractID"></param>
        /// <returns></returns>
        public int DeleteTCContractPrice(Guid contractID)
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
                cmd.CommandText = "usp_TCContractPrice_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, contractID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TCContractDAL", "DeleteTCContractPrice(Guid contractID)", excp.Message);
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

