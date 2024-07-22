using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data.Premixs
{
    public class MixPremixShift : UserTracking2
    {
        public MixPremixShift()
        { }
    
        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("MixPremixShiftID", reader)) _mixPremixShiftID = reader.GetGuid(reader.GetOrdinal("MixPremixShiftID"));
                if (!isNull("StockCode", reader)) _stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("MixDate", reader)) _mixDate = reader.GetDateTime(reader.GetOrdinal("MixDate"));
                if (!isNull("Shift", reader)) _shift = reader.GetByte(reader.GetOrdinal("Shift"));
                if (!isNull("Status", reader)) _status = reader.GetByte(reader.GetOrdinal("Status"));
                if (!isNull("UserCreatedST", reader)) _userCreatedST = reader.GetString(reader.GetOrdinal("UserCreatedST"));
                if (!isNull("DateCreatedST", reader)) _dateCreatedST = reader.GetDateTime(reader.GetOrdinal("DateCreatedST"));
            }
        }
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("MixPremixShiftID")) _mixPremixShiftID = (Guid)row["MixPremixShiftID"];
            if (!row.IsNull("StockCode")) _stockCode = (String)row["StockCode"];
            if (!row.IsNull("MixDate")) _mixDate = (DateTime)row["MixDate"];
            if (!row.IsNull("Shift")) _shift = (Byte)row["Shift"];
            if (!row.IsNull("Status")) _status = (Byte)row["Status"];
            if (!row.IsNull("UserCreatedST")) _userCreatedST = (String)row["UserCreatedST"];
            if (!row.IsNull("DateCreatedST")) _dateCreatedST = (DateTime)row["DateCreatedST"];
        }
        #region Public Properties


        protected Guid _mixPremixShiftID;
        public Guid MixPremixShiftID
        {
            set { _mixPremixShiftID = value; }
            get { return _mixPremixShiftID; }
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
        protected DateTime _dateCreatedST = Contexts.WorkingDate;
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

        protected DateTime _mixDate = Contexts.WorkingDate;
        public DateTime MixDate
        {
            set { _mixDate = value; }
            get { return _mixDate; }
        }

        protected int _shift=1;
        public int Shift
        {
            set { _shift = value; }
            get { return _shift; }
        }

        protected ListBase<MixPremix> lstMixPremix = new ListBase<MixPremix>();
        public ListBase<MixPremix> LstMixPremix
        {
            set { lstMixPremix = value; }
            get { return lstMixPremix; }
        }
        #endregion

        #region WS
        private MixPremix objMixPremix = new MixPremix();

        public MixPremix ObjMixPremix
        {
            get { return objMixPremix; }
            set { objMixPremix = value; }
        }

	
        #endregion
    }
}
