using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureShift : UserTracking2
    {
        public ManufactureShift()
        {
        }
        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);

            if (reader != null && !reader.IsClosed)
            {

                //ManufactureShifts
                if (!isNull("ManufactureShiftID", reader)) _manufactureShiftID = reader.GetGuid(reader.GetOrdinal("ManufactureShiftID"));
                if (!isNull("StockCode", reader)) _stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("ManufactureDate", reader)) _manufactureDate = reader.GetDateTime(reader.GetOrdinal("ManufactureDate"));
                if (!isNull("Shift", reader)) _shift = reader.GetByte(reader.GetOrdinal("Shift"));
                if (!isNull("ShiftLeader", reader)) _shiftLeader = reader.GetString(reader.GetOrdinal("ShiftLeader"));
                if (!isNull("ViceLeader", reader)) _viceLeader = reader.GetString(reader.GetOrdinal("ViceLeader"));
                if (!isNull("Status", reader)) _status = reader.GetByte(reader.GetOrdinal("Status"));
                if (!isNull("UserCreatedST", reader)) _userCreatedST = reader.GetString(reader.GetOrdinal("UserCreatedST"));
                if (!isNull("DateCreatedST", reader)) _dateCreatedST = reader.GetDateTime(reader.GetOrdinal("DateCreatedST"));

            }
            
        }
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);


            if (!row.IsNull("ManufactureShiftID")) _manufactureShiftID = (Guid)row["ManufactureShiftID"];
            if (!row.IsNull("StockCode")) _stockCode = (String)row["StockCode"];
            if (!row.IsNull("ManufactureDate")) _manufactureDate = (DateTime)row["ManufactureDate"];
            if (!row.IsNull("Shift")) _shift = (Byte)row["Shift"];
            if (!row.IsNull("ShiftLeader")) _shiftLeader = (String)row["ShiftLeader"];
            if (!row.IsNull("ViceLeader")) _viceLeader = (String)row["ViceLeader"];
            if (!row.IsNull("Status")) _status = (Byte) row["Status"];
            if (!row.IsNull("UserCreatedST")) _userCreatedST = (String)row["UserCreatedST"];
            if (!row.IsNull("DateCreatedST")) _dateCreatedST = (DateTime)row["DateCreatedST"];
        }
        protected Guid _manufactureShiftID;
        public Guid ManufactureShiftID
        {
            set { _manufactureShiftID = value; }
            get { return _manufactureShiftID; }
        }

        protected string _stockCode = String.Empty;
        public string StockCode
        {
            set { _stockCode = value; }
            get { return _stockCode; }
        }

        protected DateTime _manufactureDate = Contexts.WorkingDate;
        public DateTime ManufactureDate
        {
            set { _manufactureDate = value; }
            get { return _manufactureDate; }
        }

        protected int _shift = 1;
        public int Shift
        {
            set { _shift = value; }
            get { return _shift; }
        }

        protected string _shiftLeader = String.Empty;
        public string ShiftLeader
        {
            set { _shiftLeader = value; }
            get { return _shiftLeader; }
        }
        protected string _viceLeader = String.Empty;
        public string ViceLeader
        {
            set { _viceLeader = value; }
            get { return _viceLeader; }
        }
        protected int _status = 0;
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
        protected DateTime _dateCreatedST = Contexts.WorkingDate;
        public DateTime DateCreatedST
        {
            set { _dateCreatedST = value; }
            get { return _dateCreatedST; }
        }

        protected ListBase<Manufacture> _lstManufacture = new ListBase<Manufacture>();
        public ListBase<Manufacture> ListManufacture
        {
            set { _lstManufacture = value; }
            get { return _lstManufacture; }
        }

        public ListBase<ManufactureShiftTransaction> ListFuelInTransaction=new ListBase<ManufactureShiftTransaction>();

        private string shiftLeaderName = string.Empty;

        public string ShiftLeaderName
        {
            get { return shiftLeaderName; }
            set { shiftLeaderName = value; }
        }

        private string viceLeaderName = string.Empty;

        public string ViceLeaderName
        {
            get { return viceLeaderName; }
            set { viceLeaderName = value; }
        }

        private Manufacture objManufacture = new Manufacture();

        public Manufacture ObjManufacture
        {
            get { return objManufacture; }
            set { objManufacture = value; }
        }
	
	
	
    }
}
