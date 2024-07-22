using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.Premixs
{
    public class MixPremixTransactionDAL : StockBaseDAL<MixPremixTransaction>
    {
        public MixPremixTransactionDAL() { }
        public MixPremixTransactionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_MixPremixTransactions_Select_All";
        }
        public override int Update(MixPremixTransaction t)
        {
            return 0;
        }
        public override int Insert(MixPremixTransaction t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) 
                    db.Open();
                else 
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MixPremixTransactions_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixID", System.Data.DbType.Guid, 16, t.MixPremixID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.Int32, 4, t.TransactionType));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
             }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixTransactionDAL", " Insert(MixPremixTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) 
                    db.Close();
            }
            return iError;
        }
        public int Delete(Guid _MixPremixID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MixPremixTransactions_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixID", System.Data.DbType.Guid, 16, _MixPremixID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixTransactionDAL", "Delete(Guid _MixPremixID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
    }

}
