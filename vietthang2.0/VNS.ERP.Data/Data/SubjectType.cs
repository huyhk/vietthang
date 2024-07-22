using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using System.Data;


namespace VNS.ERP.Data
{
    public class SubjectType : UserTracking2
    {
        public SubjectType() { }
        public SubjectType(IDataReader Reader)
        {
            this.FromDataReader(Reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("SubjectTypeCode", reader)) subjectTypeCode = reader.GetString(reader.GetOrdinal("SubjectTypeCode"));
                if (!isNull("SubjectTypeName", reader)) subjectTypeName = reader.GetString(reader.GetOrdinal("SubjectTypeName"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
            base.FromDataReader(reader);
        }
        protected string subjectTypeCode=string.Empty;
        public string SubjectTypeCode
        {
            get { return subjectTypeCode; }
            set { subjectTypeCode = value; }
        }
        protected string subjectTypeName = string.Empty;
        public string SubjectTypeName
        {
            get { return subjectTypeName; }
            set { subjectTypeName = value; }
        }

        protected string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

    }
}
