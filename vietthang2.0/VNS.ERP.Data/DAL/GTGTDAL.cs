using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;

namespace VNS.ERP.Data.DAL
{
    public class GTGTDAL : BaseDAL<GTGT>
    {
        public GTGTDAL()
        { }
       public GTGTDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }

        public GTGT GetObjectByMonth(DateTime startDate,DateTime endDate)
        {
            GTGT ObjReturn=new GTGT();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GTGT_SelectByMonth";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@GT11", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT14", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT15", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT16", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT17", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT26", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT29", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT30", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT31", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT32", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT33", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                ObjReturn.GT10 = false;
                ObjReturn.GT11 = (decimal)cmd.Parameters["@GT11"].Value;
                ObjReturn.GT14 = (decimal)cmd.Parameters["@GT14"].Value;
                ObjReturn.GT15 = (decimal)cmd.Parameters["@GT15"].Value;
                ObjReturn.GT16 = (decimal)cmd.Parameters["@GT16"].Value;
                ObjReturn.GT17 = (decimal)cmd.Parameters["@GT17"].Value;
                ObjReturn.GT26 = (decimal)cmd.Parameters["@GT26"].Value;
                ObjReturn.GT29 = (decimal)cmd.Parameters["@GT29"].Value;
                ObjReturn.GT30 = (decimal)cmd.Parameters["@GT30"].Value;
                ObjReturn.GT31 = (decimal)cmd.Parameters["@GT31"].Value;
                ObjReturn.GT32 = (decimal)cmd.Parameters["@GT32"].Value;
                ObjReturn.GT33 = (decimal)cmd.Parameters["@GT33"].Value;

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("GTGTDAL", " GetObjectByMonth(DateTime startDate,DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return ObjReturn;
        }
        public GTGT GetObjectByPeriodCode(string periodCode)
        {
            GTGT ObjReturn = new GTGT();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GTGT_SelectByPeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@GT10", System.Data.DbType.Boolean, 1, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT11", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT14", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT15", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT16", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT17", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT26", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT29", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT30", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT31", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT32", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT33", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@GT18", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT19", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT20", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT21", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT23", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT34", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT35", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT36", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT37", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@GT42", System.Data.DbType.Decimal, 9, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                ObjReturn.GT10 = (bool)cmd.Parameters["@GT10"].Value;
                ObjReturn.GT11 = (decimal)cmd.Parameters["@GT11"].Value;
                ObjReturn.GT14 = (decimal)cmd.Parameters["@GT14"].Value;
                ObjReturn.GT15 = (decimal)cmd.Parameters["@GT15"].Value;
                ObjReturn.GT16 = (decimal)cmd.Parameters["@GT16"].Value;
                ObjReturn.GT17 = (decimal)cmd.Parameters["@GT17"].Value;
                ObjReturn.GT26 = (decimal)cmd.Parameters["@GT26"].Value;
                ObjReturn.GT29 = (decimal)cmd.Parameters["@GT29"].Value;
                ObjReturn.GT30 = (decimal)cmd.Parameters["@GT30"].Value;
                ObjReturn.GT31 = (decimal)cmd.Parameters["@GT31"].Value;
                ObjReturn.GT32 = (decimal)cmd.Parameters["@GT32"].Value;
                ObjReturn.GT33 = (decimal)cmd.Parameters["@GT33"].Value;

                ObjReturn.GT18 = (decimal)cmd.Parameters["@GT18"].Value;
                ObjReturn.GT19 = (decimal)cmd.Parameters["@GT19"].Value;
                ObjReturn.GT20 = (decimal)cmd.Parameters["@GT20"].Value;
                ObjReturn.GT21 = (decimal)cmd.Parameters["@GT21"].Value;
                ObjReturn.GT23 = (decimal)cmd.Parameters["@GT23"].Value;
                ObjReturn.GT34 = (decimal)cmd.Parameters["@GT34"].Value;
                ObjReturn.GT35 = (decimal)cmd.Parameters["@GT35"].Value;
                ObjReturn.GT36 = (decimal)cmd.Parameters["@GT36"].Value;
                ObjReturn.GT37 = (decimal)cmd.Parameters["@GT37"].Value;
                ObjReturn.GT42 = (decimal)cmd.Parameters["@GT42"].Value;

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("GTGTDAL", "GetObjectByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return ObjReturn;
        }
        public override int Insert(GTGT t)
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
                cmd.CommandText = "usp_GTGTs_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@GT10", System.Data.DbType.Boolean, 1, t.GT10));
                cmd.Parameters.Add(db.CreateParameter("@GT11", System.Data.DbType.Decimal, 9,t.GT11));
                cmd.Parameters.Add(db.CreateParameter("@GT14", System.Data.DbType.Decimal, 9, t.GT14));
                cmd.Parameters.Add(db.CreateParameter("@GT15", System.Data.DbType.Decimal, 9, t.GT15));
                cmd.Parameters.Add(db.CreateParameter("@GT16", System.Data.DbType.Decimal, 9,t.GT16));
                cmd.Parameters.Add(db.CreateParameter("@GT17", System.Data.DbType.Decimal, 9,t.GT17));
                cmd.Parameters.Add(db.CreateParameter("@GT26", System.Data.DbType.Decimal, 9, t.GT26));
                cmd.Parameters.Add(db.CreateParameter("@GT29", System.Data.DbType.Decimal, 9,t.GT29));
                cmd.Parameters.Add(db.CreateParameter("@GT30", System.Data.DbType.Decimal, 9, t.GT30));
                cmd.Parameters.Add(db.CreateParameter("@GT31", System.Data.DbType.Decimal, 9,t.GT31));
                cmd.Parameters.Add(db.CreateParameter("@GT32", System.Data.DbType.Decimal, 9,t.GT32));
                cmd.Parameters.Add(db.CreateParameter("@GT33", System.Data.DbType.Decimal, 9, t.GT33));
                cmd.Parameters.Add(db.CreateParameter("@GT43", System.Data.DbType.Decimal, 9, t.GT43));

                cmd.Parameters.Add(db.CreateParameter("@GT18", System.Data.DbType.Decimal, 9, t.GT18));
                cmd.Parameters.Add(db.CreateParameter("@GT19", System.Data.DbType.Decimal, 9, t.GT19));
                cmd.Parameters.Add(db.CreateParameter("@GT20", System.Data.DbType.Decimal, 9, t.GT20));
                cmd.Parameters.Add(db.CreateParameter("@GT21", System.Data.DbType.Decimal, 9, t.GT21));
                cmd.Parameters.Add(db.CreateParameter("@GT23", System.Data.DbType.Decimal, 9, t.GT23));
                cmd.Parameters.Add(db.CreateParameter("@GT34", System.Data.DbType.Decimal, 9, t.GT34));
                cmd.Parameters.Add(db.CreateParameter("@GT35", System.Data.DbType.Decimal, 9, t.GT35));
                cmd.Parameters.Add(db.CreateParameter("@GT36", System.Data.DbType.Decimal, 9, t.GT36));
                cmd.Parameters.Add(db.CreateParameter("@GT37", System.Data.DbType.Decimal, 9, t.GT37));
                cmd.Parameters.Add(db.CreateParameter("@GT42", System.Data.DbType.Decimal, 9, t.GT42));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GTGTDAL", "Insert(GTGT t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public override int Delete(GTGT t)
        {
            return Delete(t.PeriodCode);
        }
        public int Delete(string periodCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GTGTs_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GTGTDAL", "Delete(string periodCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(GTGT t)
        {
            return base.Update(t);
        }
    }
}