

/************************************************************************
**	ClassName	: 	TransportFeeDAL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	30-11-2009 10:58 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data
{
	#region TransportFeeDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of TransportFee.
	/// </summary>
	public class TransportFeeDAL : BaseDAL<TransportFee>
	{
		public TransportFeeDAL()
		{
		}
		public TransportFeeDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(TransportFee t)
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
                cmd.CommandText = "usp_TransportFee_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@FeeCode",System.Data.DbType.AnsiString, 20, t.FeeCode));
                cmd.Parameters.Add(db.CreateParameter("@FeeName",System.Data.DbType.String, 50, t.FeeName));
                cmd.Parameters.Add(db.CreateParameter("@UnitName",System.Data.DbType.String, 20, t.UnitName));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate",System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));

                if (t.TypeCode != "")
                    cmd.Parameters.Add(db.CreateParameter("@TypeCode", System.Data.DbType.String, 20, t.TypeCode));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportFeeDAL", "Insert(TransportFee t)", excp.Message);
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
		public override int Update(TransportFee t)
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
                cmd.CommandText = "usp_TransportFee_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FeeCode",System.Data.DbType.AnsiString, 20, t.FeeCode));
                cmd.Parameters.Add(db.CreateParameter("@FeeName",System.Data.DbType.String, 50, t.FeeName));
                cmd.Parameters.Add(db.CreateParameter("@UnitName",System.Data.DbType.String, 20, t.UnitName));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate",System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));

                if (t.TypeCode != "")
                    cmd.Parameters.Add(db.CreateParameter("@TypeCode", System.Data.DbType.String, 20, t.TypeCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportFeeDAL", "Update(TransportFee t)", excp.Message);
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
		public override int Delete(TransportFee t)
		{
			           
            return this.Delete( t.FeeCode);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(string feeCode)
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
                cmd.CommandText = "usp_TransportFee_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@FeeCode", System.Data.DbType.AnsiString , 20, feeCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportFeeDAL", "Delete(TransportFee t)", excp.Message);
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
        public TransportFee GetByID(string feeCode)
        {
            int iError = 0;
            bool alreadyOpen = false;
            TransportFee obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportFee_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FeeCode", System.Data.DbType.AnsiString, 20, feeCode));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj = new TransportFee(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportFeeDAL", "GetByID(string feeCode)", excp.Message);
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
            _spSelectAll = "usp_TransportFee_SelectAll";
            //_spSelectDynamic = "usp_TransportFee_SelectDynamic";
            //_spDeleteAll = "usp_TransportFee_DeleteAll";            
            //_spDeleteDynamic = "usp_TransportFee_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

