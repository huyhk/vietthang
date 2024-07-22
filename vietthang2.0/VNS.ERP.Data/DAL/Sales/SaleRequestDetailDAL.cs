using System.Data.Common;
using VNS.Common;
using System;

using VNS.Data.DAL;
using VNS.Utils;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    class SaleRequestDetailDAL : StockBaseDAL<SaleRequestDetails>
    {
        public SaleRequestDetailDAL()
        {}
        public SaleRequestDetailDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_SaleRequestDetails_Select_All";
        }

        /// <summary>
        /// insert a SaleRequestDetails object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(SaleRequestDetails t)
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
                cmd.CommandText = "usp_SaleRequestDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestID", System.Data.DbType.Guid, 16, t.SaleRequestID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@QuantityReq", System.Data.DbType.Decimal, 9, t.QuantityReq));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@SalePrice", System.Data.DbType.Decimal, 9, t.SalePrice));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
            
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestDetailDAL", "Insert(SaleRequestDetails t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
       
        /// <summary>
        /// delete a SaleRequestDetails object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(SaleRequestDetails t)
        {
            return Delete(t.SaleRequestID);
        }
        /// <summary>
        /// Delete a SaleRequestDetails  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="_Maloai"></param>
        /// <returns></returns>
        public int Delete(Guid _SaleRequestID)
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
                cmd.CommandText = "usp_SaleRequestDetails_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestID", System.Data.DbType.Guid, 16, _SaleRequestID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SaleRequestDetailDAL", "Delete(Guid _SaleRequestID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<SaleRequestDetails> GetSaleRequestDetailByID(Guid _SaleRequestID)
        {
            bool alreadyOpen = false;
            ListBase<SaleRequestDetails> lobj = new ListBase<SaleRequestDetails>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_SaleRequestDetails_Select_SaleRequestID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestID", System.Data.DbType.Guid, 16, _SaleRequestID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    SaleRequestDetails obj = new SaleRequestDetails(reader);
                    lobj.Add(obj);
                }

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("SaleRequestDetailDAL", "GetSaleRequestDetailByID(Guid _SaleRequestID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public DataSet GetSaleRequestDetailByIsFinished_ID(string customerOrderNo,bool isFinished)
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
                cmd.CommandText = "usp_SaleRequestDetails_Select_ByIsFinished";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CustomerOrderNo", System.Data.DbType.String, 20, customerOrderNo));
                cmd.Parameters.Add(db.CreateParameter("@IsFinished", System.Data.DbType.Boolean,1,  isFinished));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation = ds.Relations.Add("SaleRequests",
                   ds.Tables[0].Columns["ItemCode"],
                   ds.Tables[1].Columns["ItemCode"]);


            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("SaleRequestDetailDAL", "GetSaleRequestDetailByID(Guid saleRequestID,bool isFinished)", excp.Message);
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
