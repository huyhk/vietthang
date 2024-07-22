

/************************************************************************
**	ClassName	: 	PurchasePlanMonthDetailDAL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-11-2008 10:43 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data
{
	#region PurchasePlanMonthDetailDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of PurchasePlanMonthDetail.
	/// </summary>
	public class PurchasePlanMonthDetailDAL : BaseDAL<PurchasePlanMonthDetail>
	{
		public PurchasePlanMonthDetailDAL()
		{
		}
		public PurchasePlanMonthDetailDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(PurchasePlanMonthDetail t)
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
                cmd.CommandText = "usp_PurchasePlanMonthDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@PlanID",System.Data.DbType.Guid, 16, t.PlanID));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode",System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode",System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity",System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.AnsiString, 20, t.ContractNo));

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
		public override int Update(PurchasePlanMonthDetail t)
		{
			return 0;
			}
        public override int Delete(PurchasePlanMonthDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchasePlanMonthDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PlanID", System.Data.DbType.Guid, 16, t.PlanID));
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
        public int Delete(Guid planID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_PurchasePlanMonthDetail_Delete";
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
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_PurchasePlanMonthDetail_SelectAll";
			_spSelectDynamic = "usp_PurchasePlanMonthDetail_SelectDynamic";
            _spDeleteAll = "usp_PurchasePlanMonthDetail_DeleteAll";            
			_spDeleteDynamic = "usp_PurchasePlanMonthDetail_DeleteDynamic";
        }

		#endregion

        public ListBase<PurchasePlanMonthDetail> GetFromPlanWeek(DateTime fromDate, DateTime toDate)
        {
            bool alreadyOpen = false;
            ListBase<PurchasePlanMonthDetail> lstReturn = new ListBase<PurchasePlanMonthDetail>();
            DbDataReader reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchasePlanMonthDetail_GetFromPlanWeek";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    PurchasePlanMonthDetail pay = new PurchasePlanMonthDetail(reader);
                    lstReturn.Add(pay);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchasePlanMonthDetailDAL", "GetFromPlanWeek(DateTime fromDate, DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
	}
	#endregion
}

