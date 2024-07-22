using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;

namespace VNS.ERP.Data
{
    public class BocxepResultBLL : IBusiness
    {
        BocxepResultDAL dal = new BocxepResultDAL();
        BocxepResultDetailDAL dalDetail = new BocxepResultDetailDAL();
        public BocxepResultBLL() { }
        public ListBase<BocxepResult> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<BocxepResult> GetForContractNoAndStockCode(string contractNo, string stockCode)
        {
            return dal.GetForContractNoAndStockCode(contractNo, stockCode);
        }
        public ListBase<BocxepResult> GetForBXSubjectCodeAndStockCode(string bxSubjectCode, string stockCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetForBXSubjectCodeAndStockCode(bxSubjectCode, stockCode, startDate, endDate);
        }
        public ListBase<BocxepType> GetListTypeCodeForDetail(string bxSubjectCode, string stockCode)
        {
            return dal.GetListTypeCodeForDetail(bxSubjectCode, stockCode);
        }
        public DataTable GetAllForWorkingTypes()
        {
            return dal.GetAllForWorkingTypes();
        }
        public DataSet Report_BocxepResults(DateTime fromDate, DateTime toDate)
        {
            return dal.Report_BocxepResults(fromDate, toDate);
        }
        public int Insert(BocxepResult t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            //dalDetail = new BocxepResultDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (BocxepResultDetail1 detail1 in t.ListDetail1)
                {
                    detail1.ResultID = t.ResultID;
                    iError = dal.InsertDetail1(detail1);
                    if (iError != 0) break;
                    foreach (BocxepResultDetail2 detail2 in detail1.ListDetail2)
                    {
                        detail2.Detail1ID = detail1.Detail1ID;
                        iError = dal.InsertDetail2(detail2);
                        if (iError != 0) break;
                        foreach (BocxepResultDetail3 detail3 in detail2.ListDetail3)
                        {
                            detail3.Detail2ID = detail2.Detail2ID;
                            iError = dal.InsertDetail3(detail3);
                            if (iError != 0) break;
                        }
                        if (iError != 0) break;
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
                iError = dal.UpdatePriceByResultID(t.ResultID);
            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Update(BocxepResult t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            //dalDetail = new BocxepResultDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal.DeleteDetail1(t.ResultID);
            }
            if (iError == 0)
            {
                foreach (BocxepResultDetail1 detail1 in t.ListDetail1)
                {
                    detail1.ResultID = t.ResultID;
                    iError = dal.InsertDetail1(detail1);
                    if (iError != 0) break;
                    foreach (BocxepResultDetail2 detail2 in detail1.ListDetail2)
                    {
                        detail2.Detail1ID = detail1.Detail1ID;
                        iError = dal.InsertDetail2(detail2);
                        if (iError != 0) break;
                        foreach (BocxepResultDetail3 detail3 in detail2.ListDetail3)
                        {
                            detail3.Detail2ID = detail2.Detail2ID;
                            iError = dal.InsertDetail3(detail3);
                            if (iError != 0) break;
                        }
                        if (iError != 0) break;
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
                iError = dal.UpdatePriceByResultID(t.ResultID);

            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Delete(BocxepResult t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as BocxepResult);
        }
        public int Update(object obj)
        {
            return this.Update(obj as BocxepResult);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as BocxepResult);
        }
        #endregion

        public int UpdatePriceByDate(DateTime fromDate, DateTime toDate)
        {
            return dal.UpdatePriceByDate(fromDate, toDate);
        }
    }
}
