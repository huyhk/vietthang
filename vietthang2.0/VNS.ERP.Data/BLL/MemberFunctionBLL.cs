using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class MemberFunctionBLL:IBusiness
    {
        MemberFunctionDAL dal = new MemberFunctionDAL();
        public MemberFunctionBLL() { }
        public int UpdateForMemberID(string _MemberID, ref DataTable DT)
        {
            int iError = 0;
            int count = DT.Rows.Count;
            bool alreadyOpen = false;
            MemberFunction mb;
          

            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();
            iError = dal.DeleteByMemberID(_MemberID);
            for (int i = 0; i < count; i++)
            {
                if (iError == 0)
                {
                    bool AllowView = false, AllowAdd = false, AllowEdit = false, AllowDelete = false, AllowEditOther = false, AllowDeleteOther = false;
                    if (DT.Rows[i]["AllowView"] != DBNull.Value)
                    {
                        AllowView = Convert.ToBoolean(DT.Rows[i]["AllowView"]);
                    }

                    if (DT.Rows[i]["AllowAdd"] != DBNull.Value)
                    {
                        AllowAdd = Convert.ToBoolean(DT.Rows[i]["AllowAdd"]);
                    }
                    if (DT.Rows[i]["AllowEdit"] != DBNull.Value)
                    {
                        AllowEdit = Convert.ToBoolean(DT.Rows[i]["AllowEdit"]);
                    }
                    if (DT.Rows[i]["AllowDelete"] != DBNull.Value)
                    {
                        AllowDelete = Convert.ToBoolean(DT.Rows[i]["AllowDelete"]);
                    }
                    if (DT.Rows[i]["AllowEditOther"] != DBNull.Value)
                    {
                        AllowEditOther = Convert.ToBoolean(DT.Rows[i]["AllowEditOther"]);
                    }
                    if (DT.Rows[i]["AllowDeleteOther"] != DBNull.Value)
                    {
                        AllowDeleteOther = Convert.ToBoolean(DT.Rows[i]["AllowDeleteOther"]);
                    }

                    bool HasCheck = AllowView || AllowAdd || AllowEdit || AllowDelete;
                    if (HasCheck)
                    {
                        mb= new MemberFunction();
                        mb.MemberID = _MemberID;
                        mb.FunctionName = DT.Rows[i]["FunctionName"].ToString();
                        mb.AllowView = AllowView;
                        mb.AllowAdd = AllowAdd;
                        mb.AllowEdit = AllowEdit;
                        mb.AllowDelete = AllowDelete;
                        mb.AllowEditOther = AllowEditOther;
                        mb.AllowDeleteOther = AllowDeleteOther;
                        iError =dal.Insert(mb);
                    }
                }
                else break;
            }
            if (iError != 0) dal.Rollback();
            else dal.Commit();
            //dal.Close();
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public ListBase<MemberFunction> GetAll()
        {
            return dal.GetObjectAll();
        }
        public DataTable DTGetByMemberID(string _MemberID)
        {
            return dal.DTGetByMemberID(_MemberID);
        }
        public ListBase<MemberFunction> GetAllForMemberID(string _MemberID)
        {
            return dal.GetAllForMemberID(_MemberID);
        }
        public int Insert(MemberFunction t)
        {
            return dal.Insert(t);
        }
        public int Update(MemberFunction t)
        {
            return dal.Update(t);
        }

        public int Delete(MemberFunction t)
        {
            return dal.Delete(t);
        }

        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as MemberFunction);
        }

        public int Update(object obj)
        {
            return this.Update(obj as MemberFunction);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as MemberFunction);
        }

        #endregion
    }
}
