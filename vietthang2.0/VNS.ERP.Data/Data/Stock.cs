using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class Stock:UserTracking2
    {
        public Stock()
        {  
        }
        public Stock(IDataReader Reader)
        {
            this.FromDataReader(Reader);
            //this.LoadFromReader(Reader);
        }
        public Stock(DataRow row)
        {
            this.FromDataRow(row);
        }
        public override void FromDataReader(IDataReader Reader)
        {
            if (Reader != null && !Reader.IsClosed)
            {
                //int count=Reader.Count;
                if (!isNull("StockCode", Reader)) _StockCode = Reader.GetString(Reader.GetOrdinal("StockCode"));
                if (!isNull("StockName", Reader)) _StockName = Reader.GetString(Reader.GetOrdinal("StockName"));
                if (!isNull("Address", Reader)) _Address = Reader.GetString(Reader.GetOrdinal("Address"));
                if (!isNull("Phone", Reader)) _Phone = Reader.GetString(Reader.GetOrdinal("Phone"));
                if (!isNull("Fax", Reader)) _Fax = Reader.GetString(Reader.GetOrdinal("Fax"));
                if (!isNull("Description", Reader)) _Description = Reader.GetString(Reader.GetOrdinal("Description"));
                if (!isNull("Controller", Reader)) _Controller = Reader.GetString(Reader.GetOrdinal("Controller"));
                if (!isNull("IsManufacture", Reader)) _IsManufacture = Reader.GetBoolean(Reader.GetOrdinal("IsManufacture"));
                if (!isNull("HasLocation", Reader)) _HasLocation = Reader.GetBoolean(Reader.GetOrdinal("HasLocation"));
                if (!isNull("SoHieu", Reader)) _SoHieu = Reader.GetString(Reader.GetOrdinal("SoHieu"));
                if (!isNull("BranchCode", Reader)) branchCode = Reader.GetString(Reader.GetOrdinal("BranchCode"));
                if (!isNull("InActive", Reader)) inActive = Reader.GetBoolean(Reader.GetOrdinal("InActive"));
                if (!isNull("StockType", Reader)) stockType = Reader.GetString(Reader.GetOrdinal("StockType"));
            }
            base.FromDataReader(Reader);
        }
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("StockCode")) _StockCode = (string)row["StockCode"];
            if (!row.IsNull("Controller")) _Controller = (string)row["Controller"];
            if (!row.IsNull("StockName")) _StockName = (string)row["StockName"];
            if (!row.IsNull("Address")) _Address = (string)row["Address"];
            if (!row.IsNull("Phone")) _Phone = (string)row["Phone"];
            if (!row.IsNull("Fax")) _Fax = (string)row["Fax"];
            if (!row.IsNull("Description")) _Description = (string)row["Description"];
            if (!row.IsNull("IsManufacture")) _IsManufacture = (bool)row["IsManufacture"];
            if (!row.IsNull("HasLocation")) _HasLocation = (bool)row["HasLocation"];
            if (!row.IsNull("SoHieu")) _SoHieu = (string)row["SoHieu"];
            if (!row.IsNull("BranchCode")) branchCode = (string)row["BranchCode"];
            if (!row.IsNull("InActive")) inActive = (bool)row["InActive"];
            if (!row.IsNull("StockType")) stockType = (string)row["StockType"];
        }
        #region Public Properties
        protected string _StockCode = string.Empty;
        public string StockCode
        {
            get { return _StockCode; }
            set { _StockCode = value; }
        }
        protected string _StockName = string.Empty;
        public string StockName
        {
            get { return _StockName; }
            set { _StockName = value; }
        }
        protected string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value;}
        }
        protected string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        protected string _Fax;
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }
        protected string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        protected string _Controller;
        public string Controller
        {
            get { return _Controller; }
            set { _Controller = value; }
        }
        protected bool _IsManufacture;
        public bool IsManufacture
        {
            get { return _IsManufacture; }
            set { _IsManufacture = value; }
        }
        protected bool _HasLocation;
        public bool HasLocation
        {
            get { return _HasLocation; }
            set { _HasLocation = value; }
        }
        protected string _SoHieu;
        public string SoHieu
        {
            get { return _SoHieu; }
            set { _SoHieu = value; }
        }
        private string branchCode = string.Empty;
        public string BranchCode
        {
            get { return branchCode; }
            set { branchCode = value; }
        }
        private bool inActive = false;
        public bool InActive
        {
            get { return inActive; }
            set { inActive = value; }
        }
        private string stockType = string.Empty;
        public string StockType
        {
            get { return stockType; }
            set { stockType = value; }
        }
        #endregion

        #region list
        ListBase<ItemStockAuto> listItemStockAuto = new ListBase<ItemStockAuto>();
        public ListBase<ItemStockAuto> ListItemStockAuto
        {
            get { return listItemStockAuto; }
            set { listItemStockAuto = value; }
        }
        #endregion
    }

    #region ItemStockAuto
    /// <summary>
    /// This object represents the properties and methods of a ItemStockAuto.
    /// </summary>
    public class ItemStockAuto : ObjectBase
    {


        public ItemStockAuto()
        {
        }



        public ItemStockAuto(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public ItemStockAuto(DataRow row)
        {
            this.FromDataRow(row);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("OutByFormula", reader)) outByFormula = reader.GetBoolean(reader.GetOrdinal("OutByFormula"));
                if (!isNull("OutToStock", reader)) outToStock = reader.GetBoolean(reader.GetOrdinal("OutToStock"));
            }
        }
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("OutByFormula")) outByFormula = (bool)row["OutByFormula"];
            if (!row.IsNull("OutToStock")) outToStock = (bool)row["OutToStock"];
        }
        #region Public Properties



        private string itemCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
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

        private bool outByFormula;
        /// <summary>
        /// Gets or sets the value of OutByFormula
        /// </summary>
        public bool OutByFormula
        {
            get { return outByFormula; }
            set { outByFormula = value; }
        }

        private bool outToStock;
        /// <summary>
        /// Gets or sets the value of OutToStock
        /// </summary>
        public bool OutToStock
        {
            get { return outToStock; }
            set { outToStock = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}
