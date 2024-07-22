using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestTransactionDetail : BaseClass
    {
        public ProductTestTransactionDetail() { }
        public ProductTestTransactionDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TestTransactionID", reader)) testTransactionID = reader.GetGuid(reader.GetOrdinal("TestTransactionID"));
            if (!isNull("ProductCode", reader)) productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
            if (!isNull("SizeCode", reader)) sizeCode = reader.GetString(reader.GetOrdinal("SizeCode"));
            if (!isNull("FormulaCode", reader)) formulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("Lot", reader)) lot = reader.GetString(reader.GetOrdinal("Lot"));
            if (!isNull("ItemEncryptCode", reader)) itemEncryptCode = reader.GetString(reader.GetOrdinal("ItemEncryptCode"));
            if (!isNull("NgayCodeBao", reader)) ngayCodeBao = reader.GetDateTime(reader.GetOrdinal("NgayCodeBao"));
        }
        private Guid testTransactionID = Guid.Empty;
        public Guid TestTransactionID
        {
            get { return testTransactionID; }
            set { testTransactionID = value; }
        }
        private string productCode = string.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
        private string sizeCode = string.Empty;
        public string SizeCode
        {
            get { return sizeCode; }
            set { sizeCode = value; }
        }
        private string formulaCode = string.Empty;
        public string FormulaCode
        {
            get { return formulaCode; }
            set { formulaCode = value; }
        }
        private string lot = string.Empty;
        public string Lot
        {
            get { return lot; }
            set { lot = value; }
        }
        private string itemEncryptCode = string.Empty;
        public string ItemEncryptCode
        {
            get { return itemEncryptCode; }
            set { itemEncryptCode = value; }
        }
        private DateTime ngayCodeBao = DateTime.Today;
        public DateTime NgayCodeBao
        {
            get { return ngayCodeBao; }
            set { ngayCodeBao = value; }
        }
        private ListBase<ProductTestTransactionResult> resultDetail = new ListBase<ProductTestTransactionResult>();
        public ListBase<ProductTestTransactionResult> ResultDetail
        {
            get { return resultDetail; }
            set { resultDetail = value; }
        }
        private ListBase<ProductTestTransactionRequest> requestDetail = new ListBase<ProductTestTransactionRequest>();
        public ListBase<ProductTestTransactionRequest> RequestDetail
        {
            get { return requestDetail; }
            set { requestDetail = value; }
        }
    }
}
