using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.Equipments
{
    #region VattuOpeningDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of VattuOpening.
    /// </summary>
    public class VattuOpeningDAL : VNS.Data.DAL.BaseDAL<VattuOpening>
    {
        public VattuOpeningDAL()
        {
        }
        public VattuOpeningDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(VattuOpening t)
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
                cmd.CommandText = "usp_VattuOpening_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.AnsiString, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@VattuCode", System.Data.DbType.AnsiString, 20, t.VattuCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
              
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuOpeningDAL", "Insert(VattuOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public override int Update(VattuOpening t)
        {
            return 0;
        }
        public override int Delete(VattuOpening t)
        {
            return 0;
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
                cmd.CommandText = "usp_VattuOpening_DeleteByPeriodStock";
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
                Write2Log.WriteLogs("VattuOpeningDAL", "Insert(VattuOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public ListBase<VattuOpening> GetByPeriodAndStock(string periodCode, string stockCode)
        {
            bool alreadyOpen = false;
            ListBase<VattuOpening> lobj = new ListBase<VattuOpening>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_VattuOpening_SelectByPeriodAndStock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lobj.Add(new VattuOpening(reader));
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VattuOpeningDAL", "GetByPeriodAndStock(string periodCode, string stockCode)", excp.Message);
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
            _spSelectAll = "usp_VattuOpening_SelectAll";
            _spSelectDynamic = "usp_VattuOpening_SelectDynamic";
            _spDeleteAll = "usp_VattuOpening_DeleteAll";
            _spDeleteDynamic = "usp_VattuOpening_DeleteDynamic";
        }

        #endregion
    }
    #endregion
}
