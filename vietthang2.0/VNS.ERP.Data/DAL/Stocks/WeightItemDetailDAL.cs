using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class WeightItemDetailDAL:StockBaseDAL<WeightItemDetail>
    {
        public WeightItemDetailDAL() { }
        public WeightItemDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_WeightItemDetails_Select_All";
            //base.SetValues();
        }

        //public ListBase<WeightItemDetail> GetBySCodeAndWCode(string _sCode, string _wCode)
        //{
        //    ListBase<WeightItemDetail> lobj = new ListBase<WeightItemDetail>();
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        DbDataReader reader = null;
        //         if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_WeightItemDetails_Select_By_SCode_And_WCode";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _sCode));
        //        cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, _wCode));
        //        reader = db.ExecuteReader(cmd);
        //        while (reader.Read())
        //        {
        //            WeightItemDetail obj = new WeightItemDetail(reader);
        //            lobj.Add(obj);
        //        }
        //    }
        //    catch (Exception excp)
        //    {
        //        Write2Log.WriteLogs("WeightItemDetailDAL", "GetBySCodeAndWCode(string _sCode, string _wCode)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return lobj;
        //}
        public ListBase<WeightItemDetail> GetByWeightID(Guid _WeightID)
        {
            ListBase<WeightItemDetail> lobj = new ListBase<WeightItemDetail>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemDetails_Select_By_WeightID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, _WeightID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    WeightItemDetail obj = new WeightItemDetail(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("WeightItemDetailDAL", "GetByWeightID(Guid _WeightID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public override int Insert(WeightItemDetail t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, t.WeightID));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransportCode", System.Data.DbType.String, 10, t.StockTransportCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Int32, 4, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemDetailDAL", "Insert(WeightItemDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        //public override int Update(WeightItemDetail t)
        //{
        //    int iError = 0;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_WeightItemDetails_Update";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, t.WeightCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockTransportCode", System.Data.DbType.String, 10, t.StockTransportCode));
        //        cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));
        //        cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Int32, 4, t.Quantity));
        //        cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
        //        iError = db.ExecuteNonQuery(cmd);
        //        iError = (int)cmd.Parameters["@iError"].Value;
        //    }
        //    catch (Exception excp)
        //    {
        //       iError = -1000;
        //       Write2Log.WriteLogs("WeightItemDetailDAL", "Update(WeightItemDetail t)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return iError;
        //    //return base.Update(t);
        //}
        //public int DeleteBySCodeAndWCode(string _SCode, string _WCode)
        //{
        //    int iError = 0;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_WeightItemDetails_Delete_By_SCode_And_WCode";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, _WCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _SCode));
        //        cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
        //        iError = db.ExecuteNonQuery(cmd);
        //        iError = (int)cmd.Parameters["@iError"].Value;
        //    }
        //    catch (Exception excp)
        //    {
        //        iError = -1000;
        //        Write2Log.WriteLogs("WeightItemDetailDAL", "DeleteBySCodeAndWCode(string _SCode, string WeightCode)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    if (iError > 0) iError = -1;
        //    return iError;
        //}
        public int DeleteByWeightID(Guid _WeightID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_WeightItemDetails_Delete_By_WeightID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, _WeightID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("WeightItemDetailDAL", "DeleteByWeightID(Guid _WeightID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            if (iError > 0) iError = -1;
            return iError;
        }
        //public override int Delete(WeightItemDetail t)
        //{
        //    int iError = 0;
        //    bool alreadyOpen = false;
        //      try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_WeightItemDetails_Delete";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, t.WeightCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockTransportCode", System.Data.DbType.String, 10, t.StockTransportCode));
        //        cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
        //        iError = db.ExecuteNonQuery(cmd);
        //        iError = (int)cmd.Parameters["@iError"].Value;
        //    }
        //    catch (Exception excp)
        //    {
        //        iError = -1000;
        //        Write2Log.WriteLogs("WeightItemDetailDAL", "Delete(WeightItemDetail t)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return iError;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_WeightItemDetails_Delete";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 20, t.WeightCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockTransportCode", System.Data.DbType.String, 10, t.StockTransportCode));
        //        cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
        //        iError = db.ExecuteNonQuery(cmd);
        //        iError = (int)cmd.Parameters["@iError"].Value;
        //    }
        //    catch (Exception excp)
        //    {
        //        iError = -1000;
        //        Write2Log.WriteLogs("WeightItemDetailDAL", "Delete(WeightItemDetail t)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return iError;
        //    //return base.Delete(t);
        //}
    }
}
