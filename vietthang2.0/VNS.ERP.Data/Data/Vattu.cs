using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region Vattu
    /// <summary>
    /// This object represents the properties and methods of a Vattu.
    /// </summary>
    public class Vattu : UserTracking2
    {


        public Vattu()
        {
        }

        public Vattu(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public Vattu(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    vattuCode = (obj as Vattu).vattuCode;
        //    vattuName = (obj as Vattu).vattuName;
        //    unit = (obj as Vattu).unit;
        //    description = (obj as Vattu).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("VattuCode", reader)) vattuCode = reader.GetString(reader.GetOrdinal("VattuCode"));
                if (!isNull("VattuName", reader)) vattuName = reader.GetString(reader.GetOrdinal("VattuName"));
                if (!isNull("Unit", reader)) unit = reader.GetString(reader.GetOrdinal("Unit"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("VattuCode")) vattuCode = (string)row["VattuCode"];
            if (!row.IsNull("VattuName")) vattuName = (string)row["VattuName"];
            if (!row.IsNull("Unit")) unit = (string)row["Unit"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        #region Public Properties



        private string vattuCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of VattuCode
        /// </summary>
        public string VattuCode
        {
            get { return vattuCode; }
            set { vattuCode = value; }
        }

        private string vattuName = String.Empty;
        /// <summary>
        /// Gets or sets the value of VattuName
        /// </summary>
        public string VattuName
        {
            get { return vattuName; }
            set { vattuName = value; }
        }

        private string unit = String.Empty;
        /// <summary>
        /// Gets or sets the value of Unit
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
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
