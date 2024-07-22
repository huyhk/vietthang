using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data.Grinds
{
    public class GrindMaterialTransactions : UserTracking2
    {
        public GrindMaterialTransactions()
        { }
        public GrindMaterialTransactions(DbDataReader Reader)
        {
            this.LoadFromReader(Reader);
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {

                if (!CheckNull("GrindMaterialID", reader)) _grindMaterialID = reader.GetGuid(reader.GetOrdinal("GrindMaterialID"));
                if (!CheckNull("ItemCode", reader)) _itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!CheckNull("IsReceived", reader)) _isReceived = reader.GetBoolean(reader.GetOrdinal("IsReceived"));
                if (!CheckNull("TransactionType", reader)) _transactionType = reader.GetInt32(reader.GetOrdinal("TransactionType"));
                if (!CheckNull("Quantity", reader)) _quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            }
        }
        #region Public Properties

        protected Guid _grindMaterialID;
        public Guid GrindMaterialID
        {
            set { _grindMaterialID = value; }
            get { return _grindMaterialID; }
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
