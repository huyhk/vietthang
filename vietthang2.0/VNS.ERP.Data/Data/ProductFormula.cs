using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class ProductFormula:UserTracking2
    {
        public ProductFormula() { }
        public ProductFormula(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("FormulaCode", reader)) _FormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
                if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
            }
            base.FromDataReader(reader);
        }
        #region Public Properties
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
        private ListBase<ProductFormulaDetail> productFormulaDetails = new ListBase<ProductFormulaDetail>();
        public ListBase<ProductFormulaDetail> ProductFormulaDetails
        {
            get { return productFormulaDetails; }
            set { productFormulaDetails = value; }
        }
        #endregion
    }
}
