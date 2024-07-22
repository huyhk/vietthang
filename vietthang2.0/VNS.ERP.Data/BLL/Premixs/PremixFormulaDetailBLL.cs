using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.Premixs
{
   public class PremixFormulaDetailBLL
    {

        private PremixFormulaDetailDAL dal = new PremixFormulaDetailDAL();

        public PremixFormulaDetailBLL()
		{}

       public ListBase<PremixFormulaDetail> GetDetail(string _FormulaCode,string _PremixCode)
       {
          return dal.GetDetail(_FormulaCode, _PremixCode);
       }
       public ListBase<PremixFormulaDetail> GetMaterialCodeMixPremix(string _FormulaCode, string _PremixCode, decimal _Weight)
       {
           return dal.GetMaterialCodeMixPremix(_FormulaCode, _PremixCode, _Weight);
       }
       public DataTable GetMaterialCode(string _FormulaCode, string _PremixCode, decimal _Weight)
       {
           return dal.GetMaterialCode(_FormulaCode, _PremixCode, _Weight);
       }
       public DataTable GetFormulaCode(string _PremixCode)
       {
           return dal.GetFormulaCode(_PremixCode,false);
       }
       public DataTable GetFormulaCode(string _PremixCode,Boolean isActive)
       {
           return dal.GetFormulaCode(_PremixCode, isActive);
       }
        /// <summary>
        /// Insert a ItemWrappings object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>

       public int Insert(ListBase<PremixFormulaDetail> lstP,GeneralPremix G)
           {
               int Error = 0;
               PremixFormulaDAL PreDAL = new PremixFormulaDAL(dal.DBHelper);
              // if (lstP.Count > 0)
               //{
                   PremixFormula obj = new PremixFormula();
                   G.UserCreated = Contexts.CurrentUser.LoginName;
                   obj = PreDAL.GetFormulaCode(G.FormulaCode);
                   dal.Open();
                   dal.BeginTransaction();
                   if (obj.FormulaCode == null)
                       Error = PreDAL.Insert((PremixFormula)G);
                   else
                   {
                       G.UserUpdated = Contexts.CurrentUser.LoginName;
                       Error = PreDAL.Update((PremixFormula)G);
                   }
                   Error = dal.Delete(G.FormulaCode, G.PremixCode);
                   if (Error == 0)
                   {
                       foreach (PremixFormulaDetail _P in lstP)
                       {
                           Error = dal.Insert(_P);
                           if (Error != 0) break;
                       }
                   }
                   if (Error == 0)
                       dal.Commit();
                   else
                       dal.Rollback();
               //}
              // else
                //   Error = PreDAL.Insert((PremixFormula)G);
                   //Error = -100;
                 //Error = dal.Delete(G.FormulaCode,G.PremixCode);
                
               
               dal.Close();
               return Error;
               
           }
        /// <summary>
        /// Update  the ItemWrappings into Database.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        //public int Update(ItemWrapping t)
        //{
        //    t.UserUpdated = Contexts.CurrentUser.LoginName;
        //    int Error;
        //    ItemDAL ItemDal = new ItemDAL(dal.DBHelper);
        //    dal.Open();
        //    dal.BeginTransaction();
        //    Error = ItemDal.Update((Item)t);

        //    if (Error == 0)
        //        Error = dal.Update(t);

        //    if (Error == 0)
        //        dal.Commit();
        //    else
        //        dal.Rollback();
        //    dal.Close();
        //    return Error;
        //}
        /// <summary>
        /// delete a  ItemWrappings object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        //public int Delete(ItemWrapping  t)
        //{
        //    ItemDAL ItemDal = new ItemDAL(dal.DBHelper);
        //    return ItemDal.Delete((Item)t);}


        public ListBase<PremixFormulaDetail> GetLast(string pCode, DateTime pDate)
        {
            return dal.GetLast(pCode, pDate);
        }
    }
}
