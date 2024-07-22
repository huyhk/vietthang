
/************************************************************************
**	ClassName	: 	ToBocxep
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-08-2008 11:44 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
	#region ToBocxep
	/// <summary>
	/// This object represents the properties and methods of a ToBocxep.
	/// </summary>
	public class ToBocxep : UserTracking2 
	{
			
		
		public ToBocxep()
		{
		}
		public ToBocxep(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("ToBocxepCode",reader)) toBocxepCode = reader.GetString(reader.GetOrdinal("ToBocxepCode"));
				if (!isNull("ToBocxepName",reader)) toBocxepName = reader.GetString(reader.GetOrdinal("ToBocxepName"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
				if (!isNull("SubjectCode",reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
			}
		}
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("ToBocxepCode")) toBocxepCode = (string)row["ToBocxepCode"];
			if (!row.IsNull("ToBocxepName")) toBocxepName = (string)row["ToBocxepName"];
			if (!row.IsNull("Description")) description = (string)row["Description"];
			if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
		}
		#region Public Properties
		
		private string toBocxepCode = String.Empty;
		public string ToBocxepCode
		{
			get {return toBocxepCode;}
			set {toBocxepCode = value;}
		}

		private string toBocxepName = String.Empty;
		public string ToBocxepName
		{
			get {return toBocxepName;}
			set {toBocxepName = value;}
		}

		private string description = String.Empty;
		public string Description
		{
			get {return description;}
			set {description = value;}
		}

		private string subjectCode = String.Empty;
		public string SubjectCode
		{
			get {return subjectCode;}
			set {subjectCode = value;}
		}
		#endregion
		
		#region Lists
		#endregion
		

	}
	#endregion
}	

