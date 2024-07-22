using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionStockDAL : BaseDAL<AccountTransactionStock>
    {
        public AccountTransactionStockDAL() { }
        public AccountTransactionStockDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountTransactionStock_Select_All";
        }
        public override int Insert(AccountTransactionStock t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStock_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountTransationID", System.Data.DbType.Guid, 16, t.AccountTransationID));
                Cmd.Parameters.Add(db.CreateParameter("@StockTransactionTypeCode", System.Data.DbType.String, 10, t.StockTransactionTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@StockTransactionNo", System.Data.DbType.String, 20, t.StockTransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@StockTransactionDate", System.Data.DbType.DateTime, 8, t.StockTransactionDate));
                Cmd.Parameters.Add(db.CreateParameter("@Tenkho", System.Data.DbType.String, 50, t.Tenkho));
                Cmd.Parameters.Add(db.CreateParameter("@Nguoigiaonhan", System.Data.DbType.String, 50, t.Nguoigiaonhan));
                Cmd.Parameters.Add(db.CreateParameter("@Donvi", System.Data.DbType.String, 50, t.Donvi));
                Cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 50, t.PTVC));
                Cmd.Parameters.Add(db.CreateParameter("@NguoiVC", System.Data.DbType.String, 50, t.NguoiVC));
                Cmd.Parameters.Add(db.CreateParameter("@LydoNX", System.Data.DbType.String, 50, t.LydoNX));
                Cmd.Parameters.Add(db.CreateParameter("@Chungtukemtheo", System.Data.DbType.String, 50, t.Chungtukemtheo));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                if (t.DonviCode == string.Empty || t.DonviCode == null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DonviCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DonviCode", System.Data.DbType.String, 10, t.DonviCode));
                }
                
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceMau", System.Data.DbType.String, 50, t.InvoiceMau));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceSeri", System.Data.DbType.String, 50, t.InvoiceSeri));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceSo", System.Data.DbType.String, 50, t.InvoiceSo));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceNgay", System.Data.DbType.DateTime, 4, t.InvoiceNgay));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceThuexuat", System.Data.DbType.Decimal, 9, t.InvoiceThuexuat));
                Cmd.Parameters.Add(db.CreateParameter("@BeforeTaxAmount", System.Data.DbType.Decimal, 9, t.BeforeTaxAmount));
                Cmd.Parameters.Add(db.CreateParameter("@TaxAmount", System.Data.DbType.Decimal, 9, t.TaxAmount));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountDescription", System.Data.DbType.String, 50, t.DiscountDescription));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountAmount", System.Data.DbType.Decimal, 9, t.DiscountAmount));
                Cmd.Parameters.Add(db.CreateParameter("@PaymentType", System.Data.DbType.String, 50, t.PaymentType));
                Cmd.Parameters.Add(db.CreateParameter("@Giamgia", System.Data.DbType.Boolean, 1, t.Giamgia));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceVAT", System.Data.DbType.Boolean, 1, t.InvoiceVAT));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceAmount", System.Data.DbType.Decimal, 9, t.InvoiceAmount));
                Cmd.Parameters.Add(db.CreateParameter("@PaidDays", System.Data.DbType.Int32, 4, t.PaidDays));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionStockDAL", "Insert(AccountTransactionStock t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(AccountTransactionStock t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStock_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountTransationID", System.Data.DbType.Guid, 16, t.AccountTransationID));
                Cmd.Parameters.Add(db.CreateParameter("@StockTransactionTypeCode", System.Data.DbType.String, 10, t.StockTransactionTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@StockTransactionNo", System.Data.DbType.String, 20, t.StockTransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@StockTransactionDate", System.Data.DbType.DateTime, 8, t.StockTransactionDate));
                Cmd.Parameters.Add(db.CreateParameter("@Tenkho", System.Data.DbType.String, 50, t.Tenkho));
                Cmd.Parameters.Add(db.CreateParameter("@Nguoigiaonhan", System.Data.DbType.String, 50, t.Nguoigiaonhan));
                Cmd.Parameters.Add(db.CreateParameter("@Donvi", System.Data.DbType.String, 50, t.Donvi));
                Cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 50, t.PTVC));
                Cmd.Parameters.Add(db.CreateParameter("@NguoiVC", System.Data.DbType.String, 50, t.NguoiVC));
                Cmd.Parameters.Add(db.CreateParameter("@LydoNX", System.Data.DbType.String, 50, t.LydoNX));
                Cmd.Parameters.Add(db.CreateParameter("@Chungtukemtheo", System.Data.DbType.String, 50, t.Chungtukemtheo));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                if (t.DonviCode == string.Empty || t.DonviCode == null)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DonviCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DonviCode", System.Data.DbType.String, 10, t.DonviCode));
                }
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceMau", System.Data.DbType.String, 50, t.InvoiceMau));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceSeri", System.Data.DbType.String, 50, t.InvoiceSeri));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceSo", System.Data.DbType.String, 50, t.InvoiceSo));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceNgay", System.Data.DbType.DateTime, 4, t.InvoiceNgay));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceThuexuat", System.Data.DbType.Decimal, 4, t.InvoiceThuexuat));
                Cmd.Parameters.Add(db.CreateParameter("@BeforeTaxAmount", System.Data.DbType.Decimal, 9, t.BeforeTaxAmount));
                Cmd.Parameters.Add(db.CreateParameter("@TaxAmount", System.Data.DbType.Decimal, 9, t.TaxAmount));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountDescription", System.Data.DbType.String, 50, t.DiscountDescription));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountAmount", System.Data.DbType.Decimal, 9, t.DiscountAmount));
                Cmd.Parameters.Add(db.CreateParameter("@PaymentType", System.Data.DbType.String, 50, t.PaymentType));
                Cmd.Parameters.Add(db.CreateParameter("@Giamgia", System.Data.DbType.Boolean, 1, t.Giamgia));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceVAT", System.Data.DbType.Boolean, 1, t.InvoiceVAT));
                Cmd.Parameters.Add(db.CreateParameter("@InvoiceAmount", System.Data.DbType.Decimal, 9, t.InvoiceAmount));
                Cmd.Parameters.Add(db.CreateParameter("@PaidDays", System.Data.DbType.Int32, 4, t.PaidDays));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionStockDAL", "Update(AccountTransactionStock t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(AccountTransactionStock t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_AccountTransactionStock_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountTransationID", System.Data.DbType.Guid, 16, t.AccountTransationID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionStockDAL", "Delete(AccountTransactionStock t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
