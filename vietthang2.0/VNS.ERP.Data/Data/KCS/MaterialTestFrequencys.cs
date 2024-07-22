
/************************************************************************
**	ClassName	: 	MaterialTestFrequencys
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	19-02-2008 02:20 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
	#region MaterialTestFrequencys
	/// <summary>
	/// This object represents the properties and methods of a MaterialTestFrequencys.
	/// </summary>
	public class MaterialTestFrequencys : UserTracking2 
	{
			
		
		public MaterialTestFrequencys()
		{
		}
		
		
		
		public MaterialTestFrequencys(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("ItemCode",reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
				if (!isNull("TechCode",reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
				if (!isNull("StartDate",reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
				if (!isNull("FrequencyType",reader)) frequencyType = reader.GetString(reader.GetOrdinal("FrequencyType"));
				if (!isNull("Quantity",reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("QuantityLocal", reader)) quantityLocal = reader.GetDecimal(reader.GetOrdinal("QuantityLocal"));

                //if (!isNull("UserCreated",reader)) userCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                //if (!isNull("DateCreated",reader)) dateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
                //if (!isNull("UserUpdated",reader)) userUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                //if (!isNull("DateUpdated",reader)) dateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
			}
            base.FromDataReader(reader);
		}
		
		#region Public Properties

		
		
		private string itemCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of ItemCode
		/// </summary>
		public string ItemCode
		{
			get {return itemCode;}
			set {itemCode = value;}
		}

		private string techCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of TechCode
		/// </summary>
		public string TechCode
		{
			get {return techCode;}
			set {techCode = value;}
		}

		private DateTime startDate=DateTime.Now;
		/// <summary>
		/// Gets or sets the value of StartDate
		/// </summary>
		public DateTime StartDate
		{
			get {return startDate;}
			set {startDate = value;}
		}

		private string frequencyType = String.Empty;
		/// <summary>
		/// Gets or sets the value of FrequencyType
		/// </summary>
		public string FrequencyType
		{
			get {return frequencyType;}
			set {frequencyType = value;}
		}

		private decimal quantity;
		/// <summary>
		/// Gets or sets the value of Quantity
		/// </summary>
		public decimal Quantity
		{
			get {return quantity;}
			set {quantity = value;}
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

        private decimal quantityLocal;
        /// <summary>
        /// Gets or sets the value of Quantity
        /// </summary>
        public decimal QuantityLocal
        {
            get { return quantityLocal; }
            set { quantityLocal = value; }
        }
		#endregion
		
		#region Lists
		#endregion
		

	}
	#endregion
}	

