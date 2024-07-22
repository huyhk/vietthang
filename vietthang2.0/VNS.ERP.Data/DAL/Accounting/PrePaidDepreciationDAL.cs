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
	/// This object represents the properties and methods of a Data Access Layer of FixedAssetOpening.
	/// </summary>
    public class PrePaidDepreciationDAL : StockBaseDAL<PrePaidDepreciation>
	{
		public PrePaidDepreciationDAL()
		{
		}
        public PrePaidDepreciationDAL(DBHelper dbHelper)
            : base(dbHelper)
		{
			
		}

		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public override int Insert(PrePaidDepreciation t)
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
                cmd.CommandText = "usp_PrePaidDepreciations_Insert";
                cmd.CommandType =CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode",System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@PrePaidCode", System.Data.DbType.String, 10, t.PrePaidCode));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                        
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("PrePaidDepreciationDAL", "Insert(PrePaidDepreciation t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        public override int Update(PrePaidDepreciation t)
		{
           
            return 0;
        }
        public override int Delete(PrePaidDepreciation t)
        {

            return 0;
        }


        /// <summary>
        /// Get ListBase Objects From DataBase by PeriodCode.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public ListBase<PrePaidDepreciation> GetListPrePaidDepreciationByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<PrePaidDepreciation> lstReturn = new ListBase<PrePaidDepreciation>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PrePaidDepreciations_Select_ByPeriodCode";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    PrePaidDepreciation obj = new PrePaidDepreciation(reader);
                    lstReturn.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PrePaidDepreciationDAL", "GetListPrePaidDepreciationByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int DeleteByPeriodCode(string periodCode)
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
                cmd.CommandText = "usp_PrePaidDepreciations_Delete_By_PeriodCode";
                cmd.CommandType =CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("PrePaidDepreciationDAL", "DeleteByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;


        }
        public int DeleteByPeriodCode(string periodCode, string accountCode)
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
                cmd.CommandText = "usp_PrePaidDepreciations_Delete_By_PeriodCode_AccountCode";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("PrePaidDepreciationDAL", "DeleteByPeriodCode(string periodCode, string accountCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;


        }
        public DataTable GetListRatePaidDepreciations(DateTime startDate, DateTime endDate, string accountCode, string periodCode)
        {
            bool alreadyOpen = false;
            DataTable reader = new DataTable();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PrePaidDepreciations_Report";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PrePaidDepreciationDAL", "GetListRatePaidDepreciations(DateTime startDate, DateTime endDate, string accountCode,string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }

        public ListBase<AccountTransaction> SelectBySpecialTypeAccountCodeAndDate(string specialType, DateTime startDate, DateTime endDate, string accountCode)
        {
            bool alreadyOpen = false;
            ListBase<AccountTransaction> lstobj = new ListBase<AccountTransaction>();
            AccountTransaction acc = null;
            //T obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactions_SelectBySpecialType_AccountCode_And_Date";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SpecialType", System.Data.DbType.String, 50, specialType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    acc = new AccountTransaction(reader);
                    lstobj.Add(acc);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PrePaidDepreciationDAL", "SelectBySpecialTypeAccountCodeAndDate(DateTime startDate, DateTime endDate, string accountCode,string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }

        public DataTable GetPrePaidDepreciationsReportYear(int year, string accountCode)
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
                cmd.CommandText = "usp_PrePaidDepreciations_ReportYear";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@Year", System.Data.DbType.Int32, 4, year));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));

                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PrePaidDepreciationDAL", "GetPrePaidDepreciationsReportYear(int year, string accountCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
	}

}

