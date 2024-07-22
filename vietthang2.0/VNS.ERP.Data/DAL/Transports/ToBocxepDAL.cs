

/************************************************************************
**	ClassName	: 	ToBocxepDAL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-08-2008 11:45 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data
{
	#region ToBocxepDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of ToBocxep.
	/// </summary>
	public class ToBocxepDAL : BaseDAL<ToBocxep>
	{
		public ToBocxepDAL()
		{
		}
		public ToBocxepDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		public override int Insert(ToBocxep t)
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
                cmd.CommandText = "usp_ToBocxep_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@ToBocxepCode",System.Data.DbType.String, 20, t.ToBocxepCode));
                cmd.Parameters.Add(db.CreateParameter("@ToBocxepName",System.Data.DbType.String, 50, t.ToBocxepName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.String, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    //t.ToBocxepCode = cmd.Parameters["@ToBocxepCode"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("ToBocxepDAL", "Insert(ToBocxep t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		public override int Update(ToBocxep t)
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
                cmd.CommandText = "usp_ToBocxep_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ToBocxepCode", System.Data.DbType.String, 20, t.ToBocxepCode));
                cmd.Parameters.Add(db.CreateParameter("@ToBocxepName",System.Data.DbType.String, 50, t.ToBocxepName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("ToBocxepDAL", "Update(ToBocxep t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		public override int Delete(ToBocxep t)
		{
			           
            return this.Delete( t.ToBocxepCode);
		}
		public int Delete(string toBocxepCode)
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
                cmd.CommandText = "usp_ToBocxep_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ToBocxepCode", System.Data.DbType.String, 20, toBocxepCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("ToBocxepDAL", "Delete(ToBocxep t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		public ToBocxep GetByID(string toBocxepCode)
		{
            //int iError = 0;
            bool alreadyOpen = false;			
			ToBocxep obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ToBocxep_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ToBocxepCode", System.Data.DbType.String, 20, toBocxepCode));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new ToBocxep(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("ToBocxepDAL", "GetByID(string toBocxepCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
		}
        public ListBase<ToBocxep> GetBySubjectCode(string subjectCode)
        {
            DbDataReader reader = null;
            ListBase<ToBocxep> lstReturn = new ListBase<ToBocxep>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ToBocxep_SelectBySubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ToBocxep obj = new ToBocxep(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ToBocxepDAL", "GetByToBocxepCode(string toBocxepCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_ToBocxep_SelectAll";
			_spSelectDynamic = "usp_ToBocxep_SelectDynamic";
            _spDeleteAll = "usp_ToBocxep_DeleteAll";            
			_spDeleteDynamic = "usp_ToBocxep_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

