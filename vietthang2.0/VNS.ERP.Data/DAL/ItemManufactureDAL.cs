using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Common;
using VNS.Utils;
using System.Data.Common;

namespace VNS.ERP.Data
{
    class ItemManufactureDAL : StockBaseDAL<ItemManufacture>
	{
		public ItemManufactureDAL()
		{
		}
        public ItemManufactureDAL(DBHelper dbHelper)
            : base(dbHelper)
		{
			
		}
        
        public ListBase<ItemManufacture> GetListObjectsByItemType(int itemType)
        {
            bool alreadyOpen = false;
            ListBase<ItemManufacture> lstReturn = new ListBase<ItemManufacture>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemManufactures_Select_By_ItemType";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int32, 2, itemType));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ItemManufacture obj = new ItemManufacture(reader);
                    lstReturn.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemManufactureDAL", "GetListObjectsByItemType(int itemType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
   }
}

