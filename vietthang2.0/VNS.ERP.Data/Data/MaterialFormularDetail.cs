using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
   public class MaterialFormularDetail:BaseClass
    {
         public MaterialFormularDetail()
        { }

       public MaterialFormularDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("FormulaCode", reader)) _FormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("MaterialPCode", reader)) _MaterialPCode = reader.GetString(reader.GetOrdinal("MaterialPCode"));
            if (!isNull("MaterialCode", reader)) _MaterialCode = reader.GetString(reader.GetOrdinal("MaterialCode"));
            if (!isNull("Weight", reader)) _Weight = reader.GetDecimal(reader.GetOrdinal("Weight"));
           


        }

        protected string _FormulaCode;
        public string FormulaCode
        {
            get { return _FormulaCode; }
            set { _FormulaCode = value; }
        }
       protected string _MaterialPCode;
       public string MaterialPCode
        {
            get { return _MaterialPCode; }
            set { _MaterialPCode = value; }
        }
        protected string _MaterialCode;
        public string MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }
        protected decimal _Weight;
        public decimal Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
    }
}
