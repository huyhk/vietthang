using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerDeptDAL : StockBaseDAL<CustomerDept>
    {
        public CustomerDeptDAL() { }
        public CustomerDeptDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_CustomerDepts_Select_All";
            //base.SetValues();
        }
        
        public ListBase<CustomerDept> GetBySubjectCode(string subjectCode)
        {
            DbDataReader reader = null;
            ListBase<CustomerDept> lstReturn = new ListBase<CustomerDept>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CustomerDepts_Select_By_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerDept obj = new CustomerDept(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerDeptDAL", "GetBySubjectCode(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public CustomerDept GetBySubjectCodeAndDate(string subjectCode, DateTime d)
        {
            DbDataReader reader = null;
            CustomerDept objReturn=null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_CustomerDepts_Select_By_SubjectCode_And_Date";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                cmd.Parameters.Add(db.CreateParameter("@d", System.Data.DbType.DateTime, 4, d));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    objReturn = new CustomerDept(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerDeptDAL", "GetBySubjectCodeAndDate(string subjectCode, DateTime d)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return objReturn;
        }
        public override int Insert(CustomerDept t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDepts_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, t.StartDate));
                Cmd.Parameters.Add(db.CreateParameter("@Cash", System.Data.DbType.Boolean, 1, t.Cash));
                Cmd.Parameters.Add(db.CreateParameter("@AmountLimit", System.Data.DbType.Boolean, 1, t.AmountLimit));
                Cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                Cmd.Parameters.Add(db.CreateParameter("@DateLimit", System.Data.DbType.Boolean, 1, t.DateLimit));
                Cmd.Parameters.Add(db.CreateParameter("@Days", System.Data.DbType.Int16, 2, t.Days));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDeptDAL", "Insert(CustomerDept t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(CustomerDept t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDepts_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, t.StartDate));
                Cmd.Parameters.Add(db.CreateParameter("@Cash", System.Data.DbType.Boolean, 1, t.Cash));
                Cmd.Parameters.Add(db.CreateParameter("@AmountLimit", System.Data.DbType.Boolean, 1, t.AmountLimit));
                Cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                Cmd.Parameters.Add(db.CreateParameter("@DateLimit", System.Data.DbType.Boolean, 1, t.DateLimit));
                Cmd.Parameters.Add(db.CreateParameter("@Days", System.Data.DbType.Int16, 2, t.Days));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDeptDAL", "Update(CustomerDept t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(CustomerDept t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDepts_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, t.StartDate));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDeptDAL", "Delete(CustomerDept t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
