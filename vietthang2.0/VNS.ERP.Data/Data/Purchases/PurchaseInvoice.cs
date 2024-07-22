using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region PurchaseInvoice
    /// <summary>
    /// This object represents the properties and methods of a PurchaseInvoice.
    /// </summary>
    public class PurchaseInvoice : UserTracking
    {


        public PurchaseInvoice()
        {
        }

        public PurchaseInvoice(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public PurchaseInvoice(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    invoiceID = (obj as PurchaseInvoice).invoiceID;
        //    invoiceNo = (obj as PurchaseInvoice).invoiceNo;
        //    invoiceDate = (obj as PurchaseInvoice).invoiceDate;
        //    invoiceSeri = (obj as PurchaseInvoice).invoiceSeri;
        //    subjectCode = (obj as PurchaseInvoice).subjectCode;
        //    currencyCode = (obj as PurchaseInvoice).currencyCode;
        //    goodAmount = (obj as PurchaseInvoice).goodAmount;
        //    taxRate = (obj as PurchaseInvoice).taxRate;
        //    taxAmount = (obj as PurchaseInvoice).taxAmount;
        //    invoiceAmount = (obj as PurchaseInvoice).invoiceAmount;
        //    description = (obj as PurchaseInvoice).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("InvoiceID", reader)) invoiceID = reader.GetGuid(reader.GetOrdinal("InvoiceID"));
                if (!isNull("InvoiceNo", reader)) invoiceNo = reader.GetString(reader.GetOrdinal("InvoiceNo"));
                if (!isNull("InvoiceDate", reader)) invoiceDate = reader.GetDateTime(reader.GetOrdinal("InvoiceDate"));
                if (!isNull("InvoiceSeri", reader)) invoiceSeri = reader.GetString(reader.GetOrdinal("InvoiceSeri"));
                if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("CurrencyCode", reader)) currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
                if (!isNull("GoodAmount", reader)) goodAmount = reader.GetDecimal(reader.GetOrdinal("GoodAmount"));
                if (!isNull("TaxRate", reader)) taxRate = reader.GetDecimal(reader.GetOrdinal("TaxRate"));
                if (!isNull("TaxAmount", reader)) taxAmount = reader.GetDecimal(reader.GetOrdinal("TaxAmount"));
                if (!isNull("InvoiceAmount", reader)) invoiceAmount = reader.GetDecimal(reader.GetOrdinal("InvoiceAmount"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));

                if (!isNull("NgayCongno", reader)) ngayCongno = reader.GetInt32(reader.GetOrdinal("NgayCongno"));
                if (!isNull("NgayThanhtoan", reader))
                { 
                    ngayThanhtoan = reader.GetDateTime(reader.GetOrdinal("NgayThanhtoan"));
                    dathanhtoan = true;
                }
                if (!isNull("Nganhang", reader)) nganhang = reader.GetString(reader.GetOrdinal("Nganhang"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("InvoiceID")) invoiceID = (Guid)row["InvoiceID"];
            if (!row.IsNull("InvoiceNo")) invoiceNo = (string)row["InvoiceNo"];
            if (!row.IsNull("InvoiceDate")) invoiceDate = (DateTime)row["InvoiceDate"];
            if (!row.IsNull("InvoiceSeri")) invoiceSeri = (string)row["InvoiceSeri"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("CurrencyCode")) currencyCode = (string)row["CurrencyCode"];
            if (!row.IsNull("GoodAmount")) goodAmount = (decimal)row["GoodAmount"];
            if (!row.IsNull("TaxRate")) taxRate = (decimal)row["TaxRate"];
            if (!row.IsNull("TaxAmount")) taxAmount = (decimal)row["TaxAmount"];
            if (!row.IsNull("InvoiceAmount")) invoiceAmount = (decimal)row["InvoiceAmount"];
            if (!row.IsNull("Description")) description = (string)row["Description"];

            if (!row.IsNull("NgayCongno")) ngayCongno = (Int32)row["NgayCongno"];
            if (!row.IsNull("NgayThanhtoan"))
            {
                ngayThanhtoan = (DateTime)row["NgayThanhtoan"];
                dathanhtoan = true;
            }
            if (!row.IsNull("Nganhang")) nganhang = (string)row["Nganhang"];
        }

        #region Public Properties



        private Guid invoiceID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of InvoiceID
        /// </summary>
        public Guid InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }

        private string invoiceNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of InvoiceNo
        /// </summary>
        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }

        private DateTime invoiceDate = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of InvoiceDate
        /// </summary>
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }

        private string invoiceSeri = String.Empty;
        /// <summary>
        /// Gets or sets the value of InvoiceSeri
        /// </summary>
        public string InvoiceSeri
        {
            get { return invoiceSeri; }
            set { invoiceSeri = value; }
        }

        private string subjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of SubjectCode
        /// </summary>
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        private string currencyCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of CurrencyCode
        /// </summary>
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }

        private decimal goodAmount;
        /// <summary>
        /// Gets or sets the value of GoodAmount
        /// </summary>
        public decimal GoodAmount
        {
            get { return goodAmount; }
            set
            {
                goodAmount = value;
                TaxAmount = Math.Round(goodAmount * taxRate, 0, MidpointRounding.AwayFromZero);
            }
        }

        private decimal taxRate = 0.05M;
        /// <summary>
        /// Gets or sets the value of TaxRate
        /// </summary>
        public decimal TaxRate
        {
            get { return taxRate; }
            set
            {
                taxRate = value;
                TaxAmount = Math.Round(goodAmount * taxRate, 0, MidpointRounding.AwayFromZero);
            }
        }

        private decimal taxAmount;
        /// <summary>
        /// Gets or sets the value of TaxAmount
        /// </summary>
        public decimal TaxAmount
        {
            get { return taxAmount; }
            set
            {
                taxAmount = value;
                invoiceAmount = goodAmount + taxAmount;
            }
        }

        private decimal invoiceAmount;
        /// <summary>
        /// Gets or sets the value of InvoiceAmount
        /// </summary>
        public decimal InvoiceAmount
        {
            get { return invoiceAmount; }
            set { invoiceAmount = value; }
        }

        private string description = String.Empty;
        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int ngayCongno;

        public int NgayCongno
        {
            get { return ngayCongno; }
            set { ngayCongno = value; }
        }
        public DateTime NgayHantra
        { get { return InvoiceDate.AddDays((Double)ngayCongno); } }

        private DateTime ngayThanhtoan = DateTime.Today;

        public DateTime NgayThanhtoan
        {
            get { return ngayThanhtoan; }
            set { ngayThanhtoan = value; }
        }

        private Boolean dathanhtoan;

        public Boolean Dathanhtoan
        {
            get { return dathanhtoan; }
            set { dathanhtoan = value; }
        }
	

        private string nganhang = string.Empty;

        public string Nganhang
        {
            get { return nganhang; }
            set { nganhang = value; }
        }

	
	
        #endregion

        #region Lists
        private ListBase<PurchaseInvoiceDetail> listPurchaseInvoiceDetail = new ListBase<PurchaseInvoiceDetail>();

        public ListBase<PurchaseInvoiceDetail> ListPurchaseInvoiceDetail
        {
            get { return listPurchaseInvoiceDetail; }
            set { listPurchaseInvoiceDetail = value; }

        }

        private static DataTable detailInvoiceSt;
        public static DataTable DetailInvoiceSt
        {
            get
            {
                if (detailInvoiceSt == null)
                {
                    detailInvoiceSt = new DataTable();
                    detailInvoiceSt.Columns.Add("ItemCode", typeof(string));
                    detailInvoiceSt.Columns.Add("Quantity", typeof(decimal));
                    detailInvoiceSt.Columns.Add("Price", typeof(decimal));
                    detailInvoiceSt.Columns.Add("Amount", typeof(decimal));
                }
                return detailInvoiceSt;
            }
        }
        private DataTable detailInvoice;

        public DataTable DetailInvoice
        {
            get
            {
                if (detailInvoice == null)
                {
                    detailInvoice = DetailInvoiceSt.Clone();
                    UpdateDetailInvoice();
                }
                return detailInvoice;
            }
            set { detailInvoice = value; }
        }
        public void UpdateDetailInvoice()
        {
            DetailInvoice.Clear();
            foreach (PurchaseInvoiceDetail d in this.listPurchaseInvoiceDetail)
            {
                bool flag = false;
                foreach (DataRow row in DetailInvoice.Rows)
                {
                    if (row["ItemCode"].ToString() == d.ItemCode && (decimal)row["Price"] == d.Price)
                    {
                        flag = true;
                        row["Quantity"] = (decimal)row["Quantity"] + d.Quantity;
                        row["Amount"] = (decimal)row["Amount"] + d.Amount;
                        break;
                    }
                }
                if (!flag)
                {
                    DataRow row = DetailInvoice.NewRow();
                    row["ItemCode"] = d.ItemCode;
                    row["Quantity"] = d.Quantity;
                    row["Price"] = d.Price;
                    row["Amount"] = d.Amount;
                    DetailInvoice.Rows.Add(row);
                }
            }
        }
        public void UpdateGoodAmount()
        {
            decimal gAmount = 0;
            foreach (PurchaseInvoiceDetail d in this.listPurchaseInvoiceDetail)
                gAmount += d.Amount;
            this.GoodAmount = gAmount;
        }
        #endregion


    }
    #endregion

    #region PurchaseInvoiceDetail
    /// <summary>
    /// This object represents the properties and methods of a PurchaseInvoiceDetail.
    /// </summary>
    public class PurchaseInvoiceDetail : BaseClass
    {


        public PurchaseInvoiceDetail()
        {
        }

        public PurchaseInvoiceDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public PurchaseInvoiceDetail(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    invoiceID = (obj as PurchaseInvoiceDetail).invoiceID;
        //    stockTransactionNo = (obj as PurchaseInvoiceDetail).stockTransactionNo;
        //    purchaseContractNo = (obj as PurchaseInvoiceDetail).purchaseContractNo;
        //    stockCode = (obj as PurchaseInvoiceDetail).stockCode;
        //    itemCode = (obj as PurchaseInvoiceDetail).itemCode;
        //    quantity = (obj as PurchaseInvoiceDetail).quantity;
        //    price = (obj as PurchaseInvoiceDetail).price;
        //    amount = (obj as PurchaseInvoiceDetail).amount;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("InvoiceID", reader)) invoiceID = reader.GetGuid(reader.GetOrdinal("InvoiceID"));
                if (!isNull("StockTransactionNo", reader)) stockTransactionNo = reader.GetString(reader.GetOrdinal("StockTransactionNo"));
                if (!isNull("StockTransactionDate", reader)) stockTransactionDate = reader.GetDateTime(reader.GetOrdinal("StockTransactionDate"));
                if (!isNull("PurchaseContractNo", reader)) purchaseContractNo = reader.GetString(reader.GetOrdinal("PurchaseContractNo"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("InvoiceID")) invoiceID = (Guid)row["InvoiceID"];
            if (!row.IsNull("StockTransactionNo")) stockTransactionNo = (string)row["StockTransactionNo"];
            if (!row.IsNull("StockTransactionDate")) stockTransactionDate = (DateTime)row["StockTransactionDate"];
            if (!row.IsNull("PurchaseContractNo")) purchaseContractNo = (string)row["PurchaseContractNo"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
            if (!row.IsNull("Amount")) amount = (decimal)row["Amount"];
        }

        #region Public Properties



        private Guid invoiceID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of InvoiceID
        /// </summary>
        public Guid InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }

        private string stockTransactionNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockTransactionNo
        /// </summary>
        public string StockTransactionNo
        {
            get { return stockTransactionNo; }
            set { stockTransactionNo = value; }
        }

        private DateTime stockTransactionDate = DateTime.Today;

        public DateTime StockTransactionDate
        {
            get { return stockTransactionDate; }
            set { stockTransactionDate = value; }
        }

        private string purchaseContractNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of PurchaseContractNo
        /// </summary>
        public string PurchaseContractNo
        {
            get { return purchaseContractNo; }
            set { purchaseContractNo = value; }
        }

        private string stockCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockCode
        /// </summary>
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }

        private string itemCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        private decimal quantity;
        /// <summary>
        /// Gets or sets the value of Quantity
        /// </summary>
        public decimal Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                amount = Math.Round(quantity * price, 0, MidpointRounding.AwayFromZero);
            }
        }

        private decimal price;
        /// <summary>
        /// Gets or sets the value of Price
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private decimal amount;
        /// <summary>
        /// Gets or sets the value of Amount
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}