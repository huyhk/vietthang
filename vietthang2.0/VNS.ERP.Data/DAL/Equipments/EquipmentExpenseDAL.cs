

/************************************************************************
**	ClassName	: 	EquipmentExpensDAL
**	Author		:	cohim2000
**	Company		:	VNS
**	Date		:	02-08-2008 05:36 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;

namespace  VNS.ERP.Data.Equipments
{
	#region EquipmentExpensDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of EquipmentExpens.
	/// </summary>
    public class EquipmentExpensDAL : BaseDAL<EquipmentExpense>
	{
		public EquipmentExpensDAL()
		{
		}
		public EquipmentExpensDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public override int Insert(EquipmentExpense t)
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
                cmd.CommandText = "usp_EquipmentExpenses_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@ExpenseID",System.Data.DbType.Guid, 16, t.ExpenseID,System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@ExpenseNo",System.Data.DbType.AnsiString, 20, t.ExpenseNo));
                cmd.Parameters.Add(db.CreateParameter("@ExpenseDate",System.Data.DbType.DateTime, 8, t.ExpenseDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode",System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Amount",System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {

                    t.ExpenseID = (Guid)cmd.Parameters["@ExpenseID"].Value;

                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentExpensDAL", "Insert(EquipmentExpens t)", excp.Message);
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
        public override int Update(EquipmentExpense t)
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
                cmd.CommandText = "usp_EquipmentExpenses_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

               cmd.Parameters.Add(db.CreateParameter("@ExpenseID",System.Data.DbType.Guid, 16, t.ExpenseID));
                cmd.Parameters.Add(db.CreateParameter("@ExpenseNo",System.Data.DbType.AnsiString, 20, t.ExpenseNo));
                cmd.Parameters.Add(db.CreateParameter("@ExpenseDate",System.Data.DbType.DateTime, 8, t.ExpenseDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode",System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Amount",System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));
          
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
	                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentExpensDAL", "Update(EquipmentExpens t)", excp.Message);
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
        public override int Delete(EquipmentExpense t)
		{
			           
            return this.Delete( t.ExpenseID);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>
        /// 
        public ListBase<EquipmentExpense> GetByDateAndStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            ListBase<EquipmentExpense> lstReturn = new ListBase<EquipmentExpense>();
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_EquipmentExpense_SelectByStockandPeriod";
                
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new EquipmentExpense(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EquipmentExpensDAL", "GetByDateAndStockCode(DateTime startDate, DateTime endDate, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;

            //DataSet ds = null;
            //DataTable lstReturn = null;
            //bool alreadyOpen = false;
            //try
            //{
            //    if (db.State != System.Data.ConnectionState.Open) db.Open();
            //    else alreadyOpen = true;
            //    DbCommand cmd = db.CreateCommand();
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.CommandText = "usp_EquipmentExpense_SelectByStockandPeriod";
            //    cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
            //    cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
            //    cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 20, stockCode));

            //    ds = db.ExecuteDataSet(cmd);
            //    lstReturn = this.GetFromDataSet(ds);
            //}
            //catch (Exception excp)
            //{
            //    Write2Log.WriteLogs("EquipmentExpensDAL", "GetByDateAndStockCode(DateTime startDate, DateTime endDate, string stockCode)", excp.Message);
            //}
            //finally
            //{
            //    if (!alreadyOpen) db.Close();
            //}
            //return lstReturn;
        }

        private ListBase<EquipmentExpense> GetFromDataSet(DataSet ds)
        {
            throw new Exception("The method or operation is not implemented.");
        }
		public int Delete(Guid expenseID)
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
                cmd.CommandText = "usp_EquipmentExpens_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@ExpenseID", System.Data.DbType.Guid , 16, expenseID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
				//if (iError == 0)
                	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("EquipmentExpensDAL", "Delete(EquipmentExpens t)", excp.Message);
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
        public EquipmentExpense GetByID(Guid expenseID)
		{
            //int iError = 0;
            bool alreadyOpen = false;
            EquipmentExpense obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_EquipmentExpens_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@ExpenseID", System.Data.DbType.Guid , 16, expenseID));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                    obj = new EquipmentExpense(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("EquipmentExpensDAL", "GetByID(Guid expenseID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
		}
		
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_EquipmentExpens_SelectAll";
            //_spSelectDynamic = "usp_EquipmentExpens_SelectDynamic";
            //_spDeleteAll = "usp_EquipmentExpens_DeleteAll";            
            //_spDeleteDynamic = "usp_EquipmentExpens_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

