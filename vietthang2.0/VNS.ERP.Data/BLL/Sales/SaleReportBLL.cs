using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class SaleReportBLL
    {
        SaleReportDAL dal = new SaleReportDAL();

        public DataTable Report(DateTime startDate, DateTime endDate)
        {
            return dal.Report(startDate, endDate);
        }
        public DataTable ReportSale(DateTime date)
        {
            return dal.ReportSale(date);
        }
        public DataTable ReportSaleForYear(DateTime date)
        {
            return dal.ReportSaleForYear(date);
        }
        public DataSet ReportGeneral(DateTime startDate, DateTime endDate, Boolean getPaymentFromAccount, string productType)
        {
            DataSet ds= dal.ReportGeneral(startDate, endDate, getPaymentFromAccount, productType);
            DataTable dt = ds.Tables[1];
            string oldSaleID = string.Empty;
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dt.Rows[i];
                string saleID = (string)row["SoCT"];
                if (saleID != oldSaleID)
                    oldSaleID = saleID;
                else
                {
                    row.BeginEdit();
                    row["SaleAmount"] = 0;
                    row.EndEdit();
                }
            }
            return ds;
        }
        public DataSet ReportGeneralTH(DateTime startDate, DateTime endDate, string productType, bool includeDetail, bool accDetail)
        {
            DataSet ds = dal.ReportGeneralTH(startDate, endDate, productType, includeDetail, accDetail);
            if (ds.Tables.Count > 1)
            {

                DataTable dt = ds.Tables[1];

                string oldSaleID = string.Empty;
                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = dt.Rows[i];
                    string saleID = (string)row["SoCT"];
                    if (saleID != oldSaleID)
                        oldSaleID = saleID;
                    else
                    {
                        row.BeginEdit();
                        row["SaleAmount"] = 0;
                        row.EndEdit();
                    }
                }

                ds.Relations.Add("DeptDetail", ds.Tables[0].Columns["CustomerCode"],
                   ds.Tables[1].Columns["CustomerCode"]);
            }
            return ds;


        }
        public DataTable GetItemCodeReports(string stockCode, DateTime fromDate, DateTime toDate)
        {
            return dal.GetItemCodeReports(stockCode, fromDate, toDate);
        }

        public DataSet GetDSSoluongThanhpham(DateTime startDate, DateTime endDate, string productType)
        {
            return dal.GetDSSoluongThanhpham(startDate, endDate, productType);
        }
        public DataSet GetCTXuatTPThang(DateTime startDate, DateTime endDate, string productType)
        {
            return dal.GetCTXuatTPThang(startDate, endDate, productType);
        }
        public DataSet GetTHCongnoKHNam(DateTime startDate, DateTime endDate, string productType)
        {
            return dal.GetTHCongnoKHNam(startDate, endDate, productType);
        }
        public DataSet GetTHCongnoKHThang(DateTime startDate, DateTime endDate, string productType)
        {
            return dal.GetTHCongnoKHThang(startDate, endDate, productType);
        }

        public DataTable KiemtragiabanHD(DateTime startDate, DateTime endDate)
        {
            return dal.KiemtragiabanHD(startDate, endDate);
        }

        public void GetSalePrice(string stockCode, string subjectCode, string itemCode, DateTime date, out decimal salePrice, out decimal reducePrice, out decimal reducePriceNoTax)
        {
            dal.GetSalePrice(stockCode, subjectCode, itemCode, date, out salePrice, out reducePrice, out reducePriceNoTax);
        }
        /// <summary>
        /// Get data by date, create dataset's datarelation, datarelation name is 
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public DataSet GetReportsCustomerDiscount(DateTime d)
        {
            return dal.GetReportsCustomerDiscount(d);
        }
        public DataSet GetReportsCustomerDiscountAll()
        {
            return dal.GetReportsCustomerDiscountAll();
        }

        public DataTable Discount_List(DateTime startDate, DateTime endDate)
        { return dal.Discount_List(startDate, endDate); }
        public DataTable Discount_List_GS(DateTime startDate, DateTime endDate)
        { return dal.Discount_List_GS(startDate, endDate); }
    }
}
