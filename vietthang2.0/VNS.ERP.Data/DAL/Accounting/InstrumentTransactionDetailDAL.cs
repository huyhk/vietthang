using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data.Accounting
{
    public class InstrumentTransactionDetailDAL : BaseDAL<InstrumentTransactionDetail>
    {
        public InstrumentTransactionDetailDAL() { }
        public InstrumentTransactionDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_InstrumentTransactionDetail_Select_All";
        }
        public override int Insert(InstrumentTransactionDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_InstrumentTransactionDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionDetailID", System.Data.DbType.Guid, 16, t.TransactionDetailID, System.Data.ParameterDirection.Output));
                if (t.StockInCode == string.Empty || t.StockInCode == null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, t.StockInCode));
                }
                if (t.StockOutCode == string.Empty || t.StockOutCode == null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockOutCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@StockOutCode", System.Data.DbType.String, 10, t.StockOutCode));
                }
                
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 20, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                Cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                if (t.DepType == string.Empty || t.DepType == null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DepType", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DepType", System.Data.DbType.String, 20, t.DepType));
                }
                Cmd.Parameters.Add(db.CreateParameter("@DepAccountCode", System.Data.DbType.String, 10, t.DepAccountCode));
                Cmd.Parameters.Add(db.CreateParameter("@DepSubjectCode", System.Data.DbType.String, 10, t.DepSubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@DepClassificationCode", System.Data.DbType.String, 10, t.DepClassificationCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.TransactionDetailID = (Guid)Cmd.Parameters["@TransactionDetailID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InstrumentTransactionDetailDAL", "Insert(InstrumentTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(InstrumentTransactionDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_InstrumentTransactionDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@DepClassificationCode", System.Data.DbType.String, 10, t.DepClassificationCode));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionDetailID", System.Data.DbType.Guid, 16, t.TransactionDetailID));
                Cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, t.StockInCode));
                Cmd.Parameters.Add(db.CreateParameter("@StockOutCode", System.Data.DbType.String, 10, t.StockOutCode));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 20, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                Cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                Cmd.Parameters.Add(db.CreateParameter("@DepType", System.Data.DbType.String, 20, t.DepType));
                Cmd.Parameters.Add(db.CreateParameter("@DepAccountCode", System.Data.DbType.String, 10, t.DepAccountCode));
                Cmd.Parameters.Add(db.CreateParameter("@DepSubjectCode", System.Data.DbType.String, 10, t.DepSubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InstrumentTransactionDetailDAL", "Update(InstrumentTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int DeleteByInstrumentTransactionID(Guid instrumentTransactionID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_InstrumentTransactionDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, instrumentTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InstrumentTransactionDetailDAL", "DeleteByInstrumentTransactionID(Guid instrumentTransactionID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(InstrumentTransactionDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_InstrumentTransactionDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InstrumentTransactionDetailDAL", "Delete(InstrumentTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
