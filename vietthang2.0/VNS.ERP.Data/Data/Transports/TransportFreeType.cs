using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region TransportFeeType
    /// <summary>
    /// This object represents the properties and methods of a TransportFeeType.
    /// </summary>
    public class TransportFeeType : UserTracking2
    {


        public TransportFeeType()
        {
        }

        public TransportFeeType(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TransportFeeType(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    typeCode = (obj as TransportFeeType).typeCode;
        //    typeName = (obj as TransportFeeType).typeName;
        //    description = (obj as TransportFeeType).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TypeCode", reader)) typeCode = reader.GetString(reader.GetOrdinal("TypeCode"));
                if (!isNull("TypeName", reader)) typeName = reader.GetString(reader.GetOrdinal("TypeName"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("TypeCode")) typeCode = (string)row["TypeCode"];
            if (!row.IsNull("TypeName")) typeName = (string)row["TypeName"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        #region Public Properties



        private string typeCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of TypeCode
        /// </summary>
        public string TypeCode
        {
            get { return typeCode; }
            set
            {
                typeCode = value;
                //OnPropertyChanged("TypeCode", value);
            }
        }

        private string typeName = String.Empty;
        /// <summary>
        /// Gets or sets the value of TypeName
        /// </summary>
        public string TypeName
        {
            get { return typeName; }
            set
            {
                typeName = value;
                //OnPropertyChanged("TypeName", value);
            }
        }

        private string description = String.Empty;
        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                //OnPropertyChanged("Description", value);
            }
        }

        #endregion

        #region Lists
        #endregion


    }
    #endregion
}