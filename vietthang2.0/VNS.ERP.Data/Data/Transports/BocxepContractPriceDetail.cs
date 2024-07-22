using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class BocxepContractPriceDetail : BaseClass
    {
        public BocxepContractPriceDetail() { }
        public BocxepContractPriceDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PriceID", reader)) priceID = reader.GetGuid(reader.GetOrdinal("PriceID"));
            if (!isNull("TypeCode", reader)) typeCode = reader.GetString(reader.GetOrdinal("TypeCode"));
            if (!isNull("Ngaythuong", reader)) ngaythuong = reader.GetDecimal(reader.GetOrdinal("Ngaythuong"));
            if (!isNull("Ngoaigio", reader)) ngoaigio = reader.GetDecimal(reader.GetOrdinal("Ngoaigio"));
            if (!isNull("Chunhat", reader)) chunhat = reader.GetDecimal(reader.GetOrdinal("Chunhat"));
            if (!isNull("Ngayle", reader)) ngayle = reader.GetDecimal(reader.GetOrdinal("Ngayle"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("TypeCode")) typeCode = (string)row["TypeCode"];
            if (!row.IsNull("Ngaythuong")) ngaythuong = (decimal)row["Ngaythuong"];
            if (!row.IsNull("Ngoaigio")) ngoaigio = (decimal)row["Ngoaigio"];
            if (!row.IsNull("Chunhat")) chunhat = (decimal)row["Chunhat"];
            if (!row.IsNull("Ngayle")) ngayle = (decimal)row["Ngayle"];
        }
        private Guid priceID = Guid.Empty;
        public Guid PriceID
        {
            get { return priceID; }
            set { priceID = value; }
        }
        private string typeCode = string.Empty;
        public string TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }
        private decimal ngaythuong = 0;
        public decimal Ngaythuong
        {
            get { return ngaythuong; }
            set { ngaythuong = value; }
        }
        private decimal ngoaigio = 0;
        public decimal Ngoaigio
        {
            get { return ngoaigio; }
            set { ngoaigio = value; }
        }
        private decimal chunhat = 0;
        public decimal Chunhat
        {
            get { return chunhat; }
            set { chunhat = value; }
        }
        private decimal ngayle = 0;
        public decimal Ngayle
        {
            get { return ngayle; }
            set { ngayle = value; }
        }
    }
}
