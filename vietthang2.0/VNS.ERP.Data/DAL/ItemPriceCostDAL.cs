using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data
{
    class ItemPriceCostDAL : StockBaseDAL<ItemPriceCost>
    {
     public ItemPriceCostDAL()
        {}
        public ItemPriceCostDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_ItemPriceCosts_Select_All";
        }
        /// <summary>
        /// insert a ItemPriceCost object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(ItemPriceCost t)
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
                cmd.CommandText = "usp_ItemPriceCosts_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@PriceCost", System.Data.DbType.Decimal, 9, t.PriceCost));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@AmountCost", System.Data.DbType.Decimal, 9, t.AmountCost));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemPriceCostDAL", "Insert(ItemPriceCost t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a ItemPriceCost object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(ItemPriceCost t)
        {
           
            return 0;
        }

        public override int Delete(ItemPriceCost t)
        {
            return Delete(t.PeriodCode);
        }
      
        
        /// <summary>
        /// Delete a ItemPriceCost  object by the ID
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
                cmd.CommandText = "usp_ItemPriceCosts_Delete_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, preiodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemPriceCostDAL", "Delete(string priodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

            
        /// <summary>
        /// Get ListBase Objects From DataBase by PeriodCode.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public ListBase<ItemPriceCost> GetListItemPriceCostByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<ItemPriceCost> lstReturn = new ListBase<ItemPriceCost>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemPriceCosts_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ItemPriceCost obj = new ItemPriceCost(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemPriceCostDAL", "GetListItemPriceCostByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }

        public DataTable GetListItemProductByPeriodCode(string periodCode, DateTime startDate, DateTime endDate)
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
                cmd.CommandText = "usp_ItemProduct_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemPriceCostDAL", " GetListItemProductByPeriodCode(string periodCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        public int DeleteGiathanhNew(string periodCode)
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
                cmd.CommandText = "usp_GiathanhNew_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemPriceCostDAL", "DeleteGiathanhNew(string priodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int InsertGiathanhNew(string periodCode, string accountCode, string itemCode, decimal amount)
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
                cmd.CommandText = "usp_GiathanhNew_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, itemCode));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, amount));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemPriceCostDAL", "InsertGiathanhNew(ItemPriceCost t)", excp.Message);
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

