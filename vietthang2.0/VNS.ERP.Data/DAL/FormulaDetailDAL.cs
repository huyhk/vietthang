using System;
using System.Collections.Generic;
using System.Text;

using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class FormulaDetailDAL:StockBaseDAL<FormulaDetail>
    {
        public FormulaDetailDAL() { }
        public FormulaDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        DataTable dt;
        protected override void SetValues()
        {
            _spSelectAll = "usp_FormularDetails_Select_All";
            //base.SetValues();
        } 
        public DataTable GetDetailForWeight(string _PCode, string _FCode, decimal _Weight)
        {
            bool alreadyOpen = false;

            try
            {
                //DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_DetailMaterials_Get_By_PCode_And_FCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, _PCode));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, _Weight));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("DetailMaterialDAL", "GetByPCodeAndFCode(string _PCode, string _FCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return dt;
        }

        /// <summary>
        /// Get All FormulaCode in table FormularDetails not in table ProductFormulaUnActive
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllFormulaActive()
        {
            bool alreadyOpen = false;
            DataTable dtReturn = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FormularDetails_Select_Active";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dtReturn = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("DetailMaterialDAL", "GetAllFormulaActive()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return dtReturn;
        }

        public ListBase<FormulaDetail> GetDetailBOM(string _PCode, string _FCode, decimal _Weight)
        {
            bool alreadyOpen = false;
            ListBase<FormulaDetail> lObj = new ListBase<FormulaDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_DetailMaterials_Get_BOM";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, _PCode));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, _Weight));
                reader = db.ExecuteReader(cmd);

                while (reader.Read())
                {
                    FormulaDetail obj = new FormulaDetail(reader);
                    lObj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("DetailMaterialDAL", "GetDetailBOM(string _PCode, string _FCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lObj;
        }
        public override int Insert(FormulaDetail t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FormulaDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialCode", System.Data.DbType.String, 50, t.MaterialCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4,0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("FormularDetailDAL", "Insert(FormularDetails t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        public override int Update(FormulaDetail t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FormularDetails_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormularCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialCode", System.Data.DbType.String, 50, t.MaterialCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("FormularDetailDAL", "Update(FormularDetails t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Update(t);
        }
        public int Delete(string _FormularCode, string _ProductCode)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FormulaDetails_Delete_By_FCode_And_PCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormularCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, _ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4,0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("FormularDetailDAL", "Delete(string _FormularCode, string _ProductCode, string _MaterialCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(FormulaDetail t)
        {
            return this.Delete(t.FormulaCode, t.ProductCode);
            //return base.Delete(t);
        }

        public DataTable GetFormulaCode(string _ProductCode)
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
                cmd.CommandText = "usp_FormulaDetails_Select_Detail_By_ProductCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, _ProductCode));
                dt = db.ExecuteTable(cmd);
              
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("FormularDetailDAL", "GetFormulaCode(string _ProductCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
    }
}
