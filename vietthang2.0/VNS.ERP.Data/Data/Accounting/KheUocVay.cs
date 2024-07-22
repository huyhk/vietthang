
/************************************************************************
**	ClassName	: 	Kheuocvay
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	05-12-2009 11:23 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.Data.Accounting
{
	#region Kheuocvay
	/// <summary>
	/// This object represents the properties and methods of a Kheuocvay.
	/// </summary>
	public class KheUocVay : UserTracking2 
	{
		
		public KheUocVay()
		{
		}

        public KheUocVay(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("VayID",reader)) vayID = reader.GetGuid(reader.GetOrdinal("VayID"));
				if (!isNull("VayNo",reader)) vayNo = reader.GetString(reader.GetOrdinal("VayNo"));
				if (!isNull("VayDate",reader)) vayDate = reader.GetDateTime(reader.GetOrdinal("VayDate"));
				if (!isNull("AccountCode",reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
				if (!isNull("SubjectCode",reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
				if (!isNull("VayRate",reader)) vayRate = reader.GetDecimal(reader.GetOrdinal("VayRate"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
				if (!isNull("IsFinished",reader)) isFinished = reader.GetBoolean(reader.GetOrdinal("IsFinished"));
			}
		}
		
		#region Public Properties
		private Guid vayID = Guid.Empty;
		/// <summary>
		/// Gets or sets the value of VayID
		/// </summary>
		public Guid VayID
		{
			get {return vayID;}
			set {vayID = value;}
		}

		private string vayNo = String.Empty;
		/// <summary>
		/// Gets or sets the value of VayNo
		/// </summary>
		public string VayNo
		{
			get {return vayNo;}
			set {vayNo = value;}
		}

		private DateTime vayDate = Contexts.WorkingDate;
		/// <summary>
		/// Gets or sets the value of VayDate
		/// </summary>
		public DateTime VayDate
		{
			get {return vayDate;}
			set {vayDate = value;}
		}

		private string accountCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of AccountCode
		/// </summary>
		public string AccountCode
		{
			get {return accountCode;}
			set {accountCode = value;}
		}

		private string subjectCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of SubjectCode
		/// </summary>
		public string SubjectCode
		{
			get {return subjectCode;}
			set {subjectCode = value;}
		}

		private decimal vayRate;
		/// <summary>
		/// Gets or sets the value of VayRate
		/// </summary>
		public decimal VayRate
		{
			get {return vayRate;}
			set {vayRate = value;}
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

		private bool isFinished;
		/// <summary>
		/// Gets or sets the value of IsFinished
		/// </summary>
		public bool IsFinished
		{
			get {return isFinished;}
			set {isFinished = value;}
		}
		#endregion

	}
	#endregion
}	

