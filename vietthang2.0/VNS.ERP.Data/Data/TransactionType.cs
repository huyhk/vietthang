using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
    public class TransactionType : UserTracking2 
    {
        //Cons
        public TransactionType() { }

        public TransactionType(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        // Method
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            //base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TransactionTypeCode", reader)) _TransactionTypeCode = reader.GetString(reader.GetOrdinal("TransactionTypeCode"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("StockTransaction", reader)) _StockTransaction = reader.GetInt16(reader.GetOrdinal("StockTransaction"));
                //if (!isNull("ForManufacture", reader)) _ForManufacture = reader.GetBoolean(reader.GetOrdinal("ForManufacture"));
            }
            base.FromDataReader(reader);
        }
        //Attribute
        private string _TransactionTypeCode;
        private string description;
        private Int16 _StockTransaction=-1;
        //Properties
        public string TransactionTypeCode
        {
            get { return _TransactionTypeCode; }
            set { _TransactionTypeCode = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Int16 StockTransaction
        {
            get { return _StockTransaction; }
            set { _StockTransaction = value; }
        }
        private bool _ForManufacture = false;
        public bool ForManufacture
        {
            get { return _ForManufacture; }
            set { _ForManufacture = value; }
        }

    }
}
