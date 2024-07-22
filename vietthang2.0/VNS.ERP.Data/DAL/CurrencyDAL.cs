using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.ERP.Data;
namespace VNS.ERP.Data
{
	
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of Currency.
	/// </summary>
	public class CurrencyDAL : BaseDAL<Currency>
	{
		public CurrencyDAL()
		{
		}
		public CurrencyDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
        protected override void SetValues()
        {
            _spSelectAll = "usp_Currency_SelectAll";
        }
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(Currency t)
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
                cmd.CommandText = "usp_Currency_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@CurrencyCode",System.Data.DbType.AnsiString, 3, t.CurrencyCode));
                cmd.Parameters.Add(db.CreateParameter("@CurrencyName",System.Data.DbType.String, 50, t.CurrencyName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("CurrencyDAL", "Insert(Currency t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		public override int Update(Currency t)
		{
			return 0;
		}
		public override int Delete(Currency t)
		{
			return 0;
		}
	
		
	}
	
}

