using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
   public  class ProvinceBLL:IBusiness 
    {
       private ProvinceDAL dal = new ProvinceDAL();

       public ProvinceBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<Provinces> GetAll()
       {
           return dal.GetObjectAll();
       }
       /// <summary>
       /// Insert a Provinces object into database
       /// return: 0: success;
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>

       public int Insert(Provinces t)
       {
          return dal.Insert(t);

       }
       /// <summary>
       /// Update  the Provinces into Database.
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
       public int Update(Provinces t)
       {
                  
           return dal.Update(t);
       }
       /// <summary>
       /// delete a  Provinces object out of database
       /// return: 0: success
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
       public int Delete(Provinces t)
       {
           return dal.Delete(t);
       }

       #region IBusiness Members

       public int Insert(object obj)
       {
           return this.Insert(obj as Provinces);
       }

       public int Update(object obj)
       {
           return this.Update(obj as Provinces);
       }

       public int Delete(object obj)
       {
           return this.Delete(obj as Provinces);
       }

       #endregion
   }
}