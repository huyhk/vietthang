
/************************************************************************
**	ClassName	: 	PurchasePlanBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	23-07-2009 02:47 PM
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
	#region PurchasePlanBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of PurchasePlan.
	/// </summary>
	public class PurchasePlanBLL : IBusiness
	{
		private PurchasePlanDAL dal = new PurchasePlanDAL();
		public PurchasePlanBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< PurchasePlan >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< PurchasePlan >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(PurchasePlan t)
		{
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            //dalDetail = new PurchasePlanDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (PurchasePlanDetail detail in t.ListPurchasePlanDetail)
                {
                    detail.PlanID = t.PlanID;
                    if (iError == 0)
                    {
                        iError = dal.InsertDetail(detail);
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
		public int Update(PurchasePlan t)
		{
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            //dalDetail = new PurchasePlanDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal.DeleteDetail(t.PlanID);
            }
            if (iError == 0)
            {
                foreach (PurchasePlanDetail detail in t.ListPurchasePlanDetail)
                {
                    detail.PlanID = t.PlanID;
                    if (iError == 0)
                    {
                        iError = dal.InsertDetail(detail);
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
		public PurchasePlan GetByID(Guid planID )
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
		public int Delete(PurchasePlan t)
		{
			           
            return dal.Delete( t.PlanID);
		}

        public ListBase<PurchasePlan> GetAllPlanMonths()
        {
            return dal.GetAllPlanMonths();
        }
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as PurchasePlan);
        }

        public int Update(object obj)
        {
            return this.Update(obj as PurchasePlan);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as PurchasePlan);
        }

        #endregion
		
	}
	#endregion
}

