using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Grinds
{
    public class GrindMaterialDAL : StockBaseDAL<GrindMaterials>
    {
        //private Guid _GrindShiftID;
        public GrindMaterialDAL() { }
        public GrindMaterialDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_GrindMaterials_Select_All";
        }
        /// <summary>
        /// Inserts objects GrindMaterials
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(GrindMaterials t)
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
                cmd.CommandText = "usp_GrindMaterials_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindCode", System.Data.DbType.String, 50, t.GrindCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialWeight", System.Data.DbType.Decimal, 9, t.MaterialWeight));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Nap", System.Data.DbType.Decimal, 9, t.Nap));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Wrapping", System.Data.DbType.Decimal, 9, t.Wrapping));
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialShiftID", System.Data.DbType.Guid, 16, t.GrindMaterialShiftID));
                cmd.Parameters.Add(db.CreateParameter("@WrappingWaste", System.Data.DbType.Decimal, 9, t.WrappingWaste));
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 50, t.PlanNo));

                cmd.Parameters.Add(db.CreateParameter("@LinesxNo", System.Data.DbType.Int32, 4, t.LinesxNo));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID1", System.Data.DbType.String, 10, t.EmployeeID1));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID2", System.Data.DbType.String, 10, t.EmployeeID2));
                cmd.Parameters.Add(db.CreateParameter("@Am", System.Data.DbType.Decimal, 9, t.Am));
                cmd.Parameters.Add(db.CreateParameter("@DelayTime", System.Data.DbType.Int32, 4, t.DelayTime));
                cmd.Parameters.Add(db.CreateParameter("@StartTime", System.Data.DbType.DateTime, 4, t.StartTime));
                cmd.Parameters.Add(db.CreateParameter("@EndTime", System.Data.DbType.DateTime, 4, t.EndTime));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.GrindMaterialID = (Guid)cmd.Parameters["@GrindMaterialID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialDAL", "Insert(GrindMaterials t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }

        

        /// <summary>
        /// Update objects GrindMaterials
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(GrindMaterials t)
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
                cmd.CommandText = "usp_GrindMaterials_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialID", System.Data.DbType.Guid, 16, t.GrindMaterialID));
                cmd.Parameters.Add(db.CreateParameter("@GrindCode", System.Data.DbType.String, 50, t.GrindCode));
                cmd.Parameters.Add(db.CreateParameter("@MaterialWeight", System.Data.DbType.Decimal, 9, t.MaterialWeight));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 10, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Nap", System.Data.DbType.Decimal, 9, t.Nap));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Wrapping", System.Data.DbType.Decimal, 9, t.Wrapping));
                cmd.Parameters.Add(db.CreateParameter("@WrappingWaste", System.Data.DbType.Decimal, 9, t.WrappingWaste));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 10, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@PlanNo", System.Data.DbType.String, 50, t.PlanNo));

                cmd.Parameters.Add(db.CreateParameter("@LinesxNo", System.Data.DbType.Int32, 4, t.LinesxNo));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID1", System.Data.DbType.String, 10, t.EmployeeID1));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID2", System.Data.DbType.String, 10, t.EmployeeID2));
                cmd.Parameters.Add(db.CreateParameter("@Am", System.Data.DbType.Decimal, 9, t.Am));
                cmd.Parameters.Add(db.CreateParameter("@DelayTime", System.Data.DbType.Int32, 4, t.DelayTime));
                cmd.Parameters.Add(db.CreateParameter("@StartTime", System.Data.DbType.DateTime, 4, t.StartTime));
                cmd.Parameters.Add(db.CreateParameter("@EndTime", System.Data.DbType.DateTime, 4, t.EndTime));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
              
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialDAL", "Insert(GrindMaterials t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }

        public override int Delete(GrindMaterials t)
        {
            return Delete(t.GrindMaterialID,t.UserUpdated);
        }
        public int Delete(Guid _GrindMaterialID,string _UserUpdated)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GrindMaterials_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialID", System.Data.DbType.Guid, 16, _GrindMaterialID));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, _UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialDAL", "Delete(Guid _GrindMaterialID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;


        }
    
    
        public int UpdateStatusGrindMaterialShift(Guid _GrindMaterialShiftID, int _Status, string _UserUpdated)
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
                cmd.CommandText = "usp_GrindMaterialShifts_Update_Status";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialShiftID", System.Data.DbType.Guid, 16, _GrindMaterialShiftID));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, _Status));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, _UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialDAL", "UpdateStatusGrindMaterialShift(Guid _GrindMaterialShiftID, int _Status, string _UserUpdated)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }

      

        public void GetGrindMaterialDetail(GrindMaterials grind)
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
                cmd.CommandText = "usp_GrindMaterialTransactions_Select_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialID", System.Data.DbType.Guid, 16, grind.GrindMaterialID));
                //cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.Int32, 4, (int)enumGrindMaterialTransactionType.AdjustIn));
                reader = db.ExecuteReader(cmd);

                if (grind.LstDieuchinh == null)
                    grind.NewList();
                while (reader.Read())
                {
                    GrindMaterialTransactions obj = new GrindMaterialTransactions(reader);
                    //grind.LstDieuchinh.Add(obj);

                    switch (obj.TransactionType)
                    {
                        case (int)enumGrindMaterialTransactionType.AdjustIn:
                            grind.LstDieuchinh.Add(obj);
                            break;
                        case (int)enumGrindMaterialTransactionType.FuelIn:
                            grind.LstNhienlieu.Add(obj);
                            break;
                        case (int)enumGrindMaterialTransactionType.WasteOut:
                            grind.LstPhepham.Add(obj);
                            break;
                        case (int)enumGrindMaterialTransactionType.WasteIn:
                            grind.LstTaiche.Add(obj);
                            break;
                       
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("GrindMaterialDAL", "GetGrindMaterialDetail(GrindMaterial grind)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) 
                    db.Close();
            }
        }
    }
}