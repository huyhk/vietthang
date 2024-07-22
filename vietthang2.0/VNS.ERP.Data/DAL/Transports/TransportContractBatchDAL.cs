using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data
{
    #region TransportContractBatchDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of TransportContractBatch.
    /// </summary>
    public class TransportContractBatchDAL : BaseDAL<TransportContractBatch>
    {
        public TransportContractBatchDAL()
        {
        }
        public TransportContractBatchDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(TransportContractBatch t)
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
                cmd.CommandText = "usp_TransportContractBatch_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@BatchID", System.Data.DbType.Guid, 16, t.BatchID));
                cmd.Parameters.Add(db.CreateParameter("@BillNo", System.Data.DbType.String, 20, t.BillNo));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@ContQuantity", System.Data.DbType.Int32, 4, t.ContQuantity));
                cmd.Parameters.Add(db.CreateParameter("@ContDes", System.Data.DbType.String, 20, t.ContDes));
                cmd.Parameters.Add(db.CreateParameter("@DonViGN", System.Data.DbType.AnsiString, 10, t.DonViGN));
                cmd.Parameters.Add(db.CreateParameter("@TokhaiHQNo", System.Data.DbType.String, 20, t.TokhaiHQNo));
                cmd.Parameters.Add(db.CreateParameter("@PortName", System.Data.DbType.String, 50, t.PortName));
                cmd.Parameters.Add(db.CreateParameter("@VendorCode", System.Data.DbType.AnsiString, 10, t.VendorCode));
                cmd.Parameters.Add(db.CreateParameter("@Hangtau", System.Data.DbType.String, 50, t.Hangtau));
                cmd.Parameters.Add(db.CreateParameter("@Noigiaohang", System.Data.DbType.String, 50, t.Noigiaohang));
                cmd.Parameters.Add(db.CreateParameter("@Thongbaotauden", System.Data.DbType.DateTime, 8, t.Thongbaotauden));
                cmd.Parameters.Add(db.CreateParameter("@NhanBCTtuBank", System.Data.DbType.DateTime, 8, t.NhanBCTtuBank));
                if (t.BCTvetoiBank != DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@BCTvetoiBank", System.Data.DbType.DateTime, 8, t.BCTvetoiBank));
                if (t.BankgiaoBCT != DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@BankgiaoBCT", System.Data.DbType.DateTime, 8, t.BankgiaoBCT));
                cmd.Parameters.Add(db.CreateParameter("@GiaoBCTchoDV", System.Data.DbType.DateTime, 8, t.GiaoBCTchoDV));
                cmd.Parameters.Add(db.CreateParameter("@MotokhaiHQ", System.Data.DbType.DateTime, 8, t.MotokhaiHQ));
                cmd.Parameters.Add(db.CreateParameter("@BatdaunhanCont", System.Data.DbType.DateTime, 8, t.BatdaunhanCont));
                cmd.Parameters.Add(db.CreateParameter("@KetthucnhanCont", System.Data.DbType.DateTime, 8, t.KetthucnhanCont));
                cmd.Parameters.Add(db.CreateParameter("@HethanluuConttaibai", System.Data.DbType.DateTime, 8, t.HethanluuConttaibai));
                cmd.Parameters.Add(db.CreateParameter("@Hethanluubai", System.Data.DbType.DateTime, 8, t.Hethanluubai));
                cmd.Parameters.Add(db.CreateParameter("@Hethanluukhorieng", System.Data.DbType.DateTime, 8, t.Hethanluukhorieng));
                cmd.Parameters.Add(db.CreateParameter("@Ngaydangtainhamay", System.Data.DbType.DateTime, 8, t.Ngaydangtainhamay));
                cmd.Parameters.Add(db.CreateParameter("@Ngaynhapxong", System.Data.DbType.DateTime, 8, t.Ngaynhapxong));
                cmd.Parameters.Add(db.CreateParameter("@Ngaytrarong", System.Data.DbType.DateTime, 8, t.Ngaytrarong));
                cmd.Parameters.Add(db.CreateParameter("@Sobao", System.Data.DbType.Int32, 4, t.Sobao));
                cmd.Parameters.Add(db.CreateParameter("@SoluongBLNet", System.Data.DbType.Decimal, 9, t.SoluongBLNet));
                cmd.Parameters.Add(db.CreateParameter("@GiakhaiHQ", System.Data.DbType.Decimal, 9, t.GiakhaiHQ));
                cmd.Parameters.Add(db.CreateParameter("@TygiaNH", System.Data.DbType.Decimal, 9, t.TygiaNH));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@PriceVC", System.Data.DbType.Decimal, 9, t.PriceVC));
                cmd.Parameters.Add(db.CreateParameter("@PriceKQ", System.Data.DbType.Decimal, 9, t.PriceKQ));
                cmd.Parameters.Add(db.CreateParameter("@IsRutruot", System.Data.DbType.Boolean, 1, t.IsRutruot));

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
                Write2Log.WriteLogs("TransportContractBatchDAL", "Insert(TransportContractBatch t)", excp.Message);
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
        public override int Update(TransportContractBatch t)
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
                cmd.CommandText = "usp_TransportContractBatch_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@BatchID", System.Data.DbType.Guid, 16, t.BatchID));
                cmd.Parameters.Add(db.CreateParameter("@BillNo", System.Data.DbType.String, 20, t.BillNo));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@ContQuantity", System.Data.DbType.Int32, 4, t.ContQuantity));
                cmd.Parameters.Add(db.CreateParameter("@ContDes", System.Data.DbType.String, 20, t.ContDes));
                cmd.Parameters.Add(db.CreateParameter("@DonViGN", System.Data.DbType.AnsiString, 10, t.DonViGN));
                cmd.Parameters.Add(db.CreateParameter("@TokhaiHQNo", System.Data.DbType.String, 20, t.TokhaiHQNo));
                cmd.Parameters.Add(db.CreateParameter("@PortName", System.Data.DbType.String, 50, t.PortName));
                cmd.Parameters.Add(db.CreateParameter("@VendorCode", System.Data.DbType.AnsiString, 10, t.VendorCode));
                cmd.Parameters.Add(db.CreateParameter("@Hangtau", System.Data.DbType.String, 50, t.Hangtau));
                cmd.Parameters.Add(db.CreateParameter("@Noigiaohang", System.Data.DbType.String, 50, t.Noigiaohang));
                cmd.Parameters.Add(db.CreateParameter("@Thongbaotauden", System.Data.DbType.DateTime, 8, t.Thongbaotauden));
                cmd.Parameters.Add(db.CreateParameter("@NhanBCTtuBank", System.Data.DbType.DateTime, 8, t.NhanBCTtuBank));
                if (t.BCTvetoiBank != DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@BCTvetoiBank", System.Data.DbType.DateTime, 8, t.BCTvetoiBank));
                if (t.BankgiaoBCT != DateTime.MinValue)
                    cmd.Parameters.Add(db.CreateParameter("@BankgiaoBCT", System.Data.DbType.DateTime, 8, t.BankgiaoBCT));
                cmd.Parameters.Add(db.CreateParameter("@GiaoBCTchoDV", System.Data.DbType.DateTime, 8, t.GiaoBCTchoDV));
                cmd.Parameters.Add(db.CreateParameter("@MotokhaiHQ", System.Data.DbType.DateTime, 8, t.MotokhaiHQ));
                cmd.Parameters.Add(db.CreateParameter("@BatdaunhanCont", System.Data.DbType.DateTime, 8, t.BatdaunhanCont));
                cmd.Parameters.Add(db.CreateParameter("@KetthucnhanCont", System.Data.DbType.DateTime, 8, t.KetthucnhanCont));
                cmd.Parameters.Add(db.CreateParameter("@HethanluuConttaibai", System.Data.DbType.DateTime, 8, t.HethanluuConttaibai));
                cmd.Parameters.Add(db.CreateParameter("@Hethanluubai", System.Data.DbType.DateTime, 8, t.Hethanluubai));
                cmd.Parameters.Add(db.CreateParameter("@Hethanluukhorieng", System.Data.DbType.DateTime, 8, t.Hethanluukhorieng));
                cmd.Parameters.Add(db.CreateParameter("@Ngaydangtainhamay", System.Data.DbType.DateTime, 8, t.Ngaydangtainhamay));
                cmd.Parameters.Add(db.CreateParameter("@Ngaynhapxong", System.Data.DbType.DateTime, 8, t.Ngaynhapxong));
                cmd.Parameters.Add(db.CreateParameter("@Ngaytrarong", System.Data.DbType.DateTime, 8, t.Ngaytrarong));
                cmd.Parameters.Add(db.CreateParameter("@Sobao", System.Data.DbType.Int32, 4, t.Sobao));
                cmd.Parameters.Add(db.CreateParameter("@SoluongBLNet", System.Data.DbType.Decimal, 9, t.SoluongBLNet));
                cmd.Parameters.Add(db.CreateParameter("@GiakhaiHQ", System.Data.DbType.Decimal, 9, t.GiakhaiHQ));
                cmd.Parameters.Add(db.CreateParameter("@TygiaNH", System.Data.DbType.Decimal, 9, t.TygiaNH));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@PriceVC", System.Data.DbType.Decimal, 9, t.PriceVC));
                cmd.Parameters.Add(db.CreateParameter("@PriceKQ", System.Data.DbType.Decimal, 9, t.PriceKQ));
                cmd.Parameters.Add(db.CreateParameter("@IsRutruot", System.Data.DbType.Boolean, 1, t.IsRutruot));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractBatchDAL", "Update(TransportContractBatch t)", excp.Message);
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
        public override int Delete(TransportContractBatch t)
        {

            return this.Delete(t.BatchID);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid batchID)
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
                cmd.CommandText = "usp_TransportContractBatch_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@BatchID", System.Data.DbType.Guid, 16, batchID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractBatchDAL", "Delete(TransportContractBatch t)", excp.Message);
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
        public TransportContractBatch GetByID(Guid batchID)
        {
            bool alreadyOpen = false;
            TransportContractBatch obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractBatch_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@BatchID", System.Data.DbType.Guid, 16, batchID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj = new TransportContractBatch(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportContractBatchDAL", "GetByID(Guid batchID)", excp.Message);
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
            _spSelectAll = "usp_TransportContractBatch_SelectAll";
            _spSelectDynamic = "usp_TransportContractBatch_SelectDynamic";
            _spDeleteAll = "usp_TransportContractBatch_DeleteAll";
            _spDeleteDynamic = "usp_TransportContractBatch_DeleteDynamic";
        }

        #endregion

        public ListBase<TransportContractBatch> GetByContractNo(string contractNo)
        {
            bool alreadyOpen = false;
            ListBase<TransportContractBatch> lst = new ListBase<TransportContractBatch>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContractBatch_GetByContractNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, contractNo));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                    lst.Add(new TransportContractBatch(reader));
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportContractBatchDAL", "GetByContractNo(string contractNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lst;
        }
    }
    #endregion
}