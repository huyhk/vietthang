using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    class CustomerOrderDAL : StockBaseDAL<CustomerOrders>
    {
     public CustomerOrderDAL()
        {}
        public CustomerOrderDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_CustomerOrders_Select_All";
        }

        /// <summary>
        /// insert a CustomerOrders object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(CustomerOrders t)
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
                cmd.CommandText = "usp_CustomerOrders_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderNo", System.Data.DbType.String, 20, t.CustomerOrderNo));
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderDate", System.Data.DbType.DateTime, 4, t.CustomerOrderDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.CustomerOrderID = (Guid)cmd.Parameters["@CustomerOrderID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerOrderDAL", "Insert(CustomerOrders t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a CustomerOrders object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(CustomerOrders t)
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
                cmd.CommandText = "usp_CustomerOrders_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderID", System.Data.DbType.Guid, 16, t.CustomerOrderID));
                cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderNo", System.Data.DbType.String, 20, t.CustomerOrderNo));
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderDate", System.Data.DbType.DateTime, 4, t.CustomerOrderDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerOrderDAL", "Update(CustomerOrders t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a CustomerOrders object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(CustomerOrders t)
        {
            return Delete(t.CustomerOrderID);
        }
        /// <summary>
        /// Delete a CustomerOrders  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_CustomerOrderID"></param>
        /// <returns></returns>
        public int Delete(Guid _CustomerOrderID)
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
                cmd.CommandText = "usp_CustomerOrders_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderID", System.Data.DbType.Guid, 16, _CustomerOrderID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerOrderDAL", "Delete(Guid _CustomerOrderID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Get All  CustomerOrders  object by the StockCode
        /// </summary>
        /// <param name="_StockCode"></param>
        /// <returns></returns>
        public ListBase<CustomerOrders> GetAllCustomerOrderByStockCode(string _StockCode, string productType)
        {
            bool alreadyOpen = false;
            ListBase<CustomerOrders> lobj = new ListBase<CustomerOrders>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_CustomerOrders_Select_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerOrders obj = new CustomerOrders(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("CustomerOrderDAL", " GetCustomerOrderByStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

          public ListBase<CustomerOrders> GetObjectByTimeStockCode(DateTime startDate,DateTime endDate,string stockCode, string productType)
        {
            bool alreadyOpen = false;
            ListBase<CustomerOrders> lobj = new ListBase<CustomerOrders>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_CustomerOrders_Select_ByTimeStockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerOrders obj = new CustomerOrders(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("CustomerOrderDAL", "GetObjectByTimeStockCode(DateTime startDate,DateTime endDate,string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        
        /// <summary>
        /// Get CustomerOrders  object by the StockCode where by IsFinished = 0
        /// </summary>
        /// <param name="_StockCode"></param>
        /// <returns></returns>
        public ListBase<CustomerOrders> GetCustomerOrderByStockCode(string _StockCode, string productType)
        {
            bool alreadyOpen = false;
            ListBase<CustomerOrders> lobj = new ListBase<CustomerOrders>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_CustomerOrders_Select_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                cmd.Parameters.Add(db.CreateParameter("@All", System.Data.DbType.Boolean, 1, true));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerOrders obj = new CustomerOrders(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("CustomerOrderDAL", " GetCustomerOrderByStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        public DataTable GetSearchCustomerOrderByStockCode(string _StockCode, string productType)
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
                cmd.CommandText = "usp_CustomerOrders_Select_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("CustomerOrderDAL", "GetSearchCustomerOrderByStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        /// <summary>
        /// Get CustomerOrderNo Top.
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        public CustomerOrders GetTopBySuffixCustomerOrderNo(string suffix)
        {
            //bool NotFound = true;
            DbDataReader reader = null;
            bool alreadyOpen = false;
            CustomerOrders obj =null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CustomerOrders_Get_Top_By_SuffixCNo";
                cmd.Parameters.Add(db.CreateParameter("@Suffix", System.Data.DbType.String, 20, suffix));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new CustomerOrders(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerOrderDAL", "GetTopBySuffixCustomerOrderNo(string suffix)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
    }
}
