using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    class CustomerPaymentDAL : StockBaseDAL<CustomerPayments>
    {
     public CustomerPaymentDAL()
        {}
        public CustomerPaymentDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_CustomerPayments_Select_All";
         
        }

        /// <summary>
        /// insert a CustomerPayments object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(CustomerPayments t)
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
                cmd.CommandText = "usp_CustomerPayments_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                if (t.StockCode == null)
                {cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, DBNull.Value));}
                else {cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));}
                cmd.Parameters.Add(db.CreateParameter("@PaymentNo", System.Data.DbType.String, 20, t.PaymentNo));
                cmd.Parameters.Add(db.CreateParameter("@PaymentDate", System.Data.DbType.DateTime, 4, t.PaymentDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@PaymentType", System.Data.DbType.Int32, 4, t.PaymentType));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@PaymentID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.PaymentID = (Guid)cmd.Parameters["@PaymentID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerPaymentDAL", "Insert(CustomerPayments t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a CustomerPayments object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(CustomerPayments t)
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
                cmd.CommandText = "usp_CustomerPayments_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PaymentID", System.Data.DbType.Guid, 16,t.PaymentID));
                cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                if (t.StockCode == null)
                { cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, DBNull.Value)); }
                else { cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode)); }
                cmd.Parameters.Add(db.CreateParameter("@PaymentNo", System.Data.DbType.String, 20, t.PaymentNo));
                cmd.Parameters.Add(db.CreateParameter("@PaymentDate", System.Data.DbType.DateTime, 4, t.PaymentDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@PaymentType", System.Data.DbType.Int32, 4, t.PaymentType));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerPaymentDAL", "Update(CustomerPayments t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a CustomerPayments object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(CustomerPayments t)
        {
            return Delete(t.PaymentID);
        }
        /// <summary>
        /// Delete a CustomerPayments  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_PaymentID"></param>
        /// <returns></returns>
        public int Delete(Guid _PaymentID)
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
                cmd.CommandText = "usp_CustomerPayments_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PaymentID", System.Data.DbType.Guid, 16, _PaymentID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerPaymentDAL", "Delete(Guid _PaymentID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Table payment of Customer.
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <returns></returns>
        public DataTable CustomerPaymentReports(DateTime tungay, DateTime denngay, string productType)
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
                cmd.CommandText = "usp_CustomerPayments_Reports";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@tungay", System.Data.DbType.DateTime, 4, tungay));
                cmd.Parameters.Add(db.CreateParameter("@denngay", System.Data.DbType.DateTime, 4, denngay));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerPaymentDAL", " CustomerPaymentReports(DateTime tungay,DateTime denngay)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }

        public ListBase<CustomerPayments> GetObjectByTime(DateTime startDate, DateTime endDate, string branchCode, string productType)
        {
            bool alreadyOpen = false;
            ListBase<CustomerPayments> lstReturn = new ListBase<CustomerPayments>();
            DbDataReader reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_CustomerPayments_Select_ByTime";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, branchCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerPayments pay = new CustomerPayments(reader);
                    lstReturn.Add(pay);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerPaymentDAL", "GetObjectByTime(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        public CustomerPayments GetTopBySuffixCustomerPaymentNo(string suffix)
        {

            DbDataReader reader = null;
            bool alreadyOpen = false;
            CustomerPayments obj = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CustomerPayments_Get_Top_By_SuffixSaleNo";
                cmd.Parameters.Add(db.CreateParameter("@Suffix", System.Data.DbType.String, 20, suffix));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new CustomerPayments(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerPaymentDAL", "GetTopBySuffixCustomerPaymentNo(string suffix)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        public CustomerPayments GetTopBySuffixCustomerPaymentNo5(string suffix)
        {

            DbDataReader reader = null;
            bool alreadyOpen = false;
            CustomerPayments obj = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CustomerPayments_Get_Top_By_SuffixSaleNo5";
                cmd.Parameters.Add(db.CreateParameter("@Suffix", System.Data.DbType.String, 20, suffix));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new CustomerPayments(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerPaymentDAL", "GetTopBySuffixCustomerPaymentNo(string suffix)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
    }
}
