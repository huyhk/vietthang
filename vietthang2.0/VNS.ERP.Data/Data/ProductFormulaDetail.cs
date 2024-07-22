using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class ProductFormulaDetail : BaseClass
    {
        public ProductFormulaDetail()
        {}
        public ProductFormulaDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("FormulaCode", reader)) _FormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
                if (!isNull("ProductCode", reader)) _ProductCode = reader.GetString(reader.GetOrdinal("ProductCode"));
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
        protected string _ProductCode;
        public string ProductCode
        {
            get { return _ProductCode; }
            set { _ProductCode = value; }
        }
        private ListBase<FormulaDetail> formulaDetails = new ListBase<FormulaDetail>();

        public ListBase<FormulaDetail> FormulaDetails
        {
            get { return formulaDetails; }
            set { formulaDetails = value; }
        }
        protected bool isActive = true;
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        #endregion
    }
}
