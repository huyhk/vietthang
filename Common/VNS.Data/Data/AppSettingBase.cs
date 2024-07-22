using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Data.DAL;

namespace VNS.Data.Data
{
    public class AppSettingBase
    {
        //public static AppSettingBase()
        //{
        //    FromDataTable((new AppSettingDAL()).GetDataTableAppSetting());
        //}

        public static void FromDataTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                if (!row.IsNull("PropertyValue"))
                {
                    property.Add(row["PropertyID"].ToString(), row["PropertyValue"].ToString());
                }
            }
        }

        private static Dictionary<string, string> property;
        public static Dictionary<string, string> Property
        {
            get
            {
                if (property == null)
                {
                    property = new Dictionary<string,string>();
                    AppSettingBase.FromDataTable((new AppSettingDAL()).GetDataTableAppSetting());
                }
                return property;
            }
            set
            {
                property = value;
            }
        }
    }
}
