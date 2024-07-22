using System;
using System.Collections.Generic;
using System.Text;
using System.IO; 
using System.Configuration;

namespace VNS.Utils
{
    public static class Write2Log
    {
        public static string LogFolder = ConfigurationManager.AppSettings["LogFolder"];
        public static string LogFileName = ConfigurationManager.AppSettings["LogFileName"];
        public static void WriteLogs(string sClassName, string sFunctionName, string sError)
        {
            if (!Directory.Exists(Write2Log.LogFolder))
            {
                Directory.CreateDirectory(Write2Log.LogFolder);
            }
            StreamWriter swFromFile = new StreamWriter(Write2Log.LogFolder + "\\" + Write2Log.LogFileName, true);
            swFromFile.WriteLine("--------------------------------------------------------------------------------");
            swFromFile.WriteLine("[Date & Time]\t\t" + DateTime.Now + "");
            swFromFile.WriteLine("[Classes Name]\t\t" + sClassName.Trim() + "");
            swFromFile.WriteLine("[Functions Name]\t" + sFunctionName.Trim() + "");
            swFromFile.WriteLine("[Description Error]\t" + sError.Trim() + "");
            swFromFile.Flush();
            swFromFile.Close();
        }
    }
}
