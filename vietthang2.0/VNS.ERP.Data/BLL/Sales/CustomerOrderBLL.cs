using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerOrderBLL:IBusiness
    {
        private CustomerOrderDAL dal = new CustomerOrderDAL();
        private CustomerOrderDetailDAL dal1 ;
        public CustomerOrderBLL()
        { }
        public ListBase<CustomerOrders> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(CustomerOrders t)
        {
            int iError=0;
            bool alreadyOpen = false;
            t.UserCreated = Contexts.CurrentUser.LoginName;
            try
            {
                if (dal.DBHelper.State != System.Data.ConnectionState.Open)
                    dal.DBHelper.Open();
                else
                    alreadyOpen = true;
                dal1 = new CustomerOrderDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    foreach (CustomerOrderDetails Detail in t.Details)
                    {
                        Detail.CustomerOrderID = t.CustomerOrderID;
                        if (iError == 0)
                        {
                            //if (Detail.Quantity > 0)
                            //{
                                iError = dal1.Insert(Detail);
                            //}
                        }
                        else
                            break;
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerOrderBLL", "Insert(CustomerOrders t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                   dal.Commit();
               else
                   dal.Rollback();
                if (!alreadyOpen)
                    dal.Close();
            }
            return iError;

        }
        public int Update(CustomerOrders t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            try
            {
                if (dal.DBHelper.State != System.Data.ConnectionState.Open)
                    dal.DBHelper.Open();
                else
                    alreadyOpen = true;
                dal1 = new CustomerOrderDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                iError = dal.Update(t);
                if (iError == 0)
                {
                    iError= dal1.Delete(t.CustomerOrderID);
                    if (iError == 0)
                    {
                        foreach (CustomerOrderDetails Detail in t.Details)
                        {
                            Detail.CustomerOrderID = t.CustomerOrderID;
                            if (iError == 0)
                            {
                                //if (Detail.Quantity > 0)
                                //{
                                    iError = dal1.Insert(Detail);
                                //}
                            }
                            else
                                break;
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerOrderBLL", "Update(CustomerOrders t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                if (!alreadyOpen)
                    dal.Close();
            }
            return iError;
        }

        public int Delete(CustomerOrders t)
        {
            return dal.Delete(t);
        }
        //public ListBase<CustomerOrders> GetAllCustomerOrderByStockCode(string _StockCode, string productType)
        //{
        //    return dal.GetAllCustomerOrderByStockCode(_StockCode, productType);
        //}
        //public ListBase<CustomerOrders> GetCustomerOrderByStockCode(string _StockCode, string productType)
        //{
        //    return dal.GetCustomerOrderByStockCode(_StockCode, productType);
        //}
        public ListBase<CustomerOrderDetails> GetCustomerOrderDetailByID(Guid _CustomerOrderID)
        {
            dal1 = new CustomerOrderDetailDAL(dal.DBHelper);
            return dal1.GetCustomerOrderDetailByID(_CustomerOrderID);
        }
        public DataTable GetSearchCustomerOrderByStockCode(string _StockCode, string productType)
        {
            return dal.GetSearchCustomerOrderByStockCode(_StockCode, productType);
        }
        public ListBase<Item> GetCustomerOrderDetailByCustomerOrderNo(string customerOrderNo)
        {
            dal1 = new CustomerOrderDetailDAL(dal.DBHelper);
            return dal1.GetCustomerOrderDetailByCustomerOrderNo(customerOrderNo);
        }
        public DataTable GetCustomerOrderDetailByDeliver_StockCode(DateTime deliverDate, string stockCode)
        {
            dal1 = new CustomerOrderDetailDAL(dal.DBHelper);
            return dal1.GetCustomerOrderDetailByDeliver_StockCode(deliverDate, stockCode);
        }
        public CustomerOrders GetTopBySuffixCustomerOrderNo(string suffix)
        {
            return dal.GetTopBySuffixCustomerOrderNo(suffix);
        }
        public ListBase<CustomerOrders> GetObjectByTimeStockCode(DateTime startDate, DateTime endDate, string stockCode, string productType)
        {
            return dal.GetObjectByTimeStockCode(startDate, endDate, stockCode, productType);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as CustomerOrders);
        }

        public int Update(object obj)
        {
            return this.Update(obj as CustomerOrders);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as CustomerOrders);
        }

        #endregion
    }
}
