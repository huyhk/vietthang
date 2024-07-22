using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class WeightItemDAL : StockBaseDAL<WeightItem>
    {
        const int numStockTransportCode = 6;
        public WeightItemDAL() { }
        public WeightItemDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_WeightItems_Select_All";
        }
        public ListBase<WeightItemResult> GetWeightItemResult(Guid WeightID)
        {
            ListBase<WeightItemResult> lobj = new ListBase<WeightItemResult>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItem_Select_WeightItemResult";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, WeightID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lobj.Add(new WeightItemResult(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemDAL", "GetWeightItemResult(Guid WeightID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<WeightItem> GetByTransactionIDIsNull(bool isReceive, string stockCode)
        {
            bool alreadyOpen = false;
            ListBase<WeightItem> lobj = new ListBase<WeightItem>();
            try
            {
                DbDataReader reader = null;
                //bool found;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Select_By_TransactionID_Is_Null";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, isReceive));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    WeightItem obj = new WeightItem(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemDAL", "GetByTransactionIDIsNull(bool isReceive, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<WeightItem> GetForCheckFromStockTransaction(Guid transactionID, bool isReceive, string stockCode)
        {
            bool alreadyOpen = false;
            ListBase<WeightItem> lobj = new ListBase<WeightItem>();
            try
            {
                DbDataReader reader = null;
                //bool found;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Select_For_Check_From_StockTransaction";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, isReceive));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    WeightItem obj = new WeightItem(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemDAL", "GetByTransactionIDIsNull(bool isReceive, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<WeightItem> GetByIsReceive(bool isReceive, string stockCode)
        {
            bool alreadyOpen = false;
            ListBase<WeightItem> lobj = new ListBase<WeightItem>();
            try
            {
                DbDataReader reader = null;
                //bool found;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Select_By_IsReceive";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, isReceive));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    WeightItem obj = new WeightItem(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemDAL", "GetByIsReceive(bool isReceive)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<WeightItem> GetByIsReceiveForPeriod(bool isReceive, string stockCode, DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            ListBase<WeightItem> lobj = new ListBase<WeightItem>();
            try
            {
                DbDataReader reader = null;
                //bool found;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Select_By_IsReceive_ForPeriod";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, isReceive));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    WeightItem obj = new WeightItem(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemDAL", "GetByIsReceive(bool isReceive)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }

        public ListBase<WeightItem> GetPKWithDetails(string _StockCode, string _WeightCode)
        {
            int i, j;
            string[] StockTransportCode = new string[numStockTransportCode];
            for (i = 0; i <= numStockTransportCode - 1; i++)
            {
                StockTransportCode[i] = "";
            }

            bool alreadyOpen = false;
            ListBase<WeightItem> lobj = new ListBase<WeightItem>();
            // ListBase<FormulaDetail> lFDObj = new ListBase<FormulaDetail>();
            try
            {
                DbDataReader reader = null;
                bool found;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Select_By_PK_With_Details";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, _WeightCode));
                reader = db.ExecuteReader(cmd);

                while (reader.Read())
                {
                    WeightItem obj = new WeightItem(reader);
                    lobj.Add(obj);
                }
                i = 0;
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        WeightItemDetail wid = new WeightItemDetail(reader);
                        found = false;
                        for (j = 0; j < i; j++)
                        {
                            if (StockTransportCode[j] == wid.StockTransportCode)
                            {
                                lobj[0].lstWeightItemDetail[j].Add(wid);
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            if (lobj[0].lstWeightItemDetail[i] == null) lobj[0].lstWeightItemDetail[i] = new ListBase<WeightItemDetail>();
                            StockTransportCode[i] = wid.StockTransportCode;
                            lobj[0].lstWeightItemDetail[i].Add(wid);
                            i++;
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemDAL", "GetPKWithDetails()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }

        public override int Insert(WeightItem t)
        {
            int iError = 0;

            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, new Guid(), System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, t.EmployeeID));
                cmd.Parameters.Add(db.CreateParameter("@WeightDate", System.Data.DbType.DateTime, 4, t.WeightDate));
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, t.IsReceive));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Int32, 4, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@WrappingWeight", System.Data.DbType.Decimal, 9, t.WrappingWeight));
                cmd.Parameters.Add(db.CreateParameter("@ItemWeight", System.Data.DbType.Decimal, 9, t.ItemWeight));
                cmd.Parameters.Add(db.CreateParameter("@PTVanChuyen", System.Data.DbType.String, 100, t.PTVanChuyen));
                cmd.Parameters.Add(db.CreateParameter("@PTTayBoa", System.Data.DbType.String, 100, t.PTTayBoa));
                cmd.Parameters.Add(db.CreateParameter("@DVVanChuyen", System.Data.DbType.String, 10, t.DVVanChuyen));
                cmd.Parameters.Add(db.CreateParameter("@KhoGiaoNhan", System.Data.DbType.String, 10, t.KhoGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@DVGiao", System.Data.DbType.String, 10, t.DVGiao));
                cmd.Parameters.Add(db.CreateParameter("@DVNhan", System.Data.DbType.String, 10, t.DVNhan));
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, t.TransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));


                iError = db.ExecuteNonQuery(cmd);
                t.WeightID = (Guid)cmd.Parameters["@WeightID"].Value;
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemDAL", "Insert(WeightItem t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            //if (iError > 0) iError = -1;
            return iError;
            //return base.Insert(t);
        }
        public int UpdateTransactionID(Guid _WeightID, Guid _TransactionID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_UpdateTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, _WeightID));
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, _TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemDAL", "UpdateTransactionID(Guid _WeightID, Guid _TransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            //if (iError > 0) iError = -1;
            return iError;
        }
        public int MakeNullTransactionID(Guid _TransactionID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Make_Null_TransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, _TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemDAL", "MakeNullTransactionID(Guid TransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            //if (iError > 0) iError = -1;
            return iError;
        }
        public override int Update(WeightItem t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, t.WeightID));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, t.EmployeeID));
                cmd.Parameters.Add(db.CreateParameter("@WeightDate", System.Data.DbType.DateTime, 4, t.WeightDate));
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, t.IsReceive));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Int32, 4, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@WrappingWeight", System.Data.DbType.Decimal, 9, t.WrappingWeight));
                cmd.Parameters.Add(db.CreateParameter("@ItemWeight", System.Data.DbType.Decimal, 9, t.ItemWeight));
                cmd.Parameters.Add(db.CreateParameter("@PTVanChuyen", System.Data.DbType.String, 100, t.PTVanChuyen));
                cmd.Parameters.Add(db.CreateParameter("@PTTayBoa", System.Data.DbType.String, 100, t.PTTayBoa));
                cmd.Parameters.Add(db.CreateParameter("@DVVanChuyen", System.Data.DbType.String, 10, t.DVVanChuyen));
                cmd.Parameters.Add(db.CreateParameter("@KhoGiaoNhan", System.Data.DbType.String, 10, t.KhoGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@DVGiao", System.Data.DbType.String, 10, t.DVGiao));
                cmd.Parameters.Add(db.CreateParameter("@DVNhan", System.Data.DbType.String, 10, t.DVNhan));
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, t.TransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {

                iError = -1000;
                Write2Log.WriteLogs("WeightItemDAL", "Update(WeightItem t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
           // if (iError > 0) iError = -1;
            return iError;
            //return base.Update(t);
        }
        public override int Delete(WeightItem t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItems_Delete_By_PK";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, t.WeightID));
                cmd.Parameters.Add(db.CreateParameter("@UserDelete", System.Data.DbType.String, 20, Contexts.CurrentUser.LoginName));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemDAL", "Delete(WeightItem t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
           // if (iError > 0) iError = -1;
            return iError;
            //return base.Delete(t);
        }
    }
}
