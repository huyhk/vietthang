using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanWeekDetailDAL : BaseDAL<ManufacturePlanWeekDetail>
    {
        public ManufacturePlanWeekDetailDAL() { }
        public ManufacturePlanWeekDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ManufacturePlanWeekDetail_Select_All";
        }
        public override int Insert(ManufacturePlanWeekDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanWeekDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, t.ManufacturePlanWeekID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                Cmd.Parameters.Add(db.CreateParameter("@Day1", System.Data.DbType.Decimal, 9, t.Day1));
                Cmd.Parameters.Add(db.CreateParameter("@Day2", System.Data.DbType.Decimal, 9, t.Day2));
                Cmd.Parameters.Add(db.CreateParameter("@Day3", System.Data.DbType.Decimal, 9, t.Day3));
                Cmd.Parameters.Add(db.CreateParameter("@Day4", System.Data.DbType.Decimal, 9, t.Day4));
                Cmd.Parameters.Add(db.CreateParameter("@Day5", System.Data.DbType.Decimal, 9, t.Day5));
                Cmd.Parameters.Add(db.CreateParameter("@Day6", System.Data.DbType.Decimal, 9, t.Day6));
                Cmd.Parameters.Add(db.CreateParameter("@Day7", System.Data.DbType.Decimal, 9, t.Day7));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanWeekDetailDAL", "Insert(ManufacturePlanWeekDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ManufacturePlanWeekDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanWeekDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, t.ManufacturePlanWeekID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                Cmd.Parameters.Add(db.CreateParameter("@Day1", System.Data.DbType.Decimal, 9, t.Day1));
                Cmd.Parameters.Add(db.CreateParameter("@Day2", System.Data.DbType.Decimal, 9, t.Day2));
                Cmd.Parameters.Add(db.CreateParameter("@Day3", System.Data.DbType.Decimal, 9, t.Day3));
                Cmd.Parameters.Add(db.CreateParameter("@Day4", System.Data.DbType.Decimal, 9, t.Day4));
                Cmd.Parameters.Add(db.CreateParameter("@Day5", System.Data.DbType.Decimal, 9, t.Day5));
                Cmd.Parameters.Add(db.CreateParameter("@Day6", System.Data.DbType.Decimal, 9, t.Day6));
                Cmd.Parameters.Add(db.CreateParameter("@Day7", System.Data.DbType.Decimal, 9, t.Day7));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanWeekDetailDAL", "Update(ManufacturePlanWeekDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ManufacturePlanWeekDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanWeekDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, t.ManufacturePlanWeekID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanWeekDetailDAL", "Delete(ManufacturePlanWeekDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
