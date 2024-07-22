using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region VesselInsuranceContract
    /// <summary>
    /// This object represents the properties and methods of a VesselInsuranceContract.
    /// </summary>
    public class VesselInsuranceContract : UserTracking2
    {


        public VesselInsuranceContract()
        {
        }

        public VesselInsuranceContract(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    contractID = (obj as VesselInsuranceContract).contractID;
        //    contractNo = (obj as VesselInsuranceContract).contractNo;
        //    contractDate = (obj as VesselInsuranceContract).contractDate;
        //    insuranceSubjectCode = (obj as VesselInsuranceContract).insuranceSubjectCode;
        //    vesselTransactionNo = (obj as VesselInsuranceContract).vesselTransactionNo;
        //    insuranceAmount = (obj as VesselInsuranceContract).insuranceAmount;
        //    lostAllow = (obj as VesselInsuranceContract).lostAllow;
        //    compensationPrice = (obj as VesselInsuranceContract).compensationPrice;
        //    currencyCode = (obj as VesselInsuranceContract).currencyCode;
        //    description = (obj as VesselInsuranceContract).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
                if (!isNull("ContractNo", reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
                if (!isNull("ContractDate", reader)) contractDate = reader.GetDateTime(reader.GetOrdinal("ContractDate"));
                if (!isNull("InsuranceSubjectCode", reader)) insuranceSubjectCode = reader.GetString(reader.GetOrdinal("InsuranceSubjectCode"));
                if (!isNull("VesselTransactionNo", reader)) vesselTransactionNo = reader.GetString(reader.GetOrdinal("VesselTransactionNo"));
                if (!isNull("InsuranceAmount", reader)) insuranceAmount = reader.GetDecimal(reader.GetOrdinal("InsuranceAmount"));
                if (!isNull("LostAllow", reader)) lostAllow = reader.GetDecimal(reader.GetOrdinal("LostAllow"));
                if (!isNull("CompensationPrice", reader)) compensationPrice = reader.GetDecimal(reader.GetOrdinal("CompensationPrice"));
                if (!isNull("CurrencyCode", reader)) currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            base.LoadFromReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
                if (!isNull("ContractNo", reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
                if (!isNull("ContractDate", reader)) contractDate = reader.GetDateTime(reader.GetOrdinal("ContractDate"));
                if (!isNull("InsuranceSubjectCode", reader)) insuranceSubjectCode = reader.GetString(reader.GetOrdinal("InsuranceSubjectCode"));
                if (!isNull("VesselTransactionNo", reader)) vesselTransactionNo = reader.GetString(reader.GetOrdinal("VesselTransactionNo"));
                if (!isNull("InsuranceAmount", reader)) insuranceAmount = reader.GetDecimal(reader.GetOrdinal("InsuranceAmount"));
                if (!isNull("LostAllow", reader)) lostAllow = reader.GetDecimal(reader.GetOrdinal("LostAllow"));
                if (!isNull("CompensationPrice", reader)) compensationPrice = reader.GetDecimal(reader.GetOrdinal("CompensationPrice"));
                if (!isNull("CurrencyCode", reader)) currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
            if (!row.IsNull("ContractDate")) contractDate = (DateTime)row["ContractDate"];
            if (!row.IsNull("InsuranceSubjectCode")) insuranceSubjectCode = (string)row["InsuranceSubjectCode"];
            if (!row.IsNull("VesselTransactionNo")) vesselTransactionNo = (string)row["VesselTransactionNo"];
            if (!row.IsNull("InsuranceAmount")) insuranceAmount = (decimal)row["InsuranceAmount"];
            if (!row.IsNull("LostAllow")) lostAllow = (decimal)row["LostAllow"];
            if (!row.IsNull("CompensationPrice")) compensationPrice = (decimal)row["CompensationPrice"];
            if (!row.IsNull("CurrencyCode")) currencyCode = (string)row["CurrencyCode"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
            if (!row.IsNull("ContractDate")) contractDate = (DateTime)row["ContractDate"];
            if (!row.IsNull("InsuranceSubjectCode")) insuranceSubjectCode = (string)row["InsuranceSubjectCode"];
            if (!row.IsNull("VesselTransactionNo")) vesselTransactionNo = (string)row["VesselTransactionNo"];
            if (!row.IsNull("InsuranceAmount")) insuranceAmount = (decimal)row["InsuranceAmount"];
            if (!row.IsNull("LostAllow")) lostAllow = (decimal)row["LostAllow"];
            if (!row.IsNull("CompensationPrice")) compensationPrice = (decimal)row["CompensationPrice"];
            if (!row.IsNull("CurrencyCode")) currencyCode = (string)row["CurrencyCode"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        #region Public Properties



        private Guid contractID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of ContractID
        /// </summary>
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }

        private string contractNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of ContractNo
        /// </summary>
        public string ContractNo
        {
            get { return contractNo; }
            set { contractNo = value; }
        }

        private DateTime contractDate = Contexts.WorkingDate;
        /// <summary>
        /// Gets or sets the value of ContractDate
        /// </summary>
        public DateTime ContractDate
        {
            get { return contractDate; }
            set { contractDate = value; }
        }

        private string insuranceSubjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of InsuranceSubjectCode
        /// </summary>
        public string InsuranceSubjectCode
        {
            get { return insuranceSubjectCode; }
            set { insuranceSubjectCode = value; }
        }

        private string vesselTransactionNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of VesselTransactionNo
        /// </summary>
        public string VesselTransactionNo
        {
            get { return vesselTransactionNo; }
            set { vesselTransactionNo = value; }
        }

        private decimal insuranceAmount;
        /// <summary>
        /// Gets or sets the value of InsuranceAmount
        /// </summary>
        public decimal InsuranceAmount
        {
            get { return insuranceAmount; }
            set { insuranceAmount = value; }
        }

        private decimal lostAllow;
        /// <summary>
        /// Gets or sets the value of LostAllow
        /// </summary>
        public decimal LostAllow
        {
            get { return lostAllow; }
            set { lostAllow = value; }
        }

        private decimal compensationPrice;
        /// <summary>
        /// Gets or sets the value of CompensationPrice
        /// </summary>
        public decimal CompensationPrice
        {
            get { return compensationPrice; }
            set { compensationPrice = value; }
        }

        private string currencyCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of CurrencyCode
        /// </summary>
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }

        private string description = String.Empty;
        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion

        #region Lists
        #endregion


    }
    #endregion
}
