
/************************************************************************
**	ClassName	: 	PurchasePlanWeekBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	09-12-2008 04:05 PM
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
	#region PurchasePlanWeekBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of PurchasePlanWeek.
	/// </summary>
	public class PurchasePlanWeekBLL : IBusiness
	{
		private PurchasePlanWeekDAL dal = new PurchasePlanWeekDAL();		
		public PurchasePlanWeekBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< PurchasePlanWeek >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< PurchasePlanWeek >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(PurchasePlanWeek t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (PurchasePlanWeekDetail detail in t.ListPurchasePlanWeekDetail)
                {
                    detail.PlanID = t.PlanID;
                    iError = dal.InsertDetail(detail);
                    if (iError != 0)
                        break;
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
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
		public int Update(PurchasePlanWeek t)
		{
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal.DeleteDetail(t.PlanID);
                if (iError == 0)
                {
                    foreach (PurchasePlanWeekDetail detail in t.ListPurchasePlanWeekDetail)
                    {
                        detail.PlanID = t.PlanID;
                        iError = dal.InsertDetail(detail);
                        if (iError != 0)
                            break;
                    }
                }
            }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public PurchasePlanWeek GetByID(Guid planID )
		{
			           
            return dal.GetByID( planID);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(Guid planID )
		{
			           
            return dal.Delete( planID);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(PurchasePlanWeek t)
		{
			           
            return dal.Delete( t.PlanID);
		}

        public ListBase<PurchasePlanWeek> GetAllPlanWeeks(int yearNo)
        {
            return dal.GetAllPlanWeeks(yearNo);
        }
		#endregion
        public DataSet ReportPurchasePlanWeek(int yearNo, int weekNo)
        {
            return dal.ReportPurchasePlanWeek(yearNo, weekNo);
        }
        public DataSet ReportPurchasePlanWeekDate(int yearNo, int weekNo, DateTime fromDate, DateTime toDate)
        { return dal.ReportPurchasePlanWeekDate(yearNo, weekNo, fromDate, toDate); }
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as PurchasePlanWeek);
        }

        public int Update(object obj)
        {
            return this.Update(obj as PurchasePlanWeek);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as PurchasePlanWeek);
        }

        #endregion
		
	}
	#endregion
}

