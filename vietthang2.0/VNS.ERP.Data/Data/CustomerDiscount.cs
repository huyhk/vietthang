using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace VNS.ERP.Data
{
    public class CustomerDiscount:UserTracking2
    {
        public CustomerDiscount() { }
        public CustomerDiscount(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("SubjectCode", reader)) _SubjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("StartDate", reader)) _StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("InvoiceDiscount", reader)) _InvoiceDiscount = reader.GetDecimal(reader.GetOrdinal("InvoiceDiscount"));
                if (!isNull("QuarterDiscount", reader)) _QuarterDiscount = reader.GetDecimal(reader.GetOrdinal("QuarterDiscount"));
                if (!isNull("YearDiscount", reader)) _YearDiscount = reader.GetDecimal(reader.GetOrdinal("YearDiscount"));
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
        protected decimal _InvoiceDiscount = 0;
        public decimal InvoiceDiscount
        {
            get { return _InvoiceDiscount; }
            set { _InvoiceDiscount = value; }
        }
        protected decimal _QuarterDiscount = 0;
        public decimal QuarterDiscount
        {
            get { return _QuarterDiscount; }
            set { _QuarterDiscount = value; }
        }
        protected decimal _YearDiscount=0;
        public decimal YearDiscount
        {
            get { return _YearDiscount; }
            set { _YearDiscount = value; }
        }
        protected string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
    }
}
