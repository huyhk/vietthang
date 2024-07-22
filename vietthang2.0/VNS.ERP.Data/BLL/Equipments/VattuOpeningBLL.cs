using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Equipments
{
    public class VattuOpeningBLL:IBusiness
    {
        VattuOpeningDAL dal = new VattuOpeningDAL();
        public string StockCode = string.Empty;
        public string PeriodCode = string.Empty;
        public ListBase<VattuOpening> GetOpening()
        {
            return GetByPeriodAndStock(PeriodCode, StockCode);
        }
        public ListBase<VattuOpening> GetByPeriodAndStock(string periodCode, string stockCode)
        {
            return dal.GetByPeriodAndStock(periodCode, stockCode);
        }

        public int UpdateByPeriodAndStock(ListBase<VattuOpening> lst,string periodCode, string stockCode)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.DeleteByPeriodAndStock(periodCode, stockCode);
            if (iError == 0)
            {
                foreach (VattuOpening t in lst)
                {
                    t.PeriodCode = periodCode;
                    t.StockCode = stockCode;
                    iError = dal.Insert(t);
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }

        #region IBusiness Members

        public int Insert(object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int Update(object obj)
        {
            return UpdateByPeriodAndStock((obj as VattuOpeningList).ListVattuOpening, PeriodCode, StockCode);
        }

        public int Delete(object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
