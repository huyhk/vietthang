using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Utils;
using VNS.Data.DAL;

namespace VNS.ERP.Data
{
    class ProductWeightDAL:StockBaseDAL<ProductWeight>
    {
        public ProductWeightDAL() { }
        public ProductWeightDAL(DBHelper dbhelper) : base(dbhelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductWeights_Select_All";
            base.SetValues();
        }
        public override int Insert(ProductWeight t)
        {
            int iError = 0;
            int rowEffect = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductWeights_Insert";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", DbType.String, 10, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Weight", DbType.String, 100, t.Weight));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
               
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                rowEffect = db.ExecuteNonQuery(cmd);

            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductWeightDAL", "Insert(ProductWeights t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        public override int Delete(ProductWeight t)
        {
            int iError = 0;
            int rowEffect = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductWeights_Delete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", DbType.String, 10, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                rowEffect = db.ExecuteNonQuery(cmd);

            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductWeightDAL", "Delete(ProductWeights t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Delete(t);
        }
        public override int Update(ProductWeight t)
        {
            int iError = 0;
            int rowEffect = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductWeights_Update";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", DbType.String, 10, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Weight", DbType.Decimal, 9, t.Weight));
           
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                rowEffect = db.ExecuteNonQuery(cmd);
                iError=(int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductWeightDAL", "Update(ProductWeights t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Update(t);
        }
    }
}
