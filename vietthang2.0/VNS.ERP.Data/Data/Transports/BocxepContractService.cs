using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region BocxepContractService
    /// <summary>
    /// This object represents the properties and methods of a BocxepContractService.
    /// </summary>
    public class BocxepContractService : UserTracking2
    {


        public BocxepContractService()
        {
        }

        public BocxepContractService(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public BocxepContractService(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    contractID = (obj as BocxepContractService).contractID;
        //    serviceID = (obj as BocxepContractService).serviceID;
        //    serviceName = (obj as BocxepContractService).serviceName;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
                if (!isNull("ServiceID", reader)) serviceID = reader.GetGuid(reader.GetOrdinal("ServiceID"));
                if (!isNull("ServiceName", reader)) serviceName = reader.GetString(reader.GetOrdinal("ServiceName"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ServiceID")) serviceID = (Guid)row["ServiceID"];
            if (!row.IsNull("ServiceName")) serviceName = (string)row["ServiceName"];
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

        private Guid serviceID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of ServiceID
        /// </summary>
        public Guid ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        private string serviceName = String.Empty;
        /// <summary>
        /// Gets or sets the value of ServiceName
        /// </summary>
        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }

        #endregion

        #region Lists
        private ListBase<BocxepService> listBocxepService = new ListBase<BocxepService>();

        public ListBase<BocxepService> ListBocxepService
        {
            get { return listBocxepService; }
            set { listBocxepService = value; }

        }

        #endregion


    }
    #endregion
    #region BocxepService
    /// <summary>
    /// This object represents the properties and methods of a BocxepService.
    /// </summary>
    public class BocxepService : BaseClass
    {


        public BocxepService()
        {
        }

        public BocxepService(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public BocxepService(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    serviceID = (obj as BocxepService).serviceID;
        //    bocxepCode = (obj as BocxepService).bocxepCode;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ServiceID", reader)) serviceID = reader.GetGuid(reader.GetOrdinal("ServiceID"));
                if (!isNull("BocxepCode", reader)) bocxepCode = reader.GetString(reader.GetOrdinal("BocxepCode"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ServiceID")) serviceID = (Guid)row["ServiceID"];
            if (!row.IsNull("BocxepCode")) bocxepCode = (string)row["BocxepCode"];
        }

        #region Public Properties



        private Guid serviceID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of ServiceID
        /// </summary>
        public Guid ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        private string bocxepCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of BocxepCode
        /// </summary>
        public string BocxepCode
        {
            get { return bocxepCode; }
            set { bocxepCode = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}