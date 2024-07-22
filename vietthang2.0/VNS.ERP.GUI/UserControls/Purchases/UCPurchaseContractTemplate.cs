using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Purchases;
using VNS.Windows;
using VNS.Common;
using System.Runtime.Remoting.Contexts;
using System.Collections;

namespace VNS.ERP.GUI
{
    public partial class UCPurchaseContractTemplate : VNS.Windows.Controls.EditControlBase
    {
        PurchaseContractTemplate pc = null;
        public UCPurchaseContractTemplate()
        {
            InitializeComponent();
            this.SetTextCode(this.txtTemplateCode);
        }

        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                pc = (this.DataSource as PurchaseContractTemplate);
                this.txtTemplateCode.Text = pc.TemplateCode;
                this.txtTemplateName.Text = pc.TemplateName;
                this.txtTemplateType.EditValue = pc.TemplateType;
                this.txtTemplateContent.Rtf = pc.TemplateContent;
                this.lookUpItemCode.EditValue = pc.ItemCode;
            }

            base.BindData();
        }
        protected override int ValidateData()
        {
            if (this.txtTemplateCode.Text == string.Empty)
            {
                this.txtTemplateCode.Focus();
                return -1;
            }
            if (this.txtTemplateName.Text == string.Empty)
            {
                this.txtTemplateName.Focus();
                return -2;
            }
            if (this.lookUpItemCode.EditValue.ToString() == string.Empty)
            {
                this.lookUpItemCode.Focus();
                return -3;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new Vendor();
            pc = (this.DataSource as PurchaseContractTemplate);
            pc.TemplateCode = this.txtTemplateCode.Text.ToString();
            pc.TemplateName = this.txtTemplateName.Text.ToString();
            pc.TemplateType = Convert.ToInt32(this.txtTemplateType.EditValue);
            pc.TemplateContent = this.txtTemplateContent.Rtf;
            pc.ItemCode = this.lookUpItemCode.EditValue.ToString();
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtTemplateCode.Properties.ReadOnly = false;
                this.txtTemplateName.Properties.ReadOnly = false;
                this.txtTemplateType.Properties.ReadOnly = false;
                this.txtTemplateContent.ReadOnly = false;
                this.lookUpItemCode.Properties.ReadOnly = false;
                this.txtTemplateCode.Focus();
            }
            if (this.editMode == FormEditMode.EDIT)
            {
                this.txtTemplateCode.Properties.ReadOnly = true;
                this.txtTemplateName.Properties.ReadOnly = false;
                this.txtTemplateType.Properties.ReadOnly = false;
                this.txtTemplateContent.ReadOnly = false;
                this.lookUpItemCode.Properties.ReadOnly = false;
                this.txtTemplateCode.Focus();

            }
            if (this.editMode == FormEditMode.VIEW)
            {
                this.txtTemplateCode.Properties.ReadOnly = true;
                this.txtTemplateName.Properties.ReadOnly = true;
                this.txtTemplateType.Properties.ReadOnly = true;
                this.txtTemplateContent.ReadOnly = true;
                this.lookUpItemCode.Properties.ReadOnly = true;
            }

            if (this.txtTemplateContent.ReadOnly == true)
                this.txtTemplateContent.BackColor = Color.Silver;
            else
                this.txtTemplateContent.BackColor = Color.White;
            base.RefreshControl();
        }

        protected override void InitDataObject()
        {
            base.InitDataObject();
            this.lookUpItemCode.Properties.DataSource = new ItemBLL().GetAll();
        }
    }
}

