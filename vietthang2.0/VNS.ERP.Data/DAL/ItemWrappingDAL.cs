using System;
using System.Collections.Generic;
using System.Text;

using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data
{
    class ItemWrappingDAL:StockBaseDAL <ItemWrapping>
    {
     public ItemWrappingDAL()
        {}
        public ItemWrappingDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_ItemWrapping_Select_All";
        }

        /// <summary>
        /// insert a ItemWrappings object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(ItemWrapping  t)
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
                cmd.CommandText = "usp_ItemWrappings_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
              
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    t.ID = (int)cmd.Parameters["@MaterialCodeOutput"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemWrappingDAL", "Insert(ItemWrappings t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a ItemWrappings object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(ItemWrapping  t)
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
                cmd.CommandText = "usp_ItemWrappings_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String , 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String , 10, t.WeightCode));
              
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemWrappingDAL", "Update(ItemWrappings t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a ItemWrappings object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(ItemWrapping  t)
        {
            return Delete(t.ItemCode);
        }
        /// <summary>
        /// Delete a ItemWrappings  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(string _Itemcode)
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
                cmd.CommandText = "usp_ItemWrappings_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String , 50, _Itemcode ));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemWrappingDAL", "Delete(int _MaterialCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<ItemWrapping > GetAll(int _Itemtype)
        {
            bool alreadyOpen = false;
            ListBase<ItemWrapping> lobj = new ListBase<ItemWrapping>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemWrapping_Select_All";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, _Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ItemWrapping obj = new ItemWrapping(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemWrappingDAL", "GetByItemType(int _Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<ItemWrapping> GetActive(int _Itemtype)
        {
            bool alreadyOpen = false;
            ListBase<ItemWrapping> lobj = new ListBase<ItemWrapping>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemWrapping_Select_Active";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, _Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ItemWrapping obj = new ItemWrapping(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemWrappingDAL", "GetActive(int _Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        public string GetItemCode(string _ProductCode, string _WeightCode)
        {
            bool alreadyOpen = false;
            string _ItemCode = "";
            try
            {
                object obj = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemWrappings_Select_ItemCode_By_PCode_WCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, _ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, _WeightCode));

                obj = db.ExecuteScalar(cmd);
                _ItemCode = obj.ToString();
               
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemWrappings", "GetItemCode(string _ProductCode, string _SizeCode, string _WeightCode)", excp.Message);
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
