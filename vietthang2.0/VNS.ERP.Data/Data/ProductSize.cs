using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
    public class ProductSize : UserTracking2 
    {
        public ProductSize() { }
        public ProductSize(System.Data.IDataReader reader) { this.FromDataReader(reader); }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            try
            {
                if (!isNull("SizeCode", reader)) SizeCode = reader.GetString(reader.GetOrdinal("SizeCode"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
            catch  { }
        }
        //Attribute
        private string sizecode;
        private string description;
        //Properties
        public string SizeCode
        {
            get { return sizecode; }
            set { sizecode  = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
