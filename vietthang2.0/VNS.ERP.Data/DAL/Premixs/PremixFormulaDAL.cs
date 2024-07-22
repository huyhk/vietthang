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
    class PremixFormulaDAL:StockBaseDAL<PremixFormula>
    {
           public PremixFormulaDAL()
        {}
        public PremixFormulaDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_PremixFormulas_Select_All";
        }

        /// <summary>
        /// insert a PremixFormulas object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(PremixFormula  t)
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
                cmd.CommandText = "usp_PremixFormulas_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@IsActive", System.Data.DbType.Boolean, 1, t.IsActive));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PremixFormulaDAL", "Insert(PremixFormulas t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a PremixFormulas object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(PremixFormula  t)
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
                cmd.CommandText = "usp_PremixFormulas_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@IsActive", System.Data.DbType.Boolean, 1, t.IsActive));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PremixFormulaDAL", "Update(PremixFormulas t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a PremixFormulas object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(PremixFormula  t)
        {
            return Delete(t.FormulaCode );
            
        }
        /// <summary>
        /// Delete a Nhaphang object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(string _FormulaCode)
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
                cmd.CommandText = "usp_PremixFormulas_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PremixFormulaDAL", "Delete(int _FormulaCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        
        public ListBase<GeneralPremix> GetAll()
        {
            bool alreadyOpen = false;
            ListBase<GeneralPremix> lobj = new ListBase<GeneralPremix>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PremixFormulas_Select_All";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
               

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    GeneralPremix obj = new GeneralPremix(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PremixFormulaDAL", "GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        public PremixFormula GetFormulaCode(string _FormulaCode)
        {
            bool alreadyOpen = false;
            PremixFormula obj = new PremixFormula();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PremixFormula_Select_FormulaCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj.FromDataReader(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PremixFormulaDAL", "GetFormulaCode(string _FormulaCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }


        
    }
}
