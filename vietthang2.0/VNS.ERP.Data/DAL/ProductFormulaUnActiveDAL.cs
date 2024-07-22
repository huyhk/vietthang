using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data
{
    public class ProductFormulaUnActiveDAL : BaseDAL<ProductFormulaUnActive>
    {
        public ProductFormulaUnActiveDAL() { }
        public ProductFormulaUnActiveDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductFormulaUnActive_Select_All";
        }
        public override int Insert(ProductFormulaUnActive t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductFormulaUnActive_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                Cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductFormulaUnActiveDAL", "Insert(ProductFormulaUnActive t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ProductFormulaUnActive t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductFormulaUnActive_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                Cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductFormulaUnActiveDAL", "Update(ProductFormulaUnActive t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ProductFormulaUnActive t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductFormulaUnActive_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                Cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductFormulaUnActiveDAL", "Delete(ProductFormulaUnActive t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
