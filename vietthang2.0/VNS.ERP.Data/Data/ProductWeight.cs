using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
    public class ProductWeight : UserTracking2 
    {
        public ProductWeight(){}
        public ProductWeight(System.Data.IDataReader reader) { this.FromDataReader(reader); }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            try
            {
                if (!isNull("WeightCode", reader)) _weightcode = reader.GetString(reader.GetOrdinal("WeightCode"));
                if (!isNull("Weight", reader)) _weight = reader.GetDecimal(reader.GetOrdinal("Weight"));
                if (!isNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
            }
            catch  {  }
        }
        //Attribute
        private string _weightcode;
        private string _description;
        private decimal  _weight;
        //Properties
        public string WeightCode
        {
            get { return _weightcode; }
            set { _weightcode = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
