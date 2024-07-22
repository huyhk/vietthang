
/************************************************************************
**	ClassName	: 	PurchasePlanMonthsBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-11-2008 10:44 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
	#region PurchasePlanMonthsBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of PurchasePlanMonths.
	/// </summary>
	public class PurchasePlanMonthsBLL : IBusiness
	{
		private PurchasePlanMonthsDAL dal = new PurchasePlanMonthsDAL();
        private PurchasePlanMonthDetailDAL dalDetail;
		public PurchasePlanMonthsBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< PurchasePlanMonths >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< PurchasePlanMonths >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(PurchasePlanMonths t)
		{
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new PurchasePlanMonthDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (PurchasePlanMonthDetail detail in t.ListPurchasePlanMonthDetail)
                {
                    detail.PlanID = t.PlanID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
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
		/// <summary>
		/// Delete all rows 
		/// </summary>
		public int DeleteAll()
		{
			return dal.DeleteAll();
		}
		/// <summary>
		/// Delete rows by dynamic criteria
		/// </summary>
		public int DeleteDynamic(string whereCondidion)
		{
			return dal.DeleteDynamic(whereCondidion);
		}
		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
		public int Update(PurchasePlanMonths t)
		{
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new PurchasePlanMonthDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.PlanID);
            }
            if (iError == 0)
            {
                foreach (PurchasePlanMonthDetail detail in t.ListPurchasePlanMonthDetail)
                {
                    detail.PlanID = t.PlanID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
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
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public PurchasePlanMonths GetByID(Guid planID )
		{
			           
            return dal.GetByID( planID);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
        //public int Delete(Guid planID )
        //{
			           
        //    return dal.Delete( planID);
        //}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(PurchasePlanMonths t)
		{
			           
            return dal.Delete(t);
		}

        public ListBase<PurchasePlanMonths> GetAllPlanMonths()
        {
            return dal.GetAllPlanMonths();
        }
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as PurchasePlanMonths);
        }

        public int Update(object obj)
        {
            return this.Update(obj as PurchasePlanMonths);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as PurchasePlanMonths);
        }

        #endregion

        public ListBase<PurchasePlanMonthDetail> GetFromPlanWeek(DateTime fromDate, DateTime toDate)
        {
            PurchasePlanMonthDetailDAL dalDt = new PurchasePlanMonthDetailDAL();
            return dalDt.GetFromPlanWeek(fromDate, toDate);
        }
	}
	#endregion
}

