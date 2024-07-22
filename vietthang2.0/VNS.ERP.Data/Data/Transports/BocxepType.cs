using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class BocxepType : UserTracking2
    {
        public BocxepType() { }
        public BocxepType(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TypeCode", reader)) typeCode = reader.GetString(reader.GetOrdinal("TypeCode"));
            if (!isNull("TypeName", reader)) typeName = reader.GetString(reader.GetOrdinal("TypeName"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string typeCode = string.Empty;
        public string TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }
        private string typeName = string.Empty;
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
