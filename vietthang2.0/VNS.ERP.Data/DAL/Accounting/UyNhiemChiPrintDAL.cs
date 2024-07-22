using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data.Accounting
{
    #region UyNhiemChiPrintDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of UyNhiemChiPrint.
    /// </summary>
    public class UyNhiemChiPrintDAL : BaseDAL<UyNhiemChiPrint>
    {
        public UyNhiemChiPrintDAL()
        {
        }
        public UyNhiemChiPrintDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(UyNhiemChiPrint t)
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
                cmd.CommandText = "usp_UyNhiemChiPrint_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@CoGiay", System.Data.DbType.String, 50, t.CoGiay));
                cmd.Parameters.Add(db.CreateParameter("@InNgang", System.Data.DbType.Boolean, 1, t.InNgang));
                cmd.Parameters.Add(db.CreateParameter("@NgayX", System.Data.DbType.Int32, 4, t.NgayX));
                cmd.Parameters.Add(db.CreateParameter("@NgayY", System.Data.DbType.Int32, 4, t.NgayY));
                cmd.Parameters.Add(db.CreateParameter("@NgayF", System.Data.DbType.String, 50, t.NgayF));
                cmd.Parameters.Add(db.CreateParameter("@ThangX", System.Data.DbType.Int32, 4, t.ThangX));
                cmd.Parameters.Add(db.CreateParameter("@ThangF", System.Data.DbType.String, 50, t.ThangF));
                cmd.Parameters.Add(db.CreateParameter("@NamX", System.Data.DbType.Int32, 4, t.NamX));
                cmd.Parameters.Add(db.CreateParameter("@NamF", System.Data.DbType.String, 50, t.NamF));
                cmd.Parameters.Add(db.CreateParameter("@TraTenX", System.Data.DbType.Int32, 4, t.TraTenX));
                cmd.Parameters.Add(db.CreateParameter("@TraTenY", System.Data.DbType.Int32, 4, t.TraTenY));
                cmd.Parameters.Add(db.CreateParameter("@TraTenC", System.Data.DbType.Int32, 4, t.TraTenC));
                cmd.Parameters.Add(db.CreateParameter("@TraTenX2", System.Data.DbType.Int32, 4, t.TraTenX2));
                cmd.Parameters.Add(db.CreateParameter("@TraTenY2", System.Data.DbType.Int32, 4, t.TraTenY2));
                cmd.Parameters.Add(db.CreateParameter("@TraTKX", System.Data.DbType.Int32, 4, t.TraTKX));
                cmd.Parameters.Add(db.CreateParameter("@TraTKY", System.Data.DbType.Int32, 4, t.TraTKY));
                cmd.Parameters.Add(db.CreateParameter("@TraNHX", System.Data.DbType.Int32, 4, t.TraNHX));
                cmd.Parameters.Add(db.CreateParameter("@TraNHY", System.Data.DbType.Int32, 4, t.TraNHY));
                cmd.Parameters.Add(db.CreateParameter("@TienChuX", System.Data.DbType.Int32, 4, t.TienChuX));
                cmd.Parameters.Add(db.CreateParameter("@TienChuY", System.Data.DbType.Int32, 4, t.TienChuY));
                cmd.Parameters.Add(db.CreateParameter("@TienChuC", System.Data.DbType.Int32, 4, t.TienChuC));
                cmd.Parameters.Add(db.CreateParameter("@TienChuX2", System.Data.DbType.Int32, 4, t.TienChuX2));
                cmd.Parameters.Add(db.CreateParameter("@TienChuY2", System.Data.DbType.Int32, 4, t.TienChuY2));
                cmd.Parameters.Add(db.CreateParameter("@TienSoX", System.Data.DbType.Int32, 4, t.TienSoX));
                cmd.Parameters.Add(db.CreateParameter("@TienSoY", System.Data.DbType.Int32, 4, t.TienSoY));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenX", System.Data.DbType.Int32, 4, t.NhanTenX));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenY", System.Data.DbType.Int32, 4, t.NhanTenY));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenC", System.Data.DbType.Int32, 4, t.NhanTenC));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenX2", System.Data.DbType.Int32, 4, t.NhanTenX2));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenY2", System.Data.DbType.Int32, 4, t.NhanTenY2));
                cmd.Parameters.Add(db.CreateParameter("@NhanTKX", System.Data.DbType.Int32, 4, t.NhanTKX));
                cmd.Parameters.Add(db.CreateParameter("@NhanTKY", System.Data.DbType.Int32, 4, t.NhanTKY));
                cmd.Parameters.Add(db.CreateParameter("@NhanNHX", System.Data.DbType.Int32, 4, t.NhanNHX));
                cmd.Parameters.Add(db.CreateParameter("@NhanNHY", System.Data.DbType.Int32, 4, t.NhanNHY));
                cmd.Parameters.Add(db.CreateParameter("@NoiDungX", System.Data.DbType.Int32, 4, t.NoiDungX));
                cmd.Parameters.Add(db.CreateParameter("@NoiDungY", System.Data.DbType.Int32, 4, t.NoiDungY));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("UyNhiemChiPrintDAL", "Insert(UyNhiemChiPrint t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Updates an existing object in database by calling Update StoredProcedure
        /// </summary>
        public override int Update(UyNhiemChiPrint t)
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
                cmd.CommandText = "usp_UyNhiemChiPrint_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@CoGiay", System.Data.DbType.String, 50, t.CoGiay));
                cmd.Parameters.Add(db.CreateParameter("@InNgang", System.Data.DbType.Boolean, 1, t.InNgang));
                cmd.Parameters.Add(db.CreateParameter("@NgayX", System.Data.DbType.Int32, 4, t.NgayX));
                cmd.Parameters.Add(db.CreateParameter("@NgayY", System.Data.DbType.Int32, 4, t.NgayY));
                cmd.Parameters.Add(db.CreateParameter("@NgayF", System.Data.DbType.String, 50, t.NgayF));
                cmd.Parameters.Add(db.CreateParameter("@ThangX", System.Data.DbType.Int32, 4, t.ThangX));
                cmd.Parameters.Add(db.CreateParameter("@ThangF", System.Data.DbType.String, 50, t.ThangF));
                cmd.Parameters.Add(db.CreateParameter("@NamX", System.Data.DbType.Int32, 4, t.NamX));
                cmd.Parameters.Add(db.CreateParameter("@NamF", System.Data.DbType.String, 50, t.NamF));
                cmd.Parameters.Add(db.CreateParameter("@TraTenX", System.Data.DbType.Int32, 4, t.TraTenX));
                cmd.Parameters.Add(db.CreateParameter("@TraTenY", System.Data.DbType.Int32, 4, t.TraTenY));
                cmd.Parameters.Add(db.CreateParameter("@TraTenC", System.Data.DbType.Int32, 4, t.TraTenC));
                cmd.Parameters.Add(db.CreateParameter("@TraTenX2", System.Data.DbType.Int32, 4, t.TraTenX2));
                cmd.Parameters.Add(db.CreateParameter("@TraTenY2", System.Data.DbType.Int32, 4, t.TraTenY2));
                cmd.Parameters.Add(db.CreateParameter("@TraTKX", System.Data.DbType.Int32, 4, t.TraTKX));
                cmd.Parameters.Add(db.CreateParameter("@TraTKY", System.Data.DbType.Int32, 4, t.TraTKY));
                cmd.Parameters.Add(db.CreateParameter("@TraNHX", System.Data.DbType.Int32, 4, t.TraNHX));
                cmd.Parameters.Add(db.CreateParameter("@TraNHY", System.Data.DbType.Int32, 4, t.TraNHY));
                cmd.Parameters.Add(db.CreateParameter("@TienChuX", System.Data.DbType.Int32, 4, t.TienChuX));
                cmd.Parameters.Add(db.CreateParameter("@TienChuY", System.Data.DbType.Int32, 4, t.TienChuY));
                cmd.Parameters.Add(db.CreateParameter("@TienChuC", System.Data.DbType.Int32, 4, t.TienChuC));
                cmd.Parameters.Add(db.CreateParameter("@TienChuX2", System.Data.DbType.Int32, 4, t.TienChuX2));
                cmd.Parameters.Add(db.CreateParameter("@TienChuY2", System.Data.DbType.Int32, 4, t.TienChuY2));
                cmd.Parameters.Add(db.CreateParameter("@TienSoX", System.Data.DbType.Int32, 4, t.TienSoX));
                cmd.Parameters.Add(db.CreateParameter("@TienSoY", System.Data.DbType.Int32, 4, t.TienSoY));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenX", System.Data.DbType.Int32, 4, t.NhanTenX));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenY", System.Data.DbType.Int32, 4, t.NhanTenY));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenC", System.Data.DbType.Int32, 4, t.NhanTenC));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenX2", System.Data.DbType.Int32, 4, t.NhanTenX2));
                cmd.Parameters.Add(db.CreateParameter("@NhanTenY2", System.Data.DbType.Int32, 4, t.NhanTenY2));
                cmd.Parameters.Add(db.CreateParameter("@NhanTKX", System.Data.DbType.Int32, 4, t.NhanTKX));
                cmd.Parameters.Add(db.CreateParameter("@NhanTKY", System.Data.DbType.Int32, 4, t.NhanTKY));
                cmd.Parameters.Add(db.CreateParameter("@NhanNHX", System.Data.DbType.Int32, 4, t.NhanNHX));
                cmd.Parameters.Add(db.CreateParameter("@NhanNHY", System.Data.DbType.Int32, 4, t.NhanNHY));
                cmd.Parameters.Add(db.CreateParameter("@NoiDungX", System.Data.DbType.Int32, 4, t.NoiDungX));
                cmd.Parameters.Add(db.CreateParameter("@NoiDungY", System.Data.DbType.Int32, 4, t.NoiDungY));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("UyNhiemChiPrintDAL", "Update(UyNhiemChiPrint t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>
        public override int Delete(UyNhiemChiPrint t)
        {

            return this.Delete(t.SubjectCode);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(string subjectCode)
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
                cmd.CommandText = "usp_UyNhiemChiPrint_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, subjectCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("UyNhiemChiPrintDAL", "Delete(UyNhiemChiPrint t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Returns an object from database by calling Select StoredProcedure
        /// </summary>		
        public UyNhiemChiPrint GetByID(string subjectCode)
        {
            bool alreadyOpen = false;
            UyNhiemChiPrint obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_UyNhiemChiPrint_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, subjectCode));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj = new UyNhiemChiPrint(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("UyNhiemChiPrintDAL", "GetByID(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        #endregion
        #region private methods

        protected override void SetValues()
        {
            _spSelectAll = "usp_UyNhiemChiPrint_SelectAll";
            _spSelectDynamic = "usp_UyNhiemChiPrint_SelectDynamic";
            _spDeleteAll = "usp_UyNhiemChiPrint_DeleteAll";
            _spDeleteDynamic = "usp_UyNhiemChiPrint_DeleteDynamic";
        }

        #endregion
    }
    #endregion
}