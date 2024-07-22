using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class Member:UserTracking2
    {
        public Member()
        { }

        public Member(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public Member(System.Data.IDataReader reader, bool oneObjOnly)
        {
            this.FromDataReader(reader);
            if (oneObjOnly)
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        int i = reader.GetInt32(reader.GetOrdinal("PropertyID"));
                        Properties[i] = reader.GetString(reader.GetOrdinal("PropertyValue"));
                    }
                }
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("MemberID", reader)) _memberID = reader.GetString(reader.GetOrdinal("MemberID"));
            if (!isNull("MemberType", reader)) MemberType = reader.GetByte(reader.GetOrdinal("MemberType"));
            if (!isNull("MemberName", reader)) _memberName = reader.GetString(reader.GetOrdinal("MemberName"));
            if (!isNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("BranchCode", reader)) branchCode = reader.GetString(reader.GetOrdinal("BranchCode"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
        }
        public void FromDataReader(System.Data.IDataReader reader, bool oneObjOnly)
        {
            base.FromDataReader(reader);
            if (!isNull("MemberID", reader)) _memberID = reader.GetString(reader.GetOrdinal("MemberID"));
            if (!isNull("MemberType", reader)) MemberType = reader.GetByte(reader.GetOrdinal("MemberType"));
            if (!isNull("MemberName", reader)) _memberName = reader.GetString(reader.GetOrdinal("MemberName"));
            if (!isNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("BranchCode", reader)) branchCode = reader.GetString(reader.GetOrdinal("BranchCode"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (oneObjOnly)
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        int i = reader.GetByte(reader.GetOrdinal("PropertyID"));
                        Properties[i] = reader.GetString(reader.GetOrdinal("PropertyValue"));
                    }
                }
        }
        protected string _memberID = string.Empty;
        public string MemberID
        {
            get { return _memberID; }
            set { _memberID = value; }
        }

        protected string _memberName = string.Empty;
        public string MemberName
        {
            get { return _memberName; }
            set { _memberName = value; }
        }

        protected byte _memberType;
        public byte MemberType
        {
            get { return _memberType; }
            set 
            { 
                _memberType = value;
                switch (value)
                {
                    case (byte)enumMemberType.Group:
                        break;
                    case (byte)enumMemberType.User:
                        Properties = new string[Enum.GetNames(typeof(enumUserProperties)).Length];
                        break;
                }
            }
        }

        protected string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string[] properties;
        public string[] Properties
        {
            get { return properties; }
            set { properties = value; }
        }
        private string branchCode = string.Empty;
        public string BranchCode
        {
            get { return branchCode; }
            set { branchCode = value; }
        }
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
    }
    public class UserERP : Member
    {
        public UserERP()
        {
            this.MemberType = (int)enumMemberType.User;
        }
        public UserERP(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public UserERP(Member mb)
        {
            if (mb != null)
            {
                this._memberID = mb.MemberID;
                this._memberName = mb.MemberName;
                this._description = mb.Description;
                this.MemberType = mb.MemberType;
                this.Properties = mb.Properties;
            }
        }

        public string LoginName
        {
            get { return _memberID; }
            set { _memberID = value; }
        }

        public string Password
        {
            set { Properties[(int)enumUserProperties.Password] = value; }
            get { return Properties[(int)enumUserProperties.Password]; }
        }
        public string UserName
        {
            get { return _memberName; }
            set { _memberName = value; }
        }
        public bool IsAdmin
        {
            get
            {
                if (Properties[(int)enumUserProperties.IsAdmin] == null)
                    return false;
                else
                    return bool.Parse(Properties[(int)enumUserProperties.IsAdmin].ToString());
            }
            set { Properties[(int)enumUserProperties.IsAdmin] = value.ToString(); }
        }
        public string EmployeeID
        {
            get
            {
                return Properties[(int)enumUserProperties.EmployeeID];
            }
            set { Properties[(int)enumUserProperties.EmployeeID] = value; }
        }
    }
    public class UserGroup : Member
    {
        public UserGroup()
        {
            this.MemberType = (int)enumMemberType.Group;
        }
        public UserGroup(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public UserGroup(Member mb)
        {
            if (mb != null)
            {
                this._memberID = mb.MemberID;
                this._memberName = mb.MemberName;
                this._description = mb.Description;
                this.MemberType = mb.MemberType;
                this.Properties = mb.Properties;
            }
        }
    }

    public class MemberProperty : BaseClass
    {
        //Members member = new Members();
        public MemberProperty()
        { }

        public MemberProperty(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("MemberID", reader)) _memberID = reader.GetString(reader.GetOrdinal("MemberID"));
            if (!isNull("PropertyID", reader)) _propertyID = reader.GetByte(reader.GetOrdinal("PropertyID"));
            if (!isNull("PropertyValue", reader)) _propertyValue = reader.GetString(reader.GetOrdinal("PropertyValue"));
        }

        protected string _memberID;
        public string MemberID
        {
            get { return _memberID; }
            set { _memberID = value; }
        }

        protected byte _propertyID;
        public byte PropertyID
        {
            get { return _propertyID; }
            set { _propertyID = value; }
        }

        protected string _propertyValue;
        public string PropertyValue
        {
            get { return _propertyValue; }
            set { _propertyValue = value; }
        }
    }
    public enum enumMemberType { Group = 1, User }

    public enum enumUserProperties { Password, IsAdmin, EmployeeID }
}
