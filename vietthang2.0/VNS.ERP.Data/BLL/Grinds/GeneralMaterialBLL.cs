using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Grinds
{
   public class GeneralMaterialBLL:IBusiness
    {
         private GeneralMaterialDAL   dal = new   GeneralMaterialDAL();

       public GeneralMaterialBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<GeneralMaterial> GetAll()
       {
           return dal.GetObjectAll();
       }
       
        /// <summary>
        /// delete a  Items object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(GeneralMaterial  t)
        {
            int Error=0;
            MaterialFormularDetailDAL dal = new  MaterialFormularDetailDAL();
            MaterialFormulaDAL dal1 = new  MaterialFormulaDAL();
            MaterialFormularDetail obj = new  MaterialFormularDetail();
            obj.FormulaCode = t.FormulaCode;
            obj.MaterialPCode = t.MaterialPCode;
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
                return this.Delete(obj as GeneralMaterial);
            }

            #endregion
    }
}
