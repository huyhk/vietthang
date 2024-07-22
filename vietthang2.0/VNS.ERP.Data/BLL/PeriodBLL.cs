using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;

namespace VNS.ERP.Data
{
   public class PeriodBLL:IBusiness
    {
       private PeriodDAL   dal = new PeriodDAL() ;

       public PeriodBLL()
		{}
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public ListBase<Period> GetAll()
       {
           return dal.GetObjectAll();
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="whereCondition"></param>
       /// <param name="orderByExpression"></param>
       /// <returns></returns>
       public ListBase<Period> GetDynamic(string whereCondition, string orderByExpression)
       {
           return dal.GetObjectDynamic(whereCondition, orderByExpression);
       }
       public int OpenPeriod(string startPeriodCodeOpen, string moduleCode)
       {
           return dal.OpenPeriod(startPeriodCodeOpen, moduleCode);
       }
        /// <summary>
        /// Gets all objects 
        /// </summary>
       public  Period GetMin()
        {
            return dal.GetMin();
        }
       public Period SelectObjectSpecify(DateTime ngay)
       {
           return dal.SelectObjectSpecify(ngay);
       }
       public ListBase<Period> SelectIsClosedFalse(string moduleCode)
       {
           return dal.SelectIsClosedFalse(moduleCode);
       }
       public ListBase<Period> SelectIsClosedTrue(string moduleCode)
       {
           return dal.SelectIsClosedTrue(moduleCode);
       }
       public Period SelectObjectLastMonthSpecify(DateTime endDate)
       {
           return dal.SelectObjectLastMonthSpecify(endDate);
       }
       public Period GetByDate(DateTime workingDate)
       {
           return dal.GetByDate(workingDate);
       }
       public int CheckDataBeforeClosePeriod(ref DateTime dateDataError, ref string transactionNoDataError, string periodCode, string moduleCode)
       {
           return dal.CheckDataBeforeClosePeriod(ref dateDataError, ref transactionNoDataError, periodCode, moduleCode);
       }
       public int CheckDataBeforeClosePeriod(ref DateTime dateDataError, ref string transactionNoDataError, DateTime startDate, DateTime endDate, string moduleCode)
       { 
           return dal.CheckDataBeforeClosePeriod(ref dateDataError, ref transactionNoDataError, startDate, endDate, moduleCode);
       }
       /// <summary>
       /// Close period
       /// </summary>
       /// <param name="obj">end period is closed</param>
       /// <param name="moduleCode"></param>
       /// <param name="lst">list periods isclose false</param>
       /// <returns></returns>
       public int ClosePeriod(Period obj, string moduleCode, ListBase<Period> lst)
       {
           int iError=0;
           bool alreadyOpen = false;
           if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
           else alreadyOpen = true;
           //dal1 = new AccountSubjectTypeDAL(dal.DBHelper);
           dal.BeginTransaction();
           int count = lst.Count;
           for (int i = 0; i < count; i++)
           {
               Period obj1 = lst[i];
               if (obj1.StartDate <= obj.StartDate)
               {
                   if (iError == 0)
                   {
                       iError = dal.ClosePeriod(obj1.PeriodCode, moduleCode);
                   }
                   //if (iError == 0) this.SelectObjectLastMonthSpecify(obj1.EndDate);
                   if (iError != 0) break;
               }
               else
               {
                   i = count;
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
       public DateTime GetFromObjectModuleLocksByID(string moduleCode)
       {
           return dal.GetFromObjectModuleLocksByID(moduleCode);
       }
       public int UpdateObjectModuleLocks(string moduleCode, DateTime day)
       {
           return dal.UpdateObjectModuleLocks(moduleCode, day);
       }
        #region IBusiness Members

        public int Insert(object obj)
        {
            //return this.Insert(obj as Item);
            return 0;
        }

        public int Update(object obj)
        {
         //   return this.Update(obj as Item);
            return 0;
        }

        public int Delete(object obj)
        {
           // return this.Delete(obj as Item);
            return 0;
        }

        #endregion
    }
}
