using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region Linesxs
    /// <summary>
    /// This object represents the properties and methods of a Linesxs.
    /// </summary>
    public class Linesxs : UserTracking2
    {


        public Linesxs()
        {
        }

        public Linesxs(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public Linesxs(DataRow row)
        {
            this.FromDataRow(row);
        }
        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    linesxNo = (obj as Linesxs).linesxNo;
        //    stockCode = (obj as Linesxs).stockCode;
        //    nangsuatLot = (obj as Linesxs).nangsuatLot;
        //    nangsuat = (obj as Linesxs).nangsuat;
        //    description = (obj as Linesxs).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("LinesxNo", reader)) linesxNo = reader.GetInt32(reader.GetOrdinal("LinesxNo"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("NangsuatLot", reader)) nangsuatLot = reader.GetInt32(reader.GetOrdinal("NangsuatLot"));
                if (!isNull("Nangsuat", reader)) nangsuat = reader.GetInt32(reader.GetOrdinal("Nangsuat"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("LinesxNo")) linesxNo = (int)row["LinesxNo"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("NangsuatLot")) nangsuatLot = (int)row["NangsuatLot"];
            if (!row.IsNull("Nangsuat")) nangsuat = (int)row["Nangsuat"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        #region Public Properties



        private int linesxNo;
        /// <summary>
        /// Gets or sets the value of LinesxNo
        /// </summary>
        public int LinesxNo
        {
            get { return linesxNo; }
            set { linesxNo = value; }
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

        private int nangsuatLot;
        /// <summary>
        /// Gets or sets the value of NangsuatLot
        /// </summary>
        public int NangsuatLot
        {
            get { return nangsuatLot; }
            set { nangsuatLot = value; }
        }

        private int nangsuat;
        /// <summary>
        /// Gets or sets the value of Nangsuat
        /// </summary>
        public int Nangsuat
        {
            get { return nangsuat; }
            set { nangsuat = value; }
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
