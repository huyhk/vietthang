using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
   public class MaterialFormular:UserTracking2
    {
         public MaterialFormular()
        { }

       public MaterialFormular(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("FormulaCode", reader)) _FormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
           


        }

        protected string _FormulaCode;
        public string FormulaCode
        {
            get { return _FormulaCode; }
            set { _FormulaCode = value; }
        }
        protected string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
 
    }
}
