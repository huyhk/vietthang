

/************************************************************************
**	ClassName	: 	EquipmentDAL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	10-07-2008 11:48 AM
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
	#region EquipmentDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of Equipment.
	/// </summary>
	public class EquipmentDAL : BaseDAL<Equipment>
	{
		public EquipmentDAL()
		{
		}
		public EquipmentDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(Equipment t)
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
                cmd.CommandText = "usp_Equipments_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@EquipmentCode",System.Data.DbType.AnsiString, 10, t.EquipmentCode));
                cmd.Parameters.Add(db.CreateParameter("@EquipmentName",System.Data.DbType.String, 50, t.EquipmentName));
                cmd.Parameters.Add(db.CreateParameter("@GroupCode",System.Data.DbType.AnsiString, 10, t.GroupCode));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
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
                Write2Log.WriteLogs("EquipmentDAL", "Insert(Equipment t)", excp.Message);
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
		public override int Update(Equipment t)
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
                cmd.CommandText = "usp_Equipments_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@EquipmentCode",System.Data.DbType.AnsiString, 10, t.EquipmentCode));
                cmd.Parameters.Add(db.CreateParameter("@EquipmentName",System.Data.DbType.String, 50, t.EquipmentName));
                cmd.Parameters.Add(db.CreateParameter("@GroupCode",System.Data.DbType.AnsiString, 10, t.GroupCode));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                //cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
                //cmd.Parameters.Add(db.CreateParameter("@ServerCreated",System.Data.DbType.AnsiString, 20, t.ServerCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentDAL", "Update(Equipment t)", excp.Message);
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
		public override int Delete(Equipment t)
		{
			           
            return this.Delete( t.EquipmentCode);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(string equipmentCode)
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
                cmd.CommandText = "usp_Equipments_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@EquipmentCode", System.Data.DbType.AnsiString , 10, equipmentCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentDAL", "Delete(Equipment t)", excp.Message);
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
		public Equipment GetByID(string equipmentCode)
		{
            //int iError = 0;
            bool alreadyOpen = false;			
			Equipment obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Equipments_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@EquipmentCode", System.Data.DbType.AnsiString , 10, equipmentCode));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new Equipment(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("EquipmentDAL", "GetByID(string equipmentCode)", excp.Message);
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
            _spSelectAll = "usp_Equipments_SelectAll";
			_spSelectDynamic = "usp_Equipments_SelectDynamic";
            _spDeleteAll = "usp_Equipments_DeleteAll";            
			_spDeleteDynamic = "usp_Equipments_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

