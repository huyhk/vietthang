using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.Grinds
{
  public  class MaterialFormularDetailBLL
    {
        
        private MaterialFormularDetailDAL dal = new  MaterialFormularDetailDAL();

        public MaterialFormularDetailBLL()
		{}

      public ListBase<MaterialFormularDetail> GetDetail(string _FormulaCode, string _MaterialPCode)
       {
           return dal.GetDetail(_FormulaCode, _MaterialPCode);
       }
      public DataTable GetMaterialPCode(string _FormulaCode, string _MaterialPCode, decimal _Weight)
      {
          return dal.GetMaterialCode(_FormulaCode, _MaterialPCode, _Weight);
      }
        /// <summary>
        /// Insert a ItemWrappings object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>

       public int Insert(ListBase<MaterialFormularDetail> lstP,GeneralMaterial G)
           {
               int Error = 0;
               MaterialFormulaDAL PreDAL = new  MaterialFormulaDAL(dal.DBHelper);
             //  if (lstP.Count > 0)
              // {
                   MaterialFormular obj = new MaterialFormular();
                   G.UserCreated = Contexts.CurrentUser.LoginName;
                   obj = PreDAL.GetFormulaCode(G.FormulaCode);
                   dal.Open();
                   dal.BeginTransaction();
                   if (obj.FormulaCode == null)
                       Error = PreDAL.Insert((MaterialFormular)G);
                   else
                   {
                       G.UserUpdated = Contexts.CurrentUser.LoginName;
                       Error = PreDAL.Update((MaterialFormular)G);
                   }
                   Error = dal.Delete(G.FormulaCode, G.MaterialPCode);
                   if (Error == 0)
                   {
                       foreach (MaterialFormularDetail _P in lstP)
                       {
                           Error = dal.Insert(_P);
                           if (Error != 0) break;
                       }
                   }
                   if (Error == 0)
                       dal.Commit();
                   else
                       dal.Rollback();
              // }
               //else
                  // Error = PreDAL.Insert((MaterialFormular)G);
                  // Error = -100;

                dal.Close();
               return Error;
               
           }
      public DataTable GetFormularCode(string _MaterialCode)
      {
          return dal.GetFormularCode(_MaterialCode);
      }
    }
}
