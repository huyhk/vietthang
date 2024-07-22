using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Equipments
{
    #region VattuOpening
    /// <summary>
    /// This object represents the properties and methods of a VattuOpening.
    /// </summary>
    public class VattuOpening : ObjectBase
    {


        public VattuOpening()
        {
        }

        public VattuOpening(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    periodCode = (obj as VattuOpening).periodCode;
        //    stockCode = (obj as VattuOpening).stockCode;
        //    vattuCode = (obj as VattuOpening).vattuCode;
        //    quantity = (obj as VattuOpening).quantity;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PeriodCode", reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("VattuCode", reader)) vattuCode = reader.GetString(reader.GetOrdinal("VattuCode"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("PeriodCode")) periodCode = (string)row["PeriodCode"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("VattuCode")) vattuCode = (string)row["VattuCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("Amount")) amount  = (decimal)row["Amount"];
        }

        #region Public Properties



        private string periodCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of PeriodCode
        /// </summary>
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }

        private decimal amount=0;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        /// <summary>
        /// Gets or sets the value of PeriodCode
        /// </summary>
       

        private string stockCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockCode
        /// </summary>
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
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
            set { quantity = value; }
        }

        #endregion

        #region Lists
        #endregion


    }
    #endregion

    public class VattuOpeningList : ObjectBase
    {
        private ListBase<VattuOpening> listVattuOpening;
        public ListBase<VattuOpening> ListVattuOpening
        {
            get { return listVattuOpening; }
            set { listVattuOpening = value; }
        }
    }
}	
