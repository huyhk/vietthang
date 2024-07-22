
/************************************************************************
**	ClassName	: 	TechnicalTestPrice
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	19-02-2008 11:36 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
	#region TechnicalTestPrice
	/// <summary>
	/// This object represents the properties and methods of a TechnicalTestPrice.
	/// </summary>
	public class TechnicalTestPrice : UserTracking2 
	{
		public TechnicalTestPrice()
		{
		}
		
		public TechnicalTestPrice(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("SubjectCode",reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
				if (!isNull("StartDate",reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
				if (!isNull("TechCode",reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
				if (!isNull("Price",reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                //if (!isNull("UserCreated",reader)) userCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                //if (!isNull("DateCreated",reader)) dateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
                //if (!isNull("UserUpdated",reader)) userUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                //if (!isNull("DateUpdated",reader)) dateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
			}
            base.FromDataReader(reader);
		}
		
		#region Public Properties

		
		
		private string subjectCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of SubjectCode
		/// </summary>
		public string SubjectCode
		{
			get {return subjectCode;}
			set {subjectCode = value;}
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

		private string techCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of TechCode
		/// </summary>
		public string TechCode
		{
			get {return techCode;}
			set {techCode = value;}
		}

		private decimal price;
		/// <summary>
		/// Gets or sets the value of Price
		/// </summary>
		public decimal Price
		{
			get {return price;}
			set {price = value;}
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

		
		#endregion
		
		#region Lists
		#endregion
		

	}
	#endregion
}	

