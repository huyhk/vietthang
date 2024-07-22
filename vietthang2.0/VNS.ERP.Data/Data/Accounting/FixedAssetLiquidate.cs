
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace VNS.ERP.Data.Accounting
{

    /// <summary>
    /// This object represents the properties and methods of a FixedAssetUpgrade.
    /// </summary>
    public class FixedAssetLiquidate : BaseClass
    {


        public FixedAssetLiquidate()
        {
        }



        public FixedAssetLiquidate(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
                if (!isNull("FixedAssetCode", reader)) fixedAssetCode = reader.GetString(reader.GetOrdinal("FixedAssetCode"));
                if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        #region Public Properties



        protected Guid accountTransactionID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of AccountTransactionID
        /// </summary>
        public Guid AccountTransactionID
        {
            get { return accountTransactionID; }
            set { accountTransactionID = value; }
        }

        protected string fixedAssetCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of FixedAssetCode
        /// </summary>
        public string FixedAssetCode
        {
            get { return fixedAssetCode; }
            set { fixedAssetCode = value; }
        }

        protected DateTime startDate = Contexts.WorkingDate;
        /// <summary>
        /// Gets or sets the value of StartDate
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        protected decimal amount;
        /// <summary>
        /// Gets or sets the value of Amount
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        protected string description = String.Empty;
        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion


    }

}
