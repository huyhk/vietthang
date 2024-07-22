using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;

namespace VNS.ERP.Data.Premixs
{
   public class GeneralPremixBLL:IBusiness
    {
       
       private GeneralPremixDAL   dal = new  GeneralPremixDAL();

       public GeneralPremixBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<GeneralPremix> GetAll()
       {
           return dal.GetObjectAll();
       }
       

     
        /// <summary>
        /// delete a  Items object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(GeneralPremix  t)
        {
            int Error=0;
            PremixFormulaDetailDAL dal = new PremixFormulaDetailDAL();
            PremixFormulaDAL dal1 = new PremixFormulaDAL();
            PremixFormulaDetail obj = new PremixFormulaDetail();
            obj.FormulaCode = t.FormulaCode;
            obj.PremixCode = t.PremixCode;
            try
            {
                Error = dal.Delete(obj);
                obj = dal.GetByFormulaCode(t.FormulaCode);
                if (obj.FormulaCode == null) Error = dal1.Delete(t.FormulaCode);
            }
            catch { }
            return Error;

        }
       
            #region IBusiness Members

            public int Insert(object obj)
            {
                return 0;
            }

            public int Update(object obj)
            {
               return  0;
            }

            public int Delete(object obj)
            {
                return this.Delete(obj as GeneralPremix);
            }

            #endregion
    }
}
