using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using VNS.Common;
using VNS.Utils;
using VNS.Data.DAL;
using System.Data.Common;

namespace VNS.ERP.Data
{
     class ProductDAL:StockBaseDAL<Product>
    {
        public ProductDAL() { }
        public ProductDAL(DBHelper dbhelper):base(dbhelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_Products_Select_All";
            //base.SetValues();
        }
        public override int Insert(Product t)
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
                cmd.CommandText = "usp_Products_Insert";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@ProductName", DbType.String, 50, t.ProductName));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, t.ProductType));
              
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                rowEffect = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductDAL", "Insert(Products t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public override int Delete(Product t)
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
                cmd.CommandText = "usp_Products_Delete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                rowEffect = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductDAL", "Delete(Products t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Delete(t);
        }
        public override int Update(Product t)
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
                cmd.CommandText = "usp_Products_Update";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@ProductName", DbType.String, 50, t.ProductName));
       
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, t.ProductType));

                rowEffect = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductDAL", "Update(Products t)", ex.Message);
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
