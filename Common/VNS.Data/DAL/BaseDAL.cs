using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

using VNS.Utils;
using VNS.Common;

namespace VNS.Data.DAL
{
    public abstract class BaseDAL<T> : DataAccessBase
        where T: new()
    {
        protected string _spSelectAll;
        protected string _spSelectDynamic;
        protected string _spDeleteAll;
        protected string _spDeleteDynamic;

        public BaseDAL()
        { SetValues(); }
        public BaseDAL(DBHelper dbHelper): base(dbHelper)
        { SetValues(); }
        protected virtual void SetValues(){}
        public virtual int Insert(T t){ return 0;}
        public virtual int Update(T t){ return 0;}
        public virtual int Delete(T t){ return 0;}
        
        protected bool CheckNotNull(DbDataReader reader, string columnName)
        {
            int n = reader.GetOrdinal(columnName);
            if (n >= 0)
                return !reader.IsDBNull(n);
            else
                return false;
        }

        protected bool CheckNotNull(DbDataReader oDR, string FieldName, ref int FieldPos)
        {
            FieldPos = -1;
            try
            {
                FieldPos = oDR.GetOrdinal(FieldName);
            }
            catch { }
            bool isNull = false;
            if (FieldPos >= 0)
                isNull = (!oDR.IsDBNull(FieldPos));
            return isNull;
        }
        protected virtual T DataReader2Object(DbDataReader oDR) { return default(T); }
        private DbDataReader getDRAll()
        {
            DbDataReader oDR = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = _spSelectAll;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                oDR = db.ExecuteReader(cmd, CommandBehavior.CloseConnection);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BaseDAL", "getDRAll()", excp.Message);
            }
            return oDR;
        }
        public ListBase<T> GetObjectAll()
        {
            ListBase<T> oListBase = new ListBase<T>();
            DbDataReader oDR = getDRAll();
            try
            {
                while (oDR.Read())
                {
                    T obj = new T();
                    (obj as ObjectBase).FromDataReader(oDR);
                    oListBase.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BaseDAL", "GetObjectAll()", excp.Message);
            }
            finally
            {
                if (oDR != null)
                    oDR.Close();
            }
            return oListBase;
        }
        private DbDataReader getDRDynamic(string WhereCondition, string OrderByExpression)
        {
            DbDataReader oDR = null;
            try
            {
                db.Open();
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = _spSelectDynamic;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WhereCondition", System.Data.DbType.String, 1000, WhereCondition));
                cmd.Parameters.Add(db.CreateParameter("@OrderByExpression", System.Data.DbType.String, 500, OrderByExpression));

                oDR = db.ExecuteReader(cmd, CommandBehavior.CloseConnection);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BaseDAL", "getDRDynamic(string WhereCondition, string OrderByExpression)", excp.Message);
            }
            return oDR;
        }
        public ListBase<T> GetObjectDynamic(string WhereCondition, string OrderByExpression)
        {
            ListBase<T> oListBase = new ListBase<T>();
            DbDataReader oDR = getDRDynamic(WhereCondition, OrderByExpression);
            try
            {
                while (oDR.Read())
                {
                    T obj = new T();
                    (obj as ObjectBase).FromDataReader(oDR);
                    oListBase.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BaseDAL", "getObjectDynamic(string WhereCondition, string OrderByExpression)", excp.Message);
            }
            finally
            {
                if (oDR != null)
                    oDR.Close();
            }
            return oListBase;
        }
        public ListBase<T> GetObjectDynamic(string WhereCondition)
        {
            return GetObjectDynamic(WhereCondition, "");
        }
                

        public int DeleteAll()
        {
            int iError = 0;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = _spDeleteAll;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("BaseDAL", "DeleteAll()", excp.Message);
            }
            finally
            {
                db.Close();
            }
            return iError;
        }
        public int DeleteDynamic(string WhereCondition)
        {
            int iError = 0;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = _spDeleteDynamic;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WhereCondition", DbType.String, 200, WhereCondition));
                cmd.Parameters.Add(db.CreateParameter("@iError", DbType.Int32, 4, 0, ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("BaseDAL", "DeleteDynamic(string WhereCondition)", excp.Message);
            }
            //finally
            //{
            //    db.Close();
            //}
            return iError;
        }
    }
}
