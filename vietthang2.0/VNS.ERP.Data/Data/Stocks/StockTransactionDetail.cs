using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace VNS.ERP.Data
{
    public class StockTransactionDetail : BaseClass
    {
        public StockTransactionDetail() { }
        public StockTransactionDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TransactionID", reader)) _TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                if (!isNull("ItemCode", reader)) _ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("InLocation", reader)) _InLocation = reader.GetString(reader.GetOrdinal("InLocation"));
                if (!isNull("OutLocation", reader)) _OutLocation = reader.GetString(reader.GetOrdinal("OutLocation"));
                if (!isNull("Quantity", reader)) _Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));

                if (!isNull("GoodCode", reader)) goodCode = reader.GetString(reader.GetOrdinal("GoodCode"));
            }
            base.FromDataReader(reader);
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!CheckNull("TransactionID", reader)) _TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                if (!CheckNull("ItemCode", reader)) _ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!CheckNull("InLocation", reader)) _InLocation = reader.GetString(reader.GetOrdinal("InLocation"));
                if (!CheckNull("OutLocation", reader)) _OutLocation = reader.GetString(reader.GetOrdinal("OutLocation"));
                if (!CheckNull("Quantity", reader)) _Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));

                if (!CheckNull("GoodCode", reader)) goodCode = reader.GetString(reader.GetOrdinal("GoodCode"));
            }
            base.LoadFromReader(reader);
        }
        protected Guid _TransactionID;
        public Guid TransactionID
        {
            get { return _TransactionID; }
            set { _TransactionID = value; }
        }
        protected string _ItemCode;
        public string ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }
        protected string _InLocation=string.Empty;
        public string InLocation
        {
            get { return _InLocation; }
            set { _InLocation = value; }
        }
        protected string _OutLocation = string.Empty;
        public string OutLocation
        {
            get { return _OutLocation; }
            set { _OutLocation = value; }
        }
        protected decimal _Quantity=0;
        public decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        protected string goodCode = string.Empty;
        public string GoodCode
        {
            get { return goodCode; }
            set { goodCode = value; }
        }
    }
}
