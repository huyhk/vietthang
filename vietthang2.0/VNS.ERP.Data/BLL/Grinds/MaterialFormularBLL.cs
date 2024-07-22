using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Data;
using System.Data;

namespace VNS.ERP.Data.Grinds
{
  public  class MaterialFormularBLL
    {
       private MaterialFormulaDAL dal = new  MaterialFormulaDAL();

        public MaterialFormularBLL()
		{
         }
       public ListBase<GeneralMaterial> GetAll()
       {
           return dal.GetAll();
       }
       public MaterialFormular GetFormulaCode(string _FormulaCode)
       {
           return dal.GetFormulaCode(_FormulaCode);
       }
     
    }
}
