

/************************************************************************
**	ClassName	: 	EquipmentGroupDAL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	10-07-2008 10:32 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace  VNS.ERP.Data.Equipments
{
	#region EquipmentGroupDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of EquipmentGroup.
	/// </summary>
	public class EquipmentGroupDAL : BaseDAL<EquipmentGroup>
	{
		public EquipmentGroupDAL()
		{
		}
		public EquipmentGroupDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(EquipmentGroup t)
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
                cmd.CommandText = "usp_EquipmentGroups_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@GroupCode",System.Data.DbType.AnsiString, 10, t.GroupCode));
                cmd.Parameters.Add(db.CreateParameter("@GroupName",System.Data.DbType.String, 50, t.GroupName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
                //cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
                //cmd.Parameters.Add(db.CreateParameter("@ServerCreated",System.Data.DbType.AnsiString, 20, t.ServerCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentGroupDAL", "Insert(EquipmentGroup t)", excp.Message);
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
		public override int Update(EquipmentGroup t)
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
                cmd.CommandText = "usp_EquipmentGroups_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@GroupCode",System.Data.DbType.AnsiString, 10, t.GroupCode));
                cmd.Parameters.Add(db.CreateParameter("@GroupName",System.Data.DbType.String, 50, t.GroupName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                //cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));
                //cmd.Parameters.Add(db.CreateParameter("@ServerCreated",System.Data.DbType.AnsiString, 20, t.ServerCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentGroupDAL", "Update(EquipmentGroup t)", excp.Message);
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
		public override int Delete(EquipmentGroup t)
		{
			           
            return this.Delete( t.GroupCode);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(string groupCode)
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
                cmd.CommandText = "usp_EquipmentGroups_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@GroupCode", System.Data.DbType.AnsiString , 10, groupCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentGroupDAL", "Delete(EquipmentGroup t)", excp.Message);
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
		public EquipmentGroup GetByID(string groupCode)
		{
            //int iError = 0;
            bool alreadyOpen = false;			
			EquipmentGroup obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_EquipmentGroups_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@GroupCode", System.Data.DbType.AnsiString , 10, groupCode));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new EquipmentGroup(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("EquipmentGroupDAL", "GetByID(string groupCode)", excp.Message);
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
            _spSelectAll = "usp_EquipmentGroups_SelectAll";
			_spSelectDynamic = "usp_EquipmentGroups_SelectDynamic";
            _spDeleteAll = "usp_EquipmentGroups_DeleteAll";            
			_spDeleteDynamic = "usp_EquipmentGroups_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

