using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;
namespace VNS.ERP.Data.Grinds
{
    class MaterialFormulaDAL:StockBaseDAL<MaterialFormular>
    {
            public MaterialFormulaDAL()
        {}
        public MaterialFormulaDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_MaterialFormulars_Select_All";
        }

        /// <summary>
        /// insert a MaterialFormulars object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(MaterialFormular  t)
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
                cmd.CommandText = "usp_MaterialFormulars_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
               
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialFormularDAL", "Insert(MaterialFormulars t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a MaterialFormulars object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(MaterialFormular  t)
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
                cmd.CommandText = "usp_MaterialFormulars_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialFormularDAL", "Update(MaterialFormulars t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a MaterialFormulars object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(MaterialFormular  t)
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
                cmd.CommandText = "usp_MaterialFormulars_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, _FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialFormularDAL", "Delete(int _FormulaCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public ListBase<GeneralMaterial> GetAll()
        {
            bool alreadyOpen = false;
            ListBase<GeneralMaterial> lobj = new ListBase<GeneralMaterial>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialFormulars_Select_All";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    GeneralMaterial obj = new GeneralMaterial(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialFormulaDAL", "GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }


        public MaterialFormular GetFormulaCode(string _FormulaCode)
        {
            bool alreadyOpen = false;
            MaterialFormular obj = new MaterialFormular();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MaterialFormulars_Select_FormulaCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, _FormulaCode));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj.FromDataReader(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialFormularDAL", "GetFormulaCode(string _FormulaCode)", excp.Message);
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
