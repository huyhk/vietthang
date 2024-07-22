using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;

using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class EmployeeDAL : StockBaseDAL<Employee>
    {
        public EmployeeDAL()
        { }
        public EmployeeDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_Employees_Select_All";
            //base.SetValues();
        }
        public override int Insert(Employee t)
        {
            //Employees Obj = GetByID(t.EmployeeID);
            //if (Obj != null) return -1;
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Employees_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, t.EmployeeID));
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeName", System.Data.DbType.String, 100, t.EmployeeName));
                if (t.StockCode != string.Empty)
                { Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode)); }
                else { Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, DBNull.Value)); }
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EmployeeDAL", "Insert(Employees t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        public override int Update(Employee t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try 
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Employees_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, t.EmployeeID));
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeName", System.Data.DbType.String, 100, t.EmployeeName));
                if (t.StockCode != string.Empty)
                { Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode)); }
                else { Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, DBNull.Value)); }
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EmployeeDAL", "Update(Employees t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(Employee t)
        {
            return Delete(t.EmployeeID);
        }
        public int Delete(string _EmployeeID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Employees_Delete_ID";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, _EmployeeID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EmployeeDAL", "Delete(string _EmployeeID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public Employee GetByID(string _EmployeeID)
        {
            bool AlreadyOpen = false;
            Employee Obj = null;
            try
            {
                DbDataReader Reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Employees_Select_ID";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, _EmployeeID));

                Reader = db.ExecuteReader(Cmd);
                if (Reader.Read()) Obj = new Employee(Reader);
                Reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EmpoyeeDAL", "GetByID(string _EmployeeID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return Obj;
        }
        public ListBase<Employee> GetByStockCode(string stockCode)
        {
            bool AlreadyOpen = false;
            Employee obj = null;
            ListBase<Employee> lstObj = new ListBase<Employee>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Employees_Select_StockCode";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));

                reader = db.ExecuteReader(Cmd);
                while (reader.Read())
                {
                    obj = new Employee(reader);
                    lstObj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EmpoyeeDAL", "GetByStockCode(string stockCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return lstObj;
        }
        public ListBase<Employee> GetByStockCodeAndGroupEmployee(string stockCode,string employeeGroupCode)
        {
            bool AlreadyOpen = false;
            Employee obj = null;
            ListBase<Employee> lstObj = new ListBase<Employee>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Employees_Select_StockCode";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeGroupCode", System.Data.DbType.String, 50, employeeGroupCode));
                reader = db.ExecuteReader(Cmd);
                while (reader.Read())
                {
                    obj = new Employee(reader);
                    lstObj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EmpoyeeDAL", "GetByStockCodeAndGroupEmployee(string stockCode,string employeeGroupCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return lstObj;
        }

        public ListBase<Employee> GetListObjectNotTableGroup(string employeeGroupCode)
        {
            bool AlreadyOpen = false;
            Employee obj = null;
            ListBase<Employee> lstObj = new ListBase<Employee>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Employees_SelectNotTableGroup";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeGroupCode", System.Data.DbType.String, 50, employeeGroupCode));

                reader = db.ExecuteReader(Cmd);
                while (reader.Read())
                {
                    obj = new Employee(reader);
                    lstObj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EmpoyeeDAL", " GetListObjectNotTableGroup(string employeeGroupCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return lstObj;
        }
        public ListBase<Employee> GetListObjectByEmployeeGroupCode(string employeeGroupCode)
        {
            bool AlreadyOpen = false;
            Employee obj = null;
            ListBase<Employee> lstObj = new ListBase<Employee>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Employees_SelectByEmployeeGroupCode";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeGroupCode", System.Data.DbType.String, 50, employeeGroupCode));

                reader = db.ExecuteReader(Cmd);
                while (reader.Read())
                {
                    obj = new Employee(reader);
                    lstObj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EmpoyeeDAL", " GetListObjectByEmployeeGroupCode(string employeeGroupCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return lstObj;
        }

        public int InsertEmployeeGroups(string employeeGroupCode,string employeeID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EmployeeGroups_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.Parameters.Add(db.CreateParameter("@EmployeeGroupCode", System.Data.DbType.String, 50, employeeGroupCode));
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, employeeID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EmployeeDAL", "InsertEmployeeGroups(string employeeGroupCode,string employeeID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int DeleteEmployeeGroup(string employeeGroupCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EmployeeGroups_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@EmployeeGroupCode", System.Data.DbType.String, 50, employeeGroupCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EmployeeDAL", "DeleteEmployeeGroup(string employeeGroupCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
