

/************************************************************************
**	ClassName	: 	TechnicalTestDAL
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	18-02-2008 01:48 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data.KCS
{
	#region TechnicalTestDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of TechnicalTest.
	/// </summary>
	public class TechnicalTestDAL : BaseDAL<TechnicalTest>
	{
		public TechnicalTestDAL()
		{
		}
		public TechnicalTestDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(TechnicalTest t)
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
                cmd.CommandText = "usp_TechnicalTest_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@TechCode",System.Data.DbType.AnsiString, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@TechName",System.Data.DbType.String, 50, t.TechName));
                cmd.Parameters.Add(db.CreateParameter("@ResultType",System.Data.DbType.AnsiString, 20, t.ResultType));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@KCSTest", System.Data.DbType.Boolean, 1, t.KCSTest));
                cmd.Parameters.Add(db.CreateParameter("@PTNTest", System.Data.DbType.Boolean, 1, t.PTNTest));
                cmd.Parameters.Add(db.CreateParameter("@OrderBy", System.Data.DbType.Int32, 4, t.OrderBy));
                cmd.Parameters.Add(db.CreateParameter("@DisplayText", System.Data.DbType.String, 50, t.DisplayText));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //{
                //}
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("TechnicalTestDAL", "Insert(TechnicalTest t)", excp.Message);
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
		public override int Update(TechnicalTest t)
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
                cmd.CommandText = "usp_TechnicalTest_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@TechCode",System.Data.DbType.AnsiString, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@TechName",System.Data.DbType.String, 50, t.TechName));
                cmd.Parameters.Add(db.CreateParameter("@ResultType",System.Data.DbType.AnsiString, 20, t.ResultType));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@KCSTest", System.Data.DbType.Boolean, 1, t.KCSTest));
                cmd.Parameters.Add(db.CreateParameter("@PTNTest", System.Data.DbType.Boolean, 1, t.PTNTest));
                cmd.Parameters.Add(db.CreateParameter("@OrderBy", System.Data.DbType.Int32, 4, t.OrderBy));
                cmd.Parameters.Add(db.CreateParameter("@DisplayText", System.Data.DbType.String, 50, t.DisplayText));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
	                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("TechnicalTestDAL", "Update(TechnicalTest t)", excp.Message);
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
		public override int Delete(TechnicalTest t)
		{
			           
            return this.Delete( t.TechCode);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(string techCode)
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
                cmd.CommandText = "usp_TechnicalTest_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.AnsiString , 10, techCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("TechnicalTestDAL", "Delete(TechnicalTest t)", excp.Message);
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
		public TechnicalTest GetByID(string techCode)
		{
            //int iError = 0;
            bool alreadyOpen = false;			
			TechnicalTest obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TechnicalTest_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.AnsiString , 10, techCode));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new TechnicalTest(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("TechnicalTestDAL", "GetByID(string techCode)", excp.Message);
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
            _spSelectAll = "usp_TechnicalTest_SelectAll";
			_spSelectDynamic = "usp_TechnicalTest_SelectDynamic";
            _spDeleteAll = "usp_TechnicalTest_DeleteAll";            
			_spDeleteDynamic = "usp_TechnicalTest_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

