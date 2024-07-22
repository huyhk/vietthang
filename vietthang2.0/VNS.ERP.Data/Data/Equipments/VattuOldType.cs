
/************************************************************************
**	ClassName	: 	VattuOldType
**	Author		:	Cohim2000
**	Company		:	VNS
**	Date		:	09-07-2008 04:44 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Equipments
{
	#region VattuOldType
	/// <summary>
	/// This object represents the properties and methods of a VattuOldType.
	/// </summary>
	public class VattuOldType : UserTracking2 
	{
			
		
		public VattuOldType()
		{
		}
		
		public VattuOldType(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);
			
        //    typeCode = (obj as VattuOldType).typeCode;
        //    typeName = (obj as VattuOldType).typeName;
        //    description = (obj as VattuOldType).description;
        //    userCreated = (obj as VattuOldType).userCreated;
        //    userUpdated = (obj as VattuOldType).userUpdated;
        //    serverCreated = (obj as VattuOldType).serverCreated;

        //}
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("TypeCode",reader)) typeCode = reader.GetString(reader.GetOrdinal("TypeCode"));
				if (!isNull("TypeName",reader)) typeName = reader.GetString(reader.GetOrdinal("TypeName"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
			
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("TypeCode")) typeCode = (string)row["TypeCode"];
			if (!row.IsNull("TypeName")) typeName = (string)row["TypeName"];
			if (!row.IsNull("Description")) description = (string)row["Description"];
			
		}
		
		#region Public Properties

		
		
		private string typeCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of TypeCode
		/// </summary>
		public string TypeCode
		{
			get {return typeCode;}
			set {typeCode = value;}
		}

		private string typeName = String.Empty;
		/// <summary>
		/// Gets or sets the value of TypeName
		/// </summary>
		public string TypeName
		{
			get {return typeName;}
			set {typeName = value;}
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

