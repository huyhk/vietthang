using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
using VNS.Data.BLL;

namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionBLL : AccountTransactionBLL<AccountTransaction>, IBusiness
    {
        AccountTransactionDAL dal = new AccountTransactionDAL();

        public AccountTransactionBLL() { }
        public ListBase<AccountTransaction> GetAll()
        {
            return dalAccountTransaction.GetObjectAll();
        }
        public AccountTransaction GetByAccountTransactionID(Guid accountTransactionID)
        {
            return dal.GetByAccountTransactionID(accountTransactionID);
        }
        public DataSet GetCloseAmount(DateTime startDate, DateTime endDate, string specialTypeNotCalculate)
        {
            return dal.GetCloseAmount(startDate, endDate, specialTypeNotCalculate);
        }
        public DataSet GetCloseAmount5678(string prefixAccount, DateTime startDate, DateTime endDate, string specialTypeNotCalculate)
        {
            return dal.GetCloseAmount5678(prefixAccount, startDate, endDate, specialTypeNotCalculate);
        }
        public ListBase<AccountTransaction> GetByStockTransTypeAndDate(string accTypeCode, string stockTransType, DateTime startDate, DateTime endDate)
        {
            return dal.GetByStockTransTypeAndDate(accTypeCode, stockTransType, startDate, endDate);
        }
        /// <summary>
        /// Insert Object into DataBase.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
       public int Insert(AccountTransaction t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;
            dalAccountTransaction.BeginTransaction();
            iError = InsertBase(t);
            if (iError != 0)
                dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }
            if (!alreadyOpen)
                dalAccountTransaction.DBHelper.Close();
            return iError;
        }
        

        public AccountTransaction GetFor632911(DateTime startDate, DateTime endDate)
        {
            return dal.GetFor632911(startDate, endDate);
        }
       
        public int Update(AccountTransaction t)
        {


            int iError;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;

            dalAccountTransaction.BeginTransaction();
            iError = UpdateBase(t);
            if (iError != 0)
                dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }
            if (!alreadyOpen)
                dalAccountTransaction.DBHelper.Close();
            return iError;
            
        }
        public int Delete(ListBase<AccountTransaction> lst)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();
            foreach (AccountTransaction t in lst)
            {
                if (iError == 0)
                {
                    iError = dal.Delete(t);
                }
                if (iError != 0) break;
            }
            if (iError != 0)
                dal.Rollback();
            else
            {
                dal.Commit();
            }

            if (!alreadyOpen)
                dal.DBHelper.Close();
            return iError;
        }
       
        public int Delete(AccountTransaction t)
        {
            return DeleteBase(t);
        }
        public decimal GetCloseAmount(string accountCode, DateTime startDate, DateTime endDate, string specialTypeNotCalculate)
        {
            return dal.GetCloseAmount(accountCode, startDate, endDate, specialTypeNotCalculate);
        }
        public decimal GetCloseAmount(string accountCode, string prefixAccountNotCalculate, DateTime startDate, DateTime endDate)
        {
            return dal.GetCloseAmount(accountCode, prefixAccountNotCalculate, startDate, endDate);
        }
        public decimal GetCloseAmount(string accountCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetCloseAmount(accountCode, startDate, endDate);
        }

        public ListBase<AccountTransaction2> GetAT2FromDataSet(DataSet ds)
        {
            ListBase<AccountTransaction2> lstobj = new ListBase<AccountTransaction2>();
            DataRelation drDetail1 = ds.Relations.Add("Detail1",
                   ds.Tables[0].Columns["AccountTransactionID"],
                   ds.Tables[1].Columns["AccountTransactionID"]);
            //DataRelation drDetail2 = ds.Relations.Add("Detail2",
            //   ds.Tables[0].Columns["AccountTransactionID"],
            //   ds.Tables[2].Columns["AccountTransactionID"]);
            //DataRelation drInvoice = ds.Relations.Add("Invoice",
            //   ds.Tables[0].Columns["AccountTransactionID"],
            //   ds.Tables[3].Columns["AccountTransactionID"]);
            //DataRelation drBuyNoInvoice = ds.Relations.Add("BuyNoInvoice",
            //   ds.Tables[0].Columns["AccountTransactionID"],
            //   ds.Tables[4].Columns["AccountTransactionID"]);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                AccountTransaction2 t = new AccountTransaction2();
                t.LoadFromDataRow(row);
                
                //t.Detail1 = new ListBase<AccountTransactionDetail1>();
                //t.Detail2 = new ListBase<AccountTransactionDetail2>();
                //t.Invoice = new ListBase<Invoice>();
                //t.BuyNoInvoice = new ListBase<BuyNoInvoice>();
                bool firstObj = true;
                foreach (DataRow rowDetail1 in row.GetChildRows(drDetail1))
                {
                    if (firstObj)
                    {
                        firstObj = false;
                        t.LoadFromDataRowD1(rowDetail1);
                        lstobj.Add(t);
                    }
                    else
                    {
                        AccountTransaction2 td1 = new AccountTransaction2();
                        td1.LoadFromDataRowD1(rowDetail1);
                        lstobj.Add(td1);
                    }
                    //t.Detail1.Add(atd1);
                }
                //foreach (DataRow rowDetail2 in row.GetChildRows(drDetail2))
                //{
                //    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                //    atd2.LoadFromDataRow(rowDetail2);
                //    t.Detail2.Add(atd2);
                //}
                //foreach (DataRow rowInvoice in row.GetChildRows(drInvoice))
                //{
                //    Invoice inv = new Invoice();
                //    inv.LoadFromDataRow(rowInvoice);
                //    t.Invoice.Add(inv);
                //}
                //foreach (DataRow rowInvoice in row.GetChildRows(drBuyNoInvoice))
                //{
                //    BuyNoInvoice inv = new BuyNoInvoice();
                //    inv.LoadFromDataRow(rowInvoice);
                //    t.BuyNoInvoice.Add(inv);
                //}
                
            }
            return lstobj;
        }
        public ListBase<AccountTransaction2> GetAT2BySubject(string accTypeCode, DateTime startDate, DateTime endDate, string subjectCode1)
        {
            return GetAT2FromDataSet( dalAccountTransaction.GetDSBySubject(accTypeCode, startDate, endDate, subjectCode1));
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountTransaction);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountTransaction);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountTransaction);
        }
        #endregion
    }
    public class AccountTransactionBLL<T>
        where T : AccountTransaction, new()
    {
        protected AccountTransactionDAL<T> dalAccountTransaction = new AccountTransactionDAL<T>();
        protected AccountTransactionDetail1DAL dalDetail1;
        protected AccountTransactionDetail2DAL dalDetail2;
        protected InvoiceDAL dalInvoice;
        protected BuyNoInvoiceDAL dalBuyNoInvoice;

        //public abstract int Insert(T t);

        //public abstract int Update(T t);

        //public abstract int Delete(T t);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public void RefeshDetail1(T t)
        {
            Boolean notFound = true;
            AccountTransactionDetail1 atd1;
            if (t.Detail2 == null)
            {
                return;
            }
            if (t.Detail1 == null)
            {
                t.Detail1 = new ListBase<AccountTransactionDetail1>();
            }
            t.Detail1.Clear();
            foreach (AccountTransactionDetail2 atd2 in t.Detail2)
            {
                atd1 = new AccountTransactionDetail1();
                atd1.AccountTransactionID = t.AccountTransactionID;
                atd1.AccountCode = atd2.DebitAccountCode;
                atd1.SubjectCode = atd2.DebitSubjectCode;
                atd1.ClassificationCode = atd2.DebitClassificationCode;
                atd1.DebitAmount = atd2.Amount;
                atd1.CreditAmount = 0;
                atd1.DebitAmountNT = atd2.AmountNT;
                atd1.CreditAmountNT = 0;
                atd1.Description = atd2.Description;
                notFound = true;
                if (t.Detail1.Count > 0)
                {
                    foreach (AccountTransactionDetail1 atd11 in t.Detail1)
                    {
                        if (atd1.AccountCode == atd11.AccountCode && atd1.SubjectCode == atd11.SubjectCode && atd1.ClassificationCode == atd11.ClassificationCode && atd11.DebitAmount != 0)
                        {
                            atd11.DebitAmount += atd1.DebitAmount;
                            notFound = false;
                            break;
                        }
                    }
                }
                if (notFound)
                {
                    t.Detail1.Add(atd1);
                }

                atd1 = new AccountTransactionDetail1();
                atd1.AccountTransactionID = t.AccountTransactionID;
                atd1.AccountCode = atd2.CreditAccountCode;
                atd1.SubjectCode = atd2.CreditSubjectCode;
                atd1.ClassificationCode = atd2.CreditClassificationCode;
                atd1.DebitAmount = 0;
                atd1.CreditAmount = atd2.Amount;
                atd1.DebitAmountNT = 0;
                atd1.CreditAmountNT = atd2.AmountNT;
                atd1.Description = atd2.Description2;
                notFound = true;
                if (t.Detail1.Count > 0)
                {
                    foreach (AccountTransactionDetail1 atd11 in t.Detail1)
                    {
                        if (atd1.AccountCode == atd11.AccountCode && atd1.SubjectCode == atd11.SubjectCode && atd1.ClassificationCode == atd11.ClassificationCode && atd11.CreditAmount != 0)
                        {
                            atd11.CreditAmount += atd1.CreditAmount;
                            notFound = false;
                            break;
                        }
                    }
                }
                if (notFound)
                {
                    t.Detail1.Add(atd1);
                }
            }
            int resultCheckAccountDetailKind = this.CheckAccountDetailKind(t.Detail1);
            if (resultCheckAccountDetailKind == 1)//1 nợ nhiều có
            {
                string debitAccountCode = "";
                if (t.Detail2.Count > 0)
                {
                    debitAccountCode = t.Detail2[0].DebitAccountCode;
                }
                int coutDetail1 = t.Detail1.Count;
                for (int i = 0; i < coutDetail1; i++)
                {
                    AccountTransactionDetail1 atdetail1 = t.Detail1[i];
                    if (atdetail1.AccountCode == debitAccountCode)
                    {
                        AccountTransactionDetail1 atd11 = (AccountTransactionDetail1)atdetail1.Clone();
                        t.Detail1.Remove(atdetail1);
                        t.Detail1.Add(atd11);
                        i = coutDetail1;//break
                    }
                }
            }
            if (resultCheckAccountDetailKind == 2)//1 có nhiều nợ
            {
                string creditAccountCode = "";
                if (t.Detail2.Count > 0)
                {
                    creditAccountCode = t.Detail2[0].CreditAccountCode;
                }
                int coutDetail1 = t.Detail1.Count;
                for (int i = 0; i < coutDetail1; i++)
                {
                    AccountTransactionDetail1 atdetail1 = t.Detail1[i];
                    if (atdetail1.AccountCode == creditAccountCode)
                    {
                        AccountTransactionDetail1 atd11 = (AccountTransactionDetail1)atdetail1.Clone();
                        t.Detail1.Remove(atdetail1);
                        t.Detail1.Add(atd11);
                        i = coutDetail1;//break
                    }
                }
            }
            if (resultCheckAccountDetailKind == 3)//nhiều có nhiều nợ
            {

            }


        }

        /// <summary>
        /// Kiểm tra chi tiết định khoản, nợ-có : 1-n, n-1, n-n...
        /// Return 1: 1-n, 2: n-1, 3: n-n, 4:...
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public int CheckAccountDetailKind(ListBase<AccountTransactionDetail1> lst)
        {
            int DebitAccountCounter = 0;
            int CreditAccountCounter = 0;
            foreach (AccountTransactionDetail1 accDetai1 in lst)
            {
                if (accDetai1.AccountCode != string.Empty)
                {
                    if (accDetai1.DebitAmount == 0 && accDetai1.CreditAmount == 0)
                        return 4;
                    if (accDetai1.DebitAmount != 0)
                        DebitAccountCounter += 1;
                    if (accDetai1.CreditAmount != 0)
                        CreditAccountCounter += 1;
                }
            }
            if (DebitAccountCounter == 1)
                return 1;
            if (CreditAccountCounter == 1)
                return 2;
            return 3;
        }

        public bool CompareDetail1(T t)
        {
            bool check = false;
            ListBase<AccountTransactionDetail1> lstDetail1 = new ListBase<AccountTransactionDetail1>();
            int index = -1;
            foreach (AccountTransactionDetail1 accDetail1 in t.Detail1)
            {
                AccountTransactionDetail1 acc1 = new AccountTransactionDetail1();
                acc1.IsTest = true;
                acc1.AccountCode = accDetail1.AccountCode;
                acc1.SubjectCode = accDetail1.SubjectCode;
                acc1.ClassificationCode = accDetail1.ClassificationCode;
                acc1.DebitAmount = accDetail1.DebitAmount;
                acc1.CreditAmount = accDetail1.CreditAmount;
                index = SearchDetail1(lstDetail1, acc1.AccountCode, acc1.SubjectCode, acc1.ClassificationCode);
                if (index >= 0)
                {
                    lstDetail1[index].DebitAmount += accDetail1.DebitAmount;
                    lstDetail1[index].CreditAmount += accDetail1.CreditAmount;
                }
                else
                {
                    lstDetail1.Add(acc1);
                }
            }

            ListBase<AccountTransactionDetail1> lstDetail2 = new ListBase<AccountTransactionDetail1>();
            foreach (AccountTransactionDetail2 accDetail2 in t.Detail2)
            {
                index = -1;
                ///Debit
                AccountTransactionDetail1 acc1 = new AccountTransactionDetail1();
                acc1.IsTest = true;
                acc1.AccountCode = accDetail2.DebitAccountCode;
                acc1.SubjectCode = accDetail2.DebitSubjectCode;
                acc1.ClassificationCode = accDetail2.DebitClassificationCode;
                acc1.DebitAmount = accDetail2.Amount;
                acc1.CreditAmount = 0;
                index = SearchDetail1(lstDetail2, acc1.AccountCode, acc1.SubjectCode, acc1.ClassificationCode);
                if (index >= 0)
                {
                    lstDetail2[index].DebitAmount += accDetail2.Amount;
                }
                else
                {
                    lstDetail2.Add(acc1);
                }
                index = -1;
                ///Credit
                acc1 = new AccountTransactionDetail1();
                acc1.IsTest = true;
                acc1.AccountCode = accDetail2.CreditAccountCode;
                acc1.SubjectCode = accDetail2.CreditSubjectCode;
                acc1.ClassificationCode = accDetail2.CreditClassificationCode;
                acc1.DebitAmount = 0;
                acc1.CreditAmount = accDetail2.Amount;
                index = SearchDetail1(lstDetail2, acc1.AccountCode, acc1.SubjectCode, acc1.ClassificationCode);
                if (index >= 0)
                {
                    lstDetail2[index].CreditAmount += accDetail2.Amount;
                }
                else
                {
                    lstDetail2.Add(acc1);
                }
            }
            index = -1;
            for (int i = lstDetail1.Count - 1; i >= 0; i--)
            {
                index = SearchDetail1(lstDetail2, lstDetail1[i].AccountCode, lstDetail1[i].SubjectCode, lstDetail1[i].ClassificationCode, lstDetail1[i].DebitAmount, lstDetail1[i].CreditAmount);

                if (index >= 0)
                {
                    lstDetail1.RemoveAt(i);
                    lstDetail2.RemoveAt(index);
                }
            }
            if (lstDetail1.Count == 0 && lstDetail2.Count == 0)
                check = true;
            else
                check = false;
            return check;
        }
        private int SearchDetail1(ListBase<AccountTransactionDetail1> lst, string accountCode, string subjectCode, string classificationCode)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].AccountCode == accountCode && lst[i].SubjectCode == subjectCode && lst[i].ClassificationCode == classificationCode)
                    return i;
            }
            return -1;
        }
        private int SearchDetail1(ListBase<AccountTransactionDetail1> lst, string accountCode, string subjectCode, string classificationCode, decimal debitAmount, decimal creditAmount)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].AccountCode == accountCode && lst[i].SubjectCode == subjectCode && lst[i].ClassificationCode == classificationCode && lst[i].DebitAmount == debitAmount && lst[i].CreditAmount == creditAmount)
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        public void RefeshDetail2(T t)
        {
            int countNumDebitAmountNotZero = 0;
            int countNumCreditAmountNotZero = 0;
            string uniqueDebitAccountCode = "";
            string uniqueCreditAccountCode = "";
            string uniqueDebitSubjectCode = "";
            string uniqueCreditSubjectCode = "";
            string uniqueDebitClassificationCode = "";
            string uniqueCreditClassificationCode = "";
            string uniqueDescription2 = "";
            string uniqueDescription = "";

            if (t.Detail1 == null)
            {
                return;
            }
            if (t.Detail2 == null)
            {
                t.Detail2 = new ListBase<AccountTransactionDetail2>();
            }
            t.Detail2.Clear();


            foreach (AccountTransactionDetail1 atd1 in t.Detail1)
            {
                if (atd1.DebitAmount != 0)
                {
                    countNumDebitAmountNotZero += 1;
                    uniqueDebitAccountCode = atd1.AccountCode;
                    uniqueDebitSubjectCode = atd1.SubjectCode;
                    uniqueDebitClassificationCode = atd1.ClassificationCode;
                    uniqueDescription = atd1.Description;
                }
                if (atd1.CreditAmount != 0)
                {
                    countNumCreditAmountNotZero += 1;
                    uniqueCreditAccountCode = atd1.AccountCode;
                    uniqueCreditSubjectCode = atd1.SubjectCode;
                    uniqueCreditClassificationCode = atd1.ClassificationCode;
                    uniqueDescription2 = atd1.Description;
                }
            }
            AccountTransactionDetail2 atd2;
            //t.Detail2.Clear();
            int countDetail1 = t.Detail1.Count;
            if (countNumDebitAmountNotZero == 1)
            {
                for (int i = 0; i < countDetail1; i++)
                {
                    atd2 = new AccountTransactionDetail2();
                    if (t.Detail1[i].DebitAmount == 0)
                    {
                        atd2.AccountTransactionID = t.AccountTransactionID;
                        atd2.DebitAccountCode = uniqueDebitAccountCode;
                        atd2.CreditAccountCode = t.Detail1[i].AccountCode;
                        atd2.DebitSubjectCode = uniqueDebitSubjectCode;
                        atd2.CreditSubjectCode = t.Detail1[i].SubjectCode;
                        atd2.DebitClassificationCode = uniqueDebitClassificationCode;
                        atd2.CreditClassificationCode = t.Detail1[i].ClassificationCode;
                        atd2.Amount = t.Detail1[i].CreditAmount;
                        atd2.AmountNT = t.Detail1[i].CreditAmountNT;

                        atd2.Description = uniqueDescription;
                        atd2.Description2 = t.Detail1[i].Description;
                        t.Detail2.Add(atd2);
                    }
                }
            }
            if (countNumCreditAmountNotZero == 1 && countNumDebitAmountNotZero != 1)
            {
                for (int i = 0; i < countDetail1; i++)
                {
                    if (t.Detail1[i].CreditAmount == 0)
                    {
                        atd2 = new AccountTransactionDetail2();
                        atd2.AccountTransactionID = t.AccountTransactionID;
                        atd2.DebitAccountCode = t.Detail1[i].AccountCode;
                        atd2.CreditAccountCode = uniqueCreditAccountCode;
                        atd2.DebitSubjectCode = t.Detail1[i].SubjectCode;
                        atd2.CreditSubjectCode = uniqueCreditSubjectCode;
                        atd2.DebitClassificationCode = t.Detail1[i].ClassificationCode;
                        atd2.CreditClassificationCode = uniqueCreditClassificationCode;
                        atd2.Amount = t.Detail1[i].DebitAmount;
                        atd2.AmountNT = t.Detail1[i].DebitAmountNT;
                        atd2.Description2 = uniqueDescription2;
                        atd2.Description = t.Detail1[i].Description;
                        t.Detail2.Add(atd2);
                    }
                }
            }
        }
        /// <summary>
        /// Remove Object when Code is Empty
        /// </summary>
        /// <param name="detail1"></param>
        /// <param name="detail2"></param>
        public void RemoveObjects(ListBase<AccountTransactionDetail1> detail1, ListBase<AccountTransactionDetail2> detail2)
        {
            int count = detail1.Count;
            for (int i = 0; i < count; i++)
            {
                if (detail1[i].AccountCode == string.Empty)
                {
                    detail1.RemoveAt(i);
                    i -= 1;
                    count -= 1;
                }
            }

            count = detail2.Count;
            for (int i = 0; i < count; i++)
            {
                if (detail2[i].DebitAccountCode == string.Empty && detail2[i].CreditAccountCode == string.Empty)
                {
                    detail2.RemoveAt(i);
                    i -= 1;
                    count -= 1;
                }
            }
        }
        public ListBase<T> GetAccountTransactionByTypeCode(string accTypeCode)
        {
            return dalAccountTransaction.GetAccountTransactionByTypeCode(accTypeCode);
        }
        public ListBase<T> SelectBySpecialTypeAndDate(string specialType, DateTime startDate, DateTime endDate)
        {
            return dalAccountTransaction.SelectBySpecialTypeAndDate(specialType, startDate, endDate);
        }
        public ListBase<T> SelectBySpecialTypeAndDate(string specialType, DateTime startDate, DateTime endDate, string prefixAccount)
        {
            return dalAccountTransaction.SelectBySpecialTypeAndDate(specialType, startDate, endDate, prefixAccount);
        }
        public ListBase<T> SelectBySpecialTypeStockCodeAndDate(string specialType, string stockCode, DateTime startDate, DateTime endDate)
        {
            return dalAccountTransaction.SelectBySpecialTypeStockCodeAndDate(specialType, stockCode, startDate, endDate);
        }
        public ListBase<T> GetObjectByTypeCodeTime(string accTypeCode, DateTime startDate, DateTime endDate)
        {
            return dalAccountTransaction.GetObjectByTypeCodeTime(accTypeCode, startDate, endDate);
        }

        public ListBase<T> GetObjectBySubject(string accTypeCode, DateTime startDate, DateTime endDate,string subjectCode1)
        {
            return dalAccountTransaction.GetObjectBySubject(accTypeCode, startDate, endDate, subjectCode1);
        }

        public ListBase<T> GetObjectBySubjectAndDetail(string accTypeCode, DateTime startDate, DateTime endDate, string subjectCode1, string detailTransactionCode)
        {
            return dalAccountTransaction.GetObjectBySubjectAndDetail(accTypeCode, startDate, endDate, subjectCode1, detailTransactionCode);
        }

        public void GetDetailAccountTransaction(T obj)
        {
            dalAccountTransaction.GetDetailAccountTransaction(obj);
        }
        public T GetTopBySuffixAccountTransactionNo(string suffix)
        {
          return  dalAccountTransaction.GetTopBySuffixAccountTransactionNo(suffix);
        }
        public T GetTopBySuffixAccountTransactionNo(string suffix, int len)
        {
            return dalAccountTransaction.GetTopBySuffixAccountTransactionNo(suffix, len);
        }

        public int InsertBase(T t)
        {
            int iError = dalAccountTransaction.Insert(t);
            dalDetail1 = new AccountTransactionDetail1DAL(dalAccountTransaction.DBHelper);
            dalDetail2 = new AccountTransactionDetail2DAL(dalAccountTransaction.DBHelper);
            dalInvoice = new InvoiceDAL(dalAccountTransaction.DBHelper);
            dalBuyNoInvoice = new BuyNoInvoiceDAL(dalAccountTransaction.DBHelper);
            if (iError == 0)
            {
                foreach (AccountTransactionDetail1 atd1 in t.Detail1)
                {
                    atd1.AccountTransactionID = t.AccountTransactionID;
                    if (iError == 0)
                    {
                        if (atd1.AccountCode != string.Empty)
                        {
                            iError = dalDetail1.Insert(atd1);
                            if (iError != 0) break;
                        }
                    }
                }
            }
            if (iError == 0)
            {
                foreach (AccountTransactionDetail2 atd2 in t.Detail2)
                {
                    atd2.AccountTransactionID = t.AccountTransactionID;
                    if (iError == 0)
                    {
                        if (atd2.DebitAccountCode != string.Empty && atd2.CreditAccountCode != string.Empty)
                        {
                            iError = dalDetail2.Insert(atd2);
                            if (iError != 0) break;
                        }
                    }
                }
            }

            //if (iError == 0)
            //{
            //    RemoveObjects(t.Detail1, t.Detail2);
            //}
            if (iError == 0)
            {
                foreach (Invoice invo in t.Invoice)
                {
                    invo.AccountTransactionID = t.AccountTransactionID;
                    if(invo.Doanhso!=0)
                        iError = dalInvoice.Insert(invo);
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (BuyNoInvoice buyNo in t.BuyNoInvoice)
                {
                    buyNo.AccountTransactionID = t.AccountTransactionID;
                    if(buyNo.TienThanhtoan!=0)
                        iError = dalBuyNoInvoice.Insert(buyNo);
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                if (t.Tienvay != null)
                {
                    if (t.Tienvay.KheuocvayID != Guid.Empty)
                    {
                        t.Tienvay.AccountTransactionID = t.AccountTransactionID;
                        iError = dalAccountTransaction.InsertTienvay(t.Tienvay);
                    }
                }
            }
            return iError;
        }


        public int UpdateBase(T t)
        {
            int iError = dalAccountTransaction.Update(t);
            dalDetail1 = new AccountTransactionDetail1DAL(dalAccountTransaction.DBHelper);
            dalDetail2 = new AccountTransactionDetail2DAL(dalAccountTransaction.DBHelper);
            dalInvoice = new InvoiceDAL(dalAccountTransaction.DBHelper);
            dalBuyNoInvoice = new BuyNoInvoiceDAL(dalAccountTransaction.DBHelper);
            if (iError == 0) iError = dalDetail1.Delete(t.AccountTransactionID);
            if (iError == 0) iError = dalDetail2.Delete(t.AccountTransactionID);
            if (iError == 0) iError = dalInvoice.Delete(t.AccountTransactionID);
            if (iError == 0) iError = dalBuyNoInvoice.Delete(t.AccountTransactionID);
            if (iError == 0)
            {
                foreach (AccountTransactionDetail1 atd1 in t.Detail1)
                {
                    atd1.AccountTransactionID = t.AccountTransactionID;
                    if (iError == 0)
                    {
                        if (atd1.AccountCode != string.Empty)
                        {
                            iError = dalDetail1.Insert(atd1);
                            if (iError != 0) break;
                        }
                    }
                }
            }
            if (iError == 0)
            {
                foreach (AccountTransactionDetail2 atd2 in t.Detail2)
                {
                    atd2.AccountTransactionID = t.AccountTransactionID;
                    if (iError == 0)
                    {
                        if (atd2.DebitAccountCode != string.Empty && atd2.CreditAccountCode != string.Empty)
                        {
                            iError = dalDetail2.Insert(atd2);
                            if (iError != 0) break;
                        }
                    }
                }
            }

            //if (iError == 0)
            //{
            //    RemoveObjects(t.Detail1, t.Detail2);
            //}
            if (iError == 0)
            {
                foreach (Invoice invo in t.Invoice)
                {
                    invo.AccountTransactionID = t.AccountTransactionID;
                    if (invo.Doanhso != 0)
                        iError = dalInvoice.Insert(invo);
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (BuyNoInvoice buyNo in t.BuyNoInvoice)
                {
                    buyNo.AccountTransactionID = t.AccountTransactionID;
                    if (buyNo.TienThanhtoan != 0)
                        iError = dalBuyNoInvoice.Insert(buyNo);
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                iError = dalAccountTransaction.DeleteTienvay(t.AccountTransactionID);
                if (t.Tienvay != null)
                {
                    if (t.Tienvay.KheuocvayID != Guid.Empty)
                    {
                        t.Tienvay.AccountTransactionID = t.AccountTransactionID;
                        iError = dalAccountTransaction.InsertTienvay(t.Tienvay);
                    }
                }
            }
            return iError;
        }

        public int DeleteBase(T t)
        {
            return dalAccountTransaction.Delete(t.AccountTransactionID);
        }
    }
}
