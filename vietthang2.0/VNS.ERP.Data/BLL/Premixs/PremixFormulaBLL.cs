using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Data;
using System.Data;
namespace VNS.ERP.Data.Premixs
{
   public class PremixFormulaBLL
    {
       
        private PremixFormulaDAL dal = new  PremixFormulaDAL();

       public PremixFormulaBLL()
		{
         }
       public ListBase<GeneralPremix> GetAll()
       {
           return dal.GetAll();
       }
       public PremixFormula GetFormulaCode(string _FormulaCode)
       {
           return dal.GetFormulaCode(_FormulaCode);
       }
      
      
       
    }
}
