using System;
using System.Collections.Generic;
using System.Text;

using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data
{
    class PremixWrappingDAL:StockBaseDAL<PremixWrapping>
    {
          public PremixWrappingDAL()
        {}
        public PremixWrappingDAL(DBHelper dbHelper)
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
        public override int Insert(PremixWrapping t)
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
                cmd.CommandText = "usp_PremixWrappings_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, t.PremixCode));
              
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PremixWrappingDAL", "Insert(PremixWrapping t)", excp.Message);
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
        public override int Update(PremixWrapping t)
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
                cmd.CommandText = "usp_PremixWrappings_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, t.PremixCode));


                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PremixWrappingDAL", "Update(PremixWrapping t)", excp.Message);
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
        public ListBase<PremixWrapping> GetAll(int _Itemtype)
        {
            bool alreadyOpen = false;
            ListBase<PremixWrapping> lobj = new ListBase<PremixWrapping>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PremixWrapping_Select_Itemtype";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, _Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    PremixWrapping obj = new PremixWrapping(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PremixWrappingDAL", "GetAll(int _Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public string GetItemCode(string _PremixCode)
        {
            bool alreadyOpen = false;
            string ItemCode = null;
            try
            {
                object obj = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PremixWrappings_Select_ItemCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, _PremixCode));
                obj = db.ExecuteScalar(cmd);
                if (obj != null) ItemCode = obj.ToString();
                
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PremixWrappingDAL", "GetItemCode(string _PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ItemCode;
        }
      
    }
}
