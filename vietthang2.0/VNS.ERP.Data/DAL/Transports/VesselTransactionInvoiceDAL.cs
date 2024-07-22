using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data
{
    public class VesselTransactionInvoiceDAL : BaseDAL<VesselTransactionInvoice>
    {
        public VesselTransactionInvoiceDAL() { }
        public VesselTransactionInvoiceDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_VesselTransactionInvoice_Select_All";
        }
        public override int Insert(VesselTransactionInvoice t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselTransactionInvoice_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceID", System.Data.DbType.Guid, 16, DBNull.Value, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, t.InvoiceNo));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 8, t.InvoiceDate));
                Cmd.Parameters.Add(db.CreateParameter("@TotalAmount", System.Data.DbType.Decimal, 9, t.TotalAmount));
                Cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.String, 3, t.CurrencyCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                    t.InvoiceID = (Guid)Cmd.Parameters["@InvoiceID"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselTransactionInvoiceDAL", "Insert(VesselTransactionInvoice t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(VesselTransactionInvoice t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselTransactionInvoice_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceID", System.Data.DbType.Guid, 16, t.InvoiceID));
                Cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, t.InvoiceNo));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 8, t.InvoiceDate));
                Cmd.Parameters.Add(db.CreateParameter("@TotalAmount", System.Data.DbType.Decimal, 9, t.TotalAmount));
                Cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.String, 3, t.CurrencyCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselTransactionInvoiceDAL", "Update(VesselTransactionInvoice t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(VesselTransactionInvoice t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselTransactionInvoice_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselTransactionInvoiceDAL", "Delete(VesselTransactionInvoice t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int Delete(Guid transactionID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_VesselTransactionInvoice_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselTransactionInvoiceDAL", "Delete(Guid transactionID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
