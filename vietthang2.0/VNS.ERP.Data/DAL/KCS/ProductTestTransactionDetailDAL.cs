using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestTransactionDetailDAL : BaseDAL<ProductTestTransactionDetail>
    {
        public ProductTestTransactionDetailDAL() { }
        public ProductTestTransactionDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductTestTransactionDetail_Select_All";
        }
        public override int Insert(ProductTestTransactionDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransactionDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 16, t.TestTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                Cmd.Parameters.Add(db.CreateParameter("@SizeCode", System.Data.DbType.String, 10, t.SizeCode));
                if (t.FormulaCode == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));        
                }
                
                Cmd.Parameters.Add(db.CreateParameter("@Lot", System.Data.DbType.String, 20, t.Lot));
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@NgayCodeBao", System.Data.DbType.DateTime, 8, t.NgayCodeBao));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionDetailDAL", "Insert(ProductTestTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ProductTestTransactionDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransactionDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 16, t.TestTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                Cmd.Parameters.Add(db.CreateParameter("@SizeCode", System.Data.DbType.String, 10, t.SizeCode));
                if (t.FormulaCode == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                }
                Cmd.Parameters.Add(db.CreateParameter("@Lot", System.Data.DbType.String, 20, t.Lot));
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionDetailDAL", "Update(ProductTestTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ProductTestTransactionDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransactionDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.String, 20, t.TestTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionDetailDAL", "Delete(ProductTestTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int Delete(Guid testTransactionID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransactionDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 20, testTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionDetailDAL", "Delete(Guid testTransactionID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
