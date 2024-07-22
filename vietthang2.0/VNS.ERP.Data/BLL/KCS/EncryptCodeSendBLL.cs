using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class EncryptCodeSendBLL : IBusiness
    {
        EncryptCodeSendDAL dal = new EncryptCodeSendDAL();
        EncryptCodeSendDetailDAL dalDetail = new EncryptCodeSendDetailDAL();
        public EncryptCodeSendBLL() { }
        public ListBase<EncryptCodeSend> GetAll()
        {
            return dal.GetObjectAll();
        }
        public string EncryptCodeSendsSetNewNo(DateTime sendDate)
        {
            return dal.EncryptCodeSendsSetNewNo(sendDate);
        }
        public DataSet GetMaterialEncryptCodeNotSend(string subjectCode)
        {
            return dal.GetMaterialEncryptCodeNotSend(subjectCode);
        }
        public DataSet GetProductEncryptCodeNotSend(string subjectCode)
        {
            return dal.GetProductEncryptCodeNotSend(subjectCode);
        }
        public ListBase<EncryptCodeSend> GetForPeriodAndSubjectCode(DateTime startDate, DateTime endDate, string subjectCode)
        {
            return dal.GetForPeriodAndSubjectCode(startDate, endDate, subjectCode);
        }
        public int Insert(EncryptCodeSend t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new EncryptCodeSendDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Insert(t);
            if (iError == 0)
            {
                t.RefreshDetail();
                foreach (EncryptCodeSendDetail detail in t.Detail)
                {
                    detail.SendID = t.SendID;
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
        public int Update(EncryptCodeSend t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new EncryptCodeSendDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.SendID);
            }
            if (iError == 0)
            {
                t.RefreshDetail();
                foreach (EncryptCodeSendDetail detail in t.Detail)
                {
                    detail.SendID = t.SendID;
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
        public int Delete(EncryptCodeSend t)
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
            return this.Insert(obj as EncryptCodeSend);
        }
        public int Update(object obj)
        {
            return this.Update(obj as EncryptCodeSend);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as EncryptCodeSend);
        }
        #endregion
    }
}
