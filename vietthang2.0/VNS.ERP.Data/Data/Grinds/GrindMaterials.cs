using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data.Grinds
{
    public class GrindMaterials : UserTracking2
    {
        public GrindMaterials()
        { }
        public GrindMaterials(DbDataReader Reader)
        {
            this.FromDataReader(Reader);
        }
        public override void LoadFromDataRow(DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("GrindMaterialID")) _grindMaterialID = (Guid)row["GrindMaterialID"];
            if (!row.IsNull("GrindCode")) _grindCode = (String)row["GrindCode"];
            if (!row.IsNull("FormulaCode")) _formulaCode = (String)row["FormulaCode"];
            if (!row.IsNull("Nap")) _nap = (Decimal)row["Nap"];
            if (!row.IsNull("MaterialWeight")) _materialWeight = (Decimal)row["MaterialWeight"];
            if (!row.IsNull("Wrapping")) _wrapping = (Decimal)row["Wrapping"];
            if (!row.IsNull("WrappingWaste")) _wrappingWaste = (Decimal)row["WrappingWaste"];
            if (!row.IsNull("Description")) _description = (String)row["Description"];
            if (!row.IsNull("PlanNo")) planNo = (String)row["PlanNo"];

            if (!row.IsNull("LinesxNo")) _linesxNo = (Byte)row["LinesxNo"];
            if (!row.IsNull("EmployeeID1")) _employeeID1 = (String)row["EmployeeID1"];
            if (!row.IsNull("EmployeeID2")) _employeeID2 = (String)row["EmployeeID2"];
            if (!row.IsNull("Am")) _am = (Decimal)row["Am"];
            if (!row.IsNull("StartTime")) _startTime = (DateTime)row["StartTime"];
            if (!row.IsNull("EndTime")) _endTime = (DateTime)row["EndTime"];
            if (!row.IsNull("DelayTime")) _delayTime = (int)row["DelayTime"];
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("GrindMaterialID", reader)) _grindMaterialID = reader.GetGuid(reader.GetOrdinal("GrindMaterialID"));
                if (!isNull("GrindMaterialShiftID", reader)) _grindMaterialShiftID = reader.GetGuid(reader.GetOrdinal("GrindMaterialShiftID"));
                if (!isNull("GrindCode", reader)) _grindCode = reader.GetString(reader.GetOrdinal("GrindCode"));
                if (!isNull("FormulaCode", reader)) _formulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
                if (!isNull("Nap", reader)) _nap = reader.GetDecimal(reader.GetOrdinal("Nap"));
                if (!isNull("MaterialWeight", reader)) _materialWeight = reader.GetDecimal(reader.GetOrdinal("MaterialWeight"));
                if (!isNull("Wrapping", reader)) _wrapping = reader.GetDecimal(reader.GetOrdinal("Wrapping"));
                if (!isNull("WrappingWaste", reader)) _wrappingWaste = reader.GetDecimal(reader.GetOrdinal("WrappingWaste"));
                if (!isNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!isNull("PlanNo", reader)) planNo = reader.GetString(reader.GetOrdinal("PlanNo"));

                if (!isNull("LinesxNo", reader)) _linesxNo = reader.GetByte(reader.GetOrdinal("LinesxNo"));
                if (!isNull("EmployeeID1", reader)) _employeeID1 = reader.GetString(reader.GetOrdinal("EmployeeID1"));
                if (!isNull("EmployeeID2", reader)) _employeeID2 = reader.GetString(reader.GetOrdinal("EmployeeID2"));
                if (!isNull("Am", reader)) _am = reader.GetDecimal(reader.GetOrdinal("Am"));
                if (!isNull("StartTime", reader)) _startTime = reader.GetDateTime(reader.GetOrdinal("StartTime"));
                if (!isNull("EndTime", reader)) _endTime = reader.GetDateTime(reader.GetOrdinal("EndTime"));
                if (!isNull("DelayTime", reader)) _delayTime = reader.GetInt32(reader.GetOrdinal("DelayTime"));
            }
           base.FromDataReader(reader);
        }

        #region Public Properties

        protected Guid _grindMaterialID;
        public Guid GrindMaterialID
        {
            set { _grindMaterialID = value; }
            get { return _grindMaterialID; }
        }
        protected Guid _grindMaterialShiftID;
        public Guid GrindMaterialShiftID
        {
            set { _grindMaterialShiftID = value; }
            get { return _grindMaterialShiftID; }
        }

        protected string _grindCode = String.Empty;
        public string GrindCode
        {
            set { _grindCode = value; }
            get { return _grindCode; }
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


        protected decimal _materialWeight;
        public decimal MaterialWeight
        {
            set { _materialWeight = value; }
            get { return _materialWeight; }
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

        protected string planNo = String.Empty;
        public string PlanNo
        {
            set { planNo = value; }
            get { return planNo; }
        }

        protected int _linesxNo = 1;
        public int LinesxNo
        {
            set { _linesxNo = value; }
            get { return _linesxNo; }
        }

        protected string _employeeID1 = String.Empty;
        public string EmployeeID1
        {
            set { _employeeID1 = value; }
            get { return _employeeID1; }
        }
        protected string _employeeID2 = String.Empty;
        public string EmployeeID2
        {
            set { _employeeID2 = value; }
            get { return _employeeID2; }
        }

        protected decimal _am;
        public decimal Am
        {
            set { _am = value; }
            get { return _am; }
        }

        protected DateTime _startTime = DateTime.Today;
        public DateTime StartTime
        {
            set { _startTime = value; }
            get { return _startTime; }
        }
        protected DateTime _endTime = DateTime.Today;
        public DateTime EndTime
        {
            set { _endTime = value; }
            get { return _endTime; }
        }

        protected int _delayTime;
        public int DelayTime
        {
            set { _delayTime = value; }
            get { return _delayTime; }
        }
        public DateTime DTDelayTime
        {
            get { return DateTime.MinValue.AddMinutes(_delayTime); }
            set { _delayTime = int.Parse(((DateTime)value).TimeOfDay.TotalMinutes.ToString()); }
        }


        protected ListBase<GrindMaterialTransactions> lstDieuchinh ;
        public ListBase<GrindMaterialTransactions> LstDieuchinh
        {
            set { lstDieuchinh = value; }
            get { return lstDieuchinh; }
        }

        protected ListBase<GrindMaterialTransactions> lstWrappingIn;
        public ListBase<GrindMaterialTransactions> LstWrappingIn
        {
            set { lstWrappingIn = value; }
            get { return lstWrappingIn; }
        }

        protected ListBase<GrindMaterialTransactions> lstWrappingWasteIn;
        public ListBase<GrindMaterialTransactions> LstWrappingWasteIn
        {
            set { lstWrappingWasteIn = value; }
            get { return lstWrappingWasteIn; }
        }

        protected ListBase<GrindMaterialTransactions> lstMaterialOut;
        public ListBase<GrindMaterialTransactions> LstMaterialOut
        {
            set { lstMaterialOut = value; }
            get { return lstMaterialOut; }
        }

        protected ListBase<GrindMaterialTransactions> lstMaterialIn;
        public ListBase<GrindMaterialTransactions> LstMaterialIn
        {
            set { lstMaterialIn = value; }
            get { return lstMaterialIn; }
        }


        protected ListBase<GrindMaterialTransactions> lstTaiche;
        public ListBase<GrindMaterialTransactions> LstTaiche
        {
            set { lstTaiche = value; }
            get { return lstTaiche; }
        }

        protected ListBase<GrindMaterialTransactions> lstNhienlieu;
        public ListBase<GrindMaterialTransactions> LstNhienlieu
        {
            set { lstNhienlieu = value; }
            get { return lstNhienlieu; }
        }

        protected ListBase<GrindMaterialTransactions> lstPhepham;
        public ListBase<GrindMaterialTransactions> LstPhepham
        {
            set { lstPhepham = value; }
            get { return lstPhepham; }
        }

        public void NewList()
        {
            this.lstDieuchinh = new ListBase<GrindMaterialTransactions>();
            this.lstNhienlieu = new ListBase<GrindMaterialTransactions>();
            this.lstPhepham = new ListBase<GrindMaterialTransactions>();
            this.lstTaiche = new ListBase<GrindMaterialTransactions>();
        }
        #endregion


    }
}
