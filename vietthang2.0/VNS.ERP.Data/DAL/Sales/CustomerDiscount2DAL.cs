using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    public class CustomerDiscount2DAL : BaseDAL<CustomerDiscount2>
    {
        public CustomerDiscount2DAL() { }
        public CustomerDiscount2DAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_CustomerDiscount2_Select_All";
        }
        public ListBase<CustomerDiscount2> GetBySubjectCode(string subjectCode)
        {
            DbDataReader reader = null;
            ListBase<CustomerDiscount2> lstReturn = new ListBase<CustomerDiscount2>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CustomerDiscount2s_Select_By_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerDiscount2 obj = new CustomerDiscount2(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerDiscount2DAL", "GetBySubjectCode(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(CustomerDiscount2 t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDiscount2_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountTypeCode", System.Data.DbType.String, 10, t.DiscountTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountPercent", System.Data.DbType.Decimal, 9, t.DiscountPercent));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDiscount2DAL", "Insert(CustomerDiscount2 t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(CustomerDiscount2 t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDiscount2_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountTypeCode", System.Data.DbType.String, 10, t.DiscountTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountPercent", System.Data.DbType.Decimal, 9, t.DiscountPercent));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDiscount2DAL", "Update(CustomerDiscount2 t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(CustomerDiscount2 t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDiscount2_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountTypeCode", System.Data.DbType.String, 10, t.DiscountTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDiscount2DAL", "Delete(CustomerDiscount2 t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

        public CustomerDiscount2 GetDiscount(string customerCode, DateTime d, string discountTypeCode, out Boolean error)
        {
            error = false;
            DbDataReader reader = null;
            CustomerDiscount2 objReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CustomerDiscount2s_Select_By_CustomerCode_And_Date";
                cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, customerCode));
                cmd.Parameters.Add(db.CreateParameter("@d", System.Data.DbType.DateTime, 4, d));
                cmd.Parameters.Add(db.CreateParameter("@DiscountTypeCode", System.Data.DbType.String, 10, discountTypeCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    objReturn = new CustomerDiscount2(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                error = true;
                Write2Log.WriteLogs("CustomerDiscount2DAL", "GetDiscount(string customerCode, DateTime d, string discountTypeCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return objReturn;
        }
    }
}
