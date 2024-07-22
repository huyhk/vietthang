using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class WeightItem:UserTracking2
    {
        const int numStockTransportCode = 6;
        public WeightItem() { }
        public WeightItem(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("WeightID", reader)) _WeightID = reader.GetGuid(reader.GetOrdinal("WeightID"));
                if (!isNull("StockCode", reader)) _StockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("ItemCode", reader)) _ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("WeightCode", reader)) _WeightCode = reader.GetString(reader.GetOrdinal("WeightCode"));
                if (!isNull("EmployeeID", reader)) _EmployeeID = reader.GetString(reader.GetOrdinal("EmployeeID"));
                if (!isNull("TransactionID", reader)) _TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                if (!isNull("WeightDate", reader)) _WeightDate = reader.GetDateTime(reader.GetOrdinal("WeightDate"));
                if (!isNull("IsReceive", reader)) _IsReceive = reader.GetBoolean(reader.GetOrdinal("IsReceive"));
                if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("Quantity", reader)) _Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                if (!isNull("WrappingWeight", reader)) _WrappingWeight = reader.GetDecimal(reader.GetOrdinal("WrappingWeight"));
                if (!isNull("ItemWeight", reader)) _ItemWeight = reader.GetDecimal(reader.GetOrdinal("ItemWeight"));
                if (!isNull("PTVanChuyen", reader)) _PTVanChuyen = reader.GetString(reader.GetOrdinal("PTVanChuyen"));
                if (!isNull("DVVanChuyen", reader)) _DVVanChuyen = reader.GetString(reader.GetOrdinal("DVVanChuyen"));
                if (!isNull("DVGiao", reader)) dvGiao = reader.GetString(reader.GetOrdinal("DVGiao"));
                if (!isNull("DVNhan", reader)) dvNhan = reader.GetString(reader.GetOrdinal("DVNhan"));
                if (!isNull("KhoGiaoNhan", reader)) khoGiaoNhan = reader.GetString(reader.GetOrdinal("KhoGiaoNhan"));
                if (!isNull("PTTayBoa", reader)) _PTTayBoa = reader.GetString(reader.GetOrdinal("PTTayBoa"));
                if (!isNull("TransactionTypeCode", reader)) _TransactionTypeCode = reader.GetString(reader.GetOrdinal("TransactionTypeCode"));
                if (!isNull("StockTransactionNo", reader)) stockTransactionNo = reader.GetString(reader.GetOrdinal("StockTransactionNo"));
                if (!isNull("StockLocationCode", reader)) StockLocationCode = reader.GetString(reader.GetOrdinal("StockLocationCode"));
            }
            base.FromDataReader(reader);
        }
        #region Public Properties
        protected Guid _TransactionID;
        public Guid TransactionID
        {
            get { return _TransactionID; }
            set { _TransactionID = value; }
        }
        protected string _PTVanChuyen;
        public string PTVanChuyen
        {
            get { return _PTVanChuyen; }
            set { _PTVanChuyen = value; }
        }
        protected string _PTTayBoa;
        public string PTTayBoa
        {
            get { return _PTTayBoa; }
            set { _PTTayBoa = value; }
        }
        protected string _DVVanChuyen=string.Empty;
        public string DVVanChuyen
        {
            get { return _DVVanChuyen; }
            set { _DVVanChuyen = value; }
        }
        /// <summary>
        /// Use to Get or set KhoGiaoNhan propertie
        /// </summary>
        private string khoGiaoNhan = string.Empty;
        /// <summary>
        /// KhoGiaoNhan propertie
        /// </summary>
        public string KhoGiaoNhan
        {
            get { return khoGiaoNhan; }
            set { khoGiaoNhan = value; }
        }
        /// <summary>
        /// use to Get or set DVGiao propertie
        /// </summary>
        private string dvGiao = string.Empty;
        /// <summary>
        /// DVGiao propertie
        /// </summary>
        public string DVGiao
        {
            get { return dvGiao; }
            set { dvGiao = value; }
        }
        /// <summary>
        /// use to Get or set DVNhan propertie
        /// </summary>
        private string dvNhan=string.Empty;
        /// <summary>
        /// DVGiao propertie
        /// </summary>
        public string DVNhan
        {
            get { return dvNhan; }
            set { dvNhan = value; }
        }
        protected Guid _WeightID;
        public Guid WeightID
        {
            get { return _WeightID; }
            set { _WeightID = value; }
        }
        protected string _StockCode;
        public string StockCode
        {
            get { return _StockCode; }
            set { _StockCode = value; }
        }
        protected string _ItemCode;
        public string ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }
        protected string _TransactionTypeCode;
        public string TransactionTypeCode
        {
            get { return _TransactionTypeCode; }
            set { _TransactionTypeCode = value; }
        }
        protected string _WeightCode;
        public string WeightCode
        {
            get { return _WeightCode; }
            set { _WeightCode = value; }
        }
        protected string _EmployeeID;
        public string EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        protected DateTime _WeightDate=Contexts.WorkingDate;
        public DateTime WeightDate
        {
            get { return _WeightDate; }
            set { _WeightDate = value; }
        }
        protected bool _IsReceive;
        public bool IsReceive
        {
            get { return _IsReceive; }
            set { _IsReceive = value; }
        }
        protected string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        protected int _Quantity;
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        protected Decimal _WrappingWeight;
        public Decimal WrappingWeight
        {
            get { return _WrappingWeight; }
            set { _WrappingWeight = value; }
        }
        protected Decimal _ItemWeight;
        public Decimal ItemWeight
        {
            get { return _ItemWeight; }
            set { _ItemWeight = value; }
        }
        private string stockTransactionNo = string.Empty;
        public string StockTransactionNo
        {
            get { return stockTransactionNo; }
            set { stockTransactionNo = value; }
        }

        public string StockLocationCode { get; set; }
        #endregion
        private ListBase<WeightItemDetail>[] _lstWeightItemDetail = new ListBase<WeightItemDetail>[numStockTransportCode];
        public ListBase<WeightItemDetail>[] lstWeightItemDetail
        {
            get { return _lstWeightItemDetail; }
            set { _lstWeightItemDetail = value; }
        }
        public ListBase<WeightItemResult> lstWeightItemResult;
    }
}
