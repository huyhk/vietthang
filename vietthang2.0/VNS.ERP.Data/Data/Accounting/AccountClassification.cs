using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class AccountClassification : UserTracking2
    {
        public AccountClassification()
        { }

        public AccountClassification(DbDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ClassificationCode", reader)) classificationCode = reader.GetString(reader.GetOrdinal("ClassificationCode"));
                if (!isNull("ClassificationName", reader)) classificationName = reader.GetString(reader.GetOrdinal("ClassificationName"));
                if (!isNull("ClassificationTypeCode", reader)) classificationTypeCode = reader.GetString(reader.GetOrdinal("ClassificationTypeCode"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }
      
        #region Public Properties
        protected string classificationCode = string.Empty;
        public string ClassificationCode
        {
            set { classificationCode = value; }
            get { return classificationCode; }
        }
        protected string classificationName = string.Empty;
        public string ClassificationName
        {
            set { classificationName = value; }
            get { return classificationName; }
        }
        protected string classificationTypeCode = string.Empty;
        public string ClassificationTypeCode
        {
            set { classificationTypeCode = value; }
            get { return classificationTypeCode; }
        }

        protected string description = string.Empty;
        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        #endregion
    }
}