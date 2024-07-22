
/************************************************************************
**	ClassName	: 	TechnicalTest
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	18-02-2008 01:46 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
	#region TechnicalTest
	/// <summary>
	/// This object represents the properties and methods of a TechnicalTest.
	/// </summary>
	public class TechnicalTest : UserTracking2 
	{
		public TechnicalTest()
		{
		}
		
		public TechnicalTest(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("TechCode",reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
				if (!isNull("TechName",reader)) techName = reader.GetString(reader.GetOrdinal("TechName"));
				if (!isNull("ResultType",reader)) resultType = reader.GetString(reader.GetOrdinal("ResultType"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("KCSTest", reader)) kcsTest = reader.GetBoolean(reader.GetOrdinal("KCSTest"));
                if (!isNull("PTNTest", reader)) ptnTest = reader.GetBoolean(reader.GetOrdinal("PTNTest"));
                if (!isNull("OrderBy", reader)) orderBy = reader.GetInt32(reader.GetOrdinal("OrderBy"));
                if (!isNull("DisplayText", reader)) displayText = reader.GetString(reader.GetOrdinal("DisplayText"));
                //if (!isNull("DateCreated",reader)) dateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
                //if (!isNull("UserUpdated",reader)) userUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                //if (!isNull("DateUpdated",reader)) dateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
			}
            base.FromDataReader(reader);
		}
		
		#region Public Properties

        private string displayText = string.Empty;

        public string DisplayText
        {
            get
            {
                return displayText;
            }
            set
            {
                displayText = value;
            }

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

		private string techName = String.Empty;
		/// <summary>
		/// Gets or sets the value of TechName
		/// </summary>
		public string TechName
		{
			get {return techName;}
			set {techName = value;}
		}

		private string resultType = String.Empty;
		/// <summary>
		/// Gets or sets the value of ResultType
		/// </summary>
		public string ResultType
		{
			get {return resultType;}
			set {resultType = value;}
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
        private bool kcsTest = false;
        public bool KCSTest
        {
            get { return kcsTest; }
            set { kcsTest = value; }
        }
        private bool ptnTest = false;
        public bool PTNTest
        {
            get { return ptnTest; }
            set { ptnTest = value; }
        }

        private int orderBy;
        public int OrderBy
        {
            get { return orderBy; }
            set { orderBy = value; }
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

        //private DateTime dateCreated;
        ///// <summary>
        ///// Gets or sets the value of DateCreated
        ///// </summary>
        //public DateTime DateCreated
        //{
        //    get {return dateCreated;}
        //    set {dateCreated = value;}
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

        //private DateTime dateUpdated;
        ///// <summary>
        ///// Gets or sets the value of DateUpdated
        ///// </summary>
        //public DateTime DateUpdated
        //{
        //    get {return dateUpdated;}
        //    set {dateUpdated = value;}
        //}
		#endregion
		
		#region Lists
		#endregion
		

	}
	#endregion
}	

