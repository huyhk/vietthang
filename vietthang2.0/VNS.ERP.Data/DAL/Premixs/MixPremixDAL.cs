using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Premixs
{
    public class MixPremixDAL : StockBaseDAL<MixPremix>
    {
        //private Guid _GrindShiftID;
        public MixPremixDAL() { }
        public MixPremixDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_MixPremixs_Select_All";
        }
        /// <summary>
        /// Inserts objects MixPremix
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(MixPremix t)
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
                cmd.CommandText = "usp_MixPremixs_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, t.PremixCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixWeight", System.Data.DbType.Decimal, 9, t.PremixWeight));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Nap", System.Data.DbType.Decimal, 9, t.Nap));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Wrapping", System.Data.DbType.Decimal, 9, t.Wrapping));
                cmd.Parameters.Add(db.CreateParameter("@MixPremixShiftID", System.Data.DbType.Guid, 16, t.MixPremixShiftID));
                cmd.Parameters.Add(db.CreateParameter("@WrappingWaste", System.Data.DbType.Decimal, 9, t.WrappingWaste));
                cmd.Parameters.Add(db.CreateParameter("@MixPremixID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@Premixer", System.Data.DbType.String, 50, t.Premixer));
                cmd.Parameters.Add(db.CreateParameter("@PremixWrappingCode", System.Data.DbType.String, 50, t.PremixWrappingCode));
                cmd.Parameters.Add(db.CreateParameter("@TonPerCode", System.Data.DbType.Decimal, 9, t.TonPerCode));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.MixPremixID = (Guid)cmd.Parameters["@MixPremixID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixDAL", "Insert(MixPremix t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }



        /// <summary>
        /// Update objects MixPremix
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(MixPremix t)
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
                cmd.CommandText = "usp_MixPremixs_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixID", System.Data.DbType.Guid, 16, t.MixPremixID));
                cmd.Parameters.Add(db.CreateParameter("@PremixCode", System.Data.DbType.String, 50, t.PremixCode));
                cmd.Parameters.Add(db.CreateParameter("@PremixWeight", System.Data.DbType.Decimal, 9, t.PremixWeight));
                cmd.Parameters.Add(db.CreateParameter("@FormulaCode", System.Data.DbType.String, 20, t.FormulaCode));
                cmd.Parameters.Add(db.CreateParameter("@Nap", System.Data.DbType.Decimal, 9, t.Nap));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Wrapping", System.Data.DbType.Decimal, 9, t.Wrapping));
                cmd.Parameters.Add(db.CreateParameter("@WrappingWaste", System.Data.DbType.Decimal, 9, t.WrappingWaste));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 10, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@Premixer", System.Data.DbType.String, 50, t.Premixer));
                cmd.Parameters.Add(db.CreateParameter("@PremixWrappingCode", System.Data.DbType.String, 50, t.PremixWrappingCode));
                cmd.Parameters.Add(db.CreateParameter("@TonPerCode", System.Data.DbType.Decimal, 9, t.TonPerCode));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixDAL", "Insert(MixPremix t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }

        public override int Delete(MixPremix t)
        {
            return Delete(t.MixPremixID, t.UserUpdated);
        }
        public int Delete(Guid _MixPremixID, string _UserUpdated)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MixPremixs_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixID", System.Data.DbType.Guid, 16, _MixPremixID));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, _UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixDAL", "Delete(Guid _MixPremixID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }


        public int UpdateStatusMixPremixhift(Guid _MixPremixShiftID, int _Status, string _UserUpdated)
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
                cmd.CommandText = "usp_MixPremixShift_Update_Status";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixShiftID", System.Data.DbType.Guid, 16, _MixPremixShiftID));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, _Status));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, _UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixDAL", "UpdateStatusMixPremixShift(Guid _MixPremixShiftID, int _Status, string _UserUpdated)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }

        public void GetMixPremixDetail(MixPremix mixPre)
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
                cmd.CommandText = "usp_MixPremixTransactions_Select_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixID", System.Data.DbType.Guid, 16, mixPre.MixPremixID));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.Int32, 4, (int)enumMixPremixTransactionType.AdjustIn));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    MixPremixTransaction obj = new MixPremixTransaction(reader);
                    mixPre.LstDieuchinh.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MixPremixDAL", "GetMixPremixDetail(MixPremix grind)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
        }
        public void GetMaterialIn(MixPremix mixPre)
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
                cmd.CommandText = "usp_MixPremixTransactions_Select_MaterialIn";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixID", System.Data.DbType.Guid, 16, mixPre.MixPremixID));
                reader = db.ExecuteReader(cmd);
                if (mixPre.LstMaterialIn == null)
                    mixPre.LstMaterialIn = new ListBase<MixPremixTransaction>();
                else
                    mixPre.LstMaterialIn.Clear();
                while (reader.Read())
                {
                    MixPremixTransaction obj = new MixPremixTransaction(reader);

                    MixPremixTransaction objf = mixPre.LstMaterialIn.Search("ItemCode",obj.ItemCode);
                    if (objf == null)
                        mixPre.LstMaterialIn.Add(obj);
                    else
                    {
                        objf.Quantity += obj.Quantity;
                        if (objf.Quantity == 0)
                            mixPre.LstMaterialIn.Remove(objf);
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MixPremixDAL", "GetMixPremixDetail(MixPremix grind)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
        }
    }
}