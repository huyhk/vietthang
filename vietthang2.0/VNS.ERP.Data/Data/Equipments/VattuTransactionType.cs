using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Equipments
{
    #region VattuTransactionType
    /// <summary>
    /// This object represents the properties and methods of a VattuTransactionType.
    /// </summary>
    public class VattuTransactionType : ObjectBase
    {


        public VattuTransactionType()
        {
        }

        public VattuTransactionType(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    typeCode = (obj as VattuTransactionType).typeCode;
        //    typeName = (obj as VattuTransactionType).typeName;
        //    inOutType = (obj as VattuTransactionType).inOutType;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TypeCode", reader)) typeCode = reader.GetString(reader.GetOrdinal("TypeCode"));
                if (!isNull("TypeName", reader)) typeName = reader.GetString(reader.GetOrdinal("TypeName"));
                if (!isNull("InOutType", reader)) inOutType = reader.GetString(reader.GetOrdinal("InOutType"));
                if (!isNull("TypeCode2", reader)) typeCode2 = reader.GetString(reader.GetOrdinal("TypeCode2"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("TypeCode")) typeCode = (string)row["TypeCode"];
            if (!row.IsNull("TypeName")) typeName = (string)row["TypeName"];
            if (!row.IsNull("InOutType")) inOutType = (string)row["InOutType"];
            if (!row.IsNull("TypeCode2")) typeCode2 = (string)row["TypeCode2"];
        }

        #region Public Properties



        private string typeCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of TypeCode
        /// </summary>
        public string TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }

        private string typeName = String.Empty;
        /// <summary>
        /// Gets or sets the value of TypeName
        /// </summary>
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        private string inOutType = String.Empty;
        /// <summary>
        /// Gets or sets the value of InOutType
        /// </summary>
        public string InOutType
        {
            get { return inOutType; }
            set { inOutType = value; }
        }

        private string typeCode2 = String.Empty;
        /// <summary>
        /// Gets or sets the value of TypeCode
        /// </summary>
        public string TypeCode2
        {
            get { return typeCode2; }
            set { typeCode2 = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}