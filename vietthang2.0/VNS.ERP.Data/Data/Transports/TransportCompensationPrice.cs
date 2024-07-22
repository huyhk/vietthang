using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Transports
{
    #region TransportCompensationPrice
    /// <summary>
    /// This object represents the properties and methods of a TransportCompensationPrice.
    /// </summary>
    public class TransportCompensationPrice : UserTracking2
    {


        public TransportCompensationPrice()
        {
        }

        public TransportCompensationPrice(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportCompensationPrice(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    compensationID = (obj as TransportCompensationPrice).compensationID;
        //    startDate = (obj as TransportCompensationPrice).startDate;
        //    itemCode = (obj as TransportCompensationPrice).itemCode;
        //    price = (obj as TransportCompensationPrice).price;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("CompensationID", reader)) compensationID = reader.GetGuid(reader.GetOrdinal("CompensationID"));
                if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("CompensationID")) compensationID = (Guid)row["CompensationID"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
        }

        #region Public Properties



        private Guid compensationID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of CompensationID
        /// </summary>
        public Guid CompensationID
        {
            get { return compensationID; }
            set { compensationID = value; }
        }

        private DateTime startDate=Contexts.WorkingDate;
        /// <summary>
        /// Gets or sets the value of StartDate
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
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