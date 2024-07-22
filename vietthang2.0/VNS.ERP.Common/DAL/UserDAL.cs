using System;
using System.Collections.Generic;
using System.Text;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;
namespace VNS.ERP.Common
{
    class UserDAL : ERPBaseDAL<UserERP>
    {
           public UserDAL()
        {}
        public UserDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_Users_Select_All";
        }

        /// <summary>
        /// insert a Users object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(UserERP  t)
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
                cmd.CommandText = "usp_Users_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@LoginName", System.Data.DbType.String, 20, t.LoginName));
                cmd.Parameters.Add(db.CreateParameter("@Password", System.Data.DbType.String, 50, t.Password));
                cmd.Parameters.Add(db.CreateParameter("@IsAdmin", System.Data.DbType.Boolean, 1, t.IsAdmin));
                cmd.Parameters.Add(db.CreateParameter("@UserName", System.Data.DbType.String,50, t.UserName));
                cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, t.EmployeeID));
               
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    t.ID = (int)cmd.Parameters["@MaterialCodeOutput"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("UserDAL", "Insert(Users t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a Users object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(UserERP  t)
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
                cmd.CommandText = "usp_Users_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@LoginName", System.Data.DbType.String, 20, t.LoginName));
                if (t.Password != null)
                    cmd.Parameters.Add(db.CreateParameter("@Password", System.Data.DbType.String, 50, t.Password));
                else
                    cmd.Parameters.Add(db.CreateParameter("@Password", System.Data.DbType.String, 50, DBNull.Value));
                cmd.Parameters.Add(db.CreateParameter("@IsAdmin", System.Data.DbType.Boolean, 1, t.IsAdmin));
                cmd.Parameters.Add(db.CreateParameter("@UserName", System.Data.DbType.String, 50, t.UserName));
                if (t.EmployeeID != null)
                    cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, t.EmployeeID));
                else
                    cmd.Parameters.Add(db.CreateParameter("@EmployeeID", System.Data.DbType.String, 10, DBNull.Value));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("UserDAL", "Update(Users t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a Users object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(UserERP  t)
        {
            return Delete(t.LoginName );
        }
        /// <summary>
        /// Delete a Nhaphang object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(string  _LoginName)
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
                cmd.CommandText = "usp_Users_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@LoginName", System.Data.DbType.String, 20, _LoginName));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("UserDAL", "Delete(string _LoginName)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public UserERP GetByLoginName(string  _LoginName)
        {
            bool alreadyOpen = false;
            UserERP obj = new UserERP();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_User_select_loginName";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@LoginName", System.Data.DbType.String, 20, _LoginName));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj.FromDataReader(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VendorDAL", "GetByID(int _VendorID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
    }
}
