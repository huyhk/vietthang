using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.KCS
{
   public class ProductQualityStandards:UserTracking2
    {
        public ProductQualityStandards()
        {
            
        }
        public ProductQualityStandards(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ProductCode", reader)) productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
            if (!isNull("TechCode", reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
            if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
            if (!isNull("ConditionType", reader)) conditionType = reader.GetString(reader.GetOrdinal("ConditionType"));
            if (!isNull("ValueString", reader)) valueString = reader.GetString(reader.GetOrdinal("ValueString"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string productCode = string.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
        private string techCode = string.Empty;
        public string TechCode
        {
            get { return techCode; }
            set { techCode = value; }
        }
        private DateTime startDate = Contexts.WorkingDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private string conditionType = string.Empty;
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
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
