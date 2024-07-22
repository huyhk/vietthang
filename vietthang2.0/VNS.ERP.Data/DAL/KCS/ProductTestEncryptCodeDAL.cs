using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestEncryptCodeDAL : BaseDAL<ProductTestEncryptCode>
    {
        public ProductTestEncryptCodeDAL() { }
        public ProductTestEncryptCodeDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductTestEncryptCode_Select_All";
            _spSelectDynamic = "usp_ProductTestEncryptCode_Select_Dynamic";
        }
        public int Update(ProductTestEncryptCode t, string oldItemEncryptCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestEncryptCode_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@ManuDate", System.Data.DbType.DateTime, 8, t.ManuDate));
                Cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Byte, 1, t.Shift));
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
                Cmd.Parameters.Add(db.CreateParameter("@OldItemEncryptCode", System.Data.DbType.String, 50, oldItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@NewItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestEncryptCodeDAL", "Update(ProductTestEncryptCode t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public DataSet GetByManuDate(DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            DataSet ds = null;
            //T obj = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductTestEncryptCode_Select_By_ManuDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductTestEncryptCodeDAL", "GetByManuDate(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public override int Insert(ProductTestEncryptCode t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestEncryptCode_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@ManuDate", System.Data.DbType.DateTime, 8, t.ManuDate));
                Cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Byte, 1, t.Shift));
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
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestEncryptCodeDAL", "Insert(ProductTestEncryptCode t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ProductTestEncryptCode t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestEncryptCode_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@ManuDate", System.Data.DbType.DateTime, 8, t.ManuDate));
                Cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Byte, 1, t.Shift));
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
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestEncryptCodeDAL", "Update(ProductTestEncryptCode t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ProductTestEncryptCode t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestEncryptCode_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestEncryptCodeDAL", "Delete(ProductTestEncryptCode t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int DeleteByItemEncryptCode(string itemEncryptCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestEncryptCode_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, itemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestEncryptCodeDAL", "Delete(ProductTestEncryptCode t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
