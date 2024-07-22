using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountStockCostOpening : BaseClass
    {
        public AccountStockCostOpening() { }
        public AccountStockCostOpening(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PeriodCode", reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
            if (!isNull("AccountCode", reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("OpeningAmount", reader)) openingAmount = reader.GetDecimal(reader.GetOrdinal("OpeningAmount"));
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
        private decimal openingAmount;
        public decimal OpeningAmount
        {
            get { return openingAmount; }
            set { openingAmount = value; }
        }
       
    }
}
