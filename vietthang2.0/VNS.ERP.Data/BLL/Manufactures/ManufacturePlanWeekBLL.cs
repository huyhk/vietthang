using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanWeekBLL : IBusiness
    {
        ManufacturePlanWeekDetailDAL dal1;
        ManufacturePlanWeekDAL dal = new ManufacturePlanWeekDAL();
        public ManufacturePlanWeekBLL() { }
        public DataTable GetDetailMaterial(Guid manufacturePlanWeekID)
        {
            return dal.GetDetailMaterial(manufacturePlanWeekID);
        }
        public ListBase<ManufacturePlanWeek> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<ManufacturePlanWeekDetail> GetSumDetail(Guid manufacturePlanWeekID)
        {
            return dal.GetSumDetail(manufacturePlanWeekID);
        }
        public ListBase<ManufacturePlanWeekDetail> GetDetail(Guid manufacturePlanWeekID)
        {
            return dal.GetDetail(manufacturePlanWeekID);
        }
        public ListBase<ManufacturePlanWeek> GetByStockCode(string sCode, int year)
        {
            return dal.GetByStockCode(sCode, year);
        }
        public int Insert(ManufacturePlanWeek t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal1 = new ManufacturePlanWeekDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError=dal.Insert(t);
            if (iError == 0)
            {
                foreach (ManufacturePlanWeekDetail mpwd in t.Detail)
                {
                    mpwd.ManufacturePlanWeekID = t.ManufacturePlanWeekID;
                    if (iError == 0)
                    {
                        if (mpwd.Day1 + mpwd.Day2 + mpwd.Day3 + mpwd.Day4 + mpwd.Day5 + mpwd.Day6 + mpwd.Day7 != 0) iError = dal1.Insert(mpwd);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                int count = t.Detail.Count;
                for (int i = 0; i < count; i++)
                {
                    if (t.Detail[i].Day1 + t.Detail[i].Day2 + t.Detail[i].Day3 + t.Detail[i].Day4 + t.Detail[i].Day5 + t.Detail[i].Day6 + t.Detail[i].Day7 == 0)
                    {
                        t.Detail.RemoveAt(i);
                        i -= 1;
                        count -= 1;
                    }
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
        public int Update(ManufacturePlanWeek t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal1 = new ManufacturePlanWeekDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                if (t.Detail.Count > 0)
                {
                    iError = dal1.Delete(t.Detail[0]);
                }
            }
            if (iError == 0)
            {
                foreach (ManufacturePlanWeekDetail mpwd in t.Detail)
                {
                    mpwd.ManufacturePlanWeekID = t.ManufacturePlanWeekID;
                    if (iError == 0)
                    {
                        if (mpwd.Day1 + mpwd.Day2 + mpwd.Day3 + mpwd.Day4 + mpwd.Day5 + mpwd.Day6 + mpwd.Day7 != 0) iError = dal1.Insert(mpwd);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                int count = t.Detail.Count;
                for (int i = 0; i < count; i++)
                {
                    if (t.Detail[i].Day1 + t.Detail[i].Day2 + t.Detail[i].Day3 + t.Detail[i].Day4 + t.Detail[i].Day5 + t.Detail[i].Day6 + t.Detail[i].Day7 == 0)
                    {
                        t.Detail.RemoveAt(i);
                        i -= 1;
                        count -= 1;
                    }
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
        public int Delete(ManufacturePlanWeek t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as ManufacturePlanWeek);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ManufacturePlanWeek);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ManufacturePlanWeek);
        }
        #endregion
    }
}
