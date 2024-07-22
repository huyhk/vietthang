using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.ERP.Data;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
	
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of AccountSampleDetail1.
	/// </summary>
	public class AccountSampleDetail1DAL : StockBaseDAL<AccountSampleDetail1>
	{
		public AccountSampleDetail1DAL()
		{
		}
		public AccountSampleDetail1DAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers

        protected override void SetValues()
        {
            _spSelectDynamic = "usp_AccountSampleDetail1s_SelectDynamic";

        }
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(AccountSampleDetail1 t)
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
                cmd.CommandText = "usp_AccountSampleDetail1s_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode",System.Data.DbType.String, 20, t.AccountSampleCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode",System.Data.DbType.String, 10, t.AccountCode));
                if (t.SubjectCode == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                }
                
                if(t.ClassificationCode == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@ClassificationCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@ClassificationCode",System.Data.DbType.String, 10, t.ClassificationCode));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountSampleDetail1DAL", "Insert(AccountSampleDetail1 t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        /// <summary>
        /// Updates an object from database by calling Delete StoredProcedure
        /// </summary>
		public override int Update(AccountSampleDetail1 t)
		{
			return 0;
		}
        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>
        public override int Delete(AccountSampleDetail1 t)
        {

            return this.Delete(t.AccountSampleCode);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(string accountSampleCode)
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
                cmd.CommandText = "usp_AccountSampleDetail1s_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode", System.Data.DbType.String, 20, accountSampleCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountSampleDetail1DAL", " Delete(string accountSampleCode)", excp.Message);
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
        public ListBase<AccountSampleDetail1> GetByID(string accountSampleCode)
        {
            bool alreadyOpen = false;
            AccountSampleDetail1 obj = null;
            ListBase<AccountSampleDetail1> lstDetail1 = new ListBase<AccountSampleDetail1>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountSampleDetail1s_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode", System.Data.DbType.String, 20, accountSampleCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountSampleDetail1(reader);
                    lstDetail1.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountSampleDetail1DAL", "GetByID(string accountSampleCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstDetail1;
        }
		#endregion
		
	}
	
}

