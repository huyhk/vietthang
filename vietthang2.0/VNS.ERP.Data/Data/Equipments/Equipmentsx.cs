
/************************************************************************
**	ClassName	: 	Equipmentsxs
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	09-07-2008 01:06 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Equipments
{
	#region Equipmentsxs
	/// <summary>
	/// This object represents the properties and methods of a Equipmentsxs.
	/// </summary>
	public class Equipmentsx : UserTracking2 
	{
			
		
		public Equipmentsx()
		{
		}
		
		public Equipmentsx(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);
			
        //    equipmentsxCode = (obj as Equipmentsxs).equipmentsxCode;
        //    equipmentsxName = (obj as Equipmentsxs).equipmentsxName;
        //    description = (obj as Equipmentsxs).description;
        //    userCreated = (obj as Equipmentsxs).userCreated;
        //    userUpdated = (obj as Equipmentsxs).userUpdated;
        //    serverCreated = (obj as Equipmentsxs).serverCreated;

        //}
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("EquipmentsxCode",reader)) equipmentsxCode = reader.GetString(reader.GetOrdinal("EquipmentsxCode"));
				if (!isNull("EquipmentsxName",reader)) equipmentsxName = reader.GetString(reader.GetOrdinal("EquipmentsxName"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                //if (!isNull("UserCreated",reader)) userCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                //if (!isNull("ServerCreated",reader)) serverCreated = reader.GetString(reader.GetOrdinal("ServerCreated"));
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("EquipmentsxCode")) equipmentsxCode = (string)row["EquipmentsxCode"];
			if (!row.IsNull("EquipmentsxName")) equipmentsxName = (string)row["EquipmentsxName"];
			if (!row.IsNull("Description")) description = (string)row["Description"];
            //if (!row.IsNull("UserCreated")) userCreated = (string)row["UserCreated"];
            //if (!row.IsNull("ServerCreated")) serverCreated = (string)row["ServerCreated"];
		}
		
		#region Public Properties

		
		
		private string equipmentsxCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of EquipmentsxCode
		/// </summary>
		public string EquipmentsxCode
		{
			get {return equipmentsxCode;}
			set {equipmentsxCode = value;}
		}

		private string equipmentsxName = String.Empty;
		/// <summary>
		/// Gets or sets the value of EquipmentsxName
		/// </summary>
		public string EquipmentsxName
		{
			get {return equipmentsxName;}
			set {equipmentsxName = value;}
		}

        private string description = String.Empty;
        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
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

        ////private string serverCreated = String.Empty;
        /////// <summary>
        /////// Gets or sets the value of ServerCreated
        /////// </summary>
        ////public string ServerCreated
        ////{
        ////    get {return serverCreated;}
        ////    set {serverCreated = value;}
        ////}
		#endregion
		
		#region Lists
		#endregion
		

	}
	#endregion
}	

