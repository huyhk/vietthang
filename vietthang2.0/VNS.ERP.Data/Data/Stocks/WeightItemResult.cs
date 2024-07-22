using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
    public class WeightItemResult:BaseClass
    {
        public WeightItemResult() { }
        public WeightItemResult(System.Data.IDataReader reader) 
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("WeightID", reader)) _WeightID = reader.GetGuid(reader.GetOrdinal("WeightID"));
                if (!isNull("StockLocationCode", reader)) _StockLocationCode = reader.GetString(reader.GetOrdinal("StockLocationCode"));
                if (!isNull("Weight", reader)) _Weight = reader.GetDecimal(reader.GetOrdinal("Weight"));
            }
            base.FromDataReader(reader);
        }
        protected Guid _WeightID;
        public Guid WeightID
        {
            get { return _WeightID; }
            set { _WeightID = value; }
        }
        protected string _StockLocationCode;
        public string StockLocationCode
        {
            get { return _StockLocationCode; }
            set { _StockLocationCode = value; }
        }
        protected decimal _Weight;
        public decimal Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
    }
}
