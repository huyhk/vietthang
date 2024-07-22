using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VNS.Data.DAL;

using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.Sales
{
    class CustomerDiscountListDAL : StockBaseDAL<CustomerDiscountList>
    {
        public CustomerDiscountListDAL()
        { }
        public CustomerDiscountListDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_CustomerDiscountList_SelectAll";
            //base.SetValues();
        }
        public override int Insert(CustomerDiscountList t)
        {
            //Employees Obj = GetByID(t.EmployeeID);
            //if (Obj != null) return -1;
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDiscountList_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                Cmd.Parameters.Add(db.CreateParameter("@DiscountID", System.Data.DbType.Guid, 16, t.DiscountID));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountName", System.Data.DbType.String, 100, t.DiscountName));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountType", System.Data.DbType.String, 10, t.DiscountType));
                Cmd.Parameters.Add(db.CreateParameter("@InActive", System.Data.DbType.Boolean, 1, t.InActive));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDiscountListDAL", "Insert(CustomerDiscountList t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        public override int Update(CustomerDiscountList t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try 
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDiscountList_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@DiscountID", System.Data.DbType.Guid, 16, t.DiscountID));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountType", System.Data.DbType.String, 10, t.DiscountType));
                Cmd.Parameters.Add(db.CreateParameter("@DiscountName", System.Data.DbType.String, 100, t.DiscountName));
                Cmd.Parameters.Add(db.CreateParameter("@InActive", System.Data.DbType.Boolean, 1, t.InActive)); 
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDiscountListDAL", "Update(CustomerDiscountList t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(CustomerDiscountList t)
        {
            return Delete(t.DiscountID);
        }
        public int Delete(Guid discountID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_CustomerDiscountList_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@DiscountID", System.Data.DbType.Guid, 16, discountID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDiscountListDAL", "Delete(Guid discountID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
