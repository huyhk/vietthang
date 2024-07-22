using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;

namespace VNS.UserManagement.Data
{
    /// <summary>
    /// the class to manage the privilege of a MemberID to access a FunctionID
    /// </summary>
    public class MemberFunction:ObjectBase
    {
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("FunctionID", reader)) functionID = reader.GetString(reader.GetOrdinal("FunctionID"));
                if (!isNull("MemberID", reader)) memberID = reader.GetString(reader.GetOrdinal("MemberID"));
                if (!isNull("AllowView", reader)) allowView = reader.GetBoolean(reader.GetOrdinal("AllowView"));
                if (!isNull("AllowAdd", reader)) allowAdd = reader.GetBoolean(reader.GetOrdinal("AllowAdd"));
                if (!isNull("AllowEdit", reader)) allowEdit = reader.GetBoolean(reader.GetOrdinal("AllowEdit"));
                if (!isNull("AllowDelete", reader)) allowDelete = reader.GetBoolean(reader.GetOrdinal("AllowDelete"));
            }
        }
        private string functionID = string.Empty;
        public string FunctionID
        {
            get { return functionID; }
            set { functionID = value; }
        }

        private string memberID = string.Empty;
        public string MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        private bool allowView = false;
        public bool AllowView
        {
            get { return allowView; }
            set { allowView = value; }
        }

        private bool allowAdd = false;
        public bool AllowAdd
        {
            get { return allowAdd; }
            set
            {
                allowAdd = value;
                allowView = allowView || allowAdd;
            }
        }

        private bool allowEdit = false;
        public bool AllowEdit
        {
            get { return allowEdit; }
            set
            {
                allowEdit = value;
                allowView = allowView || allowEdit;
            }
        }

        private bool allowDelete = false;
        public bool AllowDelete
        {
            get { return allowDelete; }
            set
            {
                allowDelete = value;
                allowView = allowView || allowDelete;
            }
        }
    }
    /// <summary>
    /// the combination of Function and MemberFunction 
    /// </summary>
    public class MemberFunctionEdit:MemberFunction
    {
        private string moduleID = string.Empty;
        public string ModuleID
        {
            get { return moduleID; }
            set { moduleID = value; }
        }

        private string groupID = string.Empty;
        public string GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private bool canAdd = false;
        public bool CanAdd
        {
            get { return canAdd; }
            set { canAdd = value; }
        }

        private bool canEdit = false;
        public bool CanEdit
        {
            get { return canEdit; }
            set { canEdit = value; }
        }

        private bool canDelete = false;
        public bool CanDelete
        {
            get { return canDelete; }
            set { canDelete = value; }
        }

        private int functionOrder = 0;
        public int FunctionOrder
        {
            get { return functionOrder; }
            set { functionOrder = value; }
        }
 
    }
}
