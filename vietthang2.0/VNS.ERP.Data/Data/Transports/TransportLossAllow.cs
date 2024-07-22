
/************************************************************************
**	ClassName	: 	TransportLossAllow
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	26-10-2009 11:16 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Transports
{
	#region TransportLossAllow
	/// <summary>
	/// This object represents the properties and methods of a TransportLossAllow.
	/// </summary>
	public class TransportLossAllow : UserTracking2 
	{
			
		public TransportLossAllow()
		{
		}
		
		public TransportLossAllow(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
        public TransportLossAllow(DataRow row)
        {
            this.FromDataRow(row);
        }

		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("AllowID",reader)) allowID = reader.GetGuid(reader.GetOrdinal("AllowID"));
				if (!isNull("StartDate",reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
				if (!isNull("LossAllowRate",reader)) lossAllowRate = reader.GetDecimal(reader.GetOrdinal("LossAllowRate"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
			}
		}

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("AllowID")) allowID = (Guid)row["AllowID"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("LossAllowRate")) lossAllowRate = (decimal)row["LossAllowRate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

		#region Public Properties

		
		
		private Guid allowID = Guid.Empty;
		/// <summary>
		/// Gets or sets the value of AllowID
		/// </summary>
		public Guid AllowID
		{
			get {return allowID;}
			set {allowID = value;}
		}

		private DateTime startDate = Contexts.WorkingDate;
		/// <summary>
		/// Gets or sets the value of StartDate
		/// </summary>
		public DateTime StartDate
		{
			get {return startDate;}
			set {startDate = value;}
		}

		private decimal lossAllowRate;
		/// <summary>
		/// Gets or sets the value of LossAllowRate
		/// </summary>
		public decimal LossAllowRate
		{
			get {return lossAllowRate;}
			set {lossAllowRate = value;}
		}

		private string description = String.Empty;
		/// <summary>
		/// Gets or sets the value of Description
		/// </summary>
		public string Description
		{
			get {return description;}
			set {description = value;}
		}

        //private string serverCreated = String.Empty;
        ///// <summary>
        ///// Gets or sets the value of ServerCreated
        ///// </summary>
        //public string ServerCreated
        //{
        //    get {return serverCreated;}
        //    set {serverCreated = value;}
        //}
		#endregion
		
		#region Lists
        private ListBase<TransportLossAllowTransportType> transportLossAllowTransportTypeList = new ListBase<TransportLossAllowTransportType>();

        public ListBase<TransportLossAllowTransportType> TransportLossAllowTransportTypeList
        {
            get { return transportLossAllowTransportTypeList; }
            set { transportLossAllowTransportTypeList = value; }

        }	

        private ListBase<TransportLossAllowTransportItemType> transportLossAllowTransportItemTypeList = new ListBase<TransportLossAllowTransportItemType>();

        public ListBase<TransportLossAllowTransportItemType> TransportLossAllowTransportItemTypeList
        {
            get { return transportLossAllowTransportItemTypeList; }
            set { transportLossAllowTransportItemTypeList = value; }

        }

        private ListBase<TransportLossAllowItem> transportLossAllowItemList = new ListBase<TransportLossAllowItem>();

        public ListBase<TransportLossAllowItem> TransportLossAllowItemList
        {
            get { return transportLossAllowItemList; }
            set { transportLossAllowItemList = value; }

        }
		
		#endregion
		

	}


	#endregion

    #region TransportLossAllowTransportType
    /// <summary>
    /// This object represents the properties and methods of a TransportContractPriceItem.
    /// </summary>
    public class TransportLossAllowTransportType : ObjectBase
    {
        public TransportLossAllowTransportType()
        {
        }

        public TransportLossAllowTransportType(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportLossAllowTransportType(DataRow row)
        {
            this.FromDataRow(row);
        }

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("AllowID", reader)) allowID = reader.GetGuid(reader.GetOrdinal("AllowID"));
                if (!isNull("TransportType", reader)) transportType = reader.GetString(reader.GetOrdinal("TransportType"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("AllowID")) allowID = (Guid)row["AllowID"];
            if (!row.IsNull("TransportType")) transportType = (string)row["TransportType"];
        }

        #region Public Properties



        private Guid allowID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of PriceID
        /// </summary>
        public Guid AllowID
        {
            get { return allowID; }
            set { allowID = value; }
        }

        private string transportType = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string TransportType
        {
            get { return transportType; }
            set { transportType = value; }
        }
        #endregion


    }
        #endregion

    #region TransportLossAllowTransportItemType
    /// <summary>
    /// This object represents the properties and methods of a TransportContractPriceItem.
    /// </summary>
    public class TransportLossAllowTransportItemType : ObjectBase
    {
        public TransportLossAllowTransportItemType()
        {
        }

        public TransportLossAllowTransportItemType(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportLossAllowTransportItemType(DataRow row)
        {
            this.FromDataRow(row);
        }

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("AllowID", reader)) allowID = reader.GetGuid(reader.GetOrdinal("AllowID"));
                if (!isNull("TransportItemType", reader)) transportItemType = reader.GetString(reader.GetOrdinal("TransportItemType"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("AllowID")) allowID = (Guid)row["AllowID"];
            if (!row.IsNull("TransportItemType")) transportItemType = (string)row["TransportItemType"];
        }

        #region Public Properties



        private Guid allowID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of PriceID
        /// </summary>
        public Guid AllowID
        {
            get { return allowID; }
            set { allowID = value; }
        }

        private string transportItemType = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string TransportItemType
        {
            get { return transportItemType; }
            set { transportItemType = value; }
        }
        #endregion


    }
    #endregion

    #region TransportLossAllowItem
    /// <summary>
    /// This object represents the properties and methods of a TransportContractPriceItem.
    /// </summary>
    public class TransportLossAllowItem : ObjectBase
    {


        public TransportLossAllowItem()
        {
        }

        public TransportLossAllowItem(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportLossAllowItem(DataRow row)
        {
            this.FromDataRow(row);
        }

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("AllowID", reader)) allowID = reader.GetGuid(reader.GetOrdinal("AllowID"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("AllowID")) allowID = (Guid)row["AllowID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
        }

        #region Public Properties



        private Guid allowID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of PriceID
        /// </summary>
        public Guid AllowID
        {
            get { return allowID; }
            set { allowID = value; }
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
        #endregion


    }
    #endregion

}	

