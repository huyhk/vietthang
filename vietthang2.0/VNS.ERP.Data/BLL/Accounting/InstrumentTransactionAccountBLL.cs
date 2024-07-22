using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Accounting
{
    public class InstrumentTransactionAccountBLL : AccountTransactionBLL<InstrumentTransactionAccount>, IBusiness
    {
        InstrumentTransactionDetailDAL instrTransDetailDal = null;
        InstrumentTransactionAccountDAL instrTransAccDal = null;
        AccountInstrumentTransactionDAL accInstrTransDal = null;
        InstrumentPrepaidDAL instrPrepaidDal = null;
        InstrumentTransactionDAL instrTransDal = null;
        PrePaidExpenseDAL prePaidExpseDal = null;
        public InstrumentTransactionAccountBLL()
        { }
        public ListBase<InstrumentTransactionDetail> GetDetail(Guid InstrTransID)
        {
            instrTransDal = new InstrumentTransactionDAL();
            return instrTransDal.GetDetail(InstrTransID);
        }
        public ListBase<InstrumentTransactionAccount> GetWithDetailByTransactionTypeForPeriod(string transType, DateTime startDate, DateTime endDate)
        {
            instrTransAccDal = new InstrumentTransactionAccountDAL();
            return instrTransAccDal.GetWithDetailByTransactionTypeForPeriod(transType, startDate, endDate);
        }
        public ListBase<InstrumentTransactionAccount> GetByTransactionTypeForPeriod(string transType, DateTime startDate, DateTime endDate)
        {
            instrTransAccDal = new InstrumentTransactionAccountDAL();
            return instrTransAccDal.GetByTransactionTypeForPeriod(transType, startDate, endDate);
        }
        public ListBase<InstrumentTransactionAccount> GetByTransactionType(string transType)
        {
            instrTransAccDal = new InstrumentTransactionAccountDAL();
            return instrTransAccDal.GetByTransactionType(transType);
        }
        public InstrumentTransaction GetInsTransByAccTransID(Guid accTransID)
        {
            instrTransDal = new InstrumentTransactionDAL();
            return instrTransDal.GetByAccTransID(accTransID);
        }
        public int Insert(InstrumentTransactionAccount t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;
            instrTransDetailDal = new InstrumentTransactionDetailDAL(dalAccountTransaction.DBHelper);
            accInstrTransDal = new AccountInstrumentTransactionDAL(dalAccountTransaction.DBHelper);
            instrPrepaidDal = new InstrumentPrepaidDAL(dalAccountTransaction.DBHelper);
            instrTransDal = new InstrumentTransactionDAL(this.dalAccountTransaction.DBHelper);
            prePaidExpseDal = new PrePaidExpenseDAL(this.dalAccountTransaction.DBHelper);
            dalAccountTransaction.BeginTransaction();

            iError = base.InsertBase(t);
            if (iError == 0)
            {
                //t.InstrTrans.AccountTransationID = t.AccountTransactionID;
                iError = instrTransDal.Insert(t.InstrTrans);
            }
            if (iError == 0)
            {
                AccountInstrumentTransaction accInstrTrans = new AccountInstrumentTransaction();
                accInstrTrans.AccountTransactionID = t.AccountTransactionID;
                accInstrTrans.InstrumentTransactionID = t.InstrTrans.TransactionID;
                iError = accInstrTransDal.Insert(accInstrTrans);
            }
            if (iError == 0)
            {
                foreach (InstrumentTransactionDetail instrTransDetail in t.InstrTrans.Detail)
                {
                    instrTransDetail.TransactionID = t.InstrTrans.TransactionID;
                    if (iError == 0)
                    {
                        iError = instrTransDetailDal.Insert(instrTransDetail);
                        if (iError == 0 && instrTransDetail.LstPrePaidExpense.Count > 0 && instrTransDetail.StockOutCode != string.Empty && instrTransDetail.StockOutCode != null)
                        {
                            instrTransDetail.LstPrePaidExpense[0].PrePaidNo = t.InstrTrans.TransactionNo;
                            instrTransDetail.LstPrePaidExpense[0].PrePaidDate = t.InstrTrans.TransactionDate;
                            instrTransDetail.LstPrePaidExpense[0].Quantity = instrTransDetail.Quantity;
                            instrTransDetail.LstPrePaidExpense[0].Price = instrTransDetail.Price;
                            instrTransDetail.LstPrePaidExpense[0].Amount = instrTransDetail.Amount;
                            instrTransDetail.LstPrePaidExpense[0].DepAccountCode = instrTransDetail.DepAccountCode;
                            instrTransDetail.LstPrePaidExpense[0].DepSubjectCode = instrTransDetail.DepSubjectCode;
                            instrTransDetail.LstPrePaidExpense[0].DepClassificationCode = instrTransDetail.DepClassificationCode;
                            iError = prePaidExpseDal.Insert(instrTransDetail.LstPrePaidExpense[0]);
                            if (iError == 0)
                            {
                                InstrumentPrepaid instrPrepaid = new InstrumentPrepaid();
                                instrPrepaid.InstrumentTransactionDetailID = instrTransDetail.TransactionDetailID;
                                instrPrepaid.PrePaidCode = instrTransDetail.LstPrePaidExpense[0].PrePaidCode;
                                iError = instrPrepaidDal.Insert(instrPrepaid);
                            }
                        }
                        if (iError != 0) break;
                    }
                }
            }
           
            if (iError != 0) dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }

            if (!alreadyOpen) dalAccountTransaction.DBHelper.Close();
            return iError;
        }
        public int Update(InstrumentTransactionAccount t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;
            instrTransDetailDal = new InstrumentTransactionDetailDAL(dalAccountTransaction.DBHelper);
            accInstrTransDal = new AccountInstrumentTransactionDAL(dalAccountTransaction.DBHelper);
            instrPrepaidDal = new InstrumentPrepaidDAL(dalAccountTransaction.DBHelper);
            instrTransDal = new InstrumentTransactionDAL(this.dalAccountTransaction.DBHelper);
            prePaidExpseDal = new PrePaidExpenseDAL(this.dalAccountTransaction.DBHelper);
            dalAccountTransaction.BeginTransaction();

            iError = instrTransDetailDal.DeleteByInstrumentTransactionID(t.InstrTrans.TransactionID);
            if (iError == 0)
            {
                iError = base.UpdateBase(t);
            }

            if (iError == 0)
            {
                iError = instrTransDal.Update(t.InstrTrans);
            }
            //if (iError == 0)
            //{
            //    AccountInstrumentTransaction accInstrTrans = new AccountInstrumentTransaction();
            //    accInstrTrans.AccountTransactionID = t.AccountTransactionID;
            //    accInstrTrans.InstrumentTransactionID = t.InstrTrans.TransactionID;
            //    iError = accInstrTransDal.Insert(accInstrTrans);
            //}
            if (iError == 0)
            {
                foreach (InstrumentTransactionDetail instrTransDetail in t.InstrTrans.Detail)
                {
                    instrTransDetail.TransactionID = t.InstrTrans.TransactionID;
                    if (iError == 0)
                    {
                        iError = instrTransDetailDal.Insert(instrTransDetail);
                        if (iError == 0 && instrTransDetail.LstPrePaidExpense.Count > 0 && instrTransDetail.StockOutCode != string.Empty && instrTransDetail.StockOutCode != null)
                        {
                            instrTransDetail.LstPrePaidExpense[0].PrePaidNo = t.InstrTrans.TransactionNo;
                            instrTransDetail.LstPrePaidExpense[0].PrePaidDate = t.InstrTrans.TransactionDate;
                            instrTransDetail.LstPrePaidExpense[0].Quantity = instrTransDetail.Quantity;
                            instrTransDetail.LstPrePaidExpense[0].Price = instrTransDetail.Price;
                            instrTransDetail.LstPrePaidExpense[0].Amount = instrTransDetail.Amount;
                            instrTransDetail.LstPrePaidExpense[0].DepAccountCode = instrTransDetail.DepAccountCode;
                            instrTransDetail.LstPrePaidExpense[0].DepSubjectCode = instrTransDetail.DepSubjectCode;
                            instrTransDetail.LstPrePaidExpense[0].DepClassificationCode = instrTransDetail.DepClassificationCode;
                            iError = prePaidExpseDal.Insert(instrTransDetail.LstPrePaidExpense[0]);
                            if (iError == 0)
                            {
                                InstrumentPrepaid instrPrepaid = new InstrumentPrepaid();
                                instrPrepaid.InstrumentTransactionDetailID = instrTransDetail.TransactionDetailID;
                                instrPrepaid.PrePaidCode = instrTransDetail.LstPrePaidExpense[0].PrePaidCode;
                                iError = instrPrepaidDal.Insert(instrPrepaid);
                            }
                        }
                        if (iError != 0) break;
                    }
                }
            }
            if (iError != 0) dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }
            if (!alreadyOpen) dalAccountTransaction.DBHelper.Close();
            return iError;
        }
        public int Delete(InstrumentTransactionAccount t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;
            instrTransDal = new InstrumentTransactionDAL(this.dalAccountTransaction.DBHelper);
            dalAccountTransaction.BeginTransaction();
            iError = base.DeleteBase(t);
            if (iError == 0)
            {
                iError = instrTransDal.Delete(t.InstrTrans);
            }
            if (iError != 0) dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }
            if (!alreadyOpen) dalAccountTransaction.DBHelper.Close();
            return iError;
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as InstrumentTransactionAccount);
        }
        public int Update(object obj)
        {
            return this.Update(obj as InstrumentTransactionAccount);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as InstrumentTransactionAccount);
        }
        #endregion
    }
}
