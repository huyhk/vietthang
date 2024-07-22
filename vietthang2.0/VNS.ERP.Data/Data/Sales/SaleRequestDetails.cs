using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    public class SaleRequestDetails : UserTracking2
    {
        public SaleRequestDetails()
        { }

        public SaleRequestDetails(DbDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!CheckNull("SaleRequestID", reader)) _saleRequestID = reader.GetGuid(reader.GetOrdinal("SaleRequestID"));
                if (!CheckNull("ItemCode", reader)) _itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!CheckNull("QuantityReq", reader)) _quantityReq = reader.GetDecimal(reader.GetOrdinal("QuantityReq"));
                if (!CheckNull("Quantity", reader)) _quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!CheckNull("SalePrice", reader)) _salePrice = reader.GetDecimal(reader.GetOrdinal("SalePrice"));
                if (!CheckNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
           
        }
        #region Public Properties

        protected Guid _saleRequestID;
        public Guid SaleRequestID
        {
            set { _saleRequestID = value; }
            get { return _saleRequestID; }
        }

        protected string _itemCode = String.Empty;
        public string ItemCode
        {
            set { _itemCode = value; }
            get { return _itemCode; }
        }

        protected decimal _quantity;
        public decimal Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }

        protected decimal _quantityReq;
        public decimal QuantityReq
        {
            set { _quantityReq = value; }
            get { return _quantityReq; }
        }

        protected decimal _salePrice;
        public decimal SalePrice
        {
            set { _salePrice = value; }
            get { return _salePrice; }
        }
        protected string description = String.Empty;
        public string Description
        {
            set { description = value; }
            get { return description; }
        }  
        #endregion
    }
}

