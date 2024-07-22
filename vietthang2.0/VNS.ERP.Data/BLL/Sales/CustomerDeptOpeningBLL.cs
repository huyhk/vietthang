using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.Sales
{
    public class CustomerDeptOpeningBLL
    {
        private CustomerDeptOpeningDAL dal = new CustomerDeptOpeningDAL();
        private CustomerDeptSumOpeningDAL dal1;
        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerDeptOpeningBLL() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        /// <param name="stockCode"></param>
        /// <returns></returns>
        public ListBase<CustomerDeptOpening> GetByPeriodCode(string periodCode)
        {
            return dal.GetByPeriodCode(periodCode);
        }
             
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(ListBase<CustomerDeptOpening> lstCusDeptOpening,ListBase<CustomerDeptSumOpening> lstOpen, string periodCode)
        {
             dal1 = new CustomerDeptSumOpeningDAL(dal.DBHelper);
            lstOpen = ConvertRemainAmount(lstOpen);
            ListBase<CustomerDeptSumOpening> lstInsertSumDetail = new ListBase<CustomerDeptSumOpening>();

            foreach (CustomerDeptOpening cusDep in lstCusDeptOpening)
            {
                CustomerDeptSumOpening cusSum = lstInsertSumDetail.Search("CustomerCode", cusDep.CustomerCode);
                if (cusSum == null)
                {
                    CustomerDeptSumOpening cusInsert = new CustomerDeptSumOpening();
                    cusInsert.CustomerCode = cusDep.CustomerCode;
                    cusInsert.PeriodCode = cusDep.PeriodCode;
                    cusInsert.RemainAmount = cusDep.RemainAmount;
                    lstInsertSumDetail.Add(cusInsert);
                }
                else
                {
                    cusSum.RemainAmount += cusDep.RemainAmount;
                }
               
            }


            int iError = 0;
            dal.Open();
            dal.BeginTransaction();

            iError = dal.DeleteByPeriodCode(periodCode);
                if (iError == 0)
                    iError = dal1.Delete(periodCode);
                if (iError == 0)
                {
                    foreach (CustomerDeptOpening cusDeptOpeningObj in lstCusDeptOpening)
                    {
                            iError = dal.Insert(cusDeptOpeningObj);
                       if(iError!=0)
                            break;
                    }
                    foreach(CustomerDeptSumOpening sumDetai in lstInsertSumDetail)
                    {
                        iError=dal1.Insert(sumDetai);
                        if(iError!=0)
                            break;
                    }
                    foreach (CustomerDeptSumOpening cusOpen in lstOpen)
                    {
                        iError = dal1.Insert(cusOpen);
                        if (iError != 0)
                            break;
                    }
                }
            
            if (iError == 0) dal.Commit();
            else dal.Rollback();
            dal.Close();
            lstOpen = ConvertRemainAmount(lstOpen);
            return iError;
        }

        public DataTable ReportsCustomerDeptOpening(DateTime ngay, string productType)
        {
            DataSet ds = dal.ReportsCustomerDeptOpening(ngay, productType);
            DataTable dt = ds.Tables[0];
            DataTable dtTotal = ds.Tables[1];

            DataView dv = dt.DefaultView;
            dv.Sort = "InvoiceDate ASC,CustomerCode ASC";
            foreach (DataRow drTotal in dtTotal.Rows)
            {
                decimal totalAmount =decimal.Parse(drTotal["TotalAmount"].ToString());
                for(int i=0; i<dv.Count;i++)
                {
                    if (drTotal["CustomerCode"].Equals(dv[i]["CustomerCode"]))
                    {
                           if (totalAmount >= decimal.Parse(dv[i]["RemainAmount"].ToString()))
                            {
                                totalAmount -= decimal.Parse(dv[i]["RemainAmount"].ToString());
                                dv[i]["RemainAmount"] = 0;
                            }
                            else
                            {
                                dv[i]["RemainAmount"] = decimal.Parse(dv[i]["RemainAmount"].ToString()) - totalAmount;
                                dv[i]["PaidAmount"] = decimal.Parse(dv[i]["PaidAmount"].ToString()) + totalAmount;
                                break;
                            }
                    }
                }
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (decimal.Parse(dr["RemainAmount"].ToString()) == 0)
                    dr.Delete();
            }
            return dt;
        }
        private ListBase<CustomerDeptSumOpening> ConvertRemainAmount(ListBase<CustomerDeptSumOpening> lst)
        {
            foreach (CustomerDeptSumOpening cusOpen in lst)
            {
                if (cusOpen.RemainAmount < 0)
                    cusOpen.RemainAmount = (-cusOpen.RemainAmount);
                else
                    cusOpen.RemainAmount = (-cusOpen.RemainAmount);
            }
            return lst;
        }
    }
}
