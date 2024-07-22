using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionStockDetail : BaseClass
    {
        public AccountTransactionStockDetail() { }
        public AccountTransactionStockDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("AccountTransactionID")) accountTransactionID = (Guid)(row["AccountTransactionID"]);
            if (!row.IsNull("AccountTransactionDetail1ID")) accountTransactionDetail1ID = (Guid)(row["AccountTransactionDetail1ID"]);
            if (!row.IsNull("AccountTransactionDetail2ID")) accountTransactionDetail1ID = (Guid)(row["AccountTransactionDetail2ID"]);
            if (!row.IsNull("DebitAccountCode")) debitAccountCode = (String)(row["DebitAccountCode"]);
            if (!row.IsNull("StockInCode")) stockInCode = (String)(row["StockInCode"]);
            if (!row.IsNull("CreditAccountCode")) creditAccountCode = (String)(row["CreditAccountCode"]);
            if (!row.IsNull("StockOutCode")) stockOutCode = (String)(row["StockOutCode"]);
            if (!row.IsNull("ItemCode")) itemCode = (String)(row["ItemCode"]);
            if (!row.IsNull("Quantity")) quantity = (Decimal)(row["Quantity"]);
            if (!row.IsNull("Price")) price = (Decimal)(row["Price"]);
            if (!row.IsNull("CostPrice")) costPrice = (Decimal)(row["CostPrice"]);
            if (!row.IsNull("Amount")) amount = (Decimal)(row["Amount"]);
            if (!row.IsNull("CostAmount")) costAmount = (Decimal)(row["CostAmount"]);
            if (!row.IsNull("Description")) description = (String)(row["Description"]);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
            if (!isNull("AccountTransactionDetail1ID", reader)) accountTransactionDetail1ID = reader.GetGuid(reader.GetOrdinal("AccountTransactionDetail1ID"));
            if (!isNull("AccountTransactionDetail2ID", reader)) accountTransactionDetail1ID = reader.GetGuid(reader.GetOrdinal("AccountTransactionDetail2ID"));
            if (!isNull("DebitAccountCode", reader)) debitAccountCode = reader.GetString(reader.GetOrdinal("DebitAccountCode"));
            if (!isNull("StockInCode", reader)) stockInCode = reader.GetString(reader.GetOrdinal("StockInCode"));
            if (!isNull("CreditAccountCode", reader)) creditAccountCode = reader.GetString(reader.GetOrdinal("CreditAccountCode"));
            if (!isNull("StockOutCode", reader)) stockOutCode = reader.GetString(reader.GetOrdinal("StockOutCode"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
            if (!isNull("CostPrice", reader)) costPrice = reader.GetDecimal(reader.GetOrdinal("CostPrice"));
            if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
            if (!isNull("CostAmount", reader))  costAmount = reader.GetDecimal(reader.GetOrdinal("CostAmount"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private Guid accountTransactionID;
        public Guid AccountTransactionID
        {
            get { return accountTransactionID; }
            set { accountTransactionID = value; }
        }
        private Guid accountTransactionDetail1ID;
        public Guid AccountTransactionDetail1ID
        {
            get { return accountTransactionDetail1ID; }
            set { accountTransactionDetail1ID = value; }
        }
        private Guid accountTransactionDetail2ID;
        public Guid AccountTransactionDetail2ID
        {
            get { return accountTransactionDetail2ID; }
            set { accountTransactionDetail2ID = value; }
        }
        private string debitAccountCode;
        public string DebitAccountCode
        {
            get { return debitAccountCode; }
            set { debitAccountCode = value; }
        }
        private string stockInCode;
        public string StockInCode
        {
            get { return stockInCode; }
            set { stockInCode = value; }
        }
        private string creditAccountCode;
        public string CreditAccountCode
        {
            get { return creditAccountCode; }
            set { creditAccountCode = value; }
        }
        private string stockOutCode;
        public string StockOutCode
        {
            get { return stockOutCode; }
            set { stockOutCode = value; }
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
            get {
                return quantity;
                //return Math.Round(quantity,0); 
            }
            set 
            { 
                quantity = value;
                this.amount = Math.Round(value * this.Price, 0, MidpointRounding.AwayFromZero);
                this.costAmount = Math.Round(value * this.CostPrice, 0, MidpointRounding.AwayFromZero);
            }
        }
        private decimal costPrice;
        public decimal CostPrice
        {
            get { return Math.Round( costPrice,2); }
            set 
            { 
                costPrice = value;
                this.costAmount = value * this.Quantity;
            }
        }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set 
            { 
                price = value;
                if (this.StockInCode != string.Empty && this.StockInCode != null)
                {
                    this.CostPrice = value;
                }
                this.amount = Math.Round(value * this.Quantity, 0, MidpointRounding.AwayFromZero);
               
            }
        }
        private decimal amount;
        public decimal Amount
        {
            get { return Math.Round(amount,0); }
            set 
            { 
                amount = value;
                if (this.StockInCode != string.Empty && this.StockInCode != null)
                {
                    this.CostAmount = value;
                }
                //price = value / this.Quantity;
                if (this.quantity != 0)
                {
                    price = value / this.Quantity;
                }
                else
                {
                    if (this.price != 0)
                    {
                        this.quantity = value / this.price;
                    }
                }
            }
        }
        private decimal costAmount;
        public decimal CostAmount
        {
            get { return Math.Round(costAmount,0); }
            set 
            { 
                costAmount = value;
                if (this.quantity != 0)
                {
                    costPrice = value / this.Quantity;
                }
                else
                {
                    if (this.costPrice != 0)
                    {
                        this.quantity = value / this.costPrice;
                    }
                }
            }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
