using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows;

namespace VNS.ERP.GUI
{
    public partial class UCAccountClassificationType : EditControlBase
    {
        public UCAccountClassificationType()
        {
            InitializeComponent();
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtAccountClassificationTypeCode.Text = (dataSource as AccountClassificationType).ClassificationTypeCode;
                this.txtAccountClassificationTypeName.Text = (dataSource as AccountClassificationType).ClassificationTypeName;
                this.txtDescription.Text = (dataSource as AccountClassificationType).Description;
            }
        }
        protected override int ValidateData()
        {
            if (this.txtAccountClassificationTypeCode.Text == string.Empty)
            {
                this.txtAccountClassificationTypeCode.Focus();
                return -1;
            }
            if (this.txtAccountClassificationTypeName.Text == string.Empty)
            {
                this.txtAccountClassificationTypeName.Focus();
                return -2;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new AccountClassificationType();
            (dataSource as AccountClassificationType).ClassificationTypeCode = this.txtAccountClassificationTypeCode.Text;
            (dataSource as AccountClassificationType).ClassificationTypeName = this.txtAccountClassificationTypeName.Text;
            (dataSource as AccountClassificationType).Description = this.txtDescription.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtAccountClassificationTypeCode.Properties.ReadOnly = false;
                this.txtAccountClassificationTypeName.Properties.ReadOnly = false;
                this.txtDescription.ReadOnly = false;
                this.txtAccountClassificationTypeCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtAccountClassificationTypeCode.Properties.ReadOnly = true;
                this.txtAccountClassificationTypeName.Properties.ReadOnly = false;
                this.txtDescription.ReadOnly = false;
                this.txtAccountClassificationTypeName.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
            {

                this.txtAccountClassificationTypeCode.Properties.ReadOnly = true;
                this.txtAccountClassificationTypeName.Properties.ReadOnly = true;
                this.txtDescription.ReadOnly = true;
            }
            base.RefreshControl();
        }

    }
}
