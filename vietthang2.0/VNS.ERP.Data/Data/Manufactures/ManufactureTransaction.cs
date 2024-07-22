using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureTransaction : UserTracking2
    {
        public ManufactureTransaction()
        { }
        public ManufactureTransaction(DbDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ManufactureID", reader)) _manufactureID = reader.GetGuid(reader.GetOrdinal("ManufactureID"));
                if (!isNull("ItemCode", reader)) _itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("IsReceived", reader)) _isReceived = reader.GetBoolean(reader.GetOrdinal("IsReceived"));
                if (!isNull("TransactionType", reader)) _transactionType = reader.GetInt32(reader.GetOrdinal("TransactionType"));
                if (!isNull("Quantity", reader)) _quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("PCode", reader)) pCode = reader.GetString(reader.GetOrdinal("PCode"));
            }

        }
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);


            if (!row.IsNull("ManufactureID")) _manufactureID = (Guid)row["ManufactureID"];
            if (!row.IsNull("ItemCode")) _itemCode = (String)row["ItemCode"];
            if (!row.IsNull("IsReceived")) _isReceived = (bool)row["IsReceived"];
            if (!row.IsNull("TransactionType")) _transactionType = (Byte)row["TransactionType"];
            if (!row.IsNull("Quantity")) _quantity = (decimal)row["Quantity"];
            if (!row.IsNull("PCode")) pCode = (String)row["PCode"];

        }
        #region Public Properties

        protected Guid _manufactureID;
        public Guid ManufactureID
        {
            set { _manufactureID = value; }
            get { return _manufactureID; }
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

        private string pCode = string.Empty;

        public string PCode
        {
            get { return pCode; }
            set { pCode = value; }
        }

	
        #endregion
    }
}
