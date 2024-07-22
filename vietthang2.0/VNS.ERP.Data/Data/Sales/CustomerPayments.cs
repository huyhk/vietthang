using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    public class CustomerPayments : UserTracking2
    {
        public CustomerPayments()
        { }

        public CustomerPayments(DbDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PaymentID", reader)) _paymentID = reader.GetGuid(reader.GetOrdinal("PaymentID"));
                if (!isNull("CustomerCode", reader)) _customerCode = reader.GetString(reader.GetOrdinal("CustomerCode"));
                if (!isNull("StockCode", reader)) _stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("PaymentNo", reader)) _paymentNo = reader.GetString(reader.GetOrdinal("PaymentNo"));
                if (!isNull("PaymentDate", reader)) _paymentDate = reader.GetDateTime(reader.GetOrdinal("PaymentDate"));
                if (!isNull("Amount", reader)) _amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
                if (!isNull("PaymentType", reader)) _paymentType = reader.GetByte(reader.GetOrdinal("PaymentType"));
                if (!isNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("BranchCode", reader)) branchCode = reader.GetString(reader.GetOrdinal("BranchCode"));
            }
        }
      
        #region Public Properties

        protected Guid _paymentID;
        public Guid PaymentID
        {
            set { _paymentID = value; }
            get { return _paymentID; }
        }

        protected string _stockCode=string.Empty;
        public string StockCode
        {
            set { _stockCode = value; }
            get { return _stockCode; }
        }
        protected string _paymentNo = string.Empty;
        public string PaymentNo
        {
            set { _paymentNo = value; }
            get { return _paymentNo; }
        }

        protected DateTime _paymentDate=Contexts.WorkingDate;
        public DateTime PaymentDate
        {
            set { _paymentDate = value; }
            get { return _paymentDate; }
        }

        protected string _customerCode = string.Empty;
        public string CustomerCode
        {
            set { _customerCode = value; }
            get { return _customerCode; }
        }

        protected string _description = string.Empty;
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }

        protected decimal _amount=0;
        public decimal Amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        protected string branchCode = string.Empty;
        public string BranchCode
        {
            set { branchCode = value; }
            get { return branchCode; }
        }

        protected byte _paymentType=(byte)enumCustomerPayments.Bank;
        public byte PaymentType
        {
            set { _paymentType = value; }
            get { return _paymentType; }
        }
        #endregion
    }
}