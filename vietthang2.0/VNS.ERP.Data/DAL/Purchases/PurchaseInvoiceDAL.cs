using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data
{
    #region PurchaseInvoiceDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of PurchaseInvoice.
    /// </summary>
    public class PurchaseInvoiceDAL : BaseDAL<PurchaseInvoice>
    {
        public PurchaseInvoiceDAL()
        {
        }
        public PurchaseInvoiceDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        public ListBase<PurchaseInvoice> GetByDateAndSubject(DateTime fromDate, DateTime toDate, string subjectCode)
        {
            DataSet ds = null;
            ListBase<PurchaseInvoice> lstReturn = new ListBase<PurchaseInvoice>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchaseInvoice_SelectByDateAndSubject";
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                ds = db.ExecuteDataSet(cmd);

                DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["InvoiceID"], ds.Tables[1].Columns["InvoiceID"]);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PurchaseInvoice pc = new PurchaseInvoice(dr);
                    foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                    {
                        pc.ListPurchaseInvoiceDetail.Add(new PurchaseInvoiceDetail(dr1));
                    }
                    lstReturn.Add(pc);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseInvoiceDAL", "GetByDateAndSubject()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }

        public DataTable GetTransactionNotInvoiced(string subjectCode,Guid invoiceID)
        {
            DataTable dt = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchaseInvoice_GetTransactionNotInvoiced";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceID", System.Data.DbType.Guid, 16, invoiceID));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseInvoiceDAL", "GetTransactionNotInvoiced()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return dt;
        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(PurchaseInvoice t)
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
                cmd.CommandText = "usp_PurchaseInvoice_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@InvoiceID", System.Data.DbType.Guid, 16, t.InvoiceID, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, t.InvoiceNo));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 8, t.InvoiceDate));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceSeri", System.Data.DbType.String, 20, t.InvoiceSeri));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.AnsiString, 3, t.CurrencyCode));
                cmd.Parameters.Add(db.CreateParameter("@GoodAmount", System.Data.DbType.Decimal, 9, t.GoodAmount));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate", System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@TaxAmount", System.Data.DbType.Decimal, 9, t.TaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceAmount", System.Data.DbType.Decimal, 9, t.InvoiceAmount));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));

                cmd.Parameters.Add(db.CreateParameter("@NgayCongno", System.Data.DbType.Int32, 9, t.NgayCongno));
                if (t.Dathanhtoan)
                    cmd.Parameters.Add(db.CreateParameter("@NgayThanhtoan", System.Data.DbType.DateTime, 8, t.NgayThanhtoan));
                cmd.Parameters.Add(db.CreateParameter("@Nganhang", System.Data.DbType.String, 100, t.Nganhang));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.InvoiceID = (Guid)cmd.Parameters["@InvoiceID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseInvoiceDAL", "Insert(PurchaseInvoice t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Updates an existing object in database by calling Update StoredProcedure
        /// </summary>
        public override int Update(PurchaseInvoice t)
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
                cmd.CommandText = "usp_PurchaseInvoice_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@InvoiceID", System.Data.DbType.Guid, 16, t.InvoiceID));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, t.InvoiceNo));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 8, t.InvoiceDate));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceSeri", System.Data.DbType.String, 20, t.InvoiceSeri));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.AnsiString, 3, t.CurrencyCode));
                cmd.Parameters.Add(db.CreateParameter("@GoodAmount", System.Data.DbType.Decimal, 9, t.GoodAmount));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate", System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@TaxAmount", System.Data.DbType.Decimal, 9, t.TaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@InvoiceAmount", System.Data.DbType.Decimal, 9, t.InvoiceAmount));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@NgayCongno", System.Data.DbType.Int32, 9, t.NgayCongno));
                if (t.Dathanhtoan)
                    cmd.Parameters.Add(db.CreateParameter("@NgayThanhtoan", System.Data.DbType.DateTime, 8, t.NgayThanhtoan));
                cmd.Parameters.Add(db.CreateParameter("@Nganhang", System.Data.DbType.String, 100, t.Nganhang));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseInvoiceDAL", "Update(PurchaseInvoice t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>
        public override int Delete(PurchaseInvoice t)
        {

            return this.Delete(t.InvoiceID);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid invoiceID)
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
                cmd.CommandText = "usp_PurchaseInvoice_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@InvoiceID", System.Data.DbType.Guid, 16, invoiceID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseInvoiceDAL", "Delete(PurchaseInvoice t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        #endregion
        #region private methods

        protected override void SetValues()
        {
            _spSelectAll = "usp_PurchaseInvoice_SelectAll";
            _spSelectDynamic = "usp_PurchaseInvoice_SelectDynamic";
            _spDeleteAll = "usp_PurchaseInvoice_DeleteAll";
            _spDeleteDynamic = "usp_PurchaseInvoice_DeleteDynamic";
        }

        #endregion
        #region detail
        public int InsertDetail(PurchaseInvoiceDetail t)
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
                cmd.CommandText = "usp_PurchaseInvoiceDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@InvoiceID", System.Data.DbType.Guid, 16, t.InvoiceID));
                cmd.Parameters.Add(db.CreateParameter("@StockTransactionNo", System.Data.DbType.AnsiString, 20, t.StockTransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@StockTransactionDate", System.Data.DbType.DateTime, 8, t.StockTransactionDate));
                cmd.Parameters.Add(db.CreateParameter("@PurchaseContractNo", System.Data.DbType.AnsiString, 20, t.PurchaseContractNo));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseInvoiceDetailDAL", "InsertDetail(PurchaseInvoiceDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int DeleteDetail(Guid invoiceID)
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
                cmd.CommandText = "usp_PurchaseInvoiceDetail_DeleteByInvoiceID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@InvoiceID", System.Data.DbType.Guid, 16, invoiceID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchaseInvoiceDetailDAL", "DeleteDetail(Guid invoiceID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion
    }
    #endregion
}