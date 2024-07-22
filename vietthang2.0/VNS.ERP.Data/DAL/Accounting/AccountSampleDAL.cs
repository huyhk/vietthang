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
	/// This object represents the properties and methods of a Data Access Layer of AccountSample.
	/// </summary>
	class AccountSampleDAL : StockBaseDAL<AccountSample>
	{
		public AccountSampleDAL()
		{
		}
		public AccountSampleDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers

        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountSamples_SelectAll";
			_spSelectDynamic = "usp_AccountSamples_SelectDynamic";
        }

		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(AccountSample t)
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
                cmd.CommandText = "usp_AccountSamples_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode",System.Data.DbType.String, 20, t.AccountSampleCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleName",System.Data.DbType.String, 50, t.AccountSampleName));
                
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, t.AccountTransactionTypeCode));
                
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountSampleDAL", "Insert(AccountSample t)", excp.Message);
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
		public override int Update(AccountSample t)
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
                cmd.CommandText = "usp_AccountSamples_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode", System.Data.DbType.String, 20, t.AccountSampleCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountSampleName", System.Data.DbType.String, 50, t.AccountSampleName));

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, t.AccountTransactionTypeCode));

                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountSampleDAL", "Update(AccountSample t)", excp.Message);
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
		public override int Delete(AccountSample t)
		{
			           
            return this.Delete( t.AccountSampleCode);
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
                cmd.CommandText = "usp_AccountSamples_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode", System.Data.DbType.String , 20, accountSampleCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountSampleDAL", "Delete(AccountSample t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		
		/// <summary>
		/// Add Details an object from database by calling Select StoredProcedure
		/// </summary>		
        public void GetDetailAccountSamples(AccountSample obj)
		{
            bool alreadyOpen = false;			
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountSamples_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@AccountSampleCode", System.Data.DbType.String , 20, obj.AccountSampleCode));
                
				reader = db.ExecuteReader(cmd);
                obj.Detail1 = new ListBase<AccountSampleDetail1>();
                    while (reader.Read())
                    {
                        AccountSampleDetail1 obj1= new AccountSampleDetail1(reader);
                        obj.Detail1.Add(obj1);
                    }
                    if (reader.NextResult())
                    {
                        obj.Detail2 = new ListBase<AccountSampleDetail2>();
                        while (reader.Read())
                        {
                            AccountSampleDetail2 obj2 = new AccountSampleDetail2(reader);
                            obj.Detail2.Add(obj2);
                        }
                    }
                   reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountSampleDAL", "GetDetailAccountSamples(AccountSample obj)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
		}

        /// <summary>
        /// Get ListBase  AccountSamples by AccountTransactionTypeCode.
        /// </summary>
        /// <param name="typeCode"></param>
        public ListBase<AccountSample> GetListAccountSamplesByTypeCode(string typeCode)
        {
            bool alreadyOpen = false;
            ListBase<AccountSample> lstAccSample = new ListBase<AccountSample>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountSamples_Select_By_AccTypeCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, typeCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountSample obj= new AccountSample(reader);
                    lstAccSample.Add(obj);
                }
             
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountSampleDAL", "GetListAccountSamplesByTypeCode(string typeCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstAccSample;
        }
		
		#endregion
	
	}

}

