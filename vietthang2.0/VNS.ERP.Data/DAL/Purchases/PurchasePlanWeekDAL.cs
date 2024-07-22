

/************************************************************************
**	ClassName	: 	PurchasePlanWeekDAL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	09-12-2008 04:04 PM
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
	#region PurchasePlanWeekDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of PurchasePlanWeek.
	/// </summary>
	public class PurchasePlanWeekDAL : BaseDAL<PurchasePlanWeek>
	{
		public PurchasePlanWeekDAL()
		{
		}
		public PurchasePlanWeekDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(PurchasePlanWeek t)
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
                cmd.CommandText = "usp_PurchasePlanWeek_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@PlanID",System.Data.DbType.Guid, 16, t.PlanID, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@YearNo",System.Data.DbType.Int32, 4, t.YearNo));
                cmd.Parameters.Add(db.CreateParameter("@WeekNo",System.Data.DbType.Int32, 4, t.WeekNo));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                if (iError == 0)
	                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.PlanID = (Guid)cmd.Parameters["@PlanID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("PurchasePlanWeekDAL", "Insert(PurchasePlanWeek t)", excp.Message);
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
		public override int Update(PurchasePlanWeek t)
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
                cmd.CommandText = "usp_PurchasePlanWeek_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PlanID",System.Data.DbType.Guid, 16, t.PlanID));
                cmd.Parameters.Add(db.CreateParameter("@YearNo",System.Data.DbType.Int32, 4, t.YearNo));
                cmd.Parameters.Add(db.CreateParameter("@WeekNo",System.Data.DbType.Int32, 4, t.WeekNo));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				if (iError == 0)
	                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("PurchasePlanWeekDAL", "Update(PurchasePlanWeek t)", excp.Message);
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
		public override int Delete(PurchasePlanWeek t)
		{
			           
            return this.Delete( t.PlanID);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(Guid planID)
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
                cmd.CommandText = "usp_PurchasePlanWeek_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid , 16, planID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("PurchasePlanWeekDAL", "Delete(PurchasePlanWeek t)", excp.Message);
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
		public PurchasePlanWeek GetByID(Guid planID)
		{
            //int iError = 0;
            bool alreadyOpen = false;			
			PurchasePlanWeek obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchasePlanWeek_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid , 16, planID));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new PurchasePlanWeek(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("PurchasePlanWeekDAL", "GetByID(Guid planID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
		}
        public ListBase<PurchasePlanWeek> GetAllPlanWeeks(int yearNo)
        {
            DataSet ds = null;
            ListBase<PurchasePlanWeek> lstReturn = new ListBase<PurchasePlanWeek>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchasePlanWeeks_GetAllPlanWeeks";
                cmd.Parameters.Add(db.CreateParameter("@YearNo", System.Data.DbType.Int32, 4, yearNo));
                ds = db.ExecuteDataSet(cmd);

                DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["PlanID"], ds.Tables[1].Columns["PlanID"]);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PurchasePlanWeek pc = new PurchasePlanWeek();
                    pc.FromDataRow(dr);
                    foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                    {
                        PurchasePlanWeekDetail pcd = new PurchasePlanWeekDetail();
                        pcd.FromDataRow(dr1);
                        pc.ListPurchasePlanWeekDetail.Add(pcd);
                    }
                    lstReturn.Add(pc);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchasePlanWeeksDAL", "GetAllPlanWeeks()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        /// <summary>
        /// Get Detail of PurchasePlanWeek that PurchasePlanWeek have YearNo = yearNo and WeekNo = weekNo
        /// </summary>
        /// <param name="yearNo"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public DataSet ReportPurchasePlanWeek(int yearNo, int weekNo)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchasePlanWeekDetail_SelectByWeek";
                cmd.Parameters.Add(db.CreateParameter("@YearNo", System.Data.DbType.Int32, 4, yearNo));
                cmd.Parameters.Add(db.CreateParameter("@WeekNo", System.Data.DbType.Int32, 4, weekNo));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchasePlanWeeksDAL", "ReportPurchasePlanWeek()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        public DataSet ReportPurchasePlanWeekDate(int yearNo, int weekNo, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchasePlanWeekDetail_SelectByWeekDate";
                cmd.Parameters.Add(db.CreateParameter("@YearNo", System.Data.DbType.Int32, 4, yearNo));
                cmd.Parameters.Add(db.CreateParameter("@WeekNo", System.Data.DbType.Int32, 4, weekNo));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchasePlanWeeksDAL", "ReportPurchasePlanWeekDate()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_PurchasePlanWeek_SelectAll";
			_spSelectDynamic = "usp_PurchasePlanWeek_SelectDynamic";
            _spDeleteAll = "usp_PurchasePlanWeek_DeleteAll";            
			_spDeleteDynamic = "usp_PurchasePlanWeek_DeleteDynamic";
        }

		#endregion
        #region PurchasePlanWeekDetailDAL
        public int InsertDetail(PurchasePlanWeekDetail t)
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
                cmd.CommandText = "usp_PurchasePlanWeekDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid, 16, t.PlanID));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.AnsiString, 20, t.ContractNo));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Day1", System.Data.DbType.Decimal, 9, t.Day1));
                cmd.Parameters.Add(db.CreateParameter("@Day2", System.Data.DbType.Decimal, 9, t.Day2));
                cmd.Parameters.Add(db.CreateParameter("@Day3", System.Data.DbType.Decimal, 9, t.Day3));
                cmd.Parameters.Add(db.CreateParameter("@Day4", System.Data.DbType.Decimal, 9, t.Day4));
                cmd.Parameters.Add(db.CreateParameter("@Day5", System.Data.DbType.Decimal, 9, t.Day5));
                cmd.Parameters.Add(db.CreateParameter("@Day6", System.Data.DbType.Decimal, 9, t.Day6));
                cmd.Parameters.Add(db.CreateParameter("@Day7", System.Data.DbType.Decimal, 9, t.Day7));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("PurchasePlanWeekDetailDAL", "Insert(PurchasePlanWeekDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int DeleteDetail(Guid planID)
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
                cmd.CommandText = "usp_PurchasePlanWeekDetail_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid, 16, planID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("PurchasePlanWeekDetailDAL", "Delete(PurchasePlanWeekDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion
    }
	#endregion
}

