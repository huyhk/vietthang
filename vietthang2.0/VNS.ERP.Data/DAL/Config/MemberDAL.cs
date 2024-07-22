using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;

using System.Data.Common;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class MemberDAL<T>:BaseDAL<T>
        where T:Member,new()
    {
        public MemberDAL()
        { }
        public MemberDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }
        //override 
        public override int Insert(T t)
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
                cmd.CommandText = "usp_Members_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, t.MemberID));
                cmd.Parameters.Add(db.CreateParameter("@MemberName", System.Data.DbType.String, 100, t.MemberName));
                cmd.Parameters.Add(db.CreateParameter("@MemberType", System.Data.DbType.Byte, 1, t.MemberType));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                if (t.BranchCode == string.Empty || t.BranchCode == null)
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));
                }
                if (t.StockCode == string.Empty || t.StockCode == null)
                {
                    cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                }
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "Insert(Members t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        
        public override int Update(T t)
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
                cmd.CommandText = "usp_Members_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, t.MemberID));
                cmd.Parameters.Add(db.CreateParameter("@MemberName", System.Data.DbType.String, 100, t.MemberName));
                //cmd.Parameters.Add(db.CreateParameter("@MemberType", System.Data.DbType.Int32, 4, t.MemberType));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                if (t.BranchCode == string.Empty || t.BranchCode == null)
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));
                }
                if (t.StockCode == string.Empty || t.StockCode == null)
                {
                    cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                }
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "Update(Members t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public override int Delete(T t)
        {
            return Delete(t.MemberID);
        }
        public int Delete(string _memberID)
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
                cmd.CommandText = "usp_Members_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, _memberID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "Delete(string _memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int InsertUpdateProperty(string _memberID, byte _propertyID,string _propertyValue)
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
                cmd.CommandText = "usp_MemberProperties_InsertUpdate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, _memberID));
                cmd.Parameters.Add(db.CreateParameter("@PropertyID", System.Data.DbType.Byte, 2, _propertyID));
                if (_propertyValue!=null)
                cmd.Parameters.Add(db.CreateParameter("@PropertyValue", System.Data.DbType.String, 100, _propertyValue));
                else
                cmd.Parameters.Add(db.CreateParameter("@PropertyValue", System.Data.DbType.String, 100, DBNull.Value));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "InsertUpdateProperty(string _memberID, byte _propertyID,string _propertyValue)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<Member> GetAll()
        {
            ListBase<Member> lstReturn = new ListBase<Member>();
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Members_Select_All";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                oDR = db.ExecuteReader(cmd);

                while (oDR.Read())
                {
                    Member obj = new Member(oDR);
                    obj.FromDataReader(oDR);
                    lstReturn.Add(obj);
                }
                oDR.Close();
            }
            catch(Exception excp)
            {
                Write2Log.WriteLogs("MemberDAL", "GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        public ListBase<T> GetObjectByType(byte _memberType)
        {
            ListBase<T> oListBase = new ListBase<T>();
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Members_Select_Type";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@Type", System.Data.DbType.Byte, 1, _memberType));

                oDR = db.ExecuteReader(cmd);
                while (oDR.Read())
                {
                    T obj = new T();
                    obj.FromDataReader(oDR);
                    oListBase.Add(obj);
                }
                if (oDR.NextResult())
                {
                    while (oDR.Read())
                    {
                        MemberProperty mp = new MemberProperty(oDR); ;
                        oListBase.Search("MemberID", mp.MemberID).Properties[mp.PropertyID] = mp.PropertyValue;
                    }
                }
                oDR.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MemberDAL", "GetObjectByType(byte _memberType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return oListBase;
        }

        public T GetObjectByID(string _memberID)
        {
            T obj = null;
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Members_Select_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, _memberID));

                oDR = db.ExecuteReader(cmd);
                if (oDR.Read())
                {
                    obj = new T();
                    obj.FromDataReader(oDR, true);
                }
                oDR.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MemberDAL", "GetObjectByID(int _memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        public int InsertMemberOf(string _parentID, string _memberID)
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
                cmd.CommandText = "usp_MemberOf_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, _memberID));
                cmd.Parameters.Add(db.CreateParameter("@ParentID", System.Data.DbType.String, 20, _parentID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "InsertMemberOf(string _parentID, string _memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int DeleteMemberOf(string _parentID, string _memberID)
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
                cmd.CommandText = "usp_MemberOf_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, _memberID));
                cmd.Parameters.Add(db.CreateParameter("@ParentID", System.Data.DbType.String, 20, _parentID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "DeleteMemberOf(string _parentID, string _memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int DeleteMemberOf(string _ParentID)
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
                cmd.CommandText = "usp_MemberOf_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ParentID", System.Data.DbType.String, 20, _ParentID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "Delete(string _memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<Member> GetObjectMemberOf(string _parentID,bool _isChild)
        {
            ListBase<Member> oListBase = new ListBase<Member>();
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MemberOf_Select_ParentID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ParentID", System.Data.DbType.String, 20, _parentID));
                cmd.Parameters.Add(db.CreateParameter("@IsChild", System.Data.DbType.Boolean, 1, _isChild));

                oDR = db.ExecuteReader(cmd);
                while (oDR.Read())
                {
                    oListBase.Add(new Member(oDR));
                }
                oDR.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MemberDAL", "GetObjectMemberOf(string _parentID,bool _isChild)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return oListBase;
        }
    }
    class UserDAL : MemberDAL<UserERP>
    { }
    class UserGroupDAL : MemberDAL<UserGroup>
    { }
}
