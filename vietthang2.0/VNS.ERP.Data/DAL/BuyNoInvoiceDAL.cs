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

    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of Invoice.
    /// </summary>
    public class BuyNoInvoiceDAL : StockBaseDAL<BuyNoInvoice>
    {

        public BuyNoInvoiceDAL()
        {
        }
        public BuyNoInvoiceDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        protected override void SetValues()
        {
            _spSelectAll = "usp_BuyNoInvoices_SelectAll";

        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(BuyNoInvoice t)
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
                cmd.CommandText = "usp_BuyNoInvoices_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@Ngaymua", System.Data.DbType.DateTime, 4, t.Ngaymua));
                cmd.Parameters.Add(db.CreateParameter("@TenNguoiban", System.Data.DbType.String, 50, t.TenNguoiban));
                cmd.Parameters.Add(db.CreateParameter("@Diachi", System.Data.DbType.String, 50, t.Diachi));
                cmd.Parameters.Add(db.CreateParameter("@TenMathang", System.Data.DbType.String, 50, t.TenMathang));
                cmd.Parameters.Add(db.CreateParameter("@Soluong", System.Data.DbType.Decimal, 9, t.Soluong));
                cmd.Parameters.Add(db.CreateParameter("@Dongia", System.Data.DbType.Decimal, 9, t.Dongia));
                cmd.Parameters.Add(db.CreateParameter("@TienThanhtoan", System.Data.DbType.Decimal,9, t.TienThanhtoan));
                cmd.Parameters.Add(db.CreateParameter("@Ghichu", System.Data.DbType.String, 50, t.Ghichu));
                cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("BuyNoInvoiceDAL", "Insert(BuyNoInvoice t)", excp.Message);
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
        public override int Delete(BuyNoInvoice t)
        {
            return this.Delete(t.AccountTransactionID);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid accountTransactionID)
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
                cmd.CommandText = "usp_BuyNoInvoices_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("BuyNoInvoiceDAL", "Delete(Guid accountTransactionID)", excp.Message);
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
