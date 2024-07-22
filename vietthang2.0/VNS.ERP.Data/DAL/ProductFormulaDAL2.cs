using System;
using System.Collections.Generic;
using System.Text;
using VNS.Utils;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class ProductFormulaDAL2 : StockBaseDAL<ProductFormula2>
    {
        public ProductFormulaDAL2() { }
        public ProductFormulaDAL2(DBHelper dbHelper)
            : base(dbHelper)
        {
        }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductFormula_Select_All3";
            //base.SetValues();
        }
        public override int Insert(ProductFormula2 t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormulas_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductFormulaDAL", "Insert(ProductFormulas t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        public override int Update(ProductFormula2 t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormulas_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductFormulaDAL", "Update(ProductFormulas t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Update(t);
        }
        public int Delete(string _FormulaCode)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormulas_Delete_Code";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@UserDelete", System.Data.DbType.String, 20, Contexts.CurrentUser.LoginName));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductFormulaDAL", "Delete(string _FormulaCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ProductFormula2 t)
        {
            return Delete(t.FormulaCode);
            //return base.Delete(t);
        }
        public ListBase<ProductFormula2> GetByProductCode(string productCode)
        {
            bool alreadyOpen = false;
            ListBase<ProductFormula2> lobj = new ListBase<ProductFormula2>();
            // ListBase<FormulaDetail> lFDObj = new ListBase<FormulaDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormula_Select_By_Product_Code";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, productCode));
                reader = db.ExecuteReader(cmd);

                while (reader.Read())
                {
                    ProductFormula2 obj = new ProductFormula2(reader);
                    lobj.Add(obj);
                }

                int count = lobj.Count;
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        FormulaDetail fd = new FormulaDetail(reader);
                        for (int i = 0; i < count; i++)
                        {
                            ProductFormula2 pf2 = lobj[i];
                            if (pf2.FormulaCode == fd.FormulaCode && pf2.ProductCode == fd.ProductCode)
                            {
                                pf2.FormulaDetails.Add(fd);
                                i = count;
                            }
                        }
                    }
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        ProductFormulaUnActive pfu = new ProductFormulaUnActive(reader);
                        for (int i = 0; i < count; i++)
                        {
                            ProductFormula2 pf2 = lobj[i];
                            if (pf2.FormulaCode == pfu.FormulaCode && pf2.ProductCode == pfu.ProductCode)
                            {
                                pf2.IsActive = false;
                                i = count;
                            }
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductFormulaDAL", "ListBase<ProductFormula2> GetByProductCode(string productCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<ProductFormula2> GetFormulaByProductCode(string productCode)
        {
            bool alreadyOpen = false;
            ListBase<ProductFormula2> lobj = new ListBase<ProductFormula2>();
            // ListBase<FormulaDetail> lFDObj = new ListBase<FormulaDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormula_Select_By_Product_Code";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, productCode));
                reader = db.ExecuteReader(cmd);

                while (reader.Read())
                {
                    ProductFormula2 obj = new ProductFormula2(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductFormulaDAL", "ListBase<ProductFormula2> GetFormulaByProductCode(string productCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }

        public DataSet GetAll4()
        {
            bool alreadyOpen = false;
            DataSet ds = null;
            // ListBase<FormulaDetail> lFDObj = new ListBase<FormulaDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormula_Select_All4";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductFormulaDAL", "DataSet GetAll4()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
    }
}
