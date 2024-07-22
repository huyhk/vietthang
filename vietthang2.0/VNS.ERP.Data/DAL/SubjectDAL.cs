using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data
{
    public class SubjectDAL<T> : BaseDAL<T>
        where T : Subject, new()
    {
        public SubjectDAL()
        { }
        public SubjectDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_Subjects_Select_All";
            _spSelectDynamic = "usp_Subjects_SelectDynamic";
        }

        public override int Insert(T t)
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
                cmd.CommandText = "usp_Subjects_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@SubjectName", System.Data.DbType.String, 100, t.SubjectName));
                cmd.Parameters.Add(db.CreateParameter("@SubjectTypeCode", System.Data.DbType.String, 10, t.SubjectTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Address", System.Data.DbType.String, 100, t.Address));
                cmd.Parameters.Add(db.CreateParameter("@Phone", System.Data.DbType.String, 20, t.Phone));
                cmd.Parameters.Add(db.CreateParameter("@Fax", System.Data.DbType.String, 20, t.Fax));
                cmd.Parameters.Add(db.CreateParameter("@TaxCode", System.Data.DbType.String, 20, t.TaxCode));
                cmd.Parameters.Add(db.CreateParameter("@BankName", System.Data.DbType.String, 50, t.BankName));
                cmd.Parameters.Add(db.CreateParameter("@BankAccountNo", System.Data.DbType.String, 20, t.BankAccountNo));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@SoHieu", System.Data.DbType.String, 20, t.SoHieu));
                if (t.BranchCode == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("SubjectDAL", "Insert(T t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public override int Update(T t)
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
                cmd.CommandText = "usp_Subjects_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@SubjectName", System.Data.DbType.String, 100, t.SubjectName));
                //cmd.Parameters.Add(db.CreateParameter("@SubjectType", System.Data.DbType.Byte, 1, t.SubjectType));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Address", System.Data.DbType.String, 100, t.Address));
                cmd.Parameters.Add(db.CreateParameter("@Phone", System.Data.DbType.String, 20, t.Phone));
                cmd.Parameters.Add(db.CreateParameter("@Fax", System.Data.DbType.String, 20, t.Fax));
                cmd.Parameters.Add(db.CreateParameter("@TaxCode", System.Data.DbType.String, 20, t.TaxCode));
                cmd.Parameters.Add(db.CreateParameter("@BankName", System.Data.DbType.String, 50, t.BankName));
                cmd.Parameters.Add(db.CreateParameter("@BankAccountNo", System.Data.DbType.String, 20, t.BankAccountNo));
                cmd.Parameters.Add(db.CreateParameter("@SoHieu", System.Data.DbType.String, 20, t.SoHieu));
                if(t.BranchCode==string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("SubjectDAL", "Update(T t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public override int Delete(T t)
        {
            return Delete(t.SubjectCode);
        }

        public int Delete(string _subjectCode)
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
                cmd.CommandText = "usp_Subjects_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, _subjectCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("SubjectDAL", "Delete(string _subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int InsertUpdateProperty(string _subjectCode, byte _propertyID, string _propertyValue)
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
                cmd.CommandText = "usp_SubjectProperties_InsertUpdate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, _subjectCode));
                cmd.Parameters.Add(db.CreateParameter("@PropertyID", System.Data.DbType.Byte, 2, _propertyID));
                if (_propertyValue != null)
                    cmd.Parameters.Add(db.CreateParameter("@PropertyValue", System.Data.DbType.String, 100, _propertyValue));
                else
                    cmd.Parameters.Add(db.CreateParameter("@PropertyValue", System.Data.DbType.String, 100, DBNull.Value));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("SubjectDAL", "InsertUpdateProperty(string _memberID, byte _propertyID,string _propertyValue)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public System.Data.DataTable GetAll()
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Subjects_Select_All";
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SubjectDAL", "GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public ListBase<Subject> GetListBaseSubjectOutSide()
        {
            ListBase<Subject> lst = new ListBase<Subject>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader read = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Subject_Select_SubjectsOutSide";
                read = db.ExecuteReader(cmd);
                while (read.Read())
                {
                    Subject obj = new Subject(read);
                    lst.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SubjectDAL", " GetListBaseSubjectOutSide()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return lst;
        }

        public DataTable GetSubjectOutSide()
        {
           DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Subject_Select_SubjectsOutSide";
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SubjectDAL", " GetSubjectOutSide()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public ListBase<T> GetObjectByType(string _subjectType)
        {
            ListBase<T> oListBase = new ListBase<T>();
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Subjects_Select_Type";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@Type", System.Data.DbType.String, 10, _subjectType));

                //oDR = db.ExecuteReader(cmd);
                //while (oDR.Read())
                //{
                //    T obj = new T();
                //    obj.FromDataReader(oDR);
                //    oListBase.Add(obj);
                //}
                //if (oDR.NextResult())
                //{
                //    while (oDR.Read())
                //    {
                //        SubjectProperty sp = new SubjectProperty(oDR);
                //        T t = oListBase.Search("SubjectCode", sp.SubjectCode);
                //        if (t.Properties.Length > sp.PropertyID)
                //            t.Properties[sp.PropertyID] = sp.PropertyValue;
                //    }
                //}
                //oDR.Close();
                DataSet ds = db.ExecuteDataSet(cmd);
                DataRelation dr = new DataRelation("SubjectCode", ds.Tables[0].Columns["SubjectCode"], ds.Tables[1].Columns["SubjectCode"]);
                ds.Relations.Add(dr);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    T obj = new T();
                    obj.FromDataRow(row);
                    oListBase.Add(obj);
                    foreach (DataRow rowD in row.GetChildRows(dr))
                    {
                        SubjectProperty sp = new SubjectProperty(rowD);
                        if (obj.Properties.Length > sp.PropertyID)
                            obj.Properties[sp.PropertyID] = sp.PropertyValue;
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SubjectDAL", "GetObjectByType(byte _subjectType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return oListBase;
        }
        public ListBase<T> GetObjectCustomer(string productType)
        {
            ListBase<T> oListBase = new ListBase<T>();
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Subjects_Select_Customer";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));

                //oDR = db.ExecuteReader(cmd);
                //while (oDR.Read())
                //{
                //    T obj = new T();
                //    obj.FromDataReader(oDR);
                //    oListBase.Add(obj);
                //}
                //if (oDR.NextResult())
                //{
                //    while (oDR.Read())
                //    {
                //        SubjectProperty sp = new SubjectProperty(oDR);
                //        T t = oListBase.Search("SubjectCode", sp.SubjectCode);
                //        if (t.Properties.Length > sp.PropertyID)
                //            t.Properties[sp.PropertyID] = sp.PropertyValue;
                //    }
                //}
                //oDR.Close();
                DataSet ds = db.ExecuteDataSet(cmd);
                DataRelation dr = new DataRelation("SubjectCode", ds.Tables[0].Columns["SubjectCode"], ds.Tables[1].Columns["SubjectCode"]);
                ds.Relations.Add(dr);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    T obj = new T();
                    obj.FromDataRow(row);
                    oListBase.Add(obj);
                    foreach (DataRow rowD in row.GetChildRows(dr))
                    {
                        SubjectProperty sp = new SubjectProperty(rowD);
                        if (obj.Properties.Length > sp.PropertyID)
                            obj.Properties[sp.PropertyID] = sp.PropertyValue;
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SubjectDAL", "GetObjectCustomer(byte _subjectType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return oListBase;
        }
        public ListBase<T> GetObjectByTypeAndMemberID(string subjectType,string memberID)
        {
            ListBase<T> oListBase = new ListBase<T>();
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Subjects_SelectAll_By_Type_MemberID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@Type", System.Data.DbType.String, 10, subjectType));
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, memberID));
                //oDR = db.ExecuteReader(cmd);
                //while (oDR.Read())
                //{
                //    T obj = new T();
                //    obj.FromDataReader(oDR);
                //    oListBase.Add(obj);
                //}
                //if (oDR.NextResult())
                //{
                //    while (oDR.Read())
                //    {
                //        SubjectProperty sp = new SubjectProperty(oDR); ;
                //        oListBase.Search("SubjectCode", sp.SubjectCode).Properties[sp.PropertyID] = sp.PropertyValue;
                //    }
                //}
                //oDR.Close();
                DataSet ds = db.ExecuteDataSet(cmd);
                DataRelation dr = new DataRelation("SubjectCode", ds.Tables[0].Columns["SubjectCode"], ds.Tables[1].Columns["SubjectCode"]);
                ds.Relations.Add(dr);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    T obj = new T();
                    obj.FromDataRow(row);
                    oListBase.Add(obj);
                    foreach (DataRow rowD in row.GetChildRows(dr))
                    {
                        SubjectProperty sp = new SubjectProperty(rowD);
                        if (obj.Properties.Length > sp.PropertyID)
                            obj.Properties[sp.PropertyID] = sp.PropertyValue;
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SubjectDAL", "GetObjectByTypeAndMemberID(string subjectType,string memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return oListBase;
        }

        public T GetBySubjectCode(string subjectCode)
        {
            T obj = null;
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Subject_Select_By_SubjectCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));

                oDR = db.ExecuteReader(cmd);
                if (oDR.Read())
                {
                    obj = new T();
                    obj.FromDataReader(oDR);
                    if (oDR.NextResult())
                    {
                        while (oDR.Read())
                        {
                            SubjectProperty sp = new SubjectProperty(oDR);
                            if (obj.Properties.Length > sp.PropertyID)
                                obj.Properties[sp.PropertyID] = sp.PropertyValue;
                        }
                    }
                }
                oDR.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("SubjectDAL", "GetBySubjectCode(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
    }

    public class CustomerDAL : SubjectDAL<Customer>
    {
        public System.Data.DataTable ReportDiscount(DateTime startDate, DateTime endDate)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Customer_Report_Discount";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerDAL", "ReportDiscount(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public System.Data.DataTable ReportDiscountDetail(DateTime startDate, DateTime endDate)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Customer_Report_Discount_Detail";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerDAL", "ReportDiscountDetail(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
    }

    public class VendorDAL : SubjectDAL<Vendor>
    { }

    //public class TransportDAL : SubjectDAL<Transport>
    //{ }
    public class BankDAL : SubjectDAL<Bank>
    { }

    public class CashDAL : SubjectDAL<Cash>
    { }

    public class FixedAssetDAL : SubjectDAL<FixedAsset>
    { }
    public class BranchDAL : SubjectDAL<Branch>
    { }

    public class AdPaymentDAL : SubjectDAL<AdPayment>
    { }
}
