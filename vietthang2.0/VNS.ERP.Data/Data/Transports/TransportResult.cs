using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Transports
{
    #region TransportResult
    /// <summary>
    /// This object represents the properties and methods of a TransportResult.
    /// </summary>
    public class TransportResult : UserTracking2
    {


        public TransportResult()
        {
        }

        public TransportResult(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportResult(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    resultID = (obj as TransportResult).resultID;
        //    transportSubjectCode = (obj as TransportResult).transportSubjectCode;
        //    routeCode = (obj as TransportResult).routeCode;
        //    fromDate = (obj as TransportResult).fromDate;
        //    toDate = (obj as TransportResult).toDate;
        //    isTrungchuyen = (obj as TransportResult).isTrungchuyen;
        //    description = (obj as TransportResult).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ResultID", reader)) resultID = reader.GetGuid(reader.GetOrdinal("ResultID"));
                if (!isNull("TransportSubjectCode", reader)) transportSubjectCode = reader.GetString(reader.GetOrdinal("TransportSubjectCode"));
                if (!isNull("RouteCode", reader)) routeCode = reader.GetString(reader.GetOrdinal("RouteCode"));
                if (!isNull("FromDate", reader)) fromDate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
                if (!isNull("ToDate", reader)) toDate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
                if (!isNull("IsTrungchuyen", reader)) isTrungchuyen = reader.GetBoolean(reader.GetOrdinal("IsTrungchuyen"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));

                if (!isNull("TransportContractNo", reader)) transportContractNo = reader.GetString(reader.GetOrdinal("TransportContractNo"));
                if (!isNull("BatchID", reader)) batchID = reader.GetGuid(reader.GetOrdinal("BatchID"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("TransportSubjectCode")) transportSubjectCode = (string)row["TransportSubjectCode"];
            if (!row.IsNull("RouteCode")) routeCode = (string)row["RouteCode"];
            if (!row.IsNull("FromDate")) fromDate = (DateTime)row["FromDate"];
            if (!row.IsNull("ToDate")) toDate = (DateTime)row["ToDate"];
            if (!row.IsNull("IsTrungchuyen")) isTrungchuyen = (bool)row["IsTrungchuyen"];
            if (!row.IsNull("Description")) description = (string)row["Description"];

            if (!row.IsNull("TransportContractNo")) transportContractNo = (string)row["TransportContractNo"];
            if (!row.IsNull("BatchID")) batchID = (Guid)row["BatchID"];
        }

        #region Public Properties



        private Guid resultID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of ResultID
        /// </summary>
        public Guid ResultID
        {
            get { return resultID; }
            set { resultID = value; }
        }

        private string transportSubjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of TransportSubjectCode
        /// </summary>
        public string TransportSubjectCode
        {
            get { return transportSubjectCode; }
            set { transportSubjectCode = value; }
        }

        private string routeCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of RouteCode
        /// </summary>
        public string RouteCode
        {
            get { return routeCode; }
            set { routeCode = value; }
        }

        private DateTime fromDate = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of FromDate
        /// </summary>
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        private DateTime toDate = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of ToDate
        /// </summary>
        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        private bool isTrungchuyen;
        /// <summary>
        /// Gets or sets the value of IsTrungchuyen
        /// </summary>
        public bool IsTrungchuyen
        {
            get { return isTrungchuyen; }
            set { isTrungchuyen = value; }
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

        private string transportContractNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of TransportSubjectCode
        /// </summary>
        public string TransportContractNo
        {
            get { return transportContractNo; }
            set { transportContractNo = value; }
        }

        private Guid batchID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of BatchID
        /// </summary>
        public Guid BatchID
        {
            get { return batchID; }
            set
            {
                batchID = value;
                //OnPropertyChanged("BatchID", value);
            }
        }
        #endregion

        #region Lists
        private ListBase<TransportResultDetail1> listTransportResultDetail1 = new ListBase<TransportResultDetail1>();

        public ListBase<TransportResultDetail1> ListTransportResultDetail1
        {
            get { return listTransportResultDetail1; }
            set { listTransportResultDetail1 = value; }

        }

        #endregion

        private ListBase<TransportContractBatch> listBatch;
        public ListBase<TransportContractBatch> ListBatch
        {
            get
            {
                if (listBatch == null)
                {
                    listBatch = new TransportContractBatchDAL().GetByContractNo(this.transportContractNo);
                }
                return listBatch;
            }
            set { listBatch = value; }

        }
    }
    #endregion

    #region TransportResultDetail1
    /// <summary>
    /// This object represents the properties and methods of a TransportResultDetail1.
    /// </summary>
    public class TransportResultDetail1 : ObjectBase
    {


        public TransportResultDetail1()
        {
        }

        public TransportResultDetail1(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportResultDetail1(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    resultID = (obj as TransportResultDetail1).resultID;
        //    detail1ID = (obj as TransportResultDetail1).detail1ID;
        //    transactionNo = (obj as TransportResultDetail1).transactionNo;
        //    transactionDate = (obj as TransportResultDetail1).transactionDate;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ResultID", reader)) resultID = reader.GetGuid(reader.GetOrdinal("ResultID"));
                if (!isNull("Detail1ID", reader)) detail1ID = reader.GetGuid(reader.GetOrdinal("Detail1ID"));
                if (!isNull("TransportType", reader)) transportType = reader.GetString(reader.GetOrdinal("TransportType"));
                if (!isNull("PTVC", reader)) pTVC = reader.GetString(reader.GetOrdinal("PTVC"));

                if (!isNull("DetentionDay", reader)) detentionDay = reader.GetDecimal(reader.GetOrdinal("DetentionDay"));
                if (!isNull("OverdueHour", reader)) overdueHour = reader.GetDecimal(reader.GetOrdinal("OverdueHour"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("Detail1ID")) detail1ID = (Guid)row["Detail1ID"];
            if (!row.IsNull("TransportType")) transportType = (string)row["TransportType"];
            if (!row.IsNull("PTVC")) pTVC = (string)row["PTVC"];

            if (!row.IsNull("DetentionDay")) detentionDay = (decimal)row["DetentionDay"];
            if (!row.IsNull("OverdueHour")) overdueHour = (decimal)row["OverdueHour"];
        }

        #region Public Properties



        private Guid resultID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of ResultID
        /// </summary>
        public Guid ResultID
        {
            get { return resultID; }
            set { resultID = value; }
        }

        private Guid detail1ID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of Detail1ID
        /// </summary>
        public Guid Detail1ID
        {
            get { return detail1ID; }
            set { detail1ID = value; }
        }

        private string pTVC = String.Empty;
        /// <summary>
        /// Gets or sets the value of PTVC
        /// </summary>
        public string PTVC
        {
            get { return pTVC; }
            set { pTVC = value; }
        }

        private string transportType = String.Empty;
        /// <summary>
        /// Gets or sets the value of TransportType
        /// </summary>
        public string TransportType
        {
            get { return transportType; }
            set { transportType = value; }
        }

        private decimal detentionDay = 0;
        /// <summary>
        /// Gets or sets the value of DetentionDay 
        /// </summary>
        public decimal DetentionDay 
        {
            get { return detentionDay; }
            set { detentionDay = value; }
        }

        private decimal overdueHour = 0;
        /// <summary>
        /// Gets or sets the value of OverdueHour 
        /// </summary>
        public decimal OverdueHour
        {
            get { return overdueHour; }
            set { overdueHour = value; }
        }
        #endregion

        #region Lists
        private ListBase<TransportResultDetail2> listTransportResultDetail2 = new ListBase<TransportResultDetail2>();

        public ListBase<TransportResultDetail2> ListTransportResultDetail2
        {
            get { return listTransportResultDetail2; }
            set { listTransportResultDetail2 = value; }
        }

        private ListBase<TransportResultDetail3> listTransportResultDetail3 = new ListBase<TransportResultDetail3>();

        public ListBase<TransportResultDetail3> ListTransportResultDetail3
        {
            get { return listTransportResultDetail3; }
            set { listTransportResultDetail3 = value; }
        }

        #endregion


    }
    #endregion

    #region TransportResultDetail2
    /// <summary>
    /// This object represents the properties and methods of a TransportResultDetail2.
    /// </summary>
    public class TransportResultDetail2 : ObjectBase
    {


        public TransportResultDetail2()
        {
        }

        public TransportResultDetail2(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportResultDetail2(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    detail1ID = (obj as TransportResultDetail2).detail1ID;
        //    itemCode = (obj as TransportResultDetail2).itemCode;
        //    quantity = (obj as TransportResultDetail2).quantity;
        //    slGiao = (obj as TransportResultDetail2).slGiao;
        //    transportItemType = (obj as TransportResultDetail2).transportItemType;
        //    transportType = (obj as TransportResultDetail2).transportType;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("Detail1ID", reader)) detail1ID = reader.GetGuid(reader.GetOrdinal("Detail1ID"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("SlGiao", reader)) slGiao = reader.GetDecimal(reader.GetOrdinal("SlGiao"));
                if (!isNull("TransportItemType", reader)) transportItemType = reader.GetString(reader.GetOrdinal("TransportItemType"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("Detail1ID")) detail1ID = (Guid)row["Detail1ID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("SlGiao")) slGiao = (decimal)row["SlGiao"];
            if (!row.IsNull("TransportItemType")) transportItemType = (string)row["TransportItemType"];
        }

        #region Public Properties



        private Guid detail1ID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of Detail1ID
        /// </summary>
        public Guid Detail1ID
        {
            get { return detail1ID; }
            set { detail1ID = value; }
        }

        private string itemCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        private decimal quantity;
        /// <summary>
        /// Gets or sets the value of Quantity
        /// </summary>
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private decimal slGiao;
        /// <summary>
        /// Gets or sets the value of SlGiao
        /// </summary>
        public decimal SlGiao
        {
            get { return slGiao; }
            set { slGiao = value; }
        }

        private string transportItemType = String.Empty;
        /// <summary>
        /// Gets or sets the value of TransportItemType
        /// </summary>
        public string TransportItemType
        {
            get { return transportItemType; }
            set { transportItemType = value; }
        }

        #endregion

        #region Lists
        #endregion


    }
    #endregion

    #region TransportResultDetail3
    /// <summary>
    /// This object represents the properties and methods of a TransportResultDetail1.
    /// </summary>
    public class TransportResultDetail3 : ObjectBase
    {


        public TransportResultDetail3()
        {
        }

        public TransportResultDetail3(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportResultDetail3(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    resultID = (obj as TransportResultDetail1).resultID;
        //    detail1ID = (obj as TransportResultDetail1).detail1ID;
        //    transactionNo = (obj as TransportResultDetail1).transactionNo;
        //    transactionDate = (obj as TransportResultDetail1).transactionDate;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("Detail1ID", reader)) detail1ID = reader.GetGuid(reader.GetOrdinal("Detail1ID"));
                if (!isNull("TransactionNo", reader)) transactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
                if (!isNull("TransactionDate", reader)) transactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("Detail1ID")) detail1ID = (Guid)row["Detail1ID"];
            if (!row.IsNull("TransactionNo")) transactionNo = (string)row["TransactionNo"];
            if (!row.IsNull("TransactionDate")) transactionDate = (DateTime)row["TransactionDate"];
        }

        #region Public Properties

        private Guid detail1ID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of Detail1ID
        /// </summary>
        public Guid Detail1ID
        {
            get { return detail1ID; }
            set { detail1ID = value; }
        }

        private string transactionNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of TransactionNo
        /// </summary>
        public string TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }

        private DateTime transactionDate;
        /// <summary>
        /// Gets or sets the value of TransactionDate
        /// </summary>
        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}