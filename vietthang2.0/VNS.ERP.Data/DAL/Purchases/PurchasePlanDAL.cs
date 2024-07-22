

/************************************************************************
**	ClassName	: 	PurchasePlanDAL
**	Author		:	Ai tang
**	Company		:	VNS
**	Date		:	23-07-2009 02:46 PM
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
	#region PurchasePlanDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of PurchasePlan.
	/// </summary>
	public class PurchasePlanDAL : BaseDAL<PurchasePlan>
	{
		public PurchasePlanDAL()
		{
		}
		public PurchasePlanDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(PurchasePlan t)
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
                cmd.CommandText = "usp_PurchasePlan_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid, 16, t.PlanID, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@YearNo",System.Data.DbType.Int32, 4, t.YearNo));
                cmd.Parameters.Add(db.CreateParameter("@MonthNo",System.Data.DbType.Int32, 4, t.MonthNo));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.String, 20, t.UserCreated));
			
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
                Write2Log.WriteLogs("PurchasePlanDAL", "Insert(PurchasePlan t)", excp.Message);
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
		public override int Update(PurchasePlan t)
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
                cmd.CommandText = "usp_PurchasePlan_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PlanID",System.Data.DbType.Guid, 16, t.PlanID));
                cmd.Parameters.Add(db.CreateParameter("@YearNo",System.Data.DbType.Int32, 4, t.YearNo));
                cmd.Parameters.Add(db.CreateParameter("@MonthNo",System.Data.DbType.Int32, 4, t.MonthNo));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.String, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	            iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchasePlanDAL", "Update(PurchasePlan t)", excp.Message);
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
		public override int Delete(PurchasePlan t)
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
                cmd.CommandText = "usp_PurchasePlan_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid , 16, planID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchasePlanDAL", "Delete(PurchasePlan t)", excp.Message);
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
		public PurchasePlan GetByID(Guid planID)
		{
			int iError = 0;
            bool alreadyOpen = false;			
			PurchasePlan obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchasePlan_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid , 16, planID));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new PurchasePlan(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("PurchasePlanDAL", "GetByID(Guid planID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
		}
        public ListBase<PurchasePlan> GetAllPlanMonths()
        {
            DataSet ds = null;
            ListBase<PurchasePlan> lstReturn = new ListBase<PurchasePlan>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_PurchasePlan_GetAllPlanMonths";
                ds = db.ExecuteDataSet(cmd);

                DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["PlanID"], ds.Tables[1].Columns["PlanID"]);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    PurchasePlan pc = new PurchasePlan();
                    pc.FromDataRow(dr);
                    foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                    {
                        PurchasePlanDetail pcd = new PurchasePlanDetail();
                        pcd.FromDataRow(dr1);
                        pc.ListPurchasePlanDetail.Add(pcd);
                    }
                    lstReturn.Add(pc);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchasePlanDAL", "GetAllPlanMonths()", excp.Message);
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
            _spSelectAll = "usp_PurchasePlan_SelectAll";
			_spSelectDynamic = "usp_PurchasePlan_SelectDynamic";
            _spDeleteAll = "usp_PurchasePlan_DeleteAll";            
			_spDeleteDynamic = "usp_PurchasePlan_DeleteDynamic";
        }

		#endregion

        public int InsertDetail(PurchasePlanDetail t)
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
                cmd.CommandText = "usp_PurchasePlanDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid, 16, t.PlanID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchasePlanMonthDetailDAL", "Insert(PurchasePlanMonthDetail t)", excp.Message);
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
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchasePlanDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid, 16, planID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PurchasePlanMonthDetailDAL", "Delete(PurchasePlanMonthDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
	}
	#endregion
}

