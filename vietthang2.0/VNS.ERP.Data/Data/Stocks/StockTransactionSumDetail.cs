using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class StockTransactionSumDetail : BaseClass
    {
        public StockTransactionSumDetail(DataRow row)
        {
            this.FromDataRow(row);
        }
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("TransactionID")) _TransactionID = (Guid)row["TransactionID"];
            if (!row.IsNull("ItemCode")) _ItemCode = (string)row["ItemCode"];
            if (!row.IsNull("Quantity")) _Quantity = (decimal)row["Quantity"];
            if (!row.IsNull("QuantityReg")) _QuantityReg = (decimal)row["QuantityReg"];
            if (!row.IsNull("QuantityInclWrapping")) _QuantityInclWrapping = (decimal)row["QuantityInclWrapping"];
            if (!row.IsNull("WrappingCounter")) _WrappingCounter = (int)row["WrappingCounter"];
            if (!row.IsNull("PriceCost")) _PriceCost = (decimal)row["PriceCost"];
            if (!row.IsNull("AmountCost")) _AmountCost = (decimal)row["AmountCost"];
            if (!row.IsNull("PriceIn")) _PriceIn = (decimal)row["PriceIn"];
            if (!row.IsNull("AmountIn")) _AmountIn = (decimal)row["AmountIn"];
            if (!row.IsNull("PriceOut")) _PriceOut = (decimal)row["PriceOut"];
            if (!row.IsNull("AmountOut")) _AmountOut = (decimal)row["AmountOut"];
            //if (!row.IsNull("SLThucnhan")) _ = (decimal)row["SLThucnhan"];
        }
        public StockTransactionSumDetail() 
        {
            //lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
            //_lstStockTransactionDetail.ListChanged += new System.ComponentModel.ListChangedEventHandler(lstStockTransactionDetail_ListChanged);
        }

        //void lstStockTransactionDetail_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        //{
        //    //throw new Exception("The method or operation is not implemented.");
        //    this.Quantity = 0;
        //    foreach (StockTransactionDetail std in lstStockTransactionDetail)
        //    {
        //        this.Quantity += std.Quantity;
        //    }
        //}
        public StockTransactionSumDetail(System.Data.IDataReader reader)
        {
           // _lstStockTransactionDetail.ListChanged += new System.ComponentModel.ListChangedEventHandler(lstStockTransactionDetail_ListChanged);
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TransactionID", reader)) _TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                if (!isNull("ItemCode", reader)) _ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Quantity", reader)) _Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("QuantityReg", reader)) _QuantityReg = reader.GetDecimal(reader.GetOrdinal("QuantityReg"));
                if (!isNull("QuantityInclWrapping", reader)) _QuantityInclWrapping = reader.GetDecimal(reader.GetOrdinal("QuantityInclWrapping"));
                if (!isNull("WrappingCounter", reader)) _WrappingCounter = reader.GetInt32(reader.GetOrdinal("WrappingCounter"));
                if (!isNull("PriceCost", reader)) _PriceCost = reader.GetDecimal(reader.GetOrdinal("PriceCost"));
                if (!isNull("AmountCost", reader)) _AmountCost = reader.GetDecimal(reader.GetOrdinal("AmountCost"));
                if (!isNull("PriceIn", reader)) _PriceIn = reader.GetDecimal(reader.GetOrdinal("PriceIn"));
                if (!isNull("AmountIn", reader)) _AmountIn = reader.GetDecimal(reader.GetOrdinal("AmountIn"));
                if (!isNull("PriceOut", reader)) _PriceOut = reader.GetDecimal(reader.GetOrdinal("PriceOut"));
                if (!isNull("AmountOut", reader)) _AmountOut = reader.GetDecimal(reader.GetOrdinal("AmountOut"));
            }
            base.FromDataReader(reader);
        }
        //public override void LoadFromReader(DbDataReader reader)
        //{
        //    if (reader != null && !reader.IsClosed)
        //    {
        //        if (!CheckNull("TransactionID", reader)) _TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
        //        if (!CheckNull("ItemCode", reader)) _ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
        //        if (!CheckNull("InLocation", reader)) _InLocation = reader.GetString(reader.GetOrdinal("InLocation"));
        //        if (!CheckNull("OutLocation", reader)) _OutLocation = reader.GetString(reader.GetOrdinal("OutLocation"));
        //        if (!CheckNull("Quantity", reader)) _Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
        //    }
        //    base.LoadFromReader(reader);
        //}
        protected Guid _TransactionID;
        public Guid TransactionID
        {
            get { return _TransactionID; }
            set { _TransactionID = value; }
        }
        protected string _ItemCode;
        public string ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }
        protected decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set 
            { 
                _Quantity = value;
                AmountOut = Math.Round(_Quantity * _PriceOut, 0, MidpointRounding.AwayFromZero);
                AmountIn = Math.Round(_Quantity * _PriceIn, 0, MidpointRounding.AwayFromZero);
            }
        }
        protected decimal _QuantityReg;
        public decimal QuantityReg
        {
            get { return _QuantityReg; }
            set { _QuantityReg = value; }
        }
        protected decimal _QuantityInclWrapping;
        public decimal QuantityInclWrapping
        {
            get { return _QuantityInclWrapping; }
            set { _QuantityInclWrapping = value; }
        }
        protected Int32 _WrappingCounter;
        public Int32 WrappingCounter
        {
            get { return _WrappingCounter; }
            set { _WrappingCounter = value; }
        }
        protected decimal _PriceCost;
        public decimal PriceCost
        {
            get { return _PriceCost; }
            set { _PriceCost = value; }
        }
        protected decimal _AmountCost;
        public decimal AmountCost
        {
            get { return _AmountCost; }
            set { _AmountCost = value; }
        }
        protected decimal _PriceIn;
        public decimal PriceIn
        {
            get { return _PriceIn; }
            set 
            {
                _PriceIn = value;
                AmountIn = Math.Round(_PriceIn * _Quantity, 0, MidpointRounding.AwayFromZero);
            }
        }
        protected decimal _AmountIn;
        public decimal AmountIn
        {
            get { return _AmountIn; }
            set { _AmountIn = value; }
        }
        protected decimal _PriceOut;
        public decimal PriceOut
        {
            get { return _PriceOut; }
            set 
            { 
                _PriceOut = value;
                AmountOut = Math.Round(_PriceOut * _Quantity, 0, MidpointRounding.AwayFromZero);
            }
        }
        protected decimal _AmountOut;
        public decimal AmountOut
        {
            get { return _AmountOut; }
            set { _AmountOut = value; }
        }
        protected ListBase<StockTransactionDetail> _lstStockTransactionDetail= new ListBase<StockTransactionDetail>();
        public ListBase<StockTransactionDetail> lstStockTransactionDetail
        {
            get { return _lstStockTransactionDetail; }
            set { _lstStockTransactionDetail = value; }
        }
        protected ListBase<StockTransactionPurchaseDetail> listPurchaseDetail = new ListBase<StockTransactionPurchaseDetail>();
        public ListBase<StockTransactionPurchaseDetail> ListPurchaseDetail
        {
            get { return listPurchaseDetail; }
            set { listPurchaseDetail = value; }
        }
    }
}