using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data.Premixs
{
    public class MixPremix : UserTracking2
    {
        public MixPremix()
        { }
        public MixPremix(DbDataReader Reader)
        {
            this.FromDataReader(Reader);
        }

        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("MixPremixID")) _mixPremixID = (Guid)row["MixPremixID"];
            if (!row.IsNull("PremixCode")) _premixCode = (String)row["PremixCode"];
            if (!row.IsNull("FormulaCode")) _formulaCode = (String)row["FormulaCode"];
            if (!row.IsNull("Nap")) _nap = (Decimal)row["Nap"];
            if (!row.IsNull("PremixWeight")) _premixWeight = (Decimal)row["PremixWeight"];
            if (!row.IsNull("Wrapping")) _wrapping = (Decimal)row["Wrapping"];
            if (!row.IsNull("WrappingWaste")) _wrappingWaste = (Decimal)row["WrappingWaste"];
            if (!row.IsNull("Description")) _description = (String)row["Description"];
            if (!row.IsNull("PremixWrappingCode")) premixWrappingCode = (String)row["PremixWrappingCode"];
            if (!row.IsNull("Premixer")) premixer = (String)row["Premixer"];
            if (!row.IsNull("TonPerCode")) tonPerCode = (Decimal)row["TonPerCode"];

        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("MixPremixID", reader)) _mixPremixID = reader.GetGuid(reader.GetOrdinal("MixPremixID"));
                if (!isNull("MixPremixShiftID", reader)) _mixPremixShiftID = reader.GetGuid(reader.GetOrdinal("MixPremixShiftID"));
                if (!isNull("PremixCode", reader)) _premixCode = reader.GetString(reader.GetOrdinal("PremixCode"));
                if (!isNull("FormulaCode", reader)) _formulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
                if (!isNull("Nap", reader)) _nap = reader.GetDecimal(reader.GetOrdinal("Nap"));
                if (!isNull("PremixWeight", reader)) _premixWeight = reader.GetDecimal(reader.GetOrdinal("PremixWeight"));
                if (!isNull("Wrapping", reader)) _wrapping = reader.GetDecimal(reader.GetOrdinal("Wrapping"));
                if (!isNull("WrappingWaste", reader)) _wrappingWaste = reader.GetDecimal(reader.GetOrdinal("WrappingWaste"));
                if (!isNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));

                if (!isNull("Premixer", reader)) premixer = reader.GetString(reader.GetOrdinal("Premixer"));
                if (!isNull("PremixWrappingCode", reader)) premixWrappingCode = reader.GetString(reader.GetOrdinal("PremixWrappingCode"));
                if (!isNull("TonPerCode", reader)) tonPerCode = reader.GetDecimal(reader.GetOrdinal("TonPerCode"));
            }
            base.FromDataReader(reader);
        }
     

        #region Public Properties
       
        protected Guid _mixPremixID;
        public Guid MixPremixID
        {
            set { _mixPremixID = value; }
            get { return _mixPremixID; }
        }
        protected Guid _mixPremixShiftID;
        public Guid MixPremixShiftID
        {
            set { _mixPremixShiftID = value; }
            get { return _mixPremixShiftID; }
        }
        protected string _premixCode = String.Empty;
        public string PremixCode
        {
            set { _premixCode = value; }
            get { return _premixCode; }
        }

        protected string _formulaCode = String.Empty;
        public string FormulaCode
        {
            set { _formulaCode = value; }
            get { return _formulaCode; }
        }
        protected decimal _nap;
        public decimal Nap
        {
            set { _nap = value; }
            get { return _nap; }
        }


        protected decimal _premixWeight;
        public decimal PremixWeight
        {
            set { _premixWeight = value; }
            get { return _premixWeight; }
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
        protected decimal _wrappingWaste;
        public decimal WrappingWaste
        {
            set { _wrappingWaste = value; }
            get { return _wrappingWaste; }
        }

        protected decimal _wrapping = 0;
        public decimal Wrapping
        {
            set { _wrapping = value; }
            get { return _wrapping; }
        }

        protected string _description = String.Empty;
        public string Description
        {
            set { _description = value; }
            get { return _description; }
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

        protected int _shift;
        public int Shift
        {
            set { _shift = value; }
            get { return _shift; }
        }

     
        protected ListBase<MixPremixTransaction> lstDieuchinh;
        public ListBase<MixPremixTransaction> LstDieuchinh
        {
            set { lstDieuchinh = value; }
            get { return lstDieuchinh; }
        }

        protected ListBase<MixPremixTransaction> lstWrappingIn;
        public ListBase<MixPremixTransaction> LstWrappingIn
        {
            set { lstWrappingIn = value; }
            get { return lstWrappingIn; }
        }

        protected ListBase<MixPremixTransaction> lstWrappingWasteIn;
        public ListBase<MixPremixTransaction> LstWrappingWasteIn
        {
            set { lstWrappingWasteIn = value; }
            get { return lstWrappingWasteIn; }
        }

        protected ListBase<MixPremixTransaction> lstPremixOut;
        public ListBase<MixPremixTransaction> LstPremixOut
        {
            set { lstPremixOut = value; }
            get { return lstPremixOut; }
        }

        protected ListBase<MixPremixTransaction> lstMaterialIn;
        public ListBase<MixPremixTransaction> LstMaterialIn
        {
            set { lstMaterialIn = value; }
            get { return lstMaterialIn; }
        }
      

        #endregion

        //    public enum enumMixPremixTransactionType { ProductOut = 1, AdjustIn, MaterialIn, WrappingPremixIn, WrappingPremixWasteOut }

        #region WS
        private string premixWrappingCode = string.Empty;

        public string PremixWrappingCode
        {
            get { return premixWrappingCode; }
            set { premixWrappingCode = value; }
        }

        private string premixer = string.Empty;

        public string Premixer
        {
            get { return premixer; }
            set { premixer = value; }
        }
        private decimal tonPerCode;

        public decimal TonPerCode
        {
            get { return tonPerCode; }
            set { tonPerCode = value; }
        }
	


	
        #endregion
    }
}
