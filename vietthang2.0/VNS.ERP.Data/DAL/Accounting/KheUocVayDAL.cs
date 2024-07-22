

/************************************************************************
**	ClassName	: 	KheuocvayDAL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	05-12-2009 11:42 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data.Accounting
{
	#region KheuocvayDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of Kheuocvay.
	/// </summary>
	public class KheUocVayDAL : BaseDAL<KheUocVay>
	{
		public KheUocVayDAL()
		{
		}
        public KheUocVayDAL(DBHelper dbHelper)
            : base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public override int Insert(KheUocVay t)
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
                cmd.CommandText = "usp_Kheuocvay_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@VayID",System.Data.DbType.Guid, 16, 0, ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@VayNo",System.Data.DbType.String, 20, t.VayNo));
                cmd.Parameters.Add(db.CreateParameter("@VayDate",System.Data.DbType.DateTime, 8, t.VayDate));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode",System.Data.DbType.AnsiString, 10, t.AccountCode));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@VayRate",System.Data.DbType.Decimal, 9, t.VayRate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished",System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
	
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	            iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.VayID = (Guid)cmd.Parameters["@VayID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("KheuocvayDAL", "Insert(Kheuocvay t)", excp.Message);
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
        public override int Update(KheUocVay t)
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
                cmd.CommandText = "usp_Kheuocvay_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@VayID",System.Data.DbType.Guid, 16, t.VayID));
                cmd.Parameters.Add(db.CreateParameter("@VayNo",System.Data.DbType.String, 20, t.VayNo));
                cmd.Parameters.Add(db.CreateParameter("@VayDate",System.Data.DbType.DateTime, 8, t.VayDate));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode",System.Data.DbType.AnsiString, 10, t.AccountCode));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@VayRate",System.Data.DbType.Decimal, 9, t.VayRate));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished",System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("KheuocvayDAL", "Update(Kheuocvay t)", excp.Message);
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
        public override int Delete(KheUocVay t)
		{
			           
            return this.Delete( t.VayID);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(Guid vayID)
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
                cmd.CommandText = "usp_Kheuocvay_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@VayID", System.Data.DbType.Guid , 16, vayID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("KheuocvayDAL", "Delete(Kheuocvay t)", excp.Message);
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
            _spSelectAll = "usp_Kheuocvay_SelectAll";
        //    _spSelectDynamic = "usp_Kheuocvay_SelectDynamic";
        //    _spDeleteAll = "usp_Kheuocvay_DeleteAll";            
        //    _spDeleteDynamic = "usp_Kheuocvay_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

