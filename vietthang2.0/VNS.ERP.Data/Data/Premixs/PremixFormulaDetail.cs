using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Premixs
{
  public  class PremixFormulaDetail:BaseClass
    {
         public PremixFormulaDetail()
        { }

        public PremixFormulaDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("FormulaCode", reader)) _FormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("PremixCode", reader)) _PremixCode = reader.GetString(reader.GetOrdinal("PremixCode"));
            if (!isNull("MaterialCode", reader)) _MaterialCode = reader.GetString(reader.GetOrdinal("MaterialCode"));
            if (!isNull("Weight", reader)) _Weight = reader.GetDecimal(reader.GetOrdinal("Weight"));
           


        }

        protected string _FormulaCode;
        public string FormulaCode
        {
            get { return _FormulaCode; }
            set { _FormulaCode = value; }
        }
        protected string _PremixCode;
        public string PremixCode
        {
            get { return _PremixCode; }
            set { _PremixCode = value; }
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
