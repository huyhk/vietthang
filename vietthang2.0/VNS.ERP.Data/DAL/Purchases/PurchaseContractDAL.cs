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
    public class PurchaseContractDAL : BaseDAL<PurchaseContract>
    {
        public PurchaseContractDAL() { }
        public PurchaseContractDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_PurchaseContract_Select_All";
            _spSelectDynamic = "usp_PurchaseContract_SelectDynamic";
        }
        private ListBase<PurchaseContract> GetFromDataSet(DataSet ds)
        {
            ListBase<PurchaseContract> lstReturn = new ListBase<PurchaseContract>();

            DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["ContractID"], ds.Tables[1].Columns["ContractID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                PurchaseContract pc = new PurchaseContract();
                pc.LoadFromDataRow(dr);
                foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                {
                    PurchaseContractDetail pcd = new PurchaseContractDetail();
                    pcd.LoadFromDataRow(dr1);
                    pc.Detail.Add(pcd);
                }
                lstReturn.Add(pc);
            }
            return lstReturn;
        }
        public ListBase<PurchaseContract> GetForPeriod(DateTime startDate, DateTime endDate, Boolean isOverSea)
        {
            DataSet ds = null;
            ListBase<PurchaseContract> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchaseContract_Select_For_Period";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@IsOverSea", System.Data.DbType.Boolean, 1, isOverSea));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseContractDAL", "GetForPeriod(DateTime startDate, DateTime endDate, Boolean isOverSea)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public DataTable GetForContractNo(string vendorcode)
        {
            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchaseContracts_forContractNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@VendorCode",System.Data.DbType.String,10,vendorcode));
                reader = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseContractDAL", "GetForContractNo(string vendorcode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable GetByVendor(string vendorcode)
        {
            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchaseContracts_forContractNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@VendorCode", System.Data.DbType.String, 10, vendorcode));
                reader = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseContractDAL", "GetByVendor(string vendorcode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataSet PurchaseTransaction_SelectByContractNo(string contractNo, string subjectCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchaseTransaction_SelectByContractNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, contractNo));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                ds = db.ExecuteDataSet(cmd);

                //DataRelation DtRelation = ds.Relations.Add("PurchaseTransaction",
                //   ds.Tables[0].Columns["ItemCode"],
                //   ds.Tables[1].Columns["ItemCode"]);
                if (ds != null)
                {
                    ds.Tables[0].TableName = "Header";
                    ds.Tables[1].TableName = "Detail";
                    DataRelation dataRelation = new DataRelation("PurchaseTransaction", new DataColumn[] { ds.Tables["Header"].Columns["Khonhap"], ds.Tables["Header"].Columns["ItemCode"] }, new DataColumn[] { ds.Tables["Detail"].Columns["Khonhap"], ds.Tables["Detail"].Columns["ItemCode"] });
                    ds.Relations.Add(dataRelation);
                }


            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("PurchaseContractDAL", "PurchaseTransaction_SelectByContractNo(string contractNo, string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public override int Insert(PurchaseContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchaseContract_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                Cmd.Parameters.Add(db.CreateParameter("@VendorCode", System.Data.DbType.String, 10, t.VendorCode));
                Cmd.Parameters.Add(db.CreateParameter("@IsOverSea", System.Data.DbType.Boolean, 1, t.IsOverSea));
                Cmd.Parameters.Add(db.CreateParameter("@IsTransported", System.Data.DbType.Boolean, 1, t.IsTransported));
                if (t.CurrencyCode == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.String, 3, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.String, 3, t.CurrencyCode));
                }
                
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                Cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                Cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
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
                Write2Log.WriteLogs("PurchaseContractDAL", "Insert(PurchaseContract t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(PurchaseContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchaseContract_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                Cmd.Parameters.Add(db.CreateParameter("@VendorCode", System.Data.DbType.String, 10, t.VendorCode));
                Cmd.Parameters.Add(db.CreateParameter("@IsOverSea", System.Data.DbType.Boolean, 1, t.IsOverSea));
                Cmd.Parameters.Add(db.CreateParameter("@IsTransported", System.Data.DbType.Boolean, 1, t.IsTransported));
                if (t.CurrencyCode == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.String, 3, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.String, 3, t.CurrencyCode));
                }
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                Cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                Cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractDAL", "Update(PurchaseContract t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(PurchaseContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchaseContract_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractDAL", "Delete(PurchaseContract t)", excp.Message);
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
                Cmd.CommandText = "usp_PurchaseContract_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, contractID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseContractDAL", "Delete(Guid contractID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
