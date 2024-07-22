using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using VNS.Common;
using VNS.Utils;
using VNS.Data.DAL;


namespace VNS.ERP.Data
{
    class ProductSizeDAL:StockBaseDAL<ProductSize>
    {
        public ProductSizeDAL(){}
        public ProductSizeDAL(DBHelper dbhelper) : base(dbhelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductSizes_Select_All";
            base.SetValues();
        }
        public override int Insert(ProductSize t)
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
                cmd.CommandText = "usp_ProductSizes_Insert";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", DbType.String, 10, t.SizeCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
              
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                rowEffect = db.ExecuteNonQuery(cmd);
                iError =(int)cmd.Parameters["@iError"].Value;


            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductDAL", "Insert(ProductSizes t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
           // return base.Insert(t);
        }
        public override int Delete(ProductSize t)
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
                cmd.CommandText = "usp_ProductSizes_Delete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", DbType.String, 10, t.SizeCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                rowEffect = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductDAL", "Delete(ProductSizes t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Delete(t);
        }
        public override int Update(ProductSize t)
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
                cmd.CommandText = "usp_ProductSizes_Update";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", DbType.String, 10, t.SizeCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", DbType.String, 100, t.Description));
     
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                rowEffect = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductDAL", "Update(ProductSizes t)", ex.Message);
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
