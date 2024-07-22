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
    public class VesselTransactionDAL : BaseDAL<VesselTransaction>
    {
        public VesselTransactionDAL() { }
        public VesselTransactionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_VesselTransaction_Select_All";
        }
        public ListBase<VesselTransaction> GetFromDataSet(DataSet ds)
        {
            ListBase<VesselTransaction> lstReturn = new ListBase<VesselTransaction>();

            DataRelation drDetailInvoice = ds.Relations.Add("DetailInvoice", ds.Tables[0].Columns["TransactionID"], ds.Tables[1].Columns["TransactionID"]);
            DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[1].Columns["InvoiceID"], ds.Tables[2].Columns["InvoiceID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                VesselTransaction vt = new VesselTransaction();
                vt.LoadFromDataRow(dr);
                foreach (DataRow dr1 in dr.GetChildRows(drDetailInvoice))
                {
                    VesselTransactionInvoice vti = new VesselTransactionInvoice();
                    vti.LoadFromDataRow(dr1);
                    foreach (DataRow dr2 in dr1.GetChildRows(drDetail))
                    {
                        VesselTransactionInvoiceDetail vtid = new VesselTransactionInvoiceDetail();
                        vtid.LoadFromDataRow(dr2);
                        vti.Detail.Add(vtid);
                    }
                    vt.DetailInvoice.Add(vti);
                }
                lstReturn.Add(vt);
            }
            return lstReturn;
        }
        public ListBase<VesselTransaction> GetForPeriod(DateTime startDate, DateTime endDate)
        {
            DataSet ds = null;
            ListBase<VesselTransaction> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VesselTransaction_Select_For_Period";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VesselTransactionDAL", "GetForPeriod(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(VesselTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselTransaction_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.String, 20, t.TransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 8, t.TransactionDate));
                Cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.String, 10, t.VesselCode));
                Cmd.Parameters.Add(db.CreateParameter("@VendorCode", System.Data.DbType.String, 10, t.VendorCode));
                Cmd.Parameters.Add(db.CreateParameter("@StartPlace", System.Data.DbType.String, 50, t.StartPlace));
                Cmd.Parameters.Add(db.CreateParameter("@EndPlace", System.Data.DbType.String, 50, t.EndPlace));
                Cmd.Parameters.Add(db.CreateParameter("@EstimateDate", System.Data.DbType.DateTime, 8, t.EstimateDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.TransactionID = (Guid)Cmd.Parameters["@TransactionID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselTransactionDAL", "Insert(VesselTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(VesselTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselTransaction_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.String, 20, t.TransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 8, t.TransactionDate));
                Cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.String, 10, t.VesselCode));
                Cmd.Parameters.Add(db.CreateParameter("@VendorCode", System.Data.DbType.String, 10, t.VendorCode));
                Cmd.Parameters.Add(db.CreateParameter("@StartPlace", System.Data.DbType.String, 50, t.StartPlace));
                Cmd.Parameters.Add(db.CreateParameter("@EndPlace", System.Data.DbType.String, 50, t.EndPlace));
                Cmd.Parameters.Add(db.CreateParameter("@EstimateDate", System.Data.DbType.DateTime, 8, t.EstimateDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselTransactionDAL", "Update(VesselTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(VesselTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselTransaction_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselTransactionDAL", "Delete(VesselTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

        public DataTable GetSearch()
        {
            DataTable dt = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VesselTransactions_Search";
                //cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                //cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VesselTransactionDAL", "GetSearch()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return dt;
        }
    }
}
