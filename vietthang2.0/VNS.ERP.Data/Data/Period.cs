using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
   public class Period:BaseClass
    {
       public Period()
        { }

       public Period(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PeriodCode", reader)) _PeriodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
            if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("StartDate", reader)) _StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
            if (!isNull("EndDate", reader)) _EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
            if (!isNull("IsClosed", reader)) _IsClosed = reader.GetBoolean(reader.GetOrdinal("IsClosed"));
            

        }

       protected string _PeriodCode;
       public string PeriodCode
        {
            get { return _PeriodCode; }
            set { _PeriodCode = value; }
        }
       protected string _Description;
       public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

       protected DateTime _StartDate = DateTime.Today;
       public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
       

       protected DateTime _EndDate = DateTime.Today;
       public DateTime EndDate
      {
          get { return _EndDate; }
          set { _EndDate = value; }
      }
       protected bool _IsClosed;
       public bool IsClosed
        {
            get { return _IsClosed; }
            set { _IsClosed = value; }
        }
      
    }
}
