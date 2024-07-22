

/************************************************************************
**	ClassName	: 	PurchasePlanMonthsDAL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-11-2008 10:42 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data
{
	#region PurchasePlanMonthsDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of PurchasePlanMonths.
	/// </summary>
	public class PurchasePlanMonthsDAL : BaseDAL<PurchasePlanMonths>
	{
		public PurchasePlanMonthsDAL()
		{
		}
		public PurchasePlanMonthsDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(PurchasePlanMonths t)
		{
			int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchasePlanMonths_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@PlanID",System.Data.DbType.Guid, 16, t.PlanID, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@YearNo",System.Data.DbType.Int32, 4, t.YearNo));
                cmd.Parameters.Add(db.CreateParameter("@MonthNo",System.Data.DbType.Int32, 4, t.MonthNo));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.PlanID = (Guid)cmd.Parameters["@PlanID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchasePlanMonthsDAL", "Insert(PurchasePlanMonths t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		/// <summary>
		/// Updates an existing object in database by calling Update StoredProcedure
		/// </summary>
		public override int Update(PurchasePlanMonths t)
		{
			int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchasePlanMonths_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PlanID",System.Data.DbType.Guid, 16, t.PlanID));
                cmd.Parameters.Add(db.CreateParameter("@YearNo",System.Data.DbType.Int32, 4, t.YearNo));
                cmd.Parameters.Add(db.CreateParameter("@MonthNo",System.Data.DbType.Int32, 4, t.MonthNo));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchasePlanMonthsDAL", "Update(PurchasePlanMonths t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>
        //public override int Delete(PurchasePlanMonths t)
        //{
			           
        //    return this.Delete( t.PlanID);
        //}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
        public override int Delete(PurchasePlanMonths t)
		{
			int iError = 0;
            bool alreadyOpen = false;			
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchasePlanMonths_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid , 16, t.PlanID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchasePlanMonthsDAL", "Delete(PurchasePlanMonths t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		
		/// <summary>
		/// Returns an object from database by calling Select StoredProcedure
		/// </summary>		
		public PurchasePlanMonths GetByID(Guid planID)
		{
            //int iError = 0;
            bool alreadyOpen = false;			
			PurchasePlanMonths obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchasePlanMonths_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid , 16, planID));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new PurchasePlanMonths(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("PurchasePlanMonthsDAL", "GetByID(Guid planID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
		}
        public ListBase<PurchasePlanMonths> GetAllPlanMonths()
        {
            DataSet ds = null;
            ListBase<PurchasePlanMonths> lstReturn = new ListBase<PurchasePlanMonths>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchasePlanMonths_GetAllPlanMonths";
                ds = db.ExecuteDataSet(cmd);

                DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["PlanID"], ds.Tables[1].Columns["PlanID"]);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PurchasePlanMonths pc = new PurchasePlanMonths();
                    pc.FromDataRow(dr);
                    foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                    {
                        PurchasePlanMonthDetail pcd = new PurchasePlanMonthDetail();
                        pcd.FromDataRow(dr1);
                        pc.ListPurchasePlanMonthDetail.Add(pcd);
                    }
                    lstReturn.Add(pc);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchasePlanMonthsDAL", "GetAllPlanMonths()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_PurchasePlanMonths_SelectAll";
			_spSelectDynamic = "usp_PurchasePlanMonths_SelectDynamic";
            _spDeleteAll = "usp_PurchasePlanMonths_DeleteAll";            
			_spDeleteDynamic = "usp_PurchasePlanMonths_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

