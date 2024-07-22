using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanMonthBLL : IBusiness
    {
        ManufacturePlanMonthDAL dal = new ManufacturePlanMonthDAL();
        ManufacturePlanMonthDetailDAL dal1;
        public ManufacturePlanMonthBLL() { }
        public ListBase<ManufacturePlanMonth> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<ManufacturePlanMonthDetail> GetSumDetail(Guid manufacturePlanMonthID)
        {
            return dal.GetSumDetail(manufacturePlanMonthID);
        }
        public ListBase<ManufacturePlanMonth> GetByStockCode(string sCode)
        {
            return dal.GetByStockCode(sCode);
        }
        public ListBase<ManufacturePlanMonthDetail> GetDetail(Guid manufacturePlanMonthID)
        {
            return dal.GetDetail(manufacturePlanMonthID);
        }
        public DataTable GetDetailMaterial(Guid manufacturePlanMonthID)
        {
            return dal.GetDetailMaterial(manufacturePlanMonthID);
        }
        public int Insert(ManufacturePlanMonth t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal1 = new ManufacturePlanMonthDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (ManufacturePlanMonthDetail mpmd in t.Detail)
                {
                    mpmd.ManufacturePlanMonthID = t.ManufacturePlanMonthID;
                    if (iError == 0)
                    {
                        if (mpmd.Quantity > 0) iError = dal1.Insert(mpmd);
                    }
                    if(iError!=0) break;
                }
            }
            if (iError == 0)
            {
                int count = t.Detail.Count;
                for (int i = 0; i < count; i++)
                {
                    if (t.Detail[i].Quantity == 0)
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
        public int Update(ManufacturePlanMonth t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal1 = new ManufacturePlanMonthDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError= dal.Update(t);
            if (iError == 0)
            {
                if (t.Detail.Count > 0)
                {
                    iError = dal1.Delete(t.Detail[0]);
                }
            }
            if (iError == 0)
            {
                foreach (ManufacturePlanMonthDetail mpmd in t.Detail)
                {
                    mpmd.ManufacturePlanMonthID = t.ManufacturePlanMonthID;
                    if (iError == 0)
                    {
                        if(mpmd.Quantity>0) iError = dal1.Insert(mpmd);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                int count = t.Detail.Count;
                for (int i = 0; i < count; i++)
                {
                    if (t.Detail[i].Quantity == 0)
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
        public int Delete(ManufacturePlanMonth t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as ManufacturePlanMonth);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ManufacturePlanMonth);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ManufacturePlanMonth);
        }
        #endregion
    }
}
