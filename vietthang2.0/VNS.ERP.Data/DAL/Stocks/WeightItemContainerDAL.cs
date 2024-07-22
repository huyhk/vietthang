using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class WeightItemContainerDAL : BaseDAL<WeightItemContainer>
    {
        public WeightItemContainerDAL() { }
        public WeightItemContainerDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_WeightItemContainer_Select_All";
        }
        public int UpdateTransactionID(Guid weightContainerID, Guid transactionID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemContainers_UpdateTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightContainerID", System.Data.DbType.Guid, 16, weightContainerID));
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemContainerDAL", "UpdateTransactionID(Guid weightContainerID, Guid transactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            //if (iError > 0) iError = -1;
            return iError;
        }
        public ListBase<WeightItemContainer> GetByIsReceiveForPeriod(string stockCode, bool isReceive, DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            ListBase<WeightItemContainer> lobj = new ListBase<WeightItemContainer>();
            try
            {
                DbDataReader reader = null;
                //bool found;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemContainer_Select_By_IsReceive_StockCode_For_Period";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, isReceive));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    WeightItemContainer obj = new WeightItemContainer(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemContainerDAL", "GetByIsReceiveForPeriod(string stockCode, bool isReceive, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<WeightItemContainer> GetByContScale(DateTime startDate, DateTime endDate, string employeeID)
        {
            bool alreadyOpen = false;
            ListBase<WeightItemContainer> lobj = new ListBase<WeightItemContainer>();
            try
            {
                DbDataReader reader = null;
                //bool found;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemContainer_Select_By_IsReceive_StockCode_For_Period";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 20, employeeID));
                //cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, isReceive));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                int i = 1;
                while (reader.Read())
                {
                    WeightItemContainer obj = new WeightItemContainer(reader);
                    obj.Stt = i;
                    lobj.Add(obj);

                    i++;
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemContainerDAL", "GetByIsReceiveForPeriod(string stockCode, bool isReceive, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<WeightItemContainer> GetByStockCodeAndIsReceive(Guid transactionID, string transactionTypeCode, string stockCode, bool isReceive)
        {
            bool alreadyOpen = false;
            ListBase<WeightItemContainer> lobj = new ListBase<WeightItemContainer>();
            try
            {
                DbDataReader reader = null;
                //bool found;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemContainer_Select_By_IsReceive_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (transactionID == null)
                {
                    cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                }
                
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, transactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, isReceive));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    WeightItemContainer obj = new WeightItemContainer(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemContainerDAL", "GetByStockCodeAndIsReceive(string stockCode, bool isReceive)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public int MakeNullTransactionID(Guid transactionID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemContainers_Make_Null_TransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemContainerDAL", "MakeNullTransactionID(Guid transactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            //if (iError > 0) iError = -1;
            return iError;
        }
        public override int Insert(WeightItemContainer t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_WeightItemContainer_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@WeightContainerID", System.Data.DbType.Guid, 16, t.WeightContainerID, System.Data.ParameterDirection.Output));
                if (t.CopyFromID != Guid.Empty)
                    Cmd.Parameters.Add(db.CreateParameter("@CopyFromID", System.Data.DbType.Guid, 16, t.CopyFromID));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, t.WeightCode));
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, t.EmployeeID));
                //Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@WeightDate", System.Data.DbType.DateTime, 4, t.WeightDate));
                Cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, t.IsReceive));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@WrappingWeight", System.Data.DbType.Decimal, 9, t.WrappingWeight));
                Cmd.Parameters.Add(db.CreateParameter("@WrappingType", System.Data.DbType.String, 50, t.WrappingType));
                Cmd.Parameters.Add(db.CreateParameter("@ItemWeight", System.Data.DbType.Decimal, 9, t.ItemWeight));
                Cmd.Parameters.Add(db.CreateParameter("@PTVanChuyen", System.Data.DbType.String, 100, t.PTVanChuyen));
                Cmd.Parameters.Add(db.CreateParameter("@PTTrungChuyen", System.Data.DbType.String, 100, t.PTTrungChuyen));
                Cmd.Parameters.Add(db.CreateParameter("@DVVanChuyen", System.Data.DbType.String, 100, t.DVVanChuyen));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, t.TransactionTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@KhoGiaoNhan", System.Data.DbType.String, 10, t.KhoGiaoNhan));
                Cmd.Parameters.Add(db.CreateParameter("@DVGiao", System.Data.DbType.String, 10, t.DVGiao));
                Cmd.Parameters.Add(db.CreateParameter("@DVNhan", System.Data.DbType.String, 10, t.DVNhan));
                Cmd.Parameters.Add(db.CreateParameter("@Weight1", System.Data.DbType.Decimal, 9, t.Weight1));
                Cmd.Parameters.Add(db.CreateParameter("@Weight2", System.Data.DbType.Decimal, 9, t.Weight2));
                Cmd.Parameters.Add(db.CreateParameter("@WeightTime1", System.Data.DbType.DateTime, 8, t.WeightTime1));
                Cmd.Parameters.Add(db.CreateParameter("@WeightTime2", System.Data.DbType.DateTime, 8, t.WeightTime2));
                Cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
                if (t.StockLocationCode2 != string.Empty)
                    Cmd.Parameters.Add(db.CreateParameter("@StockLocationCode2", System.Data.DbType.String, 10, t.StockLocationCode2));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                Cmd.Parameters.Add(db.CreateParameter("@IsAuto", System.Data.DbType.Boolean, 1, t.IsAuto));
                Cmd.Parameters.Add(db.CreateParameter("@PalletWeight", System.Data.DbType.Decimal, 9, t.PalletWeight));
                Cmd.Parameters.Add(db.CreateParameter("@Luot", System.Data.DbType.Int32, 4, t.Luot));

                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.WeightContainerID = (Guid)Cmd.Parameters["@WeightContainerID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemContainerDAL", "Insert(WeightItemContainer t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(WeightItemContainer t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_WeightItemContainer_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@WeightContainerID", System.Data.DbType.Guid, 16, t.WeightContainerID));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, t.WeightCode));
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, t.EmployeeID));
                //Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@WeightDate", System.Data.DbType.DateTime, 4, t.WeightDate));
                Cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, t.IsReceive));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@WrappingWeight", System.Data.DbType.Decimal, 9, t.WrappingWeight));
                Cmd.Parameters.Add(db.CreateParameter("@WrappingType", System.Data.DbType.String, 50, t.WrappingType));
                Cmd.Parameters.Add(db.CreateParameter("@ItemWeight", System.Data.DbType.Decimal, 9, t.ItemWeight));
                Cmd.Parameters.Add(db.CreateParameter("@PTVanChuyen", System.Data.DbType.String, 100, t.PTVanChuyen));
                Cmd.Parameters.Add(db.CreateParameter("@PTTrungChuyen", System.Data.DbType.String, 100, t.PTTrungChuyen));
                Cmd.Parameters.Add(db.CreateParameter("@DVVanChuyen", System.Data.DbType.String, 100, t.DVVanChuyen));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, t.TransactionTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@KhoGiaoNhan", System.Data.DbType.String, 10, t.KhoGiaoNhan));
                Cmd.Parameters.Add(db.CreateParameter("@DVGiao", System.Data.DbType.String, 10, t.DVGiao));
                Cmd.Parameters.Add(db.CreateParameter("@DVNhan", System.Data.DbType.String, 10, t.DVNhan));
                Cmd.Parameters.Add(db.CreateParameter("@Weight1", System.Data.DbType.Decimal, 9, t.Weight1));
                Cmd.Parameters.Add(db.CreateParameter("@Weight2", System.Data.DbType.Decimal, 9, t.Weight2));
                Cmd.Parameters.Add(db.CreateParameter("@WeightTime1", System.Data.DbType.DateTime, 8, t.WeightTime1));
                Cmd.Parameters.Add(db.CreateParameter("@WeightTime2", System.Data.DbType.DateTime, 8, t.WeightTime2));
                Cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
                if (t.StockLocationCode2 != string.Empty)
                    Cmd.Parameters.Add(db.CreateParameter("@StockLocationCode2", System.Data.DbType.String, 10, t.StockLocationCode2));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                Cmd.Parameters.Add(db.CreateParameter("@PalletWeight", System.Data.DbType.Decimal, 9, t.PalletWeight));
                Cmd.Parameters.Add(db.CreateParameter("@Luot", System.Data.DbType.Int32, 4, t.Luot));

                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemContainerDAL", "Update(WeightItemContainer t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(WeightItemContainer t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_WeightItemContainer_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@WeightContainerID", System.Data.DbType.Guid, 16, t.WeightContainerID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemContainerDAL", "Delete(WeightItemContainer t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

        public string GetNextNo(string stockCode, DateTime date, string transType)
        {
            bool alreadyOpen = false;
            string TransNo = "";
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemContainers_GetNextNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@Date", System.Data.DbType.DateTime, 8, date));
                cmd.Parameters.Add(db.CreateParameter("@TransType", System.Data.DbType.String, 20, transType));
                TransNo = (string)db.ExecuteScalar(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemContainerDAL", "GetByIsReceiveForPeriod(string stockCode, bool isReceive, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return TransNo;
        }
    }
}
