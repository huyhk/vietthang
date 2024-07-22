using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    public class CustomerOrderDetails : UserTracking2
    {
        public CustomerOrderDetails()
        { }

        public CustomerOrderDetails(DbDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!CheckNull("CustomerOrderID", reader)) _customerOrderID = reader.GetGuid(reader.GetOrdinal("CustomerOrderID"));
                if (!CheckNull("ItemCode", reader)) _itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!CheckNull("Quantity", reader)) _quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!CheckNull("DeliverDate", reader)) _deliverDate = reader.GetDateTime(reader.GetOrdinal("DeliverDate"));
                if (!CheckNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!CheckNull("QuantityOut", reader)) _quantityOut = reader.GetDecimal(reader.GetOrdinal("QuantityOut"));
            }
           
        }
        #region Public Properties

        protected Guid _customerOrderID;
        public Guid CustomerOrderID
        {
            set { _customerOrderID = value; }
            get { return _customerOrderID; }
        }

        protected string _itemCode = String.Empty;
        public string ItemCode
        {
            set { _itemCode = value; }
            get { return _itemCode; }
        }

        protected DateTime _deliverDate = Contexts.WorkingDate;
        public DateTime DeliverDate
        {
            set { _deliverDate = value; }
            get { return _deliverDate; }
        }


        protected decimal _quantity;
        public decimal Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }

        protected string _description = String.Empty;
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        protected decimal _quantityOut;
        public decimal QuantityOut
        {
            set { _quantityOut = value; }
            get { return _quantityOut; }
        }
      
        #endregion
    }
}

