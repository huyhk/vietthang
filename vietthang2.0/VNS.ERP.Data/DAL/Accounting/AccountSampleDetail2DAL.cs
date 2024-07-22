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
	/// This object represents the properties and methods of a Data Access Layer of AccountSampleDetail2.
	/// </summary>
	public class AccountSampleDetail2DAL : StockBaseDAL<AccountSampleDetail2>
	{
		public AccountSampleDetail2DAL()
		{
		}
		public AccountSampleDetail2DAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers

        protected override void SetValues()
        {
            
			_spSelectDynamic = "usp_AccountSampleDetail2s_SelectDynamic";

        }

		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(AccountSampleDetail2 t)
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
                cmd.CommandText = "usp_AccountSampleDetail2s_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode",System.Data.DbType.String, 20, t.AccountSampleCode));
                if (t.DebitAccountCode == string.Empty || t.DebitAccountCode == null)
                {
                    cmd.Parameters.Add(db.CreateParameter("@DebitAccountCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@DebitAccountCode", System.Data.DbType.String, 10, t.DebitAccountCode));
                }
                
                if (t.DebitSubjectCode == null || t.DebitSubjectCode == string.Empty)
                {cmd.Parameters.Add(db.CreateParameter("@DebitSubjectCode", System.Data.DbType.String, 10, DBNull.Value));}
                else { cmd.Parameters.Add(db.CreateParameter("@DebitSubjectCode", System.Data.DbType.String, 10, t.DebitSubjectCode)); }
                if (t.DebitClassificationCode == null || t.DebitClassificationCode == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@DebitClassificationCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@DebitClassificationCode", System.Data.DbType.String, 10, t.DebitClassificationCode));
                }
                if (t.CreditAccountCode == null || t.CreditAccountCode == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@CreditAccountCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@CreditAccountCode", System.Data.DbType.String, 10, t.CreditAccountCode));
                }
                if (t.CreditSubjectCode == null || t.CreditSubjectCode == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@CreditSubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@CreditSubjectCode", System.Data.DbType.String, 10, t.CreditSubjectCode));
                }
                if (t.CreditClassificationCode == null || t.CreditClassificationCode == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@CreditClassificationCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@CreditClassificationCode", System.Data.DbType.String, 10, t.CreditClassificationCode));
                }
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountSampleDetail2DAL", "Insert(AccountSampleDetail2 t)", excp.Message);
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
		public override int Update(AccountSampleDetail2 t)
		{
			return 0;
		}
        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>
        public override int Delete(AccountSampleDetail2 t)
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
                cmd.CommandText = "usp_AccountSampleDetail2s_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode", System.Data.DbType.String, 20, accountSampleCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountSampleDetail2DAL", " Delete(string accountSampleCode)", excp.Message);
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
        public ListBase<AccountSampleDetail2> GetByID(string accountSampleCode)
        {
            bool alreadyOpen = false;
            AccountSampleDetail2 obj = null;
            ListBase<AccountSampleDetail2> lstDetail2 = new ListBase<AccountSampleDetail2>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountSampleDetail2s_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode", System.Data.DbType.String, 20, accountSampleCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountSampleDetail2(reader);
                    lstDetail2.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountSampleDetail2DAL", "GetByID(string accountSampleCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstDetail2;
        }
		#endregion


	}
}

