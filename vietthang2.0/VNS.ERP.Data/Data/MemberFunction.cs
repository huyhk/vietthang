using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace VNS.ERP.Data
{
    public class MemberFunction:BaseClass
    {
        public MemberFunction() { }
        public MemberFunction(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                //int count=Reader.Count;
                if (!isNull("MemberID", reader)) _MemberID = reader.GetString(reader.GetOrdinal("MemberID"));
                if (!isNull("FunctionName", reader)) _FunctionName = reader.GetString(reader.GetOrdinal("FunctionName"));
                if (!isNull("AllowView", reader)) _AllowView = reader.GetBoolean(reader.GetOrdinal("AllowView"));
                if (!isNull("AllowAdd", reader)) _AllowAdd = reader.GetBoolean(reader.GetOrdinal("AllowAdd"));
                if (!isNull("AllowEdit", reader)) _AllowEdit = reader.GetBoolean(reader.GetOrdinal("AllowEdit"));
                if (!isNull("AllowDelete", reader)) _AllowDelete = reader.GetBoolean(reader.GetOrdinal("AllowDelete"));
                if (!isNull("AllowEditOther", reader)) allowEditOther = reader.GetBoolean(reader.GetOrdinal("AllowEditOther"));
                if (!isNull("AllowDeleteOther", reader)) allowDeleteOther = reader.GetBoolean(reader.GetOrdinal("AllowDeleteOther"));
            }
                base.FromDataReader(reader);
        }
        protected string _MemberID;
        public string MemberID
        {
            get { return _MemberID; }
            set { _MemberID = value; }
        }
        protected string _FunctionName;
        public string FunctionName
        {
            get { return _FunctionName; }
            set { _FunctionName = value; }
        }
        protected bool _AllowView;
        public bool AllowView
        {
            get { return _AllowView; }
            set { _AllowView = value; }
        }
        protected bool _AllowAdd;
        public bool AllowAdd
        {
            get { return _AllowAdd; }
            set { _AllowAdd = value; }
        }
        protected bool _AllowEdit;
        public bool AllowEdit
        {
            get { return _AllowEdit; }
            set { _AllowEdit = value; }
        }
        protected bool _AllowDelete;
        public bool AllowDelete
        {
            get { return _AllowDelete; }
            set { _AllowDelete = value; }
        }

        protected bool allowEditOther = false;
        public bool AllowEditOther
        {
            get { return allowEditOther; }
            set { allowEditOther = value; }
        }
        protected bool allowDeleteOther = false;
        public bool AllowDeleteOther
        {
            get { return allowDeleteOther; }
            set { allowDeleteOther = value; }
        }
    }
}
