using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class Item : UserTracking2 
    {
       
        public Item()
        { }

       public Item(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ItemCode", reader)) _ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("ItemName", reader)) _ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
            if (!isNull("Unit", reader)) _Unit= reader.GetString(reader.GetOrdinal("Unit"));
            if (!isNull("UnitWeight", reader)) _UnitWeight = reader.GetDecimal(reader.GetOrdinal("UnitWeight"));
            if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("ItemType", reader)) _ItemType = reader.GetInt16  (reader.GetOrdinal("ItemType"));
            if (!isNull("OutByFormula", reader)) _OutByFormula = reader.GetBoolean(reader.GetOrdinal("OutByFormula"));
            if (!isNull("OutToStock", reader)) _OutToStock = reader.GetBoolean(reader.GetOrdinal("OutToStock"));
            if (!isNull("ItemGroup", reader)) itemGroup = reader.GetString(reader.GetOrdinal("ItemGroup"));

            if (!isNull("Masapxep", reader)) masapxep = reader.GetString(reader.GetOrdinal("Masapxep"));
            if (!isNull("InActive", reader)) inActive = reader.GetBoolean(reader.GetOrdinal("InActive"));

            if (!isNull("Code2", reader)) code2 = reader.GetString(reader.GetOrdinal("Code2"));
        }

        public ListBase<string> ColorName2
        {
            get { return null; }

        }
       protected string  _ItemCode;
       public string ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }
        protected string _Unit=string.Empty;
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }
        protected decimal _UnitWeight=0;
        public decimal UnitWeight
        {
            get { return _UnitWeight; }
            set { _UnitWeight = value; }
        }
       protected string _ItemName;
       public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

      
      protected string _Description=string.Empty;
      public string Description
      {
          get { return _Description; }
          set { _Description = value; }
      }
       protected int _ItemType;
       public int ItemType
        {
          get { return _ItemType; }
          set { _ItemType = value; }
        }
       protected bool  _OutByFormula=false;
       public bool  OutByFormula
       {
           get { return _OutByFormula; }
           set { _OutByFormula = value; }
       }

       protected bool _OutToStock = false;
        public bool OutToStock
       {
           get { return _OutToStock; }
           set { _OutToStock = value; }
       }

        protected string itemGroup = String.Empty;
        public string ItemGroup
        {
            get { return itemGroup; }
            set { itemGroup = value; }
        }

        protected string masapxep = String.Empty;
        public string Masapxep
        {
            get { return masapxep; }
            set { masapxep = value; }
        }

        private bool inActive = false;
        public bool InActive
        {
            get { return inActive; }
            set { inActive = value; }
        }
        private string code2 = string.Empty;

        public string Code2
        {
            get { return code2; }
            set { code2 = value; }
        }

	
    }

    //public enum enumItemType { Product = 1, Wrapping, Material, Fuel, Waste, Premix, WrappingMaterial, WrappingPremix }
}
