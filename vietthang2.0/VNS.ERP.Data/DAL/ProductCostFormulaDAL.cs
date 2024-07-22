using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data
{
    class ProductCostFormulaDAL : StockBaseDAL<ProductCostFormula>
    {
     public ProductCostFormulaDAL()
        {}
        public ProductCostFormulaDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        public void UpdateCostPrice(string periodCode)
        {
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductCostFormulas_Update_CostPrice";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                db.ExecuteNonQuery(Cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductCostFormulaDAL", "public void UpdateCostPrice(string periodCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
        }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductCostFormulas_Select_All";
        }
        /// <summary>
        /// insert a ProductCostFormula object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(ProductCostFormula t)
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
                cmd.CommandText = "usp_ProductCostFormulas_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialCode", System.Data.DbType.String, 50, t.MaterialCode));
                cmd.Parameters.Add(db.CreateParameter("@WrappingCode", System.Data.DbType.String, 50, t.WrappingCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@CostPrice", System.Data.DbType.Decimal, 9, t.CostPrice));
                cmd.Parameters.Add(db.CreateParameter("@CostAmount", System.Data.DbType.Decimal, 9, t.CostAmount));
                cmd.Parameters.Add(db.CreateParameter("@STT", System.Data.DbType.Int32, 4, t.STT));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductCostFormulaDAL", "Insert(ProductCostFormula t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a ProductCostFormula object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(ProductCostFormula t)
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
                cmd.CommandText = "usp_ProductCostFormulas_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialCode", System.Data.DbType.String, 50, t.MaterialCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@CostPrice", System.Data.DbType.Decimal, 9, t.CostPrice));
                cmd.Parameters.Add(db.CreateParameter("@CostAmount", System.Data.DbType.Decimal, 9, t.CostAmount));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductCostFormulaDAL", "Update(ProductCostFormula t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public override int Delete(ProductCostFormula t)
        {
            return Delete(t.PeriodCode);
        }
              
         /// <summary>
         /// Delete a ProductCostFormula  object by the ID
         /// Return: 0:successful
         /// </summary>
         /// <param name="preiodCode"></param>
         /// <param name="productCode"></param>
         /// <returns></returns>
        public int Delete(string preiodCode, string productCode, string wrappingCode)
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
                cmd.CommandText = "usp_ProductCostFormulas_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, preiodCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, productCode));
                cmd.Parameters.Add(db.CreateParameter("@WrappingCode", System.Data.DbType.String, 10, wrappingCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductCostFormulaDAL", "Delete(string priodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Delete a ProductCostFormula  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="preiodCode"></param>
        /// <returns></returns>
        public int Delete(string preiodCode)
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
                cmd.CommandText = "usp_ProductCostFormulas_Delete_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, preiodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductCostFormulaDAL", "Delete(string priodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Get ListBase Objects From DataBase by PeriodCode.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public ListBase<ProductCostFormula> GetListProductCostFormulaByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<ProductCostFormula> lstReturn = new ListBase<ProductCostFormula>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductCostFormulas_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ProductCostFormula obj = new ProductCostFormula(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductCostFormulaDAL", "GetListProductCostFormulaByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        /// <summary>
        /// Copy Objects From DataBase by PeriodCodeLast.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public int CopyProductCostFormulaByPeriodCodeLast(string periodCode, string periodCodeLast)
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
                cmd.CommandText = "usp_ProductCostFormulas_Copy_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@PeriodCodeLast", System.Data.DbType.String, 10, periodCodeLast));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductCostFormulaDAL", "CopyProductCostFormulaByPeriodCodeLast(string periodCode, string periodCodeLast)", excp.Message);
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

