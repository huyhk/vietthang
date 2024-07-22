using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data
{
    public class VesselExchangeContractDAL : BaseDAL<VesselExchangeContract>
    {
        public VesselExchangeContractDAL() { }
        public VesselExchangeContractDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_VesselExchangeContract_Select_All";
        }
        private ListBase<VesselExchangeContract> GetFromDataSet(DataSet ds)
        {
            ListBase<VesselExchangeContract> lstReturn = new ListBase<VesselExchangeContract>();

            DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["ContractID"], ds.Tables[1].Columns["ContractID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                VesselExchangeContract t = new VesselExchangeContract();
                t.LoadFromDataRow(dr);
                foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                {
                    VesselExchangeContractItem tDetail = new VesselExchangeContractItem();
                    tDetail.LoadFromDataRow(dr1);
                    t.Detail.Add(tDetail);
                }
                lstReturn.Add(t);
            }
            return lstReturn;
        }
        public ListBase<VesselExchangeContract> GetByDate(DateTime fromDate,DateTime toDate)
        {
            DataSet ds = null;
            ListBase<VesselExchangeContract> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VesselExchangeContract_Select_ByDate";
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VesselExchangeContractDAL", "GetByDate(DateTime fromDate,DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(VesselExchangeContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselExchangeContract_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                Cmd.Parameters.Add(db.CreateParameter("@ExchangeSubjectCode", System.Data.DbType.String, 10, t.ExchangeSubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@VesselTransactionNo", System.Data.DbType.String, 20, t.VesselTransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@NangsuatbocdoSalan", System.Data.DbType.Decimal, 9, t.NangsuatbocdoSalan));
                Cmd.Parameters.Add(db.CreateParameter("@GiaphatluuSalan", System.Data.DbType.Decimal, 9, t.GiaphatluuSalan));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ContractID = (Guid)Cmd.Parameters["@ContractID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselExchangeContractDAL", "Insert(VesselExchangeContract t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(VesselExchangeContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselExchangeContract_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                Cmd.Parameters.Add(db.CreateParameter("@ExchangeSubjectCode", System.Data.DbType.String, 10, t.ExchangeSubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@VesselTransactionNo", System.Data.DbType.String, 20, t.VesselTransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@NangsuatbocdoSalan", System.Data.DbType.Decimal, 9, t.NangsuatbocdoSalan));
                Cmd.Parameters.Add(db.CreateParameter("@GiaphatluuSalan", System.Data.DbType.Decimal, 9, t.GiaphatluuSalan));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselExchangeContractDAL", "Update(VesselExchangeContract t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(VesselExchangeContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselExchangeContract_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselExchangeContractDAL", "Delete(VesselExchangeContract t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

        public DataTable GetSearch(string exchangeSubjectCode)
        {
            DataTable dt = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VesselExchangeContracts_Search";
                cmd.Parameters.Add(db.CreateParameter("@ExchangeSubjectCode", System.Data.DbType.String, 10, exchangeSubjectCode));

                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VesselExchangeContractDAL", "GetSearch()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return dt;
        }
    }
}
