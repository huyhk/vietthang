using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;

namespace VNS.ERP.Data
{
    class MaterialFormularDetailDAL:StockBaseDAL<MaterialFormularDetail>
    {
        
            public MaterialFormularDetailDAL()
        {}
        public MaterialFormularDetailDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_MaterialFormularDetails_Select_All";
        }

        /// <summary>
        /// insert a MaterialFormularDetails object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(MaterialFormularDetail  t)
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
                cmd.CommandText = "usp_MaterialFormularDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialPCode", System.Data.DbType.String, 50, t.MaterialPCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialCode", System.Data.DbType.String, 50, t.MaterialCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));
               
               
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialFormularDetailDAL", "Insert(MaterialFormularDetails t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a MaterialFormularDetails object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(MaterialFormularDetail  t)
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
                cmd.CommandText = "usp_MaterialFormularDetails_Update";

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialPCode", System.Data.DbType.String, 50, t.MaterialPCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialCode", System.Data.DbType.String, 50, t.MaterialCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialFormularDetailDAL", "Update(MaterialFormularDetails t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a MaterialFormularDetails object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public ListBase<MaterialFormularDetail> GetDetail(string _FormulaCode, string _MaterialPCode)
        {
            bool alreadyOpen = false;
            ListBase<MaterialFormularDetail> lobj = new ListBase<MaterialFormularDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialFormularDetails_Select_Detail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialPCode", System.Data.DbType.String, 50, _MaterialPCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    MaterialFormularDetail obj = new MaterialFormularDetail(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetDetail(string _FormulaCode, string _PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public override int Delete(MaterialFormularDetail t)
        {
            return Delete(t.FormulaCode,t.MaterialPCode);

        }
        /// <summary>
        /// Delete a Nhaphang object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(string _FormulaCode, string _MaterialPCode)
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
                cmd.CommandText = "usp_MaterialFormularDetails_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialPCode", System.Data.DbType.String, 50, _MaterialPCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialFormularDetailDAL", "Delete(string _FormulaCode, string _PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public MaterialFormularDetail GetByFormulaCode(string _FormulaCode)
        {
            bool alreadyOpen = false;
            MaterialFormularDetail obj = new MaterialFormularDetail();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialFormularDetails_Select_FormulaCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, _FormulaCode));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj.FromDataReader(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialFormularDetailDAL", "GetFormulaCode(string _FormulaCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        public DataTable GetMaterialCode(string _FormulaCode, string _MaterialPCode, decimal _Weight)
        {
            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialFormulaDetails_Select_MaterialCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialPCode", System.Data.DbType.String, 50, _MaterialPCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, _Weight));

                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialFormularDetailDAL", "GetMaterialPCode(string _FormulaCode, string _MaterialCode, decimal _Weight)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }

        public ListBase<MaterialFormularDetail> GetMaterialCodeGrindMaterial(string _MaterialPCode, string _FormulaCode, decimal _Weight)
        {
            bool alreadyOpen = false;
            ListBase<MaterialFormularDetail> lObj = new ListBase<MaterialFormularDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialFormulaDetails_Select_MaterialCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MaterialPCode", System.Data.DbType.String, 50, _MaterialPCode));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, _Weight));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    MaterialFormularDetail obj = new MaterialFormularDetail(reader);
                    lObj.Add(obj);
                }
                reader.Close();

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialFormularDetailDAL", "GetMaterialPCode(string _FormulaCode, string _MaterialCode, decimal _Weight)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lObj;
        }
        public DataTable GetFormularCode(string _MaterialCode)
        {
            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialFormulas_Select_ByMaterialPCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MaterialPCode", System.Data.DbType.String, 50, _MaterialCode));

                reader = db.ExecuteTable(cmd);
                
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialFormularDAL", "GetFormular(string _MaterialCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
    }
}
