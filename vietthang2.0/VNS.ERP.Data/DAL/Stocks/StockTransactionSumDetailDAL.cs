using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;

using System.Data.Common;
using VNS.Utils;

namespace VNS.ERP.Data
{
    public class StockTransactionSumDetailDAL : StockBaseDAL<StockTransactionSumDetail>
    {
        public StockTransactionSumDetailDAL()
        { }
        public StockTransactionSumDetailDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_StockTransactionSumDetails_Select_All";
            //base.SetValues();
        }
        public override int Insert(StockTransactionSumDetail t)
        {
            //Employees Obj = GetByID(t.EmployeeID);
            //if (Obj != null) return -1;
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_StockTransactionSumDetails_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@QuantityReg", System.Data.DbType.Decimal, 9, t.QuantityReg));
                Cmd.Parameters.Add(db.CreateParameter("@QuantityInclWrapping", System.Data.DbType.Decimal, 9, t.QuantityInclWrapping));
                Cmd.Parameters.Add(db.CreateParameter("@WrappingCounter", System.Data.DbType.Int32, 2, t.WrappingCounter));
                Cmd.Parameters.Add(db.CreateParameter("@PriceCost", System.Data.DbType.Decimal, 9, t.PriceCost));
                Cmd.Parameters.Add(db.CreateParameter("@AmountCost", System.Data.DbType.Decimal, 9, t.AmountCost));
                Cmd.Parameters.Add(db.CreateParameter("@PriceIn", System.Data.DbType.Decimal, 9, t.PriceIn));
                Cmd.Parameters.Add(db.CreateParameter("@AmountIn", System.Data.DbType.Decimal, 9, t.AmountIn));
                Cmd.Parameters.Add(db.CreateParameter("@PriceOut", System.Data.DbType.Decimal, 9, t.PriceOut));
                Cmd.Parameters.Add(db.CreateParameter("@AmountOut", System.Data.DbType.Decimal, 9, t.AmountOut));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionSumDetailDAL", "Insert(StockTransactionSumDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        //public override int Update(StockTransactionSumDetail t)
        //{
        //    int iError = 0;
        //    bool AlreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else AlreadyOpen = true;
        //        DbCommand Cmd = db.CreateCommand();
        //        Cmd.CommandText = "usp_StockTransactionSumDetails_Update";
        //        Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
        //        Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 10, t.ItemCode));
        //        Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
        //        Cmd.Parameters.Add(db.CreateParameter("@QuantityReg", System.Data.DbType.Decimal, 9, t.QuantityReg));
        //        Cmd.Parameters.Add(db.CreateParameter("@QuantityInclWrapping", System.Data.DbType.Decimal, 9, t.QuantityInclWrapping));
        //        Cmd.Parameters.Add(db.CreateParameter("@WrappingCounter", System.Data.DbType.Int16, 2, t.WrappingCounter));
        //        Cmd.Parameters.Add(db.CreateParameter("@PriceCost", System.Data.DbType.Decimal, 9, t.PriceCost));
        //        Cmd.Parameters.Add(db.CreateParameter("@AmountCost", System.Data.DbType.Decimal, 9, t.AmountCost));
        //        Cmd.Parameters.Add(db.CreateParameter("@PriceIn", System.Data.DbType.Decimal, 9, t.PriceIn));
        //        Cmd.Parameters.Add(db.CreateParameter("@AmountIn", System.Data.DbType.Decimal, 9, t.AmountIn));
        //        Cmd.Parameters.Add(db.CreateParameter("@PriceOut", System.Data.DbType.Decimal, 9, t.PriceOut));
        //        Cmd.Parameters.Add(db.CreateParameter("@AmountOut", System.Data.DbType.Decimal, 9, t.AmountOut));
        //        Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
        //        iError = db.ExecuteNonQuery(Cmd);
        //        iError = (int)Cmd.Parameters["@iError"].Value;
        //    }
        //    catch (Exception excp)
        //    {
        //        iError = -1000;
        //        Write2Log.WriteLogs("StockTransactionSumDetailDAL", "Update(StockTransactionSumDetail t)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!AlreadyOpen) db.Close();
        //    }
        //    return iError;
        //}
        public int UpdateGiamua(StockTransactionSumDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.CommandText = "usp_StockTransactionSumDetails_Update_Giamua";
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@PriceIn", System.Data.DbType.Decimal, 9, t.PriceIn));
                Cmd.Parameters.Add(db.CreateParameter("@AmountIn", System.Data.DbType.Decimal, 9, t.AmountIn));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionSumDetailDAL", "UpdateGiamua(StockTransactionSumDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int DeleteByTransactionID(Guid _TransactionID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactionSumDetails_Delete_By_TransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, _TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionSumDetailDAL", "DeleteByTransactionID(string _TransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
