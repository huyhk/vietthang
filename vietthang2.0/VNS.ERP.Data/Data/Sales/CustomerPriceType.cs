using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    #region CustomerPriceType
    /// <summary>
    /// This object represents the properties and methods of a CustomerPriceType.
    /// </summary>
    public class CustomerPriceType : UserTracking2
    {


        public CustomerPriceType()
        {
        }

        public CustomerPriceType(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public CustomerPriceType(DataRow row)
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
                if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("SpecialPrice", reader)) specialPrice = reader.GetBoolean(reader.GetOrdinal("SpecialPrice"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("SpecialPrice")) specialPrice = (bool)row["SpecialPrice"];
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

        private string subjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of SubjectCode
        /// </summary>
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
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

        private bool specialPrice;
        /// <summary>
        /// Gets or sets the value of SpecialPrice
        /// </summary>
        public bool SpecialPrice
        {
            get { return specialPrice; }
            set { specialPrice = value; }
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