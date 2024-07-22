using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;

namespace VNS.ERP.Data
{
    class WeightItemResultDAL : StockBaseDAL<WeightItemResult>
    {
        public WeightItemResultDAL() { }
        public WeightItemResultDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_WeightItemResults_Select_All";
            //base.SetValues();
        }
        public int DeleteByWeightID(Guid _WeightID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemResults_Delete_By_WeightID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, _WeightID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemResultDAL", "DeleteByWeightID(Guid _WeightID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Insert(WeightItemResult t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemResults_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, t.WeightID));
                cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemResultDAL", "Insert(WeightItemResult t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        //public override int Update(WeightItemResult t)
        //{
        //    int iError = 0;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_WeightItemResults_Update";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, t.WeightID));
        //        cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
        //        cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));
        //        cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
        //        iError = db.ExecuteNonQuery(cmd);
        //        iError = (int)cmd.Parameters["@iError"].Value;
        //    }
        //    catch (Exception excp)
        //    {
        //        iError = -1000;
        //        Write2Log.WriteLogs("WeightItemResultDAL", "Update(WeightItemResult t)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return iError;
        //    //return base.Update(t);
        //}
    }
}
