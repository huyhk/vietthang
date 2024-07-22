using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data.Grinds
{
    public class GrindMaterialShift : UserTracking2
    {
        public GrindMaterialShift()
        { }
    
        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("GrindMaterialShiftID", reader)) _grindMaterialShiftID = reader.GetGuid(reader.GetOrdinal("GrindMaterialShiftID"));
                if (!isNull("StockCode", reader)) _stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("GrindDate", reader)) _grindDate = reader.GetDateTime(reader.GetOrdinal("GrindDate"));
                if (!isNull("Shift", reader)) _shift = reader.GetByte(reader.GetOrdinal("Shift"));
                if (!isNull("Status", reader)) _status = reader.GetByte(reader.GetOrdinal("Status"));
                if (!isNull("UserCreatedST", reader)) _userCreatedST = reader.GetString(reader.GetOrdinal("UserCreatedST"));
                if (!isNull("DateCreatedST", reader)) _dateCreatedST = reader.GetDateTime(reader.GetOrdinal("DateCreatedST"));

                if (!isNull("ShiftLeader", reader)) shiftLeader = reader.GetString(reader.GetOrdinal("ShiftLeader"));
            }
        }
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("GrindMaterialShiftID")) _grindMaterialShiftID = (Guid)row["GrindMaterialShiftID"];
            if (!row.IsNull("StockCode")) _stockCode = (String)row["StockCode"];
            if (!row.IsNull("GrindDate")) _grindDate = (DateTime)row["GrindDate"];
            if (!row.IsNull("Shift")) _shift = (Byte)row["Shift"];
            if (!row.IsNull("Status")) _status = (Byte)row["Status"];
            if (!row.IsNull("UserCreatedST")) _userCreatedST = (String)row["UserCreatedST"];
            if (!row.IsNull("DateCreatedST")) _dateCreatedST = (DateTime)row["DateCreatedST"];

            if (!row.IsNull("ShiftLeader")) shiftLeader = (String)row["ShiftLeader"];
        }
        #region Public Properties


        protected Guid _grindMaterialShiftID;
        public Guid GrindMaterialShiftID
        {
            set { _grindMaterialShiftID = value; }
            get { return _grindMaterialShiftID; }
        }
        protected int _status;
        public int Status
        {
            set { _status = value; }
            get { return _status; }
        }

        protected string _userCreatedST = String.Empty;
        public string UserCreatedST
        {
            set { _userCreatedST = value; }
            get { return _userCreatedST; }
        }
        protected DateTime _dateCreatedST=Contexts.WorkingDate;
        public DateTime DateCreatedST
        {
            set { _dateCreatedST = value; }
            get { return _dateCreatedST; }
        }
        
        protected string _stockCode = String.Empty;
        public string StockCode
        {
            set { _stockCode = value; }
            get { return _stockCode; }
        }

        protected DateTime _grindDate = Contexts.WorkingDate;
        public DateTime GrindDate
        {
            set { _grindDate = value; }
            get { return _grindDate; }
        }

        protected int _shift=1;
        public int Shift
        {
            set { _shift = value; }
            get { return _shift; }
        }

        protected ListBase<GrindMaterials> lstGrindMaterial = new ListBase<GrindMaterials>();
        public ListBase<GrindMaterials> LstGrindMaterial
        {
            set { lstGrindMaterial = value; }
            get { return lstGrindMaterial; }
        }

        protected string shiftLeader = String.Empty;
        public string ShiftLeader
        {
            set { shiftLeader = value; }
            get { return shiftLeader; }
        }
        #endregion


    }
}
