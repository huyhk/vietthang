using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class BocxepResultDetail : BaseClass
    {
        public BocxepResultDetail() { }
        public BocxepResultDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ResultID", reader)) resultID = reader.GetGuid(reader.GetOrdinal("ResultID"));
            if (!isNull("TypeCode", reader)) typeCode = reader.GetString(reader.GetOrdinal("TypeCode"));
            if (!isNull("Ngaythuong", reader)) ngaythuong = reader.GetDecimal(reader.GetOrdinal("Ngaythuong"));
            if (!isNull("Ngoaigio", reader)) ngoaigio = reader.GetDecimal(reader.GetOrdinal("Ngoaigio"));
            if (!isNull("Chunhat", reader)) chunhat = reader.GetDecimal(reader.GetOrdinal("Chunhat"));
            if (!isNull("Ngayle", reader)) ngayle = reader.GetDecimal(reader.GetOrdinal("Ngayle"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("ResultDate", reader)) resultDate = reader.GetDateTime(reader.GetOrdinal("ResultDate"));
            if (!isNull("PTVC", reader)) ptvc = reader.GetString(reader.GetOrdinal("PTVC"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("TypeCode")) typeCode = (string)row["TypeCode"];
            if (!row.IsNull("Ngaythuong")) ngaythuong = (decimal)row["Ngaythuong"];
            if (!row.IsNull("Ngoaigio")) ngoaigio = (decimal)row["Ngoaigio"];
            if (!row.IsNull("Chunhat")) chunhat = (decimal)row["Chunhat"];
            if (!row.IsNull("Ngayle")) ngayle = (decimal)row["Ngayle"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("ResultDate")) resultDate = (DateTime)row["ResultDate"];
            if (!row.IsNull("PTVC")) ptvc = (string)row["PTVC"];


        }
        private Guid resultID = Guid.Empty;
        public Guid ResultID
        {
            get { return resultID; }
            set { resultID = value; }
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
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private DateTime resultDate = Contexts.WorkingDate;
        public DateTime ResultDate
        {
            get { return resultDate; }
            set { resultDate = value; }
        }
       
        private String ptvc = string.Empty;
        public string PTVC
        {
            get
            {
                return ptvc;
            }
            set
            {
                ptvc = value;
            }
        }
       
    }
}
