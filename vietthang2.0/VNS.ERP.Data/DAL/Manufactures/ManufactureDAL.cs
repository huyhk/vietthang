using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureDAL : StockBaseDAL<Manufacture>
    {
        public ManufactureDAL() { }
        public ManufactureDAL(DBHelper dbHelper) : base(dbHelper) { }
        private Guid _ManuShiftID;
        protected override void SetValues()
        {
            _spSelectAll = "usp_Manufactures_Select_All";
        }

        public Manufacture GetObjectsByID(Guid _ManufactureShiftID)
        {
            bool alreadyOpen = false;
            Manufacture obj = new Manufacture();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShifts_Select_ManufactureShiftID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, _ManufactureShiftID));
                reader = db.ExecuteReader(cmd);

                while (reader.Read())
                {
                    obj = new Manufacture(reader);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "GetObjectsByID(Guid _ManufactureShiftID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        /// <summary>
        /// Inserts objects Manufactures
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(Manufacture t)
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
                cmd.CommandText = "usp_Manufactures_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@LinesxNo", System.Data.DbType.String, 10, t.LinesxNo));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID1", System.Data.DbType.String, 10, t.EmployeeID1));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID2", System.Data.DbType.String, 10, t.EmployeeID2));
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", System.Data.DbType.String, 10, t.SizeCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Nap", System.Data.DbType.Decimal, 9, t.Nap));
                cmd.Parameters.Add(db.CreateParameter("@ProductWeight", System.Data.DbType.Decimal, 9, t.ProductWeight));
                cmd.Parameters.Add(db.CreateParameter("@Lot", System.Data.DbType.String, 20,t.Lot));
                cmd.Parameters.Add(db.CreateParameter("@Ep", System.Data.DbType.Decimal, 9, t.Ep));
                cmd.Parameters.Add(db.CreateParameter("@Domin", System.Data.DbType.String, 20, t.Domin));
                cmd.Parameters.Add(db.CreateParameter("@Am", System.Data.DbType.String, 20, t.Am));
                cmd.Parameters.Add(db.CreateParameter("@Tilebot", System.Data.DbType.String, 20, t.Tilebot));
                cmd.Parameters.Add(db.CreateParameter("@CodeBaoTP", System.Data.DbType.String, 100, t.CodeBaoTP));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 500, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Wrapping", System.Data.DbType.Decimal, 9, t.Wrapping));
                cmd.Parameters.Add(db.CreateParameter("@Phepham", System.Data.DbType.Decimal, 9, t.Phepham));
                cmd.Parameters.Add(db.CreateParameter("@Taiche", System.Data.DbType.Decimal, 9, t.Taiche));
                cmd.Parameters.Add(db.CreateParameter("@Electricity", System.Data.DbType.Decimal, 9, t.Electricity));
                cmd.Parameters.Add(db.CreateParameter("@DelayTime", System.Data.DbType.Int32, 4, t.DelayTime));
                cmd.Parameters.Add(db.CreateParameter("@StartTime", System.Data.DbType.DateTime, 4, t.StartTime));
                cmd.Parameters.Add(db.CreateParameter("@EndTime", System.Data.DbType.DateTime, 4, t.EndTime));
                cmd.Parameters.Add(db.CreateParameter("@TotalWorkingTime", System.Data.DbType.Int32, 4, t.TotalWorkingTime));
                if (t.PlanNo == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                    cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, t.PlanNo));
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, t.ManufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@WrappingWaste", System.Data.DbType.Decimal, 9, t.WrappingWaste));
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@ItemProductCode", System.Data.DbType.String, 50, t.ItemProductCode));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@Docung", System.Data.DbType.Decimal, 9, t.Docung));
                cmd.Parameters.Add(db.CreateParameter("@Tytrong", System.Data.DbType.Decimal, 9, t.Tytrong));

                cmd.Parameters.Add(db.CreateParameter("@IsSilo", System.Data.DbType.Boolean, 1, t.IsSilo));
                cmd.Parameters.Add(db.CreateParameter("@FabNo", System.Data.DbType.String, 50, t.FabNo));

                cmd.Parameters.Add(db.CreateParameter("@CodePremix", System.Data.DbType.String, 50, t.CodePremix));
                cmd.Parameters.Add(db.CreateParameter("@ItemWrappingCode", System.Data.DbType.String, 50, t.ItemWrappingCode));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ManufactureID = (Guid)cmd.Parameters["@ManufactureID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureDAL", "Insert(Manufactures t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
     

        public int UpdateManufactureShiftStatus(Guid _ManufactureShiftID, int _Status, string _UserUpdate)
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
                cmd.CommandText = "usp_ManufactureShift_Update_Status";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, _ManufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, _Status));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, _UserUpdate));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureDAL", "UpdateManufactureShiftStatus(Guid _ManufactureShiftID, int _Status, string _UserUpdate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Select Manufactures Table from Database 
        /// </summary>
        /// <param name="_StockCode"></param>
        /// <param name="_Tungay"></param>
        /// <param name="_Denngay"></param>
        /// <returns></returns>
        /// usp_Manufactures_Report_ShiftDetail2
        public DataTable ReportManufacture(string _StockCode, DateTime _Tungay, DateTime _Denngay)
        {
            bool alreadyOpen = false;
            DataTable dt = new DataTable();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Reports";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@tungay", System.Data.DbType.DateTime, 4, _Tungay));
                cmd.Parameters.Add(db.CreateParameter("@denngay", System.Data.DbType.DateTime, 4, _Denngay));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "ReportManufacture(DateTime _Tungay,DateTime _Denngay)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        public DataSet ReportManufactureDS(string _StockCode, DateTime _Tungay, DateTime _Denngay)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Reports";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@tungay", System.Data.DbType.DateTime, 4, _Tungay));
                cmd.Parameters.Add(db.CreateParameter("@denngay", System.Data.DbType.DateTime, 4, _Denngay));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "ReportManufacture(DateTime _Tungay,DateTime _Denngay)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public Guid TestExitsManufactureShift(string _StockCode, DateTime _ManufactureDate, int _Shift)
        {
         
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShifts_TestsExits";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String,10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ManufactureDate", System.Data.DbType.DateTime, 4, _ManufactureDate));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Int32,4,_Shift));
               _ManuShiftID =(Guid)db.ExecuteScalar(cmd);
             
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", " TestExitsManufactureShift(string _StockCode, DateTime _ManufactureDate, int _Shift, string _ShiftLeader)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return _ManuShiftID;


        }
        public int  SelectStatusManufactureShift(Guid _ManufactureShiftID)
        {
         
            bool alreadyOpen = false;
            int _Status = 0;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShift_Select_Status";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, _ManufactureShiftID));
               _Status =int.Parse(db.ExecuteScalar(cmd).ToString());
                
             
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "SelectStatusManufactureShift(Guid _ManufactureShiftID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return _Status;
        }


        public DataSet GetManufacturebyStockCode(string _StockCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Select_By_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                ds = db.ExecuteDataSet(cmd);
                ds.Relations.Add("Manu",
                   ds.Tables[0].Columns["ManufactureShiftID"],
                   ds.Tables[1].Columns["ManufactureShiftID"]);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "GetManufacturebyStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        /// <summary>
        /// Update Object
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(Manufacture t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, t.ManufactureID));
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, t.ProductCode));
                cmd.Parameters.Add(db.CreateParameter("@LinesxNo", System.Data.DbType.String, 10, t.LinesxNo));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID1", System.Data.DbType.String, 10, t.EmployeeID1));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID2", System.Data.DbType.String, 10, t.EmployeeID2));
                cmd.Parameters.Add(db.CreateParameter("@SizeCode", System.Data.DbType.String, 10, t.SizeCode));
                cmd.Parameters.Add(db.CreateParameter("@WeightCode", System.Data.DbType.String, 10, t.WeightCode));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Nap", System.Data.DbType.Decimal, 9, t.Nap));
                cmd.Parameters.Add(db.CreateParameter("@ProductWeight", System.Data.DbType.Decimal, 9, t.ProductWeight));
                cmd.Parameters.Add(db.CreateParameter("@Lot", System.Data.DbType.String, 20, t.Lot));
                cmd.Parameters.Add(db.CreateParameter("@Ep", System.Data.DbType.Decimal, 9, t.Ep));
                cmd.Parameters.Add(db.CreateParameter("@Domin", System.Data.DbType.String, 20, t.Domin));
                cmd.Parameters.Add(db.CreateParameter("@Am", System.Data.DbType.String, 20, t.Am));
                cmd.Parameters.Add(db.CreateParameter("@Tilebot", System.Data.DbType.String, 20, t.Tilebot));
                cmd.Parameters.Add(db.CreateParameter("@CodeBaoTP", System.Data.DbType.String, 100, t.CodeBaoTP));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 500, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Phepham", System.Data.DbType.Decimal, 9, t.Phepham));
                cmd.Parameters.Add(db.CreateParameter("@Taiche", System.Data.DbType.Decimal, 9, t.Taiche));
                cmd.Parameters.Add(db.CreateParameter("@Electricity", System.Data.DbType.Decimal, 9, t.Electricity));
                cmd.Parameters.Add(db.CreateParameter("@DelayTime", System.Data.DbType.Int32, 4, t.DelayTime));
                cmd.Parameters.Add(db.CreateParameter("@StartTime", System.Data.DbType.DateTime, 4, t.StartTime));
                cmd.Parameters.Add(db.CreateParameter("@EndTime", System.Data.DbType.DateTime, 4, t.EndTime));
                cmd.Parameters.Add(db.CreateParameter("@TotalWorkingTime", System.Data.DbType.Int32, 4, t.TotalWorkingTime));
                if (t.PlanNo == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                    cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, t.PlanNo));
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, t.ManufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@Wrapping", System.Data.DbType.Decimal, 9, t.Wrapping));
                cmd.Parameters.Add(db.CreateParameter("@WrappingWaste", System.Data.DbType.Decimal, 9, t.WrappingWaste));
                cmd.Parameters.Add(db.CreateParameter("@ItemProductCode", System.Data.DbType.String, 50, t.ItemProductCode));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@Docung", System.Data.DbType.Decimal, 9, t.Docung));
                cmd.Parameters.Add(db.CreateParameter("@Tytrong", System.Data.DbType.Decimal, 9, t.Tytrong));

                cmd.Parameters.Add(db.CreateParameter("@IsSilo", System.Data.DbType.Boolean, 1, t.IsSilo));
                cmd.Parameters.Add(db.CreateParameter("@FabNo", System.Data.DbType.String, 50, t.FabNo));

                cmd.Parameters.Add(db.CreateParameter("@CodePremix", System.Data.DbType.String, 50, t.CodePremix));
                cmd.Parameters.Add(db.CreateParameter("@ItemWrappingCode", System.Data.DbType.String, 50, t.ItemWrappingCode));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {

                iError = -1000;
                Write2Log.WriteLogs("ManufactureDAL", "Update(Manufacture t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
           
        }

        /// <summary>
        /// Update Header Object
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int UpdateHeader(Manufacture t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_UpdateHeader";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, t.ManufactureID));
                cmd.Parameters.Add(db.CreateParameter("@LinesxNo", System.Data.DbType.String, 10, t.LinesxNo));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID1", System.Data.DbType.String, 10, t.EmployeeID1));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID2", System.Data.DbType.String, 10, t.EmployeeID2));
                cmd.Parameters.Add(db.CreateParameter("@Lot", System.Data.DbType.String, 20, t.Lot));
                cmd.Parameters.Add(db.CreateParameter("@Ep", System.Data.DbType.Decimal, 9, t.Ep));
                cmd.Parameters.Add(db.CreateParameter("@Domin", System.Data.DbType.String, 20, t.Domin));
                cmd.Parameters.Add(db.CreateParameter("@Am", System.Data.DbType.String, 20, t.Am));
                cmd.Parameters.Add(db.CreateParameter("@Tilebot", System.Data.DbType.String, 20, t.Tilebot));
                cmd.Parameters.Add(db.CreateParameter("@CodeBaoTP", System.Data.DbType.String, 50, t.CodeBaoTP));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 500, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Electricity", System.Data.DbType.Decimal, 9, t.Electricity));
                cmd.Parameters.Add(db.CreateParameter("@DelayTime", System.Data.DbType.Int32, 4, t.DelayTime));
                cmd.Parameters.Add(db.CreateParameter("@StartTime", System.Data.DbType.DateTime, 4, t.StartTime));
                cmd.Parameters.Add(db.CreateParameter("@EndTime", System.Data.DbType.DateTime, 4, t.EndTime));
                cmd.Parameters.Add(db.CreateParameter("@TotalWorkingTime", System.Data.DbType.Int32, 4, t.TotalWorkingTime));
                if (t.PlanNo == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                    cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 20, t.PlanNo));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@Docung", System.Data.DbType.Decimal, 9, t.Docung));
                cmd.Parameters.Add(db.CreateParameter("@Tytrong", System.Data.DbType.Decimal, 9, t.Tytrong));
                cmd.Parameters.Add(db.CreateParameter("@FabNo", System.Data.DbType.String, 50, t.FabNo));

                cmd.Parameters.Add(db.CreateParameter("@CodePremix", System.Data.DbType.String, 50, t.CodePremix));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {

                iError = -1000;
                Write2Log.WriteLogs("ManufactureDAL", "UpdateHeader(Manufacture t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;

        }
        public override int Delete(Manufacture t)
        {
            return Delete(t.ManufactureID,t.UserUpdated);
        }
        public int Delete(Guid _ManufactureID , string _UserUpdated)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, _ManufactureID));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, _UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureDAL", "Delete(Guid _ManufactureID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public int DeleteManufatureShifts(Guid _ManufactureShiftID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShifts_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, _ManufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureDAL", "DeleteManufatureShifts(Guid _ManufactureShiftID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;


        }
        
        public DataTable ReportManufactureShiftDetails(string _StockCode,int _ForDepartment, DateTime _Tungay,DateTime _Denngay, string _ItemType)
        {
            bool alreadyOpen = false;
            DataTable dt = new DataTable();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Report_ShiftDetail2";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Int32, 4, _ForDepartment));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4,DateTime.Parse(_Tungay.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, DateTime.Parse(_Denngay.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.String, 100, _ItemType));

                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "ReportManufactureShiftDetails(string _StockCode,DateTime _Tungay,DateTime _Denngay)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        /// <summary>
        /// Select 
        /// </summary>
        /// <param name="_ProductCode"></param>
        /// <returns></returns>
        public DataSet Select_WCode_SCode_FCode_by_ProductCode(string _ProductCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Select_WCode_SCode_FCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ProductCode", System.Data.DbType.String, 10, _ProductCode));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "Select_WCode_SCode_FCode_by_ProductCode(string _ProductCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }

        public void GetManufactureDetail(Manufacture manu)
        {
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureTransactions_Select_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, manu.ManufactureID));
                reader = db.ExecuteReader(cmd);
                if (manu.LstTaiche == null)
                {
                    manu.LstTaiche = new ListBase<ManufactureTransaction>();
                    manu.LstNhienlieu = new ListBase<ManufactureTransaction>();
                    manu.LstDieuchinh = new ListBase<ManufactureTransaction>();
                    manu.LstPhepham = new ListBase<ManufactureTransaction>();
                    manu.LstMaterialIn = new ListBase<ManufactureTransaction>();
                    manu.LstWrappingIn = new ListBase<ManufactureTransaction>();
                }
                while (reader.Read())
                {
                    ManufactureTransaction obj = new ManufactureTransaction(reader);
                    switch (obj.TransactionType)
                    {
                        case (int)enumManufactureTransactionType.WasteIn:
                            manu.LstTaiche.Add(obj);
                            break;
                        case (int)enumManufactureTransactionType.FuelIn:
                            manu.LstNhienlieu.Add(obj);
                            break;
                        case (int)enumManufactureTransactionType.AdjustIn:
                            manu.LstDieuchinh.Add(obj);
                            break;
                        case (int)enumManufactureTransactionType.WasteOut:
                            manu.LstPhepham.Add(obj);
                            break;
                        case (int)enumManufactureTransactionType.MaterialIn:
                            manu.LstMaterialIn.Add(obj);
                            break;
                        case (int)enumManufactureTransactionType.WrappingIn:
                            manu.LstWrappingIn.Add(obj);
                            break;
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "GetManufactureDetail(Manufacture manu)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
         
        }
        public DataTable GetWasteOrg(Guid manufactureID)
        {
            bool alreadyOpen = false;
            DataTable ds = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureWaste_GetOrg";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureID", System.Data.DbType.Guid, 16, manufactureID));
                ds = db.ExecuteTable(cmd);
                ds.TableName = "WasteOrg";
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureDAL", "ReportManufacture(DateTime _Tungay,DateTime _Denngay)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        
        }
     
    }
}


