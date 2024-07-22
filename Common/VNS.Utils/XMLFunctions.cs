using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace VNS.Utils
{
    public class XMLFunctions
    {
        public static string GetTextFromXML(XmlDocument xml, string id, string attName, string defaultValue)
        {
            if (xml == null) return defaultValue;
            XmlElement ele = xml.GetElementById(id);
            if (ele != null)
                if (ele.HasAttribute(attName))
                    return ele.GetAttribute(attName);
            return defaultValue;
        }
        
        public static string GetTextFromXML(XmlDocument xml, string id, string attName)
        {
            return GetTextFromXML(xml, id, attName, "");
        }
        private static string GetTextFromElement(XmlElement element, string attName, string defaultValue)
        {
            if (element.HasAttribute(attName))
                return element.GetAttribute(attName);
            return defaultValue;
        }
    }
}
