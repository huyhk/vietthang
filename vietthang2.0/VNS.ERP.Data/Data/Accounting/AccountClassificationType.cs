using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class AccountClassificationType : UserTracking2
    {
        public AccountClassificationType()
        { }

        public AccountClassificationType(DbDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ClassificationTypeCode", reader)) classificationTypeCode = reader.GetString(reader.GetOrdinal("ClassificationTypeCode"));
                if (!isNull("ClassificationTypeName", reader)) classificationTypeName = reader.GetString(reader.GetOrdinal("ClassificationTypeName"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }
      
        #region Public Properties
        protected string classificationTypeCode = string.Empty;
        public string ClassificationTypeCode
        {
            set { classificationTypeCode = value; }
            get { return classificationTypeCode; }
        }
        protected string classificationTypeName = string.Empty;
        public string ClassificationTypeName
        {
            set { classificationTypeName = value; }
            get { return classificationTypeName; }
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