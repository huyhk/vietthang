using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
    public class StockTransport : UserTracking2 
    {
       
        public StockTransport()
        { }

       public StockTransport(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("StockCode", reader)) _StockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("StockTransportCode", reader)) _StockTransportCode = reader.GetString(reader.GetOrdinal("StockTransportCode"));
            if (!isNull("StockTransportName", reader)) _StockTransportName = reader.GetString(reader.GetOrdinal("StockTransportName"));
            if (!isNull("Description", reader)) _Description = reader.GetString  (reader.GetOrdinal("Description"));
            if (!isNull("Weight", reader)) _Weight = reader.GetDecimal (reader.GetOrdinal("Weight"));


        }

       protected string  _StockCode;
       public string StockCode
        {
            get { return _StockCode; }
            set { _StockCode = value; }
        }


       protected string _StockTransportCode;
       public string StockTransportCode
        {
            get { return _StockTransportCode; }
            set { _StockTransportCode = value; }
        }

      
      protected string _StockTransportName;
      public string StockTransportName
      {
          get { return _StockTransportName; }
          set { _StockTransportName = value; }
      }
       protected string _Description;
       public string Description
        {
          get { return _Description; }
          set { _Description = value; }
        }
       protected decimal   _Weight;
       public decimal   Weight
       {
           get { return _Weight; }
           set { _Weight = value; }
       }


    }

    
}
