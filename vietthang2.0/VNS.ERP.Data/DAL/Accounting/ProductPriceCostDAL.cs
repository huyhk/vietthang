using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Accounting
{
    class ProductPriceCostDAL : StockBaseDAL<ProductPriceCost>
    {
     public ProductPriceCostDAL()
        {}
        public ProductPriceCostDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductPriceCosts_Select_All";
        }
        /// <summary>
        /// insert a ProductPriceCost object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(ProductPriceCost t)
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
                cmd.CommandText = "usp_ProductPriceCosts_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@WrappingCode", System.Data.DbType.String, 10, t.WrappingCode));
                cmd.Parameters.Add(db.CreateParameter("@PriceCost", System.Data.DbType.Decimal, 9, t.PriceCost));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductPriceCostDAL", "Insert(ProductPriceCost t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a ProductPriceCost object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(ProductPriceCost t)
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
                cmd.CommandText = "usp_ProductPriceCosts_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@PriceCost", System.Data.DbType.Decimal, 9, t.PriceCost));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductPriceCostDAL", "Update(ProductPriceCost t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public override int Delete(ProductPriceCost t)
        {
            return Delete(t.PeriodCode);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        public void UpdateInStockCostPriceProduct(string periodCode)
        {
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStocks_Update_InStock_CostPrice_Product";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                db.ExecuteNonQuery(Cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductPriceCostDAL", "UpdateInStockCostPriceProduct(string periodCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
        }  
        
        /// <summary>
        /// Delete a ProductPriceCost  object by the ID
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
                cmd.CommandText = "usp_ProductPriceCosts_Delete_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, preiodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductPriceCostDAL", "Delete(string priodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Lấy chi tiết thành phẩm để tính giá thành theo Period.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable GetDetaiProductByPeriodCode(string periodCode, DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            DataTable dt = new DataTable();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductCostFormulas_Select_ProductCode_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductPriceCostAmountDAL", "GetDetaiProductByPeriodCode(string periodCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        public DataSet GiathanhNew(string periodCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GiathanhNew";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductPriceCostAmountDAL", "GiathanhNew(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        /// <summary>
        /// Get ListBase Objects From DataBase by PeriodCode.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public ListBase<ProductPriceCost> GetListProductPriceCostByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<ProductPriceCost> lstReturn = new ListBase<ProductPriceCost>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductPriceCosts_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ProductPriceCost obj = new ProductPriceCost(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductPriceCostDAL", "GetListProductPriceCostByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }

        /// <summary>
        /// Lấy chi tiết ProductSizeCode để tính giá thành theo Period.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable GetDetaiProductSizeCodeByPeriodCode(string periodCode, DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            DataTable dt = new DataTable();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductCostFormulas_Select_SizeCode_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductPriceCostAmountDAL", "GetDetaiProductSizeCodeByPeriodCode(string periodCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        ///// <summary>
        ///// Copy Objects From DataBase by PeriodCodeLast.
        ///// </summary>
        ///// <param name="periodCode"></param>
        ///// <returns></returns>
        //public int CopyProductCostFormulaByPeriodCodeLast(string periodCode, string periodCodeLast)
        //{
        //    int iError = 0;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open)
        //            db.Open();
        //        else
        //            alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_ProductCostFormulas_Copy_By_PeriodCode";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
        //        cmd.Parameters.Add(db.CreateParameter("@PeriodCodeLast", System.Data.DbType.String, 10, periodCodeLast));
        //        cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
        //        iError = db.ExecuteNonQuery(cmd);
        //        iError = (int)cmd.Parameters["@iError"].Value;
        //    }
        //    catch (Exception excp)
        //    {
        //        iError = -1000;
        //        Write2Log.WriteLogs("ProductCostFormulaDAL", "CopyProductCostFormulaByPeriodCodeLast(string periodCode, string periodCodeLast)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen)
        //            db.Close();
        //    }
        //    return iError;
        //}
    }
}

