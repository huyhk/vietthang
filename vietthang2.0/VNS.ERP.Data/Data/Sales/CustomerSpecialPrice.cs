using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    #region CustomerSpecialPrice
    /// <summary>
    /// This object represents the properties and methods of a CustomerSpecialPrice.
    /// </summary>
    public class CustomerSpecialPrice : UserTracking2
    {


        public CustomerSpecialPrice()
        {
        }

        public CustomerSpecialPrice(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public CustomerSpecialPrice(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    priceID = (obj as CustomerSpecialPrice).priceID;
        //    startDate = (obj as CustomerSpecialPrice).startDate;
        //    subjectCode = (obj as CustomerSpecialPrice).subjectCode;
        //    description = (obj as CustomerSpecialPrice).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PriceID", reader)) priceID = reader.GetGuid(reader.GetOrdinal("PriceID"));
                if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
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
        private ListBase<CustomerSpecialPriceDetail> listCustomerSpecialPriceDetail = new ListBase<CustomerSpecialPriceDetail>();

        public ListBase<CustomerSpecialPriceDetail> ListCustomerSpecialPriceDetail
        {
            get { return listCustomerSpecialPriceDetail; }
            set { listCustomerSpecialPriceDetail = value; }

        }

        #endregion


    }
    #endregion

    #region CustomerSpecialPriceDetail
    /// <summary>
    /// This object represents the properties and methods of a CustomerSpecialPriceDetail.
    /// </summary>
    public class CustomerSpecialPriceDetail : ObjectBase
    {


        public CustomerSpecialPriceDetail()
        {
        }

        public CustomerSpecialPriceDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public CustomerSpecialPriceDetail(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    priceID = (obj as CustomerSpecialPriceDetail).priceID;
        //    itemCode = (obj as CustomerSpecialPriceDetail).itemCode;
        //    price = (obj as CustomerSpecialPriceDetail).price;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PriceID", reader)) priceID = reader.GetGuid(reader.GetOrdinal("PriceID"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
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

        private string itemCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
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
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}