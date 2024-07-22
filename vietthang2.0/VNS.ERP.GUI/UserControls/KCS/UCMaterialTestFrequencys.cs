using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.KCS;
using VNS.Windows;
using VNS.Common;

namespace VNS.ERP.GUI
{
    public partial class UCMaterialTestFrequencys : EditControlBase
    {
        private string itemCode = "";
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        public UCMaterialTestFrequencys()
        {
            InitializeComponent();
            //this.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //this.txtQuantity.Properties.Mask.EditMask = AppConfigs.CONFIG_QUANTITYMASK;
            //this.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        protected override void BindData()
        {
            if (DataSource != null)
            {
                MaterialTestFrequencys materialTestFrequencys = (DataSource as MaterialTestFrequencys);
                this.dateEditStartDate.EditValue = materialTestFrequencys.StartDate;
                //this.txtItemCode.EditValue = materialTestFrequencys.ItemCode;
                this.lookUpTechnic.EditValue = materialTestFrequencys.TechCode;
                this.txtQuantity.EditValue = materialTestFrequencys.Quantity;
                this.txtDescription.EditValue = materialTestFrequencys.Description;
                this.lookUpFrequencyType.EditValue = materialTestFrequencys.FrequencyType;
                this.txtQuantityLocal.EditValue = materialTestFrequencys.QuantityLocal;
            }
            base.BindData();
        }
        public void SetDss()
        {
            //Enum t=new enumFrequencyType();
            //ListBase<Enum> list = EnumDisplays.GetListenumFrequencyType();
            //Enum e = list.Search("EnumText", enumFrequencyType.Block.ToString());
            //if (e != null)
            //{
            //    list.Remove(list.IndexOf(e));
            //}
            lookUpFrequencyType.Properties.DataSource =  EnumDisplays.GetListenumFrequencyType_Material();
            //lookUpFrequencyType.Properties.DataSource = list;
            lookUpFrequencyType.Properties.DisplayMember = "EnumText";
            lookUpFrequencyType.Properties.ValueMember = "EnumName";

            lookUpTechnic.Properties.DataSource = new TechnicalTestBLL().GetAll();
            lookUpTechnic.Properties.DisplayMember = "TechName";
            lookUpTechnic.Properties.ValueMember = "TechCode";
        }
        protected override void AssignData()
        {
            if (DataSource == null) DataSource = new MaterialTestFrequencys();
            MaterialTestFrequencys materialTestFrequencys = (DataSource as MaterialTestFrequencys);

            if (this.EditMode == FormEditMode.ADD)
            {
                materialTestFrequencys.UserCreated = Contexts.CurrentUser.LoginName;
                materialTestFrequencys.DateCreated = DateTime.Now;
            }
            materialTestFrequencys.UserUpdated = Contexts.CurrentUser.LoginName;
            materialTestFrequencys.DateUpdated = DateTime.Now;
            materialTestFrequencys.ItemCode = this.ItemCode;
            materialTestFrequencys.StartDate = dateEditStartDate.DateTime.Date;
            materialTestFrequencys.Quantity = Convert.ToDecimal(txtQuantity.EditValue);
            materialTestFrequencys.TechCode =this.lookUpTechnic.EditValue.ToString();
            materialTestFrequencys.Description = txtDescription.Text;
            materialTestFrequencys.FrequencyType = lookUpFrequencyType.EditValue.ToString();
            materialTestFrequencys.QuantityLocal = Convert.ToDecimal(txtQuantityLocal.EditValue);
            base.AssignData();
        }

        protected override int ValidateData()
        {
            txtDescription.Text = txtDescription.Text.Trim();
            if (lookUpTechnic.EditValue.ToString() == "")
            {
                lookUpTechnic.Focus();
                return -2;
            }

            if (lookUpFrequencyType.EditValue.ToString() == "")
            {
                lookUpFrequencyType.Focus();
                return -1;
            }
       
            return base.ValidateData();
        }

        public override void RefreshControl()
        {
            if (this.EditMode == FormEditMode.ADD)
            {
                this.lookUpTechnic.Focus();
            }
            if (this.EditMode == FormEditMode.EDIT)
            {
                this.txtQuantity.Focus();
            }
            dateEditStartDate.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            lookUpFrequencyType.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            lookUpTechnic.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            //txtItemCode.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW || this.EditMode == FormEditMode.EDIT;
            txtDescription.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtQuantity.Properties.ReadOnly = this.EditMode == FormEditMode.VIEW;
            txtQuantityLocal.Properties.ReadOnly = this.editMode == FormEditMode.VIEW;
            base.RefreshControl();
        }

    
    }
}
