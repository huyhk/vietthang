using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{

	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of FixedAsset.
	/// </summary>
    public class AccountOpeningDAL : StockBaseDAL<AccountOpening>
	{

		public AccountOpeningDAL()
		{
		}
        public AccountOpeningDAL(DBHelper dbHelper)
            : base(dbHelper)
		{
			
		}
        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountOpenings_SelectAll";

        }
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public override int Insert(AccountOpening t)
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
                cmd.CommandText = "usp_AccountOpenings_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, t.AccountCode));
                if(t.SubjectCode==string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@OpeningAmount", System.Data.DbType.Decimal, 9, t.OpeningAmount));
                cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.String, 3, t.CurrencyCode));
                cmd.Parameters.Add(db.CreateParameter("@OpeningAmountNT", System.Data.DbType.Decimal, 9, t.OpeningAmountNT));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountOpeningDAL", "Insert(AccountOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        public decimal GetOpenAmount(string accountCode, string periodCode)
        {
            decimal result = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountOpenings_OpenAmount_For_AccountCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@Result", System.Data.DbType.Decimal, 9, 0, ParameterDirection.Output));
               
                db.ExecuteNonQuery(cmd);
                result = (decimal)cmd.Parameters["@Result"].Value;
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountOpeningDAL", "GetOpenAmount(string accountCode, DateTime openDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return result;
        }
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>
		public override int Delete(AccountOpening t)
		{
            return this.Delete( t.PeriodCode);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
        public int Delete(string periodCode)
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
                cmd.CommandText = "usp_AccountOpenings_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
               	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountOpeningDAL", "Delete(AccountOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        /// <summary>
        /// Get ListBase Objects From DataBase by PeriodCode.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public ListBase<AccountOpening> GetListAccountOpeningByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<AccountOpening> lstReturn = new ListBase<AccountOpening>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountOpenings_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountOpening obj = new AccountOpening(reader);
                    lstReturn.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountOpeningDAL", "GetListAccountOpeningByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }

        public ListBase<AccountOpening> GetFromCustomerDeptSumOpenings(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<AccountOpening> lstReturn = new ListBase<AccountOpening>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountOpenings_Select_From_CustomerDeptSumOpenings";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountOpening obj = new AccountOpening(reader);
                    lstReturn.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountOpeningDAL", "GetFromCustomerDeptSumOpenings(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        public ListBase<AccountOpening> GetFromFixedAssetOpenings(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<AccountOpening> lstReturn = new ListBase<AccountOpening>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountOpenings_Select_From_FixedAssetOpenings";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountOpening obj = new AccountOpening(reader);
                    lstReturn.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountOpeningDAL", "GetFromFixedAssetOpenings(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
    }
}
