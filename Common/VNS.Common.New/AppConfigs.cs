using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace VNS.Common
{
    public class AppConfigs
    {
        public static string CONFIG_DATEFORMAT = ConfigurationManager.AppSettings["DateFormat"];
        public static string CONFIG_DATEFORMAT_STRING = "{0:" + CONFIG_DATEFORMAT + "}";

        public static string CONFIG_ENABLEDCOLOR = ConfigurationManager.AppSettings["EnabledColor"];
        public static string CONFIG_READONLYCOLOR = ConfigurationManager.AppSettings["ReadOnlyColor"];
        public static string CONFIG_DISABLEDCOLOR = ConfigurationManager.AppSettings["DisabledColor"];

        public static string CONFIG_QUANTITY_PRODUCT_FORMAT1 = "n0";
        public static string CONFIG_QUANTITY_PRODUCT_FORMAT1_SUMMARY = "{0:" + CONFIG_QUANTITY_PRODUCT_FORMAT1 + "}";
        public static string CONFIG_WEIGHT_WRAPPING_FORMAT = "n2";
        public static string CONFIG_WEIGHT_WRAPPING_FORMAT_SUMMARY = "{0:" + CONFIG_WEIGHT_WRAPPING_FORMAT + "}";
        public static string CONFIG_WEIGHT_PRODUCT_FORMAT = "n0";
        public static string CONFIG_WEIGHT_PRODUCT_FORMAT_SUMMARY = "{0:" + CONFIG_WEIGHT_PRODUCT_FORMAT + "}";

        public static string CONFIG_QUANTITYFORMAT = "#,##0.##";
        public static string CONFIG_QUANTITYFORMAT_STRING = "{0:" + CONFIG_QUANTITYFORMAT + "}";

        public static string CONFIG_QUANTITYSALEFORMAT = "#,##0";
        public static string CONFIG_QUANTITYSALEFORMAT_STRING = "{0:" + CONFIG_QUANTITYSALEFORMAT + "}";
        public static string CONFIG_QUANTITYSALEFORMATZ = "#,###";
        public static string CONFIG_QUANTITYSALEFORMATZ_STRING = "{0:" + CONFIG_QUANTITYSALEFORMATZ + "}";

        public static string CONFIG_QUANTITYPRODUCTFORMAT = "#,##0";
        public static string CONFIG_QUANTITYPRODUCTFORMAT_STRING = "{0:" + CONFIG_QUANTITYPRODUCTFORMAT + "}";

        public static string CONFIG_PRICEVNFORMAT = "#,##0.#0";
        public static string CONFIG_PRICEVNFORMAT_STRING = "{0:" + CONFIG_PRICEVNFORMAT + "}";
        public static string CONFIG_PRICEVNFORMATZ = "#,###.##";
        public static string CONFIG_PRICEVNFORMATZ_STRING = "{0:" + CONFIG_PRICEVNFORMATZ + "}";

        public static string CONFIG_AMOUNTVNFORMAT = "#,##0";
        public static string CONFIG_AMOUNTVNFORMAT_STRING = "{0:" + CONFIG_AMOUNTVNFORMAT + "}";
        public static string CONFIG_AMOUNTNTFORMAT = "#,##0.##";
        public static string CONFIG_AMOUNTNTFORMAT_STRING = "{0:" + CONFIG_AMOUNTNTFORMAT + "}";
        public static string CONFIG_AMOUNTVNFORMATZ = "#,###";
        public static string CONFIG_AMOUNTVNFORMATZ_STRING = "{0:" + CONFIG_AMOUNTVNFORMATZ + "}";

        public static string CONFIG_PERCENTFORMAT = "p";
        public static string CONFIG_PERCENTFORMAT_STRING = "{0:" + CONFIG_PERCENTFORMAT + "}";

        public static string CONFIG_PERCENTFORMAT0 = "p0";
        public static string CONFIG_PERCENTFORMAT0_STRING = "{0:" + CONFIG_PERCENTFORMAT0 + "}";

        public static string CONFIG_AMOUNTVNMASK = "###,###,###,##0";
        public static string CONFIG_AMOUNTNTMASK = "###,###,###,##0.00";
        public static string CONFIG_QUANTITYMASK = "###,###,###,##0.00";
        public static string CONFIG_PRICEVNMASK = "###,###,###,##0.00";

    }
}
