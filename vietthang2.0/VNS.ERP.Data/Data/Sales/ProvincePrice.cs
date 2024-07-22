using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common;
//namespace VNS.ERP.Data.Data.Sales
//{
//    class ProvincePrice
//    {
//    }
//}


namespace VNS.ERP.Data.Sales
{
    #region ProvincePrice
    /// <summary>
    /// This object represents the properties and methods of a ProvincePrice.
    /// </summary>
    public class ProvincePrice : UserTracking2
    {


        public ProvincePrice()
        {
        }

        public ProvincePrice(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public ProvincePrice(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    priceID = (obj as CustomerPriceType).priceID;
        //    subjectCode = (obj as CustomerPriceType).subjectCode;
        //    startDate = (obj as CustomerPriceType).startDate;
        //    specialPrice = (obj as CustomerPriceType).specialPrice;
        //    description = (obj as CustomerPriceType).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PriceID", reader)) priceID = reader.GetGuid(reader.GetOrdinal("PriceID"));
                if (!isNull("ProvinceCode", reader)) provinceCode = reader.GetString(reader.GetOrdinal("ProvinceCode"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("ProductType", reader)) productType = reader.GetString(reader.GetOrdinal("ProductType"));
                if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("ProvinceCode")) provinceCode = (string)row["ProvinceCode"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("ProductType")) productType = (string)row["ProductType"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("Amount")) amount = (decimal)row["Amount"];
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

        private string provinceCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ProvinceCode
        /// </summary>
        public string ProvinceCode
        {
            get { return provinceCode; }
            set { provinceCode = value; }
        }

        private string stockCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ProvinceCode
        /// </summary>
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }

        private string productType = String.Empty;
        /// <summary>
        /// Gets or sets the value of ProductType
        /// </summary>
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
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
