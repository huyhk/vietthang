using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class ItemSalePriceBLL:IBusiness
    {
         private ItemSalePriceDAL DAL = new ItemSalePriceDAL();
        public ItemSalePriceBLL() { }
        public ListBase<ItemSalePrice> GetAll()
        {
            return DAL.GetObjectAll();
        }
        public ItemSalePrice GetByItemCodeAndDate(string itemCode, DateTime d)
        {
            return DAL.GetByItemCodeAndDate(itemCode, d);
        }
        public ListBase<ItemSalePrice> GetByItemCode(string itemCode)
        {
            return DAL.GetByItemCode(itemCode);
        }
        public int Insert(ItemSalePrice t)
        {
            return DAL.Insert(t);
        }
        public int Update(ItemSalePrice t)
        {
            return DAL.Update(t);
        }
        public int Delete(ItemSalePrice t)
        {
            return DAL.Delete(t);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as ItemSalePrice);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ItemSalePrice);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ItemSalePrice);
        }

        #endregion
    }
}
