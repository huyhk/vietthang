using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureTransactionDAL : StockBaseDAL<ManufactureTransaction>
    {
        public ManufactureTransactionDAL() { }
        public ManufactureTransactionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ManufactureTransactions_Select_All";
        }
        public override int Update(ManufactureTransaction t)
        {
            return 0;
        }
        public override int Insert(ManufactureTransaction t)
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
                cmd.CommandText = "usp_ManufactureTransactions_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, t.ManufactureID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.Int32, 4, t.TransactionType));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                if (t.PCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@PCode", System.Data.DbType.String, 50, t.PCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
             }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureTansactionDAL", " Insert(ManufactureTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) 
                    db.Close();
            }
            return iError;
        }
        public int Delete(Guid _ManufactureID)
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
                cmd.CommandText = "usp_ManufactureTransactions_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, _ManufactureID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureTransactionDAL", "Delete(Guid _ManufactureID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int Delete(Guid manufactureID,int transactionType)
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
                cmd.CommandText = "usp_ManufactureTransactions_Delete_Type";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, manufactureID));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.Int32, 4, transactionType));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureTransactionDAL", "(Guid manufactureID,int transactionType)", excp.Message);
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
