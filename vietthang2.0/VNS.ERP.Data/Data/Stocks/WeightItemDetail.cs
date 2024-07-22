using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class WeightItemDetail:BaseClass
    {
        public WeightItemDetail() { }
        public WeightItemDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("WeightID", reader)) _WeightID = reader.GetGuid(reader.GetOrdinal("WeightID"));
                if (!isNull("StockCode", reader)) _StockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("StockLocationCode", reader)) _StockLocationCode = reader.GetString(reader.GetOrdinal("StockLocationCode"));
                if (!isNull("StockTransportCode", reader)) _StockTransportCode = reader.GetString(reader.GetOrdinal("StockTransportCode"));
                if (!isNull("Weight", reader)) _Weight = reader.GetDecimal(reader.GetOrdinal("Weight"));
                if (!isNull("Quantity", reader)) _Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
            }
            base.FromDataReader(reader);
        }
        #region Public Properties
        protected Guid _WeightID;
        public Guid WeightID
        {
            get { return _WeightID; }
            set { _WeightID = value; }
        }
        protected string _StockCode;
        public string StockCode
        {
            get { return _StockCode; }
            set { _StockCode = value; }
        }
        protected string _StockLocationCode;
        public string StockLocationCode
        {
            get { return _StockLocationCode; }
            set { _StockLocationCode = value; }
        }
        protected string _StockTransportCode;
        public string StockTransportCode
        {
            get { return _StockTransportCode; }
            set { _StockTransportCode = value; }
        }
        protected Decimal _Weight;
        public Decimal Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
        protected int _Quantity;
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        #endregion
    }
}
