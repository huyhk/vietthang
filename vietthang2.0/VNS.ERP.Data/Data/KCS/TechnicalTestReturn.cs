using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class TechnicalTestReturn : UserTracking2
    {
        public static DataTable StructMaterialDetailTable = null;
        public static DataTable StructProductDetailTable = null;
        public TechnicalTestReturn() { }
        public TechnicalTestReturn(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ReturnID", reader)) returnID = reader.GetGuid(reader.GetOrdinal("ReturnID"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("ReturnDate", reader)) returnDate = reader.GetDateTime(reader.GetOrdinal("ReturnDate"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("IsReceived", reader)) isReceived = reader.GetBoolean(reader.GetOrdinal("IsReceived"));
            if (!isNull("UserReceived", reader)) userReceived = reader.GetString(reader.GetOrdinal("UserReceived"));
            if (!isNull("DateReceived", reader)) dateReceived = reader.GetDateTime(reader.GetOrdinal("DateReceived"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ReturnID")) returnID = (Guid)row["ReturnID"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("ReturnDate")) returnDate = (DateTime)row["ReturnDate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("IsReceived")) isReceived = (bool)row["IsReceived"];
            if (!row.IsNull("UserReceived")) userReceived = (string)row["UserReceived"];
            if (!row.IsNull("DateReceived")) dateReceived = (DateTime)row["DateReceived"];
        }
        public void RefreshDetail()
        {
            this.Detail.Clear();
            foreach (DataRow dr in this.MaterialDetailTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();
                string result = dr["Result"].ToString();

                TechnicalTestReturnDetail detail = new TechnicalTestReturnDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.Result = result;
                detail.IsProduct = false;
                this.Detail.Add(detail);
            }
            foreach (DataRow dr in this.ProductDetailTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();
                string result = dr["Result"].ToString();

                TechnicalTestReturnDetail detail = new TechnicalTestReturnDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.Result = result;
                detail.IsProduct = true;
                this.Detail.Add(detail);
            }
        }
        private Guid returnID = Guid.Empty;
        public Guid ReturnID
        {
            get { return returnID; }
            set { returnID = value; }
        }

        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private DateTime returnDate = Contexts.WorkingDate;
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private bool isReceived = false;
        public bool IsReceived
        {
            get { return isReceived; }
            set { isReceived = value; }
        }
        private string userReceived = string.Empty;
        public string UserReceived
        {
            get { return userReceived; }
            set { userReceived = value; }
        }
        private DateTime dateReceived = Contexts.WorkingDate;
        public DateTime DateReceived
        {
            get { return dateReceived; }
            set { dateReceived = value; }
        }
        private ListBase<TechnicalTestReturnDetail> detail = new ListBase<TechnicalTestReturnDetail>();
        public ListBase<TechnicalTestReturnDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private DataTable materialDetailTable = null;
        public DataTable MaterialDetailTable
        {
            get { return materialDetailTable; }
            set { materialDetailTable = value; }
        }
        private DataTable productDetailTable = null;
        public DataTable ProductDetailTable
        {
            get { return productDetailTable; }
            set { productDetailTable = value; }
        }

        private string infaUser = string.Empty;

        public string InfaUser
        {
            get { return infaUser; }
            set { infaUser = value; }
        }

	
    }
}
