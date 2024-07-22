using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerDept : UserTracking2
    {
        public CustomerDept() { }
        public CustomerDept(IDataReader Reader)
        {
            this.FromDataReader(Reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("SubjectCode", reader)) _SubjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("StartDate", reader)) _StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("Cash", reader)) _Cash = reader.GetBoolean(reader.GetOrdinal("Cash"));
                if (!isNull("AmountLimit", reader)) _AmountLimit = reader.GetBoolean(reader.GetOrdinal("AmountLimit"));
                if (!isNull("Amount", reader)) _Amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
                if (!isNull("DateLimit", reader)) _DateLimit = reader.GetBoolean(reader.GetOrdinal("DateLimit"));
                if (!isNull("Days", reader)) _Days = reader.GetInt32(reader.GetOrdinal("Days"));
                if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
            }
            base.FromDataReader(reader);
        }
        protected string _SubjectCode;
        public string SubjectCode
        {
            get { return _SubjectCode; }
            set { _SubjectCode = value; }
        }
        protected DateTime _StartDate = Contexts.WorkingDate;
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        protected bool _Cash = true;
        public bool Cash
        {
            get { return _Cash; }
            set 
            {
                _Cash = value;
                _NotCash = !value;
            }
        }
        protected bool _NotCash = false;
        public bool NotCash
        {
            get { return _NotCash; }
        }
        protected bool _AmountLimit=false;
        public bool AmountLimit
        {
            get { return _AmountLimit; }
            set { _AmountLimit = value; }
        }
        protected decimal _Amount=0;
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        protected bool _DateLimit = false;
        public bool DateLimit
        {
            get { return _DateLimit; }
            set { _DateLimit = value; }
        }
        protected int _Days = 0;
        public int Days
        {
            get { return _Days; }
            set { _Days = value; }
        }
        protected string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

    }
}
