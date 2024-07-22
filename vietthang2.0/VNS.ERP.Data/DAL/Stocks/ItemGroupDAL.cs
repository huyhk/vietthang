

/************************************************************************
**	ClassName	: 	ItemGroupDAL
**	Author		:	Ai tang
**	Company		:	VNS
**	Date		:	25-07-2009 10:28 AM
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
	#region ItemGroupDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of ItemGroup.
	/// </summary>
	public class ItemGroupDAL : BaseDAL<ItemGroup>
	{
		public ItemGroupDAL()
		{
		}
		public ItemGroupDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(ItemGroup t)
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
                cmd.CommandText = "usp_ItemGroup_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@GroupCode",System.Data.DbType.AnsiString, 10, t.GroupCode));
                cmd.Parameters.Add(db.CreateParameter("@GroupName",System.Data.DbType.String, 50, t.GroupName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("Masapxep", System.Data.DbType.String, 10, t.Masapxep));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemGroupDAL", "Insert(ItemGroup t)", excp.Message);
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
		public override int Update(ItemGroup t)
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
                cmd.CommandText = "usp_ItemGroup_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@GroupCode",System.Data.DbType.AnsiString, 10, t.GroupCode));
                cmd.Parameters.Add(db.CreateParameter("@GroupName",System.Data.DbType.String, 50, t.GroupName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("Masapxep", System.Data.DbType.String, 10, t.Masapxep));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemGroupDAL", "Update(ItemGroup t)", excp.Message);
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
		public override int Delete(ItemGroup t)
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
                cmd.CommandText = "usp_ItemGroup_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@GroupCode", System.Data.DbType.AnsiString , 10, groupCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemGroupDAL", "Delete(ItemGroup t)", excp.Message);
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
		public ItemGroup GetByID(string groupCode)
		{
			int iError = 0;
            bool alreadyOpen = false;			
			ItemGroup obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemGroup_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@GroupCode", System.Data.DbType.AnsiString , 10, groupCode));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new ItemGroup(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("ItemGroupDAL", "GetByID(string groupCode)", excp.Message);
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
            _spSelectAll = "usp_ItemGroup_SelectAll";
			_spSelectDynamic = "usp_ItemGroup_SelectDynamic";
            _spDeleteAll = "usp_ItemGroup_DeleteAll";            
			_spDeleteDynamic = "usp_ItemGroup_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

