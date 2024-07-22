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
	/// This object represents the properties and methods of a Data Access Layer of AccountTransactionDetail2.
	/// </summary>
	public class AccountTransactionDetail2DAL :  StockBaseDAL<AccountTransactionDetail2>
	{
		public AccountTransactionDetail2DAL()
		{
		}
		public AccountTransactionDetail2DAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers

        protected override void SetValues()
        {
            _spSelectDynamic = "usp_AccountTransactionDetail2_SelectDynamic";
        }
        public ListBase<AccountTransactionDetail2> GetListBaseByPeriodCodeFromPrePaidDepreciations(string periodCode, string accountCode)
        {
            bool alreadyOpen = false;
            AccountTransactionDetail2 obj = null;
            ListBase<AccountTransactionDetail2> lstDetail2 = new ListBase<AccountTransactionDetail2>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetail2s_Select_PeriodCode_FromPrePaidDepreciations";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountTransactionDetail2(reader);
                    lstDetail2.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDetail2DAL", "GetListBaseByPeriodCodeFromPrePaidDepreciations(string periodCode, string accountCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstDetail2;
        }

        public ListBase<AccountTransactionDetail2> GetListBaseByPeriodCodeFromFixedAssetDepreciations(string periodCode, bool subTK)
        {
            bool alreadyOpen = false;
            AccountTransactionDetail2 obj = null;
            ListBase<AccountTransactionDetail2> lstDetail2 = new ListBase<AccountTransactionDetail2>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetail2s_Select_PeriodCode_FromFixedAssetDepreciations";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@SubTK", System.Data.DbType.Boolean, 1, subTK));
                //cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountTransactionDetail2(reader);
                    lstDetail2.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDetail2DAL", "GetListBaseByPeriodCodeFromFixedAssetDepreciations(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstDetail2;
        }
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(AccountTransactionDetail2 t)
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
                cmd.CommandText = "usp_AccountTransactionDetail2s_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDetail2ID", System.Data.DbType.Guid, 16, t.AccountTransactionDetail2ID, ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID",System.Data.DbType.Guid, 16, t.AccountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@DebitAccountCode",System.Data.DbType.String, 10, t.DebitAccountCode));
                cmd.Parameters.Add(db.CreateParameter("@DebitSubjectCode",System.Data.DbType.String, 10, t.DebitSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@DebitClassificationCode",System.Data.DbType.String, 10, t.DebitClassificationCode));
                cmd.Parameters.Add(db.CreateParameter("@CreditAccountCode",System.Data.DbType.String, 10, t.CreditAccountCode));
                cmd.Parameters.Add(db.CreateParameter("@CreditSubjectCode",System.Data.DbType.String, 10, t.CreditSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@CreditClassificationCode",System.Data.DbType.String, 10, t.CreditClassificationCode));
                cmd.Parameters.Add(db.CreateParameter("@Amount",System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@AmountNT",System.Data.DbType.Decimal, 9, t.AmountNT));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Description2", System.Data.DbType.String, 200, t.Description2));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.AccountTransactionDetail2ID = (Guid)cmd.Parameters["@AccountTransactionDetail2ID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountTransactionDetail2DAL", "Insert(AccountTransactionDetail2 t)", excp.Message);
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
		public override int Update(AccountTransactionDetail2 t)
		{
            return 0;
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>
		public override int Delete(AccountTransactionDetail2 t)
		{
			           
            return this.Delete( t.AccountTransactionID);
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
                cmd.CommandText = "usp_AccountTransactionDetail2s_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid , 16, accountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountTransactionDetail2DAL", "Delete(AccountTransactionDetail2 t)", excp.Message);
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
		public  ListBase<AccountTransactionDetail2> GetByID(Guid accountTransactionID)
		{
            bool alreadyOpen = false;			
			AccountTransactionDetail2 obj = null;
            ListBase<AccountTransactionDetail2> lstDetail2 = new ListBase<AccountTransactionDetail2>();
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetail2s_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid , 16, accountTransactionID));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountTransactionDetail2(reader);
                    lstDetail2.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("AccountTransactionDetail2DAL", "GetByID(Guid accountTransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstDetail2;
		}

        /// <summary>
        /// Returns an object from database by calling Select StoredProcedure
        /// </summary>		
        public DataTable GetByStartDate_EndDate_And_DebitAccountCode(DateTime startDate,DateTime endDate,string accountCode)
        {
            bool alreadyOpen = false;
            DataTable dt = new DataTable();
            
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetail2s_Select_StartDate_EndDate_And_AccountCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));

             //   cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDetail2DAL", " GetByStartDate_EndDate_And_DebitAccountCode(DateTime startDate,DateTime endDate,string accountCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
		
        public DataTable GetCloseAmountByAccountCode(DateTime startDate,DateTime endDate)
        {
            bool alreadyOpen = false;
            DataTable dt = new DataTable();
            
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetail2_Select_CloseAmount_ByAccountCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDetail2DAL", "GetCloseAmountByAccountCode(DateTime startDate,DateTime endDate,string accountCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
		#endregion
		
	}
	
}

