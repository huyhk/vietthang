using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace VNS.ERP.Data.KCS
{
    public class MaterialQualityStandards :UserTracking2
    {
        public MaterialQualityStandards() { }
        public MaterialQualityStandards(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("TechCode", reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
                if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("conditionType", reader)) conditionType = reader.GetString(reader.GetOrdinal("ConditionType"));
                if (!isNull("valueString", reader)) valueString = reader.GetString(reader.GetOrdinal("ValueString"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
		}
       	private string itemCode = String.Empty;
		public string ItemCode
		{
			get {return itemCode;}
			set {itemCode = value;}
		}

		private string techCode = String.Empty;
		public string TechCode
		{
			get {return techCode;}
			set {techCode = value;}
		}
		private DateTime startDate=DateTime.Now;
		public DateTime StartDate
		{
			get {return startDate;}
			set {startDate = value;}
		}

		private string conditionType = String.Empty;
        public string ConditionType
		{
            get { return conditionType; }
            set { conditionType = value; }
		}

        private string valueString;
        public string ValueString
		{
            get { return valueString; }
            set { valueString = value; }
		}
		private string description = String.Empty;
		public string Description
		{
			get {return description;}
			set {description = value;}
		}

	
	

		

    }
}
