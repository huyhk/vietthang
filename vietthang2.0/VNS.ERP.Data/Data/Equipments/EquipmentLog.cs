
/************************************************************************
**	ClassName	: 	EquipmentLog
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	10-07-2008 12:30 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace  VNS.ERP.Data.Equipments
{
	#region EquipmentLog
	/// <summary>
	/// This object represents the properties and methods of a EquipmentLog.
	/// </summary>
	public class EquipmentLog : UserTracking2 
	{
			
		
		public EquipmentLog()
		{
		}
		
		public EquipmentLog(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);
			
        //    equipmentCode = (obj as EquipmentLog).equipmentCode;
        //    startDate = (obj as EquipmentLog).startDate;
        //    stockCode = (obj as EquipmentLog).stockCode;
        //    description = (obj as EquipmentLog).description;
        //    userCreated = (obj as EquipmentLog).userCreated;
        //    userUpdated = (obj as EquipmentLog).userUpdated;
        //    serverCreated = (obj as EquipmentLog).serverCreated;

        //}
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("EquipmentCode",reader)) equipmentCode = reader.GetString(reader.GetOrdinal("EquipmentCode"));
				if (!isNull("StartDate",reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
				if (!isNull("StockCode",reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            //    if (!isNull("UserCreated",reader)) userCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
            //    if (!isNull("UserUpdated",reader)) userUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
            //    if (!isNull("ServerCreated",reader)) serverCreated = reader.GetString(reader.GetOrdinal("ServerCreated"));
            }
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("EquipmentCode")) equipmentCode = (string)row["EquipmentCode"];
			if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
			if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
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

        private DateTime startDate = Contexts.WorkingDate;
		/// <summary>
		/// Gets or sets the value of StartDate
		/// </summary>
		public DateTime StartDate
		{
			get {return startDate;}
			set {startDate = value;}
		}

		private string stockCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of StockCode
		/// </summary>
		public string StockCode
		{
			get {return stockCode;}
			set {stockCode = value;}
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

