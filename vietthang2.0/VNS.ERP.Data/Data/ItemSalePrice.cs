using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace VNS.ERP.Data
{
    public class ItemSalePrice:UserTracking2
    {
        public ItemSalePrice() { }
        public ItemSalePrice(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ItemCode", reader)) _ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("StartDate", reader)) _StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("SalePrice", reader)) _SalePrice = reader.GetDecimal(reader.GetOrdinal("SalePrice"));
                if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
            }
            base.FromDataReader(reader);
        }
        protected string _ItemCode;
        public string ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }
        protected DateTime _StartDate = DateTime.Today;
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        protected decimal _SalePrice = 0;
        public decimal SalePrice
        {
            get { return _SalePrice; }
            set { _SalePrice = value; }
        }
        protected string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
    }
}
