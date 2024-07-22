using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data
{
    class ProductSizeCostFormulaDAL : StockBaseDAL<ProductSizeCostFormula>
    {
     public ProductSizeCostFormulaDAL()
        {}
        public ProductSizeCostFormulaDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

      
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductSizeCostFormulas_Select_All";
        }
        /// <summary>
        /// insert a ProductSizeCostFormula object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(ProductSizeCostFormula t)
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
                cmd.CommandText = "usp_ProductSizeCostFormulas_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductSizeCode", System.Data.DbType.String, 10, t.ProductSizeCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, t.ProductType));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Quantity2", System.Data.DbType.Decimal, 9, t.Quantity2));
              
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductSizeCostFormulaDAL", "Insert(ProductSizeCostFormula t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
     

        public override int Delete(ProductSizeCostFormula t)
        {
            return Delete(t.PeriodCode);
        }
              
        /// <summary>
        /// Delete a ProductSizeCostFormula  object by the ID
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
                cmd.CommandText = "usp_ProductSizeCostFormulas_Delete_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, preiodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductSizeCostFormulaDAL", "Delete(string priodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public ListBase<ProductSizeCostFormula> GetListBaseObject(string preiodCode)
        {
            bool alreadyOpen = false;
            ListBase<ProductSizeCostFormula> lstReturn = new ListBase<ProductSizeCostFormula>();
            DbDataReader reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductSizeCostFormulas_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, preiodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ProductSizeCostFormula obj = new ProductSizeCostFormula(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
        
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductSizeCostFormulaDAL", "GetListBaseObject(string preiodCode)", excp.Message);
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
        public int CopyProductSizeCostFormulaByPeriodCodeLast(string periodCode, string periodCodeLast)
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
                cmd.CommandText = "usp_ProductSizeCostFormulas_Copy_By_PeriodCode";
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
                Write2Log.WriteLogs("ProductSizeCostFormulaDAL", "CopyProductSizeCostFormulaByPeriodCodeLast(string periodCode, string periodCodeLast)", excp.Message);
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
