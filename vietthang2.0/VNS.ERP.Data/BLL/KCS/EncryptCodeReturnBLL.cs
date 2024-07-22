using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class EncryptCodeReturnBLL : IBusiness
    {
        EncryptCodeReturnDAL dal = new EncryptCodeReturnDAL();
        EncryptCodeReturnDetailDAL dalDetail = new EncryptCodeReturnDetailDAL();
        public EncryptCodeReturnBLL() { }
        public ListBase<EncryptCodeReturn> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<EncryptCodeReturn> GetForTestRequestReturnCheck(Guid returnID)
        {
            return dal.GetForTestRequestReturnCheck(returnID);
        }
        public ListBase<EncryptCodeReturn> GetForPeriodAndSubjectCode(DateTime startDate, DateTime endDate, string subjectCode)
        {
            return dal.GetForPeriodAndSubjectCode(startDate, endDate, subjectCode);
        }
        public DataSet GetMaterialEncryptCodeNotReturn(string subjectCode)
        {
            return dal.GetMaterialEncryptCodeNotReturn(subjectCode);
        }
        public DataSet GetProductEncryptCodeNotReturn(string subjectCode)
        {
            return dal.GetProductEncryptCodeNotReturn(subjectCode);
        }
        public DataSet GetEncryptCodeNotReturn(string subjectCode)
        {
            return dal.GetEncryptCodeNotReturn(subjectCode);
        }
        public int Insert(EncryptCodeReturn t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new EncryptCodeReturnDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Insert(t);
            if (iError == 0)
            {
                t.RefreshDetail();
                foreach (EncryptCodeReturnDetail detail in t.Detail)
                {
                    detail.ReturnID = t.ReturnID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
                    }
                    if (iError != 0) break;
                }
            }

            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Update(EncryptCodeReturn t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new EncryptCodeReturnDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.ReturnID);
            }
            if (iError == 0)
            {
                t.RefreshDetail();
                foreach (EncryptCodeReturnDetail detail in t.Detail)
                {
                    detail.ReturnID = t.ReturnID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
                    }
                    if (iError != 0) break;
                }
            }

            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
       
        public int Delete(EncryptCodeReturn t)
        {
            dal.Open();
            dal.BeginTransaction();
            int iError = dal.Delete(t);
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as EncryptCodeReturn);
        }
        public int Update(object obj)
        {
            return this.Update(obj as EncryptCodeReturn);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as EncryptCodeReturn);
        }
        #endregion
    }
}
