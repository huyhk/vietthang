using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    class SaleRequestDAL : StockBaseDAL<SaleRequests>
    {
     public SaleRequestDAL()
        {}
        public SaleRequestDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_SaleRequests_Select_All";
        }
        public SaleRequests GetItemMaxInvoiceNo(string invoiceSeri)
        {
            bool alreadyOpen = false;
            SaleRequests sr = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequest_Select_Item_MaxInvoiceNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@InvoiceSeri", System.Data.DbType.String, 50, invoiceSeri));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    sr = new SaleRequests(reader);
                }
                //if (reader.NextResult() && sr != null)
                //{
                //    sr.Details = new ListBase<SaleRequestDetails>();
                //    while (reader.Read())
                //    {
                //        SaleRequestDetails srd = new SaleRequestDetails(reader);
                //        sr.Details.Add(srd);
                //    }
                //}
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SaleRequestDAL", "GetBySaleRequestNo(string saleRequestNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return sr;
        }
        public SaleRequests GetBySaleRequestNo(string saleRequestNo)
        {
            bool alreadyOpen = false;
            SaleRequests sr = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequests_Select_By_SaleRequestNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestNo", System.Data.DbType.String, 20, saleRequestNo));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    sr = new SaleRequests(reader);
                }
                if (reader.NextResult() && sr != null)
                {
                    sr.Details = new ListBase<SaleRequestDetails>();
                    while (reader.Read())
                    {
                        SaleRequestDetails srd = new SaleRequestDetails(reader);
                        sr.Details.Add(srd);
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SaleRequestDAL", "GetBySaleRequestNo(string saleRequestNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return sr;
        }
        public SaleRequests GetByCurrentInvoiceSeri()
        {
            bool alreadyOpen = false;
            SaleRequests sr = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequests_Select_By_CurrentInvoiceSeri";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    sr = new SaleRequests(reader);
                }
                //if (reader.NextResult() && sr != null)
                //{
                //    sr.Details = new ListBase<SaleRequestDetails>();
                //    while (reader.Read())
                //    {
                //        SaleRequestDetails srd = new SaleRequestDetails(reader);
                //        sr.Details.Add(srd);
                //    }
                //}
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SaleRequestDAL", "GetBySaleRequestNo(string saleRequestNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return sr;
        }

        /// <summary>
        /// insert a SaleRequests object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(SaleRequests t)
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
                cmd.CommandText = "usp_SaleRequests_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderNo", System.Data.DbType.String, 20, t.CustomerOrderNo));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                if (t.StockInCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, t.StockInCode));
                if (t.CustomerCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                if (t.TransportCode == "")
                {
                    cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, t.TransportCode));
                }
                //cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, t.TransportCode));
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestNo", System.Data.DbType.String, 20, t.SaleRequestNo));
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestDate", System.Data.DbType.DateTime, 4, t.SaleRequestDate));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 20, t.PTVC));
                if (t.DueDate == DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@DueDate", System.Data.DbType.DateTime, 4, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@DueDate", System.Data.DbType.DateTime, 4, t.DueDate));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceDiscount", System.Data.DbType.Decimal, 9, t.InvoiceDiscount));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceAmount", System.Data.DbType.Decimal, 9, t.InvoiceAmount));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, t.InvoiceNo));
                cmd.Parameters.Add(db.CreateParameter("@BeforeTaxAmount", System.Data.DbType.Decimal, 9, t.BeforeTaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@TaxAmount", System.Data.DbType.Decimal, 9, t.TaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate", System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@DateLimit", System.Data.DbType.Boolean, 1, t.DateLimit));
                cmd.Parameters.Add(db.CreateParameter("@DiscountDescription", System.Data.DbType.String, 50, t.DiscountDescription));
                cmd.Parameters.Add(db.CreateParameter("@DiscountAmount", System.Data.DbType.Decimal, 9, t.DiscountAmount));
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@Nguoigiaonhan", System.Data.DbType.String, 50, t.NguoiGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@PaymentType", System.Data.DbType.String, 50, t.PaymentType));
                cmd.Parameters.Add(db.CreateParameter("@Giamgia", System.Data.DbType.Boolean, 1, t.Giamgia));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceCustomerName", System.Data.DbType.String, 100, t.InvoiceCustomerName));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                if (t.DiscountID!=Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DiscountID", System.Data.DbType.Guid, 16, t.DiscountID));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.SaleRequestID = (Guid)cmd.Parameters["@SaleRequestID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestDAL", "Insert(SaleRequests t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a SaleRequests object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(SaleRequests t)
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
                cmd.CommandText = "usp_SaleRequests_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SaleRequestID", System.Data.DbType.Guid, 16,t.SaleRequestID));
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderNo", System.Data.DbType.String, 20, t.CustomerOrderNo));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                if (t.StockInCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, t.StockInCode));
                if (t.CustomerCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                if (t.TransportCode == "")
                {
                    cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, t.TransportCode));
                }
                //cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, t.TransportCode));
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestNo", System.Data.DbType.String, 20, t.SaleRequestNo));
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestDate", System.Data.DbType.DateTime, 4, t.SaleRequestDate));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 20, t.PTVC));
                if(t.DueDate==DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@DueDate", System.Data.DbType.DateTime, 4, DBNull.Value));
                else
                   cmd.Parameters.Add(db.CreateParameter("@DueDate", System.Data.DbType.DateTime, 4, t.DueDate));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceDiscount", System.Data.DbType.Decimal, 9, t.InvoiceDiscount));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceAmount", System.Data.DbType.Decimal, 9, t.InvoiceAmount));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, t.InvoiceNo));
                cmd.Parameters.Add(db.CreateParameter("@BeforeTaxAmount", System.Data.DbType.Decimal, 9, t.BeforeTaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@TaxAmount", System.Data.DbType.Decimal, 9, t.TaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate", System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@DateLimit", System.Data.DbType.Boolean, 1, t.DateLimit));
                cmd.Parameters.Add(db.CreateParameter("@DiscountDescription", System.Data.DbType.String, 50, t.DiscountDescription));
                cmd.Parameters.Add(db.CreateParameter("@DiscountAmount", System.Data.DbType.Decimal, 9, t.DiscountAmount));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@Nguoigiaonhan", System.Data.DbType.String, 50, t.NguoiGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@PaymentType", System.Data.DbType.String, 50, t.PaymentType));
                cmd.Parameters.Add(db.CreateParameter("@Giamgia", System.Data.DbType.Boolean, 1, t.Giamgia));
                if (t.InvoiceDate == DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 4, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 1, t.InvoiceDate));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceMau", System.Data.DbType.String, 50, t.InvoiceMau));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceSeri", System.Data.DbType.String, 50, t.InvoiceSeri));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceCustomerName", System.Data.DbType.String, 100, t.InvoiceCustomerName));
                cmd.Parameters.Add(db.CreateParameter("@InvoicePersonName", System.Data.DbType.String, 100, t.InvoicePersonName));
                cmd.Parameters.Add(db.CreateParameter("@CheckIsFinished", System.Data.DbType.Boolean, 1, 1));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                if (t.DiscountID != Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DiscountID", System.Data.DbType.Guid, 16, t.DiscountID));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestDAL", "Update(SaleRequests t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int UpdateFromOrtherBLLs(SaleRequests t)
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
                cmd.CommandText = "usp_SaleRequests_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SaleRequestID", System.Data.DbType.Guid, 16, t.SaleRequestID));
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderNo", System.Data.DbType.String, 20, t.CustomerOrderNo));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                if (t.StockInCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@StockInCode", System.Data.DbType.String, 10, t.StockInCode));
                if (t.CustomerCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                if (t.TransportCode == "")
                {
                    cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, t.TransportCode));
                }
                //cmd.Parameters.Add(db.CreateParameter("@TransportCode", System.Data.DbType.String, 10, t.TransportCode));
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestNo", System.Data.DbType.String, 20, t.SaleRequestNo));
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestDate", System.Data.DbType.DateTime, 4, t.SaleRequestDate));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 20, t.PTVC));
                if (t.DueDate == DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@DueDate", System.Data.DbType.DateTime, 4, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@DueDate", System.Data.DbType.DateTime, 4, t.DueDate));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceDiscount", System.Data.DbType.Decimal, 9, t.InvoiceDiscount));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceAmount", System.Data.DbType.Decimal, 9, t.InvoiceAmount));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, t.InvoiceNo));
                cmd.Parameters.Add(db.CreateParameter("@BeforeTaxAmount", System.Data.DbType.Decimal, 9, t.BeforeTaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@TaxAmount", System.Data.DbType.Decimal, 9, t.TaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate", System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@DateLimit", System.Data.DbType.Boolean, 1, t.DateLimit));
                cmd.Parameters.Add(db.CreateParameter("@DiscountDescription", System.Data.DbType.String, 50, t.DiscountDescription));
                cmd.Parameters.Add(db.CreateParameter("@DiscountAmount", System.Data.DbType.Decimal, 9, t.DiscountAmount));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@Nguoigiaonhan", System.Data.DbType.String, 50, t.NguoiGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@PaymentType", System.Data.DbType.String, 50, t.PaymentType));
                cmd.Parameters.Add(db.CreateParameter("@Giamgia", System.Data.DbType.Boolean, 1, t.Giamgia));
                if (t.InvoiceDate == DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 4, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 4, t.InvoiceDate));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceMau", System.Data.DbType.String, 50, t.InvoiceMau));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceSeri", System.Data.DbType.String, 50, t.InvoiceSeri));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceCustomerName", System.Data.DbType.String, 100, t.InvoiceCustomerName));
                cmd.Parameters.Add(db.CreateParameter("@InvoicePersonName", System.Data.DbType.String, 100, t.InvoicePersonName));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                if (t.DiscountID != Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DiscountID", System.Data.DbType.Guid, 16, t.DiscountID));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestDAL", "Update(SaleRequests t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a SaleRequests object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(SaleRequests t)
        {
            return Delete(t.SaleRequestID);
        }
        /// <summary>
        /// Delete a SaleRequests  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_SaleRequestID"></param>
        /// <returns></returns>
        public int Delete(Guid _SaleRequestID)
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
                cmd.CommandText = "usp_SaleRequests_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestID", System.Data.DbType.Guid, 16, _SaleRequestID));
                cmd.Parameters.Add(db.CreateParameter("@CheckIsFinished", System.Data.DbType.Boolean, 1, 1));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestDAL", "Delete(Guid _SaleRequestID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Get All  SaleRequests  object by the StockCode
        /// </summary>
        /// <param name="_StockCode"></param>
        /// <returns></returns>
        public ListBase<SaleRequests> GetAllSaleRequestByStockCode(string _StockCode)
        {
            bool alreadyOpen = false;
            ListBase<SaleRequests> lobj = new ListBase<SaleRequests>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequests_Select_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    SaleRequests obj = new SaleRequests(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("SaleRequestDAL", " GetSaleRequestByStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        public ListBase<SaleRequests> GetObjectByTimeStockCode(DateTime startDate, DateTime endDate, string stockCode, string productType)
        {
            bool alreadyOpen = false;
            ListBase<SaleRequests> lobj = new ListBase<SaleRequests>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequests_Select_ByTimeStockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    SaleRequests obj = new SaleRequests(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("SaleRequestDAL", "GetObjectByTimeStockCode(DateTime startDate,DateTime endDate,string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        
        /// <summary>
        /// Get SaleRequests  object by the StockCode where by IsFinished = 0
        /// </summary>
        /// <param name="_StockCode"></param>
        /// <returns></returns>
        public ListBase<SaleRequests> GetSaleRequestByStockCode(string _StockCode)
        {
            bool alreadyOpen = false;
            ListBase<SaleRequests> lobj = new ListBase<SaleRequests>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequests_Select_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@All", System.Data.DbType.Boolean, 1, true));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    SaleRequests obj = new SaleRequests(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("SaleRequestDAL", " GetSaleRequestByStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        /// <summary>
        /// Truyền vào 1 formSearch để chọn Số đơn hàng cho StockTransaction
        /// </summary>
        /// <param name="_StockCode"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public DataTable GetForSTCheck(string _StockCode,DateTime d, string currentSoDH)
        {
            bool alreadyOpen = false;
            DataTable dt = null;
            try
            {
             
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequests_Select_For_ST_Check";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@d", System.Data.DbType.DateTime, 4, d));
                cmd.Parameters.Add(db.CreateParameter("@CurrentSoDH", System.Data.DbType.String, 20, currentSoDH));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SaleRequestDAL", "GetForSTCheck(string _StockCode,DateTime d, string currentSoDH)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        /// <summary>
        /// Get Table Sale Detail ItemCode 
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <returns></returns>
        public DataTable ReportsSaleRequestsForItems(DateTime tungay, DateTime denngay, string productType)
        {
            bool alreadyOpen = false;
            DataTable dt = null;
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequests_Reports_Items";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@tungay", System.Data.DbType.DateTime, 4, tungay));
                cmd.Parameters.Add(db.CreateParameter("@denngay", System.Data.DbType.DateTime, 4, denngay));
                //cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, true));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SaleRequestDAL", "ReportsSaleRequestsForItems(DateTime tungay, DateTime denngay)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        
        public SaleRequests GetTopBySuffixSaleRequestNo(string suffix)
        {
           
            DbDataReader reader = null;
            bool alreadyOpen = false;
            SaleRequests obj = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_SaleRequests_Get_Top_By_SuffixSaleNo";
                cmd.Parameters.Add(db.CreateParameter("@Suffix", System.Data.DbType.String, 20, suffix));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new SaleRequests(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SaleRequestDAL", "GetTopBySuffixSaleRequestNo(string suffix)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }

        public ListBase<SaleRequests> GetByBranchCode(DateTime startDate, DateTime endDate, string branchCode)
        {
            bool alreadyOpen = false;
            ListBase<SaleRequests> lobj = new ListBase<SaleRequests>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequest_GetInvoice";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, branchCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    SaleRequests obj = new SaleRequests(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("SaleRequestDAL", "GetByBranchCode(DateTime startDate, DateTime endDate, string branchCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        public int UpdateDiscountID(Guid SaleRequestID, Guid DiscountID)
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
                cmd.CommandText = "usp_SaleRequests_Update_DiscountID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SaleRequestID", System.Data.DbType.Guid, 16, SaleRequestID));
                
                if (DiscountID != Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DiscountID", System.Data.DbType.Guid, 16, DiscountID));

                iError = db.ExecuteNonQuery(cmd);
                //iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestDAL", "Update(SaleRequests t)", excp.Message);
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
