using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{

    public class SubjectTypeBLL:IBusiness
    {
        private SubjectTypeDAL dal = new SubjectTypeDAL();
        public SubjectTypeBLL() { }
        
        
        public ListBase<SubjectType> GetAll()
        {
            return dal.GetObjectAll();
        }

        public int Insert(SubjectType t)
        {
            t.UserCreated = Contexts.CurrentUser.LoginName;
            return dal.Insert(t);
        }
        public int Update(SubjectType t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(t);
        }
        public int Delete(SubjectType t)
        {
           return dal.Delete(t);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as SubjectType);
        }

        public int Update(object obj)
        {
            return this.Update(obj as SubjectType);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as SubjectType);
        }

        #endregion
    }
    public static class SystemType
    {
        public static bool CheckSystemType(string subjectTypeCode)
        {
            bool check = false;
            foreach (string enumType in Enum.GetNames(typeof(enumSubjectType)))
            {
                if (enumType == subjectTypeCode)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
    }
}
