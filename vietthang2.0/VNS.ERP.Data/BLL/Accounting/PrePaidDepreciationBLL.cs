using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Accounting
{

	/// <summary>
	/// This object represents the properties and methods of a Business Layer of FixedAssetOpening.
	/// </summary>
	public class PrePaidDepreciationBLL 
	{
        private PrePaidDepreciationDAL dal = new PrePaidDepreciationDAL();
        private PrePaidExpenseOpeningDAL dalOpen;// = new PrePaidExpenseOpeningDAL();
        private AccountTransactionDetail1DAL dalTranDetail1;
        public PrePaidDepreciationBLL()
		{
		}

	
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int InsertListPrePaidDepreciation(DataTable dtInsert,string preiodCode,string periodCodeLast)
		{
            dalOpen = new PrePaidExpenseOpeningDAL();
            int iError=0;
            dal.Open();
            dal.BeginTransaction();
            try 
	        {
                iError = dal.DeleteByPeriodCode(preiodCode);
                if(iError==0)
                    iError = dalOpen.DeleteByPeriodCode(periodCodeLast);
                if (iError == 0)
                {
                    foreach (DataRow dr in dtInsert.Rows)
                    {
                        PrePaidDepreciation prePaid = new PrePaidDepreciation();
                        prePaid.PeriodCode = preiodCode;
                        prePaid.PrePaidCode = dr["PrePaidCode"].ToString();
                        prePaid.Amount = decimal.Parse(dr["DepRateMonthInput"].ToString());
                        iError = dal.Insert(prePaid);
                        if (iError != 0)
                            break;
                        PrePaidExpenseOpening preOpen = new PrePaidExpenseOpening();
                        preOpen.PeriodCode = periodCodeLast;
                        preOpen.PrePaidCode = dr["PrePaidCode"].ToString();
                        preOpen.AccumulatedDepreciation = decimal.Parse(dr["AccumulatedDepLastMonth"].ToString());
                        preOpen.RemainCost=decimal.Parse(dr["RemainCost"].ToString());
                        preOpen.DepStartDate = DateTime.Parse(dr["DepStartDate"].ToString());
                        preOpen.DepRate = decimal.Parse(dr["DepRate"].ToString());
                        preOpen.DepMonth = int.Parse(dr["DepMonth"].ToString());
                        preOpen.PrePaidNo = dr["PrePaidNo"].ToString();
                        preOpen.PrePaidDate = DateTime.Parse(dr["PrePaidDate"].ToString());
                        iError = dalOpen.Insert(preOpen);
                        if (iError != 0)
                            break;
                    }
                }
	        }
	        catch
	        {
                iError=-1000;
	        }
            finally
            {
                if (iError != 0)
                    dal.Rollback();
                else
                    dal.Commit();
                dal.Close();
            }
            return iError;
		}
        public int InsertListPrePaidDepreciation(DataTable dtInsert, string preiodCode, string periodCodeLast, string accountCode)
        {
            dalOpen = new PrePaidExpenseOpeningDAL(dal.DBHelper);
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.DeleteByPeriodCode(preiodCode, accountCode);
                if (iError == 0)
                    iError = dalOpen.DeleteByPeriodCode(periodCodeLast, accountCode);
                if (iError == 0)
                {
                    foreach (DataRow dr in dtInsert.Rows)
                    {
                        PrePaidDepreciation prePaid = new PrePaidDepreciation();
                        prePaid.PeriodCode = preiodCode;
                        prePaid.PrePaidCode = dr["PrePaidCode"].ToString();
                        if (dr.IsNull("DepRateMonthInput"))
                            prePaid.Amount = 0;
                        else
                            prePaid.Amount = decimal.Parse(dr["DepRateMonthInput"].ToString());
                        iError = dal.Insert(prePaid);
                        if (iError != 0)
                            break;
                        PrePaidExpenseOpening preOpen = new PrePaidExpenseOpening();
                        preOpen.PeriodCode = periodCodeLast;
                        preOpen.PrePaidCode = dr["PrePaidCode"].ToString();
                        preOpen.AccumulatedDepreciation = decimal.Parse(dr["AccumulatedDepLastMonth"].ToString());
                        preOpen.RemainCost = decimal.Parse(dr["RemainCost"].ToString());
                        preOpen.DepStartDate = DateTime.Parse(dr["DepStartDate"].ToString());
                        preOpen.DepRate = decimal.Parse(dr["DepRate"].ToString());
                        preOpen.DepMonth = int.Parse(dr["DepMonth"].ToString());
                        preOpen.PrePaidNo = dr["PrePaidNo"].ToString();
                        preOpen.PrePaidDate = DateTime.Parse(dr["PrePaidDate"].ToString());
                        iError = dalOpen.Insert(preOpen);
                        if (iError != 0)
                            break;
                    }
                }
            }
            catch
            {
                iError = -1000;
            }
            finally
            {
                if (iError != 0)
                    dal.Rollback();
                else
                    dal.Commit();
                dal.Close();
            }
            return iError;
        }
        /// <summary>
        /// Updates an object into database by calling Updates StoredProcedure
        /// </summary>
        public int Update(PrePaidDepreciation t)
		{
            return 0;
		}
        /// <summary>
        /// Deletes an object into database by calling Deletes StoredProcedure
        /// </summary>
        public int Delete(PrePaidDepreciation t)
        {
            return 0;
        }
      
        public int DeleteByPeriodCode(string periodCode)
        {
            return dal.DeleteByPeriodCode(periodCode);
        }

        public ListBase<PrePaidDepreciation> GetListPrePaidDepreciationByPeriodCode(string periodCode)
        {
            return dal.GetListPrePaidDepreciationByPeriodCode(periodCode);
        }

        public DataTable GetListDepRatePaidDepreciation(DateTime startDate, DateTime endDate, string accountCode, string periodCode)
        {
            ListBase<PrePaidDepreciation> lstPrePaidDep = null;
            ListBase<PrePaidReDepreciation> lstPrePaidReDep = null;
            DataTable dtReturn = new DataTable();

            dtReturn = dal.GetListRatePaidDepreciations(startDate, endDate, accountCode, periodCode);
            dtReturn.Columns.Add("DepRateMonthCal", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("DepRateMonthInput", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("AccumulatedDepLastMonth", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("DateTest", typeof(DateTime)).DefaultValue = DateTime.Today;
            lstPrePaidDep = dal.GetListPrePaidDepreciationByPeriodCode(periodCode);
            lstPrePaidReDep = (new PrePaidReDepreciationDAL()).GetListPrePaidReDepreciationByPeriodCode(periodCode);
            foreach (DataRow dr in dtReturn.Rows)
            {
                PrePaidReDepreciation prePaid = lstPrePaidReDep.Search("PrePaidCode", dr["PrePaidCode"]);
                if (prePaid != null)
                {
                    dr["DepStartDate"] = startDate;
                    dr["DepRate"] = prePaid.DepRate;
                    dr["DepMonth"] = prePaid.DepMonth;
                }
                dr["DateTest"] = ((DateTime)dr["DepStartDate"]).AddMonths((int)dr["DepMonth"]-1);
                if ((decimal)dr["Amount"] != 0)
                    dr["DepRateMonthCal"] = decimal.Round(decimal.Round(((decimal)(dr["Amount"]) * ((decimal)dr["DepRate"])),0) / ((int)dr["DepMonth"]),0);
                dr["AccumulatedDepLastMonth"] = dr["AccumulatedDepreciation"].ToString();
                dr["RemainCost"] =((decimal)dr["Amount"]) - ((decimal)dr["AccumulatedDepLastMonth"]);
                dr["DepRateMonthCal"] = Math.Min((decimal)dr["DepRateMonthCal"], (decimal)dr["RemainCost"]);
            }
            if (lstPrePaidDep.Count > 0)
            {
                foreach (DataRow dr in dtReturn.Rows)
                {
                    PrePaidDepreciation prePaid = lstPrePaidDep.Search("PrePaidCode", dr["PrePaidCode"]);
                    if (prePaid != null)
                    {
                        dr["DepRateMonthInput"] = prePaid.Amount;
                        dr["AccumulatedDepLastMonth"] = ((decimal)dr["AccumulatedDepreciation"])+prePaid.Amount;
                        dr["RemainCost"] = ((decimal)dr["Amount"] - (decimal)dr["AccumulatedDepLastMonth"]);
                    }
                }
            }
            for (int i = dtReturn.Rows.Count - 1; i >= 0; i--)
            {
                if ((decimal)dtReturn.Rows[i]["DepRateMonthCal"] == 0)
                    dtReturn.Rows.RemoveAt(i);
            }
            return dtReturn;
        }

        public ListBase<AccountTransactionDetail1> GetListBaseDetal1ByPeriodCode(string periodCode)
        {
            dalTranDetail1 = new AccountTransactionDetail1DAL();
            return dalTranDetail1.GetListBaseByPeriodCodeFromPrePaidDepreciations(periodCode);
        }
        public ListBase<AccountTransactionDetail2> GetListBaseDetal2ByPeriodCode(string periodCode, string accountCode)
        {
            AccountTransactionDetail2DAL dalTranDetail2 = new AccountTransactionDetail2DAL();
            return dalTranDetail2.GetListBaseByPeriodCodeFromPrePaidDepreciations(periodCode, accountCode);
        }
        public ListBase<AccountTransaction> SelectBySpecialTypeAccountCodeAndDate(string specialType, DateTime startDate, DateTime endDate, string accountCode)
        {
            return dal.SelectBySpecialTypeAccountCodeAndDate(specialType, startDate, endDate, accountCode);
        }
        public DataTable GetPrePaidDepreciationsReportYear(int year, string accountCode)
        {
            return dal.GetPrePaidDepreciationsReportYear(year, accountCode);
        }
	}
}

