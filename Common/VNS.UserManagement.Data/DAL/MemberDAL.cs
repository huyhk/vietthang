using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Data.DAL;

using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using VNS.Security;

namespace VNS.UserManagement.Data
{

    public class MemberDAL<T> : BaseDAL<T>
    where T : Member, new()
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
                cmd.CommandText = "usp_Member_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, t.MemberID));
                cmd.Parameters.Add(db.CreateParameter("@MemberName", System.Data.DbType.String, 50, t.MemberName));
                cmd.Parameters.Add(db.CreateParameter("@MemberType", System.Data.DbType.String, 20, t.MemberType));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));

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
                cmd.CommandText = "usp_Member_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, t.MemberID));
                cmd.Parameters.Add(db.CreateParameter("@MemberName", System.Data.DbType.String, 50, t.MemberName));
                cmd.Parameters.Add(db.CreateParameter("@MemberType", System.Data.DbType.String, 20, t.MemberType));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
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
        public int Delete(string memberID)
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
                cmd.CommandText = "usp_Member_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, memberID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "Delete(string memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int InsertUpdateProperty(string memberID, string propertyID, string propertyValue)
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

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, memberID));
                cmd.Parameters.Add(db.CreateParameter("@PropertyID", System.Data.DbType.String, 20, propertyID));
                if (propertyValue != null)
                    cmd.Parameters.Add(db.CreateParameter("@PropertyValue", System.Data.DbType.String, 100, propertyValue));
                else
                    cmd.Parameters.Add(db.CreateParameter("@PropertyValue", System.Data.DbType.String, 100, DBNull.Value));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "InsertUpdateProperty(string memberID, string propertyID,string propertyValue)", excp.Message);
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
                cmd.CommandText = "usp_Member_SelectAll";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                oDR = db.ExecuteReader(cmd);

                while (oDR.Read())
                {
                    Member obj = new Member();
                    obj.FromDataReader(oDR);
                    lstReturn.Add(obj);
                }
                oDR.Close();
            }
            catch (Exception excp)
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
        public ListBase<T> GetObjectByType(string memberType)
        {
            ListBase<T> oListBase = new ListBase<T>();
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Member_Select_Type";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@Type", System.Data.DbType.String, 20, memberType));

                ds = db.ExecuteDataSet(cmd);

                DataRelation dtRelation = ds.Relations.Add("Member",
                   ds.Tables[0].Columns["MemberID"],
                   ds.Tables[1].Columns["MemberID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    T t = new T();
                    t.FromDataRow(dr);
                    foreach (DataRow drChild in dr.GetChildRows(dtRelation))
                    {
                        t.LoadPropertyFromDataRow(drChild);
                    }
                    oListBase.Add(t);
                }

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MemberDAL", "GetObjectByType(string memberType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return oListBase;
        }

        

        public T GetObjectByID(string memberID, string memberType)
        {
            T t = null;
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Member_Select_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, memberID));
                if (memberType!=string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@MemberType", System.Data.DbType.String, 20, memberType));

                
                ds = db.ExecuteDataSet(cmd);

                DataRelation dtRelation = ds.Relations.Add("Member",
                   ds.Tables[0].Columns["MemberID"],
                   ds.Tables[1].Columns["MemberID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    t = new T();
                    t.FromDataRow(dr);
                    foreach (DataRow drChild in dr.GetChildRows(dtRelation))
                    {
                        t.LoadPropertyFromDataRow(drChild);
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MemberDAL", "GetObjectByID(string memberID, string memberType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return t;
        }

        /// <summary>
        /// add a Member into a UserGroup
        /// </summary>
        /// <param name="parentID"> the ID of the UserGroup</param>
        /// <param name="memberID">the ID of the Member</param>
        /// <returns></returns>
        public int InsertMemberOf(string parentID, string memberID)
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

                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, memberID));
                cmd.Parameters.Add(db.CreateParameter("@ParentID", System.Data.DbType.String, 20, parentID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "InsertMemberOf(string parentID, string memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// remove all the members out of a UserGroup
        /// </summary>
        /// <param name="parentID">the ID of the UserGroup to reset all the member belong to</param>
        /// <returns></returns>
        public int DeleteMemberOf(string parentID)
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
                cmd.CommandText = "usp_MemberOf_Delete_ParentID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ParentID", System.Data.DbType.String, 20, parentID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("MemberDAL", "DeleteMemberOf(string parentID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Get the list of members belong (or not belong) to a parent member (User group)
        /// </summary>
        /// <param name="parentID">the ID of the User Group</param>
        /// <param name="isChild">true to get the list of member belong to the UserGroup, false to get the list of member that not belong</param>
        /// <returns></returns>
        public ListBase<Member> GetObjectMemberOf(string parentID, bool isChild)
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

                cmd.Parameters.Add(db.CreateParameter("@ParentID", System.Data.DbType.String, 20, parentID));
                cmd.Parameters.Add(db.CreateParameter("@IsChild", System.Data.DbType.Boolean, 1, isChild));

                oDR = db.ExecuteReader(cmd);
                while (oDR.Read())
                {
                    oListBase.Add(new Member(oDR));
                }
                oDR.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MemberDAL", "GetObjectMemberOf(string parentID,bool isChild)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return oListBase;
        }
        

    }

    class UserDAL : MemberDAL<User>
    { }
    class UserGroupDAL : MemberDAL<UserGroup>
    {
        
    }
}
