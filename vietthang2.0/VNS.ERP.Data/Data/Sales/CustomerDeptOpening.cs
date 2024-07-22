using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Sales
{
    public class CustomerDeptOpening : BaseClass
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public CustomerDeptOpening() { }
        /// <summary>
        /// Constructor read data info data reader
        /// </summary>
        /// <param name="reader"></param>
        public CustomerDeptOpening(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        /// <summary>
        /// Load info from reader into object
        /// </summary>
        /// <param name="reader">System.Data.IDataReader</param>
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PeriodCode", reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("CustomerCode", reader)) customerCode = reader.GetString(reader.GetOrdinal("CustomerCode"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("InvoiceNo", reader)) invoiceNo = reader.GetString(reader.GetOrdinal("InvoiceNo"));
                if (!isNull("InvoiceDate", reader)) invoiceDate = reader.GetDateTime(reader.GetOrdinal("InvoiceDate"));
                if (!isNull("OrgAmount", reader)) orgAmount = reader.GetDecimal(reader.GetOrdinal("OrgAmount"));
                if (!isNull("PaidAmount", reader)) paidAmount = reader.GetDecimal(reader.GetOrdinal("PaidAmount"));
                if (!isNull("RemainAmount", reader)) remainAmount = reader.GetDecimal(reader.GetOrdinal("RemainAmount"));
                if (!isNull("DueDate", reader)) dueDate = reader.GetDateTime(reader.GetOrdinal("DueDate"));
                if (!isNull("DateLimit", reader)) DateLimit = reader.GetBoolean(reader.GetOrdinal("DateLimit"));
            }
            base.FromDataReader(reader);
        }
        /// <summary>
        /// Use to backup PeriocCode property
        /// </summary>
        private string periodCode;
        /// <summary>
        /// Get or set PeriodCode property
        /// </summary>
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }
        /// <summary>
        /// Use to backup CustomerCode property
        /// </summary>
        private string customerCode;
        /// <summary>
        /// Get or ser CustomerCode property
        /// </summary>
        public string CustomerCode
        {
            get { return customerCode; }
            set { customerCode = value; }
        }
        /// <summary>
        /// Use to backup StockCode property
        /// </summary>
        private string stockCode;
        /// <summary>
        /// Get or set StockCode property
        /// </summary>
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        /// <summary>
        /// Use to backup InvoiceNo property
        /// </summary>
        private string invoiceNo;
        /// <summary>
        /// Get or set InvoiceNo property
        /// </summary>
        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }
        /// <summary>
        /// Use to backup InvoiceDate property
        /// </summary>
        private DateTime invoiceDate=Contexts.WorkingDate;
        /// <summary>
        /// Get or set InvoiceDate property
        /// </summary>
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }
        /// <summary>
        /// Use to backup OrgAmount property
        /// </summary>
        private decimal orgAmount;
        /// <summary>
        /// Get or set OrgAmount property
        /// </summary>
        public decimal OrgAmount
        {
            get { return orgAmount; }
            set 
            { 
                orgAmount = value;
                remainAmount = orgAmount - paidAmount;
            }
        }
        /// <summary>
        /// Use to backup PaidAmountProperty
        /// </summary>
        private decimal paidAmount;
        /// <summary>
        /// Get or set PaidAmount property
        /// </summary>
        public decimal PaidAmount
        {
            get { return paidAmount; }
            set 
            { 
                paidAmount = value;
                remainAmount = orgAmount - paidAmount;
            }
        }
        /// <summary>
        /// Use to backup RemainAmount property
        /// </summary>
        private decimal remainAmount;
        /// <summary>
        /// Get or set RemainAmount property
        /// </summary>
        public decimal RemainAmount
        {
            get { return remainAmount; }
            set 
            { 
                remainAmount = value;
                paidAmount = orgAmount - remainAmount;
            }
        }
        /// <summary>
        /// Use to backup DueDate property
        /// </summary>
        private DateTime dueDate=Contexts.WorkingDate;
        /// <summary>
        /// Get or set DueDate property
        /// </summary>
        public DateTime DueDate
        {
            get { return dueDate; }
            set {  dueDate = value;}
        }

        public string DueDateFormated
        {
            get
            {
                if (dateLimit==false)
                    return string.Empty;
                else
                    return dueDate.ToString("dd/MM/yyyy");
            }

        }
        
        /// <summary>
        /// Use to backup DateLimit property
        /// </summary>
        private bool dateLimit = false;
        /// <summary>
        /// Get or set DateLimit property
        /// </summary>
        public bool DateLimit
        {
            get { return dateLimit; }
            set 
            { 
                dateLimit = value;
            }
        }
    }
}
