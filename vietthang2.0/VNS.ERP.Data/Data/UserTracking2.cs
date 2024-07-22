using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class UserTracking2 : UserTracking //BaseClass
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
                //if (!isNull("UserCreated", reader)) _UserCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                //if (!isNull("UserUpdated", reader)) _UserUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                //if (!isNull("DateCreated", reader)) _DateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
                //if (!isNull("DateUpdated", reader)) _DateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));

                if (!isNull("ServerCreated", reader)) serverCreated = reader.GetString(reader.GetOrdinal("ServerCreated"));
            }
        }
       public override void LoadFromReader(DbDataReader reader)
       {
           base.LoadFromReader(reader);
           if (reader != null && !reader.IsClosed)
           {
               //if (!isNull("UserCreated", reader)) _UserCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
               //if (!isNull("UserUpdated", reader)) _UserUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
               //if (!isNull("DateCreated", reader)) _DateCreated = reader.GetDateTime(reader.GetOrdinal("DateCreated"));
               //if (!isNull("DateUpdated", reader)) _DateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));

               if (!isNull("ServerCreated", reader)) serverCreated = reader.GetString(reader.GetOrdinal("ServerCreated"));
           }
       }
       public override void LoadFromDataRow(DataRow row)
       {
           base.LoadFromDataRow(row);
           //if (!row.IsNull("UserCreated")) _UserCreated = (string)row["UserCreated"];
           //if (!row.IsNull("UserUpdated")) _UserUpdated = (string)row["UserUpdated"];
           //if (!row.IsNull("DateCreated")) _DateCreated = (DateTime)row["DateCreated"];
           //if (!row.IsNull("DateUpdated")) _DateUpdated = (DateTime)row["DateUpdated"];

           if (!row.IsNull("ServerCreated")) serverCreated = row["ServerCreated"].ToString(); 
       }
       public override void FromDataRow(DataRow row)
       {
           base.FromDataRow(row);
           //if (!row.IsNull("UserCreated")) _UserCreated = (string)row["UserCreated"];
           //if (!row.IsNull("UserUpdated")) _UserUpdated = (string)row["UserUpdated"];
           //if (!row.IsNull("DateCreated")) _DateCreated = (DateTime)row["DateCreated"];
           //if (!row.IsNull("DateUpdated")) _DateUpdated = (DateTime)row["DateUpdated"];

           if (!row.IsNull("ServerCreated")) serverCreated = row["ServerCreated"].ToString();
       }
       // private string _UserCreated;

       // public string UserCreated
       // {
       //     get { return _UserCreated; }
       //     set { _UserCreated = value; }
       // }

       // private string _UserUpdated;

       // public string UserUpdated
       // {
       //     get { return _UserUpdated; }
       //     set { _UserUpdated = value; }
       // }

       // private DateTime _DateCreated=DateTime.Now;

       // public DateTime DateCreated
       // {
       //     get { return _DateCreated; }
       //     set { _DateCreated = value; }
       // }

       //private DateTime _DateUpdated = DateTime.Now;

       // public DateTime DateUpdated
       // {
       //     get { return _DateUpdated; }
       //     set { _DateUpdated = value; }
       // }

        private string serverCreated = string.Empty;

       public string ServerCreated
        {
            get { return serverCreated; }
            set { serverCreated = value; }
        }
	
    }
}
