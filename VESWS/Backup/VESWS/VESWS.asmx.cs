using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VNS.ERP.Data.Manufactures;
using System.Data;
using VNS.Common;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.ERP.Data.Premixs;

namespace VESWS
{
    /// <summary>
    /// Summary description for VESWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VESWS : System.Web.Services.WebService
    {

        [WebMethod]
        public ListBase<ManufactureShift> GetObject(string searchString)
        {
            ListBase<ManufactureShift> obj = new ManufactureShiftBLL().Search(searchString);
            
            return obj;
        }

        [WebMethod]
        public ListBase<StockTransaction> GetCustomer(string searchString)
        {
            ListBase<StockTransaction> obj = new StockTransactionBLL().GetByGoodCode(searchString);

            return obj;
        }

        [WebMethod]
        public ListBase<StockTransaction> GetMaterialInfo(Guid manufactureShiftID)
        {
            ListBase<StockTransaction> obj = new StockTransactionBLL().GetMaterialInfo(manufactureShiftID);

            return obj;
        }

        [WebMethod]
        public WSProductTest GetWSProductTest(string searchString)
        {
            WSProductTest obj = new KCSReportBLL().GetWSProductTest(searchString);

            return obj;
        }
        [WebMethod]
        public ListBase<StockTransaction> GetWrappingInfo(string searchString)
        {
            ListBase<StockTransaction> obj = new StockTransactionBLL().GetWrappingInfo(searchString);

            return obj;
        }

        [WebMethod]
        public ListBase<WSMaterialTest> GetWSMaterialTest(string searchString)
        {
            ListBase<WSMaterialTest> obj = new KCSReportBLL().GetWSMaterialTest(searchString);

            return obj;
        }

        [WebMethod]
        public ListBase<StockTransaction> GetPremixInfo(string searchString)
        {
            ListBase<StockTransaction> obj = new StockTransactionBLL().GetPremixInfo(searchString);

            return obj;
        }

        [WebMethod]
        public MixPremixShift GetPremix(string searchString)
        {
            MixPremixShift obj = new MixPremixShiftBLL().GetPremix(searchString);

            return obj;
        }
        
    }
}
