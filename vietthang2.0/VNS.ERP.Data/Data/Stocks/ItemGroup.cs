
/************************************************************************
**	ClassName	: 	ItemGroup
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-07-2009 10:28 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
	#region ItemGroup
	/// <summary>
	/// This object represents the properties and methods of a ItemGroup.
	/// </summary>
	public class ItemGroup : UserTracking 
	{
			
		
		public ItemGroup()
		{
		}
		
		public ItemGroup(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("GroupCode",reader)) groupCode = reader.GetString(reader.GetOrdinal("GroupCode"));
				if (!isNull("GroupName",reader)) groupName = reader.GetString(reader.GetOrdinal("GroupName"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));

                if (!isNull("Masapxep", reader)) masapxep = reader.GetString(reader.GetOrdinal("Masapxep"));
			}
		}
		#region Public Properties

		
		
		private string groupCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of GroupCode
		/// </summary>
		public string GroupCode
		{
			get {return groupCode;}
			set {groupCode = value;}
		}

		private string groupName = String.Empty;
		/// <summary>
		/// Gets or sets the value of GroupName
		/// </summary>
		public string GroupName
		{
			get {return groupName;}
			set {groupName = value;}
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

        protected string masapxep = String.Empty;
        public string Masapxep
        {
            get { return masapxep; }
            set { masapxep = value; }
        }
		#endregion
		
		#region Lists
		#endregion
		

	}
	#endregion
}	

