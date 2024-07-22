using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    class CustomerOrderDetailDAL : StockBaseDAL<CustomerOrderDetails>
    {
        public CustomerOrderDetailDAL()
        {}
        public CustomerOrderDetailDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_CustomerOrderDetails_Select_All";
        }

        /// <summary>
        /// insert a CustomerOrderDetails object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(CustomerOrderDetails t)
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
                cmd.CommandText = "usp_CustomerOrderDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderID", System.Data.DbType.Guid, 16, t.CustomerOrderID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@DeliverDate", System.Data.DbType.DateTime, 4, t.DeliverDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@QuantityOut", System.Data.DbType.Decimal, 9, t.QuantityOut));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerOrderDetalDAL", "Insert(CustomerOrderDetails t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
       
        /// <summary>
        /// delete a CustomerOrderDetails object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(CustomerOrderDetails t)
        {
            return Delete(t.CustomerOrderID);
        }
        /// <summary>
        /// Delete a CustomerOrderDetails  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
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
                cmd.CommandText = "usp_CustomerOrderDetails_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderID", System.Data.DbType.Guid, 16, _CustomerOrderID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerOrderDetalDAL", "Delete(Guid _CustomerOrderID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Get object CustomerOrderDetail by ID
        /// </summary>
        /// <param name="_CustomerOrderID"></param>
        /// <returns></returns>
        public ListBase<CustomerOrderDetails> GetCustomerOrderDetailByID(Guid _CustomerOrderID)
        {
            bool alreadyOpen = false;
            ListBase<CustomerOrderDetails> lobj = new ListBase<CustomerOrderDetails>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_CustomerOrderDetails_Select_CustomerOrderID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderID", System.Data.DbType.Guid, 16, _CustomerOrderID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerOrderDetails obj = new CustomerOrderDetails(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("CustomerOrderDetalDAL", "GetCustomerOrderDetailByID(Guid _CustomerOrderID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        /// <summary>
        /// Get ItemCode by CustomerOrderNo
        /// </summary>
        /// <param name="_CustomerOrderID"></param>
        /// <returns></returns>
        public ListBase<Item>GetCustomerOrderDetailByCustomerOrderNo(string customerOrderNo)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_CustomerOrderDetails_Select_ByCustomerOrderNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderNo", System.Data.DbType.String, 20, customerOrderNo));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("CustomerOrderDetalDAL", "GetCustomerOrderDetailByCustomerOrderNo(string customerOrderNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
      /// <summary>
      /// Select CustomerOrderDetails by DeliverDate and StockCode.  
      /// </summary>
      /// <param name="deliverDate"></param>
      /// <param name="stockCode"></param>
      /// <returns></returns>
        public DataTable GetCustomerOrderDetailByDeliver_StockCode(DateTime deliverDate, string stockCode)
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
                cmd.CommandText = "usp_CustomerOrderDetails_Select_By_DeliverDate_And_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@DeliverDate", System.Data.DbType.DateTime, 4, deliverDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("CustomerOrderDetalDAL", "GetCustomerOrderDetailByDeliver_StockCode(DateTime deliverDate, string stockCode)", excp.Message);
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
