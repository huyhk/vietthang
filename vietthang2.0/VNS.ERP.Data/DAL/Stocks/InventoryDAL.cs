using System;
using System.Collections.Generic;
using System.Text;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;

namespace VNS.ERP.Data
{
    class InventoryDAL:StockBaseDAL<Inventory>
    {
            public InventoryDAL()
        {}
        public InventoryDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_Inventories_Select_All";
        }

        /// <summary>
        /// insert a Inventorys object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(Inventory  t)
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
                cmd.CommandText = "usp_Inventories_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10,t.PeriodCode ));
                if (t.StockLocationCode!=null)
                cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
                else
                cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, DBNull.Value));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
            
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InventoryDAL", "Insert(Inventory t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a Inventories object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(Inventory  t)
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
                cmd.CommandText = "usp_Inventories_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InventoryDAL", "Update(Inventory t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        
        /// <summary>
        /// Delete a Inventories object by the _StockCode
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int DeleteByStockCode(Inventory t)
        {
            return DeleteByStockCode(t);
        }
        public int DeleteByStockCode(string _StockCode,string _PeriodCode)
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
                cmd.CommandText = "usp_Inventories_Delete_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, _PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("InventoryDAL", "DeleteByStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
       
        public ListBase<Inventory > GetByStockCode(string _StockCode,string _PeriodCode)
        {
            bool alreadyOpen = false;
            ListBase<Inventory> lobj = new ListBase<Inventory>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Inventories_Select_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, _PeriodCode));
                
                cmd.Parameters.Add(db.CreateParameter("@iError",System.Data.DbType.Int32,4,0,System.Data.ParameterDirection.Output));
                
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Inventory obj = new Inventory(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VentoryDAL", " GetByStockCode(int _StockCode)", excp.Message);
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
