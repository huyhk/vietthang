using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class UCSubjectType : EditControlBase
    {
        public UCSubjectType()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtSubjectTypeCode.Text = (dataSource as SubjectType).SubjectTypeCode;
                this.txtSubjectTypeName.Text = (dataSource as SubjectType).SubjectTypeName;
                this.txtDescription.Text = (dataSource as SubjectType).Description;
            }
        }
        protected override int ValidateData()
        {
            if (this.txtSubjectTypeCode.Text == string.Empty)
            {
                this.txtSubjectTypeCode.Focus();
                return -1;
            }
            if (this.txtSubjectTypeName.Text == string.Empty)
            {
                this.txtSubjectTypeName.Focus();
                return -2;
            }
         
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new SubjectType();
            (dataSource as SubjectType).SubjectTypeCode = this.txtSubjectTypeCode.Text;
            (dataSource as SubjectType).SubjectTypeName = this.txtSubjectTypeName.Text;
            (dataSource as SubjectType).Description = this.txtDescription.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtSubjectTypeCode.Properties.ReadOnly = false;
                this.txtSubjectTypeName.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtSubjectTypeCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtSubjectTypeCode.Properties.ReadOnly = true;
                this.txtSubjectTypeName.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtSubjectTypeName.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
            {

                this.txtSubjectTypeCode.Properties.ReadOnly = true;
                this.txtSubjectTypeName.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }


    }
}
