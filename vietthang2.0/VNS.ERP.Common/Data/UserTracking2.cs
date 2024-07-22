using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace VNS.ERP.Common
{
   public class UserTracking2:BaseClass
    {
       public UserTracking2()
        { }
       public UserTracking2(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("UserCreated", reader)) _UserCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                if (!isNull("UserUpdated", reader)) _UserUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                if (!isNull("DateCreated", reader)) _DateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
                if (!isNull("DateUpdated", reader)) _DateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
            }
        }
       public override void LoadFromReader(DbDataReader reader)
       {
           base.LoadFromReader(reader);
           if (reader != null && !reader.IsClosed)
           {
               if (!isNull("UserCreated", reader)) _UserCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
               if (!isNull("UserUpdated", reader)) _UserUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
               if (!isNull("DateCreated", reader)) _DateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
               if (!isNull("DateUpdated", reader)) _DateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
           }
       }
        private string _UserCreated;

        public string UserCreated
        {
            get { return _UserCreated; }
            set { _UserCreated = value; }
        }

        private string _UserUpdated;

        public string UserUpdated
        {
            get { return _UserUpdated; }
            set { _UserUpdated = value; }
        }

        private DateTime _DateCreated=DateTime.Now;

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }

       private DateTime _DateUpdated = DateTime.Now;

        public DateTime DateUpdated
        {
            get { return _DateUpdated; }
            set { _DateUpdated = value; }
        }
	
    }
}
