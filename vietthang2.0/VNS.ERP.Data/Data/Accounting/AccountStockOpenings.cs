using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountStockOpenings : BaseClass
    {
        public AccountStockOpenings() { }
        public AccountStockOpenings(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PeriodCode", reader)) PeriodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
            if (!isNull("AccountCode", reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
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
        private string stockCode;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private string itemCode;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }
        private decimal quantity;
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
