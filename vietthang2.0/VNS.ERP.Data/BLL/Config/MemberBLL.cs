using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Utils;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
    public class MemberBLL<T> : IBusiness
        where T:Member,new()
    {
        protected MemberDAL<T> dal = new MemberDAL<T>();
        public ListBase<Member> GetAll()
        { return dal.GetAll(); }
        public int Insert(T t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    for (int i = 0; i <= t.Properties.Length - 1; i++)
                    {
                        iError = dal.InsertUpdateProperty(t.MemberID, (byte)i, t.Properties[i]);
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

        public int Update(T t)
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
                        for (int i = 0; i <= t.Properties.Length - 1; i++)
                        {
                            iError = dal.InsertUpdateProperty(t.MemberID, (byte)i, t.Properties[i]);
                            if (iError != 0)
                                break;
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
        public int UpdatePassword(UserERP t)
        {
            return dal.InsertUpdateProperty(t.LoginName,(byte) enumUserProperties.Password, t.Password);
     
        }

        //public int Delete(string _memberID)
        //{
        //    return dal.Delete(_memberID);
        //}

        public int Delete(T t)
        {
            return dal.Delete(t);
        }

        public T GetByMemberID(string _memberID)
        {
            return dal.GetObjectByID(_memberID);
        }

        public int InsertMemberOf(string _parentID, string _childID)
        {
            return dal.InsertMemberOf(_parentID, _childID);
        }

        public int UpdateMemberOf(T _Member, ListBase<Member> t)
        {
            int Error = 0;
            //if (t.Count > 0)
            //{
                dal.Open();
                dal.BeginTransaction();
                Error = dal.Update(_Member);
                if (Error == 0)
                {
                    Error = dal.DeleteMemberOf(_Member.MemberID);
                }
                if (Error == 0)
                    foreach (Member ItemMember in t)
                    {
                        Error = dal.InsertMemberOf(_Member.MemberID, ItemMember.MemberID);
                        if (Error != 0) break;
                    }

                if (Error == 0)
                    dal.Commit();
                else
                    dal.Rollback();

                dal.Close();
            //}
            //else
            //{
            //    Error = -100;
            //}
            return Error;


        }
        public int InsertMemberOf(Member _Member, ListBase<Member> t)
        {
            int Error = 0;
            MemberDAL<Member> User = new MemberDAL<Member>(dal.DBHelper);
            //if (t.Count > 0)
            //{
                dal.Open();
                dal.BeginTransaction();
 
                Error = User.Insert(_Member);
                if (Error == 0)
                    foreach (Member ItemMember in t)
                    {
                        Error = dal.InsertMemberOf(_Member.MemberID, ItemMember.MemberID);
                        if (Error != 0) break;
                    }

                if (Error == 0)
                    dal.Commit();
                else
                    dal.Rollback();

                dal.Close();
            //}
            //else
            //{
            //    Error = User.Insert(_Member);
            //}
            return Error;


        }

        public int DeleteMemberOf(string _parentID, string _childID)
        {
            return dal.DeleteMemberOf(_parentID, _childID);
        }

        public ListBase<Member> GetMemberOf(string _parentID)
        {
            return dal.GetObjectMemberOf(_parentID, true);
        }

        public ListBase<Member> GetMemberNotOf(string _parentID)
        {
            return dal.GetObjectMemberOf(_parentID, false);
        }

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
    public class UserBLL : MemberBLL<UserERP>
    {
        public ListBase<UserERP> GetAllUser()
        {
            return dal.GetObjectByType((byte)enumMemberType.User);
        }
    }
    public class UserGroupBLL : MemberBLL<UserGroup>
    {
        public ListBase<UserGroup> GetAllGroup()
        {
            return dal.GetObjectByType((byte)enumMemberType.Group);
        }
       
        
       
        
    }
}
