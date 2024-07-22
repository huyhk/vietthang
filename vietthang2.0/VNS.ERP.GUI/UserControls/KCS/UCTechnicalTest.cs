using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.Windows;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;

namespace VNS.ERP.GUI
{
    public partial class UCTechnicalTest : EditControlBase
    {
        public UCTechnicalTest()
        {
            InitializeComponent();
        }

        protected override void BindData()
        {
            base.BindData();
            this.txtTechCode.Text = (dataSource as TechnicalTest).TechCode;
            this.txtTechName.Text = (dataSource as TechnicalTest).TechName;
            this.lookUpResultType.EditValue = (dataSource as TechnicalTest).ResultType;
            this.txtDescription.Text = (dataSource as TechnicalTest).Description;
            this.chkKCSTest.Checked = (dataSource as TechnicalTest).KCSTest;
            this.chkPTNTest.Checked = (dataSource as TechnicalTest).PTNTest;
            this.txtThutu.EditValue = (dataSource as TechnicalTest).OrderBy;
            this.txtDisplayText.EditValue = (dataSource as TechnicalTest).DisplayText;
        }

        protected override void AssignData()
        {
            (dataSource as TechnicalTest).TechCode = this.txtTechCode.Text;
            (dataSource as TechnicalTest).TechName = this.txtTechName.Text;
            (dataSource as TechnicalTest).ResultType = this.lookUpResultType.EditValue.ToString();
            (dataSource as TechnicalTest).Description = this.txtDescription.Text;
            (dataSource as TechnicalTest).KCSTest = this.chkKCSTest.Checked;
            (dataSource as TechnicalTest).PTNTest = this.chkPTNTest.Checked;
            (dataSource as TechnicalTest).OrderBy = int.Parse(this.txtThutu.EditValue.ToString());
            (dataSource as TechnicalTest).DisplayText = this.txtDisplayText.EditValue.ToString();
            base.AssignData();
        }

        protected override int ValidateData()
        {
            if (this.txtTechCode.Text == String.Empty)
            {
                this.txtTechCode.Focus();
                return -1;
            }
            if (this.txtTechName.Text == String.Empty)
            {
                this.txtTechName.Focus();
                return -2;
            }
            if (this.lookUpResultType.EditValue.ToString() == "")
            {
                this.lookUpResultType.Focus();
                return -3;
            }
            if (int.Parse(this.txtThutu.EditValue.ToString()) <= 0)
            {
                return -4;
            }
            return 0;
        }

        public void SetDataSourceForLookUpEdit()
        {
            lookUpResultType.Properties.DataSource = EnumDisplays.GetListenumResultTypeTechnicalTest();
            lookUpResultType.Properties.DisplayMember = "EnumText";
            lookUpResultType.Properties.ValueMember = "EnumName";
            lookUpResultType.ItemIndex = 0;
        }

        public override void RefreshControl()
        {
            bool viewMode = this.EditMode == FormEditMode.VIEW;
            txtTechCode.Properties.ReadOnly = this.EditMode != FormEditMode.ADD;
            txtDescription.Properties.ReadOnly = viewMode;
            txtTechName.Properties.ReadOnly = viewMode;
            lookUpResultType.Properties.ReadOnly = viewMode;
            chkKCSTest.Properties.ReadOnly = viewMode;
            chkPTNTest.Properties.ReadOnly = viewMode;
            this.txtDisplayText.Properties.ReadOnly = viewMode;
            this.txtThutu.Properties.ReadOnly = viewMode;
            if (editMode == FormEditMode.ADD)
            {
                txtTechCode.Focus();
            }
            if (editMode == FormEditMode.EDIT)
            {
                txtTechName.Focus();
            }
            if (this.DataSource == null)
            {
                txtTechCode.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtTechName.Text = string.Empty;
                chkKCSTest.Checked = false;
                chkKCSTest.Checked = false;
            }
            base.RefreshControl();
        }

        
    }
}
