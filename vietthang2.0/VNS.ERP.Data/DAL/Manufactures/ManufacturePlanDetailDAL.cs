using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Manufactures
{
    class ManufacturePlanDetailDAL : StockBaseDAL<ManufacturePlanDetail>
    {
        public ManufacturePlanDetailDAL()
        {}
        public ManufacturePlanDetailDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_ManufacturePlanDetails_Select_All";
        }

        /// <summary>
        /// insert a ManufacturePlanDetails object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(ManufacturePlanDetail t)
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
                cmd.CommandText = "usp_ManufacturePlanDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanID", System.Data.DbType.Guid, 16,t.ManufacturePlanID));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@DetailDate", System.Data.DbType.DateTime, 4, t.DetailDate));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Int32, 4, t.Shift));
                cmd.Parameters.Add(db.CreateParameter("@LinesxNo", System.Data.DbType.String, 10, t.LinesxNo));
                cmd.Parameters.Add(db.CreateParameter("@PlanWeight", System.Data.DbType.Decimal, 9, t.PlanWeight));
                cmd.Parameters.Add(db.CreateParameter("@PlanWrapping", System.Data.DbType.Decimal, 9, t.PlanWrapping));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanDetailDAL", "Insert(ManufacturePlanDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
       
        /// <summary>
        /// delete a ManufacturePlanDetails object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(ManufacturePlanDetail t)
        {
            return Delete(t.ManufacturePlanID);
        }
        /// <summary>
        /// Delete a ManufacturePlanDetails  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(Guid _ManufacturePlanID)
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
                cmd.CommandText = "usp_ManufacturePlanDetails_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanID", System.Data.DbType.Guid, 16, _ManufacturePlanID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanDetailDAL", "Delete(Guid _ManufacturePlanID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<ManufacturePlanDetail> GetManufacturePlanDetailByID(Guid _ManufacturePlanID)
        {
            bool alreadyOpen = false;
            ListBase<ManufacturePlanDetail> lobj = new ListBase<ManufacturePlanDetail>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufacturePlanDetails_Select_ManufacturePlanID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanID", System.Data.DbType.Guid, 16, _ManufacturePlanID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    ManufacturePlanDetail obj = new ManufacturePlanDetail(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("ManufacturePlanDAL", "GetManufacturePlanDetailByID(Guid _ManufacturePlanID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }

        /// <summary>
        /// Get DataTable Reports ManufactureDetail group by ItemCode
        /// </summary>
        /// <param name="planDate"></param>
        /// <param name="stockCode"></param>
        /// <returns></returns>
        public DataTable GetReportForItemCode(string planNo)
        {
            bool alreadyOpen = false;
            DataTable dtReturn = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufacturePlanDetails_Reports_For_ItemCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, planNo));
                dtReturn = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanDAL", "GetReportForItemCode(string planNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dtReturn;
        }

        /// <summary>
        /// Get DataTable Reports ManufactureDetail group by SizeCode
        /// </summary>
        /// <param name="planDate"></param>
        /// <param name="stockCode"></param>
        /// <returns></returns>
        public DataTable GetReportForSizeCode(string planNo)
        {
            bool alreadyOpen = false;
            DataTable dtReturn = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufacturePlanDetails_Reports_For_SizeCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, planNo));
                dtReturn = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("ManufacturePlanDAL", "GetReportForSizeCode(string planNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dtReturn;
        }

    }
}
