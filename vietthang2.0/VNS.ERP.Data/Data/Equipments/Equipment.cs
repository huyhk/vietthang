
/************************************************************************
**	ClassName	: 	Equipment
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	10-07-2008 11:47 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace  VNS.ERP.Data.Equipments
{
	#region Equipment
	/// <summary>
	/// This object represents the properties and methods of a Equipment.
	/// </summary>
	public class Equipment : UserTracking2 
	{
			
		
		public Equipment()
		{
		}
		
		public Equipment(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);
			
        //    equipmentCode = (obj as Equipment).equipmentCode;
        //    equipmentName = (obj as Equipment).equipmentName;
        //    groupCode = (obj as Equipment).groupCode;
        //    description = (obj as Equipment).description;
        //    userCreated = (obj as Equipment).userCreated;
        //    userUpdated = (obj as Equipment).userUpdated;
        //    serverCreated = (obj as Equipment).serverCreated;

        //}
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("EquipmentCode",reader)) equipmentCode = reader.GetString(reader.GetOrdinal("EquipmentCode"));
				if (!isNull("EquipmentName",reader)) equipmentName = reader.GetString(reader.GetOrdinal("EquipmentName"));
				if (!isNull("GroupCode",reader)) groupCode = reader.GetString(reader.GetOrdinal("GroupCode"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                //if (!isNull("UserCreated",reader)) userCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                //if (!isNull("UserUpdated",reader)) userUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                //if (!isNull("ServerCreated",reader)) serverCreated = reader.GetString(reader.GetOrdinal("ServerCreated"));
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("EquipmentCode")) equipmentCode = (string)row["EquipmentCode"];
			if (!row.IsNull("EquipmentName")) equipmentName = (string)row["EquipmentName"];
			if (!row.IsNull("GroupCode")) groupCode = (string)row["GroupCode"];
			if (!row.IsNull("Description")) description = (string)row["Description"];
            //if (!row.IsNull("UserCreated")) userCreated = (string)row["UserCreated"];
            //if (!row.IsNull("UserUpdated")) userUpdated = (string)row["UserUpdated"];
            //if (!row.IsNull("ServerCreated")) serverCreated = (string)row["ServerCreated"];
		}
		
		#region Public Properties

		
		
		private string equipmentCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of EquipmentCode
		/// </summary>
		public string EquipmentCode
		{
			get {return equipmentCode;}
			set {equipmentCode = value;}
		}

		private string equipmentName = String.Empty;
		/// <summary>
		/// Gets or sets the value of EquipmentName
		/// </summary>
		public string EquipmentName
		{
			get {return equipmentName;}
			set {equipmentName = value;}
		}

		private string groupCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of GroupCode
		/// </summary>
		public string GroupCode
		{
			get {return groupCode;}
			set {groupCode = value;}
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

