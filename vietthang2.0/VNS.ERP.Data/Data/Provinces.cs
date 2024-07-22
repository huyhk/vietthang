using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class Provinces : BaseClass 
    {
       
        public Provinces()
        { }

        public Provinces(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            
            if (!isNull("ProvinceCode", reader)) _provinceCode = reader.GetString(reader.GetOrdinal("ProvinceCode"));
            if (!isNull("ProvinceName", reader)) _provinceName = reader.GetString(reader.GetOrdinal("ProvinceName"));
            base.FromDataReader(reader);
        }

        protected string _provinceCode;
        public string ProvinceCode
        {
            get { return _provinceCode; }
            set { _provinceCode = value; }
        }
        protected string _provinceName = string.Empty;
        public string ProvinceName
        {
            get { return _provinceName; }
            set { _provinceName = value; }
        }
       
    }
}
