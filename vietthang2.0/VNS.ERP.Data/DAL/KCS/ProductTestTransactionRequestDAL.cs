using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestTransactionRequestDAL : BaseDAL<ProductTestTransactionRequest>
    {
        public ProductTestTransactionRequestDAL() { }
        public ProductTestTransactionRequestDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductTestTransactionRequest_Select_All";
        }
        public override int Insert(ProductTestTransactionRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransactionRequest_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionRequestDAL", "Insert(ProductTestTransactionRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ProductTestTransactionRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransactionRequest_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionRequestDAL", "Update(ProductTestTransactionRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ProductTestTransactionRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransactionRequest_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionRequestDAL", "Delete(ProductTestTransactionRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
