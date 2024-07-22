using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;


namespace VNS.ERP.Data
{
    class StockTransportDAL:StockBaseDAL <StockTransport >
    {
        
           public StockTransportDAL()
        {}
        public StockTransportDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_StockTransports_Select_All";
        }

        /// <summary>
        /// insert a StockTransports object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(StockTransport  t)
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
                cmd.CommandText = "usp_StockTransports_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode ));
                cmd.Parameters.Add(db.CreateParameter("@StockTransportCode", System.Data.DbType.String, 10, t.StockTransportCode ));
                cmd.Parameters.Add(db.CreateParameter("@StockTransportName", System.Data.DbType.String, 100, t.StockTransportName ));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String , 200, t.Description ));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal  , 9, t.Weight ));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
               

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
                
                iError=db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //    t.ID = (int)cmd.Parameters["@MaterialCodeOutput"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransportDAL", "Insert(StockTransports t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a StockTransports object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(StockTransport  t)
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
                cmd.CommandText = "usp_StockTransports_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransportCode", System.Data.DbType.String, 10, t.StockTransportCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransportName", System.Data.DbType.String, 100, t.StockTransportName));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@Weight", System.Data.DbType.Decimal , 9, t.Weight));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransportDAL", "Update(StockTransports t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a StockTransports object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(StockTransport  t)
        {
            return Delete(t.StockCode ,t.StockTransportCode  );
        }
        /// <summary>
        /// Delete a Nhaphang object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(string _StockCode, string _StockTransportCode)
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
                cmd.CommandText = "usp_StockTransports_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransportCode", System.Data.DbType.String, 10, _StockTransportCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransportDAL", "Delete(int _MaterialCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<StockTransport> GetAll(string _StockCode)
        {
            bool alreadyOpen = false;
            ListBase<StockTransport> lobj = new ListBase<StockTransport>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransports_Select_All";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String , 10, _StockCode ));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransport obj = new StockTransport(reader);
                    lobj.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransportDAL", "GetByItemType(int _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
    }
}
