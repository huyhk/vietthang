

/************************************************************************
**	ClassName	: 	EquipmentsxsDAL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	09-07-2008 01:17 PM
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
	#region EquipmentsxDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of Equipmentsxs.
	/// </summary>
	public class EquipmentsxDAL : BaseDAL<Equipmentsx>
	{
		public EquipmentsxDAL()
		{
		}
		public EquipmentsxDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(Equipmentsx t)
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
                cmd.CommandText = "usp_Equipmentsxs_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@EquipmentsxCode",System.Data.DbType.AnsiString, 10, t.EquipmentsxCode));
                cmd.Parameters.Add(db.CreateParameter("@EquipmentsxName",System.Data.DbType.String, 50, t.EquipmentsxName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
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
                Write2Log.WriteLogs("EquipmentsxDAL", "Insert(Equipmentsx t)", excp.Message);
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
		public override int Update(Equipmentsx t)
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
                cmd.CommandText = "usp_Equipmentsxs_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@EquipmentsxCode",System.Data.DbType.AnsiString, 10, t.EquipmentsxCode));
                cmd.Parameters.Add(db.CreateParameter("@EquipmentsxName",System.Data.DbType.String, 50, t.EquipmentsxName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
                //cmd.Parameters.Add(db.CreateParameter("@ServerCreated",System.Data.DbType.AnsiString, 20, t.ServerCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
	                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentsxDAL", "Update(Equipmentsx t)", excp.Message);
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
		public override int Delete(Equipmentsx t)
		{
			           
            return this.Delete( t.EquipmentsxCode);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(string equipmentsxCode)
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
                cmd.CommandText = "usp_Equipmentsxs_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@EquipmentsxCode", System.Data.DbType.AnsiString , 10, equipmentsxCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentsxDAL", "Delete(Equipmentsx t)", excp.Message);
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
		public Equipmentsx GetByID(string equipmentsxCode)
		{
            //int iError = 0;
            bool alreadyOpen = false;			
			Equipmentsx obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Equipmentsxs_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@EquipmentsxCode", System.Data.DbType.AnsiString , 10, equipmentsxCode));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new Equipmentsx(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("EquipmentsxDAL", "GetByID(string equipmentsxCode)", excp.Message);
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
            _spSelectAll = "usp_Equipmentsxs_SelectAll";
			_spSelectDynamic = "usp_Equipmentsxs_SelectDynamic";
            _spDeleteAll = "usp_Equipmentsxs_DeleteAll";            
			_spDeleteDynamic = "usp_Equipmentsxs_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

