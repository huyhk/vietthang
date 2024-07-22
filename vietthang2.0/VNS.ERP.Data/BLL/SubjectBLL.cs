using System;
using System.Collections.Generic;
using System.Text;

using VNS.Common;
using VNS.Utils;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data
{
    public class SubjectBLL<T> : IBusiness
        where T : Subject, new()
    {
        protected SubjectDAL<T> dal = new SubjectDAL<T>();

        public DataTable GetAllToDataTable()
        {
            return dal.GetAll();
        }
        public DataTable GetSubjectsOutSideToDataTable()
        {
            return dal.GetSubjectOutSide();
        }
        public T GetBySubjectCode(string subjectCode)
        {
            return dal.GetBySubjectCode(subjectCode);
        }
        public ListBase<Subject> GetListBaseSubjectOutSide()
        {
            return dal.GetListBaseSubjectOutSide();
        }
         public ListBase<T> GetObjectByType(string subjectType)
        {
            return dal.GetObjectByType(subjectType);
        }
        public ListBase<T> GetDynamic(string WhereCondition, string OrderByExpression)
        {
            return dal.GetObjectDynamic(WhereCondition, OrderByExpression);
        }
        public ListBase<T> GetAllByMemberID(string subjectType, string memberID)
        {
            return dal.GetObjectByTypeAndMemberID(subjectType, memberID);
        }
        public int Insert(T t)
        {
            int iError = 0;
            //t.UserCreated = Contexts.CurrentUser.LoginName;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    if (t.Properties != null)
                    {
                        for (int i = 0; i <= t.Properties.Length - 1; i++)
                        {
                            iError = dal.InsertUpdateProperty(t.SubjectCode, (byte)i, t.Properties[i]);
                            if (iError != 0)
                                break;
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SubjectBLL", "Insert(T t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }
            return iError;
        }

        public int Update(T t)
        {
            int iError = 0;
            //t.UserUpdated = Contexts.CurrentUser.LoginName;
            try
            {
                dal.Open();
                dal.BeginTransaction();
                iError = dal.Update(t);
                if (iError == 0)
                {
                    if (t.Properties != null)
                    {
                        for (int i = 0; i <= t.Properties.Length - 1; i++)
                        {
                            iError = dal.InsertUpdateProperty(t.SubjectCode, (byte)i, t.Properties[i]);
                            if (iError != 0)
                                break;
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SubjectBLL", "Update(T t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }

            return iError;
        }

        public int Delete(T t)
        {
            return dal.Delete(t);
        }

        public int Delete(string _subjectCode)
        {
            return dal.Delete(_subjectCode);
        }


        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as T);
        }
        public int Update(object obj)
        {
            return this.Update(obj as T);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as T);
        }
        #endregion
    }
    public class CustomerBLL : SubjectBLL<Customer>
    {
        public System.Data.DataTable ReportDiscount(DateTime startDate, DateTime endDate)
        {
            return new CustomerDAL().ReportDiscount(startDate, endDate);
        }
        public System.Data.DataTable ReportDiscountDetail(DateTime startDate, DateTime endDate)
        {
            return new CustomerDAL().ReportDiscountDetail(startDate, endDate);
        }
        public ListBase<Customer> GetAll()
        {
            return dal.GetObjectByType(enumSubjectType.Customer.ToString());
        }
        public ListBase<Customer> GetTS()
        { return dal.GetObjectCustomer(ProductType.THUYSAN); }
        public ListBase<Customer> GetGS()
        { return dal.GetObjectCustomer(ProductType.GIASUC); }
        public ListBase<Customer> GetCustomer(string productType)
        { return dal.GetObjectCustomer(productType); }
    }
    public class VendorBLL : SubjectBLL<Vendor>
    {
        public ListBase<Vendor> GetAll()
        {
            return dal.GetObjectByType(enumSubjectType.Vendor.ToString());
        }
        public ListBase<Vendor> GetForPurchase()
        {
            ListBase<Vendor> lst = this.GetAll();
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (!lst[i].PurchaseDept)
                    lst.RemoveAt(i);
            }
            return lst;
        }
        public ListBase<Vendor> GetForBocxep()
        {
            ListBase<Vendor> lst = this.GetAll();
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (!lst[i].BocxepDept)
                    lst.RemoveAt(i);
            }
            return lst;
        }
        public ListBase<Vendor> GetForVanchuyen()
        {
            ListBase<Vendor> lst = this.GetAll();
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (!lst[i].VanchuyenDept)
                    lst.RemoveAt(i);
            }
            return lst;
        }
    }
    //public class TransportBLL : SubjectBLL<Transport>
    //{
    //    public ListBase<Transport> GetAll()
    //    {
    //        return dal.GetObjectByType(enumSubjectType.Transport.ToString());
    //    }
    //}
    public class BankBLL : SubjectBLL<Bank>
    {
        public ListBase<Bank> GetAll()
        {
            return dal.GetObjectByType(enumSubjectType.Bank.ToString());
        }
        //public ListBase<Bank> GetAllByMemberID(string memberID)
        //{
        //    return dal.GetObjectByTypeAndMemberID(enumSubjectType.Bank.ToString(),memberID);
        //}
    }
    public class CashBLL : SubjectBLL<Cash>
    {
        public ListBase<Cash> GetAll()
        {
            return dal.GetObjectByType(enumSubjectType.Cash.ToString());
        }
        //public ListBase<Cash> GetAllByMemberID(string memberID)
        //{
        //    return dal.GetObjectByTypeAndMemberID(enumSubjectType.Cash.ToString(), memberID);
        //}
    }
    public class FixedAssetBLL : SubjectBLL<FixedAsset>
    {
        public ListBase<FixedAsset> GetAll()
        {
            return dal.GetObjectByType(enumSubjectType.FixedAsset.ToString());
        }
    }

    public class BranchBLL : SubjectBLL<Branch>
    {
        public ListBase<Branch> GetAll()
        {
            return dal.GetObjectByType(enumSubjectType.Branch.ToString());
        }
    }
    public class AdPaymentBLL : SubjectBLL<AdPayment>
    {
        public ListBase<AdPayment> GetAll()
        {
            return dal.GetObjectByType(enumSubjectType.AdPayment.ToString());
        }
    }

    public class SubjectBLL : SubjectBLL<Subject>
    {
        public ListBase<Subject> GetAll()
        {
            return dal.GetObjectAll();
        }

        public ListBase<Subject> GetBankandCash()
        {
            return dal.GetObjectDynamic("SubjectTypeCode in ('"+enumSubjectType.Cash.ToString()+"','"+enumSubjectType.Bank.ToString()+"')");
        }
        public ListBase<Subject> GetTTPT()
        {
            return dal.GetObjectDynamic("left(SubjectCode,3)='PT.'","SubjectCode");
        }
        //public ListBase<Subject> GetMaterialVendor()
        //{
        //    return dal.GetObjectDynamic("left(SubjectCode,3)='NL.' or left(SubjectCode,4)='NHL.'", "SubjectCode");
        //}
        //public ListBase<Subject> GetKhoVan()
        //{
        //    return dal.GetObjectDynamic("left(SubjectCode,3)='KV.'", "SubjectCode");
        //}
        public ListBase<Subject> GetBaohiem()
        {
            return dal.GetObjectDynamic("left(SubjectCode,3)='BH.'", "SubjectCode");
        }
    }
    public class AnalizeSubjectBLL : SubjectBLL<AnalizeSubject>
    {
        public ListBase<AnalizeSubject> GetAll()
        {
            return dal.GetObjectDynamic("left(SubjectCode,3)='PT.'");
        }
    }
}
