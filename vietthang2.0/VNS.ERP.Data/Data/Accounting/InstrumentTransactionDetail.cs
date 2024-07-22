using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class InstrumentTransactionDetail : BaseClass
    {
        public InstrumentTransactionDetail() { }
        public InstrumentTransactionDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("DepClassificationCode")) depClassificationCode = (String)(row["DepClassificationCode"]);
            if (!row.IsNull("TransactionID")) transactionID = (Guid)(row["TransactionID"]);
            if (!row.IsNull("TransactionDetailID")) transactionDetailID = (Guid)(row["TransactionDetailID"]);
            if (!row.IsNull("StockInCode")) stockInCode = (String)(row["StockInCode"]);
            if (!row.IsNull("StockOutCode")) stockOutCode = (String)(row["StockOutCode"]);
            if (!row.IsNull("ItemCode")) itemCode = (String)(row["ItemCode"]);
            if (!row.IsNull("Quantity")) quantity = (Decimal)(row["Quantity"]);
            if (!row.IsNull("Price")) price = (Decimal)(row["Price"]);
            if (!row.IsNull("Amount")) amount = (Decimal)(row["Amount"]);
            if (!row.IsNull("DepType")) depType = (String)(row["DepType"]);
            if (!row.IsNull("DepAccountCode")) depAccountCode = (String)(row["DepAccountCode"]);
            if (!row.IsNull("DepSubjectCode")) depSubjectCode = (String)(row["DepSubjectCode"]);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("DepClassificationCode", reader)) depClassificationCode = reader.GetString(reader.GetOrdinal("DepClassificationCode"));
            if (!isNull("TransactionID", reader)) transactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
            if (!isNull("TransactionDetailID", reader)) transactionDetailID = reader.GetGuid(reader.GetOrdinal("TransactionDetailID"));
            if (!isNull("StockInCode", reader)) stockInCode = reader.GetString(reader.GetOrdinal("StockInCode"));
            if (!isNull("StockOutCode", reader)) stockOutCode = reader.GetString(reader.GetOrdinal("StockOutCode"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
            if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
            if (!isNull("DepType", reader)) depType = reader.GetString(reader.GetOrdinal("DepType"));
            if (!isNull("DepAccountCode", reader)) depAccountCode = reader.GetString(reader.GetOrdinal("DepAccountCode"));
            if (!isNull("DepSubjectCode", reader)) depSubjectCode = reader.GetString(reader.GetOrdinal("DepSubjectCode"));
        }
        private string depClassificationCode=string.Empty;
        public string DepClassificationCode
        {
            get { return depClassificationCode; }
            set { depClassificationCode = value; }
        }
        private Guid transactionID;
        public Guid TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        private Guid transactionDetailID;
        public Guid TransactionDetailID
        {
            get { return transactionDetailID; }
            set { transactionDetailID = value; }
        }
        private string stockInCode = string.Empty;
        public string StockInCode
        {
            get { return stockInCode; }
            set { stockInCode = value; }
        }
        private string stockOutCode = string.Empty;
        public string StockOutCode
        {
            get { return stockOutCode; }
            set { stockOutCode = value; }
        }
        private string itemCode = string.Empty;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }
        private decimal quantity;
        public decimal Quantity
        {
            get { return quantity; }
            set 
            { 
                quantity = value;
                this.amount = this.quantity * this.price;
            }
        }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set 
            { 
                price = value;
                this.amount = this.quantity * this.price;
            }
        }
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set 
            { 
                amount = value;
                if (this.quantity != 0)
                {
                    this.price = this.amount / this.quantity;
                }
                else
                {
                    if (this.price != 0)
                    {
                        this.quantity = this.amount / this.price;
                    }
                }
            }
        }
        private string depType = string.Empty;
        public string DepType
        {
            get { return depType; }
            set 
            {
                if (value == enumDepType.Prepaid.ToString())
                {
                    if(depType != value) this.LstPrePaidExpense.Add(new PrePaidExpense());
                }
                else
                {
                    this.LstPrePaidExpense.Clear();
                }
                depType = value;
            }
        }
        private string depAccountCode = string.Empty;
        public string DepAccountCode
        {
            get { return depAccountCode; }
            set { depAccountCode = value; }
        }
        private string depSubjectCode = string.Empty;
        public string DepSubjectCode
        {
            get { return depSubjectCode; }
            set { depSubjectCode = value; }
        }
        private ListBase<PrePaidExpense> lstPrePaidExpense = new ListBase<PrePaidExpense>();
        public ListBase<PrePaidExpense> LstPrePaidExpense
        {
            get { return lstPrePaidExpense; }
            set { lstPrePaidExpense = value; }
        }
    }
}
