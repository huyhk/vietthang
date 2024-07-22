using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;

namespace VNS.Security
{
    public class Member:UserTracking
    {
        public enum enumMemberType { USER, USERGROUP}
        public Member()
        { }
        public override void CopyFrom(object obj)
        {
            base.CopyFrom(obj);

            memberID = (obj as Member).memberID;
            memberName = (obj as Member).memberName;
            memberType = (obj as Member).memberType;
            description = (obj as Member).description;

            property = this.CloneDictionary((obj as Member).property) as Dictionary<string, string>;
        }
        public Member(System.Data.IDataReader reader)
        {
            FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("MemberID", reader)) memberID = reader.GetString(reader.GetOrdinal("MemberID"));
                if (!isNull("MemberName", reader)) memberName = reader.GetString(reader.GetOrdinal("MemberName"));
                if (!isNull("MemberType", reader)) memberType = reader.GetString(reader.GetOrdinal("MemberType"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(System.Data.DataRow row)
        {
            base.FromDataRow(row);
            if (!row.IsNull("MemberID")) memberID = (string)row["MemberID"];
            if (!row.IsNull("MemberName")) memberName = (string)row["MemberName"];
            if (!row.IsNull("MemberType")) memberType = (string)row["MemberType"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        public void LoadPropertyFromDataRow(System.Data.DataRow row)
        {
            if (!row.IsNull("PropertyValue"))
            {
                property.Add(row["PropertyID"].ToString(), row["PropertyValue"].ToString());
            }
        }
        protected string memberID =string.Empty;
        public string MemberID
        {
            get { return memberID; }
            set { memberID= value; }
        }

        protected string memberName = string.Empty;
        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        protected string memberType = string.Empty;
        public string MemberType
        {
            get { return memberType; }
            set { memberType = value; }
        }

        protected string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        protected Dictionary<string, string> property = new Dictionary<string, string>();
        public Dictionary<string, string> Property
        {
            get { return property; }
            set { property = value; }
        }
    }

    public class User : Member
    {
        public User()
        {
            MemberType = User.enumMemberType.USER.ToString();
        }
        public enum enumPropertyID { PASSWORD}
        public string LoginName
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public string UserName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        public string Password
        {
            get
            {
                if (Property.ContainsKey(User.enumPropertyID.PASSWORD.ToString()))
                    return Crypto.DecryptString(Property[User.enumPropertyID.PASSWORD.ToString()]);
                else
                    return string.Empty;
            }
            set
            {
                if (Property.ContainsKey(User.enumPropertyID.PASSWORD.ToString()))
                    Property[User.enumPropertyID.PASSWORD.ToString()] = Crypto.EncryptString(value);
                else
                    Property.Add(User.enumPropertyID.PASSWORD.ToString(), Crypto.EncryptString(value));
            }
        }

    }

    public class UserGroup : Member
    {
        public UserGroup()
        {
            MemberType = Member.enumMemberType.USERGROUP.ToString();
        }
        public override void CopyFrom(object obj)
        {
            base.CopyFrom(obj);

            listMember = (obj as UserGroup).listMember.Clone() as ListBase<Member>;
        }
        private ListBase<Member> listMember;
        public ListBase<Member> ListMember
        {
            get { return listMember; }
            set { listMember = value; }
        }
    }
}
