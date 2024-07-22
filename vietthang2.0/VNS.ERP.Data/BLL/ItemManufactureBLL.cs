using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;

namespace VNS.ERP.Data
{
   public class ItemManufactureBLL
    {
       private ItemManufactureDAL dal = new ItemManufactureDAL();
       public ItemManufactureBLL()
       {
	    }
       public ListBase<ItemManufacture> GetListObjectsByItemType(int itemType)
       {
           return dal.GetListObjectsByItemType(itemType);
       }
    }
}
