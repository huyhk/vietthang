using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace VNS.Common
{
    public class AppConfigBase
    {
        public static string CONFIG_DATEFORMAT = ConfigurationManager.AppSettings["DateFormat"];
        public static string CONFIG_DATEFORMAT_STRING = "{0:" + CONFIG_DATEFORMAT + "}";

        public static string CONFIG_ENABLEDCOLOR = ConfigurationManager.AppSettings["EnabledColor"];
        public static string CONFIG_READONLYCOLOR = ConfigurationManager.AppSettings["ReadOnlyColor"];
        public static string CONFIG_DISABLEDCOLOR = ConfigurationManager.AppSettings["DisabledColor"];
        

    }
}
