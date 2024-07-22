using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Utils;
using VNS.Data.DAL;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data
{
    class TransactionTypesDAL : StockBaseDAL<TransactionType>
    {
        public TransactionTypesDAL() { }
        public TransactionTypesDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_TransactionTypes_Select_All";
            //base.SetValues();
        }
        public ListBase<TransactionType> GetBySTAndForManufacture(enumStockTransaction _StockTransaction, bool _ForManufacture)
        {
            DbDataReader reader = null;
            ListBase<TransactionType> lsttt = new ListBase<TransactionType>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransactionTypes_Select_By_ST_ForManufacture";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", System.Data.DbType.Int16, 2, _StockTransaction));
                cmd.Parameters.Add(db.CreateParameter("@ForManufacture", System.Data.DbType.Boolean, 1, _ForManufacture));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    TransactionType obj = new TransactionType(reader);
                    lsttt.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransactionTypeDAL", "GetBySTAndForManufacture(Int16 _StockTransaction, bool ForManufacture)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lsttt;
        }
        public ListBase<TransactionType> GetByStockTransaction(enumStockTransaction _StockTransaction)
        {
            bool alreadyOpen = false;
            ListBase<TransactionType> lobj = new ListBase<TransactionType>();
            try
            {
                DbDataReader reader = null;
        
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransactionTypes_Select_By_StockTransaction";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", System.Data.DbType.Int16, 2, (Int16)_StockTransaction));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    TransactionType obj = new TransactionType(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransactionTypeDAL", "GetByStockTransaction(Int16 _StockTransaction)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<TransactionType> GetByStockTransactionContScale(enumStockTransaction _StockTransaction)
        {
            bool alreadyOpen = false;
            ListBase<TransactionType> lobj = new ListBase<TransactionType>();
            try
            {
                DbDataReader reader = null;

                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransactionTypes_Select_By_StockTransaction";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", System.Data.DbType.Int16, 2, (Int16)_StockTransaction));
                cmd.Parameters.Add(db.CreateParameter("@ContScale", System.Data.DbType.Boolean, 1, true));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    TransactionType obj = new TransactionType(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransactionTypeDAL", "GetByStockTransaction(Int16 _StockTransaction)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public override int Insert(TransactionType t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransactionTypes_Insert";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", DbType.String, 10, t.TransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", DbType.Int16, 2, (Int16)t.StockTransaction));
                cmd.Parameters.Add(db.CreateParameter("@ForManufacture", DbType.Boolean, 1, t.ForManufacture));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //{ t.Typecode = cmd.Parameters["@TypeCode"].Value; }

            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransactionTypeDAL", "Insert(TransactionType t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //iError = (int)cmd.Parameters[""]
            //return base.Insert(t);
        }
        public override int Update(TransactionType t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransactionTypes_Update";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", DbType.String, 10, t.TransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", DbType.Int16, 2, (Int16)t.StockTransaction));
                cmd.Parameters.Add(db.CreateParameter("@ForManufacture", DbType.Boolean, 1, t.ForManufacture));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransactionTypeDAL", "Update(TransactionType t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Update(t);
        }
        public override int Delete(TransactionType t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransactionTypes_Delete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", DbType.String, 10, t.TransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@UserDelete", DbType.String, 20, Contexts.CurrentUser.LoginName));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception ex)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransactionTypeDAL", "Delete(TransactionType t)", ex.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Delete(t);
        }
    }
}
