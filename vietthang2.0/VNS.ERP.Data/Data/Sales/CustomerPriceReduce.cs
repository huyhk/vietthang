using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    #region CustomerPriceReduce
    /// <summary>
    /// This object represents the properties and methods of a CustomerPriceReduce.
    /// </summary>
    public class CustomerPriceReduce : UserTracking2
    {


        public CustomerPriceReduce()
        {
        }

        public CustomerPriceReduce(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public CustomerPriceReduce(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    priceID = (obj as CustomerPriceReduce).priceID;
        //    startDate = (obj as CustomerPriceReduce).startDate;
        //    subjectCode = (obj as CustomerPriceReduce).subjectCode;
        //    stockCode = (obj as CustomerPriceReduce).stockCode;
        //    reduceAmount = (obj as CustomerPriceReduce).reduceAmount;
        //    description = (obj as CustomerPriceReduce).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PriceID", reader)) priceID = reader.GetGuid(reader.GetOrdinal("PriceID"));
                if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("ReduceAmount", reader)) reduceAmount = reader.GetDecimal(reader.GetOrdinal("ReduceAmount"));
                if (!isNull("ReduceAmountNoTax", reader)) reduceAmountNoTax = reader.GetDecimal(reader.GetOrdinal("ReduceAmountNoTax"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("ReduceAmount")) reduceAmount = (decimal)row["ReduceAmount"];
            if (!row.IsNull("ReduceAmountNoTax")) reduceAmountNoTax = (decimal)row["ReduceAmountNoTax"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        #region Public Properties



        private Guid priceID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of PriceID
        /// </summary>
        public Guid PriceID
        {
            get { return priceID; }
            set { priceID = value; }
        }

        private DateTime startDate = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of StartDate
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
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

        private string stockCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockCode
        /// </summary>
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }

        private decimal reduceAmount;
        /// <summary>
        /// Gets or sets the value of ReduceAmount
        /// </summary>
        public decimal ReduceAmount
        {
            get { return reduceAmount; }
            set
            {
                reduceAmount = value;
                //reduceAmountNoTax = 0;
            }
        }

        private decimal reduceAmountNoTax;
        /// <summary>
        /// Gets or sets the value of ReduceAmountNoTax
        /// </summary>
        public decimal ReduceAmountNoTax
        {
            get { return reduceAmountNoTax; }
            set
            {
                reduceAmountNoTax = value;
                //reduceAmount = 0;
            }
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

        #endregion

        #region Lists
        #endregion


    }
    #endregion
}