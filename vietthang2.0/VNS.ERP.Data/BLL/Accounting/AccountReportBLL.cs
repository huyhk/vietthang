using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
using System.Linq;

namespace VNS.ERP.Data.Accounting
{
    public class AccountReportBLL
    {
        AccountReportDAL dal = new AccountReportDAL();
        /// <summary>
        /// AccountTransactionStocks_ReportQuantity
        /// </summary>
        /// <param name="accountCode"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable GetReportQuantity(string prefixAccountCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetReportQuantity(prefixAccountCode, startDate, endDate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="preStartDate"></param>
        /// <param name="preEndDate"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable ReportCashFlow(DateTime preStartDate, DateTime preEndDate, DateTime startDate, DateTime endDate)
        {
            return dal.ReportCashFlow(preStartDate, preEndDate, startDate, endDate);
        }
        /// <summary>
        /// Thẻ kho
        /// </summary>
        /// <param name="itemCode"></param>
        /// <param name="stockCode"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable ReportTheKho(string itemCode, string stockCode, DateTime startDate, DateTime endDate)
        {
            return dal.ReportTheKho(itemCode, stockCode, startDate, endDate);
        }
        public DataSet GetAccountTransactionDetail2as(DateTime startDate, DateTime endDate, string accountCode)
        {
            return dal.GetAccountTransactionDetail2as(startDate, endDate, accountCode);
        }
        public int UpdateMonthBalanceAccount(string periodCode, string nextPeriodCode, DataTable dt, string rowCodeCaption, string oldOpeningAmountCaption, string oldClosingAmountCaption, bool updateOldOpeningAmount)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();

            iError = dal.DeleteBalanceAccountByPeriodCode(nextPeriodCode);
            if (iError == 0 && updateOldOpeningAmount)
            {
                iError = dal.DeleteBalanceAccountByPeriodCode(periodCode);
            }
            if (iError == 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string rowCode = dr[rowCodeCaption].ToString();
                    if (rowCode != string.Empty)
                    {
                        if (iError == 0)
                        {
                            if (updateOldOpeningAmount)
                            {
                                iError = dal.InsertBalanceAccount(periodCode, rowCode, Convert.ToDecimal(dr[oldOpeningAmountCaption]));
                            }
                            if (iError == 0)
                            {
                                iError = dal.InsertBalanceAccount(nextPeriodCode, rowCode, Convert.ToDecimal(dr[oldClosingAmountCaption]));
                                if (iError != 0) break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else break;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable ReportBalanceAccount(DateTime startDate, DateTime endDate)
        {
            return dal.ReportBalanceAccount(startDate, endDate);
        }
        public int UpdateQuarterAmountReportCashFlowOpenings(DataTable dt, string rowCodeCaption, string preAmountCaption)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();

            foreach (DataRow dr in dt.Rows)
            {
                string rowCode = dr[rowCodeCaption].ToString();
                if (rowCode != string.Empty)
                {
                    if (iError == 0)
                    {
                        iError = dal.UpdateQuarterAmountReportCashFlowOpening(rowCode, Convert.ToDecimal(dr[preAmountCaption]));
                    }
                    else break;
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
        public int UpdateYearAmountReportCashFlowOpenings(DataTable dt, string rowCodeCaption, string preAmountCaption)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();

            foreach (DataRow dr in dt.Rows)
            {
                string rowCode = dr[rowCodeCaption].ToString();
                if (rowCode != string.Empty)
                {
                    if (iError == 0)
                    {
                        iError = dal.UpdateYearAmountReportCashFlowOpening(rowCode, Convert.ToDecimal(dr[preAmountCaption]));
                    }
                    else break;
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
        public int UpdateMonthCashFlow(string periodCode, DataTable dt, string rowCodeCaption, string amountCaption, string preAmountCaption, bool updateOpenings)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();

            iError = dal.DeleteCashFlowByPeriodCode(periodCode);
            if (iError == 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string rowCode = dr[rowCodeCaption].ToString();
                    if (rowCode != string.Empty)
                    {
                        if (iError == 0)
                        {
                            if (updateOpenings)
                            {
                                iError = dal.UpdateMonthAmountReportCashFlowOpening(rowCode, Convert.ToDecimal(dr[preAmountCaption]));
                            }
                            if (iError == 0)
                            {
                                iError = dal.InsertCashFlow(periodCode, rowCode, Convert.ToDecimal(dr[amountCaption]));
                                if (iError != 0) break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else break;
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
        public int UpdateQuarterAmountReportBusinessResultOpenings(DataTable dt, string rowCodeCaption, string preAmountCaption)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();

            foreach (DataRow dr in dt.Rows)
            {
                if (iError == 0)
                {
                    iError = dal.UpdateQuarterAmountReportBusinessResultOpenings(dr[rowCodeCaption].ToString(), Convert.ToDecimal(dr[preAmountCaption]));
                }
                else break;
            }

            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }

            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int UpdateYearAmountReportBusinessResultOpenings(DataTable dt, string rowCodeCaption, string preAmountCaption)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();

            foreach (DataRow dr in dt.Rows)
            {
                if (iError == 0)
                {
                    iError = dal.UpdateYearAmountReportBusinessResultOpenings(dr[rowCodeCaption].ToString(), Convert.ToDecimal(dr[preAmountCaption]));
                }
                else break;
            }

            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }

            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        /// <summary>
        /// Backup the month business result for the next month report, update MonthAmount
        /// </summary>
        /// <param name="periodCode">PeriodCode backup</param>
        /// <param name="dt">Datasource to backup and update</param>
        /// <param name="rowCodeCaption">Caption of RowCode field in dt</param>
        /// <param name="amountCaption">Caption of Amount field in dt</param>
        /// <param name="preAmountCaption">Caption of PreAmount field in dt</param>
        /// <returns></returns>
        public int UpdateMonthBusinessResult(string periodCode, DataTable dt, string rowCodeCaption, string amountCaption, string preAmountCaption, bool updateOpenings)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();

            iError = dal.DeleteBusinessResultByPeriodCode(periodCode);
            if (iError == 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (iError == 0)
                    {
                        if (updateOpenings)
                        {
                            iError = dal.UpdateMonthAmountReportBusinessResultOpenings(dr[rowCodeCaption].ToString(), Convert.ToDecimal(dr[preAmountCaption]));
                        }
                        if (iError == 0)
                        {
                            iError = dal.InsertBusinessResult(periodCode, dr[rowCodeCaption].ToString(), Convert.ToDecimal(dr[amountCaption]));
                            if (iError != 0) break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else break;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="preStartDate"></param>
        /// <param name="preEndDate"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable ReportBusinessResult(DateTime preStartDate, DateTime preEndDate, DateTime startDate, DateTime endDate)
        {
            return dal.ReportBusinessResult(preStartDate, preEndDate, startDate, endDate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taxRate"></param>
        /// <param name="subjectCode"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable ReportInvoiceInItems(decimal taxRate, string subjectCode, DateTime startDate, DateTime endDate)
        {
            return dal.ReportInvoiceInItems(taxRate, subjectCode, startDate, endDate);
        }
        public DataTable ReportInvoiceInItems2(decimal taxRate, string subjectCode, DateTime startDate, DateTime endDate, string tk)
        {
            return dal.ReportInvoiceInItems2(taxRate, subjectCode, startDate, endDate, tk);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="subjectCode"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable ReportInvoiceOutItems(string subjectCode, DateTime startDate, DateTime endDate)
        {
            return dal.ReportInvoiceOutItems(subjectCode, startDate, endDate);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prefixAccountCode"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable GetReportAmount(string prefixAccountCode, DateTime startDate, DateTime endDate)
        { 
            return dal.GetReportAmount(prefixAccountCode, startDate, endDate);
        }
        public DataTable GetReportDetail(string prefixAccountCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetReportDetail(prefixAccountCode, startDate, endDate);
        }
        public DataTable GetReportDetailQuantity(string prefixAccountCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetReportDetailQuantity(prefixAccountCode, startDate, endDate);
        }
        public DataTable GetAccountTransactionGenerals(DateTime startDate, DateTime endDate, string accountCode)
        {
            return dal.GetAccountTransactionGenerals(startDate, endDate, accountCode, 0);
        }
        public DataTable GetAccountTransactionGenerals(DateTime startDate, DateTime endDate, string accountCode, int accountLength)
        {
            return dal.GetAccountTransactionGenerals(startDate, endDate, accountCode, accountLength);
        }
        public DataTable GetAccountTransactionSubjectsGeneral(DateTime startDate, DateTime endDate, string accountCode)
        {
            return dal.GetAccountTransactionSubjectsGeneral(startDate, endDate, accountCode);
        }
        public DataTable GetAccountTransactionClassificationGeneral(DateTime startDate, DateTime endDate, string accountCode)
        {
            return dal.GetAccountTransactionClassificationGeneral(startDate, endDate, accountCode);
        }

        public DataTable GetAccountTransactionDetail1s(DateTime startDate, DateTime endDate,string accountCode)
        {
            return dal.GetAccountTransactionDetail1s(startDate, endDate, accountCode);
        }
        public DataTable GetAccountTransactionDetail1s2(DateTime startDate, DateTime endDate, string accountCode, string subjectCode)
        { return dal.GetAccountTransactionDetail1s2(startDate, endDate, accountCode, subjectCode); }
        

        public DataTable GetAccountTransactionDetail2s(DateTime startDate, DateTime endDate, string accountCode)
        {
            return dal.GetAccountTransactionDetail2s(startDate, endDate, accountCode);
        }
        public DataTable GetAccountTransactionDetail2s(DateTime startDate, DateTime endDate, string accountCode, string subjectCode)
        {
            return dal.GetAccountTransactionDetail2s(startDate, endDate, accountCode, subjectCode);
        }
        public DataTable GetAccountTransactionDetail2s_HD(DateTime startDate, DateTime endDate, string accountCode, string subjectCode)
        {
            DataSet ds = dal.GetAccountTransactionDetail2s_HD(startDate, endDate, accountCode, subjectCode);
            //DataRelation dr = ds.Relations.Add("TranID", ds.Tables[0].Columns["AccountTransactionID"], ds.Tables[1].Columns["AccountTransactionID"]);
            ds.Tables[0].Columns.Add("InvoiceSo", typeof(string));
            
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["InvoiceSo"] = string.Empty;
                foreach (DataRow rowd in ds.Tables[1].Select("AccountTransactionID='"+row["AccountTransactionID"].ToString()+"'"))
                {
                    if (row["InvoiceSo"].ToString() == string.Empty)
                        row["InvoiceSo"] = rowd["SoHoadon"];
                    else
                        row["InvoiceSo"] += ", " + rowd["SoHoadon"];
                }
            }
            return ds.Tables[0];

        }
        public DataTable GetAccountTransactionDetail2s_HD_NoSub(DateTime startDate, DateTime endDate, string accountCode)
        {
            DataSet ds = dal.GetAccountTransactionDetail2s_HD_NoSub(startDate, endDate, accountCode);
            //DataRelation dr = ds.Relations.Add("TranID", ds.Tables[0].Columns["AccountTransactionID"], ds.Tables[1].Columns["AccountTransactionID"]);
            ds.Tables[0].Columns.Add("InvoiceSo", typeof(string));

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["InvoiceSo"] = string.Empty;
                foreach (DataRow rowd in ds.Tables[1].Select("AccountTransactionID='" + row["AccountTransactionID"].ToString() + "'"))
                {
                    if (row["InvoiceSo"].ToString() == string.Empty)
                        row["InvoiceSo"] = rowd["SoHoadon"];
                    else
                        row["InvoiceSo"] += ", " + rowd["SoHoadon"];
                }
            }
            return ds.Tables[0];

        }
        public DataTable GetAccountTransactionDetail2s_NoHD(DateTime startDate, DateTime endDate, string accountCode, string subjectCode)
        {
            return dal.GetAccountTransactionDetail2s_NoHD(startDate, endDate, accountCode, subjectCode);
        }

        public DataTable GetListBuyNoInvoices(DateTime startDate, DateTime endDate, string branchCode)
        {
            return dal.GetListBuyNoInvoices(startDate, endDate, branchCode);
        }

        public DataTable GetListAccountTransactionDetail1ByObjects(DateTime startDate, DateTime endDate, string accountCode, string subjectCode)
        {
            return dal.GetListAccountTransactionDetail1ByObjects(startDate, endDate, accountCode, subjectCode);
        }
        public DataTable GetListAccountTransactionDetail2ByObject(DateTime startDate, DateTime endDate, string accountCode, string subjectCode)
        {
            return dal.GetListAccountTransactionDetail2ByObject(startDate, endDate, accountCode, subjectCode);
        }
        public decimal GetListOpeningAmount(DateTime startDate, string accountCode, string subjectCode)
        {
            return dal.GetListOpeningAmount(startDate, accountCode, subjectCode);
        }
        public DataTable GetAccountTransactionOriginateBalances(DateTime startDate, DateTime endDate, int accLens)
        {
            return dal.GetAccountTransactionOriginateBalances(startDate, endDate, accLens);
        }

        public DataSet GetDSSoNhatkyThutien(string accountCode, string subjectCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetDSSoNhatkyThutien(accountCode, subjectCode, startDate, endDate);
        }
        public DataSet GetDSSoNhatkyChitien(string accountCode, string subjectCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetDSSoNhatkyChitien(accountCode, subjectCode, startDate, endDate);
        }
        public DataSet GetDSSoNhatkyChung(DateTime startDate, DateTime endDate)
        {
            return dal.GetDSSoNhatkyChung( startDate, endDate);
        }
        public DataSet GetDSSoNhatkyChungNB(DateTime startDate, DateTime endDate)
        {
            return dal.GetDSSoNhatkyChungNB(startDate, endDate);
        }
        public DataSet GetDSSoNhatkyChungBank(DateTime startDate, DateTime endDate)
        {
            return dal.GetDSSoNhatkyChungBank(startDate, endDate);
        }
        public DataSet GetDSSoNhatkyChungAll(DateTime startDate, DateTime endDate)
        {
            return dal.GetDSSoNhatkyChungAll(startDate, endDate);
        }
        public DataSet PagedSonhatky(DataSet ds, int firstPage, int nextPage)
        {
            System.Data.DataTable dt = ds.Tables[0];
            dt.Columns.Add("PageNumber", typeof(int));
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("TransactionMonth", typeof(int));

            int count = 0, maxLengthDesc = 89;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i + count <= firstPage)
                    dt.Rows[i]["PageNumber"] = 1;
                else
                    dt.Rows[i]["PageNumber"] = Math.Ceiling((decimal)((decimal)(i + count - firstPage) / nextPage)) + 1;
                if (dt.Rows[i]["Diengiai"].ToString().Length > maxLengthDesc)
                    count++;
                if (dt.Rows[i]["Diengiai"].ToString().Length > maxLengthDesc * 2)
                    count++;

                dt.Rows[i]["STT"] = i + 1;//Ngayghiso
                dt.Rows[i]["TransactionMonth"] = ((DateTime)dt.Rows[i]["Ngayghiso"]).Month;
            }

            return ds;
        }
        public DataSet PagedSonhatkyChungAll(DateTime fromDate, DateTime toDate, int firstPage, int nextPage)
        {
            return PagedSonhatky(GetDSSoNhatkyChungAll(fromDate, toDate), firstPage, nextPage);
        }
        public DataSet PagedSonhatkyChungAll(DateTime fromDate, DateTime toDate)
        {
            return PagedSonhatkyChungAll(fromDate, toDate, 29, 37);
        }
        public DataSet PagedSonhatkyChungAllYear(int year, int firstPage, int nextPage)
        {
            DateTime fromDate = new DateTime(year, 1, 1);
            DateTime toDate = fromDate.AddYears(1).AddDays(-1);
            return PagedSonhatky(GetDSSoNhatkyChungAll(fromDate, toDate), firstPage, nextPage);
        }

        public DataSet GetDSSoNhatkyMuahang(DateTime startDate, DateTime endDate)
        {
            return dal.GetDSSoNhatkyMuahang(startDate, endDate);
        }
        public DataSet GetDSSoNhatkyBanhang(DateTime startDate, DateTime endDate)
        {
            return dal.GetDSSoNhatkyBanhang(startDate, endDate);
        }
        public DataTable GetAccountTransactionNgoaite(DateTime startDate, DateTime endDate, string accountCode, string currencyCode)
        {
            return dal.GetAccountTransactionNgoaite(startDate, endDate, accountCode, currencyCode);
        }
        public DataTable GetAccountTransactionDetail2Ngoaite(DateTime startDate, DateTime endDate, string accountCode, string currencyCode)
        {
            return dal.GetAccountTransactionDetail2Ngoaite(startDate, endDate, accountCode, currencyCode);
        }
        public DataTable GetObjectSoDoChuT(DateTime startDate, DateTime endDate, string accountCode)
        {
            return dal.GetObjectSoDoChuT(startDate, endDate, accountCode);
        }
        public DataSet ReportFixedAssetList()
        {
            return dal.ReportFixedAssetList();
        }
        public DataSet ReportPrePaidExpense()
        {
            return dal.ReportPrePaidExpense();
        }
        public DataSet Accounting_Report_Chitietbanhang(DateTime startdate,DateTime enddate)
        {
            return dal.Accounting_Report_Chitietbanhang(startdate,enddate);
        }
        public DataSet Accounting_Report_Chitietbanhang_KH(DateTime startdate, DateTime enddate)
        {
            return dal.Accounting_Report_Chitietbanhang_KH(startdate, enddate);
        }
        public DataSet Accounting_Report_LaigopKhachhang(DateTime startdate, DateTime enddate)
        {
            return dal.Accounting_Report_LaigopKhachhang(startdate, enddate);
        }
        public DataTable CongnoNCCDenhan(DateTime startDate, DateTime endDate)
        {
            DataSet ds = dal.CongnoNCCDenhan(startDate, endDate);
            foreach (DataRow rowT in ds.Tables[0].Rows)
            {
                decimal paidAmount = (decimal)rowT["PaidAmount"];
                if (paidAmount > 0)
                {
                    foreach (DataRow rowH in ds.Tables[1].Select("SubjectCode='" + rowT["SubjectCode"].ToString() + "'"))
                    {
                        decimal remainAmount = (decimal)rowH["RemainAmount"];
                        if (paidAmount >= remainAmount)
                        {
                            paidAmount -= remainAmount;
                            ds.Tables[1].Rows.Remove(rowH);
                            if (paidAmount == 0)
                                break;
                        }
                        else
                        {
                            rowH["RemainAmount"] = remainAmount - paidAmount;
                            break;
                        }
                    }
                }
            }
            return ds.Tables[1].Copy();
        }

        public DataSet Report_SoTSCD(int year, string accountCode)
        {
            return dal.Report_SoTSCD(year, accountCode);
        }

        public DataSet TonghopcongthucNVL(int year)
        {
            return dal.TonghopcongthucNVL(year);
        }

        public DataTable GetAccountReportSotheodoiTSCD(DateTime startDate, DateTime endDate, string subjectCode, string accountCode)
        {
            return dal.GetAccountReportSotheodoiTSCD(startDate, endDate, subjectCode, accountCode);
        }
        public DataTable GetAccountReportSotheodoiCCDC(DateTime startDate, DateTime endDate, string subjectCode, string accountCode)
        {
            return dal.GetAccountReportSotheodoiCCDC(startDate, endDate, subjectCode, accountCode);
        }
        /// <summary>
        /// Lay du lieu tu database.
        /// Du lieu tra ve la DataSet co DataRelation la "relVayID".
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="accountCode"></param>
        /// <returns>Du lieu tra ve la DataSet co DataRelation la "relVayID".</returns>
        public DataSet GetAccountReportSoChiTietTienVay(DateTime startDate, DateTime endDate, string accountCode)
        {
            return dal.GetAccountReportSoChiTietTienVay(startDate, endDate, accountCode);
        }
        public DataTable GetAccountStockOpen(string periodCode, string accountCode)
        { return dal.GetAccountStockOpen(periodCode, accountCode); }

        public DataTable Tuoinonam(DateTime date)
        { return dal.Tuoinonam(date); }
        public DataSet Tinhlai(string accountCode, string subjectCode, DateTime startDate, DateTime endDate, int day1, int day2)
        { return dal.Tinhlai(accountCode, subjectCode, startDate, endDate, day1, day2); }

        public DataTable StockEnding(int year, string tk)
        { return dal.StockEnding(year, tk); }

        public DataTable StockEnding2(DateTime startDate, string tk)
        { return dal.StockEnding2(startDate, tk); }
        public DataSet Congtrinh(DateTime startDate, DateTime endDate)
        { return dal.Congtrinh(startDate, endDate); }
    }
}
