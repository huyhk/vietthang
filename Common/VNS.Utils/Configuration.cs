using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Web.Configuration;
using System.Configuration;
namespace VNS.Utils
{
    public class WebConfiguration
    {
        public static void Save(string path, NameValueCollection configs)
        { 
            Save(path,configs,false);
        }
        public static void Save(string path,NameValueCollection configs, bool encrypted)
        {
            path = path.Substring(0, path.LastIndexOf("/"));
            Configuration cfg = WebConfigurationManager.OpenWebConfiguration(path);
            AppSettingsSection appSettings = cfg.GetSection("appSettings") as AppSettingsSection;
            foreach (string s in configs)
            {
                appSettings.Settings.Remove(s);
                appSettings.Settings.Add(s, configs[s]);
            }
            if (!appSettings.SectionInformation.IsProtected)
            {
                if (encrypted)
                    appSettings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            else
                appSettings.SectionInformation.UnprotectSection();

            cfg.Save();
            
        }
    }
}
