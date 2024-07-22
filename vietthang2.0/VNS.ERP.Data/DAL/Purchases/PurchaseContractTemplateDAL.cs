

/************************************************************************
**	ClassName	: 	PurchaseContractTemplateDAL
**	Author		:	Ai tang
**	Company		:	VNS
**	Date		:	13-08-2009 02:01 PM
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
	#region PurchaseContractTemplateDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of PurchaseContractTemplate.
	/// </summary>
	public class PurchaseContractTemplateDAL : BaseDAL<PurchaseContractTemplate>
	{
		public PurchaseContractTemplateDAL()
		{
		}
		public PurchaseContractTemplateDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(PurchaseContractTemplate t)
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
                cmd.CommandText = "usp_PurchaseContractTemplate_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@TemplateCode",System.Data.DbType.AnsiString, 20, t.TemplateCode));
                cmd.Parameters.Add(db.CreateParameter("@TemplateName",System.Data.DbType.String, 50, t.TemplateName));
                cmd.Parameters.Add(db.CreateParameter("@TemplateType",System.Data.DbType.Int32, 4, t.TemplateType));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode",System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TemplateContent",System.Data.DbType.String, 4000, t.TemplateContent));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
				
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
                Write2Log.WriteLogs("PurchaseContractTemplateDAL", "Insert(PurchaseContractTemplate t)", excp.Message);
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
		public override int Update(PurchaseContractTemplate t)
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
                cmd.CommandText = "usp_PurchaseContractTemplate_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@TemplateCode",System.Data.DbType.AnsiString, 20, t.TemplateCode));
                cmd.Parameters.Add(db.CreateParameter("@TemplateName",System.Data.DbType.String, 50, t.TemplateName));
                cmd.Parameters.Add(db.CreateParameter("@TemplateType",System.Data.DbType.Int32, 4, t.TemplateType));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode",System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TemplateContent",System.Data.DbType.String, 4000, t.TemplateContent));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractTemplateDAL", "Update(PurchaseContractTemplate t)", excp.Message);
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
		public override int Delete(PurchaseContractTemplate t)
		{
			           
            return this.Delete( t.TemplateCode);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(string templateCode)
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
                cmd.CommandText = "usp_PurchaseContractTemplate_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@TemplateCode", System.Data.DbType.AnsiString , 20, templateCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractTemplateDAL", "Delete(PurchaseContractTemplate t)", excp.Message);
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
		public PurchaseContractTemplate GetByID(string templateCode)
		{
			int iError = 0;
            bool alreadyOpen = false;			
			PurchaseContractTemplate obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchaseContractTemplate_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@TemplateCode", System.Data.DbType.AnsiString , 20, templateCode));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new PurchaseContractTemplate(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("PurchaseContractTemplateDAL", "GetByID(string templateCode)", excp.Message);
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
            _spSelectAll = "usp_PurchaseContractTemplate_SelectAll";
			_spSelectDynamic = "usp_PurchaseContractTemplate_SelectDynamic";
            _spDeleteAll = "usp_PurchaseContractTemplate_DeleteAll";            
			_spDeleteDynamic = "usp_PurchaseContractTemplate_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

