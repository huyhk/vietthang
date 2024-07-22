using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class ProductFormula2 : UserTracking2
    {
        public ProductFormula2() { }
        public ProductFormula2(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("FormulaCode", reader)) _FormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
                if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("ProductCode", reader)) productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
            }
            base.FromDataReader(reader);
        }
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("FormulaCode")) _FormulaCode = row["FormulaCode"].ToString();
            if (!row.IsNull("ProductCode")) productCode = row["ProductCode"].ToString();
            if (!row.IsNull("Description")) _Description = row["Description"].ToString();

            if (!row.IsNull("UnActive")) isActive = !(bool)row["UnActive"];
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
        private string productCode = string.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
        protected bool isActive = true;
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        private ListBase<FormulaDetail> formulaDetails = new ListBase<FormulaDetail>();
        public ListBase<FormulaDetail> FormulaDetails
        {
            get { return formulaDetails; }
            set { formulaDetails = value; }
        }
        private bool isNewFormulaCode = false;
        public bool IsNewFormulaCode
        {
            get { return isNewFormulaCode; }
            set { isNewFormulaCode = value; }
        }
        #endregion
    }
}
