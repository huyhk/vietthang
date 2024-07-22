

/************************************************************************
**	ClassName	: 	MaterialTestFrequencysDAL
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	19-02-2008 02:23 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.KCS
{
	#region MaterialTestFrequencysDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of MaterialTestFrequencys.
	/// </summary>
	public class MaterialTestFrequencysDAL : BaseDAL<MaterialTestFrequencys>
	{
		public MaterialTestFrequencysDAL()
		{
		}
		public MaterialTestFrequencysDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(MaterialTestFrequencys t)
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
                cmd.CommandText = "usp_MaterialTestFrequencys_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@ItemCode",System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TechCode",System.Data.DbType.String, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@FrequencyType",System.Data.DbType.AnsiString, 20, t.FrequencyType));
                cmd.Parameters.Add(db.CreateParameter("@Quantity",System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@QuantityLocal", System.Data.DbType.Decimal, 9, t.QuantityLocal));

				
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
                Write2Log.WriteLogs("MaterialTestFrequencysDAL", "Insert(MaterialTestFrequencys t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        public override int Update(MaterialTestFrequencys t)
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
                cmd.CommandText = "usp_MaterialTestFrequencys_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@FrequencyType", System.Data.DbType.AnsiString, 20, t.FrequencyType));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                //cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@QuantityLocal", System.Data.DbType.Decimal, 9, t.QuantityLocal));

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
                Write2Log.WriteLogs("MaterialTestFrequencysDAL", "Update(MaterialTestFrequencys t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public ListBase<MaterialTestFrequencys> GetByItemCode(string itemCode)
        {
            DbDataReader reader = null;
            ListBase<MaterialTestFrequencys> lstReturn = new ListBase<MaterialTestFrequencys>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_MaterialTestFrequencys_SelectByItemCode";
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, itemCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    MaterialTestFrequencys obj = new MaterialTestFrequencys(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialTestFrequencysDAL", "GetByItemCode(string itemCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }

		public override int Delete(MaterialTestFrequencys t)
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
                cmd.CommandText = "usp_MaterialTestFrequencys_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.AnsiString, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
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
                Write2Log.WriteLogs("MaterialTestFrequencysDAL", "Delete(MaterialTestFrequencys t)", excp.Message);
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
            _spSelectAll = "usp_MaterialTestFrequencys_SelectAll";
			_spSelectDynamic = "usp_MaterialTestFrequencys_SelectDynamic";
            _spDeleteAll = "usp_MaterialTestFrequencys_DeleteAll";            
			_spDeleteDynamic = "usp_MaterialTestFrequencys_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

