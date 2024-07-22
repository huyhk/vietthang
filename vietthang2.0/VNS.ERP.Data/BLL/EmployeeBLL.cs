using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;

namespace VNS.ERP.Data
{
    public class EmployeeBLL:IBusiness
    {
        private EmployeeDAL DAL = new EmployeeDAL();
        public EmployeeBLL()
        { }
        public ListBase<Employee> GetAll()
        {
            return DAL.GetObjectAll();
        }
        public int Insert(Employee t)
        {
            
            return DAL.Insert(t);
        }
        public int Update(Employee t)
        {
            return DAL.Update(t);
        }
        public int Delete(string _EmployeeID)
        {
            return DAL.Delete(_EmployeeID);
        }
        public int Delete(Employee t)
        {
            return this.Delete(t.EmployeeID);
        }
        public ListBase<Employee> GetByStockCode(string stockCode)
        {
            return DAL.GetByStockCode(stockCode);
        }
        public ListBase<Employee> GetByStockCodeAndGroupEmployee(string stockCode, string employeeGroupCode)
        {
            return DAL.GetByStockCodeAndGroupEmployee(stockCode, employeeGroupCode);
        }
        public ListBase<Employee> GetListObjectNotTableGroup(string employeeGroupCode)
        {
            return DAL.GetListObjectNotTableGroup(employeeGroupCode);
        }
        public ListBase<Employee> GetListObjectByEmployeeGroupCode(string employeeGroupCode)
        {
            return DAL.GetListObjectByEmployeeGroupCode(employeeGroupCode);
        }
        public int InserEmployeeGroup(string employeeGroupCode,ListBase<Employee> lst)
        {
            int iError = 0;
            DAL.Open();
            DAL.BeginTransaction();
            try
            {
                iError = DAL.DeleteEmployeeGroup(employeeGroupCode);
                if (iError == 0)
                {
                    foreach (Employee var in lst)
                    {
                        iError = DAL.InsertEmployeeGroups(employeeGroupCode, var.EmployeeID);
                        if (iError != 0)
                            break;
                    }
                }

            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialBLL", "Insert(GrindMaterials t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    DAL.Commit();
                else
                    DAL.Rollback();
                DAL.Close();
            }
            return iError;
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Employee);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Employee);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Employee);
        }

        #endregion
    }
}
