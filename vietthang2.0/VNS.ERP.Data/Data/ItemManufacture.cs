using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace VNS.ERP.Data
{
    public class ItemManufacture:Item
    {
        public ItemManufacture()
		{
		}
        public ItemManufacture(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		public override void FromDataReader(IDataReader reader)
		{
            base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{
                if (!isNull("SizeCode", reader)) sizeCode = reader.GetString(reader.GetOrdinal("SizeCode"));
                if (!isNull("WeightCode", reader)) weightCode = reader.GetString(reader.GetOrdinal("WeightCode"));
                if (!isNull("SizeDescription", reader)) sizeDescription = reader.GetString(reader.GetOrdinal("SizeDescription"));
                if (!isNull("Weight", reader)) weight = reader.GetDecimal(reader.GetOrdinal("Weight"));
                if (!isNull("WeightDescription", reader)) weightDescription = reader.GetString(reader.GetOrdinal("WeightDescription"));
			}
		}

        private string sizeCode = string.Empty;
        public string SizeCode
        {
            get { return sizeCode; }
            set { sizeCode = value; }
        }
        private string weightCode = string.Empty;
        public string WeightCode
        {
            get { return weightCode; }
            set { weightCode = value; }
        }
        private string sizeDescription = string.Empty;
        public string SizeDescription
        {
            get { return sizeDescription; }
            set { sizeDescription = value; }
        }
        private decimal weight;
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string weightDescription = string.Empty;
        public string WeightDescription
        {
            get { return weightDescription; }
            set { weightDescription = value; }
        }
    }
}
