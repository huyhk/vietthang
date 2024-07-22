using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    public class SaleRequests : UserTracking2
    {
        public SaleRequests()
        { }

        public SaleRequests(DbDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!CheckNull("SaleRequestID", reader)) _saleRequestID = reader.GetGuid(reader.GetOrdinal("SaleRequestID"));
                if (!CheckNull("CustomerOrderNo", reader)) _customerOrderNo = reader.GetString(reader.GetOrdinal("CustomerOrderNo"));
                if (!CheckNull("StockCode", reader)) _stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!CheckNull("CustomerCode", reader)) _customerCode = reader.GetString(reader.GetOrdinal("CustomerCode"));
                if (!CheckNull("TransportCode", reader)) _transportCode = reader.GetString(reader.GetOrdinal("TransportCode"));
                if (!CheckNull("SaleRequestNo", reader)) _saleRequestNo = reader.GetString(reader.GetOrdinal("SaleRequestNo"));
                if (!CheckNull("SaleRequestDate", reader)) _saleRequestDate = reader.GetDateTime(reader.GetOrdinal("SaleRequestDate"));
                if (!CheckNull("PTVC", reader)) _pTVC = reader.GetString(reader.GetOrdinal("PTVC"));
                if (!CheckNull("DueDate", reader)) _dueDate = reader.GetDateTime(reader.GetOrdinal("DueDate"));
                if (!CheckNull("InvoiceDiscount", reader)) _invoiceDiscount = reader.GetDecimal(reader.GetOrdinal("InvoiceDiscount"));
                if (!CheckNull("InvoiceAmount", reader)) _invoiceAmount = reader.GetDecimal(reader.GetOrdinal("InvoiceAmount"));
                if (!CheckNull("InvoiceNo", reader)) _invoiceNo = reader.GetString(reader.GetOrdinal("InvoiceNo"));
                if (!CheckNull("QuarterDiscount", reader)) _quarterDiscount = reader.GetDecimal(reader.GetOrdinal("QuarterDiscount"));
                if (!CheckNull("YearDiscount", reader)) _yearDiscount = reader.GetDecimal(reader.GetOrdinal("YearDiscount"));
                if (!CheckNull("IsFinished", reader)) _isFinished = reader.GetBoolean(reader.GetOrdinal("IsFinished"));
                if (!CheckNull("TaxRate", reader)) _taxRate = reader.GetDecimal(reader.GetOrdinal("TaxRate"));
                if (!CheckNull("Quantity", reader)) _quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!CheckNull("DateLimit", reader)) _dateLimit = reader.GetBoolean(reader.GetOrdinal("DateLimit"));
                if (!CheckNull("Nguoigiaonhan", reader)) nguoiGiaoNhan = reader.GetString(reader.GetOrdinal("Nguoigiaonhan"));
                if (!CheckNull("TaxAmount", reader)) taxAmount = reader.GetDecimal(reader.GetOrdinal("TaxAmount"));
                if (!CheckNull("BeforeTaxAmount", reader)) beforeTaxAmount = reader.GetDecimal(reader.GetOrdinal("BeforeTaxAmount"));
                if (!CheckNull("DiscountDescription", reader)) discountDescription = reader.GetString(reader.GetOrdinal("DiscountDescription"));
                if (!CheckNull("DiscountAmount", reader)) discountAmount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount"));
                if (!CheckNull("PaymentType", reader)) paymentType = reader.GetString(reader.GetOrdinal("PaymentType"));
                if (!CheckNull("Giamgia", reader)) giamgia = reader.GetBoolean(reader.GetOrdinal("Giamgia"));
                if (!CheckNull("InvoiceDate", reader)) invoiceDate = reader.GetDateTime(reader.GetOrdinal("InvoiceDate"));
                if (!CheckNull("InvoiceMau", reader)) invoiceMau = reader.GetString(reader.GetOrdinal("InvoiceMau"));
                if (!CheckNull("InvoiceSeri", reader)) invoiceSeri = reader.GetString(reader.GetOrdinal("InvoiceSeri"));
                if (!CheckNull("InvoiceCustomerName", reader)) invoiceCustomerName = reader.GetString(reader.GetOrdinal("InvoiceCustomerName"));
                if (!CheckNull("InvoicePersonName", reader)) invoicePersonName = reader.GetString(reader.GetOrdinal("InvoicePersonName"));

                if (!CheckNull("DiscountID", reader)) discountID = reader.GetGuid(reader.GetOrdinal("DiscountID"));
                if (!CheckNull("StockInCode", reader)) stockInCode = reader.GetString(reader.GetOrdinal("StockInCode"));
            }
          
            base.LoadFromReader(reader);
        }
        #region Public Properties

        protected Guid _saleRequestID;
        public Guid SaleRequestID
        {
            set { _saleRequestID = value; }
            get { return _saleRequestID; }
        }
        protected Guid discountID = Guid.Empty;
        public Guid DiscountID
        {
            set { discountID = value; }
            get { return discountID; }
        }
        

        protected string _customerOrderNo = String.Empty;
        public string CustomerOrderNo
        {
            set { _customerOrderNo = value; }
            get { return _customerOrderNo; }
        }

        protected string invoiceCustomerName = String.Empty;
        public string InvoiceCustomerName
        {
            set { invoiceCustomerName = value; }
            get { return invoiceCustomerName; }
        }

        protected string invoicePersonName = String.Empty;
        public string InvoicePersonName
        {
            set { invoicePersonName = value; }
            get { return invoicePersonName; }
        }

        protected string _stockCode = String.Empty;
        public string StockCode
        {
            set { _stockCode = value; }
            get { return _stockCode; }
        }
        protected string _customerCode = String.Empty;
        public string CustomerCode
        {
            set { _customerCode = value; }
            get { return _customerCode; }
        }
        protected string _transportCode = String.Empty;
        public string TransportCode
        {
            set { _transportCode = value; }
            get { return _transportCode; }
        }

        protected DateTime _saleRequestDate=Contexts.WorkingDate;
        public DateTime SaleRequestDate
        {
            set { _saleRequestDate = value; }
            get { return _saleRequestDate; }
        }

        protected string _saleRequestNo = String.Empty;
        public string SaleRequestNo
        {
            set { _saleRequestNo = value; }
            get { return _saleRequestNo; }
        }

        protected string _pTVC = String.Empty;
        public string PTVC
        {
            set { _pTVC = value; }
            get { return _pTVC; }
        }

        protected DateTime _dueDate;
        public DateTime DueDate
        {
            set { _dueDate = value; }
            get { return _dueDate; }
        }
        protected string _dueDateFormat = string.Empty;
        public string DueDateFormat
        {
            
            get
            {
                if (_dueDate == DateTime.MinValue)
                {
                    return _dueDateFormat;
                }
                else
                    return _dueDate.ToShortDateString();
            }

        }

        protected decimal _invoiceDiscount;
        public decimal InvoiceDiscount
        {
            set { _invoiceDiscount = value; }
            get { return _invoiceDiscount; }
        }

        protected decimal _invoiceAmount;
        public decimal InvoiceAmount
        {
            set { _invoiceAmount = value; }
            get { return _invoiceAmount; }
        }


        protected string _invoiceNo = String.Empty;
        public string InvoiceNo
        {
            set { _invoiceNo = value; }
            get { return _invoiceNo; }
        }

        protected decimal _quarterDiscount;
        public decimal QuarterDiscount
        {
            set { _quarterDiscount = value; }
            get { return _quarterDiscount; }
        }
        public decimal QuarterDiscountAmount
        {
            get { return _invoiceAmount * _quarterDiscount; }
        }

        protected decimal _yearDiscount;
        public decimal YearDiscount
        {
            set { _yearDiscount = value; }
            get { return _yearDiscount; }
        }

        public decimal YearDiscountAmount
        {
            get { return _invoiceAmount * _yearDiscount; }
        }
        protected bool _isFinished;
        public bool IsFinished
        {
            set { _isFinished = value; }
            get { return _isFinished; }
        }
        protected decimal _taxRate;
        public decimal TaxRate
        {
            set { _taxRate = value; }
            get { return _taxRate; }
        }

        protected decimal _quantity;
        public decimal Quantity
        {
            set { _quantity = value; }
            get { return _quantity; }
        }

        protected bool _dateLimit;
        public bool DateLimit
        {
            set { _dateLimit = value; }
            get { return _dateLimit; }
        }

        private string nguoiGiaoNhan=string.Empty;
        public string NguoiGiaoNhan
        {
            get { return nguoiGiaoNhan; }
            set { nguoiGiaoNhan = value; }
        }

        protected decimal taxAmount;
        public decimal TaxAmount
        {
            set { taxAmount = value; }
            get { return taxAmount; }
        }

        protected decimal beforeTaxAmount;
        public decimal BeforeTaxAmount
        {
            set { beforeTaxAmount = value; }
            get { return beforeTaxAmount; }
        }

        protected string discountDescription = string.Empty;
        public string DiscountDescription
        {
            set { discountDescription = value; }
            get { return discountDescription; }
        }

        protected decimal discountAmount;
        public decimal DiscountAmount
        {
            set { discountAmount = value; }
            get { return discountAmount; }
        }

        protected string paymentType=string.Empty;
        public string PaymentType
        {
            set { paymentType = value; }
            get { return paymentType; }
        }
        private bool giamgia;
        public bool Giamgia
        {
            get { return giamgia; }
            set { giamgia = value; }
        }
        protected DateTime invoiceDate;//=Contexts.WorkingDate;
        public DateTime InvoiceDate
        {
            set { invoiceDate = value; }
            get { return invoiceDate; }
        }

        protected string invoiceDateFormat = "";
        public string InvoiceDateFormat
        {
            get {
                if (invoiceDate == DateTime.MinValue)
                    invoiceDateFormat="";
                else
                    invoiceDateFormat= invoiceDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
              return  invoiceDateFormat;
            }
        }
        protected string invoiceMau = string.Empty;//"01 GTKT - 3LL";
        public string InvoiceMau
        {
            set { invoiceMau = value; }
            get { return invoiceMau; }
        }

        protected string invoiceSeri = string.Empty;
        public string InvoiceSeri
        {
            set { invoiceSeri = value; }
            get { return invoiceSeri; }
        }

        protected string stockInCode = string.Empty;
        public string StockInCode
        {
            set { stockInCode = value; }
            get { return stockInCode; }
        }



        protected ListBase<SaleRequestDetails> details ;//= new ListBase<SaleRequestDetails>();
        public ListBase<SaleRequestDetails> Details
        {
            set { details = value; }
            get { return details; }
        }
        #endregion

        public void UpdateRequestAmount()
        {
            decimal bfTax = 0;
            foreach (SaleRequestDetails d in this.Details)
            {
                bfTax += Math.Round(d.QuantityReq * d.SalePrice, 0, MidpointRounding.AwayFromZero);
            }
            this.BeforeTaxAmount = bfTax;
            this.TaxAmount = Math.Round(this.BeforeTaxAmount * this.TaxRate, 0, MidpointRounding.AwayFromZero);
            this.InvoiceAmount = this.BeforeTaxAmount + this.TaxAmount;
        }
    }
}
