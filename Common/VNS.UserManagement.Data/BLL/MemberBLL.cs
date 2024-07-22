using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Utils;
using VNS.Data.BLL;
using VNS.Security;
namespace VNS.UserManagement.Data
{
    public class MemberBLL<T>: IBusiness
        where T:Member,new()
    {
        protected MemberDAL<T> dal = new MemberDAL<T>();
        public ListBase<Member> GetAll()
        { return dal.GetAll(); }
        public virtual int Insert(T t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    if (t is User)
                        (t as User).Password = "";
                    foreach (KeyValuePair<string, string> kvp in t.Property)
                    {
                        iError = dal.InsertUpdateProperty(t.MemberID, kvp.Key, kvp.Value);
                        if (iError != 0)
                            break;
                    }
                }
            }
            catch
            {
                iError = -1000;
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }
            return iError;
        }

        public virtual int Update(T t)
        {
            int iError = 0;
            try
            {
                dal.Open();
                dal.BeginTransaction();
                iError = dal.Update(t);
                if (iError == 0)
                {
                    if (iError == 0)
                    {
                        foreach (KeyValuePair<string, string> kvp in t.Property)
                        {
                            if (kvp.Key != User.enumPropertyID.PASSWORD.ToString())
                            {

                                iError = dal.InsertUpdateProperty(t.MemberID, kvp.Key, kvp.Value);
                                if (iError != 0)
                                    break;
                            }

                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MemberBLL", "Update(Member t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }

            return iError;
        }


        //public int Delete(string _memberID)
        //{
        //    return dal.Delete(_memberID);
        //}

        public int Delete(T t)
        {
            return dal.Delete(t);
        }

        public T GetByMemberID(string memberID)
        {

            return dal.GetObjectByID(memberID,new T().MemberType);
        }

        

        //public ListBase<Member> GetMemberOf(string parentID)
        //{
        //    return dal.GetObjectMemberOf(parentID, true);
        //}

        //public ListBase<Member> GetMemberNotOf(string parentID)
        //{
        //    return dal.GetObjectMemberOf(parentID, false);
        //}

        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as T);
        }
        public int Update(object obj)
        {
            return this.Update(obj as T);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as T);
        }
        #endregion
    }

    public class UserBLL : MemberBLL<User>
    {
        public ListBase<User> GetAllUser()
        {
            return dal.GetObjectByType(User.enumMemberType.USER.ToString());
        }
        public int UpdatePassword(User t)
        {
            return dal.InsertUpdateProperty(t.MemberID, User.enumPropertyID.PASSWORD.ToString(), Crypto.EncryptString(t.Password));

        }
    }
    public class UserGroupBLL : MemberBLL<UserGroup>
    {
        public ListBase<UserGroup> GetAllGroup()
        {
            return dal.GetObjectByType(UserGroup.enumMemberType.USERGROUP.ToString());
        }
        public override int Insert(UserGroup t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    foreach (KeyValuePair<string, string> kvp in t.Property)
                    {
                        iError = dal.InsertUpdateProperty(t.MemberID, kvp.Key, kvp.Value);
                        if (iError != 0)
                            break;
                    }
                }
                if (iError == 0)
                {
                    foreach (Member member in t.ListMember)
                    {
                        iError = dal.InsertMemberOf(t.MemberID, member.MemberID);
                        if (iError != 0)
                            break;
                    }
                }
            }
            catch
            {
                iError = -1000;
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }
            return iError;
        }
        public override int Update(UserGroup t)
        {
            int iError = 0;
            try
            {
                dal.Open();
                dal.BeginTransaction();
                iError = dal.Update(t);
                if (iError == 0)
                {
                    foreach (KeyValuePair<string, string> kvp in t.Property)
                    {
                        iError = dal.InsertUpdateProperty(t.MemberID, kvp.Key, kvp.Value);
                        if (iError != 0)
                            break;
                    }
                }
                if (iError == 0)
                {
                    iError = dal.DeleteMemberOf(t.MemberID);
                    if (iError == 0)
                    {
                        foreach (Member member in t.ListMember)
                        {
                            iError = dal.InsertMemberOf(t.MemberID, member.MemberID);
                            if (iError != 0)
                                break;
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("UserGroupBLL", "Update(UserGroup t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }

            return iError;

            
        }
    }
}
