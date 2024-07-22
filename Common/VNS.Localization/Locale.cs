using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
namespace VNS.Localization
{
    public class Locale
    {
#region constructors
        public Locale()
        { }
        public Locale(LocaleType type)
        {
            this._type = type;
        }

#endregion
#region static methods
        public static Locale GetFromXML(string xmlFile,string prefix)
        {
            Locale local = new Locale(LocaleType.XML);
            return local;
        }

        public static Locale GetFromDatabase(string connectionString,string tableName,string prefix)
        {
            Locale local = new Locale(LocaleType.DATABASE);
            return local;
        }        
        
#endregion

#region properties
        private LocaleType _type;

        public LocaleType LocalizationType
        {
            get { return _type; }
            set { _type = value; }
        }
	

        private string _language = "EN";

        public string Language
        {
            get { return _language ; }
            set { _language =  value; }
        }

        private string _prefix;

        public string Prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }

        private string _xmlFile;

        public string XmlFile
        {
            get
            {
                if (_type != LocaleType.XML)
                    throw new Exception("LocalizationType must be set to XML before accessing this property!");
                return _xmlFile;
            }
            set
            {
                if (_type != LocaleType.XML)
                    throw new Exception("LocalizationType must be set to XML before accessing this property!");
                _xmlFile = value;
            }
        }
	
        protected Dictionary<string, FormText> Entries;
               
        public FormText this[string keyName]
        {
            get { return Entries[keyName]; }
        }

        public string GetText(string keyName)
        {
            return Entries[keyName].Text;
        }
        public string GetToolTipText(string keyName)
        {
            return Entries[keyName].ToolTipText;
        }
        public int Count
        {
            get { return Entries.Count; }
        }

#endregion

#region public methods
        public void LoadXML(string xmlFile)        
        {
            this._type = LocaleType.XML;
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
        }

        public void Load()
        { }

#endregion


    }
    public enum LocaleType
    { 
        XML,
        DATABASE
    }
    public class FormText
    {
        public FormText():this("","")
        { }
        public FormText(string text):this(text,"")
        { 
        }
        public FormText(string text,string tooltip)
        {
            _text = text;
            _tooltip = tooltip;
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private string _tooltip;

        public string ToolTipText
        {
            get { return _tooltip; }
            set { _tooltip = value; }
        }
	
	
    }
}
