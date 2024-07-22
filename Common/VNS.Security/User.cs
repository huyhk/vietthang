using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;

namespace VNS.Security
{
    public class User:ObjectBase
    {
        protected string _loginName = String.Empty;
        protected string _password = String.Empty;
        protected string _userName = String.Empty;
        protected string _description = String.Empty;
        protected int _roleID;
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
        }
        public bool IsAdmin = false;
    }
}
