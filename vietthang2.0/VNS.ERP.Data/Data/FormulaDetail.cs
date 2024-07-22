using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class FormulaDetail:BaseClass
    {
        public FormulaDetail() { }
        public FormulaDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("FormulaCode", reader)) _FormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
                if (!isNull("ProductCode", reader)) _ProductCode = reader.GetString(reader.GetOrdinal("ProductCode"));
                if (!isNull("MaterialCode", reader)) _MaterialCode = reader.GetString(reader.GetOrdinal("MaterialCode"));
                if (!isNull("Weight", reader)) _Weight = reader.GetDecimal(reader.GetOrdinal("Weight"));
            }
            base.FromDataReader(reader);
        }
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("FormulaCode")) _FormulaCode = row["FormulaCode"].ToString();
            if (!row.IsNull("ProductCode")) _ProductCode = row["ProductCode"].ToString();
            if (!row.IsNull("MaterialCode")) _MaterialCode = row["MaterialCode"].ToString();

            if (!row.IsNull("Weight")) _Weight = (decimal)row["Weight"];
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
         #endregion
    }
}
