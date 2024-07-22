using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class InstrumentTransactionDAL : BaseDAL<InstrumentTransaction>
    {
        public InstrumentTransactionDAL() { }
        public InstrumentTransactionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_InstrumentTransaction_Select_All";
        }
        public ListBase<InstrumentTransactionDetail> GetDetail(Guid InstrTransID)
        {
            ListBase<InstrumentTransactionDetail> lobj = new ListBase<InstrumentTransactionDetail>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_InstrumentTransactionDetail_Select_By_InstrumentTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@InstrumentTransactionID", System.Data.DbType.Guid, 20, InstrTransID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    InstrumentTransactionDetail obj = new InstrumentTransactionDetail(reader);
                    lobj.Add(obj);
                }

                if (reader.NextResult())
                {
                    Guid instrumentTransactionDetailID = Guid.NewGuid();
                    BaseClass b = new BaseClass();
                    while (reader.Read())
                    {
                        if (!b.isNull("InstrumentTransactionDetailID", reader)) instrumentTransactionDetailID = reader.GetGuid(reader.GetOrdinal("InstrumentTransactionDetailID"));
                        PrePaidExpense obj1 = new PrePaidExpense(reader);
                        foreach (InstrumentTransactionDetail instrTransDetail in lobj)
                        {
                            if (instrTransDetail.TransactionDetailID == instrumentTransactionDetailID)
                            {
                                instrTransDetail.LstPrePaidExpense.Clear();
                                instrTransDetail.LstPrePaidExpense.Add(obj1);
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("InstrumentTransactionAccountDAL", "GetByTransactionType(string transType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public InstrumentTransaction GetByAccTransID(Guid accTransID)
        {
            InstrumentTransaction obj = null;
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_InstrumentTransaction_Select_By_AccountTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 20, accTransID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new InstrumentTransaction(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("InstrumentTransactionDAL", "GetByAccTransID(Guid accTransID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        public override int Insert(InstrumentTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_InstrumentTransaction_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.String, 20, t.TransactionType));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.String, 20, t.TransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 4, t.TransactionDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
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
                Write2Log.WriteLogs("InstrumentTransactionDAL", "Insert(InstrumentTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(InstrumentTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_InstrumentTransaction_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.String, 20, t.TransactionType));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.String, 20, t.TransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 4, t.TransactionDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InstrumentTransactionDAL", "Update(InstrumentTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(InstrumentTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_InstrumentTransaction_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InstrumentTransactionDAL", "Delete(InstrumentTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
