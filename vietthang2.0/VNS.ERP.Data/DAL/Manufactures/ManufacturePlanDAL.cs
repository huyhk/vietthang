using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Manufactures
{
    class ManufacturePlanDAL : StockBaseDAL<ManufacturePlan>
    {
     public ManufacturePlanDAL()
        {}
        public ManufacturePlanDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_ManufaturePlans_Select_All";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturePlanID"></param>
        /// <returns></returns>
        public DataTable GetDetailMaterial(Guid manufacturePlanID,DateTime planDate)
        {
            DataTable dtReturn = new DataTable();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlan_Select_Detail_Material";
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanID", System.Data.DbType.Guid, 16, manufacturePlanID));
                cmd.Parameters.Add(db.CreateParameter("@PlanDate", System.Data.DbType.DateTime, 4, planDate));
                dtReturn = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanDAL", "GetDetailMaterial(Guid manufacturePlanID,DateTime planDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return dtReturn;
        }
        /// <summary>
        /// insert a ManufacturePlans object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(ManufacturePlan t)
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
                cmd.CommandText = "usp_ManufacturePlans_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, t.PlanNo));
                cmd.Parameters.Add(db.CreateParameter("@PlanDate", System.Data.DbType.DateTime, 4, t.PlanDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 500, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@TyleHaohut", System.Data.DbType.Decimal, 9, t.TyleHaohut));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ManufacturePlanID = (Guid)cmd.Parameters["@ManufacturePlanID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanDAL", "Insert(ManufacturePlan t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a ManufacturePlans object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(ManufacturePlan t)
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
                cmd.CommandText = "usp_ManufacturePlans_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanID", System.Data.DbType.Guid, 16, t.ManufacturePlanID));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, t.PlanNo));
                cmd.Parameters.Add(db.CreateParameter("@PlanDate", System.Data.DbType.DateTime, 4, t.PlanDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 500, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean, 1, t.IsFinished));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@TyleHaohut", System.Data.DbType.Decimal, 9, t.TyleHaohut));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanDAL", "Update(ManufacturePlan t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a ManufacturePlans object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(ManufacturePlan t)
        {
            return Delete(t.ManufacturePlanID);
        }
        /// <summary>
        /// Delete a ManufacturePlans  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(Guid manufacturePlanID)
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
                cmd.CommandText = "usp_ManufacturePlans_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanID", System.Data.DbType.Guid, 16, manufacturePlanID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanDAL", "Delete(Guid manufacturePlanID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<ManufacturePlan> GetAllManufacturePlanByStockCode(string stockCode)
        {
            bool alreadyOpen = false;
            ListBase<ManufacturePlan> lobj = new ListBase<ManufacturePlan>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufacturePlans_Select_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ManufacturePlan obj = new ManufacturePlan(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {
                
                Write2Log.WriteLogs("ManufacturePlanDAL", " GetManufacturePlanByStockCode(string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<ManufacturePlan> GetManufacturePlanByStockCode(string stockCode)
        {
            bool alreadyOpen = false;
            ListBase<ManufacturePlan> lobj = new ListBase<ManufacturePlan>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufacturePlans_Select_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@All", System.Data.DbType.Boolean, 1, true));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ManufacturePlan obj = new ManufacturePlan(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("ManufacturePlanDAL", " GetManufacturePlanByStockCode(string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public ListBase<ManufacturePlan> GetListObjectByTime(DateTime startDate,DateTime endDate,string stockCode)
        {
            bool alreadyOpen = false;
            ListBase<ManufacturePlan> lobj = new ListBase<ManufacturePlan>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufacturePlans_SelectByTime_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ManufacturePlan obj = new ManufacturePlan(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("ManufacturePlanDAL", "GetListObjectByTime(DateTime startDate,DateTime endDate,string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        public decimal GetPlanWeight(string planNo, string formulaCode, string itemCode, int shift, string linesxNo)
        {
            bool alreadyOpen = false;
            decimal weight = 0;
            try
            {
                
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufacturePlan_GetPlanWeight";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, planNo));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, formulaCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, itemCode));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Int32, 20, shift));
                cmd.Parameters.Add(db.CreateParameter("@LinesxNo", System.Data.DbType.String, 20, linesxNo));
                weight = (decimal)db.ExecuteScalar(cmd);
                

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("ManufacturePlanDAL", "GetPlanWeight()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return weight;
        }
    }
}
