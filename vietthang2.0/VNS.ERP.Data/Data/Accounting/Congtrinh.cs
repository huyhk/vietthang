using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class Congtrinh : UserTracking2
    {
        public Congtrinh() { }
        public Congtrinh(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("CongtrinhCode", reader)) congtrinhCode = reader.GetString(reader.GetOrdinal("CongtrinhCode"));
            if (!isNull("CongtrinhName", reader)) congtrinhName = reader.GetString(reader.GetOrdinal("CongtrinhName"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            
        }
        private string congtrinhCode;
        public string CongtrinhCode
        {
            get { return congtrinhCode; }
            set { congtrinhCode = value; }
        }
        private string congtrinhName;
        public string CongtrinhName
        {
            get { return congtrinhName; }
            set { congtrinhName = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}
