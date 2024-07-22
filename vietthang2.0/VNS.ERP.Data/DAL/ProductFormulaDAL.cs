using System;
using System.Collections.Generic;
using System.Text;
using VNS.Utils;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class ProductFormulaDAL:StockBaseDAL<ProductFormula>
    {
        public ProductFormulaDAL() { }
        public ProductFormulaDAL(DBHelper dbHelper):base(dbHelper)
        { 
        }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductFormulas_Select_All";
            //base.SetValues();
        }
        public override int Insert(ProductFormula t)
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
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String,20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String,200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32,4, 0, System.Data.ParameterDirection.Output));
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
        public override int Update(ProductFormula t)
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
        public override int Delete(ProductFormula t)
        {
            return Delete(t.FormulaCode);
            //return base.Delete(t);
        }
        public ListBase<ProductFormula> GetAll()
        {
            bool alreadyOpen = false;
            ListBase<ProductFormula> lobj = new ListBase<ProductFormula>();
           // ListBase<FormulaDetail> lFDObj = new ListBase<FormulaDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormulas_Select_All";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                reader = db.ExecuteReader(cmd);
              
                while (reader.Read())
                {
                    ProductFormula obj = new ProductFormula(reader);
                    lobj.Add(obj);
                }
             
               
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        ProductFormulaDetail pfd = new ProductFormulaDetail(reader);
                        ProductFormula pf = lobj.Search("FormulaCode", pfd.FormulaCode);                      
                        
                        if (pf != null)
                        {
                            if (pf.ProductFormulaDetails == null)
                                pf.ProductFormulaDetails = new ListBase<ProductFormulaDetail>();

                            if (pf.ProductFormulaDetails.Count > 0)
                            {
                                if (pf.ProductFormulaDetails.Search("ProductCode", pfd.ProductCode) == null)
                                {
                                    pf.ProductFormulaDetails.Add(pfd);
                                    //lFDObj.Add(fd);
                                }
                            }
                            else
                            {
                                pf.ProductFormulaDetails.Add(pfd);
                            }
                            //FormulaDetail fdsub = pf.FormulaDetails.Search("ProductCode", fd.ProductCode);
                            //if (pf.FormulaDetails.Search("ProductCode", fd.ProductCode) == null)
                            //{
                            //    pf.FormulaDetails.Add(fd);
                            //}
                        }
                    }
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        FormulaDetail fd = new FormulaDetail(reader);
                        ProductFormula pf = lobj.Search("FormulaCode", fd.FormulaCode);
                        ProductFormulaDetail pfd = pf.ProductFormulaDetails.Search("ProductCode", fd.ProductCode);
                        if (pfd != null)
                        {
                            if (pfd.FormulaDetails == null)
                                pfd.FormulaDetails = new ListBase<FormulaDetail>();
                            pfd.FormulaDetails.Add(fd);     
                        }
                    }
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        ProductFormulaUnActive pFUnActive = new ProductFormulaUnActive(reader);
                        ProductFormula pf = lobj.Search("FormulaCode", pFUnActive.FormulaCode);
                        if (pf != null)
                        {
                            ProductFormulaDetail pfd = pf.ProductFormulaDetails.Search("ProductCode", pFUnActive.ProductCode);
                            if (pfd != null)
                            {
                                pfd.IsActive = false;
                            }
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductFormulaDAL", "ListBase<ProductFormula> GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }

        public ListBase<ProductFormula> GetActiveByProductCode(string productCode)
        {
            bool alreadyOpen = false;
            ListBase<ProductFormula> lobj = new ListBase<ProductFormula>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormula_SelectActiveByProductCode";
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 20, productCode));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                reader = db.ExecuteReader(cmd);

                while (reader.Read())
                {
                    lobj.Add(new ProductFormula(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductFormulaDAL", "GetActiveByProductCode(string productCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }

        public ListBase<ProductFormula> GetActiveByItemCode(string itemCode)
        {
            bool alreadyOpen = false;
            ListBase<ProductFormula> lobj = new ListBase<ProductFormula>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ProductFormula_SelectActiveByItemCode";
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, itemCode));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                reader = db.ExecuteReader(cmd);

                while (reader.Read())
                {
                    lobj.Add(new ProductFormula(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductFormulaDAL", "GetActiveByItemCode(string productCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
    }
}
