using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Common
{
   public class UserERP:BaseClass
    {
          public UserERP()
        { }

       public UserERP(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("LoginName", reader)) _LoginName = reader.GetString(reader.GetOrdinal("LoginName"));
            if (!isNull("Password", reader)) _Password = reader.GetString(reader.GetOrdinal("Password"));
            if (!isNull("IsAdmin", reader)) _IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
            if (!isNull("UserName", reader)) _UserName = reader.GetString(reader.GetOrdinal("UserName"));
            if (!isNull("EmployeeID", reader)) _EmployeeID = reader.GetString(reader.GetOrdinal("EmployeeID"));
            if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));


        }

       protected string  _LoginName;
       public string LoginName
        {
            get { return _LoginName; }
            set { _LoginName = value; }
        }


       protected string _Password;
       public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

      
      protected bool _IsAdmin;
      public bool IsAdmin
      {
          get { return _IsAdmin; }
          set { _IsAdmin = value; }
      }
       protected string _UserName;
       public string UserName
        {
          get { return _UserName; }
          set { _UserName = value; }
        }
       protected string _EmployeeID;
       public string  EmployeeID
       {
           get { return _EmployeeID; }
           set { _EmployeeID= value; }
       }
        protected string _Description=string.Empty;
       public string  Description
       {
           get { return _Description; }
           set { _Description= value; }
       }

    
    }
}
