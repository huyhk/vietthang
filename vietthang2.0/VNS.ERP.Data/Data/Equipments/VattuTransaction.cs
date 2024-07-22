using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Equipments
{
    #region VattuTransaction
    /// <summary>
    /// This object represents the properties and methods of a VattuTransaction.
    /// </summary>
    public class VattuTransaction : UserTracking2
    {


        public VattuTransaction()
        {
        }

        public VattuTransaction(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    transactionID = (obj as VattuTransaction).transactionID;
        //    transactionNo = (obj as VattuTransaction).transactionNo;
        //    transactionDate = (obj as VattuTransaction).transactionDate;
        //    transactionType = (obj as VattuTransaction).transactionType;
        //    stockIn = (obj as VattuTransaction).stockIn;
        //    stockOut = (obj as VattuTransaction).stockOut;
        //    description = (obj as VattuTransaction).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TransactionID", reader)) transactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                if (!isNull("TransactionNo", reader)) transactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
                if (!isNull("TransactionDate", reader)) transactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                if (!isNull("TransactionType", reader)) transactionType = reader.GetString(reader.GetOrdinal("TransactionType"));
                if (!isNull("StockIn", reader)) stockIn = reader.GetString(reader.GetOrdinal("StockIn"));
                if (!isNull("StockOut", reader)) stockOut = reader.GetString(reader.GetOrdinal("StockOut"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("DVGiaoNhan", reader)) dvGiaoNhan = reader.GetString(reader.GetOrdinal("DVGiaoNhan"));
                if (!isNull("CTKemtheo", reader)) ctKemtheo = reader.GetString(reader.GetOrdinal("CTKemtheo"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("TransactionID")) transactionID = (Guid)row["TransactionID"];
            if (!row.IsNull("TransactionNo")) transactionNo = (string)row["TransactionNo"];
            if (!row.IsNull("TransactionDate")) transactionDate = (DateTime)row["TransactionDate"];
            if (!row.IsNull("TransactionType")) transactionType = (string)row["TransactionType"];
            if (!row.IsNull("StockIn")) stockIn = (string)row["StockIn"];
            if (!row.IsNull("StockOut")) stockOut = (string)row["StockOut"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("DVGiaoNhan")) dvGiaoNhan = (string)row["DVGiaoNhan"];
            if (!row.IsNull("CTKemtheo")) ctKemtheo = (string)row["CTKemtheo"];
        }

        #region Public Properties



        private Guid transactionID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of TransactionID
        /// </summary>
        public Guid TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
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

        private DateTime transactionDate = Contexts.WorkingDate;
        /// <summary>
        /// Gets or sets the value of TransactionDate
        /// </summary>
        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }

        private string transactionType = String.Empty;
        /// <summary>
        /// Gets or sets the value of TransactionType
        /// </summary>
        public string TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }

        private string stockIn = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockIn
        /// </summary>
        public string StockIn
        {
            get { return stockIn; }
            set { stockIn = value; }
        }

        private string stockOut = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockOut
        /// </summary>
        public string StockOut
        {
            get { return stockOut; }
            set { stockOut = value; }
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

        private string dvGiaoNhan = String.Empty;
        public string DVGiaoNhan
        {
            get { return dvGiaoNhan; }
            set { dvGiaoNhan = value; }
        }

        private string ctKemtheo = String.Empty;
        public string CTKemtheo
        {
            get { return ctKemtheo; }
            set { ctKemtheo = value; }
        }
        #endregion

        #region Lists
        private ListBase<VattuTransactionDetail> listVattuTransactionDetail = new ListBase<VattuTransactionDetail>();

        public ListBase<VattuTransactionDetail> ListVattuTransactionDetail
        {
            get { return listVattuTransactionDetail; }
            set { listVattuTransactionDetail = value; }

        }

        //private ListBase<VattuTransactionDetail> listVattuTransactionDetailOld = new ListBase<VattuTransactionDetail>();

        //public ListBase<VattuTransactionDetail> ListVattuTransactionDetailOld
        //{
        //    get { return listVattuTransactionDetailOld; }
        //    set { listVattuTransactionDetailOld = value; }

        //}

        #endregion


    }
    #endregion
    #region VattuTransactionDetail
    /// <summary>
    /// This object represents the properties and methods of a VattuTransactionDetail.
    /// </summary>
    public class VattuTransactionDetail : ObjectBase
    {


        public VattuTransactionDetail()
        {
        }

        public VattuTransactionDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    transactionID = (obj as VattuTransactionDetail).transactionID;
        //    vattuCode = (obj as VattuTransactionDetail).vattuCode;
        //    quantity = (obj as VattuTransactionDetail).quantity;
        //    price = (obj as VattuTransactionDetail).price;
        //    amount = (obj as VattuTransactionDetail).amount;
        //    lineSxNo = (obj as VattuTransactionDetail).lineSxNo;
        //    equipmentSxCode = (obj as VattuTransactionDetail).equipmentSxCode;
        //    equipmentCode = (obj as VattuTransactionDetail).equipmentCode;
        //    vattuOldType = (obj as VattuTransactionDetail).vattuOldType;
        //    description = (obj as VattuTransactionDetail).description;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("TransactionID", reader)) transactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                if (!isNull("VattuCode", reader)) vattuCode = reader.GetString(reader.GetOrdinal("VattuCode"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
                if (!isNull("LineSxNo", reader)) lineSxNo = reader.GetInt32(reader.GetOrdinal("LineSxNo"));
                if (!isNull("EquipmentSxCode", reader)) equipmentSxCode = reader.GetString(reader.GetOrdinal("EquipmentSxCode"));
                if (!isNull("EquipmentCode", reader)) equipmentCode = reader.GetString(reader.GetOrdinal("EquipmentCode"));
                if (!isNull("VattuOldType", reader)) vattuOldType = reader.GetString(reader.GetOrdinal("VattuOldType"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("TransactionID")) transactionID = (Guid)row["TransactionID"];
            if (!row.IsNull("VattuCode")) vattuCode = (string)row["VattuCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
            if (!row.IsNull("Amount")) amount = (decimal)row["Amount"];
            if (!row.IsNull("LineSxNo")) lineSxNo = (int)row["LineSxNo"];
            if (!row.IsNull("EquipmentSxCode")) equipmentSxCode = (string)row["EquipmentSxCode"];
            if (!row.IsNull("EquipmentCode")) equipmentCode = (string)row["EquipmentCode"];
            if (!row.IsNull("VattuOldType")) vattuOldType = (string)row["VattuOldType"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        #region Public Properties



        private Guid transactionID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of TransactionID
        /// </summary>
        public Guid TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }

        private string vattuCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of VattuCode
        /// </summary>
        public string VattuCode
        {
            get { return vattuCode; }
            set { vattuCode = value; }
        }

        private decimal quantity;
        /// <summary>
        /// Gets or sets the value of Quantity
        /// </summary>
        public decimal Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                amount = quantity * price;
            }
        }

        private decimal price;
        /// <summary>
        /// Gets or sets the value of Price
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                amount = quantity * price;
            }
        }

        private decimal amount;
        /// <summary>
        /// Gets or sets the value of Amount
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                if (quantity != 0)
                    price = amount / quantity;
            }
        }

        private int lineSxNo;
        /// <summary>
        /// Gets or sets the value of LineSxNo
        /// </summary>
        public int LineSxNo
        {
            get { return lineSxNo; }
            set { lineSxNo = value; }
        }

        private string equipmentSxCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of EquipmentSxCode
        /// </summary>
        public string EquipmentSxCode
        {
            get { return equipmentSxCode; }
            set { equipmentSxCode = value; }
        }

        private string equipmentCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of EquipmentCode
        /// </summary>
        public string EquipmentCode
        {
            get { return equipmentCode; }
            set { equipmentCode = value; }
        }

        private string vattuOldType = String.Empty;
        /// <summary>
        /// Gets or sets the value of VattuOldType
        /// </summary>
        public string VattuOldType
        {
            get { return vattuOldType; }
            set { vattuOldType = value; }
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