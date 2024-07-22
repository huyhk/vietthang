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
	/// This object represents the properties and methods of a Data Access Layer of AccountTransactionDetail1.
	/// </summary>
	public class AccountTransactionDetail1DAL :  StockBaseDAL<AccountTransactionDetail1>
	{
		public AccountTransactionDetail1DAL()
		{
		}
		public AccountTransactionDetail1DAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
       


         protected override void SetValues()
        {
          _spSelectDynamic = "usp_AccountTransactionDetail1s_SelectDynamic";
        }

		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(AccountTransactionDetail1 t)
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
                cmd.CommandText = "usp_AccountTransactionDetail1s_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDetail1ID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID",System.Data.DbType.Guid, 16, t.AccountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode",System.Data.DbType.String, 10, t.AccountCode));
                if(t.SubjectCode==string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.String, 10, t.SubjectCode));
                if(t.ClassificationCode==string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@ClassificationCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@ClassificationCode",System.Data.DbType.String, 10, t.ClassificationCode));
                cmd.Parameters.Add(db.CreateParameter("@DebitAmount",System.Data.DbType.Decimal, 9, t.DebitAmount));
                cmd.Parameters.Add(db.CreateParameter("@CreditAmount",System.Data.DbType.Decimal, 9, t.CreditAmount));
                if(t.CurrencyCode==string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.String, 3, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@CurrencyCode",System.Data.DbType.String, 3, t.CurrencyCode));
                cmd.Parameters.Add(db.CreateParameter("@Rate",System.Data.DbType.Decimal, 9, t.Rate));
                cmd.Parameters.Add(db.CreateParameter("@DebitAmountNT",System.Data.DbType.Decimal, 9, t.DebitAmountNT));
                cmd.Parameters.Add(db.CreateParameter("@CreditAmountNT",System.Data.DbType.Decimal, 9, t.CreditAmountNT));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));

                if (t.CongtrinhCode!=string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@CongtrinhCode", System.Data.DbType.String, 50, t.CongtrinhCode));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.AccountTransactionDetail1ID = (Guid)cmd.Parameters["@AccountTransactionDetail1ID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountTransactionDetail1DAL", "Insert(AccountTransactionDetail1 t)", excp.Message);
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
		public override int Update(AccountTransactionDetail1 t)
		{
            return 0;
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>
		public override int Delete(AccountTransactionDetail1 t)
		{
			           
            return this.Delete(t.AccountTransactionID);
		}

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid accountTransactionID)
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
                cmd.CommandText = "usp_AccountTransactionDetail1s_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountTransactionDetail1DAL", " Delete(Guid accountTransactionID)", excp.Message);
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
		public ListBase<AccountTransactionDetail1> GetByID(Guid accountTransactionID)
		{
            bool alreadyOpen = false;			
			AccountTransactionDetail1 obj = null;
            ListBase<AccountTransactionDetail1> lstDetail1 = new ListBase<AccountTransactionDetail1>();
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetail1s_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid , 16, accountTransactionID));
                
				reader = db.ExecuteReader(cmd);
				while (reader.Read())
                {
                    obj = new AccountTransactionDetail1(reader);
                    lstDetail1.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("AccountTransactionDetail1DAL", "GetByID(Guid accountTransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstDetail1;
		}

        public ListBase<AccountTransactionDetail1> GetListBaseByPeriodCodeFromFixedAssetDepreciations(string periodCode)
		{
            bool alreadyOpen = false;			
			AccountTransactionDetail1 obj = null;
            ListBase<AccountTransactionDetail1> lstDetail1 = new ListBase<AccountTransactionDetail1>();
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetail1s_Select_PeriodCode_FromFixedAssetDepreciations";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                
				reader = db.ExecuteReader(cmd);
				while (reader.Read())
                {
                    obj = new AccountTransactionDetail1(reader);
                    lstDetail1.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDetail1DAL", "GetListBaseByPeriodCodeFromFixedAssetDepreciations(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstDetail1;
		}

        public ListBase<AccountTransactionDetail1> GetListBaseByPeriodCodeFromPrePaidDepreciations(string periodCode)
        {
            bool alreadyOpen = false;
            AccountTransactionDetail1 obj = null;
            ListBase<AccountTransactionDetail1> lstDetail1 = new ListBase<AccountTransactionDetail1>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetail1s_Select_PeriodCode_FromPrePaidDepreciations";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountTransactionDetail1(reader);
                    lstDetail1.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDetail1DAL", "GetListBaseByPeriodCodeFromPrePaidDepreciations(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstDetail1;
        }
	
		
	}
}

