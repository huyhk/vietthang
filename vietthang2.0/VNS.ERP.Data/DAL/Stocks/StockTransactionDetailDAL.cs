using System;
using System.Collections.Generic;
using System.Text;
using VNS.Utils;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class StockTransactionDetailDAL : StockBaseDAL<StockTransactionDetail>
    {
        public StockTransactionDetailDAL() { }
        public StockTransactionDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_StockTransactionDetails_Select_All";
            //base.SetValues();
        }
        
        public override int Insert(StockTransactionDetail t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactionDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                if (t.InLocation == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@InLocation", System.Data.DbType.String, 10, DBNull.Value));
                }
                else 
                {
                    cmd.Parameters.Add(db.CreateParameter("@InLocation", System.Data.DbType.String, 10, t.InLocation));
                }
                if (t.OutLocation == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@OutLocation", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@OutLocation", System.Data.DbType.String, 10, t.OutLocation));
                }
                  
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@GoodCode", System.Data.DbType.String, 200, t.GoodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDetailDAL", "Insert(StockTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
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
                cmd.CommandText = "usp_StockTransactionDetails_Delete_By_TransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, _TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDetailDAL", "DeleteByTransactionID(string _TransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public ListBase<StockTransactionDetail> GetByWeightIDInWeighItemResult(Guid _WeightID)
        {
            ListBase<StockTransactionDetail> lobj = new ListBase<StockTransactionDetail>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactionDetails_Select_By_WeightID_In_WeightItemResult";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, _WeightID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransactionDetail obj = new StockTransactionDetail(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDetailDAL", "GetByWeightIDInWeighItemResult(Guid _WeightID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<StockTransactionSumDetail> GetByTransactionID(Guid _TransactionID)
        {
            DbDataReader reader = null;
            ListBase<StockTransactionSumDetail> lobj = new ListBase<StockTransactionSumDetail>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactionDetails_Get_By_TransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, _TransactionID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransactionSumDetail obj = new StockTransactionSumDetail(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDetailDAL", "GetByTransactionID(Guid _TransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<StockTransactionDetail> GetByGoodCode(string searchString)
        {
            DbDataReader reader = null;
            ListBase<StockTransactionDetail> lobj = new ListBase<StockTransactionDetail>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactionDetail_GetByGoodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SearchString", System.Data.DbType.String, 50, searchString));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransactionDetail obj = new StockTransactionDetail(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDetailDAL", "GetByTransactionID(Guid _TransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
    }
}
