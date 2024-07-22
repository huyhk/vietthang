using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.KCS
{
    public class MaterialTestTransactionBLL : IBusiness
    {
        MaterialTestTransactionDAL dal = new MaterialTestTransactionDAL();
        MaterialTestTransactionDetailDAL dalDetail = new MaterialTestTransactionDetailDAL();
        public MaterialTestTransactionBLL() { }
        public ListBase<MaterialTestTransaction> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<MaterialTestTransaction> GetDynamic(string whereCondition, string orderBy)
        {
            return dal.GetObjectDynamic(whereCondition,orderBy);
        }
        public string GetMaxTestTransactionNo(string stockCode)
        {
            string kq = string.Empty;
            ListBase<MaterialTestTransaction> lstDynamic = new MaterialTestTransactionBLL().GetDynamic("TestTransactionNo in (select max(TestTransactionNo) from MaterialTestTransactions where StockCode = '" + stockCode + "')", "");
            if (lstDynamic.Count > 0)
            {
                kq = lstDynamic[0].TestTransactionNo;
                Int32 i = 0;
                try
                {
                    i = Convert.ToInt32(kq);
                }
                catch
                {
                    throw;
                }
                i++;
                kq = i.ToString();
                while (kq.Length < 6)
                {
                    kq = "0" + kq;
                }
            }
            else
            {
                kq = "000001";
            }
            return kq;
        }
        public int Insert(MaterialTestTransaction t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new MaterialTestTransactionDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (MaterialTestTransactionDetail mttd in t.Detail)
                {
                    mttd.TestTransactionID = t.TestTransactionID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(mttd);
                        if (iError != 0) break;
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
        public int Update(MaterialTestTransaction t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new MaterialTestTransactionDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0 && t.Detail.Count > 0)
            {
                iError = dalDetail.Delete(t.Detail[0]);
            }
            if (iError == 0)
            {
                foreach (MaterialTestTransactionDetail mttd in t.Detail)
                {
                    mttd.TestTransactionID = t.TestTransactionID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(mttd);
                        if (iError != 0) break;
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
        public int Delete(MaterialTestTransaction t)
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
        public ListBase<MaterialTestTransaction> GetByDate(DateTime startDate, DateTime endDate)
        {
            return dal.GetByDate(startDate, endDate);
        }
        public ListBase<MaterialTestTransaction> GetByDateAndStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.GetByDateAndStockCode(startDate, endDate, stockCode);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as MaterialTestTransaction);
        }
        public int Update(object obj)
        {
            return this.Update(obj as MaterialTestTransaction);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as MaterialTestTransaction);
        }
        #endregion
    }
}
