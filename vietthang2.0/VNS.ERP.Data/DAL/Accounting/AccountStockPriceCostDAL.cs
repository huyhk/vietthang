using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using System.Data;
namespace VNS.ERP.Data.Accounting
{
    public class AccountStockPriceCostDAL : BaseDAL<AccountStockPriceCost>
    {
        public AccountStockPriceCostDAL() { }
        public AccountStockPriceCostDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountStockPriceCost_Select_All";
            _spDeleteDynamic = "usp_AccountStockPriceCosts_DeleteDynamic";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        public void UpdateOutStockCostPriceProduct(string periodCode)
        {
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStocks_Update_OutStock_CostPrice_Product";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                db.ExecuteNonQuery(Cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountStockPriceCostDAL", "UpdateOutStockCostPriceProduct(string periodCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
        }
        /// <summary>
        /// Update OutStock CostPrice
        /// </summary>
        /// <param name="periodCode">PeriodCode</param>
        public void UpdateOutStockCostPrice(string periodCode)
        {
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStocks_Update_OutStock_CostPrice";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                db.ExecuteNonQuery(Cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountStockPriceCostDAL", "UpdateOutStockCostPrice(string periodCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public DataTable GetMaterialOutStockPrice(string periodCode)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CalculateMaterialOutStockPrice";
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountStockPriceCostDAL", "GetMaterialOutStockPrice(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public DataTable GetProductOutStockPrice(string periodCode)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CalculateProductOutStockPrice";
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountStockPriceCostDAL", "GetProductOutStockPrice(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public override int Insert(AccountStockPriceCost t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountStockPriceCost_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                Cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, t.AccountCode));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@PriceCost", System.Data.DbType.Decimal, 9, t.PriceCost));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountStockPriceCostDAL", "Insert(AccountStockPriceCost t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(AccountStockPriceCost t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountStockPriceCost_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                Cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, t.AccountCode));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@PriceCost", System.Data.DbType.Decimal, 9, t.PriceCost));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountStockPriceCostDAL", "Update(AccountStockPriceCost t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(AccountStockPriceCost t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountStockPriceCost_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountStockPriceCostDAL", "Delete(AccountStockPriceCost t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
