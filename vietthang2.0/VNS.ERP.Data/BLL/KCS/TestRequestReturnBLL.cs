using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class TestRequestReturnBLL : IBusiness
    {
        TestRequestReturnDAL dal = new TestRequestReturnDAL();
        TestRequestReturnDetailDAL dalDetail = null;
        TestRequestReturnLinkDAL dalLink = null;
        public TestRequestReturnBLL() { }
        //public TestRequestReturn GetByReturnID(Guid returnID)
        //{
        //    return dal.GetByReturnID(returnID);
        //}
        public ListBase<TestRequestReturn> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int CancelApplyResult(string itemEncryptCode, string techCode, string subjectCode, bool isProduct)
        {
            dalDetail = new TestRequestReturnDetailDAL();
            return dalDetail.CancelApplyResult(itemEncryptCode, techCode, subjectCode, isProduct);
        }
        public int ApplyResult(string itemEncryptCode, string techCode, string subjectCode, bool isProduct)
        {
            dalDetail = new TestRequestReturnDetailDAL();
            return dalDetail.ApplyResult(itemEncryptCode, techCode, subjectCode, isProduct);
        }
        public DataSet GetForApplyResult(string itemEncryptCode, bool isProduct)
        { 
            return dal.GetForApplyResult(itemEncryptCode,isProduct);
        }
        public int UpdateIsReceived(TestRequestReturn t)
        {
            dal.Open();
            dal.BeginTransaction();
            int iError = dal.UpdateIsReceived(t);
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }
        public ListBase<TestRequestReturn> GetForPeriod(DateTime startDate, DateTime endDate)
        {
            return dal.GetForPeriod(startDate, endDate);
        }
        public int Insert(TestRequestReturn t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new TestRequestReturnDetailDAL(dal.DBHelper);
            dalLink = new TestRequestReturnLinkDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Insert(t);
            if (iError == 0)
            {
                t.RefreshDetail();
                foreach (TestRequestReturnDetail detail in t.Detail)
                {
                    detail.ReturnID = t.ReturnID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (TestRequestReturnLink link in t.Link)
                {
                    link.RequestReturnID = t.ReturnID;
                    if (iError == 0)
                    {
                        iError = dalLink.Insert(link);
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
        public int Update(TestRequestReturn t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new TestRequestReturnDetailDAL(dal.DBHelper);
            dalLink = new TestRequestReturnLinkDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.ReturnID);
            }
            if (iError == 0)
            {
                iError = dalLink.Delete(t.ReturnID);
            }
            if (iError == 0)
            {
                t.RefreshDetail();
                foreach (TestRequestReturnDetail detail in t.Detail)
                {
                    detail.ReturnID = t.ReturnID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (TestRequestReturnLink link in t.Link)
                {
                    link.RequestReturnID = t.ReturnID;
                    if (iError == 0)
                    {
                        iError = dalLink.Insert(link);
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
        public int Delete(TestRequestReturn t)
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
            return this.Insert(obj as TestRequestReturn);
        }
        public int Update(object obj)
        {
            return this.Update(obj as TestRequestReturn);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as TestRequestReturn);
        }
        #endregion
    }
}
