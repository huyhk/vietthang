using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class InstrumentOpening : BaseClass
    {
        public InstrumentOpening() { }
        public InstrumentOpening(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PeriodCode", reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
        }
        private string periodCode=string.Empty;
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }
        private string stockCode=string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private string itemCode=string.Empty;
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
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
