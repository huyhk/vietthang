using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureShiftTransaction : BaseClass
    {
        public ManufactureShiftTransaction()
        { }
        public ManufactureShiftTransaction(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ManufactureShiftID", reader)) _manufactureShiftID = reader.GetGuid(reader.GetOrdinal("ManufactureShiftID"));
                if (!isNull("ItemCode", reader)) _itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("IsReceived", reader)) _isReceived = reader.GetBoolean(reader.GetOrdinal("IsReceived"));
                if (!isNull("TransactionType", reader)) _transactionType = reader.GetInt32(reader.GetOrdinal("TransactionType"));
                if (!isNull("Quantity", reader)) _quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            }
           
        }

        #region Public Properties

        protected Guid _manufactureShiftID;
        public Guid ManufactureShiftID
        {
            set { _manufactureShiftID = value; }
            get { return _manufactureShiftID; }
        }
        protected string _itemCode = String.Empty;
        public string ItemCode
        {
            set { _itemCode = value; }
            get { return _itemCode; }
        }
        protected bool _isReceived;
        public bool IsReceived
        {
            set { _isReceived = value; }
            get { return _isReceived; }
        }

        protected int _transactionType;
        public int TransactionType
        {
            set { _transactionType = value; }
            get { return _transactionType; }
        }
        protected decimal _quantity;
        public decimal Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }
        #endregion
    }
}
