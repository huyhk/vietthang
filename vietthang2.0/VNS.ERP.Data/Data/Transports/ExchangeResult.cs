using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region ExchangeResult
    /// <summary>
    /// This object represents the properties and methods of a ExchangeResult.
    /// </summary>
    public class ExchangeResult : UserTracking2
    {


        public ExchangeResult()
        {
        }

        public ExchangeResult(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    resultID = (obj as ExchangeResult).resultID;
        //    vesselExchangeContractNo = (obj as ExchangeResult).vesselExchangeContractNo;
        //    fromDate = (obj as ExchangeResult).fromDate;
        //    toDate = (obj as ExchangeResult).toDate;
        //    description = (obj as ExchangeResult).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ResultID", reader)) resultID = reader.GetGuid(reader.GetOrdinal("ResultID"));
                if (!isNull("ExchangeSubjectCode", reader)) exchangeSubjectCode = reader.GetString(reader.GetOrdinal("ExchangeSubjectCode"));
                if (!isNull("VesselExchangeContractNo", reader)) vesselExchangeContractNo = reader.GetString(reader.GetOrdinal("VesselExchangeContractNo"));
                if (!isNull("FromDate", reader)) fromDate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
                if (!isNull("ToDate", reader)) toDate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            base.LoadFromReader(reader);

            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ResultID", reader)) resultID = reader.GetGuid(reader.GetOrdinal("ResultID"));
                if (!isNull("ExchangeSubjectCode", reader)) exchangeSubjectCode = reader.GetString(reader.GetOrdinal("ExchangeSubjectCode"));
                if (!isNull("VesselExchangeContractNo", reader)) vesselExchangeContractNo = reader.GetString(reader.GetOrdinal("VesselExchangeContractNo"));
                if (!isNull("FromDate", reader)) fromDate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
                if (!isNull("ToDate", reader)) toDate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("ExchangeSubjectCode")) exchangeSubjectCode = (string)row["ExchangeSubjectCode"];
            if (!row.IsNull("VesselExchangeContractNo")) vesselExchangeContractNo = (string)row["VesselExchangeContractNo"];
            if (!row.IsNull("FromDate")) fromDate = (DateTime)row["FromDate"];
            if (!row.IsNull("ToDate")) toDate = (DateTime)row["ToDate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);

            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("ExchangeSubjectCode")) exchangeSubjectCode = (string)row["ExchangeSubjectCode"];
            if (!row.IsNull("VesselExchangeContractNo")) vesselExchangeContractNo = (string)row["VesselExchangeContractNo"];
            if (!row.IsNull("FromDate")) fromDate = (DateTime)row["FromDate"];
            if (!row.IsNull("ToDate")) toDate = (DateTime)row["ToDate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
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

        private string exchangeSubjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of VesselExchangeContractNo
        /// </summary>
        public string ExchangeSubjectCode
        {
            get { return exchangeSubjectCode; }
            set { exchangeSubjectCode = value; }
        }

        private string vesselExchangeContractNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of VesselExchangeContractNo
        /// </summary>
        public string VesselExchangeContractNo
        {
            get { return vesselExchangeContractNo; }
            set { vesselExchangeContractNo = value; }
        }

        private DateTime fromDate=DateTime.Today;
        /// <summary>
        /// Gets or sets the value of FromDate
        /// </summary>
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        private DateTime toDate=DateTime.Today;
        /// <summary>
        /// Gets or sets the value of ToDate
        /// </summary>
        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
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
        private ListBase<ExchangeResultDetail> listExchangeResultDetail=new ListBase<ExchangeResultDetail>();

        public ListBase<ExchangeResultDetail> ListExchangeResultDetail
        {
            get { return listExchangeResultDetail; }
            set { listExchangeResultDetail = value; }

        }

        #endregion


    }
    #endregion

    #region ExchangeResultDetail
    /// <summary>
    /// This object represents the properties and methods of a ExchangeResultDetail.
    /// </summary>
    public class ExchangeResultDetail : ObjectBase
    {


        public ExchangeResultDetail()
        {
        }

        public ExchangeResultDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    resultID = (obj as ExchangeResultDetail).resultID;
        //    itemCode = (obj as ExchangeResultDetail).itemCode;
        //    transportType = (obj as ExchangeResultDetail).transportType;
        //    transportItemType = (obj as ExchangeResultDetail).transportItemType;
        //    stockCode = (obj as ExchangeResultDetail).stockCode;
        //    dateLeave = (obj as ExchangeResultDetail).dateLeave;
        //    dateArrive = (obj as ExchangeResultDetail).dateArrive;
        //    fromDate = (obj as ExchangeResultDetail).fromDate;
        //    toDate = (obj as ExchangeResultDetail).toDate;
        //    songaymuabao = (obj as ExchangeResultDetail).songaymuabao;
        //    pTVC = (obj as ExchangeResultDetail).pTVC;
        //    sobao = (obj as ExchangeResultDetail).sobao;
        //    nhantaitauChuatrubi = (obj as ExchangeResultDetail).nhantaitauChuatrubi;
        //    nhantaitauDatrubi = (obj as ExchangeResultDetail).nhantaitauDatrubi;
        //    giaonhamayDatrubi = (obj as ExchangeResultDetail).giaonhamayDatrubi;
        //    ghichu = (obj as ExchangeResultDetail).ghichu;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ResultID", reader)) resultID = reader.GetGuid(reader.GetOrdinal("ResultID"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("TransportType", reader)) transportType = reader.GetString(reader.GetOrdinal("TransportType"));
                if (!isNull("TransportItemType", reader)) transportItemType = reader.GetString(reader.GetOrdinal("TransportItemType"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("DateLeave", reader)) dateLeave = reader.GetDateTime(reader.GetOrdinal("DateLeave"));
                if (!isNull("DateArrive", reader)) dateArrive = reader.GetDateTime(reader.GetOrdinal("DateArrive"));
                if (!isNull("FromDate", reader)) fromDate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
                if (!isNull("ToDate", reader)) toDate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
                if (!isNull("Songaymuabao", reader)) songaymuabao = reader.GetInt32(reader.GetOrdinal("Songaymuabao"));
                if (!isNull("PTVC", reader)) pTVC = reader.GetString(reader.GetOrdinal("PTVC"));
                if (!isNull("Sobao", reader)) sobao = reader.GetInt32(reader.GetOrdinal("Sobao"));
                if (!isNull("NhantaitauChuatrubi", reader)) nhantaitauChuatrubi = reader.GetDecimal(reader.GetOrdinal("NhantaitauChuatrubi"));
                if (!isNull("NhantaitauDatrubi", reader)) nhantaitauDatrubi = reader.GetDecimal(reader.GetOrdinal("NhantaitauDatrubi"));
                if (!isNull("GiaonhamayDatrubi", reader)) giaonhamayDatrubi = reader.GetDecimal(reader.GetOrdinal("GiaonhamayDatrubi"));
                if (!isNull("Ghichu", reader)) ghichu = reader.GetString(reader.GetOrdinal("Ghichu"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ResultID")) resultID = (Guid)row["ResultID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("TransportType")) transportType = (string)row["TransportType"];
            if (!row.IsNull("TransportItemType")) transportItemType = (string)row["TransportItemType"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("DateLeave")) dateLeave = (DateTime)row["DateLeave"];
            if (!row.IsNull("DateArrive")) dateArrive = (DateTime)row["DateArrive"];
            if (!row.IsNull("FromDate")) fromDate = (DateTime)row["FromDate"];
            if (!row.IsNull("ToDate")) toDate = (DateTime)row["ToDate"];
            if (!row.IsNull("Songaymuabao")) songaymuabao = (int)row["Songaymuabao"];
            if (!row.IsNull("PTVC")) pTVC = (string)row["PTVC"];
            if (!row.IsNull("Sobao")) sobao = (int)row["Sobao"];
            if (!row.IsNull("NhantaitauChuatrubi")) nhantaitauChuatrubi = (decimal)row["NhantaitauChuatrubi"];
            if (!row.IsNull("NhantaitauDatrubi")) nhantaitauDatrubi = (decimal)row["NhantaitauDatrubi"];
            if (!row.IsNull("GiaonhamayDatrubi")) giaonhamayDatrubi = (decimal)row["GiaonhamayDatrubi"];
            if (!row.IsNull("Ghichu")) ghichu = (string)row["Ghichu"];
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

        private string itemCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
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

        private string transportItemType = String.Empty;
        /// <summary>
        /// Gets or sets the value of TransportItemType
        /// </summary>
        public string TransportItemType
        {
            get { return transportItemType; }
            set { transportItemType = value; }
        }

        private string stockCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockCode
        /// </summary>
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }

        private DateTime dateLeave=DateTime.Today;
        /// <summary>
        /// Gets or sets the value of DateLeave
        /// </summary>
        public DateTime DateLeave
        {
            get { return dateLeave; }
            set { dateLeave = value; }
        }

        private DateTime dateArrive=DateTime.Today;
        /// <summary>
        /// Gets or sets the value of DateArrive
        /// </summary>
        public DateTime DateArrive
        {
            get { return dateArrive; }
            set { dateArrive = value; }
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

        private int songaymuabao;
        /// <summary>
        /// Gets or sets the value of Songaymuabao
        /// </summary>
        public int Songaymuabao
        {
            get { return songaymuabao; }
            set { songaymuabao = value; }
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

        private int sobao;
        /// <summary>
        /// Gets or sets the value of Sobao
        /// </summary>
        public int Sobao
        {
            get { return sobao; }
            set { sobao = value; }
        }

        private decimal nhantaitauChuatrubi;
        /// <summary>
        /// Gets or sets the value of NhantaitauChuatrubi
        /// </summary>
        public decimal NhantaitauChuatrubi
        {
            get { return nhantaitauChuatrubi; }
            set { nhantaitauChuatrubi = value; }
        }

        private decimal nhantaitauDatrubi;
        /// <summary>
        /// Gets or sets the value of NhantaitauDatrubi
        /// </summary>
        public decimal NhantaitauDatrubi
        {
            get { return nhantaitauDatrubi; }
            set { nhantaitauDatrubi = value; }
        }

        private decimal giaonhamayDatrubi;
        /// <summary>
        /// Gets or sets the value of GiaonhamayDatrubi
        /// </summary>
        public decimal GiaonhamayDatrubi
        {
            get { return giaonhamayDatrubi; }
            set { giaonhamayDatrubi = value; }
        }

        private string ghichu = String.Empty;
        /// <summary>
        /// Gets or sets the value of Ghichu
        /// </summary>
        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}	


