using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.Grinds
{
    public class GrindMaterialTransactionDAL : StockBaseDAL<GrindMaterialTransactions>
    {
        public GrindMaterialTransactionDAL() { }
        public GrindMaterialTransactionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_GrindMaterialTransactions_Select_All";
        }
        public override int Update(GrindMaterialTransactions t)
        {
            return 0;
        }

        public override int Insert(GrindMaterialTransactions t)
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
                cmd.CommandText = "usp_GrindMaterialTransactions_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialID", System.Data.DbType.Guid, 16, t.GrindMaterialID));
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
                Write2Log.WriteLogs("GrindMaterialTransactionDAL", " Insert(GrindMaterialTransactions t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) 
                    db.Close();
            }
            return iError;
        }
        public int Delete(Guid _GrindMaterialID)
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
                cmd.CommandText = "usp_GrindMaterialTransactions_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialID", System.Data.DbType.Guid, 16, _GrindMaterialID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialTransactionDAL", "Delete(Guid _GrindMaterialID)", excp.Message);
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
