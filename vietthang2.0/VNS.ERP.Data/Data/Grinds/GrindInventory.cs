using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Grinds
{
   public class GrindInventory:BaseClass
    {
          public GrindInventory()
        { }

        public GrindInventory(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PeriodCode", reader)) _PeriodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
            if (!isNull("StockCode", reader)) _StockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("ItemCode", reader)) _ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("Quantity", reader)) _Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            
        }

        protected string _PeriodCode;
        public string PeriodCode
        {
            get { return _PeriodCode; }
            set { _PeriodCode = value; }
        }
       
        protected string _StockCode;
        public string StockCode
        {
            get { return _StockCode; }
            set { _StockCode = value; }
        }


        protected string _ItemCode ;
        public string ItemCode
      {
          get { return _ItemCode; }
          set { _ItemCode = value; }
      }
        protected decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
     
    }
}
