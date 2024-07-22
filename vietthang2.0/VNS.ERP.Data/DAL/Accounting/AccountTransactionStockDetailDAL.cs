using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionStockDetailDAL : BaseDAL<AccountTransactionStockDetail>
    {
        public AccountTransactionStockDetailDAL() { }
        public AccountTransactionStockDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountTransactionStockDetail_Select_All";
        }
        public decimal SumCostAmountX21(DateTime startDate, DateTime endDate,string goodType)
        {
            decimal result = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionDetails_Select_Sum_CostAmount_X21";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                Cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                Cmd.Parameters.Add(db.CreateParameter("@GoodType", System.Data.DbType.String, 20, goodType));
                Cmd.Parameters.Add(db.CreateParameter("@Output", System.Data.DbType.Decimal, 18, 0, System.Data.ParameterDirection.Output));
                db.ExecuteNonQuery(Cmd);
                result = (decimal)Cmd.Parameters["@Output"].Value;
            }
            catch (Exception excp)
            {
                //iError = -1000;
                Write2Log.WriteLogs("AccountTransactionStockDetailDAL", "SumCostAmountX21(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return result;
        }
        public ListBase<AccountTransactionStockDetail> GetByAccTransID(Guid accTransID)
        {
            bool alreadyOpen = false;
            ListBase<AccountTransactionStockDetail> lstReturn = new ListBase<AccountTransactionStockDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionDetails_Select_By_AccTransID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccTransID", System.Data.DbType.Guid, 16, accTransID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new AccountTransactionStockDetail(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionStockDetailDAL", "GetByAccTransID(Guid accTransID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        public int DeleteByAccTransStock(Guid accTransID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStockDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accTransID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionStockDetailDAL", "DeleteByAccTransStock(Guid accTransID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Insert(AccountTransactionStockDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStockDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                if (t.AccountTransactionDetail1ID == Guid.Empty || t.AccountTransactionDetail1ID == null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDetail1ID", System.Data.DbType.Guid, 16, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDetail1ID", System.Data.DbType.Guid, 16, t.AccountTransactionDetail1ID));
                }
                if (t.AccountTransactionDetail2ID == Guid.Empty || t.AccountTransactionDetail2ID == null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDetail2ID", System.Data.DbType.Guid, 16, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDetail2ID", System.Data.DbType.Guid, 16, t.AccountTransactionDetail2ID));
                }
                
                if (t.DebitAccountCode != null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DebitAccountCode", System.Data.DbType.String, 10, t.DebitAccountCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DebitAccountCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                if (t.StockInCode != null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, t.StockInCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                if (t.CreditAccountCode != null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@CreditAccountCode", System.Data.DbType.String, 10, t.CreditAccountCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@CreditAccountCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                if (t.StockOutCode != null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockOutCode", System.Data.DbType.String, 10, t.StockOutCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockOutCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                Cmd.Parameters.Add(db.CreateParameter("@CostPrice", System.Data.DbType.Decimal, 9, t.CostPrice));
                Cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                Cmd.Parameters.Add(db.CreateParameter("@CostAmount", System.Data.DbType.Decimal, 9, t.CostAmount));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionStockDetailDAL", "Insert(AccountTransactionStockDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(AccountTransactionStockDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStockDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDetail1ID", System.Data.DbType.Guid, 16, t.AccountTransactionDetail1ID));
                if (t.DebitAccountCode != null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DebitAccountCode", System.Data.DbType.String, 10, t.DebitAccountCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DebitAccountCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                if (t.StockInCode != null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, t.StockInCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                if (t.CreditAccountCode != null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@CreditAccountCode", System.Data.DbType.String, 10, t.CreditAccountCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@CreditAccountCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                if (t.StockOutCode != null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockOutCode", System.Data.DbType.String, 10, t.StockOutCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockOutCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                Cmd.Parameters.Add(db.CreateParameter("@CostPrice", System.Data.DbType.Decimal, 9, t.CostPrice));
                Cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                Cmd.Parameters.Add(db.CreateParameter("@CostAmount", System.Data.DbType.Decimal, 9, t.CostAmount));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionStockDetailDAL", "Update(AccountTransactionStockDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(AccountTransactionStockDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStockDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionStockDetailDAL", "Delete(AccountTransactionStockDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
