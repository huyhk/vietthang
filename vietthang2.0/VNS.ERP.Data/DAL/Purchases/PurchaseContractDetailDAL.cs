using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class PurchaseContractDetailDAL : BaseDAL<PurchaseContractDetail>
    {
        public PurchaseContractDetailDAL() { }
        public PurchaseContractDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_PurchaseContractDetail_Select_All";
        }
        public override int Insert(PurchaseContractDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchaseContractDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                Cmd.Parameters.Add(db.CreateParameter("@PriceNT", System.Data.DbType.Decimal, 9, t.PriceNT));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, t.StockCode));
                if (t.VesselCode != "")
                    Cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.AnsiString, 10, t.VesselCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractDetailDAL", "Insert(PurchaseContractDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(PurchaseContractDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchaseContractDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                Cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractDetailDAL", "Update(PurchaseContractDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(PurchaseContractDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchaseContractDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractDetailDAL", "Delete(PurchaseContractDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int Delete(Guid contractID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchaseContractDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, contractID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractDetailDAL", "Delete(Guid contractID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

        public ListBase<PurchaseContractDetail> GetByContractNo(string contractNo)
        {
            ListBase<PurchaseContractDetail> lst = new ListBase<PurchaseContractDetail>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchaseContractDetail_SelectByContractNo";
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, contractNo));

                DbDataReader reader = db.ExecuteReader(cmd);
                while (reader.Read())
                    lst.Add(new PurchaseContractDetail(reader));
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseContractDetailDAL", "GetByContractNo(string contractNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lst;
        }
    }
}
