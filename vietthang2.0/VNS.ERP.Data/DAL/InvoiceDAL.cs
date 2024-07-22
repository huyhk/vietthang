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
    public class InvoiceDAL : StockBaseDAL<Invoice>
    {

        public InvoiceDAL()
        {
        }
        public InvoiceDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        protected override void SetValues()
        {
            _spSelectAll = "usp_Invoices_SelectAll";

        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(Invoice t)
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
                cmd.CommandText = "usp_Invoices_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@Dauvao", System.Data.DbType.Boolean, 1, t.Dauvao));
                cmd.Parameters.Add(db.CreateParameter("@Doanhso", System.Data.DbType.Decimal, 9, t.Doanhso));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 50, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Khongchiuthue", System.Data.DbType.Boolean, 1, t.Khongchiuthue));
                cmd.Parameters.Add(db.CreateParameter("@Nhapkhau", System.Data.DbType.Boolean, 1, t.Nhapkhau));
                cmd.Parameters.Add(db.CreateParameter("@Masothue", System.Data.DbType.String, 50, t.Masothue));
                cmd.Parameters.Add(db.CreateParameter("@MauHoadon", System.Data.DbType.String, 50, t.MauHoadon));
                cmd.Parameters.Add(db.CreateParameter("@NgayHoadon", System.Data.DbType.DateTime, 4, t.NgayHoadon));
                cmd.Parameters.Add(db.CreateParameter("@SoHoadon", System.Data.DbType.String, 50, t.SoHoadon));
                cmd.Parameters.Add(db.CreateParameter("@SoSeri", System.Data.DbType.String, 50, t.SoSeri));
                cmd.Parameters.Add(db.CreateParameter("@TenDonvi", System.Data.DbType.String, 50, t.TenDonvi));
                cmd.Parameters.Add(db.CreateParameter("@TenMathang", System.Data.DbType.String, 50, t.TenMathang));
                cmd.Parameters.Add(db.CreateParameter("@Thuexuat", System.Data.DbType.Decimal, 9, t.Thuexuat));
                cmd.Parameters.Add(db.CreateParameter("@Tienthue", System.Data.DbType.Decimal, 9, t.Tienthue));
                cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("InvoiceDAL", "Insert(Invoice t)", excp.Message);
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
        public override int Delete(Invoice t)
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
                cmd.CommandText = "usp_Invoices_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("InvoiceDAL", "Delete(Guid accountTransactionID)", excp.Message);
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
