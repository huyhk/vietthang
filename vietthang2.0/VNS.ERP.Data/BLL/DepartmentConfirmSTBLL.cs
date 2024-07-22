using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using VNS.ERP.Data.Sales;
//using System.Windows.Forms;

namespace VNS.ERP.Data
{
    public class DepartmentConfirmSTBLL:IBusiness
    {
        private StockTransactionDAL dal = new StockTransactionDAL();
        private SaleRequestDAL srdal = null;
        private SaleRequestDetailDAL srddal = null;
        private VNS.ERP.Data.Accounting.AccountTransactionStockDAL accTransStockDAL = null;
        private VNS.ERP.Data.Accounting.AccountTransactionDAL accTransDAL = null;
        public DepartmentConfirmSTBLL() { }
        public ListBase<StockTransaction> GetForDepartmentConfirm(string stockCode, byte department)
        {
            return dal.GetForDepartmentConfirm(stockCode, department);
        }
        /// <summary>
        /// not use
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(StockTransaction t)
        {
            return 0;
        }
        public int Update(StockTransaction t)
        {
            int iError=0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;

            srdal = new SaleRequestDAL(dal.DBHelper);
            srddal = new SaleRequestDetailDAL(dal.DBHelper);
            accTransStockDAL = new VNS.ERP.Data.Accounting.AccountTransactionStockDAL(dal.DBHelper);
            accTransDAL = new VNS.ERP.Data.Accounting.AccountTransactionDAL(dal.DBHelper);
            //MessageBox.Show(
            dal.BeginTransaction();
            //if (t.IsAccounted && t.DepartmentStatus != (byte)enumStockTransactionDepartmentStatus.Confirm)
            //{ 
               
            //}
            if (t.ForDepartment == (byte)enumStockTransactionForDepartment.ForPurchase)
            {
                iError = dal.UpdateByThumua(t);
                if (iError == 0)
                {
                    StockTransactionSumDetailDAL dalSumDetail = new StockTransactionSumDetailDAL(dal.DBHelper);
                    foreach (StockTransactionSumDetail d in t.Details)
                    {
                        iError = dalSumDetail.UpdateGiamua(d);
                        if (iError != 0)
                            break;
                    }
                }
                if (iError == 0)
                {
                    iError = dal.DeletePurchaseDetail(t.TransactionID);
                    if (t.SoHD == "")
                    {
                        if (iError == 0)
                        {
                            foreach (StockTransactionSumDetail sd in t.Details)
                            {
                                foreach (StockTransactionPurchaseDetail spd in sd.ListPurchaseDetail)
                                {
                                    spd.TransactionID = t.TransactionID;
                                    spd.ItemCode = sd.ItemCode;
                                    iError = dal.InsertPurchaseDetail(spd);
                                    if (iError != 0)
                                        break;
                                }
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                }
            }
            else
            {
                if (t.IsAccounted)
                {
                    iError = accTransDAL.Delete(t.AccountTransactionID);
                }
                if (iError == -1) iError = 0;//case RowCount = 0: iError=-1
                if (iError == 0)
                {
                    iError = dal.UpdateDepartmentStatus(t);
                }
                if (iError == 0)
                {
                    #region In case ForSale
                    if (t.ForDepartment == (byte)enumStockTransactionForDepartment.ForSale)
                    {
                        SaleRequests sr = new SaleRequestBLL().GetBySaleRequestNo(t.SoDH);
                        if (sr != null)
                        {
                            //sr.Quantity = t.SaleRequestObj.Quantity;
                            sr.InvoiceAmount = t.SaleRequestObj.InvoiceAmount;
                            sr.BeforeTaxAmount = t.SaleRequestObj.BeforeTaxAmount;
                            sr.TaxAmount = t.SaleRequestObj.TaxAmount;
                            sr.DiscountAmount = t.SaleRequestObj.DiscountAmount;
                            sr.DiscountDescription = t.SaleRequestObj.DiscountDescription;
                            sr.DiscountID = t.SaleRequestObj.DiscountID;
                            sr.PaymentType = t.SaleRequestObj.PaymentType;
                            sr.Giamgia = t.SaleRequestObj.Giamgia;
                            sr.InvoiceMau = t.SaleRequestObj.InvoiceMau;
                            sr.InvoiceSeri = t.SaleRequestObj.InvoiceSeri;
                            sr.TaxRate = t.SaleRequestObj.TaxRate;
                            sr.InvoiceCustomerName = t.SaleRequestObj.InvoiceCustomerName;
                            sr.InvoicePersonName = t.SaleRequestObj.InvoicePersonName;
                            if (sr.Details != null)
                            {
                                sr.Quantity = 0;
                                //sr.InvoiceAmount = 0;
                                //sr.BeforeTaxAmount = 0;
                                //sr.TaxAmount = 0;
                                //sr.DiscountAmount = t.SaleRequestObj.DiscountAmount;
                                //sr.DiscountDescription = t.SaleRequestObj.DiscountDescription;
                                //sr.PaymentType = t.SaleRequestObj.PaymentType;
                                //sr.Giamgia = t.SaleRequestObj.Giamgia;

                                //Duyệt qua ListBase SaleRequestDetails get BeforeTaxAmount;
                                foreach (StockTransactionSumDetail stsd1 in t.Details)
                                {
                                    SaleRequestDetails srd1 = sr.Details.Search("ItemCode", stsd1.ItemCode);
                                    if (srd1 == null && t.DepartmentStatus == (byte)enumStockTransactionDepartmentStatus.Confirm)
                                    {
                                        iError = -3;
                                    }
                                }

                                foreach (SaleRequestDetails srd in sr.Details)
                                {
                                    StockTransactionSumDetail stsd = t.Details.Search("ItemCode", srd.ItemCode);
                                    srd.Quantity = 0;
                                    if (stsd != null)
                                    {
                                        srd.Quantity = stsd.Quantity;
                                        sr.Quantity += srd.Quantity;
                                        //    sr.DiscountAmount
                                        // sr.BeforeTaxAmount += Math.Round(srd.Quantity * srd.SalePrice, 0);
                                    }
                                    //else
                                    //{
                                    //    if (t.DepartmentStatus == (byte)enumStockTransactionDepartmentStatus.Confirm)
                                    //    {
                                    //        iError = -3;
                                    //    }
                                    //}
                                }

                                //sr.BeforeTaxAmount -= sr.DiscountAmount;
                                ////TaxAmount.
                                //sr.TaxAmount = Math.Round(sr.BeforeTaxAmount * sr.TaxRate, 0);
                                ////InvoiceAmount.
                                //sr.InvoiceAmount = sr.BeforeTaxAmount + sr.TaxAmount;
                            }
                            sr.IsFinished = t.DepartmentStatus == (byte)enumStockTransactionDepartmentStatus.Confirm;
                            sr.InvoiceDate = t.SaleRequestObj.InvoiceDate;
                            //if (!sr.IsFinished)
                            //{ 
                            //    AccountTransactionStockNew acc = new AccountTransactionStockNewBLL().GetByStockTransactionID(t.TransactionID);
                            //    if (acc != null && iError == 0)
                            //    {
                            //        iError = new AccountTransactionStockNewBLL().Delete(acc);
                            //    }
                            //}
                            sr.UserUpdated = Contexts.CurrentUser.LoginName;
                            sr.InvoiceNo = t.SaleRequestObj.InvoiceNo;
                            //Update SaleRequests.
                            //AccountTransactionStockNew accTransStock = new AccountTransactionStockNewBLL().GetByStockTransactionID(t.TransactionID);
                            //accTransStock.AccTransactionStock.InvoiceMau = sr.InvoiceMau;
                            //accTransStock.AccTransactionStock.DiscountAmount = sr.DiscountAmount;
                            //accTransStock.AccTransactionStock.InvoiceSeri = sr.InvoiceSeri;
                            //accTransStock.AccTransactionStock.DiscountDescription = sr.DiscountDescription;
                            //accTransStock.AccTransactionStock.InvoiceSo = sr.InvoiceNo;
                            //accTransStock.AccTransactionStock.InvoiceNgay = sr.InvoiceDate;
                            //accTransStock.AccTransactionStock.PaymentType = sr.PaymentType;
                            //accTransStock.AccTransactionStock.Giamgia = sr.Giamgia;
                            //accTransStock.AccTransactionStock.InvoiceThuexuat = sr.TaxRate;
                            //accTransStock.AccTransactionStock.TaxAmount = sr.TaxAmount;


                            //accTransStock.invoi
                            if (iError == 0)
                            {
                                iError = srdal.UpdateFromOrtherBLLs(sr);
                            }
                            //if (iError == 0)
                            //{
                            //    iError = accTransStockDAL.Update(accTransStock.AccTransactionStock);
                            //}
                            if (iError == 0)
                            {
                                iError = srddal.Delete(sr.SaleRequestID);
                            }
                            if (iError == 0)
                            {
                                if (sr.Details != null)
                                {
                                    //
                                    foreach (SaleRequestDetails srd in sr.Details)
                                    {
                                        if (iError == 0)
                                        {
                                            //Insert SaleRequestDetails of Parent.
                                            iError = srddal.Insert(srd);
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        if (iError == 0)
                        {
                            t.SaleRequestObj = sr;
                            t.AccountTransactionID = Guid.Empty;
                        }
                    }
                    #endregion
                }
            }

            if (iError != 0)
            {
               // iError = -1;
                dal.Rollback();
            }
            else dal.Commit();
            //dal.Close();
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Delete(StockTransaction t)
        {
            return 0;
        }
        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as StockTransaction);
        }
        public int Update(object obj)
        {
            return this.Update(obj as StockTransaction);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as StockTransaction);
        }
        #endregion
    }
}
