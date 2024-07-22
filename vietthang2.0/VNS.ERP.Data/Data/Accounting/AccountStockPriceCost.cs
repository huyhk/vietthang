using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountStockPriceCost : BaseClass
    {
        public AccountStockPriceCost() { }
        public AccountStockPriceCost(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PeriodCode", reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
            if (!isNull("AccountCode", reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("PriceCost", reader)) priceCost = reader.GetDecimal(reader.GetOrdinal("PriceCost"));
        }
        private string periodCode;
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }
        private string accountCode;
        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }
        private string itemCode;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }
        private decimal priceCost;
        public decimal PriceCost
        {
            get { return priceCost; }
            set { priceCost = value; }
        }
    }
}
