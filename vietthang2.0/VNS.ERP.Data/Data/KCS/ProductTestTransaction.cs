using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestTransaction : UserTracking2
    {
        public static DataTable StructTableDetail = null;
        public ProductTestTransaction() { }
        public ProductTestTransaction(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TestTransactionID", reader)) testTransactionID = reader.GetGuid(reader.GetOrdinal("TestTransactionID"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("TransactionDate", reader)) transactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
            if (!isNull("Shift", reader)) shift = reader.GetByte(reader.GetOrdinal("Shift"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("Nguoikiem", reader)) nguoikiem = reader.GetString(reader.GetOrdinal("Nguoikiem"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("TestTransactionID")) testTransactionID = (Guid)row["TestTransactionID"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("TransactionDate")) transactionDate = (DateTime)row["TransactionDate"];
            if (!row.IsNull("Shift")) shift = (byte)row["Shift"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("Nguoikiem")) nguoikiem = (string)row["Nguoikiem"];
        }
        private Guid testTransactionID = Guid.Empty;
        public Guid TestTransactionID
        {
            get { return testTransactionID; }
            set { testTransactionID = value; }
        }
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private DateTime transactionDate = Contexts.WorkingDate;
        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
        private byte shift = 1;
        public byte Shift
        {
            get { return shift; }
            set { shift = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string nguoikiem = string.Empty;
        public string Nguoikiem
        {
            get { return nguoikiem; }
            set { nguoikiem = value; }
        }

        private DataTable tableDetail = null;
        public DataTable TableDetail
        {
            get { return tableDetail; }
            set { tableDetail = value; }
        }
        private ListBase<ProductTestTransactionDetail> detail = new ListBase<ProductTestTransactionDetail>();
        public ListBase<ProductTestTransactionDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        //private string tester = string.Empty;

        //public string Tester
        //{
        //    get { return tester; }
        //    set { tester = value; }
        //}
	

    }
}
