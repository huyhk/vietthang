using System;
using System.Collections.Generic;
using System.Text;
using VNS.Security;

namespace VNS.Context
{
    public class ContextBase
    {
        public static User CurrentUser;
        public static string AppName;
        public static string AppVersion;

        public static DateTime WorkingDate;
        public static string ServerName;
        public static string DatabaseName;
    }
}
