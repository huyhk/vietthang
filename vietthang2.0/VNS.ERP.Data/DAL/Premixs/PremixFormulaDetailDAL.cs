using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;
namespace VNS.ERP.Data.Premixs
{
    class PremixFormulaDetailDAL:StockBaseDAL<PremixFormulaDetail>
    {
            public PremixFormulaDetailDAL()
        {}
        public PremixFormulaDetailDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_PremixFormulaDetails_Select_All";
        }

        /// <summary>
        /// insert a PremixFormulaDetails object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(PremixFormulaDetail  t)
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
                cmd.CommandText = "usp_PremixFormulaDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, t.PremixCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialCode", System.Data.DbType.String, 50, t.MaterialCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));
               
               
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PremixFormulaDetailDAL", "Insert(PremixFormulaDetails t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a PremixFormulaDetails object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(PremixFormulaDetail  t)
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
                cmd.CommandText = "usp_PremixFormulaDetails_Update";

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, t.PremixCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialCode", System.Data.DbType.String, 50, t.MaterialCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, t.Weight));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PremixFormulaDetailDAL", "Update(PremixFormulaDetails t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a PremixFormulaDetails object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public ListBase<PremixFormulaDetail> GetDetail(string _FormulaCode, string _PremixCode)
        {
            bool alreadyOpen = false;
            ListBase<PremixFormulaDetail> lobj = new ListBase<PremixFormulaDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PremixFormulaDetails_Select_Detail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, _PremixCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    PremixFormulaDetail obj = new PremixFormulaDetail(reader);
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
        public override int Delete(PremixFormulaDetail t)
        {
            return Delete(t.FormulaCode,t.PremixCode);

        }
        /// <summary>
        /// Delete a Nhaphang object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(string _FormulaCode, string _PremixCode)
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
                cmd.CommandText = "usp_PremixFormulaDetails_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, _PremixCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PremixFormulaDetailDAL", "Delete(string _FormulaCode, string _PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public PremixFormulaDetail GetByFormulaCode(string _FormulaCode)
        {
            bool alreadyOpen = false;
            PremixFormulaDetail obj = new PremixFormulaDetail();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PremixFormulaDetails_Select_FormulaCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj.FromDataReader(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PremixFormulaDAL", "GetByFormulaCode(string _PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        public ListBase<PremixFormulaDetail> GetMaterialCodeMixPremix(string _FormulaCode, string _PremixCode, decimal _Weight)
        {
            bool alreadyOpen = false;
            ListBase<PremixFormulaDetail> lObj = new ListBase<PremixFormulaDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PremixFormulaDetails_Select_MaterialCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, _PremixCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, _Weight));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    PremixFormulaDetail obj = new PremixFormulaDetail(reader);
                    lObj.Add(obj);
                }
                reader.Close();
                
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PremixFormulaDetailDAL", "GetMaterialCodeMixPremix(string _FormulaCode, string _PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lObj;
        }
        public DataTable GetMaterialCode(string _FormulaCode, string _PremixCode, decimal _Weight)
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
                cmd.CommandText = "usp_PremixFormulaDetails_Select_MaterialCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, _PremixCode));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal, 9, _Weight));

                reader = db.ExecuteTable(cmd);

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
            return reader;
        }
        public DataTable GetFormulaCode(string _PremixCode,Boolean isActive)
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
                cmd.CommandText = "usp_PremixFormulaDetails_Select_GetFormulaCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, _PremixCode));
                cmd.Parameters.Add(db.CreateParameter("@IsActive", System.Data.DbType.Boolean, 1, isActive));

                reader = db.ExecuteTable(cmd);

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
            return reader;
        }

        public ListBase<PremixFormulaDetail> GetLast(string pCode, DateTime pDate)
        {
            bool alreadyOpen = false;
            ListBase<PremixFormulaDetail> lobj = new ListBase<PremixFormulaDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PremixFormula_GetLast";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PCode", System.Data.DbType.String, 20, pCode));
                cmd.Parameters.Add(db.CreateParameter("@pDate", System.Data.DbType.DateTime, 8, pDate));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    PremixFormulaDetail obj = new PremixFormulaDetail(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetLast(string _FormulaCode, string _PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
    }
}
