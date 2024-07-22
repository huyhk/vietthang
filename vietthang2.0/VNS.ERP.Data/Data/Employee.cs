using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class Employee : UserTracking2
    {
        public Employee()
        { }
        public Employee(IDataReader Reader)
        {
            this.FromDataReader(Reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("EmployeeID", reader)) _EmployeeID = reader.GetString(reader.GetOrdinal("EmployeeID"));
                if (!isNull("EmployeeName", reader)) _EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            }
            base.FromDataReader(reader);
        }
        #region Public Properties
        protected string _EmployeeID = string.Empty;
        public string EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        protected string _EmployeeName;
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        #endregion
    }
}
