

/************************************************************************
**	ClassName	: 	TechnicalTestPriceDAL
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	19-02-2008 11:47 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.KCS
{
	#region TechnicalTestPriceDAL
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of TechnicalTestPrice.
	/// </summary>
	public class TechnicalTestPriceDAL : BaseDAL<TechnicalTestPrice>
	{
		public TechnicalTestPriceDAL()
		{
		}
		public TechnicalTestPriceDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(TechnicalTestPrice t)
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
                cmd.CommandText = "usp_TechnicalTestPrice_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@TechCode",System.Data.DbType.AnsiString, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@Price",System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated",System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated",System.Data.DbType.AnsiString, 20, t.UserUpdated));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //{
                //}
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("TechnicalTestPriceDAL", "Insert(TechnicalTestPrice t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        public override int Update(TechnicalTestPrice t)
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
                cmd.CommandText = "usp_TechnicalTestPrice_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.AnsiString, 10, t.TechCode));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                //cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //{
                //}
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("TechnicalTestPriceDAL", "Update(TechnicalTestPrice t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public override int Delete(TechnicalTestPrice t)
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
                cmd.CommandText = "usp_TechnicalTestPrice_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.AnsiString, 10, t.TechCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //{
                //}
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("TechnicalTestPriceDAL", "Delete(TechnicalTestPrice t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public ListBase<TechnicalTestPrice> GetBySubjectCode(string subjectCode)
        {
            DbDataReader reader = null;
            ListBase<TechnicalTestPrice> lstReturn = new ListBase<TechnicalTestPrice>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_TechnicalTestPrice_SelectBySubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    TechnicalTestPrice obj = new TechnicalTestPrice(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TechnicalTestPricesDAL", "GetBySubjectCode(string subjectCode)", excp.Message);
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
            _spSelectAll = "usp_TechnicalTestPrice_SelectAll";
			_spSelectDynamic = "usp_TechnicalTestPrice_SelectDynamic";
            _spDeleteAll = "usp_TechnicalTestPrice_DeleteAll";            
			_spDeleteDynamic = "usp_TechnicalTestPrice_DeleteDynamic";
        }

		#endregion
	}
	#endregion
}

