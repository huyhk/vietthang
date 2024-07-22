

/************************************************************************
**	ClassName	: 	VattuOldOpeningDAL
**	Author		:	cohim2000
**	Company		:	VNS
**	Date		:	10-07-2008 02:42 PM
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
	#region VattuOldOpeningDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of VattuOldOpening.
	/// </summary>
	public class VattuOldOpeningDAL : BaseDAL<VattuOldOpening>
	{
		public VattuOldOpeningDAL()
		{
		}
		public VattuOldOpeningDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(VattuOldOpening t)
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
                cmd.CommandText = "usp_VattuOldOpening_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode",System.Data.DbType.AnsiString, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode",System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@VattuCode",System.Data.DbType.AnsiString, 20, t.VattuCode));
                cmd.Parameters.Add(db.CreateParameter("@VattuOldType",System.Data.DbType.AnsiString, 10, t.VattuOldType));
                cmd.Parameters.Add(db.CreateParameter("@Quantity",System.Data.DbType.Int32, 4, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 4, t.Amount));
                //cmd.Parameters.Add(db.CreateParameter("@ServerCreated",System.Data.DbType.AnsiString, 20, t.ServerCreated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				if (iError != 0)
	                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuOldOpeningDAL", "Insert(VattuOldOpening t)", excp.Message);
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
		public override int Update(VattuOldOpening t)
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
                cmd.CommandText = "usp_VattuOldOpening_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode",System.Data.DbType.AnsiString, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode",System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@VattuCode",System.Data.DbType.AnsiString, 10, t.VattuCode));
                cmd.Parameters.Add(db.CreateParameter("@VattuOldType",System.Data.DbType.AnsiString, 10, t.VattuOldType));
                cmd.Parameters.Add(db.CreateParameter("@Quantity",System.Data.DbType.Int32, 4, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 4, t.Amount));
                
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
				iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuOldOpeningDAL", "Update(VattuOldOpening t)", excp.Message);
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
		public override int Delete(VattuOldOpening t)
		{
			           
            return this.Delete( t.PeriodCode, t.StockCode, t.VattuCode, t.VattuOldType);
		}
		
		/// <summary>
		/// Deletes an object from database by calling Delete StoredProcedure
		/// </summary>		
		public int Delete(string periodCode,string stockCode,string vattuCode,string vattuOldType)
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
                cmd.CommandText = "usp_VattuOldOpening_DeleteByPeriodStock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.AnsiString , 10, periodCode));
				cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString , 10, stockCode));
				cmd.Parameters.Add(db.CreateParameter("@VattuCode", System.Data.DbType.AnsiString , 10, vattuCode));
				cmd.Parameters.Add(db.CreateParameter("@VattuOldType", System.Data.DbType.AnsiString , 10, vattuOldType));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
					iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuOldOpeningDAL", "Delete(VattuOldOpening t)", excp.Message);
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
		public VattuOldOpening GetByID(string periodCode,string stockCode,string vattuCode,string vattuOldType)
		{
            //int iError = 0;
            bool alreadyOpen = false;			
			VattuOldOpening obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_VattuOldOpening_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.AnsiString , 10, periodCode));
				cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString , 10, stockCode));
				cmd.Parameters.Add(db.CreateParameter("@VattuCode", System.Data.DbType.AnsiString , 10, vattuCode));
				cmd.Parameters.Add(db.CreateParameter("@VattuOldType", System.Data.DbType.AnsiString , 10, vattuOldType));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
				if (reader.Read())
                	obj = new VattuOldOpening(reader);
            }
            catch (Exception excp)
            {                
                Write2Log.WriteLogs("VattuOldOpeningDAL", "GetByID(string periodCode,string stockCode,string vattuCode,string vattuOldType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
		}
        public int DeleteByPeriodAndStock(string periodCode, string stockCode)
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
                cmd.CommandText = "usp_VattuOldOpening_DeleteByPeriodStock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.AnsiString, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, stockCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                
                    iError = (int)cmd.Parameters["@iError"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuOldOpeningDAL", "Insert(VattuOldOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<VattuOldOpening> GetByPeriodAndStock(string periodCode, string stockCode)
        {
            bool alreadyOpen = false;
            ListBase<VattuOldOpening> lobj = new ListBase<VattuOldOpening>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_VattuOldOpening_SelectByPeriodAndStock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lobj.Add(new VattuOldOpening(reader));
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VattuOldOpeningDAL", "GetByPeriodAndStock(string periodCode, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
		#endregion
		#region private methods
		
        protected override void SetValues()
        {
            _spSelectAll = "usp_VattuOldOpening_SelectAll";
			_spSelectDynamic = "usp_VattuOldOpening_SelectDynamic";
            _spDeleteAll = "usp_VattuOldOpening_DeleteAll";            
			_spDeleteDynamic = "usp_VattuOldOpening_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

