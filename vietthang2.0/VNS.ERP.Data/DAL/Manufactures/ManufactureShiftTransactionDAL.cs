using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureShiftTransactionDAL : StockBaseDAL<ManufactureShiftTransaction>
    {
        public ManufactureShiftTransactionDAL() { }
        public ManufactureShiftTransactionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ManufactureShiftTransactions_Select_All";
        }
        public override int Update(ManufactureShiftTransaction t)
        {
            return 0;
        }
        public override int Insert(ManufactureShiftTransaction t)
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
                cmd.CommandText = "usp_ManufactureShiftTransactions_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, t.ManufactureShiftID));
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
                Write2Log.WriteLogs("ManufactureShiftTransactionDAL", " Insert(ManufactureShiftTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) 
                    db.Close();
            }
            return iError;
        }
        public int Delete(Guid manufactureShiftID)
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
                cmd.CommandText = "usp_ManufactureShiftTransactions_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, manufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureShiftTransactionDAL", "Delete(Guid _ManufactureID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<ManufactureShiftTransaction> GetObjectByManutransactionShiftID(Guid manuTransactionShiftID)
        {
            bool alreadyOpen = false;
            ListBase<ManufactureShiftTransaction> lobj = new ListBase<ManufactureShiftTransaction>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShiftTransactions_Select_ManufactureShiftID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, manuTransactionShiftID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ManufactureShiftTransaction obj = new ManufactureShiftTransaction(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureShiftTransactionDAL", "GetObjectByManutransactionShiftID()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

    }

}
