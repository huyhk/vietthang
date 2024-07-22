using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class BocxepResult : UserTracking2
    {
        public BocxepResult() { }
        public BocxepResult(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ResultID", reader)) resultID = reader.GetGuid(reader.GetOrdinal("ResultID"));
            if (!isNull("BocxepSubjectCode", reader)) bocxepSubjectCode = reader.GetString(reader.GetOrdinal("BocxepSubjectCode"));
            if (!isNull("BocxepContractNo", reader)) bocxepContractNo = reader.GetString(reader.GetOrdinal("BocxepContractNo"));
            if (!isNull("FromDate", reader)) fromDate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
            if (!isNull("ToDate", reader)) toDate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("BocxepSubjectCode")) bocxepSubjectCode = (string)row["BocxepSubjectCode"];
            if (!row.IsNull("BocxepContractNo")) bocxepContractNo = (string)row["BocxepContractNo"];
            if (!row.IsNull("FromDate")) fromDate = (DateTime)row["FromDate"];
            if (!row.IsNull("ToDate")) toDate = (DateTime)row["ToDate"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);
            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("BocxepSubjectCode")) bocxepSubjectCode = (string)row["BocxepSubjectCode"];
            if (!row.IsNull("BocxepContractNo")) bocxepContractNo = (string)row["BocxepContractNo"];
            if (!row.IsNull("FromDate")) fromDate = (DateTime)row["FromDate"];
            if (!row.IsNull("ToDate")) toDate = (DateTime)row["ToDate"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }
        private Guid resultID = Guid.Empty;
        public Guid ResultID
        {
            get { return resultID; }
            set { resultID = value; }
        }
        private string bocxepSubjectCode = string.Empty;
        public string BocxepSubjectCode
        {
            get { return bocxepSubjectCode; }
            set { bocxepSubjectCode = value; }
        }
        private string bocxepContractNo = string.Empty;
        public string BocxepContractNo
        {
            get { return bocxepContractNo; }
            set { bocxepContractNo = value; }
        }
        private DateTime fromDate = DateTime.Today;
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        private DateTime toDate = DateTime.Today;
        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private ListBase<BocxepResultDetail1> listDetail1 = new ListBase<BocxepResultDetail1>();
        public ListBase<BocxepResultDetail1> ListDetail1
        {
            get { return listDetail1; }
            set { listDetail1 = value; }
        }
    }

    #region BocxepResultDetail1
    /// <summary>
    /// This object represents the properties and methods of a BocxepResultDetail1.
    /// </summary>
    public class BocxepResultDetail1 : ObjectBase
    {


        public BocxepResultDetail1()
        {
        }

        public BocxepResultDetail1(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    resultID = (obj as BocxepResultDetail1).resultID;
        //    detail1ID = (obj as BocxepResultDetail1).detail1ID;
        //    stockTransactionNo = (obj as BocxepResultDetail1).stockTransactionNo;
        //    stockTransactionDate = (obj as BocxepResultDetail1).stockTransactionDate;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ResultID", reader)) resultID = reader.GetGuid(reader.GetOrdinal("ResultID"));
                if (!isNull("Detail1ID", reader)) detail1ID = reader.GetGuid(reader.GetOrdinal("Detail1ID"));
                if (!isNull("StockTransactionNo", reader)) stockTransactionNo = reader.GetString(reader.GetOrdinal("StockTransactionNo"));
                if (!isNull("StockTransactionDate", reader)) stockTransactionDate = reader.GetDateTime(reader.GetOrdinal("StockTransactionDate"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("Detail1ID")) detail1ID = (Guid)row["Detail1ID"];
            if (!row.IsNull("StockTransactionNo")) stockTransactionNo = (string)row["StockTransactionNo"];
            if (!row.IsNull("StockTransactionDate")) stockTransactionDate = (DateTime)row["StockTransactionDate"];
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

        private string stockTransactionNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockTransactionNo
        /// </summary>
        public string StockTransactionNo
        {
            get { return stockTransactionNo; }
            set { stockTransactionNo = value; }
        }

        private DateTime stockTransactionDate = Contexts.WorkingDate;
        /// <summary>
        /// Gets or sets the value of StockTransactionDate
        /// </summary>
        public DateTime StockTransactionDate
        {
            get { return stockTransactionDate; }
            set { stockTransactionDate = value; }
        }
        #endregion

        #region Lists
        private ListBase<BocxepResultDetail2> listDetail2=new ListBase<BocxepResultDetail2>();

        public ListBase<BocxepResultDetail2> ListDetail2
        {
            get { return listDetail2; }
            set { listDetail2 = value; }

        }

        #endregion


    }
    #endregion

    #region BocxepResultDetail2
    /// <summary>
    /// This object represents the properties and methods of a BocxepResultDetail2.
    /// </summary>
    public class BocxepResultDetail2 : ObjectBase
    {


        public BocxepResultDetail2()
        {
        }

        public BocxepResultDetail2(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    detail1ID = (obj as BocxepResultDetail2).detail1ID;
        //    detail2ID = (obj as BocxepResultDetail2).detail2ID;
        //    itemCode = (obj as BocxepResultDetail2).itemCode;
        //    quantity = (obj as BocxepResultDetail2).quantity;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("Detail1ID", reader)) detail1ID = reader.GetGuid(reader.GetOrdinal("Detail1ID"));
                if (!isNull("Detail2ID", reader)) detail2ID = reader.GetGuid(reader.GetOrdinal("Detail2ID"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("Detail1ID")) detail1ID = (Guid)row["Detail1ID"];
            if (!row.IsNull("Detail2ID")) detail2ID = (Guid)row["Detail2ID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
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

        private Guid detail2ID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of Detail2ID
        /// </summary>
        public Guid Detail2ID
        {
            get { return detail2ID; }
            set { detail2ID = value; }
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
        #endregion

        #region Lists
        private ListBase<BocxepResultDetail3> listDetail3=new ListBase<BocxepResultDetail3>();

        public ListBase<BocxepResultDetail3> ListDetail3
        {
            get { return listDetail3; }
            set { listDetail3 = value; }

        }

        #endregion


    }
    #endregion

    #region BocxepResultDetail3
    /// <summary>
    /// This object represents the properties and methods of a BocxepResultDetail3.
    /// </summary>
    public class BocxepResultDetail3 : ObjectBase
    {


        public BocxepResultDetail3()
        {
        }

        public BocxepResultDetail3(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    detail2ID = (obj as BocxepResultDetail3).detail2ID;
        //    detail3ID = (obj as BocxepResultDetail3).detail3ID;
        //    bocxepTypeCode = (obj as BocxepResultDetail3).bocxepTypeCode;
        //    workingType = (obj as BocxepResultDetail3).workingType;
        //    toBocxepCode = (obj as BocxepResultDetail3).toBocxepCode;
        //    songuoi = (obj as BocxepResultDetail3).songuoi;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("Detail2ID", reader)) detail2ID = reader.GetGuid(reader.GetOrdinal("Detail2ID"));
                if (!isNull("Detail3ID", reader)) detail3ID = reader.GetGuid(reader.GetOrdinal("Detail3ID"));
                if (!isNull("BocxepTypeCode", reader)) bocxepTypeCode = reader.GetString(reader.GetOrdinal("BocxepTypeCode"));
                if (!isNull("WorkingType", reader)) workingType = reader.GetString(reader.GetOrdinal("WorkingType"));
                if (!isNull("ToBocxepCode", reader)) toBocxepCode = reader.GetString(reader.GetOrdinal("ToBocxepCode"));
                if (!isNull("Songuoi", reader)) songuoi = reader.GetInt32(reader.GetOrdinal("Songuoi"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("ServiceID", reader)) serviceID = reader.GetGuid(reader.GetOrdinal("ServiceID"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("Detail2ID")) detail2ID = (Guid)row["Detail2ID"];
            if (!row.IsNull("Detail3ID")) detail3ID = (Guid)row["Detail3ID"];
            if (!row.IsNull("BocxepTypeCode")) bocxepTypeCode = (string)row["BocxepTypeCode"];
            if (!row.IsNull("WorkingType")) workingType = (string)row["WorkingType"];
            if (!row.IsNull("ToBocxepCode")) toBocxepCode = (string)row["ToBocxepCode"];
            if (!row.IsNull("Songuoi")) songuoi = (int)row["Songuoi"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("ServiceID")) serviceID = (Guid)row["ServiceID"];
        }

        #region Public Properties



        private Guid detail2ID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of Detail2ID
        /// </summary>
        public Guid Detail2ID
        {
            get { return detail2ID; }
            set { detail2ID = value; }
        }

        private Guid detail3ID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of Detail3ID
        /// </summary>
        public Guid Detail3ID
        {
            get { return detail3ID; }
            set { detail3ID = value; }
        }

        private string bocxepTypeCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of BocxepTypeCode
        /// </summary>
        public string BocxepTypeCode
        {
            get { return bocxepTypeCode; }
            set { bocxepTypeCode = value; }
        }

        private string workingType = String.Empty;
        /// <summary>
        /// Gets or sets the value of WorkingType
        /// </summary>
        public string WorkingType
        {
            get { return workingType; }
            set { workingType = value; }
        }

        private string toBocxepCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ToBocxepCode
        /// </summary>
        public string ToBocxepCode
        {
            get { return toBocxepCode; }
            set { toBocxepCode = value; }
        }

        private int songuoi;
        /// <summary>
        /// Gets or sets the value of Songuoi
        /// </summary>
        public int Songuoi
        {
            get { return songuoi; }
            set { songuoi = value; }
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

        private Guid serviceID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of ServiceID
        /// </summary>
        public Guid ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}
