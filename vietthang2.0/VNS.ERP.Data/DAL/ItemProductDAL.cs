using System;
using System.Collections.Generic;
using System.Text;

using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;


namespace VNS.ERP.Data
{
    class ItemProductDAL:StockBaseDAL <ItemProduct >
    {
             public ItemProductDAL()
        {}
        public ItemProductDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_ItemProducts_Select_All";
        }

        /// <summary>
        /// insert a ItemProducts object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(ItemProduct  t)
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
                cmd.CommandText = "usp_ItemProducts_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode ));
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", System.Data.DbType.String, 10, t.SizeCode ));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@WrappingCode", System.Data.DbType.String, 50, t.WrappingCode));

              

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    t.ID = (int)cmd.Parameters["@MaterialCodeOutput"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemProductDAL", "Insert(ItemProducts t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a ItemProducts object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(ItemProduct  t)
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
                cmd.CommandText = "usp_ItemProducts_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String , 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", System.Data.DbType.String , 10, t.SizeCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@WrappingCode", System.Data.DbType.String, 50, t.WrappingCode));

                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemProductDAL", "Update(ItemProducts t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a ItemProducts object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(ItemProduct  t)
        {
            return Delete(t.ItemCode);
        }
        /// <summary>
        /// Delete a ItemProducts  object by the ID
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
                cmd.CommandText = "usp_ItemProducts_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.Int32, 4, _Itemcode ));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemProductDAL", "Delete(int _Itemcode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<ItemProduct> GetAll(int _Itemtype)
        {
            bool alreadyOpen = false;
            ListBase<ItemProduct> lobj = new ListBase<ItemProduct>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemProducts_Select_All";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16 , 2, _Itemtype ));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ItemProduct obj = new ItemProduct(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemProductDAL", "GetByItemType(int _Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<ItemProduct> GetActive(int _Itemtype)
        {
            bool alreadyOpen = false;
            ListBase<ItemProduct> lobj = new ListBase<ItemProduct>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemProducts_Select_Active";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, _Itemtype));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ItemProduct obj = new ItemProduct(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemProductDAL", "GetActive(int _Itemtype)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public string GetProductCodeByItemCode(string _ItemCode)
        {
            bool alreadyOpen = false;
            string Str = "";
            try
            {
            
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemProducts_Select_ProductCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, _ItemCode));
                Str = db.ExecuteScalar(cmd).ToString();
             
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemProductDAL", "GetProductCodeByItemCode(string _ItemCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return Str;
        }
        public string GetItemCode(string _ProductCode, string _SizeCode, string _WeightCode)
        {
            bool alreadyOpen = false;
            string _ItemCode = "";
            try
            {
                object obj = "";
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemProducts_Select_ItemCode_By_PCode_SCode_WCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, _ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", System.Data.DbType.String, 10, _SizeCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, _WeightCode));

                obj = db.ExecuteScalar(cmd);
                _ItemCode = obj.ToString();
               
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemProductDAL", " GetItemCode(string _ProductCode, string _SizeCode, string _WeightCode)", excp.Message);
            }
            finally
            {
                   if (!alreadyOpen)
                    db.Close();
            }
            return _ItemCode;
        }

        public ItemProduct GetByPSW(string _ProductCode, string _SizeCode, string _WeightCode)
        {
            bool alreadyOpen = false;
            ItemProduct obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ItemProducts_Select_By_PCode_SCode_WCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, _ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", System.Data.DbType.String, 10, _SizeCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, _WeightCode));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj = new ItemProduct(reader);
                reader.Close();

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ItemProductDAL", " GetByPSW(string _ProductCode, string _SizeCode, string _WeightCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
    }
}
                                        