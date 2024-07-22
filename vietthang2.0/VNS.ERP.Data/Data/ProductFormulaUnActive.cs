using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class ProductFormulaUnActive : BaseClass
    {
        public ProductFormulaUnActive() { }
        public ProductFormulaUnActive(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("FormulaCode", reader)) formulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("ProductCode", reader)) productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
        }
        private string formulaCode=string.Empty;
        public string FormulaCode
        {
            get { return formulaCode; }
            set { formulaCode = value; }
        }
        private string productCode=string.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
    }
}
