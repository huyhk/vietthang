using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data.Accounting;
using VNS.Windows;

namespace VNS.ERP.GUI.UserControls
{
    public partial class UCCongtrinh : EditControlBase
    {
        public UCCongtrinh()
        {
            InitializeComponent();
        }

        protected override int ValidateData()
        {
            if (this.txtCongtrinhCode.Text == string.Empty)
            {
                this.txtCongtrinhCode.Focus();
                return -1;
            }

            return 0;
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtCongtrinhCode.Text = (dataSource as Congtrinh).CongtrinhCode;
                this.txtCongtrinhName.Text = (dataSource as Congtrinh).CongtrinhName;

                this.txtDescription.Text = (dataSource as Congtrinh).Description;

            }

            base.BindData();
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Congtrinh();
            (dataSource as Congtrinh).CongtrinhCode = this.txtCongtrinhCode.Text;
            (dataSource as Congtrinh).CongtrinhName = this.txtCongtrinhName.Text;
            (dataSource as Congtrinh).Description = this.txtDescription.Text;

            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtCongtrinhCode.Properties.ReadOnly = false;
                this.txtCongtrinhName.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtCongtrinhCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtCongtrinhCode.Properties.ReadOnly = true;
                this.txtCongtrinhName.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtCongtrinhName.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
            {
                this.txtCongtrinhCode.Properties.ReadOnly = true;
                this.txtCongtrinhName.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }
    }
}
