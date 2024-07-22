using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
    public class Product : UserTracking2 
    {
        public Product(){}
        public Product(System.Data.IDataReader reader) { this.FromDataReader(reader); }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            try
            {
                if (!isNull("ProductCode", reader)) productcode = reader.GetString(reader.GetOrdinal("ProductCode"));
                if (!isNull("ProductName", reader)) productname = reader.GetString(reader.GetOrdinal("ProductName"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("ProductType", reader)) productType = reader.GetString(reader.GetOrdinal("ProductType"));
            }
            catch { }
        }
        //Attribute
        private string productcode;
        private string description;
        private string productname;
        //Properties
        public string ProductCode
        {
            get { return productcode; }
            set { productcode = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }

        private string productType = "TS";

        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
	

    }

    public class ProductType
    {
        public static string THUYSAN = "TS";
        public static string GIASUC = "GS";
        public static string CAVAY = "CV";
    }
}
