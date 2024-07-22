
/************************************************************************
**	ClassName	: 	EquipmentGroup
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	10-07-2008 10:32 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace  VNS.ERP.Data.Equipments
{
	#region EquipmentGroup
	/// <summary>
	/// This object represents the properties and methods of a EquipmentGroup.
	/// </summary>
	public class EquipmentGroup : UserTracking2 
	{
			
		
		public EquipmentGroup()
		{
		}
		
		public EquipmentGroup(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);
			
        //    groupCode = (obj as EquipmentGroup).groupCode;
        //    groupName = (obj as EquipmentGroup).groupName;
        //    description = (obj as EquipmentGroup).description;
        //    userCreated = (obj as EquipmentGroup).userCreated;
        //    userUpdated = (obj as EquipmentGroup).userUpdated;
        //    serverCreated = (obj as EquipmentGroup).serverCreated;

        //}
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("GroupCode",reader)) groupCode = reader.GetString(reader.GetOrdinal("GroupCode"));
				if (!isNull("GroupName",reader)) groupName = reader.GetString(reader.GetOrdinal("GroupName"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                //if (!isNull("UserCreated",reader)) userCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                //if (!isNull("UserUpdated",reader)) userUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                //if (!isNull("ServerCreated",reader)) serverCreated = reader.GetString(reader.GetOrdinal("ServerCreated"));
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("GroupCode")) groupCode = (string)row["GroupCode"];
			if (!row.IsNull("GroupName")) groupName = (string)row["GroupName"];
			if (!row.IsNull("Description")) description = (string)row["Description"];
            //if (!row.IsNull("UserCreated")) userCreated = (string)row["UserCreated"];
            //if (!row.IsNull("UserUpdated")) userUpdated = (string)row["UserUpdated"];
            //if (!row.IsNull("ServerCreated")) serverCreated = (string)row["ServerCreated"];
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

        //private string userCreated = String.Empty;
        ///// <summary>
        ///// Gets or sets the value of UserCreated
        ///// </summary>
        //public string UserCreated
        //{
        //    get {return userCreated;}
        //    set {userCreated = value;}
        //}

        //private string userUpdated = String.Empty;
        ///// <summary>
        ///// Gets or sets the value of UserUpdated
        ///// </summary>
        //public string UserUpdated
        //{
        //    get {return userUpdated;}
        //    set {userUpdated = value;}
        //}

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
		#endregion
		

	}
	#endregion
}	

