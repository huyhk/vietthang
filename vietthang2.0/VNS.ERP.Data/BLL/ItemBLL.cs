using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
   public  class ItemBLL:IBusiness 
    {
       private ItemDAL   dal = new ItemDAL ();

       public ItemBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<Item> GetAll()
       {
           return dal.GetObjectAll();
       }
       public ListBase<Item> GetDynamic(string WhereCondition, string OrderByExpression)
       {
           return dal.GetObjectDynamic(WhereCondition, OrderByExpression);
       }
       public ListBase<Item> GetPremixCodeExcept(int ItemType,string FormulaCode)
       {
           return dal.GetPremixCodeExcept(ItemType, FormulaCode);
       }
       public ListBase<Item> GetByGroup2ItemType(Int16 ItemType1, Int16 ItemType2)
       {
           return dal.GetByGroup2ItemType(ItemType1, ItemType2);
       }
       public ListBase<Item> GetMatrialCodeExcept(int Itemtype, string FormulaCode)
       {
           return dal.GetMatrialCodeExcept(Itemtype, FormulaCode);
       }
       public ListBase<Item> GetbyItemtype(int _Itemtype)
       {
           return dal.GetByItemtype(_Itemtype);
       }
       public ListBase<Item> GetbyItemtypeAll(int _Itemtype)
       {
           return dal.GetByItemtypeAll(_Itemtype);
       }
       public ListBase<Item> GetProduct(string productType)
       {
           return dal.GetProduct(productType);
       }
       /// <summary>
        /// Get PremixCode  except in Item 
       /// </summary>
       /// <param name="Itemtype"></param>
       /// <returns></returns>
       public ListBase<Item> GetPremixCodeExcept2()
       {
           return dal.GetPremixCodeExcept2((int)enumItemType.Premix);
       }
       public ListBase<Item> GetPremixCodeExcept2(string PremixCode)
       {
         return  dal.GetPremixCodeExcept2((int)enumItemType.Premix, PremixCode);
           
       }
       public Item GetUnitWeight(string _PremixCode)
       {
           return dal.GetUnitWeight(_PremixCode);
       }

       /// <summary>
       /// Get List Item Material.
       /// </summary>
       /// <returns></returns>
       public ListBase<Item> GetListMaterial()
       {
           return dal.GetObjectDynamic("ItemType<>"+((int)enumItemType.Product).ToString(), "");
       }


       public string GetItemBy_Type_UnitWeight( decimal _UnitWeight)
       {
           return dal.GetItemBy_Type_UnitWeight((int)enumItemType.WrappingMaterial, _UnitWeight);
       }

        /// <summary>
        /// Insert a Items object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
   
           public int Insert(Item t)
           {
              t.UserCreated = Contexts.CurrentUser.LoginName;
              return dal.Insert (t);
               
           }
       /// <summary>
       /// Update  the Items into Database.
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
        public int Update(Item t)
        {
           
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(t);
        }
        /// <summary>
        /// delete a  Items object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(Item  t)
        {
            return dal.Delete(t);
        }
       
            #region IBusiness Members

            public int Insert(object obj)
            {
                return this.Insert(obj as Item );
            }

            public int Update(object obj)
            {
                return this.Update(obj as Item);
            }

            public int Delete(object obj)
            {
                return this.Delete(obj as Item);
            }

            #endregion
    
    }
}
