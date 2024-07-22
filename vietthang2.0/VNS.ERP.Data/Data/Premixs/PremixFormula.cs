using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Premixs
{
    public class PremixFormula : UserTracking2
    {
        public PremixFormula()
        { }

        public PremixFormula(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("FormulaCode", reader)) _FormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("IsActive", reader)) isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));


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
        protected Boolean isActive;
        public Boolean IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
    }
}
