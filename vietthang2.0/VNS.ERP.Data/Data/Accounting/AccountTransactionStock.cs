using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionStock : BaseClass
    {
        public AccountTransactionStock() { }
        public AccountTransactionStock(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("AccountTransationID")) accountTransationID = (Guid)(row["AccountTransationID"]);
            if (!row.IsNull("StockTransactionTypeCode")) stockTransactionTypeCode = (String)(row["StockTransactionTypeCode"]);
            if (!row.IsNull("StockTransactionNo")) stockTransactionNo = (String)(row["StockTransactionNo"]);
            if (!row.IsNull("StockTransactionDate")) stockTransactionDate = (DateTime)(row["StockTransactionDate"]);
            if (!row.IsNull("Tenkho")) tenkho = (String)(row["Tenkho"]);
            if (!row.IsNull("Nguoigiaonhan")) nguoigiaonhan = (String)(row["Nguoigiaonhan"]);
            if (!row.IsNull("Donvi")) donvi = (String)(row["Donvi"]);
            if (!row.IsNull("PTVC")) pTVC = (String)(row["PTVC"]);
            if (!row.IsNull("NguoiVC")) nguoiVC = (String)(row["NguoiVC"]);
            if (!row.IsNull("LydoNX")) lydoNX = (String)(row["LydoNX"]);
            if (!row.IsNull("Chungtukemtheo")) chungtukemtheo = (String)(row["Chungtukemtheo"]);
            if (!row.IsNull("Description")) description = (String)(row["Description"]);
            if (!row.IsNull("DonviCode")) donviCode = (String)(row["DonviCode"]);
            if (!row.IsNull("InvoiceMau")) invoiceMau = (String)(row["InvoiceMau"]);
            if (!row.IsNull("InvoiceSeri")) invoiceSeri = (String)(row["InvoiceSeri"]);
            if (!row.IsNull("InvoiceSo")) invoiceSo = (String)(row["InvoiceSo"]);
            if (!row.IsNull("InvoiceNgay")) invoiceNgay = (DateTime)(row["InvoiceNgay"]);
            if (!row.IsNull("InvoiceThuexuat")) invoiceThuexuat = (Decimal)(row["InvoiceThuexuat"]);
            if (!row.IsNull("BeforeTaxAmount")) beforeTaxAmount = (Decimal)(row["BeforeTaxAmount"]);
            if (!row.IsNull("TaxAmount")) taxAmount = (Decimal)(row["TaxAmount"]);
            if (!row.IsNull("DiscountDescription")) discountDescription = (String)(row["DiscountDescription"]);
            if (!row.IsNull("DiscountAmount")) discountAmount = (Decimal)(row["DiscountAmount"]);
            if (!row.IsNull("PaymentType")) paymentType = (String)(row["PaymentType"]);
            if (!row.IsNull("Giamgia")) giamgia = (Boolean)(row["Giamgia"]);
            if (!row.IsNull("InvoiceVAT")) invoiceVAT = (Boolean)(row["InvoiceVAT"]);
            if (!row.IsNull("InvoiceAmount")) invoiceAmount = (Decimal)(row["InvoiceAmount"]);
            if (!row.IsNull("PaidDays")) paidDays = (int)(row["PaidDays"]);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountTransationID", reader)) accountTransationID = reader.GetGuid(reader.GetOrdinal("AccountTransationID"));
            if (!isNull("StockTransactionTypeCode", reader)) stockTransactionTypeCode = reader.GetString(reader.GetOrdinal("StockTransactionTypeCode"));
            if (!isNull("StockTransactionNo", reader)) stockTransactionNo = reader.GetString(reader.GetOrdinal("StockTransactionNo"));
            if (!isNull("StockTransactionDate", reader)) stockTransactionDate = reader.GetDateTime(reader.GetOrdinal("StockTransactionDate"));
            if (!isNull("Tenkho", reader)) tenkho = reader.GetString(reader.GetOrdinal("Tenkho"));
            if (!isNull("Nguoigiaonhan", reader)) nguoigiaonhan = reader.GetString(reader.GetOrdinal("Nguoigiaonhan"));
            if (!isNull("Donvi", reader)) donvi = reader.GetString(reader.GetOrdinal("Donvi"));
            if (!isNull("PTVC", reader)) pTVC = reader.GetString(reader.GetOrdinal("PTVC"));
            if (!isNull("NguoiVC", reader)) nguoiVC = reader.GetString(reader.GetOrdinal("NguoiVC"));
            if (!isNull("LydoNX", reader)) lydoNX = reader.GetString(reader.GetOrdinal("LydoNX"));
            if (!isNull("Chungtukemtheo", reader)) chungtukemtheo = reader.GetString(reader.GetOrdinal("Chungtukemtheo"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("DonviCode", reader)) donviCode = reader.GetString(reader.GetOrdinal("DonviCode"));
            if (!isNull("InvoiceMau", reader)) invoiceMau = reader.GetString(reader.GetOrdinal("InvoiceMau"));
            if (!isNull("InvoiceSeri", reader)) invoiceSeri = reader.GetString(reader.GetOrdinal("InvoiceSeri"));
            if (!isNull("InvoiceSo", reader)) invoiceSo = reader.GetString(reader.GetOrdinal("InvoiceSo"));
            if (!isNull("InvoiceNgay", reader)) invoiceNgay = reader.GetDateTime(reader.GetOrdinal("InvoiceNgay"));
            if (!isNull("InvoiceThuexuat", reader)) invoiceThuexuat = reader.GetDecimal(reader.GetOrdinal("InvoiceThuexuat"));
            if (!isNull("BeforeTaxAmount", reader)) beforeTaxAmount = reader.GetDecimal(reader.GetOrdinal("BeforeTaxAmount"));
            if (!isNull("TaxAmount", reader)) taxAmount = reader.GetDecimal(reader.GetOrdinal("TaxAmount"));
            if (!isNull("DiscountDescription", reader)) discountDescription = reader.GetString(reader.GetOrdinal("DiscountDescription"));
            if (!isNull("DiscountAmount", reader)) discountAmount = reader.GetDecimal(reader.GetOrdinal("DiscountAmount"));
            if (!isNull("PaymentType", reader)) paymentType = reader.GetString(reader.GetOrdinal("PaymentType"));
            if (!isNull("Giamgia", reader)) giamgia = reader.GetBoolean(reader.GetOrdinal("Giamgia"));
            if (!isNull("InvoiceVAT", reader)) invoiceVAT = reader.GetBoolean(reader.GetOrdinal("InvoiceVAT"));
            if (!isNull("InvoiceAmount", reader)) invoiceAmount = reader.GetDecimal(reader.GetOrdinal("InvoiceAmount"));
            if (!isNull("PaidDays", reader)) paidDays = reader.GetInt32(reader.GetOrdinal("PaidDays"));
        }
        private bool getFromStockTransaction;
        public bool GetFromStockTransaction
        {
            get { return getFromStockTransaction; }
            set { getFromStockTransaction = value; }
        }
        private Guid accountTransationID;
        public Guid AccountTransationID
        {
            get { return accountTransationID; }
            set { accountTransationID = value; }
        }
        private string stockTransactionTypeCode;
        public string StockTransactionTypeCode
        {
            get { return stockTransactionTypeCode; }
            set { stockTransactionTypeCode = value; }
        }
        private string stockTransactionNo;
        public string StockTransactionNo
        {
            get { return stockTransactionNo; }
            set { stockTransactionNo = value; }
        }
        private DateTime stockTransactionDate = Contexts.WorkingDate;
        public DateTime StockTransactionDate
        {
            get { return stockTransactionDate; }
            set { stockTransactionDate = value; }
        }
        private string tenkho;
        public string Tenkho
        {
            get { return tenkho; }
            set { tenkho = value; }
        }
        private string nguoigiaonhan;
        public string Nguoigiaonhan
        {
            get { return nguoigiaonhan; }
            set { nguoigiaonhan = value; }
        }
        private string donvi;
        public string Donvi
        {
            get { return donvi; }
            set { donvi = value; }
        }
        private string pTVC;
        public string PTVC
        {
            get { return pTVC; }
            set { pTVC = value; }
        }
        private string nguoiVC;
        public string NguoiVC
        {
            get { return nguoiVC; }
            set { nguoiVC = value; }
        }
        private string lydoNX;
        public string LydoNX
        {
            get { return lydoNX; }
            set { lydoNX = value; }
        }
        private string chungtukemtheo;
        public string Chungtukemtheo
        {
            get { return chungtukemtheo; }
            set { chungtukemtheo = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }
        private string donviCode = string.Empty;
        public string DonviCode
        {
            get { return donviCode; }
            set { donviCode = value; }
        }
        private string invoiceMau = string.Empty;
        public string InvoiceMau
        {
            get { return invoiceMau; }
            set { invoiceMau = value; }
        }
        private string invoiceSeri = string.Empty;
        public string InvoiceSeri
        {
            get { return invoiceSeri; }
            set { invoiceSeri = value; }
        }
        private string invoiceSo = string.Empty;
        public string InvoiceSo
        {
            get { return invoiceSo; }
            set { invoiceSo = value; }
        }
        private DateTime invoiceNgay = Contexts.WorkingDate;
        public DateTime InvoiceNgay
        {
            get { return invoiceNgay; }
            set { invoiceNgay = value; }
        }
        private decimal invoiceThuexuat;
        public decimal InvoiceThuexuat
        {
            get { return invoiceThuexuat; }
            set { invoiceThuexuat = value; }
        }
        private decimal beforeTaxAmount;
        public decimal BeforeTaxAmount
        {
            get { return beforeTaxAmount; }
            set { beforeTaxAmount = value; }
        }
        private decimal taxAmount;
        public decimal TaxAmount
        {
            get { return taxAmount; }
            set { taxAmount = value; }
        }
        private string discountDescription=string.Empty;
        public string DiscountDescription
        {
            get { return discountDescription; }
            set { discountDescription = value; }
        }
        private decimal discountAmount;
        public decimal DiscountAmount
        {
            get { return discountAmount; }
            set { discountAmount = value; }
        }
        private string paymentType=string.Empty;
        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        
        private bool giamgia;
        public bool Giamgia
        {
            get { return giamgia; }
            set { giamgia = value; }
        }
        private bool invoiceVAT = true;
        public bool InvoiceVAT
        {
            get { return invoiceVAT; }
            set { invoiceVAT = value; }
        }
        private decimal invoiceAmount;
        public decimal InvoiceAmount
        {
            get { return invoiceAmount; }
            set { invoiceAmount = value; }
        }

        private int paidDays;
        public int PaidDays
        {
            get { return paidDays; }
            set { paidDays = value; }
        }

        private VNS.Common.ListBase<AccountTransactionStockDetail> detail;
        public VNS.Common.ListBase<AccountTransactionStockDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private VNS.Common.ListBase<AccountStock> lstAccountStock;
        public VNS.Common.ListBase<AccountStock> LstAccountStock
        {
            get { return lstAccountStock; }
            set { lstAccountStock = value; }
        }
    }
}
