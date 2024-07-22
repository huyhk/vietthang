using System;
using System.Collections.Generic;
using System.Text;

using VNS.Common;

namespace VNS.Security  
{
    public class UserRole : ObjectBase
    {
        protected string _RoleName = String.Empty;
        public string RoleName
        {
            get { return _RoleName; }
            set { _RoleName = value; }
        }
    }
}
