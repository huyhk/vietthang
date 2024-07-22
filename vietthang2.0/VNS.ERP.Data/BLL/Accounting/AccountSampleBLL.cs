using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
    public class AccountSampleBLL : IBusiness
    {
        AccountSampleDAL dal = new AccountSampleDAL();
        AccountSampleDetail1DAL dal1 = new AccountSampleDetail1DAL();
        AccountSampleDetail2DAL dal2 = new AccountSampleDetail2DAL();

        public AccountSampleBLL() { }
        public ListBase<AccountSampleDetail1> GetDetail1ByID(string accountSampleCode)
        {
            return dal1.GetByID(accountSampleCode);
        }
        public ListBase<AccountSampleDetail2> GetDetail2ByID(string accountSampleCode)
        {
            return dal2.GetByID(accountSampleCode);
        }
        /// <summary>
        /// Return true if Detail1 was refreshed, return false for else
        /// </summary>
        /// <returns></returns>
        public bool CompareDetail1(AccountSample t)
        {
            Boolean notFound = true;
            AccountSampleDetail1 asd1;
            foreach (AccountSampleDetail2 asd2 in t.Detail2)
            {
                asd1 = new AccountSampleDetail1();
                asd1.AccountSampleCode = t.AccountSampleCode;
                asd1.AccountCode = asd2.DebitAccountCode;
                asd1.SubjectCode = asd2.DebitSubjectCode;
                asd1.ClassificationCode = asd2.DebitClassificationCode;
                asd1.Description = asd2.Description;
                notFound = true;
                if (t.Detail1.Count > 0)
                {
                    foreach (AccountSampleDetail1 asd11 in t.Detail1)
                    {
                        if (asd11.AccountCode == asd1.AccountCode && asd11.SubjectCode == asd1.SubjectCode && asd11.ClassificationCode == asd1.ClassificationCode)
                        {
                            notFound = false;
                        }
                    }
                }
                if (notFound && asd1.AccountCode != null && asd1.AccountCode != string.Empty)
                {
                    return false;
                }

                asd1 = new AccountSampleDetail1();
                asd1.AccountSampleCode = t.AccountSampleCode;
                asd1.AccountCode = asd2.CreditAccountCode;
                asd1.SubjectCode = asd2.CreditSubjectCode;
                asd1.ClassificationCode = asd2.CreditClassificationCode;
                asd1.Description = asd2.Description;
                notFound = true;
                if (t.Detail1.Count > 0)
                {
                    foreach (AccountSampleDetail1 asd11 in t.Detail1)
                    {
                        if (asd11.AccountCode == asd1.AccountCode && asd11.SubjectCode == asd1.SubjectCode && asd11.ClassificationCode == asd1.ClassificationCode)
                        {
                            notFound = false;
                        }
                    }
                }
                if (notFound && asd1.AccountCode != null && asd1.AccountCode != string.Empty)
                {
                    return false;
                }
            }
            return true;
        }
        public void RefeshDetail1(AccountSample t)
        {
            Boolean notFound = true;
            Boolean notFoundCre = true;
            //AccountSampleDetail1 asd1;
            t.Detail1.Clear();
            AccountSampleDetail1 asd1Credit=null;
            foreach (AccountSampleDetail2 asd2 in t.Detail2)
            {
                AccountSampleDetail1 asd1 = new AccountSampleDetail1();
                asd1.AccountSampleCode = t.AccountSampleCode;
                asd1.AccountCode = asd2.DebitAccountCode;
                asd1.SubjectCode = asd2.DebitSubjectCode;
                asd1.ClassificationCode = asd2.DebitClassificationCode;
                asd1.Description = asd2.Description;
                notFound = true;
                if (t.Detail1.Count > 0)
                {
                    foreach (AccountSampleDetail1 asd11 in t.Detail1)
                    {
                        if (asd11.AccountCode == asd1.AccountCode && asd11.SubjectCode == asd1.SubjectCode && asd11.ClassificationCode == asd1.ClassificationCode)
                        {
                            notFound = false;
                        }
                    }
                }
                
                //if (notFound && asd1.AccountCode != string.Empty)
                //{
                //    t.Detail1.Add(asd1);
                //}

                AccountSampleDetail1 asd1cre = new AccountSampleDetail1();
                asd1cre.AccountSampleCode = t.AccountSampleCode;
                asd1cre.AccountCode = asd2.CreditAccountCode;
                asd1cre.SubjectCode = asd2.CreditSubjectCode;
                asd1cre.ClassificationCode = asd2.CreditClassificationCode;
                asd1cre.Description = asd2.Description;
                notFoundCre = true;
                if (t.Detail1.Count > 0)
                {
                    foreach (AccountSampleDetail1 asd11 in t.Detail1)
                    {
                        if (asd11.AccountCode == asd1cre.AccountCode && asd11.SubjectCode == asd1cre.SubjectCode && asd11.ClassificationCode == asd1cre.ClassificationCode)
                        {
                            notFoundCre = false;
                        }
                    }
                }
                if (notFoundCre && asd1cre.AccountCode != string.Empty)
                {
                    if (asd1Credit == null)
                    {
                        if (notFound && asd1.AccountCode != string.Empty)
                        {
                            t.Detail1.Add(asd1);
                        }
                        asd1Credit = asd1cre.Clone() as AccountSampleDetail1;
                    }
                    else
                    {
                        if (asd1Credit.AccountCode != asd1cre.AccountCode || asd1Credit.SubjectCode != asd1cre.SubjectCode || asd1Credit.ClassificationCode != asd1cre.ClassificationCode)
                        {
                            t.Detail1.Add(asd1Credit.Clone() as AccountSampleDetail1);
                            if (notFound && asd1.AccountCode != string.Empty)
                            {
                                t.Detail1.Add(asd1);
                            }
                            asd1Credit = asd1cre.Clone() as AccountSampleDetail1;
                        }
                        else
                        {
                            if (notFound && asd1.AccountCode != string.Empty)
                            {
                                t.Detail1.Add(asd1);
                            }
                        }
                    }
                    //t.Detail1.Add(asd1);
                }
                else
                {
                    if (notFound && asd1.AccountCode != string.Empty)
                    {
                        t.Detail1.Add(asd1);
                    }
                }
            }
            if (asd1Credit != null)
            {
                t.Detail1.Add(asd1Credit);
            }
        }
        public ListBase<AccountSample> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(AccountSample t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal1 = new AccountSampleDetail1DAL(dal.DBHelper);
            dal2 = new AccountSampleDetail2DAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (AccountSampleDetail1 asd1 in t.Detail1)
                {
                    asd1.AccountSampleCode = t.AccountSampleCode;
                    if (iError == 0)
                    {
                        iError = dal1.Insert(asd1);
                        if (iError != 0) break;
                    }
                }
            }
            if (iError == 0)
            {
                foreach (AccountSampleDetail2 asd2 in t.Detail2)
                {
                    asd2.AccountSampleCode = t.AccountSampleCode;
                    if (iError == 0)
                    {
                        iError = dal2.Insert(asd2);
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
        public int Update(AccountSample t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal1 = new AccountSampleDetail1DAL(dal.DBHelper);
            dal2 = new AccountSampleDetail2DAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal1.Delete(t.AccountSampleCode);
            }
            if (iError == 0)
            {
                iError = dal2.Delete(t.AccountSampleCode);
            }
            if (iError == 0)
            {
                foreach (AccountSampleDetail1 asd1 in t.Detail1)
                {
                    if (iError == 0)
                    {
                        asd1.AccountSampleCode = t.AccountSampleCode;
                        iError = dal1.Insert(asd1);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (AccountSampleDetail2 asd2 in t.Detail2)
                {
                    if (iError == 0)
                    {
                        asd2.AccountSampleCode = t.AccountSampleCode;
                        iError = dal2.Insert(asd2);
                    }
                    if (iError != 0) break;
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
        public int Delete(AccountSample t)
        {
            return dal.Delete(t);
        }

        public void GetDetailAccountSamples(AccountSample obj)
        {
            dal.GetDetailAccountSamples(obj);
        }

        public ListBase<AccountSample> GetListAccountSamplesByTypeCode(string typeCode)
        {
            return dal.GetListAccountSamplesByTypeCode(typeCode);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountSample);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountSample);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountSample);
        }
        #endregion
    }
}
