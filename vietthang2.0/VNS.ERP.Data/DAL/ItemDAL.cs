using System;
using System.Collections.Generic;
using System.Text;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;

namespace VNS.ERP.Data
{
    class ItemDAL:StockBaseDAL <Item >
    {
           public ItemDAL()
        {}
        public ItemDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_Items_Select_All";
            _spSelectDynamic="usp_Items_SelectDynamic";
        }

        /// <summary>
        /// insert a Items object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(Item  t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String , 50, t.ItemCode ));
                cmd.Parameters.Add(db.CreateParameter("@ItemName", System.Data.DbType.String, 100, t.ItemName ));
                cmd.Parameters.Add(db.CreateParameter("@Unit", System.Data.DbType.String, 20, t.Unit));
                cmd.Parameters.Add(db.CreateParameter("@UnitWeight", System.Data.DbType.Decimal, 9, t.UnitWeight));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String ,200, t.Description ));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16 , 2, t.ItemType  ));
                cmd.Parameters.Add(db.CreateParameter("@OutByFormula", System.Data.DbType.Boolean , 1,t.OutByFormula  ));
                cmd.Parameters.Add(db.CreateParameter("@OutToStock", System.Data.DbType.Boolean, 1, t.OutToStock));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@ItemGroup", System.Data.DbType.AnsiString, 10, t.ItemGroup));
                cmd.Parameters.Add(db.CreateParameter("@Masapxep", System.Data.DbType.String, 10, t.Masapxep));
                cmd.Parameters.Add(db.CreateParameter("@InActive", System.Data.DbType.Boolean, 1, t.InActive));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@Code2", System.Data.DbType.String, 20, t.Code2));

                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    t.ID = (int)cmd.Parameters["@MaterialCodeOutput"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "Insert(Items t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a Items object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(Item  t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String , 50, t.ItemCode ));
                cmd.Parameters.Add(db.CreateParameter("@ItemName", System.Data.DbType.String, 100, t.ItemName));
                cmd.Parameters.Add(db.CreateParameter("@Unit", System.Data.DbType.String, 20, t.Unit));
                cmd.Parameters.Add(db.CreateParameter("@UnitWeight", System.Data.DbType.Decimal, 9, t.UnitWeight));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String , 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.String, 2, t.ItemType));
                cmd.Parameters.Add(db.CreateParameter("@OutByFormula", System.Data.DbType.Boolean , 1, t.OutByFormula));
                cmd.Parameters.Add(db.CreateParameter("@OutToStock", System.Data.DbType.Boolean, 1, t.OutToStock));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@ItemGroup", System.Data.DbType.AnsiString, 10, t.ItemGroup));
                cmd.Parameters.Add(db.CreateParameter("@Masapxep", System.Data.DbType.String, 10, t.Masapxep));
                cmd.Parameters.Add(db.CreateParameter("@InActive", System.Data.DbType.Boolean, 1, t.InActive));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@Code2", System.Data.DbType.String, 20, t.Code2));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "Update(Items t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a Items object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(Item  t)
        {
            return Delete(t.ItemCode );
            
        }
        /// <summary>
        /// Delete a Nhaphang object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(string  _Itemcode)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String , 50, _Itemcode ));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "Delete(int _ItemCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_Itemtype"></param>
        /// <returns></returns>
        public ListBase<Item > GetByItemtype(int _Itemtype)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_ItemType";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, _Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetByItemType(int _Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<Item> GetByItemtypeAll(int _Itemtype)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_ItemTypeAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, _Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetByItemType(int _Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<Item> GetProduct(string productType)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_Product";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (productType != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetByItemType(int _Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="Itemtype"></param>
       /// <param name="FormulaCode"></param>
       /// <returns></returns>
        public ListBase<Item> GetPremixCodeExcept(int Itemtype,string FormulaCode)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_PremixCode_Except";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Itemtype", System.Data.DbType.Int16, 2, Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetPremixCodeExcept(int Itemtype,string FormulaCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<Item> GetPremixCodeExcept2(int Itemtype)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_PremixCode_Except2";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@Itemtype", System.Data.DbType.Int16, 2, Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetPremixCodeExceptInItem(int Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<Item> GetPremixCodeExcept2(int Itemtype, string PremixCode)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_PremixCode_Except21";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@Itemtype", System.Data.DbType.Int16, 2, Itemtype));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, PremixCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetPremixCodeExcept2(int Itemtype, string PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<Item> GetByGroup2ItemType(Int16 ItemType1, Int16 ItemType2)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Get_By_Group_2ItemType";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType1", System.Data.DbType.Int16, 2, ItemType1));
                cmd.Parameters.Add(db.CreateParameter("@Itemtype2", System.Data.DbType.Int16, 2, ItemType2));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetByGroup2ItemType(Int16 ItemType1, Int16 ItemType2)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<Item> GetMatrialCodeExcept(int Itemtype, string FormulaCode)
        {
            bool alreadyOpen = false;
            ListBase<Item> lobj = new ListBase<Item>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_MatrialCode_Except";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Itemtype", System.Data.DbType.Int16, 2, Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Item obj = new Item(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetPremixCodeExcept(int Itemtype,string FormulaCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        public Item GetUnitWeight(string _PremixCode)
        {
            bool alreadyOpen = false;
            Item obj = new Item();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_UnitWeight";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, _PremixCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                     obj = new Item(reader);
                   
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetUnitWeight(string _PremixCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
        public string GetItemBy_Type_UnitWeight(int _Itemtype,decimal _UnitWeight)
        {
            bool alreadyOpen = false;
            string _ItemCode = "";
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Items_Select_ItemType_UnitWeight";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, _Itemtype));
                cmd.Parameters.Add(db.CreateParameter("@UnitWeight", System.Data.DbType.Decimal, 9, _UnitWeight));
                _ItemCode = db.ExecuteScalar(cmd).ToString();

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemDAL", "GetItemBy_Type_UnitWeight(int _Itemtype,decimal _UnitWeight)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return _ItemCode;
        }

    }
}
