using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data
{
    public class BocxepContractPriceDetailDAL : BaseDAL<BocxepContractPriceDetail>
    {
        public BocxepContractPriceDetailDAL() { }
        public BocxepContractPriceDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_BocxepContractPriceDetail_Select_All";
        }
        public override int Insert(BocxepContractPriceDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepContractPriceDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PriceID", System.Data.DbType.Guid, 16, t.PriceID));
                Cmd.Parameters.Add(db.CreateParameter("@TypeCode", System.Data.DbType.String, 20, t.TypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@Ngaythuong", System.Data.DbType.Decimal, 9, t.Ngaythuong));
                Cmd.Parameters.Add(db.CreateParameter("@Ngoaigio", System.Data.DbType.Decimal, 9, t.Ngoaigio));
                Cmd.Parameters.Add(db.CreateParameter("@Chunhat", System.Data.DbType.Decimal, 9, t.Chunhat));
                Cmd.Parameters.Add(db.CreateParameter("@Ngayle", System.Data.DbType.Decimal, 9, t.Ngayle));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepContractPriceDetailDAL", "Insert(BocxepContractPriceDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(BocxepContractPriceDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepContractPriceDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PriceID", System.Data.DbType.Guid, 16, t.PriceID));
                Cmd.Parameters.Add(db.CreateParameter("@TypeCode", System.Data.DbType.String, 20, t.TypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@Ngaythuong", System.Data.DbType.Decimal, 9, t.Ngaythuong));
                Cmd.Parameters.Add(db.CreateParameter("@Ngoaigio", System.Data.DbType.Decimal, 9, t.Ngoaigio));
                Cmd.Parameters.Add(db.CreateParameter("@Chunhat", System.Data.DbType.Decimal, 9, t.Chunhat));
                Cmd.Parameters.Add(db.CreateParameter("@Ngayle", System.Data.DbType.Decimal, 9, t.Ngayle));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepContractPriceDetailDAL", "Update(BocxepContractPriceDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(BocxepContractPriceDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepContractPriceDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PriceID", System.Data.DbType.Guid, 16, t.PriceID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepContractPriceDetailDAL", "Delete(BocxepContractPriceDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int Delete(Guid priceID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepContractPriceDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PriceID", System.Data.DbType.Guid, 16, priceID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepContractPriceDetailDAL", "Delete(Guid priceID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
