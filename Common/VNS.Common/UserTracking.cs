using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace VNS.Common
{
    public abstract class UserTracking:ObjectBase
    {

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("UserCreated", reader)) userCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                if (!isNull("UserUpdated", reader)) userUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                if (!isNull("DateCreated", reader)) dateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
                if (!isNull("DateUpdated", reader)) dateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
            }
        }
        public override void FromDataRow(System.Data.DataRow row)
        {
            base.FromDataRow(row);
            if (!row.IsNull("UserCreated")) userCreated = (string)row["UserCreated"];
            if (!row.IsNull("UserUpdated")) userUpdated = (string)row["UserUpdated"];
            if (!row.IsNull("DateCreated")) dateCreated = (DateTime)row["DateCreated"];
            if (!row.IsNull("DateUpdated")) dateUpdated = (DateTime)row["DateUpdated"]; 
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            base.LoadFromReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("UserCreated", reader)) userCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                if (!isNull("UserUpdated", reader)) userUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                if (!isNull("DateCreated", reader)) dateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
                if (!isNull("DateUpdated", reader)) dateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
            }
        }
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("UserCreated")) userCreated = (string)row["UserCreated"];
            if (!row.IsNull("UserUpdated")) userUpdated = (string)row["UserUpdated"];
            if (!row.IsNull("DateCreated")) dateCreated = (DateTime)row["DateCreated"];
            if (!row.IsNull("DateUpdated")) dateUpdated = (DateTime)row["DateUpdated"];
        }
        private string userCreated=string.Empty;
        public string UserCreated
        {
            get { return userCreated; }
            set { userCreated = value; }
        }

        private string userUpdated = string.Empty;
        public string UserUpdated
        {
            get { return userUpdated; }
            set { userUpdated = value; }
        }

        private DateTime dateCreated=DateTime.Now;
        public DateTime DateCreated
        {            
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        private DateTime dateUpdated=DateTime.Now;
        public DateTime DateUpdated
        {
            get { return dateUpdated; }
            set { dateUpdated = value; }
        }
	
	
    }
}
