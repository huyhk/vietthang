using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;

namespace VNS.ERP.Data
{
    class PeriodDAL:StockBaseDAL<Period>
    {
           public PeriodDAL()
        {}
        public PeriodDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_Periods_Select_All";
            _spSelectDynamic = "usp_Periods_Select_Dynamic";
        }

        public Period  GetMin()
        {
            bool alreadyOpen = false;
            Period obj = new Period();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Period_Select_Min";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32,4,0,System.Data.ParameterDirection.Output));
                reader = db.ExecuteReader(cmd);
                if (reader.Read()) obj.FromDataReader(reader);
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PeriodDAL", "GetMin()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
        public int ClosePeriod(string periodCode, string moduleCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Period_Close";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                Cmd.Parameters.Add(db.CreateParameter("@ModuleCode", System.Data.DbType.String, 20, moduleCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PeriodDAL", "ClosePeriod(string periodCode, string moduleCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int CheckDataBeforeClosePeriod(ref DateTime dateDataError, ref string transactionNoDataError, string periodCode, string moduleCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Check_Data_Before_ClosePeriod";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                Cmd.Parameters.Add(db.CreateParameter("@ModuleCode", System.Data.DbType.String, 20, moduleCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@DateDataError", System.Data.DbType.DateTime, 4, dateDataError, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionNoDataError", System.Data.DbType.String, 20, transactionNoDataError, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError != 0)
                {
                    dateDataError = (DateTime)Cmd.Parameters["@DateDataError"].Value;
                    transactionNoDataError = (String)Cmd.Parameters["@TransactionNoDataError"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PeriodDAL", "CheckDataBeforeClosePeriod(ref DateTime dateDataError, ref string transactionNoDataError)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int CheckDataBeforeClosePeriod(ref DateTime dateDataError, ref string transactionNoDataError, DateTime startDate, DateTime endDate, string moduleCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Check_Data_Before_ClosePeriod_ForDate";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                Cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                Cmd.Parameters.Add(db.CreateParameter("@ModuleCode", System.Data.DbType.String, 20, moduleCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@DateDataError", System.Data.DbType.DateTime, 4, dateDataError, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionNoDataError", System.Data.DbType.String, 20, transactionNoDataError, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError != 0)
                {
                    dateDataError = (DateTime)Cmd.Parameters["@DateDataError"].Value;
                    transactionNoDataError = (String)Cmd.Parameters["@TransactionNoDataError"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PeriodDAL", "CheckDataBeforeClosePeriod(ref DateTime dateDataError, ref string transactionNoDataError)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int OpenPeriod(string startPeriodCodeOpen, string moduleCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Period_Open";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, startPeriodCodeOpen));
                Cmd.Parameters.Add(db.CreateParameter("@ModuleCode", System.Data.DbType.String, 20, moduleCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PeriodDAL", "ClosePeriod(string periodCode, string moduleCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public ListBase<Period> GetTest()
        {
            bool alreadyOpen = false;
            ListBase<Period> lobj = new ListBase<Period>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Period_Select_Min";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    Period obj = new Period(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PeriodDAL", " GetTest()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        /// <summary>
        /// select list periods IsClosed false
        /// </summary>
        /// <returns></returns>
        public ListBase<Period> SelectIsClosedFalse(string moduleCode)
        {
            bool alreadyOpen = false;
            ListBase<Period> lobj = new ListBase<Period>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Period_Select_IsClose_False";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ModuleCode", System.Data.DbType.String, 20, moduleCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lobj.Add(new Period(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PeriodDAL", "SelectIsClosedFalse(string moduleCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        /// <summary>
        /// select list periods IsClosed false
        /// </summary>
        /// <returns></returns>
        public ListBase<Period> SelectIsClosedTrue(string moduleCode)
        {
            bool alreadyOpen = false;
            ListBase<Period> lobj = new ListBase<Period>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Period_Select_IsClose_True";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ModuleCode", System.Data.DbType.String, 20, moduleCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lobj.Add(new Period(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PeriodDAL", "SelectIsClosedFalse(string moduleCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        /// <summary>
        /// Select object by DateTime 
        /// </summary>
        /// <param name="ngay"></param>
        /// <returns></returns>
        public Period SelectObjectSpecify(DateTime ngay)
        {
            bool alreadyOpen = false;
            Period obj=null ;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Periods_Specify";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ngay", System.Data.DbType.DateTime, 4, ngay));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new Period(reader);
                }
               reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PeriodDAL", "SelectObjectSpecify(DateTime ngay)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
        /// <summary>
        /// Select object by DateTime 
        /// </summary>
        /// <param name="ngay"></param>
        /// <returns></returns>
        public Period SelectObjectLastMonthSpecify(DateTime endDate)
        {
            bool alreadyOpen = false;
            Period obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Period_Select_PeriodCodeNext";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new Period(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PeriodDAL", "SelectObjectLastMonthSpecify(DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
        /// <summary>
        /// Select object by DateTime 
        /// </summary>
        /// <param name="ngay"></param>
        /// <returns></returns>
        public Period GetByDate(DateTime ngay)
        {
            bool alreadyOpen = false;
            Period obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Period_SelectByDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@Date", System.Data.DbType.DateTime, 4, ngay));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new Period(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PeriodDAL", "GetByDate(DateTime ngay)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        public DateTime GetFromObjectModuleLocksByID(string moduleCode)
        {
            bool alreadyOpen = false;
            DateTime dateReturn=Contexts.WorkingDate;
            try
            {
             
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ModuleLocks_Select_ByID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ModuleCode", System.Data.DbType.String, 20, moduleCode));
                dateReturn = (DateTime)db.ExecuteScalar(cmd);
               
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PeriodDAL", "GetFromObjectModuleLocksByID(string moduleCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dateReturn;
        }
        public int UpdateObjectModuleLocks(string moduleCode,DateTime day)
        {
            bool alreadyOpen = false;
            int iError = 0;
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ModuleLocks_UpdateDateLock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ModuleCode", System.Data.DbType.String, 20, moduleCode));
                cmd.Parameters.Add(db.CreateParameter("@DateLock", System.Data.DbType.DateTime, 4, day));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("PeriodDAL", "UpdateObjectModuleLocks(string moduleCode,DateTime day)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
    }
}
